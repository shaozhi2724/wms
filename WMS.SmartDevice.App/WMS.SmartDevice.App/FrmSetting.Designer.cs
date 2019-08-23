namespace WMS.SmartDevice.App
{
    partial class FrmSetting
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
            this.mainMenu = new System.Windows.Forms.MainMenu();
            this.muSave = new System.Windows.Forms.MenuItem();
            this.muExit = new System.Windows.Forms.MenuItem();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.chkSystemSignPosition = new System.Windows.Forms.CheckBox();
            this.chkPrintCargoBarcode = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.muSave);
            this.mainMenu.MenuItems.Add(this.muExit);
            // 
            // muSave
            // 
            this.muSave.Text = "保存";
            this.muSave.Click += new System.EventHandler(this.muSave_Click);
            // 
            // muExit
            // 
            this.muExit.Text = "退出";
            this.muExit.Click += new System.EventHandler(this.muExit_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(84, 131);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(142, 25);
            this.txtPassword.TabIndex = 5;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(85, 20);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(142, 25);
            this.txtServer.TabIndex = 1;
            // 
            // lblServer
            // 
            this.lblServer.Location = new System.Drawing.Point(5, 21);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(74, 20);
            this.lblServer.Text = "服务器：";
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(5, 132);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(74, 20);
            this.lblPassword.Text = "密　码：";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(85, 102);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(142, 25);
            this.txtUsername.TabIndex = 4;
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(5, 103);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(74, 20);
            this.lblUsername.Text = "用户名：";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(85, 75);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(142, 25);
            this.txtDatabase.TabIndex = 3;
            // 
            // lblDatabase
            // 
            this.lblDatabase.Location = new System.Drawing.Point(5, 76);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(74, 20);
            this.lblDatabase.Text = "数据库：";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(85, 48);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(142, 25);
            this.txtPort.TabIndex = 2;
            // 
            // lblPort
            // 
            this.lblPort.Location = new System.Drawing.Point(5, 49);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(74, 20);
            this.lblPort.Text = "端　口：";
            // 
            // chkSystemSignPosition
            // 
            this.chkSystemSignPosition.Location = new System.Drawing.Point(5, 175);
            this.chkSystemSignPosition.Name = "chkSystemSignPosition";
            this.chkSystemSignPosition.Size = new System.Drawing.Size(221, 20);
            this.chkSystemSignPosition.TabIndex = 6;
            this.chkSystemSignPosition.Text = "系统自动分配入库货位";
            // 
            // chkPrintCargoBarcode
            // 
            this.chkPrintCargoBarcode.Location = new System.Drawing.Point(6, 201);
            this.chkPrintCargoBarcode.Name = "chkPrintCargoBarcode";
            this.chkPrintCargoBarcode.Size = new System.Drawing.Size(221, 20);
            this.chkPrintCargoBarcode.TabIndex = 12;
            this.chkPrintCargoBarcode.Text = "入库需扫描货物码";
            // 
            // FrmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.chkPrintCargoBarcode);
            this.Controls.Add(this.chkSystemSignPosition);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblPort);
            this.Menu = this.mainMenu;
            this.Name = "FrmSetting";
            this.Text = "设置";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem muSave;
        private System.Windows.Forms.MenuItem muExit;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.CheckBox chkSystemSignPosition;
        private System.Windows.Forms.CheckBox chkPrintCargoBarcode;
    }
}