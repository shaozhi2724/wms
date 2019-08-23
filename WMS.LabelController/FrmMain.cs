using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WMS.App.Services;
using WMS.LabelController.Properties;
using WMS.Model;

namespace WMS.LabelController
{
    public partial class FrmMain : Form
    {
        private readonly IELabelService _labelService;
        private readonly ILabelTaskService _taskService;
        private readonly IStoreBillService _storeBillService;
        private readonly ICargoSpaceStoreDetailService _cargoService;

        private List<Controller> _controllers;

        private List<LabelTask> _waitingTasks;

        /// <summary>
        /// 所有正在亮着的通道灯
        /// </summary>
        private List<string> _lightingChannels;

        /// <summary>
        /// 所有正在亮着的标签
        /// </summary>
        private List<string> _lightingLabels;

        /// <summary>
        /// 是否已经提示关闭窗体
        /// </summary>
        private bool _isQuit;
        private bool _isSending;
        private bool _isRunning;
        private bool _showControllerResponse = true;
        /// <summary>
        /// 日志
        /// </summary>
        private string _log;

        private bool _isRed = true;
        const int PORT_CONTROLLER = 8600;

        public FrmMain()
        {
            InitializeComponent();

            _labelService = new ELabelService();
            _taskService = new LabelTaskService();
            _storeBillService = new StoreBillService();
            _cargoService = new CargoSpaceStoreDetailService();

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                _controllers = new List<Controller>();
                _waitingTasks = new List<LabelTask>();
                _lightingChannels = new List<string>();
                _lightingLabels = new List<string>();
                _showControllerResponse = tsbShowControllerResponse.Checked;

                timerTask.Interval = Settings.Default.TaskScanInterval;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMain_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(3000, "运行提示", "系统最小化托盘。", ToolTipIcon.Info);
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isQuit)
            {
                if (ControllerAPI.IsConnected())
                {
                    ControllerAPI.DisConnect();
                    ControllerAPI.ExitTrans();
                }
                return;
            }
            DialogResult dr = MessageBox.Show("警告：退出将使服务控制中心将使所有电子标签和通道灯失效。\r\n您确定要退出吗？\r\n是：系统将退出。\r\n否：系统将最小化运行。\r\n取消：系统将取消当前操作。", "系统提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                _isQuit = true;
                if (ControllerAPI.IsConnected())
                {
                    ControllerAPI.DisConnect();
                    ControllerAPI.ExitTrans();
                }
                e.Cancel = false;
            }
            else if (dr == DialogResult.No)
            {
                e.Cancel = true;
                Hide();
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(3000, "运行提示", "系统最小化托盘。", ToolTipIcon.Info);
            }
            else
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// 处理标签
        /// </summary>
        private void ProcessLabelTasks()
        {
            //查数据库待办标签
            List<LabelTask> tasks = _taskService.GetAllLabelTasks().OrderBy(p => p.TaskId).ToList();

            foreach (LabelTask task in tasks)
            {
                //添加到本机待办列表
                LabelTask waitingTask = _waitingTasks.Find(t => t.TaskId == task.TaskId);
                if (waitingTask == null)
                {
                    _waitingTasks.Add(task);
                }
            }
        }

