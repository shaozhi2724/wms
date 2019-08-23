namespace WMS.Windows.App
{
    partial class FrmStoreOutHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStoreOutHistory));
            this.panSearch = new DevComponents.DotNetBar.PanelEx();
            this.cbxStoreOutType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.itmSaleOut = new DevComponents.Editors.ComboItem();
            this.itmReturnStore = new DevComponents.Editors.ComboItem();
            this.datStoreOutEndDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.datStoreOutStartDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtStoreOutCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDealerName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblStoreOutType = new DevComponents.DotNetBar.LabelX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.lblStoreOutCode = new DevComponents.DotNetBar.LabelX();
            this.lblDealerName = new DevComponents.DotNetBar.LabelX();
            this.lblStoreOutEndDate = new DevComponents.DotNetBar.LabelX();
            this.lblStoreOutStartDate = new DevComponents.DotNetBar.LabelX();
            this.lblDetailTitle = new DevComponents.DotNetBar.LabelX();
            this.lblTitle = new DevComponents.DotNetBar.LabelX();
            this.grdStoreOutDetail = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.grdStoreOut = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.lblStoreCode = new DevComponents.DotNetBar.LabelX();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnRefresh = new DevComponents.DotNetBar.ButtonItem();
            this.btnGen = new DevComponents.DotNetBar.ButtonItem();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datStoreOutEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datStoreOutStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panSearch
            // 
            this.panSearch.CanvasColor = System.Drawing.SystemColors.Control;
            this.panSearch.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panSearch.Controls.Add(this.cbxStoreOutType);
            this.panSearch.Controls.Add(this.datStoreOutEndDate);
            this.panSearch.Controls.Add(this.datStoreOutStartDate);
            this.panSearch.Controls.Add(this.txtStoreOutCode);
            this.panSearch.Controls.Add(this.txtDealerName);
            this.panSearch.Controls.Add(this.lblStoreOutType);
            this.panSearch.Controls.Add(this.btnSearch);
            this.panSearch.Controls.Add(this.lblStoreOutCode);
            this.panSearch.Controls.Add(this.lblDealerName);
            this.panSearch.Controls.Add(this.lblStoreOutEndDate);
            this.panSearch.Controls.Add(this.lblStoreOutStartDate);
            this.panSearch.DisabledBackColor = System.Drawing.Color.Empty;
            this.panSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSearch.Location = new System.Drawing.Point(0, 61);
            this.panSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panSearch.Name = "panSearch";
            this.panSearch.Padding = new System.Windows.Forms.Padding(0, 46, 0, 0);
            this.panSearch.Size = new System.Drawing.Size(1046, 78);
            this.panSearch.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panSearch.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panSearch.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panSearch.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panSearch.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panSearch.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panSearch.Style.GradientAngle = 90;
            this.panSearch.TabIndex = 15;
            // 
            // cbxStoreOutType
            // 
            this.cbxStoreOutType.DisplayMember = "Text";
            this.cbxStoreOutType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxStoreOutType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStoreOutType.FormattingEnabled = true;
            this.cbxStoreOutType.ItemHeight = 21;
            this.cbxStoreOutType.Items.AddRange(new object[] {
            this.itmSaleOut,
            this.itmReturnStore});
            this.cbxStoreOutType.Location = new System.Drawing.Point(393, 14);
            this.cbxStoreOutType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxStoreOutType.Name = "cbxStoreOutType";
            this.cbxStoreOutType.Size = new System.Drawing.Size(191, 27);
            this.cbxStoreOutType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxStoreOutType.TabIndex = 1;
            this.cbxStoreOutType.WatermarkText = "请选择";
            // 
            // itmSaleOut
            // 
            this.itmSaleOut.Text = "销售出库";
            this.itmSaleOut.Value = "1";
            // 
            // itmReturnStore
            // 
            this.itmReturnStore.Text = "采购退回出库";
            this.itmReturnStore.Value = "2";
            // 
            // datStoreOutEndDate
            // 
            // 
            // 
            // 
            this.datStoreOutEndDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.datStoreOutEndDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datStoreOutEndDate.ButtonClear.Tooltip = "";
            this.datStoreOutEndDate.ButtonClear.Visible = true;
            this.datStoreOutEndDate.ButtonCustom.Tooltip = "";
            this.datStoreOutEndDate.ButtonCustom2.Tooltip = "";
            this.datStoreOutEndDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.datStoreOutEndDate.ButtonDropDown.Tooltip = "";
            this.datStoreOutEndDate.ButtonDropDown.Visible = true;
            this.datStoreOutEndDate.ButtonFreeText.Tooltip = "";
            this.datStoreOutEndDate.Format = DevComponents.Editors.eDateTimePickerFormat.Long;
            this.datStoreOutEndDate.IsPopupCalendarOpen = false;
            this.datStoreOutEndDate.Location = new System.Drawing.Point(393, 47);
            this.datStoreOutEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.datStoreOutEndDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.datStoreOutEndDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datStoreOutEndDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.datStoreOutEndDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.datStoreOutEndDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.datStoreOutEndDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.datStoreOutEndDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.datStoreOutEndDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.datStoreOutEndDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.datStoreOutEndDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datStoreOutEndDate.MonthCalendar.DisplayMonth = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.datStoreOutEndDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.datStoreOutEndDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.datStoreOutEndDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.datStoreOutEndDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.datStoreOutEndDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.datStoreOutEndDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datStoreOutEndDate.MonthCalendar.TodayButtonVisible = true;
            this.datStoreOutEndDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.datStoreOutEndDate.Name = "datStoreOutEndDate";
            this.datStoreOutEndDate.Size = new System.Drawing.Size(191, 27);
            this.datStoreOutEndDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.datStoreOutEndDate.TabIndex = 4;
            // 
            // datStoreOutStartDate
            // 
            // 
            // 
            // 
            this.datStoreOutStartDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.datStoreOutStartDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datStoreOutStartDate.ButtonClear.Tooltip = "";
            this.datStoreOutStartDate.ButtonClear.Visible = true;
            this.datStoreOutStartDate.ButtonCustom.Tooltip = "";
            this.datStoreOutStartDate.ButtonCustom2.Tooltip = "";
            this.datStoreOutStartDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.datStoreOutStartDate.ButtonDropDown.Tooltip = "";
            this.datStoreOutStartDate.ButtonDropDown.Visible = true;
            this.datStoreOutStartDate.ButtonFreeText.Tooltip = "";
            this.datStoreOutStartDate.Format = DevComponents.Editors.eDateTimePickerFormat.Long;
            this.datStoreOutStartDate.IsPopupCalendarOpen = false;
            this.datStoreOutStartDate.Location = new System.Drawing.Point(95, 47);
            this.datStoreOutStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.datStoreOutStartDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.datStoreOutStartDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datStoreOutStartDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.datStoreOutStartDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.datStoreOutStartDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.datStoreOutStartDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.datStoreOutStartDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.datStoreOutStartDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.datStoreOutStartDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.datStoreOutStartDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datStoreOutStartDate.MonthCalendar.DisplayMonth = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.datStoreOutStartDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.datStoreOutStartDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.datStoreOutStartDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.datStoreOutStartDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.datStoreOutStartDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.datStoreOutStartDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datStoreOutStartDate.MonthCalendar.TodayButtonVisible = true;
            this.datStoreOutStartDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.datStoreOutStartDate.Name = "datStoreOutStartDate";
            this.datStoreOutStartDate.Size = new System.Drawing.Size(191, 27);
            this.datStoreOutStartDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.datStoreOutStartDate.TabIndex = 3;
            // 
            // txtStoreOutCode
            // 
            // 
            // 
            // 
            this.txtStoreOutCode.Border.Class = "TextBoxBorder";
            this.txtStoreOutCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStoreOutCode.ButtonCustom.Tooltip = "";
            this.txtStoreOutCode.ButtonCustom2.Tooltip = "";
            this.txtStoreOutCode.Location = new System.Drawing.Point(95, 14);
            this.txtStoreOutCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStoreOutCode.Name = "txtStoreOutCode";
            this.txtStoreOutCode.PreventEnterBeep = true;
            this.txtStoreOutCode.Size = new System.Drawing.Size(191, 27);
            this.txtStoreOutCode.TabIndex = 0;
            // 
            // txtDealerName
            // 
            // 
            // 
            // 
            this.txtDealerName.Border.Class = "TextBoxBorder";
            this.txtDealerName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDealerName.ButtonCustom.Tooltip = "";
            this.txtDealerName.ButtonCustom2.Tooltip = "";
            this.txtDealerName.Location = new System.Drawing.Point(683, 14);
            this.txtDealerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.PreventEnterBeep = true;
            this.txtDealerName.Size = new System.Drawing.Size(191, 27);
            this.txtDealerName.TabIndex = 2;
            // 
            // lblStoreOutType
            // 
            this.lblStoreOutType.AutoSize = true;
            // 
            // 
            // 
            this.lblStoreOutType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStoreOutType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStoreOutType.Location = new System.Drawing.Point(307, 14);
            this.lblStoreOutType.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblStoreOutType.Name = "lblStoreOutType";
            this.lblStoreOutType.Size = new System.Drawing.Size(77, 22);
            this.lblStoreOutType.TabIndex = 3;
            this.lblStoreOutType.Text = "出库类型：";
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.AutoSize = true;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Location = new System.Drawing.Point(903, 12);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 29);
            this.btnSearch.TabIndex = 5;
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
            this.lblStoreOutCode.Location = new System.Drawing.Point(12, 17);
            this.lblStoreOutCode.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblStoreOutCode.Name = "lblStoreOutCode";
            this.lblStoreOutCode.Size = new System.Drawing.Size(77, 22);
            this.lblStoreOutCode.TabIndex = 2;
            this.lblStoreOutCode.Text = "出库单号：";
            // 
            // lblDealerName
            // 
            this.lblDealerName.AutoSize = true;
            // 
            // 
            // 
            this.lblDealerName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDealerName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDealerName.Location = new System.Drawing.Point(602, 17);
            this.lblDealerName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblDealerName.Name = "lblDealerName";
            this.lblDealerName.Size = new System.Drawing.Size(77, 22);
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
            this.lblStoreOutEndDate.Location = new System.Drawing.Point(307, 50);
            this.lblStoreOutEndDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblStoreOutEndDate.Name = "lblStoreOutEndDate";
            this.lblStoreOutEndDate.Size = new System.Drawing.Size(77, 22);
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
            this.lblStoreOutStartDate.Location = new System.Drawing.Point(12, 49);
            this.lblStoreOutStartDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblStoreOutStartDate.Name = "lblStoreOutStartDate";
            this.lblStoreOutStartDate.Size = new System.Drawing.Size(77, 22);
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
            this.lblDetailTitle.Location = new System.Drawing.Point(-5, 387);
            this.lblDetailTitle.Name = "lblDetailTitle";
            this.lblDetailTitle.Size = new System.Drawing.Size(138, 23);
            this.lblDetailTitle.TabIndex = 19;
            this.lblDetailTitle.Text = "出库单明细：";
            // 
            // lblTitle
            // 
            // 
            // 
            // 
            this.lblTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(0, 166);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(106, 23);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "出库单：";
            // 
            // grdStoreOutDetail
            // 
            this.grdStoreOutDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdStoreOutDetail.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grdStoreOutDetail.Location = new System.Drawing.Point(0, 430);
            this.grdStoreOutDetail.Name = "grdStoreOutDetail";
            this.grdStoreOutDetail.PrimaryGrid.AllowEdit = false;
            this.grdStoreOutDetail.PrimaryGrid.AutoGenerateColumns = false;
            this.grdStoreOutDetail.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn1.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
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
            gridColumn3.DataPropertyName = "BatchNo";
            gridColumn3.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn3.HeaderText = "批号";
            gridColumn3.Name = "colBatchNo";
            gridColumn4.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn4.DataPropertyName = "ProductSpec";
            gridColumn4.HeaderText = "制剂规格";
            gridColumn4.Name = "colProductSpec";
            gridColumn5.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn5.DataPropertyName = "PackageSpec";
            gridColumn5.HeaderText = "包装规格";
            gridColumn5.Name = "colPackageSpec";
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
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn1);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn2);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn3);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn4);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn5);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn6);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn7);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn8);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn9);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn10);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn11);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn12);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn13);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn14);
            this.grdStoreOutDetail.PrimaryGrid.MultiSelect = false;
            this.grdStoreOutDetail.PrimaryGrid.NoRowsText = "暂无记录";
            this.grdStoreOutDetail.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grdStoreOutDetail.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.grdStoreOutDetail.PrimaryGrid.ShowRowGridIndex = true;
            this.grdStoreOutDetail.Size = new System.Drawing.Size(1046, 204);
            this.grdStoreOutDetail.TabIndex = 17;
            this.grdStoreOutDetail.Text = "superGridControl2";
            // 
            // grdStoreOut
            // 
            this.grdStoreOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdStoreOut.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grdStoreOut.Location = new System.Drawing.Point(-5, 195);
            this.grdStoreOut.Name = "grdStoreOut";
            this.grdStoreOut.PrimaryGrid.AllowEdit = false;
            this.grdStoreOut.PrimaryGrid.AutoGenerateColumns = false;
            this.grdStoreOut.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn15.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            gridColumn15.DataPropertyName = "StoreID";
            gridColumn15.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn15.HeaderText = "序号";
            gridColumn15.Name = "colStoreID";
            gridColumn15.Visible = false;
            gridColumn16.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn16.DataPropertyName = "StoreCode";
            gridColumn16.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn16.HeaderText = "出库单编号";
            gridColumn16.Name = "colStoreCode";
            gridColumn17.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn17.DataPropertyName = "StoreTypeName";
            gridColumn17.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn17.HeaderText = "出库类型";
            gridColumn17.Name = "colStoreTypeName";
            gridColumn18.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn18.DataPropertyName = "DealerName";
            gridColumn18.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn18.HeaderText = "往来单位";
            gridColumn18.Name = "colDealerName";
            gridColumn19.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn19.DataPropertyName = "StoreDate";
            gridColumn19.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl);
            gridColumn19.HeaderText = "出库时间";
            gridColumn19.Name = "colStoreBillDate";
            gridColumn20.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn20.DataPropertyName = "StoreStatusName";
            gridColumn20.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn20.HeaderText = "出库状态";
            gridColumn20.Name = "colStoreBillStatus";
            gridColumn21.AllowEdit = false;
            gridColumn21.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn21.DataPropertyName = "Reservation10";
            gridColumn21.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn21.HeaderText = "电子监管网文件";
            gridColumn21.Name = "colExportStatus";
            gridColumn22.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn22.DataPropertyName = "StoreRemark";
            gridColumn22.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn22.HeaderText = "说明";
            gridColumn22.Name = "colStoreRemark";
            this.grdStoreOut.PrimaryGrid.Columns.Add(gridColumn15);
            this.grdStoreOut.PrimaryGrid.Columns.Add(gridColumn16);
            this.grdStoreOut.PrimaryGrid.Columns.Add(gridColumn17);
            this.grdStoreOut.PrimaryGrid.Columns.Add(gridColumn18);
            this.grdStoreOut.PrimaryGrid.Columns.Add(gridColumn19);
            this.grdStoreOut.PrimaryGrid.Columns.Add(gridColumn20);
            this.grdStoreOut.PrimaryGrid.Columns.Add(gridColumn21);
            this.grdStoreOut.PrimaryGrid.Columns.Add(gridColumn22);
            this.grdStoreOut.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row;
            this.grdStoreOut.PrimaryGrid.NoRowsText = "暂无记录";
            this.grdStoreOut.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grdStoreOut.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.grdStoreOut.PrimaryGrid.ShowRowGridIndex = true;
            this.grdStoreOut.PrimaryGrid.UseAlternateRowStyle = true;
            this.grdStoreOut.Size = new System.Drawing.Size(1046, 186);
            this.grdStoreOut.TabIndex = 16;
            this.grdStoreOut.Text = "superGridControl1";
            this.grdStoreOut.GetRowCellStyle += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridGetRowCellStyleEventArgs>(this.grdStoreOut_GetRowCellStyle);
            this.grdStoreOut.RowActivated += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowActivatedEventArgs>(this.grdStoreOut_RowActivated);
            // 
            // lblStoreCode
            // 
            // 
            // 
            // 
            this.lblStoreCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStoreCode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStoreCode.Location = new System.Drawing.Point(131, 387);
            this.lblStoreCode.Name = "lblStoreCode";
            this.lblStoreCode.Size = new System.Drawing.Size(261, 23);
            this.lblStoreCode.TabIndex = 22;
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
            this.btnGen});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(1046, 61);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.bar1.TabIndex = 23;
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
            this.btnRefresh.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnRefresh.ImageIndex = 0;
            this.btnRefresh.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PopupType = DevComponents.DotNetBar.ePopupType.ToolBar;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnGen
            // 
            this.btnGen.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnGen.ImageIndex = 2;
            this.btnGen.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnGen.Name = "btnGen";
            this.btnGen.PopupType = DevComponents.DotNetBar.ePopupType.ToolBar;
            this.btnGen.Text = "导出监管网文件";
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // FrmStoreOutHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 632);
            this.Controls.Add(this.panSearch);
            this.Controls.Add(this.lblStoreCode);
            this.Controls.Add(this.lblDetailTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grdStoreOutDetail);
            this.Controls.Add(this.grdStoreOut);
            this.Controls.Add(this.bar1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmStoreOutHistory";
            this.Text = "出库历史查询";
            this.Load += new System.EventHandler(this.FrmStoreOutHistory_Load);
            this.panSearch.ResumeLayout(false);
            this.panSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datStoreOutEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datStoreOutStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panSearch;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxStoreOutType;
        private DevComponents.Editors.ComboItem itmSaleOut;
        private DevComponents.Editors.ComboItem itmReturnStore;
        private DevComponents.DotNetBar.LabelX lblStoreOutType;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.LabelX lblStoreOutCode;
        private DevComponents.DotNetBar.LabelX lblDealerName;
        private DevComponents.DotNetBar.LabelX lblStoreOutStartDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput datStoreOutStartDate;
        private DevComponents.DotNetBar.Controls.TextBoxX txtStoreOutCode;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDealerName;
        private DevComponents.DotNetBar.LabelX lblStoreOutEndDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput datStoreOutEndDate;
        private DevComponents.DotNetBar.LabelX lblDetailTitle;
        private DevComponents.DotNetBar.LabelX lblTitle;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grdStoreOutDetail;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grdStoreOut;
        private DevComponents.DotNetBar.LabelX lblStoreCode;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnRefresh;
        private DevComponents.DotNetBar.ButtonItem btnGen;
        private System.Windows.Forms.ImageList imageList;
    }
}