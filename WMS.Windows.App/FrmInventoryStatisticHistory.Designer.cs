namespace WMS.Windows.App
{
    partial class FrmInventoryStatisticHistory
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
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn19 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn20 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn21 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn22 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn23 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventoryStatisticHistory));
            this.panSearch = new DevComponents.DotNetBar.PanelEx();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.grdInventoryStatisticDetail = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.lblStoreCode = new DevComponents.DotNetBar.LabelX();
            this.lblDetailTitle = new DevComponents.DotNetBar.LabelX();
            this.lblTitle = new DevComponents.DotNetBar.LabelX();
            this.grdInventoryStatistic = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.datEndDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.datStartDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtStatisticCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.lblStoreOutCode = new DevComponents.DotNetBar.LabelX();
            this.lblStoreOutEndDate = new DevComponents.DotNetBar.LabelX();
            this.lblStoreOutStartDate = new DevComponents.DotNetBar.LabelX();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnRefresh = new DevComponents.DotNetBar.ButtonItem();
            this.btnPrint = new DevComponents.DotNetBar.ButtonItem();
            this.btnUpdateStore = new DevComponents.DotNetBar.ButtonItem();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panSearch
            // 
            this.panSearch.CanvasColor = System.Drawing.SystemColors.Control;
            this.panSearch.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panSearch.Controls.Add(this.line1);
            this.panSearch.Controls.Add(this.grdInventoryStatisticDetail);
            this.panSearch.Controls.Add(this.lblStoreCode);
            this.panSearch.Controls.Add(this.lblDetailTitle);
            this.panSearch.Controls.Add(this.lblTitle);
            this.panSearch.Controls.Add(this.grdInventoryStatistic);
            this.panSearch.Controls.Add(this.datEndDate);
            this.panSearch.Controls.Add(this.datStartDate);
            this.panSearch.Controls.Add(this.txtStatisticCode);
            this.panSearch.Controls.Add(this.btnSearch);
            this.panSearch.Controls.Add(this.lblStoreOutCode);
            this.panSearch.Controls.Add(this.lblStoreOutEndDate);
            this.panSearch.Controls.Add(this.lblStoreOutStartDate);
            this.panSearch.DisabledBackColor = System.Drawing.Color.Empty;
            this.panSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panSearch.Location = new System.Drawing.Point(0, 63);
            this.panSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panSearch.Name = "panSearch";
            this.panSearch.Padding = new System.Windows.Forms.Padding(0, 46, 0, 0);
            this.panSearch.Size = new System.Drawing.Size(1338, 563);
            this.panSearch.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panSearch.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panSearch.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panSearch.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panSearch.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panSearch.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panSearch.Style.GradientAngle = 90;
            this.panSearch.TabIndex = 16;
            // 
            // line1
            // 
            this.line1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line1.Location = new System.Drawing.Point(3, 50);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(1332, 23);
            this.line1.TabIndex = 24;
            this.line1.Text = "line1";
            // 
            // grdInventoryStatisticDetail
            // 
            this.grdInventoryStatisticDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdInventoryStatisticDetail.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grdInventoryStatisticDetail.Location = new System.Drawing.Point(3, 336);
            this.grdInventoryStatisticDetail.Name = "grdInventoryStatisticDetail";
            this.grdInventoryStatisticDetail.PrimaryGrid.AllowEdit = false;
            this.grdInventoryStatisticDetail.PrimaryGrid.AutoGenerateColumns = false;
            this.grdInventoryStatisticDetail.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn1.DataPropertyName = "CargoSpaceStoreDetailID";
            gridColumn1.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn1.HeaderText = "序号";
            gridColumn1.Name = "colDetailID";
            gridColumn1.Visible = false;
            gridColumn2.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            gridColumn2.DataPropertyName = "StatusName";
            gridColumn2.HeaderText = "状态";
            gridColumn2.Name = "colStatusName";
            gridColumn3.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn3.DataPropertyName = "StructureCode";
            gridColumn3.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn3.HeaderText = "货位编码";
            gridColumn3.Name = "colStructureCode";
            gridColumn4.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            gridColumn4.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn4.DataPropertyName = "StructureName";
            gridColumn4.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn4.HeaderText = "货位";
            gridColumn4.Name = "colStructureName";
            gridColumn5.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            gridColumn5.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn5.DataPropertyName = "AreaType";
            gridColumn5.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn5.HeaderText = "货区类型";
            gridColumn5.Name = "colAreaType";
            gridColumn6.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            gridColumn6.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridColumn6.DataPropertyName = "ProductName";
            gridColumn6.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn6.HeaderText = "药品名称";
            gridColumn6.Name = "colProductName";
            gridColumn7.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn7.DataPropertyName = "PackagingSpecification";
            gridColumn7.HeaderText = "包装规格";
            gridColumn7.Name = "colPackagingSpecification";
            gridColumn8.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn8.DataPropertyName = "ProductBatchNumber";
            gridColumn8.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn8.HeaderText = "批号";
            gridColumn8.Name = "colBatchNo";
            gridColumn9.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn9.DataPropertyName = "ProductionDate";
            gridColumn9.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl);
            gridColumn9.HeaderText = "生产日期";
            gridColumn9.Name = "colProduceDate";
            gridColumn10.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn10.DataPropertyName = "ProductValidDate";
            gridColumn10.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl);
            gridColumn10.HeaderText = "有效期至";
            gridColumn10.Name = "colValidateDate";
            gridColumn11.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn11.DataPropertyName = "ProductAmount";
            gridColumn11.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn11.HeaderText = "数量";
            gridColumn11.Name = "colAmount";
            gridColumn12.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            gridColumn12.DataPropertyName = "VerifiedProductAmount";
            gridColumn12.HeaderText = "盘点数量";
            gridColumn12.Name = "colVerifiedAmount";
            gridColumn13.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            gridColumn13.DataPropertyName = "StockCondition";
            gridColumn13.HeaderText = "存储条件";
            gridColumn13.Name = "colStockCondition";
            gridColumn14.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn14.DataPropertyName = "ProductSpec";
            gridColumn14.HeaderText = "制剂规格";
            gridColumn14.Name = "colProductSpec";
            gridColumn15.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn15.DataPropertyName = "PackageSpec";
            gridColumn15.HeaderText = "包装规格";
            gridColumn15.Name = "colPackageSpec";
            gridColumn16.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn16.DataPropertyName = "DosageForm";
            gridColumn16.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn16.HeaderText = "剂型";
            gridColumn16.Name = "colDosageForm";
            gridColumn17.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            gridColumn17.DataPropertyName = "PackagingProportion";
            gridColumn17.HeaderText = "包装比例";
            gridColumn17.Name = "colPackagingProportion";
            gridColumn18.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn18.DataPropertyName = "Manufacturer";
            gridColumn18.HeaderText = "生产厂商";
            gridColumn18.Name = "colProducerName";
            this.grdInventoryStatisticDetail.PrimaryGrid.Columns.Add(gridColumn1);
            this.grdInventoryStatisticDetail.PrimaryGrid.Columns.Add(gridColumn2);
            this.grdInventoryStatisticDetail.PrimaryGrid.Columns.Add(gridColumn3);
            this.grdInventoryStatisticDetail.PrimaryGrid.Columns.Add(gridColumn4);
            this.grdInventoryStatisticDetail.PrimaryGrid.Columns.Add(gridColumn5);
            this.grdInventoryStatisticDetail.PrimaryGrid.Columns.Add(gridColumn6);
            this.grdInventoryStatisticDetail.PrimaryGrid.Columns.Add(gridColumn7);
            this.grdInventoryStatisticDetail.PrimaryGrid.Columns.Add(gridColumn8);
            this.grdInventoryStatisticDetail.PrimaryGrid.Columns.Add(gridColumn9);
            this.grdInventoryStatisticDetail.PrimaryGrid.Columns.Add(gridColumn10);
            this.grdInventoryStatisticDetail.PrimaryGrid.Columns.Add(gridColumn11);
            this.grdInventoryStatisticDetail.PrimaryGrid.Columns.Add(gridColumn12);
            this.grdInventoryStatisticDetail.PrimaryGrid.Columns.Add(gridColumn13);
            this.grdInventoryStatisticDetail.PrimaryGrid.Columns.Add(gridColumn14);
            this.grdInventoryStatisticDetail.PrimaryGrid.Columns.Add(gridColumn15);
            this.grdInventoryStatisticDetail.PrimaryGrid.Columns.Add(gridColumn16);
            this.grdInventoryStatisticDetail.PrimaryGrid.Columns.Add(gridColumn17);
            this.grdInventoryStatisticDetail.PrimaryGrid.Columns.Add(gridColumn18);
            this.grdInventoryStatisticDetail.PrimaryGrid.MultiSelect = false;
            this.grdInventoryStatisticDetail.PrimaryGrid.NoRowsText = "暂无记录";
            this.grdInventoryStatisticDetail.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grdInventoryStatisticDetail.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.grdInventoryStatisticDetail.PrimaryGrid.ShowRowGridIndex = true;
            this.grdInventoryStatisticDetail.Size = new System.Drawing.Size(1332, 215);
            this.grdInventoryStatisticDetail.TabIndex = 18;
            this.grdInventoryStatisticDetail.Text = "superGridControl2";
            // 
            // lblStoreCode
            // 
            // 
            // 
            // 
            this.lblStoreCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStoreCode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStoreCode.Location = new System.Drawing.Point(131, 305);
            this.lblStoreCode.Name = "lblStoreCode";
            this.lblStoreCode.Size = new System.Drawing.Size(308, 25);
            this.lblStoreCode.TabIndex = 23;
            // 
            // lblDetailTitle
            // 
            // 
            // 
            // 
            this.lblDetailTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDetailTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDetailTitle.Location = new System.Drawing.Point(3, 307);
            this.lblDetailTitle.Name = "lblDetailTitle";
            this.lblDetailTitle.Size = new System.Drawing.Size(144, 23);
            this.lblDetailTitle.TabIndex = 20;
            this.lblDetailTitle.Text = "盘库单明细：";
            // 
            // lblTitle
            // 
            // 
            // 
            // 
            this.lblTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(3, 75);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(115, 23);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "盘库单：";
            // 
            // grdInventoryStatistic
            // 
            this.grdInventoryStatistic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdInventoryStatistic.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grdInventoryStatistic.Location = new System.Drawing.Point(3, 104);
            this.grdInventoryStatistic.Name = "grdInventoryStatistic";
            this.grdInventoryStatistic.PrimaryGrid.AllowEdit = false;
            this.grdInventoryStatistic.PrimaryGrid.AutoGenerateColumns = false;
            this.grdInventoryStatistic.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn19.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            gridColumn19.DataPropertyName = "InventoryStatisticID";
            gridColumn19.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn19.HeaderText = "序号";
            gridColumn19.Name = "colInventoryStatisticID";
            gridColumn19.Visible = false;
            gridColumn20.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn20.DataPropertyName = "InventoryStatisticCode";
            gridColumn20.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn20.HeaderText = "盘库单编号";
            gridColumn20.Name = "colInventoryStatisticCode";
            gridColumn21.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn21.DataPropertyName = "StartDate";
            gridColumn21.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl);
            gridColumn21.HeaderText = "开始时间";
            gridColumn21.Name = "colStartDate";
            gridColumn22.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            gridColumn22.DataPropertyName = "EndDate";
            gridColumn22.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl);
            gridColumn22.HeaderText = "结束时间";
            gridColumn22.Name = "colEndDate";
            gridColumn23.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn23.DataPropertyName = "StatusName";
            gridColumn23.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn23.HeaderText = "状态";
            gridColumn23.Name = "colStatusName";
            this.grdInventoryStatistic.PrimaryGrid.Columns.Add(gridColumn19);
            this.grdInventoryStatistic.PrimaryGrid.Columns.Add(gridColumn20);
            this.grdInventoryStatistic.PrimaryGrid.Columns.Add(gridColumn21);
            this.grdInventoryStatistic.PrimaryGrid.Columns.Add(gridColumn22);
            this.grdInventoryStatistic.PrimaryGrid.Columns.Add(gridColumn23);
            this.grdInventoryStatistic.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row;
            this.grdInventoryStatistic.PrimaryGrid.MultiSelect = false;
            this.grdInventoryStatistic.PrimaryGrid.NoRowsText = "暂无记录";
            this.grdInventoryStatistic.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grdInventoryStatistic.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.grdInventoryStatistic.PrimaryGrid.ShowRowGridIndex = true;
            this.grdInventoryStatistic.PrimaryGrid.UseAlternateRowStyle = true;
            this.grdInventoryStatistic.Size = new System.Drawing.Size(1332, 195);
            this.grdInventoryStatistic.TabIndex = 17;
            this.grdInventoryStatistic.RowActivated += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowActivatedEventArgs>(this.grdInventoryStatistic_RowActivated);
            // 
            // datEndDate
            // 
            // 
            // 
            // 
            this.datEndDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.datEndDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datEndDate.ButtonClear.Visible = true;
            this.datEndDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.datEndDate.ButtonDropDown.Visible = true;
            this.datEndDate.Format = DevComponents.Editors.eDateTimePickerFormat.Long;
            this.datEndDate.IsPopupCalendarOpen = false;
            this.datEndDate.Location = new System.Drawing.Point(699, 16);
            this.datEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.datEndDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.datEndDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datEndDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.datEndDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.datEndDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.datEndDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.datEndDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.datEndDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.datEndDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.datEndDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datEndDate.MonthCalendar.DisplayMonth = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.datEndDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.datEndDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.datEndDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.datEndDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.datEndDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.datEndDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datEndDate.MonthCalendar.TodayButtonVisible = true;
            this.datEndDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.datEndDate.Name = "datEndDate";
            this.datEndDate.Size = new System.Drawing.Size(191, 27);
            this.datEndDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.datEndDate.TabIndex = 9;
            // 
            // datStartDate
            // 
            // 
            // 
            // 
            this.datStartDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.datStartDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datStartDate.ButtonClear.Visible = true;
            this.datStartDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.datStartDate.ButtonDropDown.Visible = true;
            this.datStartDate.Format = DevComponents.Editors.eDateTimePickerFormat.Long;
            this.datStartDate.IsPopupCalendarOpen = false;
            this.datStartDate.Location = new System.Drawing.Point(411, 16);
            this.datStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.datStartDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.datStartDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datStartDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.datStartDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.datStartDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.datStartDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.datStartDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.datStartDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.datStartDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.datStartDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datStartDate.MonthCalendar.DisplayMonth = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.datStartDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.datStartDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.datStartDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.datStartDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.datStartDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.datStartDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datStartDate.MonthCalendar.TodayButtonVisible = true;
            this.datStartDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.datStartDate.Name = "datStartDate";
            this.datStartDate.Size = new System.Drawing.Size(191, 27);
            this.datStartDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.datStartDate.TabIndex = 9;
            // 
            // txtStatisticCode
            // 
            // 
            // 
            // 
            this.txtStatisticCode.Border.Class = "TextBoxBorder";
            this.txtStatisticCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStatisticCode.Location = new System.Drawing.Point(108, 16);
            this.txtStatisticCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStatisticCode.Name = "txtStatisticCode";
            this.txtStatisticCode.PreventEnterBeep = true;
            this.txtStatisticCode.Size = new System.Drawing.Size(191, 27);
            this.txtStatisticCode.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Location = new System.Drawing.Point(930, 16);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 28);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "查询";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblStoreOutCode
            // 
            this.lblStoreOutCode.AutoSize = true;
            // 
            // 
            // 
            this.lblStoreOutCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStoreOutCode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStoreOutCode.Location = new System.Drawing.Point(17, 16);
            this.lblStoreOutCode.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblStoreOutCode.Name = "lblStoreOutCode";
            this.lblStoreOutCode.Size = new System.Drawing.Size(85, 24);
            this.lblStoreOutCode.TabIndex = 2;
            this.lblStoreOutCode.Text = "盘库单号：";
            // 
            // lblStoreOutEndDate
            // 
            this.lblStoreOutEndDate.AutoSize = true;
            // 
            // 
            // 
            this.lblStoreOutEndDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStoreOutEndDate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStoreOutEndDate.Location = new System.Drawing.Point(608, 16);
            this.lblStoreOutEndDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblStoreOutEndDate.Name = "lblStoreOutEndDate";
            this.lblStoreOutEndDate.Size = new System.Drawing.Size(85, 24);
            this.lblStoreOutEndDate.TabIndex = 5;
            this.lblStoreOutEndDate.Text = "结束时间：";
            // 
            // lblStoreOutStartDate
            // 
            this.lblStoreOutStartDate.AutoSize = true;
            // 
            // 
            // 
            this.lblStoreOutStartDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStoreOutStartDate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStoreOutStartDate.Location = new System.Drawing.Point(320, 16);
            this.lblStoreOutStartDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblStoreOutStartDate.Name = "lblStoreOutStartDate";
            this.lblStoreOutStartDate.Size = new System.Drawing.Size(85, 24);
            this.lblStoreOutStartDate.TabIndex = 5;
            this.lblStoreOutStartDate.Text = "开始时间：";
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.bar1.Images = this.imageList;
            this.bar1.ImageSize = DevComponents.DotNetBar.eBarImageSize.Large;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnRefresh,
            this.btnPrint,
            this.btnUpdateStore});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(1338, 63);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.bar1.TabIndex = 21;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "refresh.png");
            this.imageList.Images.SetKeyName(1, "cancel.png");
            this.imageList.Images.SetKeyName(2, "save.png");
            this.imageList.Images.SetKeyName(3, "print.png");
            // 
            // btnRefresh
            // 
            this.btnRefresh.Enabled = false;
            this.btnRefresh.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnRefresh.ImageIndex = 0;
            this.btnRefresh.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PopupType = DevComponents.DotNetBar.ePopupType.ToolBar;
            this.btnRefresh.Text = "一键完成";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.ImageIndex = 3;
            this.btnPrint.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Text = "打印";
            this.btnPrint.Tooltip = "打印盘点单";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnUpdateStore
            // 
            this.btnUpdateStore.Enabled = false;
            this.btnUpdateStore.ImageIndex = 2;
            this.btnUpdateStore.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnUpdateStore.Name = "btnUpdateStore";
            this.btnUpdateStore.Text = "更新库存";
            this.btnUpdateStore.Tooltip = "更新库存并同步业务库存";
            this.btnUpdateStore.Click += new System.EventHandler(this.btnUpdateStore_Click);
            // 
            // FrmInventoryStatisticHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 626);
            this.Controls.Add(this.panSearch);
            this.Controls.Add(this.bar1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmInventoryStatisticHistory";
            this.Text = "盘点历史";
            this.Load += new System.EventHandler(this.FrmInventoryStatisticHistory_Load);
            this.panSearch.ResumeLayout(false);
            this.panSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panSearch;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.LabelX lblStoreOutCode;
        private DevComponents.DotNetBar.LabelX lblStoreOutStartDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput datStartDate;
        private DevComponents.DotNetBar.Controls.TextBoxX txtStatisticCode;
        private DevComponents.DotNetBar.LabelX lblStoreOutEndDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput datEndDate;
        private DevComponents.DotNetBar.LabelX lblDetailTitle;
        private DevComponents.DotNetBar.LabelX lblTitle;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grdInventoryStatisticDetail;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grdInventoryStatistic;
        private DevComponents.DotNetBar.LabelX lblStoreCode;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnRefresh;
        private DevComponents.DotNetBar.ButtonItem btnUpdateStore;
        private DevComponents.DotNetBar.ButtonItem btnPrint;
        private System.Windows.Forms.ImageList imageList;
        private DevComponents.DotNetBar.Controls.Line line1;
    }
}