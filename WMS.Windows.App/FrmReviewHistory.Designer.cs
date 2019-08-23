namespace WMS.Windows.App
{
    partial class FrmReviewHistory
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
            this.panSearch = new DevComponents.DotNetBar.PanelEx();
            this.txtProductName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbxStoreOutType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.itmSaleOut = new DevComponents.Editors.ComboItem();
            this.itmReturnStore = new DevComponents.Editors.ComboItem();
            this.datReviewEndDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.datReviewStartDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtStoreOutReviewCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDealerName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lblStoreOutType = new DevComponents.DotNetBar.LabelX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.lblStoreOutReviewCode = new DevComponents.DotNetBar.LabelX();
            this.lblDealerName = new DevComponents.DotNetBar.LabelX();
            this.lblStoreOutEndDate = new DevComponents.DotNetBar.LabelX();
            this.lblReviewStartDate = new DevComponents.DotNetBar.LabelX();
            this.panStoreOut = new DevComponents.DotNetBar.ExpandablePanel();
            this.grdStoreOutDetail = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datReviewEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datReviewStartDate)).BeginInit();
            this.panStoreOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // panSearch
            // 
            this.panSearch.CanvasColor = System.Drawing.SystemColors.Control;
            this.panSearch.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panSearch.Controls.Add(this.txtProductName);
            this.panSearch.Controls.Add(this.cbxStoreOutType);
            this.panSearch.Controls.Add(this.datReviewEndDate);
            this.panSearch.Controls.Add(this.datReviewStartDate);
            this.panSearch.Controls.Add(this.txtStoreOutReviewCode);
            this.panSearch.Controls.Add(this.txtDealerName);
            this.panSearch.Controls.Add(this.labelX1);
            this.panSearch.Controls.Add(this.lblStoreOutType);
            this.panSearch.Controls.Add(this.btnSearch);
            this.panSearch.Controls.Add(this.lblStoreOutReviewCode);
            this.panSearch.Controls.Add(this.lblDealerName);
            this.panSearch.Controls.Add(this.lblStoreOutEndDate);
            this.panSearch.Controls.Add(this.lblReviewStartDate);
            this.panSearch.DisabledBackColor = System.Drawing.Color.Empty;
            this.panSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSearch.Location = new System.Drawing.Point(0, 0);
            this.panSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panSearch.Name = "panSearch";
            this.panSearch.Padding = new System.Windows.Forms.Padding(0, 46, 0, 0);
            this.panSearch.Size = new System.Drawing.Size(1153, 88);
            this.panSearch.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panSearch.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panSearch.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panSearch.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panSearch.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panSearch.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panSearch.Style.GradientAngle = 90;
            this.panSearch.TabIndex = 16;
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
            this.txtProductName.Location = new System.Drawing.Point(931, 15);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PreventEnterBeep = true;
            this.txtProductName.Size = new System.Drawing.Size(191, 27);
            this.txtProductName.TabIndex = 12;
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
            this.cbxStoreOutType.Location = new System.Drawing.Point(366, 14);
            this.cbxStoreOutType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxStoreOutType.Name = "cbxStoreOutType";
            this.cbxStoreOutType.Size = new System.Drawing.Size(191, 27);
            this.cbxStoreOutType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxStoreOutType.TabIndex = 10;
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
            // datReviewEndDate
            // 
            // 
            // 
            // 
            this.datReviewEndDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.datReviewEndDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datReviewEndDate.ButtonClear.Tooltip = "";
            this.datReviewEndDate.ButtonClear.Visible = true;
            this.datReviewEndDate.ButtonCustom.Tooltip = "";
            this.datReviewEndDate.ButtonCustom2.Tooltip = "";
            this.datReviewEndDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.datReviewEndDate.ButtonDropDown.Tooltip = "";
            this.datReviewEndDate.ButtonDropDown.Visible = true;
            this.datReviewEndDate.ButtonFreeText.Tooltip = "";
            this.datReviewEndDate.Format = DevComponents.Editors.eDateTimePickerFormat.Long;
            this.datReviewEndDate.IsPopupCalendarOpen = false;
            this.datReviewEndDate.Location = new System.Drawing.Point(366, 45);
            this.datReviewEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.datReviewEndDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.datReviewEndDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datReviewEndDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.datReviewEndDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.datReviewEndDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.datReviewEndDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.datReviewEndDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.datReviewEndDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.datReviewEndDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.datReviewEndDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datReviewEndDate.MonthCalendar.DisplayMonth = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.datReviewEndDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.datReviewEndDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.datReviewEndDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.datReviewEndDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.datReviewEndDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.datReviewEndDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datReviewEndDate.MonthCalendar.TodayButtonVisible = true;
            this.datReviewEndDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.datReviewEndDate.Name = "datReviewEndDate";
            this.datReviewEndDate.Size = new System.Drawing.Size(191, 27);
            this.datReviewEndDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.datReviewEndDate.TabIndex = 9;
            // 
            // datReviewStartDate
            // 
            // 
            // 
            // 
            this.datReviewStartDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.datReviewStartDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datReviewStartDate.ButtonClear.Tooltip = "";
            this.datReviewStartDate.ButtonClear.Visible = true;
            this.datReviewStartDate.ButtonCustom.Tooltip = "";
            this.datReviewStartDate.ButtonCustom2.Tooltip = "";
            this.datReviewStartDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.datReviewStartDate.ButtonDropDown.Tooltip = "";
            this.datReviewStartDate.ButtonDropDown.Visible = true;
            this.datReviewStartDate.ButtonFreeText.Tooltip = "";
            this.datReviewStartDate.Format = DevComponents.Editors.eDateTimePickerFormat.Long;
            this.datReviewStartDate.IsPopupCalendarOpen = false;
            this.datReviewStartDate.Location = new System.Drawing.Point(95, 45);
            this.datReviewStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.datReviewStartDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.datReviewStartDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datReviewStartDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.datReviewStartDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.datReviewStartDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.datReviewStartDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.datReviewStartDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.datReviewStartDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.datReviewStartDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.datReviewStartDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datReviewStartDate.MonthCalendar.DisplayMonth = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.datReviewStartDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.datReviewStartDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.datReviewStartDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.datReviewStartDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.datReviewStartDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.datReviewStartDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datReviewStartDate.MonthCalendar.TodayButtonVisible = true;
            this.datReviewStartDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.datReviewStartDate.Name = "datReviewStartDate";
            this.datReviewStartDate.Size = new System.Drawing.Size(191, 27);
            this.datReviewStartDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.datReviewStartDate.TabIndex = 9;
            // 
            // txtStoreOutReviewCode
            // 
            // 
            // 
            // 
            this.txtStoreOutReviewCode.Border.Class = "TextBoxBorder";
            this.txtStoreOutReviewCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStoreOutReviewCode.ButtonCustom.Tooltip = "";
            this.txtStoreOutReviewCode.ButtonCustom2.Tooltip = "";
            this.txtStoreOutReviewCode.Location = new System.Drawing.Point(95, 14);
            this.txtStoreOutReviewCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStoreOutReviewCode.Name = "txtStoreOutReviewCode";
            this.txtStoreOutReviewCode.PreventEnterBeep = true;
            this.txtStoreOutReviewCode.Size = new System.Drawing.Size(191, 27);
            this.txtStoreOutReviewCode.TabIndex = 6;
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
            this.txtDealerName.Location = new System.Drawing.Point(637, 14);
            this.txtDealerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.PreventEnterBeep = true;
            this.txtDealerName.Size = new System.Drawing.Size(191, 27);
            this.txtDealerName.TabIndex = 8;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(840, 17);
            this.labelX1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(77, 22);
            this.labelX1.TabIndex = 11;
            this.labelX1.Text = "药品名称：";
            // 
            // lblStoreOutType
            // 
            this.lblStoreOutType.AutoSize = true;
            // 
            // 
            // 
            this.lblStoreOutType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStoreOutType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStoreOutType.Location = new System.Drawing.Point(292, 14);
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
            this.btnSearch.Location = new System.Drawing.Point(637, 48);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 29);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "查询";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblStoreOutReviewCode
            // 
            this.lblStoreOutReviewCode.AutoSize = true;
            // 
            // 
            // 
            this.lblStoreOutReviewCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStoreOutReviewCode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStoreOutReviewCode.Location = new System.Drawing.Point(21, 14);
            this.lblStoreOutReviewCode.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblStoreOutReviewCode.Name = "lblStoreOutReviewCode";
            this.lblStoreOutReviewCode.Size = new System.Drawing.Size(77, 22);
            this.lblStoreOutReviewCode.TabIndex = 2;
            this.lblStoreOutReviewCode.Text = "复核单号：";
            // 
            // lblDealerName
            // 
            this.lblDealerName.AutoSize = true;
            // 
            // 
            // 
            this.lblDealerName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDealerName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDealerName.Location = new System.Drawing.Point(563, 14);
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
            this.lblStoreOutEndDate.Location = new System.Drawing.Point(292, 48);
            this.lblStoreOutEndDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblStoreOutEndDate.Name = "lblStoreOutEndDate";
            this.lblStoreOutEndDate.Size = new System.Drawing.Size(77, 22);
            this.lblStoreOutEndDate.TabIndex = 5;
            this.lblStoreOutEndDate.Text = "结束时间：";
            // 
            // lblReviewStartDate
            // 
            this.lblReviewStartDate.AutoSize = true;
            // 
            // 
            // 
            this.lblReviewStartDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblReviewStartDate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblReviewStartDate.Location = new System.Drawing.Point(21, 48);
            this.lblReviewStartDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblReviewStartDate.Name = "lblReviewStartDate";
            this.lblReviewStartDate.Size = new System.Drawing.Size(77, 22);
            this.lblReviewStartDate.TabIndex = 5;
            this.lblReviewStartDate.Text = "开始时间：";
            // 
            // panStoreOut
            // 
            this.panStoreOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panStoreOut.CanvasColor = System.Drawing.SystemColors.Control;
            this.panStoreOut.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panStoreOut.Controls.Add(this.grdStoreOutDetail);
            this.panStoreOut.DisabledBackColor = System.Drawing.Color.Empty;
            this.panStoreOut.ExpandButtonVisible = false;
            this.panStoreOut.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panStoreOut.HideControlsWhenCollapsed = true;
            this.panStoreOut.Location = new System.Drawing.Point(0, 85);
            this.panStoreOut.Name = "panStoreOut";
            this.panStoreOut.Size = new System.Drawing.Size(1153, 438);
            this.panStoreOut.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panStoreOut.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panStoreOut.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panStoreOut.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panStoreOut.Style.GradientAngle = 90;
            this.panStoreOut.TabIndex = 23;
            this.panStoreOut.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panStoreOut.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panStoreOut.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panStoreOut.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panStoreOut.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panStoreOut.TitleStyle.GradientAngle = 90;
            this.panStoreOut.TitleText = "出库复核单列表";
            // 
            // grdStoreOutDetail
            // 
            this.grdStoreOutDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdStoreOutDetail.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grdStoreOutDetail.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grdStoreOutDetail.Location = new System.Drawing.Point(0, 26);
            this.grdStoreOutDetail.Name = "grdStoreOutDetail";
            this.grdStoreOutDetail.PrimaryGrid.AllowEdit = false;
            this.grdStoreOutDetail.PrimaryGrid.AutoGenerateColumns = false;
            this.grdStoreOutDetail.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn1.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn1.DataPropertyName = "ReviewID";
            gridColumn1.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn1.HeaderText = "序号";
            gridColumn1.Name = "colReviewID";
            gridColumn1.Visible = false;
            gridColumn2.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            gridColumn2.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            gridColumn2.DataPropertyName = "PrintTimes";
            gridColumn2.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn2.FillWeight = 50;
            gridColumn2.HeaderText = "打印次数";
            gridColumn2.Name = "colPrintTimes";
            gridColumn2.NullString = "0";
            gridColumn2.Width = 50;
            gridColumn3.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            gridColumn3.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn3.DataPropertyName = "ReviewCode";
            gridColumn3.HeaderText = "复核单号";
            gridColumn3.Name = "colReviewCode";
            gridColumn4.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            gridColumn4.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn4.DataPropertyName = "StoreOutCode";
            gridColumn4.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn4.HeaderText = "出库单号";
            gridColumn4.Name = "colStoreOutCode";
            gridColumn4.Width = 200;
            gridColumn5.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            gridColumn5.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn5.DataPropertyName = "SaleBillCode";
            gridColumn5.HeaderText = "销售订单号";
            gridColumn5.Name = "colSaleBillCode";
            gridColumn6.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn6.DataPropertyName = "DealerName";
            gridColumn6.HeaderText = "客户名称";
            gridColumn6.Name = "colProviderName";
            gridColumn6.Width = 150;
            gridColumn7.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            gridColumn7.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridColumn7.DataPropertyName = "StoreTypeName";
            gridColumn7.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn7.HeaderText = "出库类型";
            gridColumn7.Name = "colStoreType";
            gridColumn7.Width = 150;
            gridColumn8.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            gridColumn8.DataPropertyName = "ReviewPerson";
            gridColumn8.HeaderText = "复核员";
            gridColumn8.Name = "colReviewPerson";
            gridColumn9.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            gridColumn9.DataPropertyName = "ReviewDate";
            gridColumn9.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl);
            gridColumn9.HeaderText = "复核日期";
            gridColumn9.Name = "colReviewDate";
            gridColumn9.ReadOnly = true;
            gridColumn10.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn10.DataPropertyName = "StatusName";
            gridColumn10.HeaderText = "状态";
            gridColumn10.Name = "colStatus";
            gridColumn10.Width = 150;
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
            this.grdStoreOutDetail.PrimaryGrid.NoRowsText = "暂无记录";
            this.grdStoreOutDetail.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grdStoreOutDetail.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.grdStoreOutDetail.PrimaryGrid.ShowRowGridIndex = true;
            this.grdStoreOutDetail.PrimaryGrid.UseAlternateRowStyle = true;
            this.grdStoreOutDetail.Size = new System.Drawing.Size(1153, 412);
            this.grdStoreOutDetail.TabIndex = 0;
            this.grdStoreOutDetail.Text = "superGridControl2";
            this.grdStoreOutDetail.RowDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs>(this.grdStoreOutDetail_RowDoubleClick);
            // 
            // FrmReviewHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 522);
            this.Controls.Add(this.panStoreOut);
            this.Controls.Add(this.panSearch);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmReviewHistory";
            this.Text = "复核历史查询";
            this.Load += new System.EventHandler(this.FrmReviewHistory_Load);
            this.panSearch.ResumeLayout(false);
            this.panSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datReviewEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datReviewStartDate)).EndInit();
            this.panStoreOut.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panSearch;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxStoreOutType;
        private DevComponents.Editors.ComboItem itmSaleOut;
        private DevComponents.Editors.ComboItem itmReturnStore;
        private DevComponents.DotNetBar.LabelX lblStoreOutType;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.LabelX lblStoreOutReviewCode;
        private DevComponents.DotNetBar.LabelX lblDealerName;
        private DevComponents.DotNetBar.LabelX lblStoreOutEndDate;
        private DevComponents.DotNetBar.LabelX lblReviewStartDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput datReviewEndDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput datReviewStartDate;
        private DevComponents.DotNetBar.Controls.TextBoxX txtStoreOutReviewCode;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDealerName;
        private DevComponents.DotNetBar.ExpandablePanel panStoreOut;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grdStoreOutDetail;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProductName;
    }
}