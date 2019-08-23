namespace WMS.Windows.App
{
    partial class FrmWarehouseUnit
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
            this.lblUnitCode = new DevComponents.DotNetBar.LabelX();
            this.lblUnitName = new DevComponents.DotNetBar.LabelX();
            this.lblBarcode = new DevComponents.DotNetBar.LabelX();
            this.lblStoreType = new DevComponents.DotNetBar.LabelX();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.panStoreUnit = new DevComponents.DotNetBar.ExpandablePanel();
            this.chkIsActive = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtAreaCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblParentUnitCode = new DevComponents.DotNetBar.LabelX();
            this.lblCurrentUnitCode = new DevComponents.DotNetBar.LabelX();
            this.lblParentUnitName = new DevComponents.DotNetBar.LabelX();
            this.lblCurrentUnitName = new DevComponents.DotNetBar.LabelX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.cbxStoreType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.itmArea = new DevComponents.Editors.ComboItem();
            this.itmShelf = new DevComponents.Editors.ComboItem();
            this.itmCargo = new DevComponents.Editors.ComboItem();
            this.itmTray = new DevComponents.Editors.ComboItem();
            this.cbxControlType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.itmNoControl = new DevComponents.Editors.ComboItem();
            this.itmELabel = new DevComponents.Editors.ComboItem();
            this.itmPDA = new DevComponents.Editors.ComboItem();
            this.cbxStructureType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.itmEntireCargo = new DevComponents.Editors.ComboItem();
            this.itmScatteredCargo = new DevComponents.Editors.ComboItem();
            this.lblControlType = new DevComponents.DotNetBar.LabelX();
            this.lblStructureType = new DevComponents.DotNetBar.LabelX();
            this.chkIsMinUnit = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtLocation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblLocation = new DevComponents.DotNetBar.LabelX();
            this.txtEndCode = new DevComponents.Editors.IntegerInput();
            this.txtUnitName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblEndCode = new DevComponents.DotNetBar.LabelX();
            this.txtCharge = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCharge = new DevComponents.DotNetBar.LabelX();
            this.txtBarcode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblStartCode = new DevComponents.DotNetBar.LabelX();
            this.swbCodeGenType = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.txtStartCode = new DevComponents.Editors.IntegerInput();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.treeStoreUnit = new DevComponents.AdvTree.AdvTree();
            this.colStructureCode = new DevComponents.AdvTree.ColumnHeader();
            this.colStructureName = new DevComponents.AdvTree.ColumnHeader();
            this.colStructureType = new DevComponents.AdvTree.ColumnHeader();
            this.colStructureBarCode = new DevComponents.AdvTree.ColumnHeader();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.elementStyle2 = new DevComponents.DotNetBar.ElementStyle();
            this.colIsActive = new DevComponents.AdvTree.ColumnHeader();
            this.panStoreUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeStoreUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUnitCode
            // 
            // 
            // 
            // 
            this.lblUnitCode.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.lblUnitCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblUnitCode.Location = new System.Drawing.Point(17, 119);
            this.lblUnitCode.Name = "lblUnitCode";
            this.lblUnitCode.Size = new System.Drawing.Size(75, 23);
            this.lblUnitCode.TabIndex = 4;
            this.lblUnitCode.Text = "存储编号：";
            // 
            // lblUnitName
            // 
            // 
            // 
            // 
            this.lblUnitName.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.lblUnitName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblUnitName.Location = new System.Drawing.Point(17, 190);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(75, 23);
            this.lblUnitName.TabIndex = 5;
            this.lblUnitName.Text = "存储名称：";
            // 
            // lblBarcode
            // 
            // 
            // 
            // 
            this.lblBarcode.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.lblBarcode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblBarcode.Enabled = false;
            this.lblBarcode.Location = new System.Drawing.Point(234, 303);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(70, 23);
            this.lblBarcode.TabIndex = 6;
            this.lblBarcode.Text = "条码：";
            // 
            // lblStoreType
            // 
            // 
            // 
            // 
            this.lblStoreType.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.lblStoreType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStoreType.Location = new System.Drawing.Point(18, 42);
            this.lblStoreType.Name = "lblStoreType";
            this.lblStoreType.Size = new System.Drawing.Size(75, 23);
            this.lblStoreType.TabIndex = 0;
            this.lblStoreType.Text = "存储类型：";
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(761, 30);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "修改";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(865, 30);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(653, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panStoreUnit
            // 
            this.panStoreUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panStoreUnit.CanvasColor = System.Drawing.SystemColors.Control;
            this.panStoreUnit.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panStoreUnit.Controls.Add(this.chkIsActive);
            this.panStoreUnit.Controls.Add(this.txtAreaCode);
            this.panStoreUnit.Controls.Add(this.lblParentUnitCode);
            this.panStoreUnit.Controls.Add(this.lblCurrentUnitCode);
            this.panStoreUnit.Controls.Add(this.lblParentUnitName);
            this.panStoreUnit.Controls.Add(this.lblCurrentUnitName);
            this.panStoreUnit.Controls.Add(this.btnCancel);
            this.panStoreUnit.Controls.Add(this.btnSave);
            this.panStoreUnit.Controls.Add(this.cbxStoreType);
            this.panStoreUnit.Controls.Add(this.cbxControlType);
            this.panStoreUnit.Controls.Add(this.cbxStructureType);
            this.panStoreUnit.Controls.Add(this.lblControlType);
            this.panStoreUnit.Controls.Add(this.lblStructureType);
            this.panStoreUnit.Controls.Add(this.chkIsMinUnit);
            this.panStoreUnit.Controls.Add(this.txtLocation);
            this.panStoreUnit.Controls.Add(this.lblLocation);
            this.panStoreUnit.Controls.Add(this.txtEndCode);
            this.panStoreUnit.Controls.Add(this.txtUnitName);
            this.panStoreUnit.Controls.Add(this.lblEndCode);
            this.panStoreUnit.Controls.Add(this.txtCharge);
            this.panStoreUnit.Controls.Add(this.lblCharge);
            this.panStoreUnit.Controls.Add(this.txtBarcode);
            this.panStoreUnit.Controls.Add(this.lblStartCode);
            this.panStoreUnit.Controls.Add(this.swbCodeGenType);
            this.panStoreUnit.Controls.Add(this.txtStartCode);
            this.panStoreUnit.Controls.Add(this.lblBarcode);
            this.panStoreUnit.Controls.Add(this.lblUnitCode);
            this.panStoreUnit.Controls.Add(this.lblUnitName);
            this.panStoreUnit.Controls.Add(this.lblStoreType);
            this.panStoreUnit.DisabledBackColor = System.Drawing.Color.Empty;
            this.panStoreUnit.Enabled = false;
            this.panStoreUnit.ExpandButtonVisible = false;
            this.panStoreUnit.HideControlsWhenCollapsed = true;
            this.panStoreUnit.Location = new System.Drawing.Point(653, 59);
            this.panStoreUnit.Name = "panStoreUnit";
            this.panStoreUnit.Size = new System.Drawing.Size(447, 475);
            this.panStoreUnit.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panStoreUnit.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panStoreUnit.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panStoreUnit.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panStoreUnit.Style.GradientAngle = 90;
            this.panStoreUnit.TabIndex = 0;
            this.panStoreUnit.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.panStoreUnit.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panStoreUnit.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panStoreUnit.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panStoreUnit.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panStoreUnit.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panStoreUnit.TitleStyle.GradientAngle = 90;
            this.panStoreUnit.TitleText = "存储单元设置";
            // 
            // chkIsActive
            // 
            // 
            // 
            // 
            this.chkIsActive.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.chkIsActive.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter.SetHighlightOnFocus(this.chkIsActive, true);
            this.chkIsActive.Location = new System.Drawing.Point(16, 360);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(123, 23);
            this.chkIsActive.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkIsActive.TabIndex = 45;
            this.chkIsActive.Text = "是否启用";
            // 
            // txtAreaCode
            // 
            // 
            // 
            // 
            this.txtAreaCode.Border.Class = "TextBoxBorder";
            this.txtAreaCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAreaCode.ButtonCustom.Tooltip = "";
            this.txtAreaCode.ButtonCustom2.Tooltip = "";
            this.txtAreaCode.Enabled = false;
            this.txtAreaCode.Location = new System.Drawing.Point(377, 120);
            this.txtAreaCode.Name = "txtAreaCode";
            this.txtAreaCode.PreventEnterBeep = true;
            this.txtAreaCode.Size = new System.Drawing.Size(100, 27);
            this.txtAreaCode.TabIndex = 44;
            this.txtAreaCode.TextChanged += new System.EventHandler(this.txtAreaCode_TextChanged);
            // 
            // lblParentUnitCode
            // 
            this.lblParentUnitCode.AutoSize = true;
            // 
            // 
            // 
            this.lblParentUnitCode.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionBackground;
            this.lblParentUnitCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblParentUnitCode.Location = new System.Drawing.Point(97, 157);
            this.lblParentUnitCode.Name = "lblParentUnitCode";
            this.lblParentUnitCode.Size = new System.Drawing.Size(93, 24);
            this.lblParentUnitCode.TabIndex = 43;
            this.lblParentUnitCode.Text = "                  ";
            // 
            // lblCurrentUnitCode
            // 
            this.lblCurrentUnitCode.AutoSize = true;
            // 
            // 
            // 
            this.lblCurrentUnitCode.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.lblCurrentUnitCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCurrentUnitCode.ForeColor = System.Drawing.Color.Yellow;
            this.lblCurrentUnitCode.Location = new System.Drawing.Point(301, 157);
            this.lblCurrentUnitCode.Name = "lblCurrentUnitCode";
            this.lblCurrentUnitCode.Size = new System.Drawing.Size(93, 24);
            this.lblCurrentUnitCode.TabIndex = 42;
            this.lblCurrentUnitCode.Text = "                  ";
            // 
            // lblParentUnitName
            // 
            this.lblParentUnitName.AutoSize = true;
            // 
            // 
            // 
            this.lblParentUnitName.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionBackground;
            this.lblParentUnitName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblParentUnitName.Location = new System.Drawing.Point(97, 225);
            this.lblParentUnitName.Name = "lblParentUnitName";
            this.lblParentUnitName.Size = new System.Drawing.Size(93, 24);
            this.lblParentUnitName.TabIndex = 41;
            this.lblParentUnitName.Text = "                  ";
            // 
            // lblCurrentUnitName
            // 
            this.lblCurrentUnitName.AutoSize = true;
            // 
            // 
            // 
            this.lblCurrentUnitName.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.lblCurrentUnitName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCurrentUnitName.ForeColor = System.Drawing.Color.Yellow;
            this.lblCurrentUnitName.Location = new System.Drawing.Point(301, 225);
            this.lblCurrentUnitName.Name = "lblCurrentUnitName";
            this.lblCurrentUnitName.Size = new System.Drawing.Size(93, 24);
            this.lblCurrentUnitName.TabIndex = 39;
            this.lblCurrentUnitName.Text = "                  ";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(258, 413);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(150, 413);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxStoreType
            // 
            this.cbxStoreType.DisplayMember = "Text";
            this.cbxStoreType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxStoreType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStoreType.FormattingEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.cbxStoreType, true);
            this.cbxStoreType.ItemHeight = 21;
            this.cbxStoreType.Items.AddRange(new object[] {
            this.itmArea,
            this.itmShelf,
            this.itmCargo,
            this.itmTray});
            this.cbxStoreType.Location = new System.Drawing.Point(98, 44);
            this.cbxStoreType.Name = "cbxStoreType";
            this.cbxStoreType.Size = new System.Drawing.Size(121, 27);
            this.cbxStoreType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxStoreType.TabIndex = 0;
            this.cbxStoreType.WatermarkText = "请选择";
            this.cbxStoreType.SelectedValueChanged += new System.EventHandler(this.cbxStoreType_SelectedValueChanged);
            // 
            // itmArea
            // 
            this.itmArea.Text = "货区";
            this.itmArea.Value = "货区";
            // 
            // itmShelf
            // 
            this.itmShelf.Text = "货架";
            this.itmShelf.Value = "货架";
            // 
            // itmCargo
            // 
            this.itmCargo.Text = "货位";
            this.itmCargo.Value = "货位";
            // 
            // itmTray
            // 
            this.itmTray.Text = "托盘";
            this.itmTray.Value = "托盘";
            // 
            // cbxControlType
            // 
            this.cbxControlType.DisplayMember = "Text";
            this.cbxControlType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxControlType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxControlType.FormattingEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.cbxControlType, true);
            this.cbxControlType.ItemHeight = 21;
            this.cbxControlType.Items.AddRange(new object[] {
            this.itmNoControl,
            this.itmELabel,
            this.itmPDA});
            this.cbxControlType.Location = new System.Drawing.Point(310, 82);
            this.cbxControlType.Name = "cbxControlType";
            this.cbxControlType.Size = new System.Drawing.Size(121, 27);
            this.cbxControlType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxControlType.TabIndex = 2;
            this.cbxControlType.WatermarkText = "无控制";
            // 
            // itmNoControl
            // 
            this.itmNoControl.Text = "无控制";
            this.itmNoControl.Value = "无控制";
            // 
            // itmELabel
            // 
            this.itmELabel.Text = "电子标签控制";
            this.itmELabel.Value = "电子标签控制";
            // 
            // itmPDA
            // 
            this.itmPDA.Text = "PDA控制";
            this.itmPDA.Value = "PDA控制";
            // 
            // cbxStructureType
            // 
            this.cbxStructureType.DisplayMember = "Text";
            this.cbxStructureType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxStructureType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStructureType.FormattingEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.cbxStructureType, true);
            this.cbxStructureType.ItemHeight = 21;
            this.cbxStructureType.Items.AddRange(new object[] {
            this.itmEntireCargo,
            this.itmScatteredCargo});
            this.cbxStructureType.Location = new System.Drawing.Point(97, 82);
            this.cbxStructureType.Name = "cbxStructureType";
            this.cbxStructureType.Size = new System.Drawing.Size(121, 27);
            this.cbxStructureType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxStructureType.TabIndex = 1;
            this.cbxStructureType.WatermarkText = "请选择";
            this.cbxStructureType.SelectedValueChanged += new System.EventHandler(this.cbxStructureType_SelectedValueChanged);
            // 
            // itmEntireCargo
            // 
            this.itmEntireCargo.Text = "整货";
            this.itmEntireCargo.Value = "Z";
            // 
            // itmScatteredCargo
            // 
            this.itmScatteredCargo.Text = "零货";
            this.itmScatteredCargo.Value = "L";
            // 
            // lblControlType
            // 
            // 
            // 
            // 
            this.lblControlType.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.lblControlType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblControlType.Location = new System.Drawing.Point(241, 82);
            this.lblControlType.Name = "lblControlType";
            this.lblControlType.Size = new System.Drawing.Size(70, 23);
            this.lblControlType.TabIndex = 31;
            this.lblControlType.Text = "货区控制：";
            // 
            // lblStructureType
            // 
            // 
            // 
            // 
            this.lblStructureType.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.lblStructureType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStructureType.Location = new System.Drawing.Point(17, 82);
            this.lblStructureType.Name = "lblStructureType";
            this.lblStructureType.Size = new System.Drawing.Size(75, 23);
            this.lblStructureType.TabIndex = 29;
            this.lblStructureType.Text = "货区类型：";
            // 
            // chkIsMinUnit
            // 
            // 
            // 
            // 
            this.chkIsMinUnit.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.chkIsMinUnit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter.SetHighlightOnFocus(this.chkIsMinUnit, true);
            this.chkIsMinUnit.Location = new System.Drawing.Point(18, 303);
            this.chkIsMinUnit.Name = "chkIsMinUnit";
            this.chkIsMinUnit.Size = new System.Drawing.Size(123, 23);
            this.chkIsMinUnit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkIsMinUnit.TabIndex = 9;
            this.chkIsMinUnit.Text = "是否最小存储单元";
            this.chkIsMinUnit.CheckedChanged += new System.EventHandler(this.chkIsMinUnit_CheckedChanged);
            // 
            // txtLocation
            // 
            // 
            // 
            // 
            this.txtLocation.Border.Class = "TextBoxBorder";
            this.txtLocation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLocation.ButtonCustom.Tooltip = "";
            this.txtLocation.ButtonCustom2.Tooltip = "";
            this.highlighter.SetHighlightOnFocus(this.txtLocation, true);
            this.txtLocation.Location = new System.Drawing.Point(97, 262);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.PreventEnterBeep = true;
            this.txtLocation.Size = new System.Drawing.Size(121, 27);
            this.txtLocation.TabIndex = 7;
            // 
            // lblLocation
            // 
            // 
            // 
            // 
            this.lblLocation.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.lblLocation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblLocation.Location = new System.Drawing.Point(16, 262);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(75, 23);
            this.lblLocation.TabIndex = 26;
            this.lblLocation.Text = "存储位置：";
            // 
            // txtEndCode
            // 
            // 
            // 
            // 
            this.txtEndCode.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtEndCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEndCode.ButtonCalculator.Tooltip = "";
            this.txtEndCode.ButtonClear.Tooltip = "";
            this.txtEndCode.ButtonCustom.Tooltip = "";
            this.txtEndCode.ButtonCustom2.Tooltip = "";
            this.txtEndCode.ButtonDropDown.Tooltip = "";
            this.txtEndCode.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtEndCode.ButtonFreeText.Tooltip = "";
            this.txtEndCode.DisplayFormat = "00";
            this.highlighter.SetHighlightOnFocus(this.txtEndCode, true);
            this.txtEndCode.Location = new System.Drawing.Point(289, 120);
            this.txtEndCode.MaxValue = 99;
            this.txtEndCode.MinValue = 1;
            this.txtEndCode.Name = "txtEndCode";
            this.txtEndCode.ShowUpDown = true;
            this.txtEndCode.Size = new System.Drawing.Size(66, 27);
            this.txtEndCode.TabIndex = 5;
            this.txtEndCode.Value = 1;
            this.txtEndCode.Visible = false;
            this.txtEndCode.ValueChanged += new System.EventHandler(this.txtEndCode_ValueChanged);
            // 
            // txtUnitName
            // 
            // 
            // 
            // 
            this.txtUnitName.Border.Class = "TextBoxBorder";
            this.txtUnitName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUnitName.ButtonCustom.Tooltip = "";
            this.txtUnitName.ButtonCustom2.Tooltip = "";
            this.highlighter.SetHighlightOnFocus(this.txtUnitName, true);
            this.txtUnitName.Location = new System.Drawing.Point(98, 190);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.PreventEnterBeep = true;
            this.txtUnitName.Size = new System.Drawing.Size(198, 27);
            this.txtUnitName.TabIndex = 6;
            this.txtUnitName.TextChanged += new System.EventHandler(this.txtUnitName_TextChanged);
            // 
            // lblEndCode
            // 
            // 
            // 
            // 
            this.lblEndCode.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.lblEndCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEndCode.Location = new System.Drawing.Point(270, 120);
            this.lblEndCode.Name = "lblEndCode";
            this.lblEndCode.Size = new System.Drawing.Size(26, 23);
            this.lblEndCode.TabIndex = 22;
            this.lblEndCode.Text = "到";
            this.lblEndCode.Visible = false;
            // 
            // txtCharge
            // 
            // 
            // 
            // 
            this.txtCharge.Border.Class = "TextBoxBorder";
            this.txtCharge.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCharge.ButtonCustom.Tooltip = "";
            this.txtCharge.ButtonCustom2.Tooltip = "";
            this.highlighter.SetHighlightOnFocus(this.txtCharge, true);
            this.txtCharge.Location = new System.Drawing.Point(310, 262);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.PreventEnterBeep = true;
            this.txtCharge.Size = new System.Drawing.Size(121, 27);
            this.txtCharge.TabIndex = 8;
            // 
            // lblCharge
            // 
            // 
            // 
            // 
            this.lblCharge.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.lblCharge.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCharge.Location = new System.Drawing.Point(234, 261);
            this.lblCharge.Name = "lblCharge";
            this.lblCharge.Size = new System.Drawing.Size(70, 23);
            this.lblCharge.TabIndex = 19;
            this.lblCharge.Text = "负责人：";
            // 
            // txtBarcode
            // 
            // 
            // 
            // 
            this.txtBarcode.Border.Class = "TextBoxBorder";
            this.txtBarcode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBarcode.ButtonCustom.Tooltip = "";
            this.txtBarcode.ButtonCustom2.Tooltip = "";
            this.txtBarcode.Enabled = false;
            this.txtBarcode.Location = new System.Drawing.Point(310, 303);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.PreventEnterBeep = true;
            this.txtBarcode.ReadOnly = true;
            this.txtBarcode.Size = new System.Drawing.Size(121, 27);
            this.txtBarcode.TabIndex = 10;
            // 
            // lblStartCode
            // 
            // 
            // 
            // 
            this.lblStartCode.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.lblStartCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStartCode.Location = new System.Drawing.Point(171, 119);
            this.lblStartCode.Name = "lblStartCode";
            this.lblStartCode.Size = new System.Drawing.Size(21, 23);
            this.lblStartCode.TabIndex = 17;
            this.lblStartCode.Text = "从";
            this.lblStartCode.Visible = false;
            // 
            // swbCodeGenType
            // 
            // 
            // 
            // 
            this.swbCodeGenType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter.SetHighlightOnFocus(this.swbCodeGenType, true);
            this.swbCodeGenType.Location = new System.Drawing.Point(98, 120);
            this.swbCodeGenType.Name = "swbCodeGenType";
            this.swbCodeGenType.OffText = "批量";
            this.swbCodeGenType.OnText = "单个";
            this.swbCodeGenType.Size = new System.Drawing.Size(66, 22);
            this.swbCodeGenType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swbCodeGenType.TabIndex = 3;
            this.swbCodeGenType.Value = true;
            this.swbCodeGenType.ValueObject = "Y";
            this.swbCodeGenType.ValueChanged += new System.EventHandler(this.swbCodeGenType_ValueChanged);
            // 
            // txtStartCode
            // 
            // 
            // 
            // 
            this.txtStartCode.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtStartCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStartCode.ButtonCalculator.Tooltip = "";
            this.txtStartCode.ButtonClear.Tooltip = "";
            this.txtStartCode.ButtonCustom.Tooltip = "";
            this.txtStartCode.ButtonCustom2.Tooltip = "";
            this.txtStartCode.ButtonDropDown.Tooltip = "";
            this.txtStartCode.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtStartCode.ButtonFreeText.Tooltip = "";
            this.txtStartCode.DisplayFormat = "00";
            this.highlighter.SetHighlightOnFocus(this.txtStartCode, true);
            this.txtStartCode.Location = new System.Drawing.Point(198, 119);
            this.txtStartCode.MaxValue = 99;
            this.txtStartCode.MinValue = 1;
            this.txtStartCode.Name = "txtStartCode";
            this.txtStartCode.ShowUpDown = true;
            this.txtStartCode.Size = new System.Drawing.Size(66, 27);
            this.txtStartCode.TabIndex = 4;
            this.txtStartCode.Value = 1;
            this.txtStartCode.ValueChanged += new System.EventHandler(this.txtStartCode_ValueChanged);
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            this.highlighter.CustomHighlightColors = new System.Drawing.Color[0];
            // 
            // treeStoreUnit
            // 
            this.treeStoreUnit.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.treeStoreUnit.AllowDrop = true;
            this.treeStoreUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeStoreUnit.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.treeStoreUnit.BackgroundStyle.Class = "TreeBorderKey";
            this.treeStoreUnit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.treeStoreUnit.Columns.Add(this.colStructureCode);
            this.treeStoreUnit.Columns.Add(this.colStructureName);
            this.treeStoreUnit.Columns.Add(this.colStructureType);
            this.treeStoreUnit.Columns.Add(this.colStructureBarCode);
            this.treeStoreUnit.Columns.Add(this.colIsActive);
            this.treeStoreUnit.GridRowLines = true;
            this.treeStoreUnit.HotTracking = true;
            this.treeStoreUnit.Location = new System.Drawing.Point(-3, 30);
            this.treeStoreUnit.Name = "treeStoreUnit";
            this.treeStoreUnit.NodesConnector = this.nodeConnector1;
            this.treeStoreUnit.NodeStyle = this.elementStyle1;
            this.treeStoreUnit.ParentFieldNames = "StructureCode,ParentStructureCode";
            this.treeStoreUnit.PathSeparator = ";";
            this.treeStoreUnit.Size = new System.Drawing.Size(631, 504);
            this.treeStoreUnit.Styles.Add(this.elementStyle1);
            this.treeStoreUnit.Styles.Add(this.elementStyle2);
            this.treeStoreUnit.TabIndex = 8;
            this.treeStoreUnit.AfterExpand += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.treeStoreUnit_AfterExpand);
            this.treeStoreUnit.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.treeStoreUnit_AfterNodeSelect);
            // 
            // colStructureCode
            // 
            this.colStructureCode.DataFieldName = "StructureCode";
            this.colStructureCode.Name = "colStructureCode";
            this.colStructureCode.Text = "存储编号";
            this.colStructureCode.Width.Absolute = 150;
            // 
            // colStructureName
            // 
            this.colStructureName.DataFieldName = "StructureName";
            this.colStructureName.Name = "colStructureName";
            this.colStructureName.Text = "存储名称";
            this.colStructureName.Width.Absolute = 200;
            // 
            // colStructureType
            // 
            this.colStructureType.DataFieldName = "StructureType";
            this.colStructureType.Name = "colStructureType";
            this.colStructureType.Text = "存储类型";
            this.colStructureType.Width.Absolute = 80;
            // 
            // colStructureBarCode
            // 
            this.colStructureBarCode.DataFieldName = "StructureBarCode";
            this.colStructureBarCode.Name = "colStructureBarCode";
            this.colStructureBarCode.Text = "条码";
            this.colStructureBarCode.Width.Absolute = 120;
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle2
            // 
            this.elementStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.elementStyle2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.elementStyle2.BackColorGradientAngle = 90;
            this.elementStyle2.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle2.BorderBottomWidth = 1;
            this.elementStyle2.BorderColor = System.Drawing.Color.DarkGray;
            this.elementStyle2.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle2.BorderLeftWidth = 1;
            this.elementStyle2.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle2.BorderRightWidth = 1;
            this.elementStyle2.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle2.BorderTopWidth = 1;
            this.elementStyle2.CornerDiameter = 4;
            this.elementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle2.Description = "Blue";
            this.elementStyle2.Name = "elementStyle2";
            this.elementStyle2.PaddingBottom = 1;
            this.elementStyle2.PaddingLeft = 1;
            this.elementStyle2.PaddingRight = 1;
            this.elementStyle2.PaddingTop = 1;
            this.elementStyle2.TextColor = System.Drawing.Color.Black;
            // 
            // colIsActive
            // 
            this.colIsActive.ColumnName = "IsActive";
            this.colIsActive.DataFieldName = "IsActive";
            this.colIsActive.EditorType = DevComponents.AdvTree.eCellEditorType.Custom;
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Text = "启用";
            this.colIsActive.Width.Absolute = 50;
            // 
            // FrmWarehouseUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 546);
            this.Controls.Add(this.treeStoreUnit);
            this.Controls.Add(this.panStoreUnit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmWarehouseUnit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "存储单元";
            this.Load += new System.EventHandler(this.FrmWarehouseUnit_Load);
            this.panStoreUnit.ResumeLayout(false);
            this.panStoreUnit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeStoreUnit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblUnitCode;
        private DevComponents.DotNetBar.LabelX lblUnitName;
        private DevComponents.DotNetBar.LabelX lblBarcode;
        private DevComponents.DotNetBar.LabelX lblStoreType;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.ExpandablePanel panStoreUnit;
        private DevComponents.Editors.IntegerInput txtEndCode;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUnitName;
        private DevComponents.DotNetBar.LabelX lblEndCode;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCharge;
        private DevComponents.DotNetBar.LabelX lblCharge;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBarcode;
        private DevComponents.DotNetBar.LabelX lblStartCode;
        private DevComponents.DotNetBar.Controls.SwitchButton swbCodeGenType;
        private DevComponents.Editors.IntegerInput txtStartCode;
        private DevComponents.DotNetBar.LabelX lblControlType;
        private DevComponents.DotNetBar.LabelX lblStructureType;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkIsMinUnit;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLocation;
        private DevComponents.DotNetBar.LabelX lblLocation;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxStructureType;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxControlType;
        private DevComponents.Editors.ComboItem itmNoControl;
        private DevComponents.Editors.ComboItem itmELabel;
        private DevComponents.Editors.ComboItem itmPDA;
        private DevComponents.Editors.ComboItem itmEntireCargo;
        private DevComponents.Editors.ComboItem itmScatteredCargo;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxStoreType;
        private DevComponents.Editors.ComboItem itmArea;
        private DevComponents.Editors.ComboItem itmShelf;
        private DevComponents.Editors.ComboItem itmCargo;
        private DevComponents.Editors.ComboItem itmTray;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.LabelX lblCurrentUnitName;
        private DevComponents.DotNetBar.LabelX lblParentUnitCode;
        private DevComponents.DotNetBar.LabelX lblCurrentUnitCode;
        private DevComponents.DotNetBar.LabelX lblParentUnitName;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.AdvTree.AdvTree treeStoreUnit;
        private DevComponents.AdvTree.ColumnHeader colStructureCode;
        private DevComponents.AdvTree.ColumnHeader colStructureName;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.ElementStyle elementStyle2;
        private DevComponents.AdvTree.ColumnHeader colStructureType;
        private DevComponents.AdvTree.ColumnHeader colStructureBarCode;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAreaCode;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkIsActive;
        private DevComponents.AdvTree.ColumnHeader colIsActive;
    }
}