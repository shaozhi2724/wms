namespace WMS.Windows.App
{
    partial class FrmWarehouseEditor
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
            this.lblWarehouseCode = new DevComponents.DotNetBar.LabelX();
            this.lblWarehouseName = new DevComponents.DotNetBar.LabelX();
            this.lblCharge = new DevComponents.DotNetBar.LabelX();
            this.lblEnvironment = new DevComponents.DotNetBar.LabelX();
            this.btnReset = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.txtWarehouseCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtWarehouseName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCharge = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbxEnvironment = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtPurpose = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPurpose = new DevComponents.DotNetBar.LabelX();
            this.txtPhone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPhone = new DevComponents.DotNetBar.LabelX();
            this.txtRemark = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblRemark = new DevComponents.DotNetBar.LabelX();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.SuspendLayout();
            // 
            // lblWarehouseCode
            // 
            // 
            // 
            // 
            this.lblWarehouseCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblWarehouseCode.Location = new System.Drawing.Point(22, 23);
            this.lblWarehouseCode.Name = "lblWarehouseCode";
            this.lblWarehouseCode.Size = new System.Drawing.Size(75, 23);
            this.lblWarehouseCode.TabIndex = 4;
            this.lblWarehouseCode.Text = "仓库编号：";
            // 
            // lblWarehouseName
            // 
            // 
            // 
            // 
            this.lblWarehouseName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblWarehouseName.Location = new System.Drawing.Point(304, 24);
            this.lblWarehouseName.Name = "lblWarehouseName";
            this.lblWarehouseName.Size = new System.Drawing.Size(75, 23);
            this.lblWarehouseName.TabIndex = 5;
            this.lblWarehouseName.Text = "仓库名称：";
            // 
            // lblCharge
            // 
            // 
            // 
            // 
            this.lblCharge.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCharge.Location = new System.Drawing.Point(304, 133);
            this.lblCharge.Name = "lblCharge";
            this.lblCharge.Size = new System.Drawing.Size(75, 23);
            this.lblCharge.TabIndex = 6;
            this.lblCharge.Text = "负责人：";
            // 
            // lblEnvironment
            // 
            // 
            // 
            // 
            this.lblEnvironment.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEnvironment.Location = new System.Drawing.Point(304, 80);
            this.lblEnvironment.Name = "lblEnvironment";
            this.lblEnvironment.Size = new System.Drawing.Size(75, 23);
            this.lblEnvironment.TabIndex = 7;
            this.lblEnvironment.Text = "存储环境：";
            // 
            // btnReset
            // 
            this.btnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.highlighter.SetHighlightOnFocus(this.btnReset, true);
            this.btnReset.Location = new System.Drawing.Point(244, 340);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "重置";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.highlighter.SetHighlightOnFocus(this.btnCancel, true);
            this.btnCancel.Location = new System.Drawing.Point(344, 340);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.highlighter.SetHighlightOnFocus(this.btnSave, true);
            this.btnSave.Location = new System.Drawing.Point(142, 340);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtWarehouseCode
            // 
            // 
            // 
            // 
            this.txtWarehouseCode.Border.Class = "TextBoxBorder";
            this.txtWarehouseCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter.SetHighlightOnFocus(this.txtWarehouseCode, true);
            this.txtWarehouseCode.Location = new System.Drawing.Point(103, 23);
            this.txtWarehouseCode.Name = "txtWarehouseCode";
            this.txtWarehouseCode.PreventEnterBeep = true;
            this.txtWarehouseCode.Size = new System.Drawing.Size(158, 23);
            this.txtWarehouseCode.TabIndex = 0;
            // 
            // txtWarehouseName
            // 
            // 
            // 
            // 
            this.txtWarehouseName.Border.Class = "TextBoxBorder";
            this.txtWarehouseName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter.SetHighlightOnFocus(this.txtWarehouseName, true);
            this.txtWarehouseName.Location = new System.Drawing.Point(385, 24);
            this.txtWarehouseName.Name = "txtWarehouseName";
            this.txtWarehouseName.PreventEnterBeep = true;
            this.txtWarehouseName.Size = new System.Drawing.Size(158, 23);
            this.txtWarehouseName.TabIndex = 1;
            // 
            // txtCharge
            // 
            // 
            // 
            // 
            this.txtCharge.Border.Class = "TextBoxBorder";
            this.txtCharge.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter.SetHighlightOnFocus(this.txtCharge, true);
            this.txtCharge.Location = new System.Drawing.Point(385, 133);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.PreventEnterBeep = true;
            this.txtCharge.Size = new System.Drawing.Size(158, 23);
            this.txtCharge.TabIndex = 5;
            // 
            // cbxEnvironment
            // 
            this.cbxEnvironment.DisplayMember = "Text";
            this.cbxEnvironment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxEnvironment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEnvironment.FormattingEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.cbxEnvironment, true);
            this.cbxEnvironment.ItemHeight = 17;
            this.cbxEnvironment.Location = new System.Drawing.Point(385, 79);
            this.cbxEnvironment.Name = "cbxEnvironment";
            this.cbxEnvironment.Size = new System.Drawing.Size(158, 23);
            this.cbxEnvironment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxEnvironment.TabIndex = 3;
            this.cbxEnvironment.WatermarkText = "请选择";
            // 
            // txtPurpose
            // 
            // 
            // 
            // 
            this.txtPurpose.Border.Class = "TextBoxBorder";
            this.txtPurpose.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter.SetHighlightOnFocus(this.txtPurpose, true);
            this.txtPurpose.Location = new System.Drawing.Point(103, 79);
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.PreventEnterBeep = true;
            this.txtPurpose.Size = new System.Drawing.Size(158, 23);
            this.txtPurpose.TabIndex = 2;
            // 
            // lblPurpose
            // 
            // 
            // 
            // 
            this.lblPurpose.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPurpose.Location = new System.Drawing.Point(22, 79);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(75, 23);
            this.lblPurpose.TabIndex = 21;
            this.lblPurpose.Text = "仓库用途：";
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.Border.Class = "TextBoxBorder";
            this.txtPhone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter.SetHighlightOnFocus(this.txtPhone, true);
            this.txtPhone.Location = new System.Drawing.Point(103, 133);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PreventEnterBeep = true;
            this.txtPhone.Size = new System.Drawing.Size(158, 23);
            this.txtPhone.TabIndex = 4;
            // 
            // lblPhone
            // 
            // 
            // 
            // 
            this.lblPhone.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPhone.Location = new System.Drawing.Point(22, 133);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(75, 23);
            this.lblPhone.TabIndex = 23;
            this.lblPhone.Text = "仓库电话：";
            // 
            // txtRemark
            // 
            // 
            // 
            // 
            this.txtRemark.Border.Class = "TextBoxBorder";
            this.txtRemark.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter.SetHighlightOnFocus(this.txtRemark, true);
            this.txtRemark.Location = new System.Drawing.Point(22, 214);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.PreventEnterBeep = true;
            this.txtRemark.Size = new System.Drawing.Size(521, 106);
            this.txtRemark.TabIndex = 6;
            // 
            // lblRemark
            // 
            // 
            // 
            // 
            this.lblRemark.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRemark.Location = new System.Drawing.Point(22, 185);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(75, 23);
            this.lblRemark.TabIndex = 26;
            this.lblRemark.Text = "备注：";
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            // 
            // FrmWarehouseEditor
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 385);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPurpose);
            this.Controls.Add(this.lblPurpose);
            this.Controls.Add(this.cbxEnvironment);
            this.Controls.Add(this.txtCharge);
            this.Controls.Add(this.txtWarehouseName);
            this.Controls.Add(this.txtWarehouseCode);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblEnvironment);
            this.Controls.Add(this.lblCharge);
            this.Controls.Add(this.lblWarehouseName);
            this.Controls.Add(this.lblWarehouseCode);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWarehouseEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "仓库信息管理";
            this.Load += new System.EventHandler(this.FrmWarehouseEditor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblWarehouseCode;
        private DevComponents.DotNetBar.LabelX lblWarehouseName;
        private DevComponents.DotNetBar.LabelX lblCharge;
        private DevComponents.DotNetBar.LabelX lblEnvironment;
        private DevComponents.DotNetBar.ButtonX btnReset;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.TextBoxX txtWarehouseCode;
        private DevComponents.DotNetBar.Controls.TextBoxX txtWarehouseName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCharge;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxEnvironment;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPurpose;
        private DevComponents.DotNetBar.LabelX lblPurpose;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPhone;
        private DevComponents.DotNetBar.LabelX lblPhone;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRemark;
        private DevComponents.DotNetBar.LabelX lblRemark;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;

    }
}