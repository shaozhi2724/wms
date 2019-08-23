using System;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace WMS.Windows.App
{
    public class WMSLicenseManager
    {
        /// <summary>
        /// 枚举注册文件，注册类型包含:
        /// Demo - 演示版. 不检测计算机ID
        /// NodeLocked - 特定节点注册
        /// </summary>
        public enum LicenseType
        {
            Demo,
            NodeLocked
        }

        /// <summary>
        /// Holds information about a single feature:
        /// A feature is an application part that is licensed. for Example, A flight simulator
        /// without dogfights will be featured as "BASIC" while the dogfight capability will be 
        /// featured as "DOG-FIGHTS"
        /// featureName - The feature's name
        /// timeDepend - is the feature expires
        /// expiration - The feture expiration time
        /// </summary>
        public struct FeatureInfo
        {
            public string featureName;
            public bool timeDepend;
            public DateTime expiration;
            public int maxCount; // 忽略 - 以后使用
        }

        /// <summary>
        /// 注册信息
        /// </summary>
        public struct LicenseInfo
        {
            public LicenseType kind;
            public string computerID;
            public string passCode;
            public FeatureInfo[] features;
        }

        /// <summary>
        /// 返回计算机标识符
        /// </summary>
        /// <returns>计算机ID</returns>
        /// <remarks>
        /// 首先，检测计算机是否具有网卡，如有，获取第一网卡物理地址。
        /// 如果计算机无网卡，使用磁盘卷标
        /// First, this method checks if the computer has a network adapter. If so, it will
        /// extract the physical address of the first network interface.
        /// In case the computer does not a network adapter - it will use the disk label as the 
        /// computer identification
        /// </remarks>
        public static string GetComputerId()
        {
            //return GetOldComputerId();
            return ComputerID.Value();
        }
        public static string GetOldComputerId()
        {
            string result = "";

            // 转换为16进制并以 "-" 分隔
            byte[] byteAddr = StringToByteArray(GetCPUID());
            for (int i = 0; i < byteAddr.Length; i++)
            {
                result += byteAddr[i].ToString("X2");
                if (i != byteAddr.Length - 1)
                {
                    result += "-";
                }
            }

            return result;
        }
        /// <summary>
        /// 获得CPU编号
        /// </summary>
        /// <returns></returns>
        private static string GetCPUID()
        {
            string cpuid = "";
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                cpuid = mo.Properties["ProcessorId"].Value.ToString();
            }
            return cpuid;
        }

        /// <summary>
        /// 获取硬盘序列号
        /// </summary>
        /// <returns></returns>
        private string GetDiskSerialNumber()
        {
            //这种模式在插入一个U盘后可能会有不同的结果，如插入我的手机时
            String HDid = "";
            ManagementClass mc = new ManagementClass("Win32_DiskDrive");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                HDid = (string)mo.Properties["Model"].Value;//SerialNumber
                break;//这名话解决有多个物理盘时产生的问题，只取第一个物理硬盘
            }
            return HDid;

            /*ManagementClass mc = new ManagementClass("Win32_PhysicalMedia");
            ManagementObjectCollection moc = mc.GetInstances();
            string str = "";
            foreach (ManagementObject mo in moc)
            {
                str = mo.Properties["SerialNumber"].Value.ToString();
                break;
            }
            return str;*/
        }

        /// <summary>
        /// 获取网卡硬件地址
        /// </summary>
        /// <returns></returns> 
        private string GetMacAddress()
        {
            string mac = "";
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                if ((bool)mo["IPEnabled"] == true)
                {
                    mac = mo["MacAddress"].ToString();
                    break;
                }
            }
            return mac;
        }

        /// <summary>
        /// 十六进制字符串转Byte数组
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        /// <summary>
        /// 检测注册信息是否有效
        /// </summary>
        /// <param name="licensePath">license 文件全路径</param>
        /// <param name="featureName">要检测的特性名称</param>
        /// <param name="passCode">Passcode - 客户端与服务端通讯令牌</param>
        /// <param name="bThrow">如检测失败，是否抛出异常</param>
        /// <returns></returns>
        public bool IsValid(string licensePath, string featureName, string passCode, bool bThrow)
        {
            string licenseSignature;
            LicenseInfo licenseInformation = GetLicenseFromFile(licensePath, passCode, out licenseSignature);
            licenseInformation.computerID = GetComputerId();
            string signature = CreateSignature(licenseInformation);
            if (signature != licenseSignature)
            {
                if (bThrow)
                {
                    throw (new LicenseException("WMS注册信息不匹配"));
                }
                return false;
            }

            if (licenseInformation.kind == LicenseType.NodeLocked)
            {
                if (licenseInformation.computerID != GetComputerId())
                {
                    if (bThrow)
                    {
                        throw (new LicenseException("WMS已被注册至另一台计算机"));
                    }
                    return false;
                }
            }

            foreach (FeatureInfo feature in licenseInformation.features)
            {
                if (feature.featureName == featureName)
                {
                    if (feature.timeDepend)
                    {
                        if (DateTime.Now > feature.expiration)
                        {
                            if (bThrow)
                            {
                                throw (new LicenseException("WMS已过期"));
                            }
                            return false;
                        }
                    }
                    return true;
                }
            }

            if (bThrow)
            {
                throw (new LicenseException("注册文件错误，请重新导入注册文件！"));
            }
            return false;
        }

        LicenseInfo GetLicenseFromFile(string licensePath, string passCode, out string signature)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(licensePath);
            LicenseInfo licenseInformation;
            licenseInformation.kind =
                (LicenseType)Enum.Parse(
                    typeof(LicenseType),
                    xdoc.DocumentElement["LicenseType"].InnerText,
                    true);
            licenseInformation.computerID = xdoc.DocumentElement["ComputerId"].InnerText;
            licenseInformation.passCode = passCode;
            int nFeatures = xdoc.DocumentElement["Features"].GetElementsByTagName("Feature").Count;
            licenseInformation.features = new FeatureInfo[nFeatures];
            XmlElement elem = (XmlElement)xdoc.DocumentElement["Features"].FirstChild;
            for (int i = 0; i < nFeatures; i++)
            {
                licenseInformation.features[i].featureName = elem.Attributes["Name"].Value;
                licenseInformation.features[i].timeDepend =
                    XmlConvert.ToBoolean(elem.Attributes["IsTimeDepended"].Value);
                if (licenseInformation.features[i].timeDepend)
                {
                    licenseInformation.features[i].expiration =
                        XmlConvert.ToDateTime(
                        elem.Attributes["Expiration"].Value, XmlDateTimeSerializationMode.Local);
                }
                elem = (XmlElement)elem.NextSibling;
            }
            signature = xdoc.DocumentElement["Signature"].InnerText;
            return licenseInformation;
        }

        public string CreateSignature(LicenseInfo licenseInformation)
        {
            SHA384Managed shaM = new SHA384Managed();
            byte[] data;

            MemoryStream ms = new MemoryStream();
            BinaryWriter bw = new BinaryWriter(ms);
            bw.Write((int)licenseInformation.kind);
            if (licenseInformation.kind == LicenseType.NodeLocked)
            {
                bw.Write(licenseInformation.computerID);
            }
            bw.Write(licenseInformation.passCode);
            foreach (FeatureInfo feature in licenseInformation.features)
            {
                bw.Write(feature.featureName);
                bw.Write(feature.timeDepend);
                if (feature.timeDepend)
                {
                    bw.Write(feature.expiration.ToString());
                }
                bw.Write(feature.maxCount);
            }
            int nLen = (int)ms.Position + 1;
            bw.Close();
            ms.Close();
            data = ms.GetBuffer();

            data = shaM.ComputeHash(data, 0, nLen);

            string result = "";
            foreach (byte dbyte in data)
            {
                result += dbyte.ToString("X2");
            }
            return result;
        }


        public class LicenseException : System.Exception
        {
            public LicenseException(string message)
                : base(message)
            {
            }
        }


        /// <summary>
        /// Generates a 16 byte Unique Identification code of a computer
        /// Example: 4876-8DB5-EE85-69D3-FE52-8CF7-395D-2EA9
        /// </summary>
        public class ComputerID
        {
            private static string computerID = string.Empty;

            public static string Value()
            {
                if (string.IsNullOrEmpty(computerID))
                {
                    computerID = GetHash("CPU >> " + CpuId()
                                         + "\nBIOS >> " + BiosId()
                                         + "\nBASE >> " + BaseId()
                                         + "\nDISK >> " + DiskId()
                                         + "\nVIDEO >> " + VideoId()
                                         + "\nMAC >> " + MacId());
                }
                return computerID;
            }

            private static string GetHash(string s)
            {
                MD5 sec = new MD5CryptoServiceProvider();
                ASCIIEncoding enc = new ASCIIEncoding();
                byte[] bt = enc.GetBytes(s);
                return GetHexString(sec.ComputeHash(bt));
            }

            private static string GetHexString(byte[] bt)
            {
                string s = string.Empty;
                for (int i = 0; i < bt.Length; i++)
                {
                    byte b = bt[i];
                    int n, n1, n2;
                    n = (int)b;
                    n1 = n & 15;
                    n2 = (n >> 4) & 15;
                    if (n2 > 9)
                    {
                        s += ((char)(n2 - 10 + (int)'A')).ToString();
                    }
                    else
                    {
                        s += n2.ToString();
                    }
                    if (n1 > 9)
                    {
                        s += ((char)(n1 - 10 + (int)'A')).ToString();
                    }
                    else
                    {
                        s += n1.ToString();
                    }
                    if ((i + 1) != bt.Length && (i + 1) % 2 == 0)
                    {
                        s += "-";
                    }
                }
                return s;
            }

            #region Original Device ID Getting Code

            //Return a hardware identifier
            private static string Identifier(string wmiClass, string wmiProperty, string wmiMustBeTrue)
            {
                string result = "";
                System.Management.ManagementClass mc = new System.Management.ManagementClass(wmiClass);
                System.Management.ManagementObjectCollection moc = mc.GetInstances();
                foreach (System.Management.ManagementObject mo in moc)
                {
                    if (mo[wmiMustBeTrue].ToString() == "True")
                    {
                        //Only get the first one
                        if (result == "")
                        {
                            try
                            {
                                result = mo[wmiProperty].ToString();
                                break;
                            }
                            catch
                            {
                            }
                        }
                    }
                }
                return result;
            }

            //Return a hardware identifier
            private static string Identifier(string wmiClass, string wmiProperty)
            {
                string result = "";
                System.Management.ManagementClass mc = new System.Management.ManagementClass(wmiClass);
                System.Management.ManagementObjectCollection moc = mc.GetInstances();
                foreach (System.Management.ManagementObject mo in moc)
                {
                    //Only get the first one
                    if (result == "")
                    {
                        try
                        {
                            result = mo[wmiProperty].ToString();
                            break;
                        }
                        catch
                        {
                        }
                    }
                }
                return result;
            }

            private static string CpuId()
            {
                //Uses first CPU identifier available in order of preference
                //Don't get all identifiers, as it is very time consuming
                string retVal = Identifier("Win32_Processor", "UniqueId");
                if (retVal == "") //If no UniqueID, use ProcessorID
                {
                    retVal = Identifier("Win32_Processor", "ProcessorId");
                    if (retVal == "") //If no ProcessorId, use Name
                    {
                        retVal = Identifier("Win32_Processor", "Name");
                        if (retVal == "") //If no Name, use Manufacturer
                        {
                            retVal = Identifier("Win32_Processor", "Manufacturer");
                        }
                        //Add clock speed for extra security
                        retVal += Identifier("Win32_Processor", "MaxClockSpeed");
                    }
                }
                return retVal;
            }

            //BIOS Identifier
            private static string BiosId()
            {
                return Identifier("Win32_BIOS", "Manufacturer")
                       + Identifier("Win32_BIOS", "SMBIOSBIOSVersion")
                       + Identifier("Win32_BIOS", "IdentificationCode")
                       + Identifier("Win32_BIOS", "SerialNumber")
                       + Identifier("Win32_BIOS", "ReleaseDate")
                       + Identifier("Win32_BIOS", "Version");
            }

            //Main physical hard drive ID
            private static string DiskId()
            {
                return Identifier("Win32_DiskDrive", "Model")
                       + Identifier("Win32_DiskDrive", "Manufacturer")
                       + Identifier("Win32_DiskDrive", "Signature")
                       + Identifier("Win32_DiskDrive", "TotalHeads");
            }

            //Motherboard ID
            private static string BaseId()
            {
                return Identifier("Win32_BaseBoard", "Model")
                       + Identifier("Win32_BaseBoard", "Manufacturer")
                       + Identifier("Win32_BaseBoard", "Name")
                       + Identifier("Win32_BaseBoard", "SerialNumber");
            }

            //Primary video controller ID
            private static string VideoId()
            {
                return Identifier("Win32_VideoController", "DriverVersion")
                       + Identifier("Win32_VideoController", "Name");
            }

            //First enabled network card ID
            private static string MacId()
            {
                return Identifier("Win32_NetworkAdapterConfiguration",
                    "MACAddress", "IPEnabled");
            }

            #endregion
        }
    }
}
