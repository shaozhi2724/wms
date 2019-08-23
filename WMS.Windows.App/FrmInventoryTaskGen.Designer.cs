namespace WMS.Windows.App
{
    partial class FrmInventoryTaskGen
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
            this.btnGenerate = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.datEndDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.datStartDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtInventoryStatisticCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblInventoryCode = new DevComponents.DotNetBar.LabelX();
            this.lblStoreOutEndDate = new DevComponents.DotNetBar.LabelX();
            this.lblStoreOutStartDate = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.datEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datStartDate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGenerate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGenerate.Location = new System.Drawing.Point(58, 224);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(168, 37);
            this.btnGenerate.TabIndex = 24;
            this.btnGenerate.Text = "生成库存盘点任务";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(282, 224);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 37);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "取消";
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
            this.datEndDate.Location = new System.Drawing.Point(149, 148);
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
            this.datEndDate.Size = new System.Drawing.Size(252, 27);
            this.datEndDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.datEndDate.TabIndex = 30;
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
            this.datStartDate.Location = new System.Drawing.Point(149, 98);
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
            this.datStartDate.Size = new System.Drawing.Size(252, 27);
            this.datStartDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.datStartDate.TabIndex = 31;
            // 
            // txtInventoryStatisticCode
            // 
            // 
            // 
            // 
            this.txtInventoryStatisticCode.Border.Class = "TextBoxBorder";
            this.txtInventoryStatisticCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInventoryStatisticCode.Location = new System.Drawing.Point(149, 33);
            this.txtInventoryStatisticCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInventoryStatisticCode.Name = "txtInventoryStatisticCode";
            this.txtInventoryStatisticCode.PreventEnterBeep = true;
            this.txtInventoryStatisticCode.Size = new System.Drawing.Size(252, 27);
            this.txtInventoryStatisticCode.TabIndex = 29;
            // 
            // lblInventoryCode
            // 
            this.lblInventoryCode.AutoSize = true;
            // 
            // 
            // 
            this.lblInventoryCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblInventoryCode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInventoryCode.Location = new System.Drawing.Point(58, 33);
            this.lblInventoryCode.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblInventoryCode.Name = "lblInventoryCode";
            this.lblInventoryCode.Size = new System.Drawing.Size(85, 24);
            this.lblInventoryCode.TabIndex = 26;
            this.lblInventoryCode.Text = "入库单号：";
            // 
            // lblStoreOutEndDate
            // 
            this.lblStoreOutEndDate.AutoSize = true;
            // 
            // 
            // 
            this.lblStoreOutEndDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStoreOutEndDate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStoreOutEndDate.Location = new System.Drawing.Point(58, 148);
            this.lblStoreOutEndDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblStoreOutEndDate.Name = "lblStoreOutEndDate";
            this.lblStoreOutEndDate.Size = new System.Drawing.Size(85, 24);
            this.lblStoreOutEndDate.TabIndex = 27;
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
            this.lblStoreOutStartDate.Location = new System.Drawing.Point(58, 98);
            this.lblStoreOutStartDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblStoreOutStartDate.Name = "lblStoreOutStartDate";
            this.lblStoreOutStartDate.Size = new System.Drawing.Size(85, 24);
            this.lblStoreOutStartDate.TabIndex = 28;
            this.lblStoreOutStartDate.Text = "开始时间：";
            // 
            // FrmInventoryTaskGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 298);
            this.ControlBox = false;
            this.Controls.Add(this.datEndDate);
            this.Controls.Add(this.datStartDate);
            this.Controls.Add(this.txtInventoryStatisticCode);
            this.Controls.Add(this.lblInventoryCode);
            this.Controls.Add(this.lblStoreOutEndDate);
            this.Controls.Add(this.lblStoreOutStartDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGenerate);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmInventoryTaskGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "生成库存盘点任务";
            this.Load += new System.EventHandler(this.FrmInventoryState_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datStartDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnGenerate;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput datEndDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput datStartDate;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInventoryStatisticCode;
        private DevComponents.DotNetBar.LabelX lblInventoryCode;
        private DevComponents.DotNetBar.LabelX lblStoreOutEndDate;
        private DevComponents.DotNetBar.LabelX lblStoreOutStartDate;
    }
}