namespace WMS.Windows.App
{
    partial class FrmStoreInHistory
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
            this.panSearch = new DevComponents.DotNetBar.PanelEx();
            this.cbxStoreInType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.itmOrderIn = new DevComponents.Editors.ComboItem();
            this.itmReturnStore = new DevComponents.Editors.ComboItem();
            this.datStoreInEndDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.datStoreInStartDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtStoreOutCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDealerName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblStoreInType = new DevComponents.DotNetBar.LabelX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.lblStoreOutCode = new DevComponents.DotNetBar.LabelX();
            this.lblDealerName = new DevComponents.DotNetBar.LabelX();
            this.lblStoreOutEndDate = new DevComponents.DotNetBar.LabelX();
            this.lblStoreOutStartDate = new DevComponents.DotNetBar.LabelX();
            this.lblDetailTitle = new DevComponents.DotNetBar.LabelX();
            this.lblTitle = new DevComponents.DotNetBar.LabelX();
            this.grdStoreInDetail = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.grdStoreIn = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.lblStoreCode = new DevComponents.DotNetBar.LabelX();
            this.btnPrintCargoCode = new DevComponents.DotNetBar.ButtonX();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datStoreInEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datStoreInStartDate)).BeginInit();
            this.SuspendLayout();
            // 
            // panSearch
            // 
            this.panSearch.CanvasColor = System.Drawing.SystemColors.Control;
            this.panSearch.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panSearch.Controls.Add(this.cbxStoreInType);
            this.panSearch.Controls.Add(this.datStoreInEndDate);
            this.panSearch.Controls.Add(this.datStoreInStartDate);
            this.panSearch.Controls.Add(this.txtStoreOutCode);
            this.panSearch.Controls.Add(this.txtDealerName);
            this.panSearch.Controls.Add(this.lblStoreInType);
            this.panSearch.Controls.Add(this.btnSearch);
            this.panSearch.Controls.Add(this.lblStoreOutCode);
            this.panSearch.Controls.Add(this.lblDealerName);
            this.panSearch.Controls.Add(this.lblStoreOutEndDate);
            this.panSearch.Controls.Add(this.lblStoreOutStartDate);
            this.panSearch.DisabledBackColor = System.Drawing.Color.Empty;
            this.panSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSearch.Location = new System.Drawing.Point(0, 0);
            this.panSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panSearch.Name = "panSearch";
            this.panSearch.Padding = new System.Windows.Forms.Padding(0, 46, 0, 0);
            this.panSearch.Size = new System.Drawing.Size(941, 80);
            this.panSearch.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panSearch.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panSearch.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panSearch.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panSearch.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panSearch.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panSearch.Style.GradientAngle = 90;
            this.panSearch.TabIndex = 16;
            // 
            // cbxStoreInType
            // 
            this.cbxStoreInType.DisplayMember = "Text";
            this.cbxStoreInType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxStoreInType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStoreInType.FormattingEnabled = true;
            this.cbxStoreInType.ItemHeight = 21;
            this.cbxStoreInType.Items.AddRange(new object[] {
            this.itmOrderIn,
            this.itmReturnStore});
            this.cbxStoreInType.Location = new System.Drawing.Point(370, 13);
            this.cbxStoreInType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxStoreInType.Name = "cbxStoreInType";
            this.cbxStoreInType.Size = new System.Drawing.Size(191, 27);
            this.cbxStoreInType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxStoreInType.TabIndex = 10;
            this.cbxStoreInType.WatermarkText = "请选择";
            // 
            // itmOrderIn
            // 
            this.itmOrderIn.Text = "采购入库";
            // 
            // itmReturnStore
            // 
            this.itmReturnStore.Text = "销售退回入库";
            // 
            // datStoreInEndDate
            // 
            // 
            // 
            // 
            this.datStoreInEndDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.datStoreInEndDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datStoreInEndDate.ButtonClear.Visible = true;
            this.datStoreInEndDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.datStoreInEndDate.ButtonDropDown.Visible = true;
            this.datStoreInEndDate.Format = DevComponents.Editors.eDateTimePickerFormat.Long;
            this.datStoreInEndDate.IsPopupCalendarOpen = false;
            this.datStoreInEndDate.Location = new System.Drawing.Point(370, 42);
            this.datStoreInEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.datStoreInEndDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.datStoreInEndDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datStoreInEndDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.datStoreInEndDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.datStoreInEndDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.datStoreInEndDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.datStoreInEndDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.datStoreInEndDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.datStoreInEndDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.datStoreInEndDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datStoreInEndDate.MonthCalendar.DisplayMonth = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.datStoreInEndDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.datStoreInEndDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.datStoreInEndDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.datStoreInEndDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.datStoreInEndDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.datStoreInEndDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datStoreInEndDate.MonthCalendar.TodayButtonVisible = true;
            this.datStoreInEndDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.datStoreInEndDate.Name = "datStoreInEndDate";
            this.datStoreInEndDate.Size = new System.Drawing.Size(191, 27);
            this.datStoreInEndDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.datStoreInEndDate.TabIndex = 9;
            // 
            // datStoreInStartDate
            // 
            // 
            // 
            // 
            this.datStoreInStartDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.datStoreInStartDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datStoreInStartDate.ButtonClear.Visible = true;
            this.datStoreInStartDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.datStoreInStartDate.ButtonDropDown.Visible = true;
            this.datStoreInStartDate.Format = DevComponents.Editors.eDateTimePickerFormat.Long;
            this.datStoreInStartDate.IsPopupCalendarOpen = false;
            this.datStoreInStartDate.Location = new System.Drawing.Point(91, 42);
            this.datStoreInStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.datStoreInStartDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.datStoreInStartDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datStoreInStartDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.datStoreInStartDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.datStoreInStartDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.datStoreInStartDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.datStoreInStartDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.datStoreInStartDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.datStoreInStartDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.datStoreInStartDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datStoreInStartDate.MonthCalendar.DisplayMonth = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.datStoreInStartDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.datStoreInStartDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.datStoreInStartDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.datStoreInStartDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.datStoreInStartDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.datStoreInStartDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datStoreInStartDate.MonthCalendar.TodayButtonVisible = true;
            this.datStoreInStartDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.datStoreInStartDate.Name = "datStoreInStartDate";
            this.datStoreInStartDate.Size = new System.Drawing.Size(191, 27);
            this.datStoreInStartDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.datStoreInStartDate.TabIndex = 9;
            // 
            // txtStoreOutCode
            // 
            // 
            // 
            // 
            this.txtStoreOutCode.Border.Class = "TextBoxBorder";
            this.txtStoreOutCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStoreOutCode.Location = new System.Drawing.Point(91, 16);
            this.txtStoreOutCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStoreOutCode.Name = "txtStoreOutCode";
            this.txtStoreOutCode.PreventEnterBeep = true;
            this.txtStoreOutCode.Size = new System.Drawing.Size(191, 27);
            this.txtStoreOutCode.TabIndex = 6;
            // 
            // txtDealerName
            // 
            // 
            // 
            // 
            this.txtDealerName.Border.Class = "TextBoxBorder";
            this.txtDealerName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDealerName.Location = new System.Drawing.Point(648, 13);
            this.txtDealerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.PreventEnterBeep = true;
            this.txtDealerName.Size = new System.Drawing.Size(191, 27);
            this.txtDealerName.TabIndex = 8;
            // 
            // lblStoreInType
            // 
            this.lblStoreInType.AutoSize = true;
            // 
            // 
            // 
            this.lblStoreInType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStoreInType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStoreInType.Location = new System.Drawing.Point(296, 16);
            this.lblStoreInType.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblStoreInType.Name = "lblStoreInType";
            this.lblStoreInType.Size = new System.Drawing.Size(85, 24);
            this.lblStoreInType.TabIndex = 3;
            this.lblStoreInType.Text = "入库类型：";
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Location = new System.Drawing.Point(648, 42);
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
            this.lblStoreOutCode.Text = "入库单号：";
            // 
            // lblDealerName
            // 
            this.lblDealerName.AutoSize = true;
            // 
            // 
            // 
            this.lblDealerName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDealerName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDealerName.Location = new System.Drawing.Point(574, 16);
            this.lblDealerName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblDealerName.Name = "lblDealerName";
            this.lblDealerName.Size = new System.Drawing.Size(85, 24);
            this.lblDealerName.TabIndex = 4;
            this.lblDealerName.Text = "往来单位：";
            // 
            // lblStoreOutEndDate
            // 
            this.lblStoreOutEndDate.AutoSize = true;
            // 
            // 
            // 
            this.lblStoreOutEndDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStoreOutEndDate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStoreOutEndDate.Location = new System.Drawing.Point(296, 45);
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
            this.lblStoreOutStartDate.Location = new System.Drawing.Point(17, 45);
            this.lblStoreOutStartDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblStoreOutStartDate.Name = "lblStoreOutStartDate";
            this.lblStoreOutStartDate.Size = new System.Drawing.Size(85, 24);
            this.lblStoreOutStartDate.TabIndex = 5;
            this.lblStoreOutStartDate.Text = "开始时间：";
            // 
            // lblDetailTitle
            // 
            // 
            // 
            // 
            this.lblDetailTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDetailTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDetailTitle.Location = new System.Drawing.Point(-2, 305);
            this.lblDetailTitle.Name = "lblDetailTitle";
            this.lblDetailTitle.Size = new System.Drawing.Size(116, 23);
            this.lblDetailTitle.TabIndex = 20;
            this.lblDetailTitle.Text = "入库单明细：";
            // 
            // lblTitle
            // 
            // 
            // 
            // 
            this.lblTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(0, 84);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(75, 23);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "入库单：";
            // 
            // grdStoreInDetail
            // 
            this.grdStoreInDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdStoreInDetail.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grdStoreInDetail.Location = new System.Drawing.Point(0, 334);
            this.grdStoreInDetail.Name = "grdStoreInDetail";
            this.grdStoreInDetail.PrimaryGrid.AllowEdit = false;
            this.grdStoreInDetail.PrimaryGrid.AutoGenerateColumns = false;
            this.grdStoreInDetail.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn1.DataPropertyName = "DetailID";
            gridColumn1.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn1.HeaderText = "序号";
            gridColumn1.Name = "colDetailID";
            gridColumn1.Visible = false;
            gridColumn2.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            gridColumn2.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridColumn2.DataPropertyName = "ProductName";
            gridColumn2.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn2.HeaderText = "药品名称";
            gridColumn2.Name = "colProductName";
            gridColumn3.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn3.DataPropertyName = "ProductSpec";
            gridColumn3.HeaderText = "制剂规格";
            gridColumn3.Name = "colProductSpec";
            gridColumn4.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn4.DataPropertyName = "PackageSpec";
            gridColumn4.HeaderText = "包装规格";
            gridColumn4.Name = "colPackageSpec";
            gridColumn5.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn5.DataPropertyName = "BatchNo";
            gridColumn5.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn5.HeaderText = "批号";
            gridColumn5.Name = "colBatchNo";
            gridColumn6.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn6.DataPropertyName = "ProduceDateString";
            gridColumn6.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn6.HeaderText = "生产日期";
            gridColumn6.Name = "colProduceDate";
            gridColumn7.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn7.DataPropertyName = "ValidateDateString";
            gridColumn7.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn7.HeaderText = "有效期";
            gridColumn7.Name = "colValidateDate";
            gridColumn8.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            gridColumn8.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn8.DataPropertyName = "StructureName";
            gridColumn8.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn8.HeaderText = "货位";
            gridColumn8.Name = "colStructureName";
            gridColumn9.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn9.DataPropertyName = "StructureCode";
            gridColumn9.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn9.HeaderText = "货位编码";
            gridColumn9.Name = "colStructureCode";
            gridColumn10.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn10.DataPropertyName = "Amount";
            gridColumn10.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn10.HeaderText = "数量";
            gridColumn10.Name = "colAmount";
            gridColumn11.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn11.DataPropertyName = "PackagingAmount";
            gridColumn11.HeaderText = "件数";
            gridColumn11.Name = "colPackagingAmount";
            gridColumn11.Visible = false;
            gridColumn12.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn12.DataPropertyName = "StatusName";
            gridColumn12.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn12.HeaderText = "状态";
            gridColumn12.Name = "colStatusName";
            gridColumn13.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            gridColumn13.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn13.DataPropertyName = "ControlTypeString";
            gridColumn13.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn13.HeaderText = "说明";
            gridColumn13.Name = "colControlType";
            gridColumn14.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn14.DataPropertyName = "ProducerName";
            gridColumn14.HeaderText = "生产厂商";
            gridColumn14.Name = "colProducerName";
            this.grdStoreInDetail.PrimaryGrid.Columns.Add(gridColumn1);
            this.grdStoreInDetail.PrimaryGrid.Columns.Add(gridColumn2);
            this.grdStoreInDetail.PrimaryGrid.Columns.Add(gridColumn3);
            this.grdStoreInDetail.PrimaryGrid.Columns.Add(gridColumn4);
            this.grdStoreInDetail.PrimaryGrid.Columns.Add(gridColumn5);
            this.grdStoreInDetail.PrimaryGrid.Columns.Add(gridColumn6);
            this.grdStoreInDetail.PrimaryGrid.Columns.Add(gridColumn7);
            this.grdStoreInDetail.PrimaryGrid.Columns.Add(gridColumn8);
            this.grdStoreInDetail.PrimaryGrid.Columns.Add(gridColumn9);
            this.grdStoreInDetail.PrimaryGrid.Columns.Add(gridColumn10);
            this.grdStoreInDetail.PrimaryGrid.Columns.Add(gridColumn11);
            this.grdStoreInDetail.PrimaryGrid.Columns.Add(gridColumn12);
            this.grdStoreInDetail.PrimaryGrid.Columns.Add(gridColumn13);
            this.grdStoreInDetail.PrimaryGrid.Columns.Add(gridColumn14);
            this.grdStoreInDetail.PrimaryGrid.MultiSelect = false;
            this.grdStoreInDetail.PrimaryGrid.NoRowsText = "暂无记录";
            this.grdStoreInDetail.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grdStoreInDetail.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.grdStoreInDetail.PrimaryGrid.ShowRowGridIndex = true;
            this.grdStoreInDetail.Size = new System.Drawing.Size(941, 208);
            this.grdStoreInDetail.TabIndex = 18;
            this.grdStoreInDetail.Text = "superGridControl2";
            this.grdStoreInDetail.RowActivated += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowActivatedEventArgs>(this.grdStoreInDetail_RowActivated);
            // 
            // grdStoreIn
            // 
            this.grdStoreIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdStoreIn.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grdStoreIn.Location = new System.Drawing.Point(0, 113);
            this.grdStoreIn.Name = "grdStoreIn";
            this.grdStoreIn.PrimaryGrid.AllowEdit = false;
            this.grdStoreIn.PrimaryGrid.AutoGenerateColumns = false;
            this.grdStoreIn.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn15.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            gridColumn15.DataPropertyName = "StoreID";
            gridColumn15.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn15.HeaderText = "序号";
            gridColumn15.Name = "colStoreID";
            gridColumn15.Visible = false;
            gridColumn16.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn16.DataPropertyName = "StoreCode";
            gridColumn16.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn16.HeaderText = "入库单编号";
            gridColumn16.Name = "colStoreCode";
            gridColumn17.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn17.DataPropertyName = "StoreTypeName";
            gridColumn17.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn17.HeaderText = "入库类型";
            gridColumn17.Name = "colStoreTypeName";
            gridColumn18.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn18.DataPropertyName = "DealerName";
            gridColumn18.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn18.HeaderText = "往来单位";
            gridColumn18.Name = "colDealerName";
            gridColumn19.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn19.DataPropertyName = "StoreDate";
            gridColumn19.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl);
            gridColumn19.HeaderText = "入库时间";
            gridColumn19.Name = "colStoreBillDate";
            gridColumn20.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn20.DataPropertyName = "StoreStatusName";
            gridColumn20.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn20.HeaderText = "入库状态";
            gridColumn20.Name = "colStoreBillStatus";
            gridColumn21.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn21.DataPropertyName = "StoreRemark";
            gridColumn21.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn21.HeaderText = "说明";
            gridColumn21.Name = "colStoreRemark";
            this.grdStoreIn.PrimaryGrid.Columns.Add(gridColumn15);
            this.grdStoreIn.PrimaryGrid.Columns.Add(gridColumn16);
            this.grdStoreIn.PrimaryGrid.Columns.Add(gridColumn17);
            this.grdStoreIn.PrimaryGrid.Columns.Add(gridColumn18);
            this.grdStoreIn.PrimaryGrid.Columns.Add(gridColumn19);
            this.grdStoreIn.PrimaryGrid.Columns.Add(gridColumn20);
            this.grdStoreIn.PrimaryGrid.Columns.Add(gridColumn21);
            this.grdStoreIn.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row;
            this.grdStoreIn.PrimaryGrid.MultiSelect = false;
            this.grdStoreIn.PrimaryGrid.NoRowsText = "暂无记录";
            this.grdStoreIn.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grdStoreIn.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.grdStoreIn.PrimaryGrid.ShowRowGridIndex = true;
            this.grdStoreIn.PrimaryGrid.UseAlternateRowStyle = true;
            this.grdStoreIn.Size = new System.Drawing.Size(941, 186);
            this.grdStoreIn.TabIndex = 17;
            this.grdStoreIn.Text = "superGridControl1";
            this.grdStoreIn.RowActivated += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowActivatedEventArgs>(this.grdStoreIn_RowActivated);
            // 
            // lblStoreCode
            // 
            // 
            // 
            // 
            this.lblStoreCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStoreCode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStoreCode.Location = new System.Drawing.Point(103, 305);
            this.lblStoreCode.Name = "lblStoreCode";
            this.lblStoreCode.Size = new System.Drawing.Size(308, 25);
            this.lblStoreCode.TabIndex = 23;
            // 
            // btnPrintCargoCode
            // 
            this.btnPrintCargoCode.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrintCargoCode.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrintCargoCode.Location = new System.Drawing.Point(404, 302);
            this.btnPrintCargoCode.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnPrintCargoCode.Name = "btnPrintCargoCode";
            this.btnPrintCargoCode.Size = new System.Drawing.Size(107, 28);
            this.btnPrintCargoCode.TabIndex = 24;
            this.btnPrintCargoCode.Text = "打印货物码";
            this.btnPrintCargoCode.Click += new System.EventHandler(this.btnPrintCargoCode_Click);
            // 
            // FrmStoreInHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 546);
            this.Controls.Add(this.btnPrintCargoCode);
            this.Controls.Add(this.lblStoreCode);
            this.Controls.Add(this.lblDetailTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grdStoreInDetail);
            this.Controls.Add(this.grdStoreIn);
            this.Controls.Add(this.panSearch);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmStoreInHistory";
            this.Text = "入库历史查询";
            this.Load += new System.EventHandler(this.FrmStoreInHistory_Load);
            this.panSearch.ResumeLayout(false);
            this.panSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datStoreInEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datStoreInStartDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panSearch;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxStoreInType;
        private DevComponents.Editors.ComboItem itmOrderIn;
        private DevComponents.Editors.ComboItem itmReturnStore;
        private DevComponents.DotNetBar.LabelX lblStoreInType;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.LabelX lblStoreOutCode;
        private DevComponents.DotNetBar.LabelX lblDealerName;
        private DevComponents.DotNetBar.LabelX lblStoreOutStartDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput datStoreInStartDate;
        private DevComponents.DotNetBar.Controls.TextBoxX txtStoreOutCode;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDealerName;
        private DevComponents.DotNetBar.LabelX lblStoreOutEndDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput datStoreInEndDate;
        private DevComponents.DotNetBar.LabelX lblDetailTitle;
        private DevComponents.DotNetBar.LabelX lblTitle;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grdStoreInDetail;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grdStoreIn;
        private DevComponents.DotNetBar.LabelX lblStoreCode;
        private DevComponents.DotNetBar.ButtonX btnPrintCargoCode;
    }
}