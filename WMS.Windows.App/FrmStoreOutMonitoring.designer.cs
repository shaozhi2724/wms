namespace WMS.Windows.App
{
    partial class FrmStoreOutMonitoring
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStoreOutMonitoring));
            this.grdStoreOut = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.grdStoreOutDetail = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.lblTitle = new DevComponents.DotNetBar.LabelX();
            this.lblDetailTitle = new DevComponents.DotNetBar.LabelX();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnRefresh = new DevComponents.DotNetBar.ButtonItem();
            this.btnOut = new DevComponents.DotNetBar.ButtonItem();
            this.swtAutomaticOut = new DevComponents.DotNetBar.SwitchButtonItem();
            this.btnErrorLog = new DevComponents.DotNetBar.ButtonItem();
            this.lblStoreCode = new DevComponents.DotNetBar.LabelX();
            this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.btnMenu = new DevComponents.DotNetBar.ButtonItem();
            this.btnManuallyComplete = new DevComponents.DotNetBar.ButtonItem();
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdStoreOut
            // 
            this.grdStoreOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdStoreOut.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grdStoreOut.Location = new System.Drawing.Point(14, 105);
            this.grdStoreOut.Name = "grdStoreOut";
            this.grdStoreOut.PrimaryGrid.AllowEdit = false;
            this.grdStoreOut.PrimaryGrid.AutoGenerateColumns = false;
            this.grdStoreOut.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn1.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            gridColumn1.DataPropertyName = "StoreID";
            gridColumn1.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn1.HeaderText = "序号";
            gridColumn1.Name = "colStoreID";
            gridColumn1.Visible = false;
            gridColumn2.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn2.DataPropertyName = "StoreCode";
            gridColumn2.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn2.HeaderText = "出库单编号";
            gridColumn2.Name = "colStoreCode";
            gridColumn3.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn3.DataPropertyName = "StoreTypeName";
            gridColumn3.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn3.HeaderText = "出库类型";
            gridColumn3.Name = "colStoreTypeName";
            gridColumn4.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn4.DataPropertyName = "DealerName";
            gridColumn4.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn4.HeaderText = "往来单位";
            gridColumn4.Name = "colDealerName";
            gridColumn5.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn5.DataPropertyName = "StoreDate";
            gridColumn5.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn5.HeaderText = "出库时间";
            gridColumn5.Name = "colStoreBillDate";
            gridColumn6.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn6.DataPropertyName = "StoreStatusName";
            gridColumn6.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn6.HeaderText = "出库状态";
            gridColumn6.Name = "colStoreBillStatus";
            gridColumn7.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn7.DataPropertyName = "StoreRemark";
            gridColumn7.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn7.HeaderText = "说明";
            gridColumn7.Name = "colStoreRemark";
            this.grdStoreOut.PrimaryGrid.Columns.Add(gridColumn1);
            this.grdStoreOut.PrimaryGrid.Columns.Add(gridColumn2);
            this.grdStoreOut.PrimaryGrid.Columns.Add(gridColumn3);
            this.grdStoreOut.PrimaryGrid.Columns.Add(gridColumn4);
            this.grdStoreOut.PrimaryGrid.Columns.Add(gridColumn5);
            this.grdStoreOut.PrimaryGrid.Columns.Add(gridColumn6);
            this.grdStoreOut.PrimaryGrid.Columns.Add(gridColumn7);
            this.grdStoreOut.PrimaryGrid.MultiSelect = false;
            this.grdStoreOut.PrimaryGrid.NoRowsText = "暂无记录";
            this.grdStoreOut.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grdStoreOut.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.grdStoreOut.PrimaryGrid.ShowRowGridIndex = true;
            this.grdStoreOut.PrimaryGrid.UseAlternateRowStyle = true;
            this.grdStoreOut.PrimaryGrid.VirtualMode = true;
            this.grdStoreOut.Size = new System.Drawing.Size(1054, 186);
            this.grdStoreOut.TabIndex = 10;
            this.grdStoreOut.Text = "superGridControl1";
            this.grdStoreOut.GetRowCellStyle += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridGetRowCellStyleEventArgs>(this.grdStoreOut_GetRowCellStyle);
            this.grdStoreOut.RowActivated += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowActivatedEventArgs>(this.grdStoreOut_RowActivated);
            this.grdStoreOut.RowMouseUp += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowMouseEventArgs>(this.grdStoreOut_RowMouseUp);
            // 
            // grdStoreOutDetail
            // 
            this.grdStoreOutDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdStoreOutDetail.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grdStoreOutDetail.Location = new System.Drawing.Point(14, 326);
            this.grdStoreOutDetail.Name = "grdStoreOutDetail";
            this.grdStoreOutDetail.PrimaryGrid.AllowEdit = false;
            this.grdStoreOutDetail.PrimaryGrid.AutoGenerateColumns = false;
            this.grdStoreOutDetail.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn8.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn8.DataPropertyName = "DetailID";
            gridColumn8.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn8.HeaderText = "序号";
            gridColumn8.Name = "colDetailID";
            gridColumn8.Visible = false;
            gridColumn9.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            gridColumn9.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridColumn9.DataPropertyName = "ProductName";
            gridColumn9.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn9.HeaderText = "药品名称";
            gridColumn9.Name = "colProductName";
            gridColumn10.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn10.DataPropertyName = "BatchNo";
            gridColumn10.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn10.HeaderText = "批号";
            gridColumn10.Name = "colBatchNo";
            gridColumn11.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn11.DataPropertyName = "ProductSpec";
            gridColumn11.HeaderText = "制剂规格";
            gridColumn11.Name = "colProductSpec";
            gridColumn12.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn12.DataPropertyName = "PackageSpec";
            gridColumn12.HeaderText = "包装规格";
            gridColumn12.Name = "colPackageSpec";
            gridColumn13.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn13.DataPropertyName = "ProduceDateString";
            gridColumn13.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn13.HeaderText = "生产日期";
            gridColumn13.Name = "colProduceDate";
            gridColumn14.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn14.DataPropertyName = "ValidateDateString";
            gridColumn14.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn14.HeaderText = "有效期";
            gridColumn14.Name = "colValidateDate";
            gridColumn15.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            gridColumn15.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn15.DataPropertyName = "StructureName";
            gridColumn15.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn15.HeaderText = "货位";
            gridColumn15.Name = "colStructureName";
            gridColumn16.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn16.DataPropertyName = "StructureCode";
            gridColumn16.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn16.HeaderText = "货位编码";
            gridColumn16.Name = "colStructureCode";
            gridColumn17.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn17.DataPropertyName = "Amount";
            gridColumn17.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn17.HeaderText = "数量";
            gridColumn17.Name = "colAmount";
            gridColumn18.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn18.DataPropertyName = "PackagingAmount";
            gridColumn18.HeaderText = "件数";
            gridColumn18.Name = "colPackagingAmount";
            gridColumn18.Visible = false;
            gridColumn19.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn19.DataPropertyName = "StatusName";
            gridColumn19.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn19.HeaderText = "状态";
            gridColumn19.Name = "colStatusName";
            gridColumn20.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            gridColumn20.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn20.DataPropertyName = "ControlTypeString";
            gridColumn20.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn20.HeaderText = "说明";
            gridColumn20.Name = "colControlType";
            gridColumn21.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn21.DataPropertyName = "ProducerName";
            gridColumn21.HeaderText = "生产厂商";
            gridColumn21.Name = "colProducerName";
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn8);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn9);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn10);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn11);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn12);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn13);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn14);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn15);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn16);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn17);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn18);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn19);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn20);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn21);
            this.grdStoreOutDetail.PrimaryGrid.MultiSelect = false;
            this.grdStoreOutDetail.PrimaryGrid.NoRowsText = "暂无记录";
            this.grdStoreOutDetail.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grdStoreOutDetail.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.grdStoreOutDetail.PrimaryGrid.ShowRowGridIndex = true;
            this.grdStoreOutDetail.Size = new System.Drawing.Size(1054, 263);
            this.grdStoreOutDetail.TabIndex = 11;
            this.grdStoreOutDetail.Text = "superGridControl2";
            this.grdStoreOutDetail.RowActivated += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowActivatedEventArgs>(this.grdStoreOutDetail_RowActivated);
            this.grdStoreOutDetail.RowMouseUp += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowMouseEventArgs>(this.grdStoreOutDetail_RowMouseUp);
            // 
            // lblTitle
            // 
            // 
            // 
            // 
            this.lblTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(14, 76);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(75, 23);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "出库单：";
            // 
            // lblDetailTitle
            // 
            // 
            // 
            // 
            this.lblDetailTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDetailTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDetailTitle.Location = new System.Drawing.Point(12, 297);
            this.lblDetailTitle.Name = "lblDetailTitle";
            this.lblDetailTitle.Size = new System.Drawing.Size(116, 23);
            this.lblDetailTitle.TabIndex = 13;
            this.lblDetailTitle.Text = "出库单明细：";
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
            this.btnOut,
            this.swtAutomaticOut,
            this.btnErrorLog});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(1082, 57);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.bar1.TabIndex = 20;
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
            this.imageList.Images.SetKeyName(3, "error.png");
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
            // btnOut
            // 
            this.btnOut.ImageIndex = 2;
            this.btnOut.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnOut.Name = "btnOut";
            this.btnOut.Text = "出库";
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // swtAutomaticOut
            // 
            this.swtAutomaticOut.ButtonHeight = 52;
            this.swtAutomaticOut.ButtonWidth = 106;
            this.swtAutomaticOut.Name = "swtAutomaticOut";
            this.swtAutomaticOut.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.swtAutomaticOut.OffText = "手动出库";
            this.swtAutomaticOut.OffTextColor = System.Drawing.Color.Red;
            this.swtAutomaticOut.OnText = "自动出库";
            this.swtAutomaticOut.SwitchFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.swtAutomaticOut.ValueChanged += new System.EventHandler(this.swtAutomaticOut_ValueChanged);
            // 
            // btnErrorLog
            // 
            this.btnErrorLog.ImageIndex = 3;
            this.btnErrorLog.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnErrorLog.Name = "btnErrorLog";
            this.btnErrorLog.Text = "库存异常信息";
            this.btnErrorLog.Click += new System.EventHandler(this.btnErrorLog_Click);
            // 
            // lblStoreCode
            // 
            this.lblStoreCode.AutoSize = true;
            // 
            // 
            // 
            this.lblStoreCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStoreCode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStoreCode.Location = new System.Drawing.Point(134, 297);
            this.lblStoreCode.Name = "lblStoreCode";
            this.lblStoreCode.Size = new System.Drawing.Size(0, 0);
            this.lblStoreCode.TabIndex = 21;
            // 
            // contextMenuBar1
            // 
            this.contextMenuBar1.AntiAlias = true;
            this.contextMenuBar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMenu});
            this.contextMenuBar1.Location = new System.Drawing.Point(931, 65);
            this.contextMenuBar1.Name = "contextMenuBar1";
            this.contextMenuBar1.Size = new System.Drawing.Size(137, 41);
            this.contextMenuBar1.Stretch = true;
            this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.contextMenuBar1.TabIndex = 22;
            this.contextMenuBar1.TabStop = false;
            this.contextMenuBar1.Text = "手动完成出库";
            // 
            // btnMenu
            // 
            this.btnMenu.AutoExpandOnClick = true;
            this.btnMenu.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.PopupFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMenu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnManuallyComplete});
            this.btnMenu.Text = "手动完成出库";
            // 
            // btnManuallyComplete
            // 
            this.btnManuallyComplete.Name = "btnManuallyComplete";
            this.btnManuallyComplete.Text = "手动完成出库";
            this.btnManuallyComplete.Click += new System.EventHandler(this.btnManuallyComplete_Click);
            // 
            // timerCheck
            // 
            this.timerCheck.Enabled = true;
            this.timerCheck.Interval = 10000;
            this.timerCheck.Tick += new System.EventHandler(this.timerCheck_Tick);
            // 
            // FrmStoreOutMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientSize = new System.Drawing.Size(1082, 601);
            this.Controls.Add(this.contextMenuBar1);
            this.Controls.Add(this.lblStoreCode);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.lblDetailTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grdStoreOutDetail);
            this.Controls.Add(this.grdStoreOut);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmStoreOutMonitoring";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "出库监控";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStoreOutMonitoring_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grdStoreOut;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grdStoreOutDetail;
        private DevComponents.DotNetBar.LabelX lblTitle;
        private DevComponents.DotNetBar.LabelX lblDetailTitle;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnRefresh;
        private DevComponents.DotNetBar.ButtonItem btnOut;
        private System.Windows.Forms.ImageList imageList;
        private DevComponents.DotNetBar.LabelX lblStoreCode;
        private DevComponents.DotNetBar.SwitchButtonItem swtAutomaticOut;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
        private DevComponents.DotNetBar.ButtonItem btnMenu;
        private DevComponents.DotNetBar.ButtonItem btnManuallyComplete;
        private DevComponents.DotNetBar.ButtonItem btnErrorLog;
        private System.Windows.Forms.Timer timerCheck;
    }
}