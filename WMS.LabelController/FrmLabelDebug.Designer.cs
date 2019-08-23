namespace WMS.LabelController
{
    partial class FrmLabelDebug
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbConnect = new System.Windows.Forms.GroupBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblPortName = new System.Windows.Forms.Label();
            this.gpbResult = new System.Windows.Forms.GroupBox();
            this.txtLogs = new System.Windows.Forms.RichTextBox();
            this.gpbDebug = new System.Windows.Forms.GroupBox();
            this.gpbLabel = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.rdbNone = new System.Windows.Forms.RadioButton();
            this.rdbBlue = new System.Windows.Forms.RadioButton();
            this.rdbGreen = new System.Windows.Forms.RadioButton();
            this.rdbRed = new System.Windows.Forms.RadioButton();
            this.txtLabelData = new System.Windows.Forms.TextBox();
            this.txtLabelID = new System.Windows.Forms.TextBox();
            this.lblLabelData = new System.Windows.Forms.Label();
            this.lblLabelID = new System.Windows.Forms.Label();
            this.gpbLight = new System.Windows.Forms.GroupBox();
            this.btnLightControl = new System.Windows.Forms.Button();
            this.rdbLightOff = new System.Windows.Forms.RadioButton();
            this.rdbLightOn = new System.Windows.Forms.RadioButton();
            this.txtLightID = new System.Windows.Forms.TextBox();
            this.lblLightID = new System.Windows.Forms.Label();
            this.gpbCommon = new System.Windows.Forms.GroupBox();
            this.btnDisplayAllID = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClearCurrent = new System.Windows.Forms.Button();
            this.btnModifyID = new System.Windows.Forms.Button();
            this.txtCommonID = new System.Windows.Forms.TextBox();
            this.lblCommonID = new System.Windows.Forms.Label();
            this.gpbConnect.SuspendLayout();
            this.gpbResult.SuspendLayout();
            this.gpbDebug.SuspendLayout();
            this.gpbLabel.SuspendLayout();
            this.gpbLight.SuspendLayout();
            this.gpbCommon.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbConnect
            // 
            this.gpbConnect.Controls.Add(this.txtPort);
            this.gpbConnect.Controls.Add(this.txtIP);
            this.gpbConnect.Controls.Add(this.label1);
            this.gpbConnect.Controls.Add(this.btnClear);
            this.gpbConnect.Controls.Add(this.btnClose);
            this.gpbConnect.Controls.Add(this.btnOpen);
            this.gpbConnect.Controls.Add(this.lblPortName);
            this.gpbConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbConnect.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.gpbConnect.Location = new System.Drawing.Point(0, 0);
            this.gpbConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbConnect.Name = "gpbConnect";
            this.gpbConnect.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbConnect.Size = new System.Drawing.Size(949, 81);
            this.gpbConnect.TabIndex = 0;
            this.gpbConnect.TabStop = false;
            this.gpbConnect.Text = "通讯设置";
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtPort.Location = new System.Drawing.Point(447, 28);
            this.txtPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPort.MaxLength = 4;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(135, 27);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "8600";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtIP.Location = new System.Drawing.Point(91, 28);
            this.txtIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIP.MaxLength = 20;
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(240, 27);
            this.txtIP.TabIndex = 0;
            this.txtIP.Text = "192.168.1.101";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "IP地址：";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Location = new System.Drawing.Point(852, 23);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 41);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(747, 23);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 41);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpen.Location = new System.Drawing.Point(642, 23);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(84, 41);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblPortName
            // 
            this.lblPortName.AutoSize = true;
            this.lblPortName.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblPortName.Location = new System.Drawing.Point(372, 31);
            this.lblPortName.Name = "lblPortName";
            this.lblPortName.Size = new System.Drawing.Size(54, 20);
            this.lblPortName.TabIndex = 4;
            this.lblPortName.Text = "端口：";
            // 
            // gpbResult
            // 
            this.gpbResult.Controls.Add(this.txtLogs);
            this.gpbResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gpbResult.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.gpbResult.Location = new System.Drawing.Point(0, 393);
            this.gpbResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbResult.Name = "gpbResult";
            this.gpbResult.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbResult.Size = new System.Drawing.Size(949, 200);
            this.gpbResult.TabIndex = 2;
            this.gpbResult.TabStop = false;
            this.gpbResult.Text = "数据接收";
            // 
            // txtLogs
            // 
            this.txtLogs.BackColor = System.Drawing.Color.Black;
            this.txtLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogs.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtLogs.ForeColor = System.Drawing.Color.Lime;
            this.txtLogs.Location = new System.Drawing.Point(3, 24);
            this.txtLogs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.Size = new System.Drawing.Size(943, 172);
            this.txtLogs.TabIndex = 0;
            this.txtLogs.Text = "";
            // 
            // gpbDebug
            // 
            this.gpbDebug.Controls.Add(this.gpbLabel);
            this.gpbDebug.Controls.Add(this.gpbLight);
            this.gpbDebug.Controls.Add(this.gpbCommon);
            this.gpbDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbDebug.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.gpbDebug.Location = new System.Drawing.Point(0, 81);
            this.gpbDebug.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbDebug.Name = "gpbDebug";
            this.gpbDebug.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbDebug.Size = new System.Drawing.Size(949, 312);
            this.gpbDebug.TabIndex = 1;
            this.gpbDebug.TabStop = false;
            this.gpbDebug.Text = "标签测试";
            // 
            // gpbLabel
            // 
            this.gpbLabel.Controls.Add(this.btnSend);
            this.gpbLabel.Controls.Add(this.rdbNone);
            this.gpbLabel.Controls.Add(this.rdbBlue);
            this.gpbLabel.Controls.Add(this.rdbGreen);
            this.gpbLabel.Controls.Add(this.rdbRed);
            this.gpbLabel.Controls.Add(this.txtLabelData);
            this.gpbLabel.Controls.Add(this.txtLabelID);
            this.gpbLabel.Controls.Add(this.lblLabelData);
            this.gpbLabel.Controls.Add(this.lblLabelID);
            this.gpbLabel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.gpbLabel.Location = new System.Drawing.Point(363, 31);
            this.gpbLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbLabel.Name = "gpbLabel";
            this.gpbLabel.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbLabel.Size = new System.Drawing.Size(271, 278);
            this.gpbLabel.TabIndex = 1;
            this.gpbLabel.TabStop = false;
            this.gpbLabel.Text = "电子标签测试";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.Location = new System.Drawing.Point(93, 215);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(84, 41);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rdbNone
            // 
            this.rdbNone.AutoSize = true;
            this.rdbNone.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.rdbNone.Location = new System.Drawing.Point(194, 165);
            this.rdbNone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbNone.Name = "rdbNone";
            this.rdbNone.Size = new System.Drawing.Size(45, 24);
            this.rdbNone.TabIndex = 5;
            this.rdbNone.Text = "无";
            this.rdbNone.UseVisualStyleBackColor = true;
            // 
            // rdbBlue
            // 
            this.rdbBlue.AutoSize = true;
            this.rdbBlue.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.rdbBlue.Location = new System.Drawing.Point(139, 165);
            this.rdbBlue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbBlue.Name = "rdbBlue";
            this.rdbBlue.Size = new System.Drawing.Size(45, 24);
            this.rdbBlue.TabIndex = 4;
            this.rdbBlue.Text = "蓝";
            this.rdbBlue.UseVisualStyleBackColor = true;
            // 
            // rdbGreen
            // 
            this.rdbGreen.AutoSize = true;
            this.rdbGreen.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.rdbGreen.Location = new System.Drawing.Point(84, 165);
            this.rdbGreen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbGreen.Name = "rdbGreen";
            this.rdbGreen.Size = new System.Drawing.Size(45, 24);
            this.rdbGreen.TabIndex = 3;
            this.rdbGreen.Text = "绿";
            this.rdbGreen.UseVisualStyleBackColor = true;
            // 
            // rdbRed
            // 
            this.rdbRed.AutoSize = true;
            this.rdbRed.Checked = true;
            this.rdbRed.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.rdbRed.Location = new System.Drawing.Point(29, 165);
            this.rdbRed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbRed.Name = "rdbRed";
            this.rdbRed.Size = new System.Drawing.Size(45, 24);
            this.rdbRed.TabIndex = 2;
            this.rdbRed.TabStop = true;
            this.rdbRed.Text = "红";
            this.rdbRed.UseVisualStyleBackColor = true;
            // 
            // txtLabelData
            // 
            this.txtLabelData.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtLabelData.Location = new System.Drawing.Point(98, 88);
            this.txtLabelData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLabelData.MaxLength = 14;
            this.txtLabelData.Name = "txtLabelData";
            this.txtLabelData.Size = new System.Drawing.Size(135, 27);
            this.txtLabelData.TabIndex = 1;
            this.txtLabelData.Text = "1.2.3.4.5.6.7.";
            this.txtLabelData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLabelData_KeyPress);
            // 
            // txtLabelID
            // 
            this.txtLabelID.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtLabelID.Location = new System.Drawing.Point(98, 31);
            this.txtLabelID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLabelID.MaxLength = 4;
            this.txtLabelID.Name = "txtLabelID";
            this.txtLabelID.Size = new System.Drawing.Size(135, 27);
            this.txtLabelID.TabIndex = 0;
            this.txtLabelID.Text = "1002";
            this.txtLabelID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // lblLabelData
            // 
            this.lblLabelData.AutoSize = true;
            this.lblLabelData.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblLabelData.Location = new System.Drawing.Point(26, 92);
            this.lblLabelData.Name = "lblLabelData";
            this.lblLabelData.Size = new System.Drawing.Size(54, 20);
            this.lblLabelData.TabIndex = 7;
            this.lblLabelData.Text = "数据：";
            // 
            // lblLabelID
            // 
            this.lblLabelID.AutoSize = true;
            this.lblLabelID.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblLabelID.Location = new System.Drawing.Point(26, 35);
            this.lblLabelID.Name = "lblLabelID";
            this.lblLabelID.Size = new System.Drawing.Size(54, 20);
            this.lblLabelID.TabIndex = 8;
            this.lblLabelID.Text = "ID号：";
            // 
            // gpbLight
            // 
            this.gpbLight.Controls.Add(this.btnLightControl);
            this.gpbLight.Controls.Add(this.rdbLightOff);
            this.gpbLight.Controls.Add(this.rdbLightOn);
            this.gpbLight.Controls.Add(this.txtLightID);
            this.gpbLight.Controls.Add(this.lblLightID);
            this.gpbLight.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.gpbLight.Location = new System.Drawing.Point(58, 31);
            this.gpbLight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbLight.Name = "gpbLight";
            this.gpbLight.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbLight.Size = new System.Drawing.Size(271, 278);
            this.gpbLight.TabIndex = 0;
            this.gpbLight.TabStop = false;
            this.gpbLight.Text = "通道灯测试";
            // 
            // btnLightControl
            // 
            this.btnLightControl.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLightControl.Location = new System.Drawing.Point(94, 215);
            this.btnLightControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLightControl.Name = "btnLightControl";
            this.btnLightControl.Size = new System.Drawing.Size(84, 41);
            this.btnLightControl.TabIndex = 3;
            this.btnLightControl.Text = "控制";
            this.btnLightControl.UseVisualStyleBackColor = true;
            this.btnLightControl.Click += new System.EventHandler(this.btnLightControl_Click);
            // 
            // rdbLightOff
            // 
            this.rdbLightOff.AutoSize = true;
            this.rdbLightOff.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.rdbLightOff.Location = new System.Drawing.Point(145, 165);
            this.rdbLightOff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbLightOff.Name = "rdbLightOff";
            this.rdbLightOff.Size = new System.Drawing.Size(60, 24);
            this.rdbLightOff.TabIndex = 2;
            this.rdbLightOff.Text = "熄灭";
            this.rdbLightOff.UseVisualStyleBackColor = true;
            // 
            // rdbLightOn
            // 
            this.rdbLightOn.AutoSize = true;
            this.rdbLightOn.Checked = true;
            this.rdbLightOn.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.rdbLightOn.Location = new System.Drawing.Point(54, 165);
            this.rdbLightOn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbLightOn.Name = "rdbLightOn";
            this.rdbLightOn.Size = new System.Drawing.Size(60, 24);
            this.rdbLightOn.TabIndex = 1;
            this.rdbLightOn.TabStop = true;
            this.rdbLightOn.Text = "点亮";
            this.rdbLightOn.UseVisualStyleBackColor = true;
            // 
            // txtLightID
            // 
            this.txtLightID.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtLightID.Location = new System.Drawing.Point(104, 31);
            this.txtLightID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLightID.MaxLength = 4;
            this.txtLightID.Name = "txtLightID";
            this.txtLightID.Size = new System.Drawing.Size(123, 27);
            this.txtLightID.TabIndex = 0;
            this.txtLightID.Text = "1001";
            this.txtLightID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // lblLightID
            // 
            this.lblLightID.AutoSize = true;
            this.lblLightID.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblLightID.Location = new System.Drawing.Point(43, 35);
            this.lblLightID.Name = "lblLightID";
            this.lblLightID.Size = new System.Drawing.Size(54, 20);
            this.lblLightID.TabIndex = 4;
            this.lblLightID.Text = "ID号：";
            // 
            // gpbCommon
            // 
            this.gpbCommon.Controls.Add(this.btnDisplayAllID);
            this.gpbCommon.Controls.Add(this.btnClearAll);
            this.gpbCommon.Controls.Add(this.btnClearCurrent);
            this.gpbCommon.Controls.Add(this.btnModifyID);
            this.gpbCommon.Controls.Add(this.txtCommonID);
            this.gpbCommon.Controls.Add(this.lblCommonID);
            this.gpbCommon.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.gpbCommon.Location = new System.Drawing.Point(665, 31);
            this.gpbCommon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbCommon.Name = "gpbCommon";
            this.gpbCommon.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbCommon.Size = new System.Drawing.Size(271, 278);
            this.gpbCommon.TabIndex = 2;
            this.gpbCommon.TabStop = false;
            this.gpbCommon.Text = "公共测试";
            // 
            // btnDisplayAllID
            // 
            this.btnDisplayAllID.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDisplayAllID.Location = new System.Drawing.Point(47, 168);
            this.btnDisplayAllID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDisplayAllID.Name = "btnDisplayAllID";
            this.btnDisplayAllID.Size = new System.Drawing.Size(181, 41);
            this.btnDisplayAllID.TabIndex = 3;
            this.btnDisplayAllID.Text = "显示所有ID号";
            this.btnDisplayAllID.UseVisualStyleBackColor = true;
            this.btnDisplayAllID.Click += new System.EventHandler(this.btnDisplayAllID_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearAll.Location = new System.Drawing.Point(46, 217);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(181, 41);
            this.btnClearAll.TabIndex = 4;
            this.btnClearAll.Text = "清除所有标签状态";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnClearCurrent
            // 
            this.btnClearCurrent.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearCurrent.Location = new System.Drawing.Point(46, 119);
            this.btnClearCurrent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearCurrent.Name = "btnClearCurrent";
            this.btnClearCurrent.Size = new System.Drawing.Size(181, 41);
            this.btnClearCurrent.TabIndex = 2;
            this.btnClearCurrent.Text = "清除当前标签状态";
            this.btnClearCurrent.UseVisualStyleBackColor = true;
            this.btnClearCurrent.Click += new System.EventHandler(this.btnClearCurrent_Click);
            // 
            // btnModifyID
            // 
            this.btnModifyID.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnModifyID.Location = new System.Drawing.Point(46, 70);
            this.btnModifyID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModifyID.Name = "btnModifyID";
            this.btnModifyID.Size = new System.Drawing.Size(181, 41);
            this.btnModifyID.TabIndex = 1;
            this.btnModifyID.Text = "修改当前ID号";
            this.btnModifyID.UseVisualStyleBackColor = true;
            this.btnModifyID.Click += new System.EventHandler(this.btnModifyID_Click);
            // 
            // txtCommonID
            // 
            this.txtCommonID.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtCommonID.Location = new System.Drawing.Point(104, 31);
            this.txtCommonID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCommonID.MaxLength = 4;
            this.txtCommonID.Name = "txtCommonID";
            this.txtCommonID.Size = new System.Drawing.Size(123, 27);
            this.txtCommonID.TabIndex = 0;
            this.txtCommonID.Text = "1001";
            this.txtCommonID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // lblCommonID
            // 
            this.lblCommonID.AutoSize = true;
            this.lblCommonID.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblCommonID.Location = new System.Drawing.Point(43, 35);
            this.lblCommonID.Name = "lblCommonID";
            this.lblCommonID.Size = new System.Drawing.Size(54, 20);
            this.lblCommonID.TabIndex = 5;
            this.lblCommonID.Text = "ID号：";
            // 
            // FrmLabelDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 593);
            this.Controls.Add(this.gpbDebug);
            this.Controls.Add(this.gpbResult);
            this.Controls.Add(this.gpbConnect);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLabelDebug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "标签测试";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLabelDebug_FormClosing);
            this.Load += new System.EventHandler(this.FrmLabelDebug_Load);
            this.gpbConnect.ResumeLayout(false);
            this.gpbConnect.PerformLayout();
            this.gpbResult.ResumeLayout(false);
            this.gpbDebug.ResumeLayout(false);
            this.gpbLabel.ResumeLayout(false);
            this.gpbLabel.PerformLayout();
            this.gpbLight.ResumeLayout(false);
            this.gpbLight.PerformLayout();
            this.gpbCommon.ResumeLayout(false);
            this.gpbCommon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbConnect;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblPortName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gpbResult;
        private System.Windows.Forms.RichTextBox txtLogs;
        private System.Windows.Forms.GroupBox gpbDebug;
        private System.Windows.Forms.GroupBox gpbCommon;
        private System.Windows.Forms.Label lblCommonID;
        private System.Windows.Forms.TextBox txtCommonID;
        private System.Windows.Forms.Button btnDisplayAllID;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnClearCurrent;
        private System.Windows.Forms.Button btnModifyID;
        private System.Windows.Forms.GroupBox gpbLight;
        private System.Windows.Forms.RadioButton rdbLightOn;
        private System.Windows.Forms.TextBox txtLightID;
        private System.Windows.Forms.Label lblLightID;
        private System.Windows.Forms.Button btnLightControl;
        private System.Windows.Forms.RadioButton rdbLightOff;
        private System.Windows.Forms.GroupBox gpbLabel;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RadioButton rdbGreen;
        private System.Windows.Forms.RadioButton rdbRed;
        private System.Windows.Forms.TextBox txtLabelData;
        private System.Windows.Forms.TextBox txtLabelID;
        private System.Windows.Forms.Label lblLabelData;
        private System.Windows.Forms.Label lblLabelID;
        private System.Windows.Forms.RadioButton rdbNone;
        private System.Windows.Forms.RadioButton rdbBlue;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
    }
}