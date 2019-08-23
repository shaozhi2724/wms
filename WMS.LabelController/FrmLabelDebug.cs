using System;
using System.ComponentModel;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WMS.LabelController
{
    public partial class FrmLabelDebug : Form
    {
        private Controller _controller;
        public FrmLabelDebug()
        {
            InitializeComponent();

        }

        private void FrmLabelDebug_Load(object sender, EventArgs e)
        {
            
        }

        //wParam 0/1,表示:已断开/连接上
        //lparam 未使用
        private void OnConnected(IntPtr wParam, IntPtr lParam)
        {
            if (wParam.ToInt32() == 1)
            {
                btnClose.Text = "断开";
            }
            else if (wParam.ToInt32() == 0)
            {
                btnClose.Enabled = false;
            }
        }
        //lparam:字符串起始地址
        //wparam:字符串数据长度
        private void OnRecvData(IntPtr wParam, IntPtr lParam)
        {

            byte[] byteArray = new byte[wParam.ToInt32()];
            System.Runtime.InteropServices.Marshal.Copy(lParam, byteArray, 0, wParam.ToInt32());
            string logs = System.Text.ASCIIEncoding.ASCII.GetString(byteArray);

            //textBox4.Text += "\n";
            //textBox4.Text += s;

            if (logs.Contains("NewData"))
                ControllerAPI.GetData();

            String response = logs.Substring(0, 1);
            if (response == "Q" || response == "G")
                ControllerAPI.RecvOK();
            this.WriteLineLogs(logs);
        }
        protected override void DefWndProc(ref System.Windows.Forms.Message m)
        {
            switch (m.Msg)
            {
                case ControllerAPI.DATA_RECV:
                    OnRecvData(m.WParam, m.LParam);
                    break;
                case ControllerAPI.PC_CONN:
                    OnConnected(m.WParam, m.LParam);
                    break;
                //      处理的代码
                default:
                    base.DefWndProc(ref m);///调用基类函数处理非自定义消息。
                    break;
            }
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {

            ControllerAPI.InitializeTrans();
            ControllerAPI.SetMessageHandler(this.Handle);

            var ipAddress = txtIP.Text.Trim();
            var port = uint.Parse(txtPort.Text.Trim());
            _controller = new Controller(ipAddress, port);
            bool isOpenSucceed = _controller.Open();
            if (isOpenSucceed)
            {
                btnOpen.Enabled = false;
                btnClose.Enabled = true;
                txtPort.Enabled = false;
                txtIP.Enabled = false;
                WinMessage.ShowInformation(String.Format("控制器{0}已打开并连接", ipAddress));
            }
            else
            {
                WinMessage.ShowError(String.Format("未能打开{0}，请联系管理员！", ipAddress));
            }
            /*if (!labController.bPortOpened)
            {
                short portNumber = Convert.ToInt16(cbbPortName.Text.ToUpper().Replace("COM", ""));
                bool result = labController.OpenComPort(portNumber);
                if (result)
                {
                    btnOpen.Enabled = false;
                    btnClose.Enabled = true;
                    cbbPortName.Enabled = false;
                }
                else
                {
                    WinMessage.ShowError(String.Format("未能打开端口{0}，请联系管理员！", cbbPortName.Text));
                }
            }*/
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            bool isClosed = _controller.Close();
            ControllerAPI.ExitTrans();
            if (isClosed)
            {
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
                txtIP.Enabled = true;
                txtPort.Enabled = true;
            }
            else
            {
                WinMessage.ShowWarning(String.Format("未能控制器-{0}，请联系管理员！", _controller.IpAddress));
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtLogs.Clear();
        }

/*

        private void labController_OnData(object sender, __KDLabOCX_OnDataEvent e)
        {
            string data = e.data;
            short cmd = 0;
            bool bCCOK = false;
            short labState = 52;
            short labColor = 0;
            string result = labController.DataAnalysis(data, ref cmd, ref bCCOK, ref labState, ref labColor);

            string labStateStr = string.Empty;
            if (labState == 49)
            {
                labStateStr = "空闲";
            }
            if (labState == 52)
            {
                labStateStr = "工作已完成";
            }
            if (labState == 50)
            {
                labStateStr = "正在工作";
            }
            string logs = String.Format("返回地址：{0}。返回数据：{1}标签状态：{2}", e.iD, result, labStateStr);
            this.WriteLineLogs(logs);
        }
*/

        private void btnLightControl_Click(object sender, EventArgs e)
        {
            var result = false;
            string id = txtLightID.Text.Trim();
            if (rdbLightOn.Checked)
            {
                result = _controller.On(id);
            }
            else
            {
                result = _controller.Off(id);
            }
            string logs = FrmLabelDebug.ValidateResult(result);
            this.WriteLineLogs(logs);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string id = txtLabelID.Text.Trim();
            string data = txtLabelData.Text.Trim();
            char lightColor = 'G';
            if (rdbRed.Checked)
            {
                lightColor = 'J';
            }
            if (rdbGreen.Checked)
            {
                lightColor = 'L';
            }
            if (rdbBlue.Checked)
            {
                lightColor = 'K';
            }
            var result = _controller.SendData(id, data, lightColor);
            string logs = FrmLabelDebug.ValidateResult(result);
            this.WriteLineLogs(logs);
        }

        private void btnModifyID_Click(object sender, EventArgs e)
        {
            string oldID = txtCommonID.Text.Trim();
            if (FrmLabelDebug.ValidateID(oldID))
            {
                using (FrmModifyID editor = new FrmModifyID(oldID))
                {
                    DialogResult dr = editor.ShowDialog(this);
                    if (dr == DialogResult.OK)
                    {
                        string newID = editor.NewID;
                        int result = ControllerAPI.TransPcmd(oldID, newID);
                        string logs = FrmLabelDebug.ValidateResult(result);
                        this.WriteLineLogs(logs);
                    }
                }
            }
            else
            {
                WinMessage.ShowInformation("ID号必须是4位有效数字。");
            }
        }

        private void btnClearCurrent_Click(object sender, EventArgs e)
        {
            if (!ControllerAPI.IsConnected())
            {
                WinMessage.ShowError("未成功连接至控制器，请先连接！");
                return;
            }
            string id = txtCommonID.Text.Trim();

            if (FrmLabelDebug.ValidateID(id))
            {
                var result = _controller.Clear(id);
                string logs = FrmLabelDebug.ValidateResult(result);
                this.WriteLineLogs(logs);
            }
        }

        private void btnDisplayAllID_Click(object sender, EventArgs e)
        {
            int result = ControllerAPI.TransIDcmd();
            string logs = FrmLabelDebug.ValidateResult(result);
            this.WriteLineLogs(logs);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (!ControllerAPI.IsConnected())
            {
                WinMessage.ShowError("未成功连接至控制器，请先连接！");
                return;
            }
            int result = ControllerAPI.TransQueryConfigCmd(3, "T");

            string logs = FrmLabelDebug.ValidateResult(result);
            this.WriteLineLogs(logs);
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private static string ValidateResult(int result)
        {
            switch (result)
            {
                case 1:
                    return "返回结果：操作成功。";
                case 0:
                    return "返回结果：通讯串口未打开。";
                case -1:
                    return "返回结果：不是正确的ID号。";
                default:
                    return "返回结果：操作成功。";
            }
        }

        private static string ValidateResult(bool result)
        {
            return result?"返回结果：操作成功。":"返回结果：通讯串口未打开。";
        }

        /// <summary>
        /// 验证ID号是不是4位有效数字
        /// </summary>
        /// <param name="id">ID号</param>
        /// <returns></returns>
        private static bool ValidateID(string id)
        {
            if (Regex.IsMatch(id, "^[0-9]{4}$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void WriteLineLogs(string logs)
        {
            logs = String.Format("{0:yyyy-MM-dd HH:mm:ss} | {1}{2}", DateTime.Now, logs.Replace(Environment.NewLine, Environment.NewLine + "                    | "), Environment.NewLine);
            this.txtLogs.AppendText(logs);
            this.txtLogs.Select(this.txtLogs.Text.Length, 0);
        }

        private void FrmLabelDebug_FormClosing(object sender, FormClosingEventArgs e)
        {
            ControllerAPI.DisConnect();
            /*if (labController.bPortOpened)
            {
                bool result = labController.CloseComPort();
                if (!result)
                {
                    WinMessage.ShowError(String.Format("未能关闭端口{0}，请联系管理员！", cbbPortName.Text));
                }
            }*/
        }

        private void txtLabelData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)8 && e.KeyChar != (char)46)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        
    }
}
