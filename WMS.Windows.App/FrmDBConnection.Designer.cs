namespace WMS.Windows.App
{
    partial class FrmDBConnection
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDBConnection));
            this.txtServerName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblServerName = new DevComponents.DotNetBar.LabelX();
            this.lblDatabaseName = new DevComponents.DotNetBar.LabelX();
            this.txtDatabaseName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.chkIntegratedSecurity = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.lblPassword = new DevComponents.DotNetBar.LabelX();
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblUserName = new DevComponents.DotNetBar.LabelX();
            this.txtUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.superValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.customValidator1 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.customValidator2 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtServerName
            // 
            // 
            // 
            // 
            this.txtServerName.Border.Class = "TextBoxBorder";
            this.txtServerName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter.SetHighlightOnFocus(this.txtServerName, true);
            this.txtServerName.Location = new System.Drawing.Point(100, 22);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.PreventEnterBeep = true;
            this.txtServerName.Size = new System.Drawing.Size(232, 23);
            this.txtServerName.TabIndex = 0;
            this.superValidator.SetValidator1(this.txtServerName, this.customValidator1);
            // 
            // lblServerName
            // 
            // 
            // 
            // 
            this.lblServerName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblServerName.Location = new System.Drawing.Point(35, 17);
            this.lblServerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(59, 30);
            this.lblServerName.TabIndex = 1;
            this.lblServerName.Text = "服务器：";
            // 
            // lblDatabaseName
            // 
            // 
            // 
            // 
            this.lblDatabaseName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDatabaseName.Location = new System.Drawing.Point(35, 64);
            this.lblDatabaseName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.Size = new System.Drawing.Size(59, 30);
            this.lblDatabaseName.TabIndex = 3;
            this.lblDatabaseName.Text = "数据库：";
            // 
            // txtDatabaseName
            // 
            // 
            // 
            // 
            this.txtDatabaseName.Border.Class = "TextBoxBorder";
            this.txtDatabaseName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter.SetHighlightOnFocus(this.txtDatabaseName, true);
            this.txtDatabaseName.Location = new System.Drawing.Point(100, 69);
            this.txtDatabaseName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.PreventEnterBeep = true;
            this.txtDatabaseName.Size = new System.Drawing.Size(232, 23);
            this.txtDatabaseName.TabIndex = 2;
            this.superValidator.SetValidator1(this.txtDatabaseName, this.customValidator2);
            // 
            // chkIntegratedSecurity
            // 
            // 
            // 
            // 
            this.chkIntegratedSecurity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkIntegratedSecurity.Location = new System.Drawing.Point(35, 117);
            this.chkIntegratedSecurity.Name = "chkIntegratedSecurity";
            this.chkIntegratedSecurity.Size = new System.Drawing.Size(130, 23);
            this.chkIntegratedSecurity.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkIntegratedSecurity.TabIndex = 4;
            this.chkIntegratedSecurity.Text = "Windows身份认证";
            this.chkIntegratedSecurity.CheckedChanged += new System.EventHandler(this.chkIntegratedSecurity_CheckedChanged);
            // 
            // lblPassword
            // 
            // 
            // 
            // 
            this.lblPassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPassword.Location = new System.Drawing.Point(35, 206);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 30);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "密　码：";
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter.SetHighlightOnFocus(this.txtPassword, true);
            this.txtPassword.Location = new System.Drawing.Point(100, 211);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PreventEnterBeep = true;
            this.txtPassword.Size = new System.Drawing.Size(232, 23);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            this.superValidator.SetValidator1(this.txtPassword, this.customValidator2);
            // 
            // lblUserName
            // 
            // 
            // 
            // 
            this.lblUserName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblUserName.Location = new System.Drawing.Point(35, 159);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(59, 30);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "用户名：";
            // 
            // txtUserName
            // 
            // 
            // 
            // 
            this.txtUserName.Border.Class = "TextBoxBorder";
            this.txtUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter.SetHighlightOnFocus(this.txtUserName, true);
            this.txtUserName.Location = new System.Drawing.Point(100, 164);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PreventEnterBeep = true;
            this.txtUserName.Size = new System.Drawing.Size(232, 23);
            this.txtUserName.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(100, 263);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(205, 263);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "取消";
            // 
            // superValidator
            // 
            this.superValidator.ContainerControl = this;
            this.superValidator.ErrorProvider = this.errorProvider;
            this.superValidator.Highlighter = this.highlighter;
            // 
            // customValidator1
            // 
            this.customValidator1.ErrorMessage = "Your error message here.";
            this.customValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // customValidator2
            // 
            this.customValidator2.ErrorMessage = "Your error message here.";
            this.customValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            // 
            // FrmDBConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 315);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.chkIntegratedSecurity);
            this.Controls.Add(this.lblDatabaseName);
            this.Controls.Add(this.txtDatabaseName);
            this.Controls.Add(this.lblServerName);
            this.Controls.Add(this.txtServerName);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDBConnection";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "创建数据库连接";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtServerName;
        private DevComponents.DotNetBar.LabelX lblServerName;
        private DevComponents.DotNetBar.LabelX lblDatabaseName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDatabaseName;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkIntegratedSecurity;
        private DevComponents.DotNetBar.LabelX lblPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
        private DevComponents.DotNetBar.LabelX lblUserName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUserName;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator2;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator1;
    }
}