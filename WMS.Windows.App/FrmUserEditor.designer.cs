namespace WMS.Windows.App
{
    partial class FrmUserEditor
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
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.cbxRole = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtConfirmPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtRealname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtUsername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.swtIsActive = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.lblConfirmPassword = new DevComponents.DotNetBar.LabelX();
            this.lblRole = new DevComponents.DotNetBar.LabelX();
            this.lblRealName = new DevComponents.DotNetBar.LabelX();
            this.lblPassword = new DevComponents.DotNetBar.LabelX();
            this.lblUserName = new DevComponents.DotNetBar.LabelX();
            this.lblIsActive = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.highlighter.SetHighlightOnFocus(this.btnCancel, true);
            this.btnCancel.Location = new System.Drawing.Point(304, 289);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 31);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.highlighter.SetHighlightOnFocus(this.btnSave, true);
            this.btnSave.Location = new System.Drawing.Point(161, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 31);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            // 
            // cbxRole
            // 
            this.cbxRole.DisplayMember = "Text";
            this.cbxRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRole.FormattingEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.cbxRole, true);
            this.cbxRole.ItemHeight = 21;
            this.cbxRole.Location = new System.Drawing.Point(197, 182);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(226, 27);
            this.cbxRole.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxRole.TabIndex = 4;
            this.cbxRole.WatermarkText = "请选择";
            // 
            // txtConfirmPassword
            // 
            // 
            // 
            // 
            this.txtConfirmPassword.Border.Class = "TextBoxBorder";
            this.txtConfirmPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter.SetHighlightOnFocus(this.txtConfirmPassword, true);
            this.txtConfirmPassword.Location = new System.Drawing.Point(197, 149);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PreventEnterBeep = true;
            this.txtConfirmPassword.Size = new System.Drawing.Size(226, 27);
            this.txtConfirmPassword.TabIndex = 3;
            // 
            // txtRealname
            // 
            // 
            // 
            // 
            this.txtRealname.Border.Class = "TextBoxBorder";
            this.txtRealname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter.SetHighlightOnFocus(this.txtRealname, true);
            this.txtRealname.Location = new System.Drawing.Point(197, 83);
            this.txtRealname.Name = "txtRealname";
            this.txtRealname.PreventEnterBeep = true;
            this.txtRealname.Size = new System.Drawing.Size(226, 27);
            this.txtRealname.TabIndex = 1;
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter.SetHighlightOnFocus(this.txtPassword, true);
            this.txtPassword.Location = new System.Drawing.Point(197, 116);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PreventEnterBeep = true;
            this.txtPassword.Size = new System.Drawing.Size(226, 27);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.Border.Class = "TextBoxBorder";
            this.txtUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter.SetHighlightOnFocus(this.txtUsername, true);
            this.txtUsername.Location = new System.Drawing.Point(197, 50);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PreventEnterBeep = true;
            this.txtUsername.Size = new System.Drawing.Size(226, 27);
            this.txtUsername.TabIndex = 0;
            // 
            // swtIsActive
            // 
            // 
            // 
            // 
            this.swtIsActive.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter.SetHighlightOnFocus(this.swtIsActive, true);
            this.swtIsActive.Location = new System.Drawing.Point(197, 231);
            this.swtIsActive.Name = "swtIsActive";
            this.swtIsActive.OffText = "是";
            this.swtIsActive.OnText = "否";
            this.swtIsActive.Size = new System.Drawing.Size(66, 22);
            this.swtIsActive.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swtIsActive.TabIndex = 5;
            this.swtIsActive.Value = true;
            this.swtIsActive.ValueObject = "Y";
            // 
            // lblConfirmPassword
            // 
            // 
            // 
            // 
            this.lblConfirmPassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblConfirmPassword.Location = new System.Drawing.Point(78, 149);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(97, 23);
            this.lblConfirmPassword.TabIndex = 57;
            this.lblConfirmPassword.Text = "确认密码：";
            this.lblConfirmPassword.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblRole
            // 
            // 
            // 
            // 
            this.lblRole.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRole.Location = new System.Drawing.Point(78, 182);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(97, 23);
            this.lblRole.TabIndex = 56;
            this.lblRole.Text = "角色：";
            this.lblRole.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblRealName
            // 
            // 
            // 
            // 
            this.lblRealName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRealName.Location = new System.Drawing.Point(78, 83);
            this.lblRealName.Name = "lblRealName";
            this.lblRealName.Size = new System.Drawing.Size(97, 23);
            this.lblRealName.TabIndex = 55;
            this.lblRealName.Text = "姓名：";
            this.lblRealName.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblPassword
            // 
            // 
            // 
            // 
            this.lblPassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPassword.Location = new System.Drawing.Point(78, 116);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(97, 23);
            this.lblPassword.TabIndex = 54;
            this.lblPassword.Text = "密码：";
            this.lblPassword.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblUserName
            // 
            // 
            // 
            // 
            this.lblUserName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblUserName.Location = new System.Drawing.Point(78, 50);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(97, 23);
            this.lblUserName.TabIndex = 53;
            this.lblUserName.Text = "用户名：";
            this.lblUserName.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblIsActive
            // 
            // 
            // 
            // 
            this.lblIsActive.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblIsActive.Location = new System.Drawing.Point(78, 231);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(97, 23);
            this.lblIsActive.TabIndex = 59;
            this.lblIsActive.Text = "是否禁用：";
            this.lblIsActive.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // FrmUserEditor
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 332);
            this.Controls.Add(this.lblIsActive);
            this.Controls.Add(this.swtIsActive);
            this.Controls.Add(this.cbxRole);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.txtRealname);
            this.Controls.Add(this.lblRealName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUserEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "用户信息管理";
            this.Load += new System.EventHandler(this.FrmUserEditor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxRole;
        private DevComponents.DotNetBar.Controls.TextBoxX txtConfirmPassword;
        private DevComponents.DotNetBar.LabelX lblConfirmPassword;
        private DevComponents.DotNetBar.LabelX lblRole;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRealname;
        private DevComponents.DotNetBar.LabelX lblRealName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
        private DevComponents.DotNetBar.LabelX lblPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUsername;
        private DevComponents.DotNetBar.LabelX lblUserName;
        private DevComponents.DotNetBar.LabelX lblIsActive;
        private DevComponents.DotNetBar.Controls.SwitchButton swtIsActive;

    }
}