        /// <summary>
        /// 从待发送列表中给标签发送数据
        /// </summary>
        private void SendLabelData(string previouseLabelCode = "")
        {
            ProcessLabelTasks();
            //发送列表数据
            LabelTask task = _waitingTasks.FirstOrDefault(p => p.TaskStatus == 0);// && p.LabelCode != previouseLabelCode);
            //LabelTask task = _waitingTasks.FirstOrDefault(p => p.TaskStatus == 0 && p.LabelCode != previouseLabelCode);
            if (null != task)
            {
                Controller control = _controllers.FirstOrDefault(c => c.IpAddress == task.LabelAddress);

                if (null != control)
                {
                    _isSending = true;
                    Thread.Sleep(300);
                    //给电子标签发送6位数据
                    var data = String.Format("{0:00}.{1:0000}", task.StructureCode, task.Amount);
                    //var data = String.Format("{0}{1}", task.StructureCode.ToString().PadLeft(2, ' '), task.Amount.ToString().PadLeft(4, ' '));
                    var sendData = control.SendData(task.LabelCode, data, _isRed);

                    if (!sendData)
                    {
                        LogError(String.Format("电子标签未点亮! - 请求货位为{0},数量为{1},ID号为{2}。任务号:{3}。标签返回值：{4}{5}",
                                               task.StructureLocation,
                                               task.Amount,
                                               task.LabelCode,
                                               task.TaskId,
                                               sendData,
                                               Environment.NewLine));
                    }
                }
            }

            if(_waitingTasks.Any() && _waitingTasks.All(p => p.TaskStatus == 1))
            //if(_waitingTasks.Any(p => p.TaskStatus <= 1))
            {
                SendLightData();
            }
        }
        /// <summary>
        /// 从待发送列表中给标签发送数据
        /// </summary>
        private void SendLabelData2(string previouseLabelCode = "")
        {
            Thread.Sleep(200);
            ProcessLabelTasks();
            //发送列表数据
            LabelTask task = _waitingTasks.FirstOrDefault(p => p.TaskStatus == 1 && p.LabelCode == previouseLabelCode);
            if (null != task)
            {
                Controller control = _controllers.FirstOrDefault(c => c.IpAddress == task.LabelAddress);

                if (null != control)
                {
                    _isSending = true;
                    Thread.Sleep(300);
                    //给电子标签发送6位数据
                    var data = String.Format("{0:00}.{1:0000}", task.StructureCode, task.Amount);
                    //var data = String.Format("{0}{1}", task.StructureCode.ToString().PadLeft(2, ' '), task.Amount.ToString().PadLeft(4, ' '));
                    var sendData = control.SendData(task.LabelCode, data, _isRed);

                    if (!sendData)
                    {
                        LogError(String.Format("电子标签未点亮! - 请求货位为{0},数量为{1},ID号为{2}。任务号:{3}。标签返回值：{4}{5}",
                                               task.StructureLocation,
                                               task.Amount,
                                               task.LabelCode,
                                               task.TaskId,
                                               sendData,
                                               Environment.NewLine));
                    }
                }
            }

            if(_waitingTasks.Any() && _waitingTasks.All(p => p.TaskStatus == 1))
            {
                SendLightData();
            }
        }

        /// <summary>
        /// 从待发送列表中给通道灯标签发送数据
        /// </summary>
        private void SendLightData(string previouseLightCode = "")
        {
            ProcessLabelTasks();
            //if(_waitingTasks.All(p => p.TaskStatus != 0))
            //{
            //    return;
            //}
            Thread.Sleep(1000);
            var count = _waitingTasks.Select(p => p.LightCode).Distinct().Count();
            //if(_lightingChannels.Count == count)
            //{
            //    SendLabelData();
            //}
            //发送列表数据
            //LabelTask task = _waitingTasks.FirstOrDefault(p => p.TaskStatus == 0 && !_lightingChannels.Contains(p.LightCode));

            LabelTask task = _waitingTasks.FirstOrDefault(p => p.TaskStatus == 1 && !_lightingChannels.Contains(p.LightCode));
            //if(task == null)
            //{
            //    task = _waitingTasks.FirstOrDefault(p => p.TaskStatus == 0
            //}
            if (null != task)
            {
                Controller control = _controllers.FirstOrDefault(c => c.IpAddress == task.LabelAddress);

                if (null != control)
                {
                    if (!string.IsNullOrWhiteSpace(task.LightCode)) //标签带有通道灯
                    {

                        _isSending = true;
                        //通道灯灭着
                        if (!_lightingChannels.Contains(task.LightCode))
                        {
                            //点亮通道灯
                            var sendChannelData = control.SendData(task.LightCode,
                                                                   task.StockOutNo.Substring(task.StockOutNo.Length - 3),
                                                                   true);
                            if (!sendChannelData)
                            {
                                LogError(String.Format("通道灯{1}未点亮！ - ID号为{0}的电子标签的关联通道灯。",
                                                       task.LabelCode,
                                                       task.LightCode));
                            }
                        }
                    }
                }
            }
        }

