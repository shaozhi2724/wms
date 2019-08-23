namespace WMS.Windows.App
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl = new DevComponents.DotNetBar.RibbonControl();
            this.rpanSysSettings = new DevComponents.DotNetBar.RibbonPanel();
            this.rbarSysSettings = new DevComponents.DotNetBar.RibbonBar();
            this.btnDBConfig = new DevComponents.DotNetBar.ButtonItem();
            this.btnSysConfig = new DevComponents.DotNetBar.ButtonItem();
            this.btnExitApp = new DevComponents.DotNetBar.ButtonItem();
            this.rpanStoreMonitoring = new DevComponents.DotNetBar.RibbonPanel();
            this.rbarHistoryQuery = new DevComponents.DotNetBar.RibbonBar();
            this.btnStoreInHistory = new DevComponents.DotNetBar.ButtonItem();
            this.btnStoreOutHistory = new DevComponents.DotNetBar.ButtonItem();
            this.rbarMonitoring = new DevComponents.DotNetBar.RibbonBar();
            this.btnStoreInMonitoring = new DevComponents.DotNetBar.ButtonItem();
            this.btnStoreOutMonitoring = new DevComponents.DotNetBar.ButtonItem();
            this.rpanOperating = new DevComponents.DotNetBar.RibbonPanel();
            this.rbarLabelManagement = new DevComponents.DotNetBar.RibbonBar();
            this.btnLabelManagement = new DevComponents.DotNetBar.ButtonItem();
            this.btnLabelRelationship = new DevComponents.DotNetBar.ButtonItem();
            this.rbarWarehouse = new DevComponents.DotNetBar.RibbonBar();
            this.btnWarehouse = new DevComponents.DotNetBar.ButtonItem();
            this.btnWarehouseUnit = new DevComponents.DotNetBar.ButtonItem();
            this.btnDrugManagement = new DevComponents.DotNetBar.ButtonItem();
            this.rpanRegulatoryCode = new DevComponents.DotNetBar.RibbonPanel();
            this.rbarRegulatoryCode = new DevComponents.DotNetBar.RibbonBar();
            this.btnCorpCode = new DevComponents.DotNetBar.ButtonItem();
            this.btnImportCode = new DevComponents.DotNetBar.ButtonItem();
            this.btnExportTickets = new DevComponents.DotNetBar.ButtonItem();
            this.rpanInventory = new DevComponents.DotNetBar.RibbonPanel();
            this.rbarInventoryStatistic = new DevComponents.DotNetBar.RibbonBar();
            this.btnCargoDetail = new DevComponents.DotNetBar.ButtonItem();
            this.btnInventoryStatistic = new DevComponents.DotNetBar.ButtonItem();
            this.btnInventoryHistory = new DevComponents.DotNetBar.ButtonItem();
            this.rbarInventory = new DevComponents.DotNetBar.RibbonBar();
            this.btnStoreQuery = new DevComponents.DotNetBar.ButtonItem();
            this.btnBatchNoEdit = new DevComponents.DotNetBar.ButtonItem();
            this.rpanReview = new DevComponents.DotNetBar.RibbonPanel();
            this.rbarReviewHistory = new DevComponents.DotNetBar.RibbonBar();
            this.btnReviewHistory = new DevComponents.DotNetBar.ButtonItem();
            this.rbarReview = new DevComponents.DotNetBar.RibbonBar();
            this.btnReview = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribUserManagement = new DevComponents.DotNetBar.RibbonBar();
            this.btnUserManagement = new DevComponents.DotNetBar.ButtonItem();
            this.tabStoreMonitoring = new DevComponents.DotNetBar.RibbonTabItem();
            this.tabOperating = new DevComponents.DotNetBar.RibbonTabItem();
            this.tabRegulatoryCode = new DevComponents.DotNetBar.RibbonTabItem();
            this.tabReview = new DevComponents.DotNetBar.RibbonTabItem();
            this.tabInventory = new DevComponents.DotNetBar.RibbonTabItem();
            this.tabUserManagement = new DevComponents.DotNetBar.RibbonTabItem();
            this.tabSysSettings = new DevComponents.DotNetBar.RibbonTabItem();
            this.tabStrip = new DevComponents.DotNetBar.TabStrip();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.ribbonControl.SuspendLayout();
            this.rpanSysSettings.SuspendLayout();
            this.rpanStoreMonitoring.SuspendLayout();
            this.rpanOperating.SuspendLayout();
            this.rpanRegulatoryCode.SuspendLayout();
            this.rpanInventory.SuspendLayout();
            this.rpanReview.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            // 
            // 
            // 
            this.ribbonControl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl.CanCustomize = false;
            this.ribbonControl.CaptionFont = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl.CaptionVisible = true;
            this.ribbonControl.Controls.Add(this.rpanStoreMonitoring);
            this.ribbonControl.Controls.Add(this.rpanOperating);
            this.ribbonControl.Controls.Add(this.rpanSysSettings);
            this.ribbonControl.Controls.Add(this.rpanRegulatoryCode);
            this.ribbonControl.Controls.Add(this.rpanInventory);
            this.ribbonControl.Controls.Add(this.rpanReview);
            this.ribbonControl.Controls.Add(this.ribbonPanel1);
            this.ribbonControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ribbonControl.ForeColor = System.Drawing.Color.Black;
            this.ribbonControl.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabStoreMonitoring,
            this.tabOperating,
            this.tabRegulatoryCode,
            this.tabReview,
            this.tabInventory,
            this.tabUserManagement,
            this.tabSysSettings});
            this.ribbonControl.KeyTipsFont = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl.Location = new System.Drawing.Point(5, 1);
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ribbonControl.MdiSystemItemVisible = false;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ribbonControl.RibbonStripIndent = 23;
            this.ribbonControl.Size = new System.Drawing.Size(1091, 171);
            this.ribbonControl.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl.SystemText.MaximizeRibbonText = "功能区最大化";
            this.ribbonControl.SystemText.MinimizeRibbonText = "功能区最小化";
            this.ribbonControl.SystemText.QatAddItemText = "添加到快速访问工具栏";
            this.ribbonControl.SystemText.QatCustomizeMenuLabel = "<b>自定义快速访问工具栏</b>";
            this.ribbonControl.SystemText.QatCustomizeText = "自定义快速访问工具栏...";
            this.ribbonControl.SystemText.QatDialogAddButton = "添加 >>";
            this.ribbonControl.SystemText.QatDialogCancelButton = "取消";
            this.ribbonControl.SystemText.QatDialogCaption = "自定义快速访问工具栏";
            this.ribbonControl.SystemText.QatDialogCategoriesLabel = "从下列位置选择命令：";
            this.ribbonControl.SystemText.QatDialogOkButton = "确定";
            this.ribbonControl.SystemText.QatDialogPlacementCheckbox = "在功能区下方显示快速访问工具栏";
            this.ribbonControl.SystemText.QatDialogRemoveButton = "删除";
            this.ribbonControl.SystemText.QatPlaceAboveRibbonText = "在功能区上方显示";
            this.ribbonControl.SystemText.QatPlaceBelowRibbonText = "在功能区下方显示";
            this.ribbonControl.SystemText.QatRemoveItemText = "从快速访问工具栏中移除";
            this.ribbonControl.TabGroupHeight = 14;
            this.ribbonControl.TabIndex = 0;
            this.ribbonControl.UseExternalCustomization = true;
            // 
            // rpanSysSettings
            // 
            this.rpanSysSettings.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rpanSysSettings.Controls.Add(this.rbarSysSettings);
            this.rpanSysSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpanSysSettings.Location = new System.Drawing.Point(0, 60);
            this.rpanSysSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rpanSysSettings.Name = "rpanSysSettings";
            this.rpanSysSettings.Padding = new System.Windows.Forms.Padding(4, 0, 4, 3);
            this.rpanSysSettings.Size = new System.Drawing.Size(1091, 108);
            // 
            // 
            // 
            this.rpanSysSettings.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rpanSysSettings.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rpanSysSettings.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rpanSysSettings.TabIndex = 3;
            this.rpanSysSettings.Visible = false;
            // 
            // rbarSysSettings
            // 
            this.rbarSysSettings.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rbarSysSettings.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbarSysSettings.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbarSysSettings.ContainerControlProcessDialogKey = true;
            this.rbarSysSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbarSysSettings.DragDropSupport = true;
            this.rbarSysSettings.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDBConfig,
            this.btnSysConfig,
            this.btnExitApp});
            this.rbarSysSettings.Location = new System.Drawing.Point(4, 0);
            this.rbarSysSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbarSysSettings.Name = "rbarSysSettings";
            this.rbarSysSettings.Size = new System.Drawing.Size(252, 105);
            this.rbarSysSettings.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbarSysSettings.TabIndex = 7;
            this.rbarSysSettings.Text = "系统设置";
            // 
            // 
            // 
            this.rbarSysSettings.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbarSysSettings.TitleStyle.HideMnemonic = true;
            // 
            // 
            // 
            this.rbarSysSettings.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnDBConfig
            // 
            this.btnDBConfig.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnDBConfig.Image = global::WMS.Windows.App.Properties.Resources.database_link;
            this.btnDBConfig.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDBConfig.Name = "btnDBConfig";
            this.btnDBConfig.PopupType = DevComponents.DotNetBar.ePopupType.ToolBar;
            this.btnDBConfig.SubItemsExpandWidth = 14;
            this.btnDBConfig.Text = "数据库设置";
            this.btnDBConfig.Click += new System.EventHandler(this.btnDBConfig_Click);
            // 
            // btnSysConfig
            // 
            this.btnSysConfig.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnSysConfig.Image = global::WMS.Windows.App.Properties.Resources.settings;
            this.btnSysConfig.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSysConfig.Name = "btnSysConfig";
            this.btnSysConfig.SubItemsExpandWidth = 14;
            this.btnSysConfig.Text = "系统配置";
            this.btnSysConfig.Click += new System.EventHandler(this.btnSysConfig_Click);
            // 
            // btnExitApp
            // 
            this.btnExitApp.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnExitApp.Image = global::WMS.Windows.App.Properties.Resources.door_in;
            this.btnExitApp.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.SubItemsExpandWidth = 14;
            this.btnExitApp.Text = "退出系统";
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // rpanStoreMonitoring
            // 
            this.rpanStoreMonitoring.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rpanStoreMonitoring.Controls.Add(this.rbarHistoryQuery);
            this.rpanStoreMonitoring.Controls.Add(this.rbarMonitoring);
            this.rpanStoreMonitoring.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpanStoreMonitoring.Location = new System.Drawing.Point(0, 60);
            this.rpanStoreMonitoring.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rpanStoreMonitoring.Name = "rpanStoreMonitoring";
            this.rpanStoreMonitoring.Padding = new System.Windows.Forms.Padding(4, 0, 4, 3);
            this.rpanStoreMonitoring.Size = new System.Drawing.Size(1091, 108);
            // 
            // 
            // 
            this.rpanStoreMonitoring.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rpanStoreMonitoring.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rpanStoreMonitoring.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rpanStoreMonitoring.TabIndex = 1;
            // 
            // rbarHistoryQuery
            // 
            this.rbarHistoryQuery.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rbarHistoryQuery.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbarHistoryQuery.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbarHistoryQuery.ContainerControlProcessDialogKey = true;
            this.rbarHistoryQuery.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbarHistoryQuery.DragDropSupport = true;
            this.rbarHistoryQuery.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnStoreInHistory,
            this.btnStoreOutHistory});
            this.rbarHistoryQuery.Location = new System.Drawing.Point(164, 0);
            this.rbarHistoryQuery.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbarHistoryQuery.Name = "rbarHistoryQuery";
            this.rbarHistoryQuery.Size = new System.Drawing.Size(160, 105);
            this.rbarHistoryQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbarHistoryQuery.TabIndex = 2;
            this.rbarHistoryQuery.Text = "历史查询";
            // 
            // 
            // 
            this.rbarHistoryQuery.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbarHistoryQuery.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnStoreInHistory
            // 
            this.btnStoreInHistory.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnStoreInHistory.Image = global::WMS.Windows.App.Properties.Resources.storeInHistory;
            this.btnStoreInHistory.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnStoreInHistory.Name = "btnStoreInHistory";
            this.btnStoreInHistory.SubItemsExpandWidth = 14;
            this.btnStoreInHistory.Text = "入库历史";
            this.btnStoreInHistory.Click += new System.EventHandler(this.btnStoreInHistory_Click);
            // 
            // btnStoreOutHistory
            // 
            this.btnStoreOutHistory.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnStoreOutHistory.Image = global::WMS.Windows.App.Properties.Resources.storeOutHistory;
            this.btnStoreOutHistory.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnStoreOutHistory.Name = "btnStoreOutHistory";
            this.btnStoreOutHistory.SubItemsExpandWidth = 14;
            this.btnStoreOutHistory.Text = "出库历史";
            this.btnStoreOutHistory.Click += new System.EventHandler(this.btnStoreOutHistory_Click);
            // 
            // rbarMonitoring
            // 
            this.rbarMonitoring.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rbarMonitoring.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbarMonitoring.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbarMonitoring.ContainerControlProcessDialogKey = true;
            this.rbarMonitoring.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbarMonitoring.DragDropSupport = true;
            this.rbarMonitoring.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnStoreInMonitoring,
            this.btnStoreOutMonitoring});
            this.rbarMonitoring.Location = new System.Drawing.Point(4, 0);
            this.rbarMonitoring.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbarMonitoring.Name = "rbarMonitoring";
            this.rbarMonitoring.Size = new System.Drawing.Size(160, 105);
            this.rbarMonitoring.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbarMonitoring.TabIndex = 0;
            this.rbarMonitoring.Text = "出入库监控";
            // 
            // 
            // 
            this.rbarMonitoring.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbarMonitoring.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnStoreInMonitoring
            // 
            this.btnStoreInMonitoring.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnStoreInMonitoring.Image = global::WMS.Windows.App.Properties.Resources.storeIn;
            this.btnStoreInMonitoring.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnStoreInMonitoring.Name = "btnStoreInMonitoring";
            this.btnStoreInMonitoring.SubItemsExpandWidth = 14;
            this.btnStoreInMonitoring.Text = "入库监控";
            this.btnStoreInMonitoring.Click += new System.EventHandler(this.btnStoreInMonitoring_Click);
            // 
            // btnStoreOutMonitoring
            // 
            this.btnStoreOutMonitoring.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnStoreOutMonitoring.Image = global::WMS.Windows.App.Properties.Resources.storeOut;
            this.btnStoreOutMonitoring.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnStoreOutMonitoring.Name = "btnStoreOutMonitoring";
            this.btnStoreOutMonitoring.SubItemsExpandWidth = 14;
            this.btnStoreOutMonitoring.Text = "出库监控";
            this.btnStoreOutMonitoring.Click += new System.EventHandler(this.btnStoreOutMonitoring_Click);
            // 
            // rpanOperating
            // 
            this.rpanOperating.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rpanOperating.Controls.Add(this.rbarLabelManagement);
            this.rpanOperating.Controls.Add(this.rbarWarehouse);
            this.rpanOperating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpanOperating.Location = new System.Drawing.Point(0, 60);
            this.rpanOperating.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rpanOperating.Name = "rpanOperating";
            this.rpanOperating.Padding = new System.Windows.Forms.Padding(4, 0, 4, 3);
            this.rpanOperating.Size = new System.Drawing.Size(1091, 108);
            // 
            // 
            // 
            this.rpanOperating.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rpanOperating.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rpanOperating.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rpanOperating.TabIndex = 4;
            this.rpanOperating.Visible = false;
            // 
            // rbarLabelManagement
            // 
            this.rbarLabelManagement.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rbarLabelManagement.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbarLabelManagement.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbarLabelManagement.ContainerControlProcessDialogKey = true;
            this.rbarLabelManagement.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbarLabelManagement.DragDropSupport = true;
            this.rbarLabelManagement.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnLabelManagement,
            this.btnLabelRelationship});
            this.rbarLabelManagement.Location = new System.Drawing.Point(240, 0);
            this.rbarLabelManagement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbarLabelManagement.Name = "rbarLabelManagement";
            this.rbarLabelManagement.Size = new System.Drawing.Size(160, 105);
            this.rbarLabelManagement.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbarLabelManagement.TabIndex = 4;
            this.rbarLabelManagement.Text = "货标管理";
            // 
            // 
            // 
            this.rbarLabelManagement.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbarLabelManagement.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnLabelManagement
            // 
            this.btnLabelManagement.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnLabelManagement.Image = global::WMS.Windows.App.Properties.Resources.labelManagement;
            this.btnLabelManagement.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLabelManagement.Name = "btnLabelManagement";
            this.btnLabelManagement.SubItemsExpandWidth = 14;
            this.btnLabelManagement.Text = "标签管理";
            this.btnLabelManagement.Click += new System.EventHandler(this.btnLabelManagement_Click);
            // 
            // btnLabelRelationship
            // 
            this.btnLabelRelationship.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnLabelRelationship.Image = global::WMS.Windows.App.Properties.Resources.labelRelationship;
            this.btnLabelRelationship.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLabelRelationship.Name = "btnLabelRelationship";
            this.btnLabelRelationship.SubItemsExpandWidth = 14;
            this.btnLabelRelationship.Text = "货标关联";
            this.btnLabelRelationship.Click += new System.EventHandler(this.btnLabelRelationship_Click);
            // 
            // rbarWarehouse
            // 
            this.rbarWarehouse.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rbarWarehouse.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbarWarehouse.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbarWarehouse.ContainerControlProcessDialogKey = true;
            this.rbarWarehouse.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbarWarehouse.DragDropSupport = true;
            this.rbarWarehouse.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnWarehouse,
            this.btnWarehouseUnit,
            this.btnDrugManagement});
            this.rbarWarehouse.Location = new System.Drawing.Point(4, 0);
            this.rbarWarehouse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbarWarehouse.Name = "rbarWarehouse";
            this.rbarWarehouse.Size = new System.Drawing.Size(236, 105);
            this.rbarWarehouse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbarWarehouse.TabIndex = 3;
            this.rbarWarehouse.Text = "仓库管理";
            // 
            // 
            // 
            this.rbarWarehouse.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbarWarehouse.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnWarehouse.Image = global::WMS.Windows.App.Properties.Resources.warehouse;
            this.btnWarehouse.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.SubItemsExpandWidth = 14;
            this.btnWarehouse.Text = "仓库信息";
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // btnWarehouseUnit
            // 
            this.btnWarehouseUnit.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnWarehouseUnit.Image = global::WMS.Windows.App.Properties.Resources.warehouseUnit;
            this.btnWarehouseUnit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnWarehouseUnit.Name = "btnWarehouseUnit";
            this.btnWarehouseUnit.SubItemsExpandWidth = 14;
            this.btnWarehouseUnit.Text = "存储单元";
            this.btnWarehouseUnit.Click += new System.EventHandler(this.btnWarehouseUnit_Click);
            // 
            // btnDrugManagement
            // 
            this.btnDrugManagement.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnDrugManagement.Image = global::WMS.Windows.App.Properties.Resources.drugManagement;
            this.btnDrugManagement.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDrugManagement.Name = "btnDrugManagement";
            this.btnDrugManagement.SubItemsExpandWidth = 14;
            this.btnDrugManagement.Text = "药品管理";
            this.btnDrugManagement.Click += new System.EventHandler(this.btnDrugManagement_Click);
            // 
            // rpanRegulatoryCode
            // 
            this.rpanRegulatoryCode.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rpanRegulatoryCode.Controls.Add(this.rbarRegulatoryCode);
            this.rpanRegulatoryCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpanRegulatoryCode.Location = new System.Drawing.Point(0, 62);
            this.rpanRegulatoryCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rpanRegulatoryCode.Name = "rpanRegulatoryCode";
            this.rpanRegulatoryCode.Padding = new System.Windows.Forms.Padding(4, 0, 4, 3);
            this.rpanRegulatoryCode.Size = new System.Drawing.Size(1091, 106);
            // 
            // 
            // 
            this.rpanRegulatoryCode.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rpanRegulatoryCode.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rpanRegulatoryCode.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rpanRegulatoryCode.TabIndex = 7;
            this.rpanRegulatoryCode.Visible = false;
            // 
            // rbarRegulatoryCode
            // 
            this.rbarRegulatoryCode.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rbarRegulatoryCode.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbarRegulatoryCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbarRegulatoryCode.ContainerControlProcessDialogKey = true;
            this.rbarRegulatoryCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbarRegulatoryCode.DragDropSupport = true;
            this.rbarRegulatoryCode.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnCorpCode,
            this.btnImportCode,
            this.btnExportTickets});
            this.rbarRegulatoryCode.Location = new System.Drawing.Point(4, 0);
            this.rbarRegulatoryCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbarRegulatoryCode.Name = "rbarRegulatoryCode";
            this.rbarRegulatoryCode.Size = new System.Drawing.Size(252, 103);
            this.rbarRegulatoryCode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbarRegulatoryCode.TabIndex = 1;
            this.rbarRegulatoryCode.Text = "流通监管码";
            // 
            // 
            // 
            this.rbarRegulatoryCode.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbarRegulatoryCode.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnCorpCode
            // 
            this.btnCorpCode.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnCorpCode.Image = global::WMS.Windows.App.Properties.Resources.corpCode;
            this.btnCorpCode.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCorpCode.Name = "btnCorpCode";
            this.btnCorpCode.SubItemsExpandWidth = 14;
            this.btnCorpCode.Text = "企业编码";
            this.btnCorpCode.Click += new System.EventHandler(this.btnCorpCode_Click);
            // 
            // btnImportCode
            // 
            this.btnImportCode.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnImportCode.Image = global::WMS.Windows.App.Properties.Resources.importCode;
            this.btnImportCode.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnImportCode.Name = "btnImportCode";
            this.btnImportCode.SubItemsExpandWidth = 14;
            this.btnImportCode.Text = "导入监管码";
            this.btnImportCode.Click += new System.EventHandler(this.btnImportCode_Click);
            // 
            // btnExportTickets
            // 
            this.btnExportTickets.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnExportTickets.Image = global::WMS.Windows.App.Properties.Resources.exportTickets;
            this.btnExportTickets.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnExportTickets.Name = "btnExportTickets";
            this.btnExportTickets.SubItemsExpandWidth = 14;
            this.btnExportTickets.Text = "导出单据";
            this.btnExportTickets.Click += new System.EventHandler(this.btnExportTickets_Click);
            // 
            // rpanInventory
            // 
            this.rpanInventory.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rpanInventory.Controls.Add(this.rbarInventoryStatistic);
            this.rpanInventory.Controls.Add(this.rbarInventory);
            this.rpanInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpanInventory.Location = new System.Drawing.Point(0, 62);
            this.rpanInventory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rpanInventory.Name = "rpanInventory";
            this.rpanInventory.Padding = new System.Windows.Forms.Padding(4, 0, 4, 3);
            this.rpanInventory.Size = new System.Drawing.Size(1091, 106);
            // 
            // 
            // 
            this.rpanInventory.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rpanInventory.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rpanInventory.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rpanInventory.TabIndex = 8;
            this.rpanInventory.Visible = false;
            // 
            // rbarInventoryStatistic
            // 
            this.rbarInventoryStatistic.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rbarInventoryStatistic.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbarInventoryStatistic.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbarInventoryStatistic.ContainerControlProcessDialogKey = true;
            this.rbarInventoryStatistic.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbarInventoryStatistic.DragDropSupport = true;
            this.rbarInventoryStatistic.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnCargoDetail,
            this.btnInventoryStatistic,
            this.btnInventoryHistory});
            this.rbarInventoryStatistic.Location = new System.Drawing.Point(195, 0);
            this.rbarInventoryStatistic.Name = "rbarInventoryStatistic";
            this.rbarInventoryStatistic.Size = new System.Drawing.Size(232, 103);
            this.rbarInventoryStatistic.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbarInventoryStatistic.TabIndex = 8;
            this.rbarInventoryStatistic.Text = "库存盘点";
            // 
            // 
            // 
            this.rbarInventoryStatistic.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbarInventoryStatistic.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnCargoDetail
            // 
            this.btnCargoDetail.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnCargoDetail.Image = global::WMS.Windows.App.Properties.Resources.Inventory;
            this.btnCargoDetail.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCargoDetail.Name = "btnCargoDetail";
            this.btnCargoDetail.SubItemsExpandWidth = 14;
            this.btnCargoDetail.Text = "货位详情";
            this.btnCargoDetail.Click += new System.EventHandler(this.btnCargoDetail_Click);
            // 
            // btnInventoryStatistic
            // 
            this.btnInventoryStatistic.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnInventoryStatistic.Image = global::WMS.Windows.App.Properties.Resources.checklist;
            this.btnInventoryStatistic.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnInventoryStatistic.Name = "btnInventoryStatistic";
            this.btnInventoryStatistic.SubItemsExpandWidth = 14;
            this.btnInventoryStatistic.Text = "库存盘点";
            this.btnInventoryStatistic.Click += new System.EventHandler(this.btnInventoryStatistic_Click);
            // 
            // btnInventoryHistory
            // 
            this.btnInventoryHistory.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnInventoryHistory.Image = global::WMS.Windows.App.Properties.Resources.searchfile;
            this.btnInventoryHistory.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnInventoryHistory.Name = "btnInventoryHistory";
            this.btnInventoryHistory.SubItemsExpandWidth = 14;
            this.btnInventoryHistory.Text = "盘点历史";
            this.btnInventoryHistory.Click += new System.EventHandler(this.btnInventoryHistory_Click);
            // 
            // rbarInventory
            // 
            this.rbarInventory.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rbarInventory.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbarInventory.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbarInventory.ContainerControlProcessDialogKey = true;
            this.rbarInventory.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbarInventory.DragDropSupport = true;
            this.rbarInventory.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnStoreQuery,
            this.btnBatchNoEdit});
            this.rbarInventory.Location = new System.Drawing.Point(4, 0);
            this.rbarInventory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbarInventory.Name = "rbarInventory";
            this.rbarInventory.Size = new System.Drawing.Size(191, 103);
            this.rbarInventory.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbarInventory.TabIndex = 7;
            this.rbarInventory.Text = "库存管理";
            // 
            // 
            // 
            this.rbarInventory.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbarInventory.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnStoreQuery
            // 
            this.btnStoreQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnStoreQuery.Image = global::WMS.Windows.App.Properties.Resources.labelManagement;
            this.btnStoreQuery.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnStoreQuery.Name = "btnStoreQuery";
            this.btnStoreQuery.SubItemsExpandWidth = 14;
            this.btnStoreQuery.Text = "在库药品查询";
            this.btnStoreQuery.Click += new System.EventHandler(this.btnStoreQuery_Click);
            // 
            // btnBatchNoEdit
            // 
            this.btnBatchNoEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnBatchNoEdit.Image = global::WMS.Windows.App.Properties.Resources.labelRelationship;
            this.btnBatchNoEdit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBatchNoEdit.Name = "btnBatchNoEdit";
            this.btnBatchNoEdit.SubItemsExpandWidth = 14;
            this.btnBatchNoEdit.Text = "库存管理";
            this.btnBatchNoEdit.Click += new System.EventHandler(this.btnBatchNoEdit_Click);
            // 
            // rpanReview
            // 
            this.rpanReview.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rpanReview.Controls.Add(this.rbarReviewHistory);
            this.rpanReview.Controls.Add(this.rbarReview);
            this.rpanReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpanReview.Location = new System.Drawing.Point(0, 62);
            this.rpanReview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rpanReview.Name = "rpanReview";
            this.rpanReview.Padding = new System.Windows.Forms.Padding(4, 0, 4, 3);
            this.rpanReview.Size = new System.Drawing.Size(1091, 106);
            // 
            // 
            // 
            this.rpanReview.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rpanReview.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rpanReview.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rpanReview.TabIndex = 5;
            this.rpanReview.Visible = false;
            // 
            // rbarReviewHistory
            // 
            this.rbarReviewHistory.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rbarReviewHistory.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbarReviewHistory.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbarReviewHistory.ContainerControlProcessDialogKey = true;
            this.rbarReviewHistory.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbarReviewHistory.DragDropSupport = true;
            this.rbarReviewHistory.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnReviewHistory});
            this.rbarReviewHistory.Location = new System.Drawing.Point(88, 0);
            this.rbarReviewHistory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbarReviewHistory.Name = "rbarReviewHistory";
            this.rbarReviewHistory.Size = new System.Drawing.Size(85, 103);
            this.rbarReviewHistory.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbarReviewHistory.TabIndex = 2;
            this.rbarReviewHistory.Text = "历史查询";
            // 
            // 
            // 
            this.rbarReviewHistory.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbarReviewHistory.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnReviewHistory
            // 
            this.btnReviewHistory.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnReviewHistory.Image = global::WMS.Windows.App.Properties.Resources.reviewHistory;
            this.btnReviewHistory.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnReviewHistory.Name = "btnReviewHistory";
            this.btnReviewHistory.SubItemsExpandWidth = 14;
            this.btnReviewHistory.Text = "复核历史";
            this.btnReviewHistory.Click += new System.EventHandler(this.btnReviewHistory_Click);
            // 
            // rbarReview
            // 
            this.rbarReview.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rbarReview.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbarReview.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbarReview.ContainerControlProcessDialogKey = true;
            this.rbarReview.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbarReview.DragDropSupport = true;
            this.rbarReview.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnReview});
            this.rbarReview.Location = new System.Drawing.Point(4, 0);
            this.rbarReview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbarReview.Name = "rbarReview";
            this.rbarReview.Size = new System.Drawing.Size(84, 103);
            this.rbarReview.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbarReview.TabIndex = 0;
            this.rbarReview.Text = "出库复核";
            // 
            // 
            // 
            this.rbarReview.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbarReview.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnReview
            // 
            this.btnReview.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnReview.Image = global::WMS.Windows.App.Properties.Resources.review;
            this.btnReview.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnReview.Name = "btnReview";
            this.btnReview.StopPulseOnMouseOver = false;
            this.btnReview.SubItemsExpandWidth = 14;
            this.btnReview.Text = "出库复核";
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.ribUserManagement);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 62);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(1091, 106);
            // 
            // 
            // 
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 9;
            this.ribbonPanel1.Visible = false;
            // 
            // ribUserManagement
            // 
            this.ribUserManagement.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribUserManagement.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribUserManagement.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribUserManagement.ContainerControlProcessDialogKey = true;
            this.ribUserManagement.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribUserManagement.DragDropSupport = true;
            this.ribUserManagement.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnUserManagement});
            this.ribUserManagement.Location = new System.Drawing.Point(3, 0);
            this.ribUserManagement.Name = "ribUserManagement";
            this.ribUserManagement.Size = new System.Drawing.Size(84, 103);
            this.ribUserManagement.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribUserManagement.TabIndex = 0;
            this.ribUserManagement.Text = "用户管理";
            // 
            // 
            // 
            this.ribUserManagement.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribUserManagement.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnUserManagement.Image = global::WMS.Windows.App.Properties.Resources.user;
            this.btnUserManagement.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.SubItemsExpandWidth = 14;
            this.btnUserManagement.Text = "用户管理";
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // tabStoreMonitoring
            // 
            this.tabStoreMonitoring.Checked = true;
            this.tabStoreMonitoring.Name = "tabStoreMonitoring";
            this.tabStoreMonitoring.Panel = this.rpanStoreMonitoring;
            this.tabStoreMonitoring.Text = "出入库监控";
            // 
            // tabOperating
            // 
            this.tabOperating.Name = "tabOperating";
            this.tabOperating.Panel = this.rpanOperating;
            this.tabOperating.Text = "基本操作";
            // 
            // tabRegulatoryCode
            // 
            this.tabRegulatoryCode.Name = "tabRegulatoryCode";
            this.tabRegulatoryCode.Panel = this.rpanRegulatoryCode;
            this.tabRegulatoryCode.Text = "流通监管码";
            // 
            // tabReview
            // 
            this.tabReview.Name = "tabReview";
            this.tabReview.Panel = this.rpanReview;
            this.tabReview.Text = "出库复核";
            // 
            // tabInventory
            // 
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Panel = this.rpanInventory;
            this.tabInventory.Text = "库存管理";
            // 
            // tabUserManagement
            // 
            this.tabUserManagement.Name = "tabUserManagement";
            this.tabUserManagement.Panel = this.ribbonPanel1;
            this.tabUserManagement.Text = "用户管理";
            // 
            // tabSysSettings
            // 
            this.tabSysSettings.Name = "tabSysSettings";
            this.tabSysSettings.Panel = this.rpanSysSettings;
            this.tabSysSettings.Text = "系统设置";
            // 
            // tabStrip
            // 
            this.tabStrip.AutoHideSystemBox = true;
            this.tabStrip.AutoSelectAttachedControl = true;
            this.tabStrip.CanReorderTabs = true;
            this.tabStrip.CloseButtonOnTabsVisible = true;
            this.tabStrip.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right;
            this.tabStrip.CloseButtonVisible = false;
            this.tabStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabStrip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStrip.ForeColor = System.Drawing.Color.Black;
            this.tabStrip.Location = new System.Drawing.Point(5, 172);
            this.tabStrip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabStrip.MdiAutoHide = false;
            this.tabStrip.MdiForm = this;
            this.tabStrip.MdiTabbedDocuments = true;
            this.tabStrip.Name = "tabStrip";
            this.tabStrip.SelectedTab = null;
            this.tabStrip.SelectedTabFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabStrip.ShowMdiChildIcon = false;
            this.tabStrip.Size = new System.Drawing.Size(1091, 29);
            this.tabStrip.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
            this.tabStrip.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top;
            this.tabStrip.TabIndex = 1;
            this.tabStrip.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabStrip.Text = "tabStrip";
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 654);
            this.Controls.Add(this.tabStrip);
            this.Controls.Add(this.ribbonControl);
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "博科智信仓库管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ribbonControl.ResumeLayout(false);
            this.ribbonControl.PerformLayout();
            this.rpanSysSettings.ResumeLayout(false);
            this.rpanStoreMonitoring.ResumeLayout(false);
            this.rpanOperating.ResumeLayout(false);
            this.rpanRegulatoryCode.ResumeLayout(false);
            this.rpanInventory.ResumeLayout(false);
            this.rpanReview.ResumeLayout(false);
            this.ribbonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl;
        private DevComponents.DotNetBar.RibbonPanel rpanStoreMonitoring;
        private DevComponents.DotNetBar.RibbonBar rbarMonitoring;
        private DevComponents.DotNetBar.RibbonTabItem tabStoreMonitoring;
        private DevComponents.DotNetBar.RibbonPanel rpanSysSettings;
        private DevComponents.DotNetBar.RibbonTabItem tabSysSettings;
        private DevComponents.DotNetBar.ButtonItem btnStoreInMonitoring;
        private DevComponents.DotNetBar.ButtonItem btnStoreOutMonitoring;
        private DevComponents.DotNetBar.TabStrip tabStrip;
        private DevComponents.DotNetBar.RibbonPanel rpanOperating;
        private DevComponents.DotNetBar.RibbonBar rbarLabelManagement;
        private DevComponents.DotNetBar.ButtonItem btnLabelManagement;
        private DevComponents.DotNetBar.ButtonItem btnLabelRelationship;
        private DevComponents.DotNetBar.RibbonBar rbarWarehouse;
        private DevComponents.DotNetBar.ButtonItem btnWarehouse;
        private DevComponents.DotNetBar.ButtonItem btnDrugManagement;
        private DevComponents.DotNetBar.RibbonTabItem tabOperating;
        private DevComponents.DotNetBar.ButtonItem btnWarehouseUnit;
        private DevComponents.DotNetBar.RibbonPanel rpanReview;
        private DevComponents.DotNetBar.RibbonBar rbarReview;
        private DevComponents.DotNetBar.ButtonItem btnReview;
        private DevComponents.DotNetBar.RibbonTabItem tabReview;
        private DevComponents.DotNetBar.RibbonBar rbarReviewHistory;
        private DevComponents.DotNetBar.ButtonItem btnReviewHistory;
        private DevComponents.DotNetBar.RibbonPanel rpanRegulatoryCode;
        private DevComponents.DotNetBar.RibbonBar rbarRegulatoryCode;
        private DevComponents.DotNetBar.ButtonItem btnCorpCode;
        private DevComponents.DotNetBar.ButtonItem btnImportCode;
        private DevComponents.DotNetBar.ButtonItem btnExportTickets;
        private DevComponents.DotNetBar.RibbonBar rbarHistoryQuery;
        private DevComponents.DotNetBar.ButtonItem btnStoreInHistory;
        private DevComponents.DotNetBar.ButtonItem btnStoreOutHistory;
        private DevComponents.DotNetBar.RibbonTabItem tabRegulatoryCode;
        private DevComponents.DotNetBar.RibbonBar rbarSysSettings;
        private DevComponents.DotNetBar.ButtonItem btnDBConfig;
        private DevComponents.DotNetBar.ButtonItem btnExitApp;
        private DevComponents.DotNetBar.RibbonPanel rpanInventory;
        private DevComponents.DotNetBar.RibbonBar rbarInventory;
        private DevComponents.DotNetBar.ButtonItem btnStoreQuery;
        private DevComponents.DotNetBar.ButtonItem btnBatchNoEdit;
        private DevComponents.DotNetBar.RibbonTabItem tabInventory;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonBar ribUserManagement;
        private DevComponents.DotNetBar.ButtonItem btnUserManagement;
        private DevComponents.DotNetBar.RibbonTabItem tabUserManagement;
        private DevComponents.DotNetBar.RibbonBar rbarInventoryStatistic;
        private DevComponents.DotNetBar.ButtonItem btnInventoryStatistic;
        private DevComponents.DotNetBar.ButtonItem btnInventoryHistory;
        private DevComponents.DotNetBar.ButtonItem btnCargoDetail;
        private DevComponents.DotNetBar.ButtonItem btnSysConfig;
        private DevComponents.DotNetBar.StyleManager styleManager;
    }
}

