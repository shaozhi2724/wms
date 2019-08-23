namespace WMS.Windows.App
{
    partial class FrmBatchNoChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBatchNoChange));
            this.txtOldBatchNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblServerName = new DevComponents.DotNetBar.LabelX();
            this.lblDatabaseName = new DevComponents.DotNetBar.LabelX();
            this.txtNewBatchNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.customValidator1 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.customValidator2 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.errorProvider = new System.Windows.Forms.ErrorProvider();
            this.superValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.datProductionDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.datValidDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtOldStoreAmount = new DevComponents.Editors.IntegerInput();
            this.txtNewStoreAmount = new DevComponents.Editors.IntegerInput();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datProductionDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datValidDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldStoreAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewStoreAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOldBatchNo
            // 
            // 
            // 
            // 
            this.txtOldBatchNo.Border.Class = "TextBoxBorder";
            this.txtOldBatchNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter.SetHighlightOnFocus(this.txtOldBatchNo, true);
            this.txtOldBatchNo.Location = new System.Drawing.Point(133, 21);
            this.txtOldBatchNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOldBatchNo.Name = "txtOldBatchNo";
            this.txtOldBatchNo.PreventEnterBeep = true;
            this.txtOldBatchNo.ReadOnly = true;
            this.txtOldBatchNo.Size = new System.Drawing.Size(232, 27);
            this.txtOldBatchNo.TabIndex = 0;
            // 
            // lblServerName
            // 
            // 
            // 
            // 
            this.lblServerName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblServerName.Location = new System.Drawing.Point(12, 17);
            this.lblServerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(100, 30);
            this.lblServerName.TabIndex = 1;
            this.lblServerName.Text = "原批号：";
            this.lblServerName.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblDatabaseName
            // 
            // 
            // 
            // 
            this.lblDatabaseName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDatabaseName.Location = new System.Drawing.Point(12, 64);
            this.lblDatabaseName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.Size = new System.Drawing.Size(100, 30);
            this.lblDatabaseName.TabIndex = 3;
            this.lblDatabaseName.Text = "新批号：";
            this.lblDatabaseName.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtNewBatchNo
            // 
            // 
            // 
            // 
            this.txtNewBatchNo.Border.Class = "TextBoxBorder";
            this.txtNewBatchNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter.SetHighlightOnFocus(this.txtNewBatchNo, true);
            this.txtNewBatchNo.Location = new System.Drawing.Point(133, 68);
            this.txtNewBatchNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewBatchNo.Name = "txtNewBatchNo";
            this.txtNewBatchNo.PreventEnterBeep = true;
            this.txtNewBatchNo.Size = new System.Drawing.Size(232, 27);
            this.txtNewBatchNo.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(120, 299);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(225, 299);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            // 
            // customValidator1
            // 
            this.customValidator1.ErrorMessage = "Your error message here.";
            this.customValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // customValidator2
            // 
            this.customValidator2.ErrorMessage = "Your error message here.";
            this.customValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // superValidator
            // 
            this.superValidator.ContainerControl = this;
            this.superValidator.ErrorProvider = this.errorProvider;
            this.superValidator.Highlighter = this.highlighter;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 108);
            this.labelX1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(100, 30);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "生产日期：";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 156);
            this.labelX2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(100, 30);
            this.labelX2.TabIndex = 9;
            this.labelX2.Text = "有效期至：";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // datProductionDate
            // 
            // 
            // 
            // 
            this.datProductionDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.datProductionDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datProductionDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.datProductionDate.ButtonDropDown.Visible = true;
            this.datProductionDate.IsPopupCalendarOpen = false;
            this.datProductionDate.Location = new System.Drawing.Point(133, 111);
            // 
            // 
            // 
            this.datProductionDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.datProductionDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datProductionDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.datProductionDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.datProductionDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.datProductionDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.datProductionDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.datProductionDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.datProductionDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.datProductionDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.datProductionDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datProductionDate.MonthCalendar.DisplayMonth = new System.DateTime(2014, 4, 1, 0, 0, 0, 0);
            this.datProductionDate.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.datProductionDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.datProductionDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.datProductionDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.datProductionDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.datProductionDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.datProductionDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datProductionDate.MonthCalendar.TodayButtonVisible = true;
            this.datProductionDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.datProductionDate.Name = "datProductionDate";
            this.datProductionDate.Size = new System.Drawing.Size(232, 27);
            this.datProductionDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.datProductionDate.TabIndex = 2;
            // 
            // datValidDate
            // 
            // 
            // 
            // 
            this.datValidDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.datValidDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datValidDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.datValidDate.ButtonDropDown.Visible = true;
            this.datValidDate.IsPopupCalendarOpen = false;
            this.datValidDate.Location = new System.Drawing.Point(133, 156);
            // 
            // 
            // 
            this.datValidDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.datValidDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datValidDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.datValidDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.datValidDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.datValidDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.datValidDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.datValidDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.datValidDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.datValidDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.datValidDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datValidDate.MonthCalendar.DisplayMonth = new System.DateTime(2014, 4, 1, 0, 0, 0, 0);
            this.datValidDate.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.datValidDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.datValidDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.datValidDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.datValidDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.datValidDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.datValidDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datValidDate.MonthCalendar.TodayButtonVisible = true;
            this.datValidDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.datValidDate.Name = "datValidDate";
            this.datValidDate.Size = new System.Drawing.Size(232, 27);
            this.datValidDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.datValidDate.TabIndex = 3;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(12, 241);
            this.labelX3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(100, 30);
            this.labelX3.TabIndex = 13;
            this.labelX3.Text = "新库存：";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(12, 194);
            this.labelX4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(100, 30);
            this.labelX4.TabIndex = 12;
            this.labelX4.Text = "原库存：";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtOldStoreAmount
            // 
            // 
            // 
            // 
            this.txtOldStoreAmount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtOldStoreAmount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOldStoreAmount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtOldStoreAmount.Enabled = false;
            this.txtOldStoreAmount.Location = new System.Drawing.Point(133, 197);
            this.txtOldStoreAmount.MinValue = 0;
            this.txtOldStoreAmount.Name = "txtOldStoreAmount";
            this.txtOldStoreAmount.Size = new System.Drawing.Size(232, 27);
            this.txtOldStoreAmount.TabIndex = 4;
            // 
            // txtNewStoreAmount
            // 
            // 
            // 
            // 
            this.txtNewStoreAmount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtNewStoreAmount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNewStoreAmount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtNewStoreAmount.Location = new System.Drawing.Point(133, 241);
            this.txtNewStoreAmount.MinValue = 0;
            this.txtNewStoreAmount.Name = "txtNewStoreAmount";
            this.txtNewStoreAmount.ShowUpDown = true;
            this.txtNewStoreAmount.Size = new System.Drawing.Size(232, 27);
            this.txtNewStoreAmount.TabIndex = 5;
            // 
            // FrmBatchNoChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 357);
            this.Controls.Add(this.txtNewStoreAmount);
            this.Controls.Add(this.txtOldStoreAmount);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.datValidDate);
            this.Controls.Add(this.datProductionDate);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblDatabaseName);
            this.Controls.Add(this.txtNewBatchNo);
            this.Controls.Add(this.lblServerName);
            this.Controls.Add(this.txtOldBatchNo);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBatchNoChange";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "库存管理";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datProductionDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datValidDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldStoreAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewStoreAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtOldBatchNo;
        private DevComponents.DotNetBar.LabelX lblServerName;
        private DevComponents.DotNetBar.LabelX lblDatabaseName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNewBatchNo;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator2;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput datValidDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput datProductionDate;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.IntegerInput txtNewStoreAmount;
        private DevComponents.Editors.IntegerInput txtOldStoreAmount;
    }
}