using System;

namespace WMS.LabelController
{
    /// <summary>
    /// 控制器
    /// </summary>
    public class Controller
    {
        private string _ipAddress;

        private uint _port;

        public Controller(string ipAddress, uint port = 8600)
        {
            _ipAddress = ipAddress;
            _port = port;
        }

        public uint Port
        {
            get
            {
                return _port;
            }
        }

        public string IpAddress
        {
            get
            {
                return _ipAddress;
            }
        }

        //public string LabelCode { get; set; }

        public bool Open()
        {
            return ControllerAPI.ConnectController(_ipAddress, _port) && ControllerAPI.IsConnected();
        }

        public bool Close()
        {
            try
            {
                ControllerAPI.DisConnect();
                ControllerAPI.ExitTrans();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //public short ClearAll()
        //{
        //    return ControllerAPI.Trans0Ccmd()
        //    return 0;
        //}

        /// <summary>
        /// 点亮
        /// </summary>
        /// <returns>返回结果：0 表示串口未打开，-1 非正确的ID 号，1表示正确执行</returns>
        public bool On(string lightCode)
        {
            return SendData(lightCode, " ", true);
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="lightCode">通道灯标签编码</param>
        /// <returns></returns>
        public bool Off(string lightCode)
        {
            return Clear(lightCode);
        }

        /// <summary>
        /// 清除当前状态
        /// </summary>
        /// <returns></returns>
        public bool Clear(string labelCode)
        {
            return ControllerAPI.Trans0Ccmd(labelCode);
        }

        /// <summary>
        /// 发送数据给标签
        /// </summary>
        /// <param name="labelCode">标签编码</param>
        /// <param name="data">数据</param>
        /// <param name="isRed">是否为红色灯</param>
        /// <returns>返回结果：0 表示串口未打开，-1 非正确的ID 号，1表示正确执行</returns>
        public bool SendData(string labelCode, string data, bool isRed)
        {
            if (ControllerAPI.IsConnected())
            {
                return ControllerAPI.TransTcmd(labelCode, data, (byte) 'J', 1, 0);
            }
            return false;
        }
        /// <summary>
        /// 发送数据给标签
        /// </summary>
        /// <param name="labelCode">标签编码</param>
        /// <param name="data">数据</param>
        /// <param name="isRed">是否为红色灯</param>
        /// <returns>返回结果：0 表示串口未打开，-1 非正确的ID 号，1表示正确执行</returns>
        public bool SendData(string labelCode, string data, char lightColor)
        {
            if (ControllerAPI.IsConnected())
            {
                bool isOn = lightColor != 'G';
                return ControllerAPI.TransTcmd(labelCode, data, (byte) lightColor, isOn ? (byte) 1 : (byte) 0, 1);
            }
            return false;
        }

        /// <summary>
        /// 发送数据给标签
        /// </summary>
        /// <param name="labelCode">标签编码</param>
        /// <returns></returns>
        public bool TurnOffChannelData(string labelCode)
        {
            return Clear(labelCode);
        }
    }
}
