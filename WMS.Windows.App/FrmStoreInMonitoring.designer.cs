namespace WMS.Windows.App
{
    partial class FrmStoreInMonitoring
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
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn22 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn23 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn24 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn25 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn26 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn27 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn28 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn29 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn30 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn31 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn32 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn33 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn34 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn35 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn36 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn37 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn38 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn39 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn40 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn41 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn42 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStoreInMonitoring));
            this.grdStoreOut = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.grdStoreOutDetail = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.lblTitle = new DevComponents.DotNetBar.LabelX();
            this.lblDetailTitle = new DevComponents.DotNetBar.LabelX();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnRefresh = new DevComponents.DotNetBar.ButtonItem();
            this.btnIn = new DevComponents.DotNetBar.ButtonItem();
            this.btnPrint = new DevComponents.DotNetBar.ButtonItem();
            this.lblStoreCode = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
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
            gridColumn22.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            gridColumn22.DataPropertyName = "StoreID";
            gridColumn22.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn22.HeaderText = "序号";
            gridColumn22.Name = "colStoreID";
            gridColumn22.Visible = false;
            gridColumn23.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn23.DataPropertyName = "StoreCode";
            gridColumn23.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn23.HeaderText = "入库单编号";
            gridColumn23.Name = "colStoreCode";
            gridColumn24.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn24.DataPropertyName = "StoreTypeName";
            gridColumn24.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn24.HeaderText = "入库类型";
            gridColumn24.Name = "colStoreTypeName";
            gridColumn25.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn25.DataPropertyName = "DealerName";
            gridColumn25.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn25.HeaderText = "往来单位";
            gridColumn25.Name = "colDealerName";
            gridColumn26.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn26.DataPropertyName = "";
            gridColumn26.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn26.HeaderText = "入库时间";
            gridColumn26.Name = "colStoreBillDate";
            gridColumn27.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn27.DataPropertyName = "StoreStatusName";
            gridColumn27.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn27.HeaderText = "入库状态";
            gridColumn27.Name = "colStoreBillStatus";
            gridColumn28.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn28.DataPropertyName = "StoreRemark";
            gridColumn28.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn28.HeaderText = "说明";
            gridColumn28.Name = "colStoreRemark";
            this.grdStoreOut.PrimaryGrid.Columns.Add(gridColumn22);
            this.grdStoreOut.PrimaryGrid.Columns.Add(gridColumn23);
            this.grdStoreOut.PrimaryGrid.Columns.Add(gridColumn24);
            this.grdStoreOut.PrimaryGrid.Columns.Add(gridColumn25);
            this.grdStoreOut.PrimaryGrid.Columns.Add(gridColumn26);
            this.grdStoreOut.PrimaryGrid.Columns.Add(gridColumn27);
            this.grdStoreOut.PrimaryGrid.Columns.Add(gridColumn28);
            this.grdStoreOut.PrimaryGrid.MultiSelect = false;
            this.grdStoreOut.PrimaryGrid.NoRowsText = "暂无记录";
            this.grdStoreOut.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grdStoreOut.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.grdStoreOut.PrimaryGrid.ShowRowGridIndex = true;
            this.grdStoreOut.PrimaryGrid.UseAlternateRowStyle = true;
            this.grdStoreOut.Size = new System.Drawing.Size(1036, 186);
            this.grdStoreOut.TabIndex = 10;
            this.grdStoreOut.Text = "superGridControl1";
            this.grdStoreOut.RowActivated += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowActivatedEventArgs>(this.grdStoreOut_RowActivated);
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
            gridColumn29.DataPropertyName = "DetailID";
            gridColumn29.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn29.HeaderText = "序号";
            gridColumn29.Name = "colDetailID";
            gridColumn29.Visible = false;
            gridColumn30.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            gridColumn30.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridColumn30.DataPropertyName = "ProductName";
            gridColumn30.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn30.HeaderText = "药品名称";
            gridColumn30.Name = "colProductName";
            gridColumn31.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn31.DataPropertyName = "ProductSpec";
            gridColumn31.HeaderText = "制剂规格";
            gridColumn31.Name = "colProductSpec";
            gridColumn32.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn32.DataPropertyName = "PackageSpec";
            gridColumn32.HeaderText = "包装规格";
            gridColumn32.Name = "colPackageSpec";
            gridColumn33.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn33.DataPropertyName = "BatchNo";
            gridColumn33.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn33.HeaderText = "批号";
            gridColumn33.Name = "colBatchNo";
            gridColumn34.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn34.DataPropertyName = "ProducerName";
            gridColumn34.HeaderText = "生产厂商";
            gridColumn34.Name = "colProducerName";
            gridColumn35.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn35.DataPropertyName = "ProduceDateString";
            gridColumn35.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn35.HeaderText = "生产日期";
            gridColumn35.Name = "colProduceDate";
            gridColumn36.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn36.DataPropertyName = "ValidateDateString";
            gridColumn36.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn36.HeaderText = "有效期";
            gridColumn36.Name = "colValidateDate";
            gridColumn37.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            gridColumn37.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn37.DataPropertyName = "StructureName";
            gridColumn37.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn37.HeaderText = "货位";
            gridColumn37.Name = "colStructureName";
            gridColumn38.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn38.DataPropertyName = "StructureCode";
            gridColumn38.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn38.HeaderText = "货位编码";
            gridColumn38.Name = "colStructureCode";
            gridColumn39.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn39.DataPropertyName = "Amount";
            gridColumn39.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn39.HeaderText = "数量";
            gridColumn39.Name = "colAmount";
            gridColumn40.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn40.DataPropertyName = "PackagingAmount";
            gridColumn40.HeaderText = "件数";
            gridColumn40.Name = "colPackagingAmount";
            gridColumn40.Visible = false;
            gridColumn41.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn41.DataPropertyName = "StatusName";
            gridColumn41.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn41.HeaderText = "状态";
            gridColumn41.Name = "colStatusName";
            gridColumn42.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            gridColumn42.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn42.DataPropertyName = "ControlTypeString";
            gridColumn42.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn42.HeaderText = "说明";
            gridColumn42.Name = "colControlType";
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn29);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn30);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn31);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn32);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn33);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn34);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn35);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn36);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn37);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn38);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn39);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn40);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn41);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn42);
            this.grdStoreOutDetail.PrimaryGrid.MultiSelect = false;
            this.grdStoreOutDetail.PrimaryGrid.NoRowsText = "暂无记录";
            this.grdStoreOutDetail.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grdStoreOutDetail.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.grdStoreOutDetail.PrimaryGrid.ShowRowGridIndex = true;
            this.grdStoreOutDetail.Size = new System.Drawing.Size(1036, 208);
            this.grdStoreOutDetail.TabIndex = 11;
            this.grdStoreOutDetail.Text = "superGridControl2";
            this.grdStoreOutDetail.RowActivated += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowActivatedEventArgs>(this.grdStoreOutDetail_RowActivated);
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
            this.lblTitle.Size = new System.Drawing.Size(91, 23);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "入库单：";
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
            this.lblDetailTitle.Text = "入库单明细：";
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
            this.btnIn,
            this.btnPrint});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(1064, 61);
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
            // btnIn
            // 
            this.btnIn.ImageIndex = 2;
            this.btnIn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnIn.Name = "btnIn";
            this.btnIn.Text = "入库";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.ImageIndex = 3;
            this.btnPrint.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Text = "打印";
            this.btnPrint.Tooltip = "打印货物码";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            // FrmStoreInMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientSize = new System.Drawing.Size(1064, 546);
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
            this.Name = "FrmStoreInMonitoring";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "入库监控";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStoreInMonitoring_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
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
        private DevComponents.DotNetBar.LabelX lblStoreCode;
        private System.Windows.Forms.ImageList imageList;
        private DevComponents.DotNetBar.ButtonItem btnIn;
        private DevComponents.DotNetBar.ButtonItem btnPrint;
    }
}