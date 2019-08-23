namespace WMS.Windows.App
{
    partial class FrmSystemConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSystemConfig));
            this.lblAutomaticOutStore = new DevComponents.DotNetBar.LabelX();
            this.lblAutomaticOutStoreInterval = new DevComponents.DotNetBar.LabelX();
            this.lblSystemSignStoreInPosition = new DevComponents.DotNetBar.LabelX();
            this.txtRemoteManifest = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblAllowNoCodeReview = new DevComponents.DotNetBar.LabelX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.superValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.swbAutomaticOutStore = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.txtAutomaticOutStoreInterval = new DevComponents.Editors.IntegerInput();
            this.swbAllowNoCodeReview = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.swbSystemSignStoreInPosition = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.swbPrintCargoBarcode = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.swbWMSStandalone = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.txtRootPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAutomaticOutStoreTaskCount = new DevComponents.Editors.IntegerInput();
            this.txtInDir = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtOutDir = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtComputerId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.customValidator1 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.lblPrintCargoBarcode = new DevComponents.DotNetBar.LabelX();
            this.lblRootPassword = new DevComponents.DotNetBar.LabelX();
            this.lblWMSStandalone = new DevComponents.DotNetBar.LabelX();
            this.lblRemoteManifest = new DevComponents.DotNetBar.LabelX();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.line3 = new DevComponents.DotNetBar.Controls.Line();
            this.btnInDir = new DevComponents.DotNetBar.ButtonX();
            this.btnOutDir = new DevComponents.DotNetBar.ButtonX();
            this.fbdInDir = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdOutDir = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSetCustomers = new DevComponents.DotNetBar.ButtonX();
            this.line4 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.btnGetMac = new DevComponents.DotNetBar.ButtonX();
            this.swbYuanBo = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAutomaticOutStoreInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAutomaticOutStoreTaskCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAutomaticOutStore
            // 
            // 
            // 
            // 
            this.lblAutomaticOutStore.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblAutomaticOutStore.Location = new System.Drawing.Point(120, 131);
            this.lblAutomaticOutStore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblAutomaticOutStore.Name = "lblAutomaticOutStore";
            this.lblAutomaticOutStore.Size = new System.Drawing.Size(123, 30);
            this.lblAutomaticOutStore.TabIndex = 1;
            this.lblAutomaticOutStore.Text = "是否自动出库：";
            // 
            // lblAutomaticOutStoreInterval
            // 
            // 
            // 
            // 
            this.lblAutomaticOutStoreInterval.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblAutomaticOutStoreInterval.Location = new System.Drawing.Point(120, 172);
            this.lblAutomaticOutStoreInterval.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblAutomaticOutStoreInterval.Name = "lblAutomaticOutStoreInterval";
            this.lblAutomaticOutStoreInterval.Size = new System.Drawing.Size(123, 30);
            this.lblAutomaticOutStoreInterval.TabIndex = 3;
            this.lblAutomaticOutStoreInterval.Text = "自动出库频率：";
            // 
            // lblSystemSignStoreInPosition
            // 
            // 
            // 
            // 
            this.lblSystemSignStoreInPosition.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSystemSignStoreInPosition.Location = new System.Drawing.Point(463, 176);
            this.lblSystemSignStoreInPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblSystemSignStoreInPosition.Name = "lblSystemSignStoreInPosition";
            this.lblSystemSignStoreInPosition.Size = new System.Drawing.Size(184, 30);
            this.lblSystemSignStoreInPosition.TabIndex = 8;
            this.lblSystemSignStoreInPosition.Text = "系统自动分配入库货位：";
            // 
            // txtRemoteManifest
            // 
            // 
            // 
            // 
            this.txtRemoteManifest.Border.Class = "TextBoxBorder";
            this.txtRemoteManifest.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRemoteManifest.ButtonCustom.Tooltip = "";
            this.txtRemoteManifest.ButtonCustom2.Tooltip = "";
            this.highlighter.SetHighlightOnFocus(this.txtRemoteManifest, true);
            this.txtRemoteManifest.Location = new System.Drawing.Point(249, 74);
            this.txtRemoteManifest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRemoteManifest.Name = "txtRemoteManifest";
            this.txtRemoteManifest.PreventEnterBeep = true;
            this.txtRemoteManifest.Size = new System.Drawing.Size(520, 27);
            this.txtRemoteManifest.TabIndex = 2;
            // 
            // lblAllowNoCodeReview
            // 
            // 
            // 
            // 
            this.lblAllowNoCodeReview.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblAllowNoCodeReview.Location = new System.Drawing.Point(59, 217);
            this.lblAllowNoCodeReview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblAllowNoCodeReview.Name = "lblAllowNoCodeReview";
            this.lblAllowNoCodeReview.Size = new System.Drawing.Size(184, 30);
            this.lblAllowNoCodeReview.TabIndex = 6;
            this.lblAllowNoCodeReview.Text = "允许无监管码出库复核：";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(282, 560);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 42);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(424, 560);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 42);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "取消";
            // 
            // superValidator
            // 
            this.superValidator.ContainerControl = this;
            this.superValidator.ErrorProvider = this.errorProvider;
            this.superValidator.Highlighter = this.highlighter;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            // 
            // swbAutomaticOutStore
            // 
            // 
            // 
            // 
            this.swbAutomaticOutStore.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter.SetHighlightOnFocus(this.swbAutomaticOutStore, true);
            this.swbAutomaticOutStore.Location = new System.Drawing.Point(249, 131);
            this.swbAutomaticOutStore.Name = "swbAutomaticOutStore";
            this.swbAutomaticOutStore.OffText = "否";
            this.swbAutomaticOutStore.OnText = "是";
            this.swbAutomaticOutStore.Size = new System.Drawing.Size(116, 31);
            this.swbAutomaticOutStore.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swbAutomaticOutStore.SwitchFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.swbAutomaticOutStore.TabIndex = 3;
            // 
            // txtAutomaticOutStoreInterval
            // 
            // 
            // 
            // 
            this.txtAutomaticOutStoreInterval.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtAutomaticOutStoreInterval.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAutomaticOutStoreInterval.ButtonCalculator.Tooltip = "";
            this.txtAutomaticOutStoreInterval.ButtonClear.Tooltip = "";
            this.txtAutomaticOutStoreInterval.ButtonCustom.Tooltip = "";
            this.txtAutomaticOutStoreInterval.ButtonCustom2.Tooltip = "";
            this.txtAutomaticOutStoreInterval.ButtonDropDown.Tooltip = "";
            this.txtAutomaticOutStoreInterval.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtAutomaticOutStoreInterval.ButtonFreeText.Tooltip = "";
            this.highlighter.SetHighlightOnFocus(this.txtAutomaticOutStoreInterval, true);
            this.txtAutomaticOutStoreInterval.Location = new System.Drawing.Point(249, 175);
            this.txtAutomaticOutStoreInterval.MinValue = 30;
            this.txtAutomaticOutStoreInterval.Name = "txtAutomaticOutStoreInterval";
            this.txtAutomaticOutStoreInterval.ShowUpDown = true;
            this.txtAutomaticOutStoreInterval.Size = new System.Drawing.Size(116, 27);
            this.txtAutomaticOutStoreInterval.TabIndex = 4;
            this.txtAutomaticOutStoreInterval.Value = 30;
            // 
            // swbAllowNoCodeReview
            // 
            // 
            // 
            // 
            this.swbAllowNoCodeReview.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter.SetHighlightOnFocus(this.swbAllowNoCodeReview, true);
            this.swbAllowNoCodeReview.Location = new System.Drawing.Point(249, 217);
            this.swbAllowNoCodeReview.Name = "swbAllowNoCodeReview";
            this.swbAllowNoCodeReview.OffText = "否";
            this.swbAllowNoCodeReview.OnText = "是";
            this.swbAllowNoCodeReview.Size = new System.Drawing.Size(116, 31);
            this.swbAllowNoCodeReview.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swbAllowNoCodeReview.SwitchFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.swbAllowNoCodeReview.TabIndex = 5;
            // 
            // swbSystemSignStoreInPosition
            // 
            // 
            // 
            // 
            this.swbSystemSignStoreInPosition.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter.SetHighlightOnFocus(this.swbSystemSignStoreInPosition, true);
            this.swbSystemSignStoreInPosition.Location = new System.Drawing.Point(653, 175);
            this.swbSystemSignStoreInPosition.Name = "swbSystemSignStoreInPosition";
            this.swbSystemSignStoreInPosition.OffText = "否";
            this.swbSystemSignStoreInPosition.OnText = "是";
            this.swbSystemSignStoreInPosition.Size = new System.Drawing.Size(116, 31);
            this.swbSystemSignStoreInPosition.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swbSystemSignStoreInPosition.SwitchFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.swbSystemSignStoreInPosition.TabIndex = 7;
            // 
            // swbPrintCargoBarcode
            // 
            // 
            // 
            // 
            this.swbPrintCargoBarcode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter.SetHighlightOnFocus(this.swbPrintCargoBarcode, true);
            this.swbPrintCargoBarcode.Location = new System.Drawing.Point(653, 214);
            this.swbPrintCargoBarcode.Name = "swbPrintCargoBarcode";
            this.swbPrintCargoBarcode.OffText = "否";
            this.swbPrintCargoBarcode.OnText = "是";
            this.swbPrintCargoBarcode.Size = new System.Drawing.Size(116, 31);
            this.swbPrintCargoBarcode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swbPrintCargoBarcode.SwitchFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.swbPrintCargoBarcode.TabIndex = 8;
            // 
            // swbWMSStandalone
            // 
            // 
            // 
            // 
            this.swbWMSStandalone.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter.SetHighlightOnFocus(this.swbWMSStandalone, true);
            this.swbWMSStandalone.Location = new System.Drawing.Point(653, 36);
            this.swbWMSStandalone.Name = "swbWMSStandalone";
            this.swbWMSStandalone.OffText = "否";
            this.swbWMSStandalone.OnText = "是";
            this.swbWMSStandalone.Size = new System.Drawing.Size(116, 31);
            this.swbWMSStandalone.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swbWMSStandalone.SwitchFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.swbWMSStandalone.TabIndex = 1;
            // 
            // txtRootPassword
            // 
            // 
            // 
            // 
            this.txtRootPassword.Border.Class = "TextBoxBorder";
            this.txtRootPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRootPassword.ButtonCustom.Tooltip = "";
            this.txtRootPassword.ButtonCustom2.Tooltip = "";
            this.highlighter.SetHighlightOnFocus(this.txtRootPassword, true);
            this.txtRootPassword.Location = new System.Drawing.Point(249, 36);
            this.txtRootPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRootPassword.Name = "txtRootPassword";
            this.txtRootPassword.PreventEnterBeep = true;
            this.txtRootPassword.Size = new System.Drawing.Size(195, 27);
            this.txtRootPassword.TabIndex = 0;
            // 
            // txtAutomaticOutStoreTaskCount
            // 
            // 
            // 
            // 
            this.txtAutomaticOutStoreTaskCount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtAutomaticOutStoreTaskCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAutomaticOutStoreTaskCount.ButtonCalculator.Tooltip = "";
            this.txtAutomaticOutStoreTaskCount.ButtonClear.Tooltip = "";
            this.txtAutomaticOutStoreTaskCount.ButtonCustom.Tooltip = "";
            this.txtAutomaticOutStoreTaskCount.ButtonCustom2.Tooltip = "";
            this.txtAutomaticOutStoreTaskCount.ButtonDropDown.Tooltip = "";
            this.txtAutomaticOutStoreTaskCount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtAutomaticOutStoreTaskCount.ButtonFreeText.Tooltip = "";
            this.highlighter.SetHighlightOnFocus(this.txtAutomaticOutStoreTaskCount, true);
            this.txtAutomaticOutStoreTaskCount.Location = new System.Drawing.Point(653, 135);
            this.txtAutomaticOutStoreTaskCount.MaxValue = 10;
            this.txtAutomaticOutStoreTaskCount.MinValue = 1;
            this.txtAutomaticOutStoreTaskCount.Name = "txtAutomaticOutStoreTaskCount";
            this.txtAutomaticOutStoreTaskCount.ShowUpDown = true;
            this.txtAutomaticOutStoreTaskCount.Size = new System.Drawing.Size(116, 27);
            this.txtAutomaticOutStoreTaskCount.TabIndex = 6;
            this.txtAutomaticOutStoreTaskCount.Value = 4;
            // 
            // txtInDir
            // 
            // 
            // 
            // 
            this.txtInDir.Border.Class = "TextBoxBorder";
            this.txtInDir.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInDir.ButtonCustom.Tooltip = "";
            this.txtInDir.ButtonCustom2.Tooltip = "";
            this.highlighter.SetHighlightOnFocus(this.txtInDir, true);
            this.txtInDir.Location = new System.Drawing.Point(206, 432);
            this.txtInDir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInDir.Name = "txtInDir";
            this.txtInDir.PreventEnterBeep = true;
            this.txtInDir.ReadOnly = true;
            this.txtInDir.Size = new System.Drawing.Size(483, 27);
            this.txtInDir.TabIndex = 10;
            // 
            // txtOutDir
            // 
            // 
            // 
            // 
            this.txtOutDir.Border.Class = "TextBoxBorder";
            this.txtOutDir.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOutDir.ButtonCustom.Tooltip = "";
            this.txtOutDir.ButtonCustom2.Tooltip = "";
            this.highlighter.SetHighlightOnFocus(this.txtOutDir, true);
            this.txtOutDir.Location = new System.Drawing.Point(206, 394);
            this.txtOutDir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOutDir.Name = "txtOutDir";
            this.txtOutDir.PreventEnterBeep = true;
            this.txtOutDir.ReadOnly = true;
            this.txtOutDir.Size = new System.Drawing.Size(483, 27);
            this.txtOutDir.TabIndex = 9;
            // 
            // txtComputerId
            // 
            // 
            // 
            // 
            this.txtComputerId.Border.Class = "TextBoxBorder";
            this.txtComputerId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtComputerId.ButtonCustom.Tooltip = "";
            this.txtComputerId.ButtonCustom2.Tooltip = "";
            this.highlighter.SetHighlightOnFocus(this.txtComputerId, true);
            this.txtComputerId.Location = new System.Drawing.Point(59, 322);
            this.txtComputerId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComputerId.Name = "txtComputerId";
            this.txtComputerId.PreventEnterBeep = true;
            this.txtComputerId.ReadOnly = true;
            this.txtComputerId.Size = new System.Drawing.Size(630, 27);
            this.txtComputerId.TabIndex = 38;
            // 
            // customValidator1
            // 
            this.customValidator1.ErrorMessage = "Your error message here.";
            this.customValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(373, 175);
            this.labelX1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(21, 30);
            this.labelX1.TabIndex = 13;
            this.labelX1.Text = "秒";
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(36, 108);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(765, 23);
            this.line1.TabIndex = 15;
            this.line1.Text = "line1";
            // 
            // lblPrintCargoBarcode
            // 
            // 
            // 
            // 
            this.lblPrintCargoBarcode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPrintCargoBarcode.Location = new System.Drawing.Point(479, 214);
            this.lblPrintCargoBarcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblPrintCargoBarcode.Name = "lblPrintCargoBarcode";
            this.lblPrintCargoBarcode.Size = new System.Drawing.Size(168, 30);
            this.lblPrintCargoBarcode.TabIndex = 17;
            this.lblPrintCargoBarcode.Text = "是否打印入库货物码：";
            // 
            // lblRootPassword
            // 
            // 
            // 
            // 
            this.lblRootPassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRootPassword.Location = new System.Drawing.Point(120, 33);
            this.lblRootPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblRootPassword.Name = "lblRootPassword";
            this.lblRootPassword.Size = new System.Drawing.Size(120, 30);
            this.lblRootPassword.TabIndex = 19;
            this.lblRootPassword.Text = "超级用户密码：";
            // 
            // lblWMSStandalone
            // 
            // 
            // 
            // 
            this.lblWMSStandalone.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblWMSStandalone.Location = new System.Drawing.Point(479, 36);
            this.lblWMSStandalone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblWMSStandalone.Name = "lblWMSStandalone";
            this.lblWMSStandalone.Size = new System.Drawing.Size(158, 30);
            this.lblWMSStandalone.TabIndex = 20;
            this.lblWMSStandalone.Text = "是否单独运行WMS：";
            // 
            // lblRemoteManifest
            // 
            // 
            // 
            // 
            this.lblRemoteManifest.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRemoteManifest.Location = new System.Drawing.Point(32, 74);
            this.lblRemoteManifest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblRemoteManifest.Name = "lblRemoteManifest";
            this.lblRemoteManifest.Size = new System.Drawing.Size(208, 30);
            this.lblRemoteManifest.TabIndex = 23;
            this.lblRemoteManifest.Text = "自动升级信息文件URL地址：";
            // 
            // line2
            // 
            this.line2.Location = new System.Drawing.Point(31, 369);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(765, 23);
            this.line2.TabIndex = 24;
            this.line2.Text = "line2";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(777, 135);
            this.labelX2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(21, 30);
            this.labelX2.TabIndex = 27;
            this.labelX2.Text = "个";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(463, 132);
            this.labelX3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(184, 30);
            this.labelX3.TabIndex = 25;
            this.labelX3.Text = "每次最多出库单据个数：";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(34, 390);
            this.labelX4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(160, 30);
            this.labelX4.TabIndex = 29;
            this.labelX4.Text = "电子监管网下载目录：";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(34, 428);
            this.labelX5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(160, 30);
            this.labelX5.TabIndex = 31;
            this.labelX5.Text = "电子监管网上传目录：";
            // 
            // line3
            // 
            this.line3.Location = new System.Drawing.Point(32, 531);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(765, 23);
            this.line3.TabIndex = 32;
            this.line3.Text = "line3";
            // 
            // btnInDir
            // 
            this.btnInDir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInDir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInDir.Location = new System.Drawing.Point(695, 432);
            this.btnInDir.Name = "btnInDir";
            this.btnInDir.Size = new System.Drawing.Size(73, 27);
            this.btnInDir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnInDir.TabIndex = 33;
            this.btnInDir.Text = "浏览...";
            this.btnInDir.Click += new System.EventHandler(this.btnInDir_Click);
            // 
            // btnOutDir
            // 
            this.btnOutDir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOutDir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOutDir.Location = new System.Drawing.Point(695, 394);
            this.btnOutDir.Name = "btnOutDir";
            this.btnOutDir.Size = new System.Drawing.Size(73, 27);
            this.btnOutDir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOutDir.TabIndex = 34;
            this.btnOutDir.Text = "浏览...";
            this.btnOutDir.Click += new System.EventHandler(this.btnOutDir_Click);
            // 
            // fbdInDir
            // 
            this.fbdInDir.Description = "选择电子监管网下载目录";
            // 
            // fbdOutDir
            // 
            this.fbdOutDir.Description = "选择电子监管网上传目录";
            // 
            // btnSetCustomers
            // 
            this.btnSetCustomers.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSetCustomers.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSetCustomers.Location = new System.Drawing.Point(545, 483);
            this.btnSetCustomers.Name = "btnSetCustomers";
            this.btnSetCustomers.Size = new System.Drawing.Size(223, 42);
            this.btnSetCustomers.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSetCustomers.TabIndex = 35;
            this.btnSetCustomers.Text = "电子监管网往来单位匹配";
            this.btnSetCustomers.Click += new System.EventHandler(this.btnSetCustomers_Click);
            // 
            // line4
            // 
            this.line4.Location = new System.Drawing.Point(36, 254);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(765, 23);
            this.line4.TabIndex = 36;
            this.line4.Text = "line4";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(59, 268);
            this.labelX6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(730, 46);
            this.labelX6.TabIndex = 37;
            this.labelX6.Text = "出入库机器标识：\r\n为避免多台机器运行出入库监控，造成系统重复出入相同单据，只允许一台机器可以做出入库操作！";
            // 
            // btnGetMac
            // 
            this.btnGetMac.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGetMac.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGetMac.Location = new System.Drawing.Point(695, 322);
            this.btnGetMac.Name = "btnGetMac";
            this.btnGetMac.Size = new System.Drawing.Size(73, 27);
            this.btnGetMac.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGetMac.TabIndex = 39;
            this.btnGetMac.Text = "本机标识";
            this.btnGetMac.Click += new System.EventHandler(this.btnGetMac_Click);
            // 
            // swbYuanBo
            // 
            // 
            // 
            // 
            this.swbYuanBo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter.SetHighlightOnFocus(this.swbYuanBo, true);
            this.swbYuanBo.Location = new System.Drawing.Point(260, 483);
            this.swbYuanBo.Name = "swbYuanBo";
            this.swbYuanBo.OffText = "否";
            this.swbYuanBo.OnText = "是";
            this.swbYuanBo.Size = new System.Drawing.Size(116, 31);
            this.swbYuanBo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swbYuanBo.SwitchFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.swbYuanBo.TabIndex = 41;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(31, 482);
            this.labelX7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(223, 30);
            this.labelX7.TabIndex = 40;
            this.labelX7.Text = "是否开启电子监管码扫描接口：";
            // 
            // FrmSystemConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 621);
            this.Controls.Add(this.swbYuanBo);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.btnGetMac);
            this.Controls.Add(this.txtComputerId);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.line4);
            this.Controls.Add(this.btnSetCustomers);
            this.Controls.Add(this.btnOutDir);
            this.Controls.Add(this.btnInDir);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.txtOutDir);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.txtInDir);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtAutomaticOutStoreTaskCount);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.lblRemoteManifest);
            this.Controls.Add(this.txtRootPassword);
            this.Controls.Add(this.swbWMSStandalone);
            this.Controls.Add(this.lblWMSStandalone);
            this.Controls.Add(this.lblRootPassword);
            this.Controls.Add(this.swbPrintCargoBarcode);
            this.Controls.Add(this.lblPrintCargoBarcode);
            this.Controls.Add(this.swbSystemSignStoreInPosition);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.swbAllowNoCodeReview);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtAutomaticOutStoreInterval);
            this.Controls.Add(this.swbAutomaticOutStore);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSystemSignStoreInPosition);
            this.Controls.Add(this.txtRemoteManifest);
            this.Controls.Add(this.lblAllowNoCodeReview);
            this.Controls.Add(this.lblAutomaticOutStoreInterval);
            this.Controls.Add(this.lblAutomaticOutStore);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSystemConfig";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WMS系统配置";
            this.Load += new System.EventHandler(this.FrmSystemConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAutomaticOutStoreInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAutomaticOutStoreTaskCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblAutomaticOutStore;
        private DevComponents.DotNetBar.LabelX lblAutomaticOutStoreInterval;
        private DevComponents.DotNetBar.LabelX lblSystemSignStoreInPosition;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRemoteManifest;
        private DevComponents.DotNetBar.LabelX lblAllowNoCodeReview;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator1;
        private DevComponents.DotNetBar.Controls.SwitchButton swbAutomaticOutStore;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.IntegerInput txtAutomaticOutStoreInterval;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.Controls.SwitchButton swbAllowNoCodeReview;
        private DevComponents.DotNetBar.Controls.SwitchButton swbSystemSignStoreInPosition;
        private DevComponents.DotNetBar.LabelX lblPrintCargoBarcode;
        private DevComponents.DotNetBar.Controls.SwitchButton swbPrintCargoBarcode;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRootPassword;
        private DevComponents.DotNetBar.Controls.SwitchButton swbWMSStandalone;
        private DevComponents.DotNetBar.LabelX lblWMSStandalone;
        private DevComponents.DotNetBar.LabelX lblRootPassword;
        private DevComponents.DotNetBar.LabelX lblRemoteManifest;
        private DevComponents.DotNetBar.Controls.Line line2;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Editors.IntegerInput txtAutomaticOutStoreTaskCount;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.Line line3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtOutDir;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInDir;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ButtonX btnOutDir;
        private DevComponents.DotNetBar.ButtonX btnInDir;
        private System.Windows.Forms.FolderBrowserDialog fbdInDir;
        private System.Windows.Forms.FolderBrowserDialog fbdOutDir;
        private DevComponents.DotNetBar.ButtonX btnSetCustomers;
        private DevComponents.DotNetBar.Controls.Line line4;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtComputerId;
        private DevComponents.DotNetBar.ButtonX btnGetMac;
        private DevComponents.DotNetBar.Controls.SwitchButton swbYuanBo;
        private DevComponents.DotNetBar.LabelX labelX7;
    }
}