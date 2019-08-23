using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Globalization;

namespace WMS.SmartDevice.App.Utils
{
    public class DeviceHelper
    {
        /*
HRESULT GetDeviceUniqueID(
  LPBYTE pbApplicationData,
  DWORD cbApplictionData,
  DWORD dwDeviceIDVersion,
  LPBYTE pbDeviceIDOutput,
  DWORD* pcbDeviceIDOutput
);
*/
        [DllImport("coredll.dll")]
        private extern static int GetDeviceUniqueID([In, Out] byte[] appdata,
                                                    int cbApplictionData,
                                                    int dwDeviceIDVersion,
                                                    [In, Out] byte[] deviceIDOuput,
                                                    out uint pcbDeviceIDOutput);
        /// <summary>
        /// 获取设备ID
        /// </summary>
        /// <returns></returns>
        public static string GetDeviceId()
        {
            byte[] buffer = GetDeviceID("MyAppString");
            StringBuilder sb = new StringBuilder();
            for (int x = 0; x < buffer.Length; x++)
            {
                sb.Append(string.Format("{0:x2}", buffer[x]));
            }
            return sb.ToString().ToUpper();
        }


        private static byte[] GetDeviceID(string AppString)
        {
            byte[] AppData = new byte[AppString.Length];
            for (int count = 0; count < AppString.Length; count++)
            {
                AppData[count] = (byte)AppString[count];
            }
            int appDataSize = AppData.Length;
            byte[] DeviceOutput = new byte[20];
            uint SizeOut = 20;
            GetDeviceUniqueID(AppData, appDataSize, 1, DeviceOutput, out SizeOut);
            return DeviceOutput;
        }

        [DllImport("coredll.dll", EntryPoint = "KernelIoControl", SetLastError = true)]
        private extern static bool KernelIoControl(Int32 IoControlCode, IntPtr InputBuffer, Int32 InputBufferSize, byte[] OutputBuffer, Int32 OutputBufferSize, ref Int32 BytesReturned);

        private static Int32 FILE_DEVICE_HAL = 0x00000101;
        private static Int32 IOCTL_HAL_GET_DEVICEID = ((FILE_DEVICE_HAL) << 16) | ((0x0) << 14) | ((21) << 2) | (0x0);


        public string GetPDASerialNumber()
        {
            byte[] outputBuffer = new byte[256];
            Int32 outputBufferSize = outputBuffer.Length;
            Int32 bytesReturned = 0;

            bool retVal = KernelIoControl(IOCTL_HAL_GET_DEVICEID, IntPtr.Zero, 0, outputBuffer, outputBufferSize, ref bytesReturned);

            // If the request failed, exit the method now
            if (retVal == false)
            {
                return String.Empty;
            }

            Int32 presetIdOffset = BitConverter.ToInt32(outputBuffer, 4);
            Int32 platformIdOffset = BitConverter.ToInt32(outputBuffer, 0xc);
            Int32 platformIdSize = BitConverter.ToInt32(outputBuffer, 0x10);

            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format(CultureInfo.InvariantCulture, "{0:X8}-{1:X4}-{2:X4}-{3:X4}-",
                BitConverter.ToInt32(outputBuffer, presetIdOffset),
                BitConverter.ToInt16(outputBuffer, presetIdOffset + 4),
                BitConverter.ToInt16(outputBuffer, presetIdOffset + 6),
                BitConverter.ToInt16(outputBuffer, presetIdOffset + 8)));

            for (int i = platformIdOffset; i < platformIdOffset + platformIdSize; i++)
            {
                sb.Append(String.Format(CultureInfo.InvariantCulture, "{0:X2}", outputBuffer[i]));
            }

            // return the device id string
            return sb.ToString();
        }
    }
}