        /*/// <summary>
        /// 给标签发送数据
        /// </summary>
        private void SendNextLabelData(LabelTask processingTask)
        {
            string labelCode = processingTask.LabelCode;
            string stockOutNo = processingTask.StockOutNo;
            ProcessLabelTasks();
            var previousTask = _waitingTasks.FirstOrDefault(p => p.StockOutNo == stockOutNo && p.TaskStatus == (int)TaskStatuses.Waiting);
            if (null == previousTask)
            {
                TurnOffChannelLight(processingTask);
                //TurnOnChannelLight(currentTask);
            }
            var waitingTasks = _waitingTasks
                .Where(p => p.TaskStatus == 0 && p.LabelCode == labelCode)
                .OrderBy(p => p.TaskId)
                .ToList();

            if (!waitingTasks.Any())
            {
                return;
            }
            //发送列表数据
            foreach (LabelTask task in waitingTasks)
            {
                var control = _controllers.Find(c => c.IpAddress == task.LabelAddress);

                if (null != control)
                {
                    //给电子标签发送7位数据
                    var data = String.Format("{0:00}.{1:0000}", task.StructureCode, task.Amount);
                    var sendData = control.SendData(task.LabelCode, data, _isRed);

                    if (!sendData)
                    {
                        LogError(String.Format("电子标签未点亮! - 请求货位为{0},数量为{1},ID号为{2}。任务号:{3}。标签返回值：{4}{5}",
                        task.StructureLocation, task.Amount, task.LabelCode, task.TaskId, sendData, Environment.NewLine));
                        continue;
                    }

                    //LogMessage(String.Format("来自请求货位为{0}数量为{1},ID号为{2}的电子标签已点亮。任务号:{3}。",
                    //    task.StructureLocation, task.Amount, task.LabelCode, task.TaskId));

                    //TODO:更新出库单明细为正在出库
                    //_storeBillService.UpdateStoreBillDetailStatus(task.StockOutNo, task.StructureID, task.MedicineCode, task.BatchNo, StoreBillStatuses.Processing);
                }
            }
        }

        /// <summary>
        /// 给标签发送数据
        /// </summary>
        private void SendNextLabelData(string stockOutNo)
        {
            var task =
                _waitingTasks.FirstOrDefault(
                                             p =>
                                             p.StockOutNo == stockOutNo && p.TaskStatus == (int) TaskStatuses.Waiting);
            if (null == task)
            {
                return;
            }

            var control = _controllers.Find(c => c.IpAddress == task.LabelAddress);

            if (null != control)
            {
                //给电子标签发送7位数据
                var data = String.Format("{0:00}.{1:0000}", task.StructureCode, task.Amount);
                var sendData = control.SendData(task.LabelCode, data, _isRed);

                if (!sendData)
                {
                    LogError(String.Format("电子标签未点亮! - 请求货位为{0},数量为{1},ID号为{2}。任务号:{3}。标签返回值：{4}{5}",
                                           task.StructureLocation,
                                           task.Amount,
                                           task.LabelCode,
                                           task.TaskId,
                                           sendData,
                                           Environment.NewLine));
                }
            }
        }
*/
        private void TurnOffChannelLight(LabelTask task)
        {
            var control = _controllers.FirstOrDefault(p => p.IpAddress == task.LabelAddress);
            if (null != control)
            {
                if (_waitingTasks.Count(p => p.LightCode == task.LightCode && p.StockOutNo == task.StockOutNo && p.TaskStatus < 3) == 0)
                {
                    if (control.Off(task.LightCode))
                    {
                        LogWarning(String.Format("ID号为{0}的通道灯已熄灭。", task.LightCode));
                        _lightingChannels.Remove(task.LightCode);
                    }
                    else
                    {
                        LogError(String.Format("ID号为{0}的通道灯熄灭指令失败！", task.LightCode));
                    }
                }

                if (_waitingTasks.Where(p => p.StockOutNo == task.StockOutNo).All(p => p.TaskStatus == 3))
                {
                    _isRed = !_isRed;
                    // 所有任务完成，完成出库单
                    _storeBillService.UpdateStoreBillStatus(task.StockOutNo, StoreBillStatuses.Complete);
                    /*var lightingChannels = _storeBillService.GetLightChannels(task.StockOutNo);
                    foreach (var lightingChannel in lightingChannels)
                    {
                        control.Off(lightingChannel);
                        Thread.Sleep(1000);
                    }*/
                    _waitingTasks.Clear();
                    _lightingChannels.Clear();
                    _lightingLabels.Clear();
                    _isRunning = true;
                    _isSending = false;
                    Thread.Sleep(2000);
                }
            }

        }

