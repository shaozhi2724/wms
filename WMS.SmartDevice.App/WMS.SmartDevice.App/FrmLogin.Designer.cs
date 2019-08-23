namespace WMS.SmartDevice.App
{
    partial class FrmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu;

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
            this.muExit = new System.Windows.Forms.MenuItem();
            this.muSetting = new System.Windows.Forms.MenuItem();
            this.panUnqualified = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDeviceNumber = new System.Windows.Forms.Label();
            this.panUnqualified.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.muExit);
            this.mainMenu.MenuItems.Add(this.muSetting);
            // 
            // muExit
            // 
            this.muExit.Text = "退出";
            this.muExit.Click += new System.EventHandler(this.muExit_Click);
            // 
            // muSetting
            // 
            this.muSetting.Text = "设置";
            this.muSetting.Click += new System.EventHandler(this.muSetting_Click);
            // 
            // panUnqualified
            // 
            this.panUnqualified.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panUnqualified.Controls.Add(this.lblDeviceNumber);
            this.panUnqualified.Controls.Add(this.label1);
            this.panUnqualified.Controls.Add(this.txtPassword);
            this.panUnqualified.Controls.Add(this.lblPassword);
            this.panUnqualified.Controls.Add(this.txtUsername);
            this.panUnqualified.Controls.Add(this.lblUsername);
            this.panUnqualified.Controls.Add(this.btnLogin);
            this.panUnqualified.Controls.Add(this.lblTitle);
            this.panUnqualified.Location = new System.Drawing.Point(14, 37);
            this.panUnqualified.Name = "panUnqualified";
            this.panUnqualified.Size = new System.Drawing.Size(210, 200);
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = true;
            this.txtPassword.AcceptsTab = true;
            this.txtPassword.Location = new System.Drawing.Point(74, 78);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(122, 21);
            this.txtPassword.TabIndex = 15;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(17, 80);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(51, 16);
            this.lblPassword.Text = "密码：";
            // 
            // txtUsername
            // 
            this.txtUsername.AcceptsReturn = true;
            this.txtUsername.AcceptsTab = true;
            this.txtUsername.Location = new System.Drawing.Point(74, 51);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(122, 21);
            this.txtUsername.TabIndex = 14;
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(17, 51);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(51, 14);
            this.lblUsername.Text = "帐号：";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(17, 156);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(179, 30);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "登录";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(37, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(159, 22);
            this.lblTitle.Text = "登录DQS RF扫描系统";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.Text = "设备号：";
            // 
            // lblDeviceNumber
            // 
            this.lblDeviceNumber.Location = new System.Drawing.Point(83, 126);
            this.lblDeviceNumber.Name = "lblDeviceNumber";
            this.lblDeviceNumber.Size = new System.Drawing.Size(113, 16);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 266);
            this.Controls.Add(this.panUnqualified);
            this.Menu = this.mainMenu;
            this.Name = "FrmLogin";
            this.Text = "DQS RF扫描系统－博科智信";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panUnqualified.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem muExit;
        private System.Windows.Forms.MenuItem muSetting;
        private System.Windows.Forms.Panel panUnqualified;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblDeviceNumber;
        private System.Windows.Forms.Label label1;
    }
}

