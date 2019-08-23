namespace WMS.Windows.App
{
    partial class FrmLicenserIdentification
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
            this.lblComputerID = new DevComponents.DotNetBar.LabelX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.txtComputerID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnCopy = new DevComponents.DotNetBar.ButtonX();
            this.txtLicenseFile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblLicenseFile = new DevComponents.DotNetBar.LabelX();
            this.btnBrowser = new DevComponents.DotNetBar.ButtonX();
            this.btnRegister = new DevComponents.DotNetBar.ButtonX();
            this.fdgLicenseFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblComputerID
            // 
            // 
            // 
            // 
            this.lblComputerID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblComputerID.Location = new System.Drawing.Point(42, 33);
            this.lblComputerID.Name = "lblComputerID";
            this.lblComputerID.Size = new System.Drawing.Size(75, 23);
            this.lblComputerID.TabIndex = 0;
            this.lblComputerID.Text = "注册标识:";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(339, 161);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 23);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭(&C)";
            // 
            // txtComputerID
            // 
            // 
            // 
            // 
            this.txtComputerID.Border.Class = "TextBoxBorder";
            this.txtComputerID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtComputerID.Location = new System.Drawing.Point(170, 33);
            this.txtComputerID.Name = "txtComputerID";
            this.txtComputerID.PreventEnterBeep = true;
            this.txtComputerID.Size = new System.Drawing.Size(401, 27);
            this.txtComputerID.TabIndex = 0;
            // 
            // btnCopy
            // 
            this.btnCopy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCopy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCopy.Location = new System.Drawing.Point(590, 33);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "复制(&D)";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtLicenseFile
            // 
            // 
            // 
            // 
            this.txtLicenseFile.Border.Class = "TextBoxBorder";
            this.txtLicenseFile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLicenseFile.Location = new System.Drawing.Point(170, 91);
            this.txtLicenseFile.Name = "txtLicenseFile";
            this.txtLicenseFile.PreventEnterBeep = true;
            this.txtLicenseFile.Size = new System.Drawing.Size(401, 27);
            this.txtLicenseFile.TabIndex = 2;
            // 
            // lblLicenseFile
            // 
            // 
            // 
            // 
            this.lblLicenseFile.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblLicenseFile.Location = new System.Drawing.Point(42, 91);
            this.lblLicenseFile.Name = "lblLicenseFile";
            this.lblLicenseFile.Size = new System.Drawing.Size(75, 23);
            this.lblLicenseFile.TabIndex = 4;
            this.lblLicenseFile.Text = "注册文件:";
            // 
            // btnBrowser
            // 
            this.btnBrowser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBrowser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBrowser.Location = new System.Drawing.Point(590, 95);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBrowser.TabIndex = 3;
            this.btnBrowser.Text = "浏览...";
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRegister.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRegister.Enabled = false;
            this.btnRegister.Location = new System.Drawing.Point(204, 161);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "注册(&R)";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // fdgLicenseFile
            // 
            this.fdgLicenseFile.FileName = "WMS.lic";
            this.fdgLicenseFile.Filter = "WMS注册文件(*.lic)|*.lic";
            this.fdgLicenseFile.Title = "导入WMS注册文件";
            this.fdgLicenseFile.FileOk += new System.ComponentModel.CancelEventHandler(this.fdgLicenseFile_FileOk);
            // 
            // FrmLicenserIdentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 211);
            this.ControlBox = false;
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.txtLicenseFile);
            this.Controls.Add(this.lblLicenseFile);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtComputerID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblComputerID);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLicenserIdentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WMS注册";
            this.Load += new System.EventHandler(this.FrmLicenserIdentification_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblComputerID;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.Controls.TextBoxX txtComputerID;
        private DevComponents.DotNetBar.ButtonX btnCopy;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLicenseFile;
        private DevComponents.DotNetBar.LabelX lblLicenseFile;
        private DevComponents.DotNetBar.ButtonX btnBrowser;
        private DevComponents.DotNetBar.ButtonX btnRegister;
        private System.Windows.Forms.OpenFileDialog fdgLicenseFile;
    }
}