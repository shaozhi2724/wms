using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using WMS.Model;

namespace WMS.Windows.App
{
    static class Program
    {
        static readonly string _licensePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "WMS.lic");
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-CN");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MessageBoxEx.UseSystemLocalizedString = true;
            MessageBoxEx.EnableGlass = false;
            Updater.UpdateUpdater();

            string featureName = "WMS";
            string passCode = "bokesys.com";
            bool isThrowLicenseException = true;
            int licenseCheckTimes = 0;
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                MessageBoxEx.Show("本程序已经在运行了，请不要重复运行！");
                Environment.Exit(1);
            }
            else
            {
                /*if (!File.Exists(_licensePath))
                {
                    //DQS还未注册，请联系
                    if (DialogResult.OK ==
                        MessageBoxEx.Show("WMS还未注册，请联系软件提供商并提供注册标识", "系统错误", MessageBoxButtons.OK,
                            MessageBoxIcon.Error))
                    {
                        licenseCheckTimes += 1;
                        CheckLicense(featureName, passCode, isThrowLicenseException, licenseCheckTimes);
                    }
                }
                else
                {
                    licenseCheckTimes += 1;
                    bool isValid = false;
                    try
                    {
                        isValid = new WMSLicenseManager().IsValid(_licensePath,
                            featureName,
                            passCode,
                            isThrowLicenseException);
                    }
                    catch(Exception ex)
                    {
                        if(ex is WMSLicenseManager.LicenseException)
                        {
                            CheckLicense(featureName, passCode, isThrowLicenseException, licenseCheckTimes);
                        }
                        else
                        {
                            MessageBoxEx.Show(ex.Message,
                                              "系统错误",
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Error);
                        }
                    }*/
                    /*if(isValid)
                    {*/
                        Application.Run(new FrmLogin());
                        if(IsLoginIn)
                        {
                            Application.Run(new FrmMain());
                        }
                    /*}
                }*/
            }
        }

        private static void CheckLicense(string featureName, string passCode, bool isThrowLicenseException,
            int licenseCheckTimes)
        {

            if (licenseCheckTimes == 4)
            {
                MessageBoxEx.Show("注册文件检测超过三次，系统将自动退出！", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                if (DialogResult.OK == new FrmLicenserIdentification().ShowDialog())
                {
                    licenseCheckTimes += 1;
                    try
                    {
                        bool isValid = new WMSLicenseManager().IsValid(_licensePath,
                            featureName,
                            passCode,
                            isThrowLicenseException);
                        if (isValid)
                        {
                            Application.Run(new FrmLogin());
                            if (IsLoginIn)
                            {
                                Application.Run(new FrmMain());
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        if (ex is WMSLicenseManager.LicenseException)
                        {
                            CheckLicense(featureName, passCode, isThrowLicenseException, licenseCheckTimes);
                        }
                    }
                }
            }

        }

        public static bool IsLoginIn { get; set; }

        public static WMSUser CurrentUser { get; set; }


        /// <summary>
        /// 主板编号
        /// </summary>
        /// <returns></returns>
        public static string GetBoardID()
        {
            string st = "";
            ManagementObjectSearcher mos = new ManagementObjectSearcher("Select * from Win32_BaseBoard");
            foreach(ManagementObject mo in mos.Get())
            {
                st = mo["SerialNumber"].ToString();
            }
            return st;
        }

        /// <summary>
        /// 当前计算机是否允许出入库监控
        /// </summary>
        /// <returns></returns>
        public static bool CurrentComputerAllowMonitoring()
        {
            using (var db = new WMSContext())
            {
                string computerId = GetBoardID();
                var currentMonitComputer = db.WMSMonitoringSettings.ToList().LastOrDefault();
                if (null != currentMonitComputer)
                {
                    return currentMonitComputer.ComputerId == computerId;
                }
            }
            return false;
        }
    }
}