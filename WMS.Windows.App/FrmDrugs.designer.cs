namespace WMS.Windows.App
{
    partial class FrmDrugs
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
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn5 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn6 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn7 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn8 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn9 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn10 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn11 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn12 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn13 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn14 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn15 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn16 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn17 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn18 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.grdDrugs = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.lblProductCode = new DevComponents.DotNetBar.LabelX();
            this.txtProductCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtProductName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblProductName = new DevComponents.DotNetBar.LabelX();
            this.txtProductBarCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblProductBarCode = new DevComponents.DotNetBar.LabelX();
            this.lblPackagingProportion = new DevComponents.DotNetBar.LabelX();
            this.txtProducerName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblProducerName = new DevComponents.DotNetBar.LabelX();
            this.lblStockCondition = new DevComponents.DotNetBar.LabelX();
            this.lblPackagingProportionBaseNumber = new DevComponents.DotNetBar.LabelX();
            this.txtPackagingProportion = new DevComponents.Editors.IntegerInput();
            this.lblStockMinAmount = new DevComponents.DotNetBar.LabelX();
            this.lblScatteredCargoSpaceMaximum = new DevComponents.DotNetBar.LabelX();
            this.lblEntireCargoSpaceMaximum = new DevComponents.DotNetBar.LabelX();
            this.lblEntireSpaceUnit = new DevComponents.DotNetBar.LabelX();
            this.lblStockMinAmountUnit = new DevComponents.DotNetBar.LabelX();
            this.lblScatteredSpaceUnit = new DevComponents.DotNetBar.LabelX();
            this.txtEntireCargoSpaceMaximum = new DevComponents.Editors.IntegerInput();
            this.txtStockMinAmount = new DevComponents.Editors.IntegerInput();
            this.txtScatteredCargoSpaceMaximum = new DevComponents.Editors.IntegerInput();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.cbxStockCondition = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.txtScatteredCargoSpaceMinimum = new DevComponents.Editors.IntegerInput();
            this.swbIsSupervise = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.lblScatteredCargoSpaceMinUnit = new DevComponents.DotNetBar.LabelX();
            this.lblScatteredCargoSpaceMinimum = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.txtPackagingProportion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntireCargoSpaceMaximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockMinAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScatteredCargoSpaceMaximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScatteredCargoSpaceMinimum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.highlighter.SetHighlightOnFocus(this.btnEdit, true);
            this.btnEdit.Location = new System.Drawing.Point(461, 211);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 23);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "修改";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // grdDrugs
            // 
            this.grdDrugs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDrugs.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grdDrugs.Location = new System.Drawing.Point(12, 260);
            this.grdDrugs.Name = "grdDrugs";
            this.grdDrugs.PrimaryGrid.AllowEdit = false;
            this.grdDrugs.PrimaryGrid.AutoGenerateColumns = false;
            this.grdDrugs.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.DisplayedCells;
            gridColumn1.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn1.DataPropertyName = "ProductID";
            gridColumn1.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn1.HeaderText = "序号";
            gridColumn1.Name = "colProductID";
            gridColumn1.Visible = false;
            gridColumn2.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn2.DataPropertyName = "ProductCode";
            gridColumn2.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn2.HeaderText = "药品编号";
            gridColumn2.Name = "colProductCode";
            gridColumn3.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn3.DataPropertyName = "ProductName";
            gridColumn3.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn3.HeaderText = "药品名称";
            gridColumn3.Name = "colProductName";
            gridColumn3.Width = 200;
            gridColumn4.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            gridColumn4.DataPropertyName = "IsSupervise";
            gridColumn4.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            gridColumn4.HeaderText = "电子监管药品";
            gridColumn4.Name = "colIsSupervise";
            gridColumn5.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn5.DataPropertyName = "ProductSpec";
            gridColumn5.HeaderText = "制剂规格";
            gridColumn5.Name = "colProductSpec";
            gridColumn5.Width = 200;
            gridColumn6.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn6.DataPropertyName = "PackageSpec";
            gridColumn6.HeaderText = "包装规格";
            gridColumn6.Name = "colPackageSpec";
            gridColumn7.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn7.DataPropertyName = "PackagingProportion";
            gridColumn7.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn7.HeaderText = "包装比例";
            gridColumn7.Name = "colPackagingProportion";
            gridColumn8.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn8.DataPropertyName = "ProductBarCode";
            gridColumn8.HeaderText = "药品条码";
            gridColumn8.Name = "colProductBarCode";
            gridColumn9.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn9.DataPropertyName = "ProducerName";
            gridColumn9.HeaderText = "生产厂家";
            gridColumn9.Name = "colProducerName";
            gridColumn10.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn10.DataPropertyName = "StockCondition";
            gridColumn10.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn10.HeaderText = "储存条件";
            gridColumn10.Name = "colStockCondition";
            gridColumn11.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn11.DataPropertyName = "EntireCargoSpaceMaximum";
            gridColumn11.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn11.HeaderText = "整货最大存放数量";
            gridColumn11.Name = "colEntireCargoSpaceMaximum";
            gridColumn12.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn12.DataPropertyName = "ScatteredCargoSpaceMaximum";
            gridColumn12.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn12.HeaderText = "拆零最大存放数量";
            gridColumn12.Name = "colScatteredCargoSpaceMaximum";
            gridColumn13.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn13.DataPropertyName = "ScatteredCargoSpaceMinimum";
            gridColumn13.HeaderText = "拆零补货下限预警";
            gridColumn13.Name = "colScatteredCargoSpaceMinimum";
            gridColumn14.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn14.DataPropertyName = "StockMinAmount";
            gridColumn14.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn14.HeaderText = "库存下限预警数量";
            gridColumn14.Name = "colStockMinAmount";
            gridColumn15.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn15.DataPropertyName = "AuthorizedNo";
            gridColumn15.HeaderText = "国药准字";
            gridColumn15.Name = "colAuthorizedNo";
            gridColumn16.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn16.DataPropertyName = "ChinesePinyin";
            gridColumn16.HeaderText = "汉语拼音";
            gridColumn16.Name = "colChinesePinyin";
            gridColumn16.Visible = false;
            gridColumn17.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn17.DataPropertyName = "PhysicType";
            gridColumn17.HeaderText = "剂型";
            gridColumn17.Name = "colPhysicType";
            gridColumn18.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            gridColumn18.DataPropertyName = "Reservation1";
            gridColumn18.HeaderText = "产地";
            gridColumn18.Name = "colProductLocation";
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn1);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn2);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn3);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn4);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn5);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn6);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn7);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn8);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn9);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn10);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn11);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn12);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn13);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn14);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn15);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn16);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn17);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn18);
            this.grdDrugs.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row;
            this.grdDrugs.PrimaryGrid.MultiSelect = false;
            this.grdDrugs.PrimaryGrid.NoRowsText = "暂无记录";
            this.grdDrugs.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grdDrugs.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.grdDrugs.PrimaryGrid.ShowRowGridIndex = true;
            this.grdDrugs.PrimaryGrid.UseAlternateRowStyle = true;
            this.grdDrugs.Size = new System.Drawing.Size(903, 328);
            this.grdDrugs.TabIndex = 12;
            this.grdDrugs.RowDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs>(this.grdDrugs_RowDoubleClick);
            // 
            // lblProductCode
            // 
            // 
            // 
            // 
            this.lblProductCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblProductCode.Location = new System.Drawing.Point(75, 14);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(81, 23);
            this.lblProductCode.TabIndex = 19;
            this.lblProductCode.Text = "药品编号：";
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
            this.txtProductCode.Location = new System.Drawing.Point(162, 14);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.PreventEnterBeep = true;
            this.txtProductCode.Size = new System.Drawing.Size(150, 27);
            this.txtProductCode.TabIndex = 0;
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
            this.txtProductName.Location = new System.Drawing.Point(425, 14);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PreventEnterBeep = true;
            this.txtProductName.Size = new System.Drawing.Size(150, 27);
            this.txtProductName.TabIndex = 1;
            // 
            // lblProductName
            // 
            // 
            // 
            // 
            this.lblProductName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblProductName.Location = new System.Drawing.Point(338, 14);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(81, 23);
            this.lblProductName.TabIndex = 21;
            this.lblProductName.Text = "药品名称：";
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
            this.txtProductBarCode.Location = new System.Drawing.Point(687, 14);
            this.txtProductBarCode.Name = "txtProductBarCode";
            this.txtProductBarCode.PreventEnterBeep = true;
            this.txtProductBarCode.Size = new System.Drawing.Size(150, 27);
            this.txtProductBarCode.TabIndex = 2;
            // 
            // lblProductBarCode
            // 
            // 
            // 
            // 
            this.lblProductBarCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblProductBarCode.Location = new System.Drawing.Point(600, 14);
            this.lblProductBarCode.Name = "lblProductBarCode";
            this.lblProductBarCode.Size = new System.Drawing.Size(81, 23);
            this.lblProductBarCode.TabIndex = 23;
            this.lblProductBarCode.Text = "药品条码：";
            // 
            // lblPackagingProportion
            // 
            // 
            // 
            // 
            this.lblPackagingProportion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPackagingProportion.Location = new System.Drawing.Point(600, 42);
            this.lblPackagingProportion.Name = "lblPackagingProportion";
            this.lblPackagingProportion.Size = new System.Drawing.Size(81, 23);
            this.lblPackagingProportion.TabIndex = 29;
            this.lblPackagingProportion.Text = "包装比例：";
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
            this.txtProducerName.Location = new System.Drawing.Point(425, 43);
            this.txtProducerName.Name = "txtProducerName";
            this.txtProducerName.PreventEnterBeep = true;
            this.txtProducerName.Size = new System.Drawing.Size(150, 27);
            this.txtProducerName.TabIndex = 4;
            // 
            // lblProducerName
            // 
            // 
            // 
            // 
            this.lblProducerName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblProducerName.Location = new System.Drawing.Point(338, 43);
            this.lblProducerName.Name = "lblProducerName";
            this.lblProducerName.Size = new System.Drawing.Size(81, 23);
            this.lblProducerName.TabIndex = 27;
            this.lblProducerName.Text = "生产厂家：";
            // 
            // lblStockCondition
            // 
            // 
            // 
            // 
            this.lblStockCondition.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStockCondition.Location = new System.Drawing.Point(75, 43);
            this.lblStockCondition.Name = "lblStockCondition";
            this.lblStockCondition.Size = new System.Drawing.Size(81, 23);
            this.lblStockCondition.TabIndex = 25;
            this.lblStockCondition.Text = "储存条件：";
            // 
            // lblPackagingProportionBaseNumber
            // 
            // 
            // 
            // 
            this.lblPackagingProportionBaseNumber.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPackagingProportionBaseNumber.Location = new System.Drawing.Point(689, 43);
            this.lblPackagingProportionBaseNumber.Name = "lblPackagingProportionBaseNumber";
            this.lblPackagingProportionBaseNumber.Size = new System.Drawing.Size(30, 23);
            this.lblPackagingProportionBaseNumber.TabIndex = 31;
            this.lblPackagingProportionBaseNumber.Text = "1：";
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
            this.txtPackagingProportion.Location = new System.Drawing.Point(726, 43);
            this.txtPackagingProportion.MinValue = 0;
            this.txtPackagingProportion.Name = "txtPackagingProportion";
            this.txtPackagingProportion.ShowUpDown = true;
            this.txtPackagingProportion.Size = new System.Drawing.Size(111, 27);
            this.txtPackagingProportion.TabIndex = 5;
            // 
            // lblStockMinAmount
            // 
            // 
            // 
            // 
            this.lblStockMinAmount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStockMinAmount.Location = new System.Drawing.Point(75, 108);
            this.lblStockMinAmount.Name = "lblStockMinAmount";
            this.lblStockMinAmount.Size = new System.Drawing.Size(125, 23);
            this.lblStockMinAmount.TabIndex = 37;
            this.lblStockMinAmount.Text = "库存下线预警数量：";
            // 
            // lblScatteredCargoSpaceMaximum
            // 
            // 
            // 
            // 
            this.lblScatteredCargoSpaceMaximum.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblScatteredCargoSpaceMaximum.Location = new System.Drawing.Point(485, 78);
            this.lblScatteredCargoSpaceMaximum.Name = "lblScatteredCargoSpaceMaximum";
            this.lblScatteredCargoSpaceMaximum.Size = new System.Drawing.Size(128, 23);
            this.lblScatteredCargoSpaceMaximum.TabIndex = 35;
            this.lblScatteredCargoSpaceMaximum.Text = "拆零最大存放数量：";
            // 
            // lblEntireCargoSpaceMaximum
            // 
            // 
            // 
            // 
            this.lblEntireCargoSpaceMaximum.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEntireCargoSpaceMaximum.Location = new System.Drawing.Point(75, 77);
            this.lblEntireCargoSpaceMaximum.Name = "lblEntireCargoSpaceMaximum";
            this.lblEntireCargoSpaceMaximum.Size = new System.Drawing.Size(125, 23);
            this.lblEntireCargoSpaceMaximum.TabIndex = 33;
            this.lblEntireCargoSpaceMaximum.Text = "整货最大存放数量：";
            // 
            // lblEntireSpaceUnit
            // 
            // 
            // 
            // 
            this.lblEntireSpaceUnit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEntireSpaceUnit.Location = new System.Drawing.Point(318, 79);
            this.lblEntireSpaceUnit.Name = "lblEntireSpaceUnit";
            this.lblEntireSpaceUnit.Size = new System.Drawing.Size(101, 23);
            this.lblEntireSpaceUnit.TabIndex = 41;
            this.lblEntireSpaceUnit.Text = "（盒/袋/瓶）";
            // 
            // lblStockMinAmountUnit
            // 
            // 
            // 
            // 
            this.lblStockMinAmountUnit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStockMinAmountUnit.Location = new System.Drawing.Point(318, 110);
            this.lblStockMinAmountUnit.Name = "lblStockMinAmountUnit";
            this.lblStockMinAmountUnit.Size = new System.Drawing.Size(101, 23);
            this.lblStockMinAmountUnit.TabIndex = 42;
            this.lblStockMinAmountUnit.Text = "（盒/袋/瓶）";
            // 
            // lblScatteredSpaceUnit
            // 
            // 
            // 
            // 
            this.lblScatteredSpaceUnit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblScatteredSpaceUnit.Location = new System.Drawing.Point(731, 79);
            this.lblScatteredSpaceUnit.Name = "lblScatteredSpaceUnit";
            this.lblScatteredSpaceUnit.Size = new System.Drawing.Size(106, 23);
            this.lblScatteredSpaceUnit.TabIndex = 43;
            this.lblScatteredSpaceUnit.Text = "（盒/袋/瓶）";
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
            this.txtEntireCargoSpaceMaximum.Location = new System.Drawing.Point(206, 79);
            this.txtEntireCargoSpaceMaximum.MinValue = 0;
            this.txtEntireCargoSpaceMaximum.Name = "txtEntireCargoSpaceMaximum";
            this.txtEntireCargoSpaceMaximum.ShowUpDown = true;
            this.txtEntireCargoSpaceMaximum.Size = new System.Drawing.Size(106, 27);
            this.txtEntireCargoSpaceMaximum.TabIndex = 6;
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
            this.txtStockMinAmount.Location = new System.Drawing.Point(206, 108);
            this.txtStockMinAmount.MinValue = 0;
            this.txtStockMinAmount.Name = "txtStockMinAmount";
            this.txtStockMinAmount.ShowUpDown = true;
            this.txtStockMinAmount.Size = new System.Drawing.Size(106, 27);
            this.txtStockMinAmount.TabIndex = 8;
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
            this.txtScatteredCargoSpaceMaximum.Location = new System.Drawing.Point(619, 79);
            this.txtScatteredCargoSpaceMaximum.MinValue = 0;
            this.txtScatteredCargoSpaceMaximum.Name = "txtScatteredCargoSpaceMaximum";
            this.txtScatteredCargoSpaceMaximum.ShowUpDown = true;
            this.txtScatteredCargoSpaceMaximum.Size = new System.Drawing.Size(106, 27);
            this.txtScatteredCargoSpaceMaximum.TabIndex = 7;
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.highlighter.SetHighlightOnFocus(this.btnQuery, true);
            this.btnQuery.Location = new System.Drawing.Point(351, 211);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(84, 23);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuery.TabIndex = 10;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // cbxStockCondition
            // 
            this.cbxStockCondition.DisplayMember = "Text";
            this.cbxStockCondition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxStockCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStockCondition.FormattingEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.cbxStockCondition, true);
            this.cbxStockCondition.ItemHeight = 21;
            this.cbxStockCondition.Location = new System.Drawing.Point(162, 43);
            this.cbxStockCondition.Name = "cbxStockCondition";
            this.cbxStockCondition.Size = new System.Drawing.Size(150, 27);
            this.cbxStockCondition.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxStockCondition.TabIndex = 3;
            this.cbxStockCondition.WatermarkText = "请选择";
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
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
            this.txtScatteredCargoSpaceMinimum.Location = new System.Drawing.Point(619, 108);
            this.txtScatteredCargoSpaceMinimum.MinValue = 0;
            this.txtScatteredCargoSpaceMinimum.Name = "txtScatteredCargoSpaceMinimum";
            this.txtScatteredCargoSpaceMinimum.ShowUpDown = true;
            this.txtScatteredCargoSpaceMinimum.Size = new System.Drawing.Size(106, 27);
            this.txtScatteredCargoSpaceMinimum.TabIndex = 9;
            // 
            // swbIsSupervise
            // 
            // 
            // 
            // 
            this.swbIsSupervise.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter.SetHighlightOnFocus(this.swbIsSupervise, true);
            this.swbIsSupervise.Location = new System.Drawing.Point(229, 160);
            this.swbIsSupervise.Name = "swbIsSupervise";
            this.swbIsSupervise.OffText = "否";
            this.swbIsSupervise.OnText = "是";
            this.swbIsSupervise.Size = new System.Drawing.Size(116, 31);
            this.swbIsSupervise.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swbIsSupervise.SwitchFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.swbIsSupervise.TabIndex = 72;
            // 
            // lblScatteredCargoSpaceMinUnit
            // 
            // 
            // 
            // 
            this.lblScatteredCargoSpaceMinUnit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblScatteredCargoSpaceMinUnit.Location = new System.Drawing.Point(731, 108);
            this.lblScatteredCargoSpaceMinUnit.Name = "lblScatteredCargoSpaceMinUnit";
            this.lblScatteredCargoSpaceMinUnit.Size = new System.Drawing.Size(106, 23);
            this.lblScatteredCargoSpaceMinUnit.TabIndex = 46;
            this.lblScatteredCargoSpaceMinUnit.Text = "（盒/袋/瓶）";
            // 
            // lblScatteredCargoSpaceMinimum
            // 
            // 
            // 
            // 
            this.lblScatteredCargoSpaceMinimum.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblScatteredCargoSpaceMinimum.Location = new System.Drawing.Point(485, 108);
            this.lblScatteredCargoSpaceMinimum.Name = "lblScatteredCargoSpaceMinimum";
            this.lblScatteredCargoSpaceMinimum.Size = new System.Drawing.Size(128, 23);
            this.lblScatteredCargoSpaceMinimum.TabIndex = 45;
            this.lblScatteredCargoSpaceMinimum.Text = "拆零补货下限预警：";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(75, 160);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(148, 23);
            this.labelX1.TabIndex = 71;
            this.labelX1.Text = "是否电子监管药品：";
            // 
            // FrmDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.swbIsSupervise);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtScatteredCargoSpaceMinimum);
            this.Controls.Add(this.lblScatteredCargoSpaceMinUnit);
            this.Controls.Add(this.lblScatteredCargoSpaceMinimum);
            this.Controls.Add(this.cbxStockCondition);
            this.Controls.Add(this.btnQuery);
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
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.grdDrugs);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDrugs";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "药品管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDrugs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPackagingProportion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntireCargoSpaceMaximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockMinAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScatteredCargoSpaceMaximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScatteredCargoSpaceMinimum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnEdit;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grdDrugs;
        private DevComponents.DotNetBar.LabelX lblProductCode;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProductCode;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProductName;
        private DevComponents.DotNetBar.LabelX lblProductName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProductBarCode;
        private DevComponents.DotNetBar.LabelX lblProductBarCode;
        private DevComponents.DotNetBar.LabelX lblPackagingProportion;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProducerName;
        private DevComponents.DotNetBar.LabelX lblProducerName;
        private DevComponents.DotNetBar.LabelX lblStockCondition;
        private DevComponents.DotNetBar.LabelX lblPackagingProportionBaseNumber;
        private DevComponents.Editors.IntegerInput txtPackagingProportion;
        private DevComponents.DotNetBar.LabelX lblStockMinAmount;
        private DevComponents.DotNetBar.LabelX lblScatteredCargoSpaceMaximum;
        private DevComponents.DotNetBar.LabelX lblEntireCargoSpaceMaximum;
        private DevComponents.DotNetBar.LabelX lblEntireSpaceUnit;
        private DevComponents.DotNetBar.LabelX lblStockMinAmountUnit;
        private DevComponents.DotNetBar.LabelX lblScatteredSpaceUnit;
        private DevComponents.Editors.IntegerInput txtEntireCargoSpaceMaximum;
        private DevComponents.Editors.IntegerInput txtStockMinAmount;
        private DevComponents.Editors.IntegerInput txtScatteredCargoSpaceMaximum;
        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxStockCondition;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.Editors.IntegerInput txtScatteredCargoSpaceMinimum;
        private DevComponents.DotNetBar.LabelX lblScatteredCargoSpaceMinUnit;
        private DevComponents.DotNetBar.LabelX lblScatteredCargoSpaceMinimum;
        private DevComponents.DotNetBar.Controls.SwitchButton swbIsSupervise;
        private DevComponents.DotNetBar.LabelX labelX1;

    }
}