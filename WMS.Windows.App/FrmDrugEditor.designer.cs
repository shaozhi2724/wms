namespace WMS.Windows.App
{
    partial class FrmDrugEditor
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
            this.btnReset = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.cbxStockCondition = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtScatteredCargoSpaceMaximum = new DevComponents.Editors.IntegerInput();
            this.txtStockMinAmount = new DevComponents.Editors.IntegerInput();
            this.txtEntireCargoSpaceMaximum = new DevComponents.Editors.IntegerInput();
            this.txtPackagingProportion = new DevComponents.Editors.IntegerInput();
            this.txtProducerName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtProductBarCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtProductName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtProductCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtScatteredCargoSpaceMinimum = new DevComponents.Editors.IntegerInput();
            this.lblScatteredSpaceUnit = new DevComponents.DotNetBar.LabelX();
            this.lblStockMinAmountUnit = new DevComponents.DotNetBar.LabelX();
            this.lblEntireSpaceUnit = new DevComponents.DotNetBar.LabelX();
            this.lblStockMinAmount = new DevComponents.DotNetBar.LabelX();
            this.lblScatteredCargoSpaceMaximum = new DevComponents.DotNetBar.LabelX();
            this.lblEntireCargoSpaceMaximum = new DevComponents.DotNetBar.LabelX();
            this.lblPackagingProportionBaseNumber = new DevComponents.DotNetBar.LabelX();
            this.lblPackagingProportion = new DevComponents.DotNetBar.LabelX();
            this.lblProducerName = new DevComponents.DotNetBar.LabelX();
            this.lblStockCondition = new DevComponents.DotNetBar.LabelX();
            this.lblProductBarCode = new DevComponents.DotNetBar.LabelX();
            this.lblProductName = new DevComponents.DotNetBar.LabelX();
            this.lblProductCode = new DevComponents.DotNetBar.LabelX();
            this.lblScatteredCargoSpaceMinUnit = new DevComponents.DotNetBar.LabelX();
            this.lblScatteredCargoSpaceMinimum = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.swbIsSupervise = new DevComponents.DotNetBar.Controls.SwitchButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtScatteredCargoSpaceMaximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockMinAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntireCargoSpaceMaximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPackagingProportion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScatteredCargoSpaceMinimum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.highlighter.SetHighlightOnFocus(this.btnReset, true);
            this.btnReset.Location = new System.Drawing.Point(241, 356);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "重置";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.highlighter.SetHighlightOnFocus(this.btnCancel, true);
            this.btnCancel.Location = new System.Drawing.Point(341, 356);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "取消";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.highlighter.SetHighlightOnFocus(this.btnSave, true);
            this.btnSave.Location = new System.Drawing.Point(139, 356);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            // 
            // cbxStockCondition
            // 
            this.cbxStockCondition.DisplayMember = "Text";
            this.cbxStockCondition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxStockCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStockCondition.FormattingEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.cbxStockCondition, true);
            this.cbxStockCondition.ItemHeight = 21;
            this.cbxStockCondition.Location = new System.Drawing.Point(380, 57);
            this.cbxStockCondition.Name = "cbxStockCondition";
            this.cbxStockCondition.Size = new System.Drawing.Size(150, 27);
            this.cbxStockCondition.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxStockCondition.TabIndex = 3;
            this.cbxStockCondition.WatermarkText = "请选择";
            // 
            // txtScatteredCargoSpaceMaximum
            // 
            // 
            // 
            // 
            this.txtScatteredCargoSpaceMaximum.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtScatteredCargoSpaceMaximum.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtScatteredCargoSpaceMaximum.ButtonCalculator.Tooltip = "";
            this.txtScatteredCargoSpaceMaximum.ButtonClear.Tooltip = "";
            this.txtScatteredCargoSpaceMaximum.ButtonCustom.Tooltip = "";
            this.txtScatteredCargoSpaceMaximum.ButtonCustom2.Tooltip = "";
            this.txtScatteredCargoSpaceMaximum.ButtonDropDown.Tooltip = "";
            this.txtScatteredCargoSpaceMaximum.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtScatteredCargoSpaceMaximum.ButtonFreeText.Tooltip = "";
            this.highlighter.SetHighlightOnFocus(this.txtScatteredCargoSpaceMaximum, true);
            this.txtScatteredCargoSpaceMaximum.Location = new System.Drawing.Point(161, 163);
            this.txtScatteredCargoSpaceMaximum.MinValue = 0;
            this.txtScatteredCargoSpaceMaximum.Name = "txtScatteredCargoSpaceMaximum";
            this.txtScatteredCargoSpaceMaximum.ShowUpDown = true;
            this.txtScatteredCargoSpaceMaximum.Size = new System.Drawing.Size(100, 27);
            this.txtScatteredCargoSpaceMaximum.TabIndex = 7;
            // 
            // txtStockMinAmount
            // 
            // 
            // 
            // 
            this.txtStockMinAmount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtStockMinAmount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStockMinAmount.ButtonCalculator.Tooltip = "";
            this.txtStockMinAmount.ButtonClear.Tooltip = "";
            this.txtStockMinAmount.ButtonCustom.Tooltip = "";
            this.txtStockMinAmount.ButtonCustom2.Tooltip = "";
            this.txtStockMinAmount.ButtonDropDown.Tooltip = "";
            this.txtStockMinAmount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtStockMinAmount.ButtonFreeText.Tooltip = "";
            this.highlighter.SetHighlightOnFocus(this.txtStockMinAmount, true);
            this.txtStockMinAmount.Location = new System.Drawing.Point(161, 221);
            this.txtStockMinAmount.MinValue = 0;
            this.txtStockMinAmount.Name = "txtStockMinAmount";
            this.txtStockMinAmount.ShowUpDown = true;
            this.txtStockMinAmount.Size = new System.Drawing.Size(100, 27);
            this.txtStockMinAmount.TabIndex = 9;
            // 
            // txtEntireCargoSpaceMaximum
            // 
            // 
            // 
            // 
            this.txtEntireCargoSpaceMaximum.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtEntireCargoSpaceMaximum.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEntireCargoSpaceMaximum.ButtonCalculator.Tooltip = "";
            this.txtEntireCargoSpaceMaximum.ButtonClear.Tooltip = "";
            this.txtEntireCargoSpaceMaximum.ButtonCustom.Tooltip = "";
            this.txtEntireCargoSpaceMaximum.ButtonCustom2.Tooltip = "";
            this.txtEntireCargoSpaceMaximum.ButtonDropDown.Tooltip = "";
            this.txtEntireCargoSpaceMaximum.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtEntireCargoSpaceMaximum.ButtonFreeText.Tooltip = "";
            this.highlighter.SetHighlightOnFocus(this.txtEntireCargoSpaceMaximum, true);
            this.txtEntireCargoSpaceMaximum.Location = new System.Drawing.Point(161, 134);
            this.txtEntireCargoSpaceMaximum.MinValue = 0;
            this.txtEntireCargoSpaceMaximum.Name = "txtEntireCargoSpaceMaximum";
            this.txtEntireCargoSpaceMaximum.ShowUpDown = true;
            this.txtEntireCargoSpaceMaximum.Size = new System.Drawing.Size(100, 27);
            this.txtEntireCargoSpaceMaximum.TabIndex = 6;
            // 
            // txtPackagingProportion
            // 
            // 
            // 
            // 
            this.txtPackagingProportion.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtPackagingProportion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPackagingProportion.ButtonCalculator.Tooltip = "";
            this.txtPackagingProportion.ButtonClear.Tooltip = "";
            this.txtPackagingProportion.ButtonCustom.Tooltip = "";
            this.txtPackagingProportion.ButtonCustom2.Tooltip = "";
            this.txtPackagingProportion.ButtonDropDown.Tooltip = "";
            this.txtPackagingProportion.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtPackagingProportion.ButtonFreeText.Tooltip = "";
            this.highlighter.SetHighlightOnFocus(this.txtPackagingProportion, true);
            this.txtPackagingProportion.Location = new System.Drawing.Point(414, 86);
            this.txtPackagingProportion.MinValue = 1;
            this.txtPackagingProportion.Name = "txtPackagingProportion";
            this.txtPackagingProportion.ShowUpDown = true;
            this.txtPackagingProportion.Size = new System.Drawing.Size(80, 27);
            this.txtPackagingProportion.TabIndex = 5;
            this.txtPackagingProportion.Value = 1;
            // 
            // txtProducerName
            // 
            // 
            // 
            // 
            this.txtProducerName.Border.Class = "TextBoxBorder";
            this.txtProducerName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProducerName.ButtonCustom.Tooltip = "";
            this.txtProducerName.ButtonCustom2.Tooltip = "";
            this.highlighter.SetHighlightOnFocus(this.txtProducerName, true);
            this.txtProducerName.Location = new System.Drawing.Point(117, 86);
            this.txtProducerName.Name = "txtProducerName";
            this.txtProducerName.PreventEnterBeep = true;
            this.txtProducerName.Size = new System.Drawing.Size(150, 27);
            this.txtProducerName.TabIndex = 4;
            // 
            // txtProductBarCode
            // 
            // 
            // 
            // 
            this.txtProductBarCode.Border.Class = "TextBoxBorder";
            this.txtProductBarCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProductBarCode.ButtonCustom.Tooltip = "";
            this.txtProductBarCode.ButtonCustom2.Tooltip = "";
            this.highlighter.SetHighlightOnFocus(this.txtProductBarCode, true);
            this.txtProductBarCode.Location = new System.Drawing.Point(117, 57);
            this.txtProductBarCode.Name = "txtProductBarCode";
            this.txtProductBarCode.PreventEnterBeep = true;
            this.txtProductBarCode.Size = new System.Drawing.Size(150, 27);
            this.txtProductBarCode.TabIndex = 2;
            // 
            // txtProductName
            // 
            // 
            // 
            // 
            this.txtProductName.Border.Class = "TextBoxBorder";
            this.txtProductName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProductName.ButtonCustom.Tooltip = "";
            this.txtProductName.ButtonCustom2.Tooltip = "";
            this.highlighter.SetHighlightOnFocus(this.txtProductName, true);
            this.txtProductName.Location = new System.Drawing.Point(380, 28);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PreventEnterBeep = true;
            this.txtProductName.Size = new System.Drawing.Size(150, 27);
            this.txtProductName.TabIndex = 1;
            // 
            // txtProductCode
            // 
            // 
            // 
            // 
            this.txtProductCode.Border.Class = "TextBoxBorder";
            this.txtProductCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProductCode.ButtonCustom.Tooltip = "";
            this.txtProductCode.ButtonCustom2.Tooltip = "";
            this.highlighter.SetHighlightOnFocus(this.txtProductCode, true);
            this.txtProductCode.Location = new System.Drawing.Point(117, 28);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.PreventEnterBeep = true;
            this.txtProductCode.Size = new System.Drawing.Size(150, 27);
            this.txtProductCode.TabIndex = 0;
            // 
            // txtScatteredCargoSpaceMinimum
            // 
            // 
            // 
            // 
            this.txtScatteredCargoSpaceMinimum.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtScatteredCargoSpaceMinimum.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtScatteredCargoSpaceMinimum.ButtonCalculator.Tooltip = "";
            this.txtScatteredCargoSpaceMinimum.ButtonClear.Tooltip = "";
            this.txtScatteredCargoSpaceMinimum.ButtonCustom.Tooltip = "";
            this.txtScatteredCargoSpaceMinimum.ButtonCustom2.Tooltip = "";
            this.txtScatteredCargoSpaceMinimum.ButtonDropDown.Tooltip = "";
            this.txtScatteredCargoSpaceMinimum.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtScatteredCargoSpaceMinimum.ButtonFreeText.Tooltip = "";
            this.highlighter.SetHighlightOnFocus(this.txtScatteredCargoSpaceMinimum, true);
            this.txtScatteredCargoSpaceMinimum.Location = new System.Drawing.Point(161, 192);
            this.txtScatteredCargoSpaceMinimum.MinValue = 0;
            this.txtScatteredCargoSpaceMinimum.Name = "txtScatteredCargoSpaceMinimum";
            this.txtScatteredCargoSpaceMinimum.ShowUpDown = true;
            this.txtScatteredCargoSpaceMinimum.Size = new System.Drawing.Size(100, 27);
            this.txtScatteredCargoSpaceMinimum.TabIndex = 8;
            // 
            // lblScatteredSpaceUnit
            // 
            // 
            // 
            // 
            this.lblScatteredSpaceUnit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblScatteredSpaceUnit.Location = new System.Drawing.Point(267, 163);
            this.lblScatteredSpaceUnit.Name = "lblScatteredSpaceUnit";
            this.lblScatteredSpaceUnit.Size = new System.Drawing.Size(107, 23);
            this.lblScatteredSpaceUnit.TabIndex = 65;
            this.lblScatteredSpaceUnit.Text = "（盒/袋/瓶）";
            // 
            // lblStockMinAmountUnit
            // 
            // 
            // 
            // 
            this.lblStockMinAmountUnit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStockMinAmountUnit.Location = new System.Drawing.Point(267, 221);
            this.lblStockMinAmountUnit.Name = "lblStockMinAmountUnit";
            this.lblStockMinAmountUnit.Size = new System.Drawing.Size(107, 23);
            this.lblStockMinAmountUnit.TabIndex = 64;
            this.lblStockMinAmountUnit.Text = "（盒/袋/瓶）";
            // 
            // lblEntireSpaceUnit
            // 
            // 
            // 
            // 
            this.lblEntireSpaceUnit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEntireSpaceUnit.Location = new System.Drawing.Point(267, 134);
            this.lblEntireSpaceUnit.Name = "lblEntireSpaceUnit";
            this.lblEntireSpaceUnit.Size = new System.Drawing.Size(107, 23);
            this.lblEntireSpaceUnit.TabIndex = 63;
            this.lblEntireSpaceUnit.Text = "（盒/袋/瓶）";
            // 
            // lblStockMinAmount
            // 
            // 
            // 
            // 
            this.lblStockMinAmount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStockMinAmount.Location = new System.Drawing.Point(30, 221);
            this.lblStockMinAmount.Name = "lblStockMinAmount";
            this.lblStockMinAmount.Size = new System.Drawing.Size(125, 23);
            this.lblStockMinAmount.TabIndex = 62;
            this.lblStockMinAmount.Text = "库存下限预警数量：";
            // 
            // lblScatteredCargoSpaceMaximum
            // 
            // 
            // 
            // 
            this.lblScatteredCargoSpaceMaximum.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblScatteredCargoSpaceMaximum.Location = new System.Drawing.Point(30, 163);
            this.lblScatteredCargoSpaceMaximum.Name = "lblScatteredCargoSpaceMaximum";
            this.lblScatteredCargoSpaceMaximum.Size = new System.Drawing.Size(128, 23);
            this.lblScatteredCargoSpaceMaximum.TabIndex = 61;
            this.lblScatteredCargoSpaceMaximum.Text = "拆零最大存放数量：";
            // 
            // lblEntireCargoSpaceMaximum
            // 
            // 
            // 
            // 
            this.lblEntireCargoSpaceMaximum.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEntireCargoSpaceMaximum.Location = new System.Drawing.Point(30, 134);
            this.lblEntireCargoSpaceMaximum.Name = "lblEntireCargoSpaceMaximum";
            this.lblEntireCargoSpaceMaximum.Size = new System.Drawing.Size(125, 23);
            this.lblEntireCargoSpaceMaximum.TabIndex = 60;
            this.lblEntireCargoSpaceMaximum.Text = "整货最大存放数量：";
            // 
            // lblPackagingProportionBaseNumber
            // 
            // 
            // 
            // 
            this.lblPackagingProportionBaseNumber.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPackagingProportionBaseNumber.Location = new System.Drawing.Point(377, 86);
            this.lblPackagingProportionBaseNumber.Name = "lblPackagingProportionBaseNumber";
            this.lblPackagingProportionBaseNumber.Size = new System.Drawing.Size(30, 23);
            this.lblPackagingProportionBaseNumber.TabIndex = 59;
            this.lblPackagingProportionBaseNumber.Text = "1：";
            // 
            // lblPackagingProportion
            // 
            // 
            // 
            // 
            this.lblPackagingProportion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPackagingProportion.Location = new System.Drawing.Point(293, 85);
            this.lblPackagingProportion.Name = "lblPackagingProportion";
            this.lblPackagingProportion.Size = new System.Drawing.Size(81, 23);
            this.lblPackagingProportion.TabIndex = 58;
            this.lblPackagingProportion.Text = "包装比例：";
            // 
            // lblProducerName
            // 
            // 
            // 
            // 
            this.lblProducerName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblProducerName.Location = new System.Drawing.Point(30, 86);
            this.lblProducerName.Name = "lblProducerName";
            this.lblProducerName.Size = new System.Drawing.Size(81, 23);
            this.lblProducerName.TabIndex = 57;
            this.lblProducerName.Text = "生产厂家：";
            // 
            // lblStockCondition
            // 
            // 
            // 
            // 
            this.lblStockCondition.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStockCondition.Location = new System.Drawing.Point(293, 57);
            this.lblStockCondition.Name = "lblStockCondition";
            this.lblStockCondition.Size = new System.Drawing.Size(81, 23);
            this.lblStockCondition.TabIndex = 56;
            this.lblStockCondition.Text = "储存条件：";
            // 
            // lblProductBarCode
            // 
            // 
            // 
            // 
            this.lblProductBarCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblProductBarCode.Location = new System.Drawing.Point(30, 57);
            this.lblProductBarCode.Name = "lblProductBarCode";
            this.lblProductBarCode.Size = new System.Drawing.Size(81, 23);
            this.lblProductBarCode.TabIndex = 55;
            this.lblProductBarCode.Text = "药品条码：";
            // 
            // lblProductName
            // 
            // 
            // 
            // 
            this.lblProductName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblProductName.Location = new System.Drawing.Point(293, 28);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(81, 23);
            this.lblProductName.TabIndex = 54;
            this.lblProductName.Text = "药品名称：";
            // 
            // lblProductCode
            // 
            // 
            // 
            // 
            this.lblProductCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblProductCode.Location = new System.Drawing.Point(30, 28);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(81, 23);
            this.lblProductCode.TabIndex = 53;
            this.lblProductCode.Text = "药品编号：";
            // 
            // lblScatteredCargoSpaceMinUnit
            // 
            // 
            // 
            // 
            this.lblScatteredCargoSpaceMinUnit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblScatteredCargoSpaceMinUnit.Location = new System.Drawing.Point(267, 192);
            this.lblScatteredCargoSpaceMinUnit.Name = "lblScatteredCargoSpaceMinUnit";
            this.lblScatteredCargoSpaceMinUnit.Size = new System.Drawing.Size(107, 23);
            this.lblScatteredCargoSpaceMinUnit.TabIndex = 68;
            this.lblScatteredCargoSpaceMinUnit.Text = "（盒/袋/瓶）";
            // 
            // lblScatteredCargoSpaceMinimum
            // 
            // 
            // 
            // 
            this.lblScatteredCargoSpaceMinimum.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblScatteredCargoSpaceMinimum.Location = new System.Drawing.Point(27, 192);
            this.lblScatteredCargoSpaceMinimum.Name = "lblScatteredCargoSpaceMinimum";
            this.lblScatteredCargoSpaceMinimum.Size = new System.Drawing.Size(128, 23);
            this.lblScatteredCargoSpaceMinimum.TabIndex = 67;
            this.lblScatteredCargoSpaceMinimum.Text = "拆零补货下限预警：";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(30, 275);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(148, 23);
            this.labelX1.TabIndex = 69;
            this.labelX1.Text = "是否电子监管药品：";
            // 
            // swbIsSupervise
            // 
            // 
            // 
            // 
            this.swbIsSupervise.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter.SetHighlightOnFocus(this.swbIsSupervise, true);
            this.swbIsSupervise.Location = new System.Drawing.Point(184, 275);
            this.swbIsSupervise.Name = "swbIsSupervise";
            this.swbIsSupervise.OffText = "否";
            this.swbIsSupervise.OnText = "是";
            this.swbIsSupervise.Size = new System.Drawing.Size(116, 31);
            this.swbIsSupervise.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swbIsSupervise.SwitchFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.swbIsSupervise.TabIndex = 70;
            // 
            // FrmDrugEditor
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 391);
            this.Controls.Add(this.swbIsSupervise);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtScatteredCargoSpaceMinimum);
            this.Controls.Add(this.lblScatteredCargoSpaceMinUnit);
            this.Controls.Add(this.lblScatteredCargoSpaceMinimum);
            this.Controls.Add(this.cbxStockCondition);
            this.Controls.Add(this.txtScatteredCargoSpaceMaximum);
            this.Controls.Add(this.txtStockMinAmount);
            this.Controls.Add(this.txtEntireCargoSpaceMaximum);
            this.Controls.Add(this.lblScatteredSpaceUnit);
            this.Controls.Add(this.lblStockMinAmountUnit);
            this.Controls.Add(this.lblEntireSpaceUnit);
            this.Controls.Add(this.lblStockMinAmount);
            this.Controls.Add(this.lblScatteredCargoSpaceMaximum);
            this.Controls.Add(this.lblEntireCargoSpaceMaximum);
            this.Controls.Add(this.txtPackagingProportion);
            this.Controls.Add(this.lblPackagingProportionBaseNumber);
            this.Controls.Add(this.lblPackagingProportion);
            this.Controls.Add(this.txtProducerName);
            this.Controls.Add(this.lblProducerName);
            this.Controls.Add(this.lblStockCondition);
            this.Controls.Add(this.txtProductBarCode);
            this.Controls.Add(this.lblProductBarCode);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDrugEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "药品信息管理";
            this.Load += new System.EventHandler(this.FrmDrugEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtScatteredCargoSpaceMaximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockMinAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntireCargoSpaceMaximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPackagingProportion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScatteredCargoSpaceMinimum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnReset;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxStockCondition;
        private DevComponents.Editors.IntegerInput txtScatteredCargoSpaceMaximum;
        private DevComponents.Editors.IntegerInput txtStockMinAmount;
        private DevComponents.Editors.IntegerInput txtEntireCargoSpaceMaximum;
        private DevComponents.DotNetBar.LabelX lblScatteredSpaceUnit;
        private DevComponents.DotNetBar.LabelX lblStockMinAmountUnit;
        private DevComponents.DotNetBar.LabelX lblEntireSpaceUnit;
        private DevComponents.DotNetBar.LabelX lblStockMinAmount;
        private DevComponents.DotNetBar.LabelX lblScatteredCargoSpaceMaximum;
        private DevComponents.DotNetBar.LabelX lblEntireCargoSpaceMaximum;
        private DevComponents.Editors.IntegerInput txtPackagingProportion;
        private DevComponents.DotNetBar.LabelX lblPackagingProportionBaseNumber;
        private DevComponents.DotNetBar.LabelX lblPackagingProportion;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProducerName;
        private DevComponents.DotNetBar.LabelX lblProducerName;
        private DevComponents.DotNetBar.LabelX lblStockCondition;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProductBarCode;
        private DevComponents.DotNetBar.LabelX lblProductBarCode;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProductName;
        private DevComponents.DotNetBar.LabelX lblProductName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProductCode;
        private DevComponents.DotNetBar.LabelX lblProductCode;
        private DevComponents.Editors.IntegerInput txtScatteredCargoSpaceMinimum;
        private DevComponents.DotNetBar.LabelX lblScatteredCargoSpaceMinUnit;
        private DevComponents.DotNetBar.LabelX lblScatteredCargoSpaceMinimum;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.SwitchButton swbIsSupervise;

    }
}