        protected override void DefWndProc(ref Message m)
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

        //wParam 0/1,表示:已断开/连接上
        //lparam 未使用
        private void OnConnected(IntPtr wParam,IntPtr lParam)
        {
            if (wParam.ToInt32() == 1)
            {
                tsbStart.Enabled = false;
                tsbStop.Enabled = true;
                tsbShowControllerResponse.Enabled = true;
            }
            else if (wParam.ToInt32() == 0)
            {
                tsbStart.Enabled = true;
                tsbStop.Enabled = false;
                tsbShowControllerResponse.Enabled = false;
            }
        }

        //lparam:字符串起始地址
        //wparam:字符串数据长度
        private void OnRecvData(IntPtr wParam, IntPtr lParam)
        {
            byte[] byteArray = new byte[wParam.ToInt32()];
            Marshal.Copy(lParam, byteArray, 0, wParam.ToInt32());
            string result = ASCIIEncoding.ASCII.GetString(byteArray);

            if (_showControllerResponse)
            {
                LogMessage(string.Format("标签应答 - {0}", result));
            }

            if (result.Contains("NewData"))
            {
                ControllerAPI.GetData();
            }
            if (result.Contains(",4:") && !result.StartsWith("Q"))
            {
                result = "Q" + result;
            }
            String response = result.Substring(0,1);

            //返回应答
            if (result.StartsWith("ACK:"))
            {
                var splitValues = result.Split(':');
                string labelCode = splitValues[splitValues.Length - 1];
                var currentTask = _waitingTasks.FirstOrDefault(p => p.LabelCode == labelCode && p.TaskStatus < (int)TaskStatuses.Processing);

                if (null == currentTask)
                {
                    currentTask = _waitingTasks.FirstOrDefault(p => p.LightCode == labelCode);
                    if (null != currentTask)
                    {
                        if (!_lightingChannels.Contains(currentTask.LightCode))
                        {
                            _lightingChannels.Add(currentTask.LightCode);
                            LogMessage(String.Format("ID号为{0}的电子标签的关联通道灯{1}已点亮。",
                                                 currentTask.LabelCode,
                                                 currentTask.LightCode));
                        }
                        SendLightData(currentTask.LightCode);
                    }
                }
                else
                {
                    string logs = String.Format("来自ID号为{0}的标签信息，已应答。", labelCode);
                    LogWarning(logs);
                    if (!_lightingLabels.Contains(labelCode))
                    {
                        _lightingLabels.Add(labelCode);
                    }
                    var task = _waitingTasks.Find(p => p.LabelCode == labelCode && p.TaskStatus == 0);
                    if (null != task
                        && task.TaskStatus != (int) TaskStatuses.Complete
                        && task.TaskStatus != (int) TaskStatuses.Processing)
                    {
                        task.TaskStatus = (int) TaskStatuses.Processing;
                        _taskService.UpdateLabelTask(task);
                    }
                    LogMessage(String.Format("来自请求货位为{0}数量为{1},ID号为{2}的电子标签已点亮。任务号:{3}。",
                                                currentTask.StructureLocation,
                                                currentTask.Amount,
                                                currentTask.LabelCode,
                                                currentTask.TaskId));
                    SendLabelData(labelCode);
                }
                //ControllerAPI.RecvOK();
            }


            //标签编号不存在
            if (result.Contains("F:") && result.EndsWith(":2"))
            {
                var splitValues = result.Split(':');
                string labelCode = splitValues[splitValues.Length - 2];

                string logs = String.Format("指令发送失败，ID号为{0}的标签不存在，请检查标签配置！", labelCode);
                LogError(logs);
            }

            //标签有问题，未响应
            if (result.StartsWith("NACK:"))
            {
                var splitValues = result.Split(':');
                string labelCode = splitValues[splitValues.Length - 1];

                var currentTask = _waitingTasks.FirstOrDefault(p => p.LabelCode == labelCode && p.TaskStatus != (int)TaskStatuses.Processing);

                if (null != currentTask)
                {
                    string logs = String.Format("ID号为{0}的标签无应答，请检查标签存在且工作正常！", labelCode);
                    LogError(logs);

                    LogError(String.Format("电子标签未点亮! - 请求货位为{0},数量为{1},ID号为{2}。任务号:{3}。标签返回值：{4}{5}",
                        currentTask.StructureLocation, currentTask.Amount, currentTask.LabelCode, currentTask.TaskId, result, Environment.NewLine));
                }
            }
            
            if(result.Contains("?Q"))
            {
                var results = result.Split("?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                foreach (var r in results)
                {
                    var content = r;
                    if (r.Contains("ACK:"))
                    {
                        if (r.Contains("Q"))
                        {
                            content = r.Split("Q".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)[1];
                        }
                        else
                        {
                            continue;
                        }
                    }
                    var splitValues = content.Split(',');
                    //标签号
                    string labelCode = splitValues[0].Replace("Q", "");
                    int status = int.Parse(splitValues[1].Substring(0, 1));
                    //1：表示待机状态；2：表示正在操作；4：表示操作完成
                    if(status == 4)
                    {
                        //货位号
                        string amountWithStructureCode = splitValues[1];
                        if(amountWithStructureCode.EndsWith("?"))
                        {
                            amountWithStructureCode = amountWithStructureCode.Replace("?", "");
                        }

                        int amount = int.Parse(amountWithStructureCode.Substring(amountWithStructureCode.Length - 4));
                        string logs = String.Format("来自ID号为{0}的标签信息，数量 {1}，上一次工作已完成。", labelCode, amount.ToString());
                        LogWarning(logs);

                        //货位号
                        var structureCode = int.Parse(result.Split(':')[1].Substring(0, 2));
                        var task = _waitingTasks.OrderByDescending(p => p.TaskStatus).FirstOrDefault(t =>
                                                                t.TaskStatus <= 1 && t.LabelCode == labelCode &&
                                                                t.StructureCode == structureCode && t.Amount == amount);

                        if(null != task)
                        {
                            task.TaskStatus = (int)TaskStatuses.Complete;
                            _taskService.UpdateLabelTask(task);

                            //更新库存和出库单明细状态
                            _storeBillService.UpdateCargoSpaceAmount(task.BillDetailID,
                                                                     task.StructureID.Value,
                                                                     int.Parse(task.MedicineCode),
                                                                     task.BatchNo,
                                                                     task.Amount.Value);

                            _storeBillService.UpdateStoreBillDetailStatus(task.StockOutNo,
                                                                          task.WMSDetailID,
                                                                          StoreBillStatuses.Complete);

                            _cargoService.CleanStore();
                            //发送下一个
                            //SendLabelData();
                            ProcessLabelTasks();
                            var waitingTasks = _waitingTasks.Where(p => p.TaskStatus <= 1 && p.LightCode == task.LightCode)
                                                            .OrderBy(p => p.TaskId)
                                                            .ToList();

                            //接收后在发送列表中移除
                            if(!waitingTasks.Any())
                            {
                                //TODO:取拍灯标签的通道灯
                                var tempTask = _waitingTasks.FirstOrDefault(
                                                                 t =>
                                                                 t.LabelCode == labelCode &&
                                                                 t.StructureCode == structureCode);
                                if(null != tempTask)
                                {
                                    TurnOffChannelLight(tempTask);
                                }
                            }
                            else
                            {
                                SendLabelData2(labelCode);
                            }
                        }

                    }
                }
                
                //ControllerAPI.RecvOK();
            }
            else
            {
                //返回拍灯按键回馈，如：Q1001,4:0005
                if(response == "Q")
                {
                    var splitValues = result.Split(',');
                    //标签号
                    string labelCode = splitValues[0].Replace("Q", "");
                    int status = int.Parse(splitValues[1].Substring(0, 1));
                    //1：表示待机状态；2：表示正在操作；4：表示操作完成
                    if(status == 4)
                    {
                        string amountWithStructureCode = splitValues[1];
                        if (amountWithStructureCode.EndsWith("?"))
                        {
                            amountWithStructureCode = amountWithStructureCode.Replace("?", "");
                        }

                        int amount = int.Parse(amountWithStructureCode.Substring(amountWithStructureCode.Length - 4));
                        string logs = String.Format("来自ID号为{0}的标签信息，数量 {1}，上一次工作已完成。", labelCode, amount.ToString());
                        LogWarning(logs);

                        //货位号
                        var structureCode = int.Parse(result.Split(':')[1].Substring(0, 2));
                        var task = _waitingTasks.OrderByDescending(p => p.TaskStatus).FirstOrDefault(t =>
                                                                t.TaskStatus <= 1 && t.LabelCode == labelCode &&
                                                                t.StructureCode == structureCode && t.Amount == amount);

                        if(null != task)
                        {
                            task.TaskStatus = (int)TaskStatuses.Complete;
                            _taskService.UpdateLabelTask(task);

                            //更新库存和出库单明细状态
                            _storeBillService.UpdateCargoSpaceAmount(task.BillDetailID,
                                                                     task.StructureID.Value,
                                                                     int.Parse(task.MedicineCode),
                                                                     task.BatchNo,
                                                                     task.Amount.Value);

                            _storeBillService.UpdateStoreBillDetailStatus(task.StockOutNo,
                                                                          task.WMSDetailID,
                                                                          StoreBillStatuses.Complete);

                            _cargoService.CleanStore();
                            //发送下一个
                            //SendLabelData();
                            ProcessLabelTasks();
                            var waitingTasks = _waitingTasks.Where(p => p.TaskStatus <= 1 && p.LightCode == task.LightCode)
                                                            .OrderBy(p => p.TaskId)
                                                            .ToList();

                            //接收后在发送列表中移除
                            if(!waitingTasks.Any())
                            {
                                //TODO:取拍灯标签的通道灯
                                var tempTask = _waitingTasks.FirstOrDefault(
                                                                 t =>
                                                                 t.LabelCode == labelCode &&
                                                                 t.StructureCode == structureCode);
                                if(null != tempTask)
                                {
                                    TurnOffChannelLight(tempTask);
                                }
                            }
                            else
                            {
                                SendLabelData2(labelCode);
                            }
                        }

                    }
                    //ControllerAPI.RecvOK();
                }
            }
            
            if (response == "G")
            {
                ControllerAPI.RecvOK();
            }

        }

/*
        private void labelController_OnAck(object sender, __KDLabOCX_OnAckEvent e)
        {
            var ackType = e.ackType;
            var labelID = e.iD.ToString();
            if (ackType == 2)
            {
                var task = _waitingTasks.Find(p => p.LabelCode == labelID && p.TaskStatus == 0);
                if (null != task && task.TaskStatus != (int) TaskStatuses.Complete && task.TaskStatus != (int)TaskStatuses.Processing)
                {
                    task.TaskStatus = (int) TaskStatuses.Processing;
                    _taskService.UpdateLabelTask(task);
                }
            }
            //WriteLineLogs(string.Format("ACKType:{0},LabelID{1}",ackType,labelID));
        }

        public void labelController_OnData(object sender, __KDLabOCX_OnDataEvent e)
        {
            AxKDLabOCX labController = sender as AxKDLabOCX;
            if (null == labController)
            {
                return;
            }

            string data = e.data;
            short cmd = 0;
            bool bCCOK = false;
            short labState = 0;
            short labColor = 0;
            string result = labController.DataAnalysis(data, ref cmd, ref bCCOK, ref labState, ref labColor);
            //WriteLineLogs(String.Format("Result:{0}{6}Data:{1}{6}CMD:{2}{6}bCCOK:{3}{6}LabState:{4}{6}LabColor:{5}",
                //result, data, cmd, bCCOK, labState, labColor, Environment.NewLine));
            string labelID = e.iD.ToString();
            if (labState == 52)
            {
                string logs = String.Format("来自ID号为{0}的标签信息，上一次工作已完成。", e.iD);
                WriteLineLogs(logs);

                var structureCode = int.Parse(result.Split('.')[0]);

                var waitingTasks = _waitingTasks.Where(p => p.TaskStatus <= 1).OrderBy(p => p.TaskId).ToList();

                //接收后在发送列表中移除
                if (!waitingTasks.Any())
                {
                    TurnOffChannelLight(labelID);
                    return;
                }

                var task = waitingTasks.Find(t => t.LabelCode == labelID && t.StructureCode == structureCode);
                if (null != task)
                {
                    task.TaskStatus = (int) TaskStatuses.Complete;
                    _taskService.UpdateLabelTask(task);

                    //更新库存和出库单明细状态
                    _storeBillService.UpdateCargoSpaceAmount(task.BillDetailID, task.StructureID.Value,
                        int.Parse(task.MedicineCode), task.BatchNo, task.Amount.Value);

                    _storeBillService.UpdateStoreBillDetailStatus(task.StockOutNo, task.WMSDetailID,
                        StoreBillStatuses.Complete);

                    _cargoService.CleanStore();
                }
            }

            //发送下一个

            SendLabelData(labelID);
        }
        private void TurnOffChannelLight(string labelCode)
        {
            using (var db = new WMSContext())
            {
                var task = db.LabelTasks.FirstOrDefault(p => p.LabelCode == labelCode);
                short lightComPort = 0;
                string lightCode = "";
                if (null != task)
                {
                    lightComPort = (short) task.LightComPort.Value;
                    lightCode = task.LightCode;
                }
                else
                {
                    var elabel = db.ElectronicLabels.FirstOrDefault(p => p.LabelCode == labelCode);
                    var lightId = elabel.ParentLabelID;
                    if (null != lightId)
                    {
                        var light = db.ElectronicLabels.FirstOrDefault(p => p.LabelID == lightId);
                        lightComPort = short.Parse(light.LabelPortName.Replace("COM", ""));
                        lightCode = light.LabelCode;
                    }
                }
                var control = _controllers.Find(p => p.Port == lightComPort);
                if (null != control)
                {
                    //control.OFF(task.LightCode);
                    control.TurnOffChannelData(lightCode);
                    LogWarning(String.Format("ID号为{0}的通道灯已熄灭。", lightCode));
                    _lightingLabelChannels.Remove(lightCode);

                }
            }
        }
*/

        private void tsbStart_Click(object sender, EventArgs e)
        {
            ControllerAPI.InitializeTrans();
            ControllerAPI.SetMessageHandler(this.Handle);
            LogMessage("电子标签服务启动中...");
            _controllers.Clear();
            LogMessage("正在收集控制器信息...");
            try
            {
                var controllers = _labelService.GetAllElectronicLabels();
                var controllerAddresses = controllers.Select(p => p.LabelAddress).Distinct().ToList();

                if (controllerAddresses.Any())
                {
                    foreach (var controllerAddress in controllerAddresses)
                    {
                        Controller controller = new Controller(controllerAddress, PORT_CONTROLLER);
                        _controllers.Add(controller);
                    }

                    _log = String.Format("收集到[{0}]个控制器信息...", _controllers.Count);
                    LogMessage(_log);
                }
                else
                {
                    LogError("未收集任何控制器信息...");
                    return;
                }
            }
            catch (Exception ex)
            {
                _log = String.Format("收集控制器信息失败...{0}错误信息：{1}", Environment.NewLine, ex.Message);
                LogError(_log);
                return;
            }

            LogMessage("正在打开控制器...");

            foreach (Controller c in _controllers)
            {
                if (!c.Open())
                {
                    LogError(String.Format("未能打开控制器 - {0}...", c.IpAddress));
                }
                else
                {
                    LogMessage(String.Format("控制器 - {0} 已打开", c.IpAddress));
                }
            }

            LogMessage("启动完成，开始监听...");

            _isRunning = true;
            timerTask.Enabled = true;
            _isQuit = false;
            tsbStart.Enabled = false;
            tsbStop.Enabled = true;
        }

        private void tsbStop_Click(object sender, EventArgs e)
        {
            LogWarning("正在关闭控制器...");

            foreach (Controller c in _controllers)
            {
                if (!c.Close())
                {
                    LogError(String.Format("未能关闭{0}上的控制器...", c.IpAddress));
                }
            }
            tsbStart.Enabled = true;
            tsbStop.Enabled = false;
            tsbShowControllerResponse.Enabled = false;

            _controllers.Clear();
            _lightingLabels.Clear();
            _lightingChannels.Clear();
            _waitingTasks.Clear();

            LogMessage("服务已关闭...");
            timerTask.Enabled = false;
            _isRunning = false;
            _isSending = false;
            _isQuit = true;
        }

        private void tsbClear_Click(object sender, EventArgs e)
        {
            txtLogs.Clear();
            tsbClear.Enabled = false;
        }

        #region 菜单

        private void itmLabelTest_Click(object sender, EventArgs e)
        {
            using (FrmLabelDebug debugger = new FrmLabelDebug())
            {
                debugger.ShowDialog(this);
            }
        }

        private void itmAbout_Click(object sender, EventArgs e)
        {
            using (FrmAboutBox aboutBox = new FrmAboutBox())
            {
                aboutBox.ShowDialog(this);
            }
        }

        private void itmExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        #endregion

        #region 日志记录、支持其他线程访问

        public delegate void LogAppendDelegate(Color color, string text);

        /// <summary> 
        /// 追加显示文本 
        /// </summary> 
        /// <param name="color">文本颜色</param> 
        /// <param name="text">显示文本</param> 
        public void LogAppend(Color color, string text)
        {
            txtLogs.SelectionColor = color;
            txtLogs.AppendText(text);
            txtLogs.Update();
        }

        /// <summary> 
        /// 显示错误日志 
        /// </summary> 
        /// <param name="text"></param> 
        public void LogError(string text)
        {
            tsbClear.Enabled = true;
            LogAppendDelegate la = new LogAppendDelegate(LogAppend);
            string logs = String.Format("{0:yyyy-MM-dd HH:mm:ss} | {1}", DateTime.Now, text);
            logs += Environment.NewLine;
            txtLogs.Invoke(la, Color.Red, logs);
            //写本地日志
            LogManager.WriteLocalLog(logs);

            Thread.Sleep(100);
        }

        /// <summary> 
        /// 显示警告信息 
        /// </summary> 
        /// <param name="text"></param> 
        public void LogWarning(string text)
        {
            tsbClear.Enabled = true;
            LogAppendDelegate la = new LogAppendDelegate(LogAppend);
            string logs = String.Format("{0:yyyy-MM-dd HH:mm:ss} | {1}", DateTime.Now, text);
            logs += Environment.NewLine;
            txtLogs.Invoke(la, Color.Gold, logs);
            //写本地日志
            LogManager.WriteLocalLog(logs);

            Thread.Sleep(100);
        }

        /// <summary> 
        /// 显示信息 
        /// </summary> 
        /// <param name="text"></param> 
        public void LogMessage(string text)
        {
            tsbClear.Enabled = true;
            LogAppendDelegate la = new LogAppendDelegate(LogAppend);
            string logs = String.Format("{0:yyyy-MM-dd HH:mm:ss} | {1}", DateTime.Now, text);
            logs += Environment.NewLine;
            txtLogs.Invoke(la, Color.Lime, logs);
            //写本地日志
            LogManager.WriteLocalLog(logs);

            Thread.Sleep(100);
        }

        #endregion

        private void tsbShowControllerResponse_CheckedChanged(object sender, EventArgs e)
        {
            _showControllerResponse = tsbShowControllerResponse.Checked;
        }

        private void timerTask_Tick(object sender, EventArgs e)
        {
            timerTask.Enabled = false;
            if(!_isSending && _isRunning)
            {
                //发送标签数据
                //SendLightData();
                SendLabelData();
            }
            timerTask.Enabled = true;
        }
    }
}
