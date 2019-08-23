namespace WMS.LabelController
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.itmTool = new System.Windows.Forms.ToolStripMenuItem();
            this.itmLabelTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.itmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.itmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.itmSysInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbStart = new System.Windows.Forms.ToolStripButton();
            this.tsbStop = new System.Windows.Forms.ToolStripButton();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.tsbShowControllerResponse = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.gpLogs = new System.Windows.Forms.GroupBox();
            this.txtLogs = new System.Windows.Forms.RichTextBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerTask = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.gpLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmTool,
            this.itmAbout});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1157, 30);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // itmTool
            // 
            this.itmTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmLabelTest,
            this.toolStripSeparator3,
            this.itmExit});
            this.itmTool.Name = "itmTool";
            this.itmTool.Size = new System.Drawing.Size(70, 24);
            this.itmTool.Text = "选项(&T)";
            // 
            // itmLabelTest
            // 
            this.itmLabelTest.Name = "itmLabelTest";
            this.itmLabelTest.Size = new System.Drawing.Size(159, 24);
            this.itmLabelTest.Text = "标签测试(&D)";
            this.itmLabelTest.Click += new System.EventHandler(this.itmLabelTest_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(156, 6);
            // 
            // itmExit
            // 
            this.itmExit.Name = "itmExit";
            this.itmExit.Size = new System.Drawing.Size(159, 24);
            this.itmExit.Text = "退出(&X)";
            this.itmExit.Click += new System.EventHandler(this.itmExit_Click);
            // 
            // itmAbout
            // 
            this.itmAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmSysInfo});
            this.itmAbout.Name = "itmAbout";
            this.itmAbout.Size = new System.Drawing.Size(72, 24);
            this.itmAbout.Text = "关于(&A)";
            // 
            // itmSysInfo
            // 
            this.itmSysInfo.Name = "itmSysInfo";
            this.itmSysInfo.Size = new System.Drawing.Size(156, 24);
            this.itmSysInfo.Text = "系统信息(&F)";
            this.itmSysInfo.Click += new System.EventHandler(this.itmAbout_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbStart,
            this.tsbStop,
            this.tsbClear,
            this.tsbShowControllerResponse});
            this.toolStrip.Location = new System.Drawing.Point(0, 30);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1157, 75);
            this.toolStrip.TabIndex = 4;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsbStart
            // 
            this.tsbStart.Image = global::WMS.LabelController.Properties.Resources.media_playback_start;
            this.tsbStart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStart.Name = "tsbStart";
            this.tsbStart.Size = new System.Drawing.Size(73, 72);
            this.tsbStart.Text = "启动服务";
            this.tsbStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbStart.Click += new System.EventHandler(this.tsbStart_Click);
            // 
            // tsbStop
            // 
            this.tsbStop.Enabled = false;
            this.tsbStop.Image = global::WMS.LabelController.Properties.Resources.media_playback_stop;
            this.tsbStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStop.Name = "tsbStop";
            this.tsbStop.Size = new System.Drawing.Size(73, 72);
            this.tsbStop.Text = "关闭服务";
            this.tsbStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbStop.Click += new System.EventHandler(this.tsbStop_Click);
            // 
            // tsbClear
            // 
            this.tsbClear.Enabled = false;
            this.tsbClear.Image = global::WMS.LabelController.Properties.Resources.edit_clear;
            this.tsbClear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClear.Name = "tsbClear";
            this.tsbClear.Size = new System.Drawing.Size(73, 72);
            this.tsbClear.Text = "清除日志";
            this.tsbClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbClear.Click += new System.EventHandler(this.tsbClear_Click);
            // 
            // tsbShowControllerResponse
            // 
            this.tsbShowControllerResponse.Checked = true;
            this.tsbShowControllerResponse.CheckOnClick = true;
            this.tsbShowControllerResponse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbShowControllerResponse.Enabled = false;
            this.tsbShowControllerResponse.Image = global::WMS.LabelController.Properties.Resources.log;
            this.tsbShowControllerResponse.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbShowControllerResponse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShowControllerResponse.Name = "tsbShowControllerResponse";
            this.tsbShowControllerResponse.Size = new System.Drawing.Size(103, 72);
            this.tsbShowControllerResponse.Text = "显示标签应答";
            this.tsbShowControllerResponse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbShowControllerResponse.CheckedChanged += new System.EventHandler(this.tsbShowControllerResponse_CheckedChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 698);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(1157, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // gpLogs
            // 
            this.gpLogs.Controls.Add(this.txtLogs);
            this.gpLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpLogs.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpLogs.Location = new System.Drawing.Point(0, 105);
            this.gpLogs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpLogs.Name = "gpLogs";
            this.gpLogs.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpLogs.Size = new System.Drawing.Size(1157, 593);
            this.gpLogs.TabIndex = 6;
            this.gpLogs.TabStop = false;
            this.gpLogs.Text = "运行日志";
            // 
            // txtLogs
            // 
            this.txtLogs.BackColor = System.Drawing.Color.Black;
            this.txtLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogs.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLogs.ForeColor = System.Drawing.Color.Lime;
            this.txtLogs.Location = new System.Drawing.Point(3, 24);
            this.txtLogs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.Size = new System.Drawing.Size(1151, 565);
            this.txtLogs.TabIndex = 0;
            this.txtLogs.Text = "";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "电子标签服务控制中心";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // timerTask
            // 
            this.timerTask.Interval = 1000;
            this.timerTask.Tick += new System.EventHandler(this.timerTask_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 720);
            this.Controls.Add(this.gpLogs);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1164, 758);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电子标签服务控制中心";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.SizeChanged += new System.EventHandler(this.FrmMain_SizeChanged);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.gpLogs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem itmTool;
        private System.Windows.Forms.ToolStripMenuItem itmLabelTest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem itmExit;
        private System.Windows.Forms.ToolStripMenuItem itmAbout;
        private System.Windows.Forms.ToolStripMenuItem itmSysInfo;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbStart;
        private System.Windows.Forms.ToolStripButton tsbStop;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.GroupBox gpLogs;
        private System.Windows.Forms.RichTextBox txtLogs;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripButton tsbShowControllerResponse;
        private System.Windows.Forms.Timer timerTask;
    }
}

