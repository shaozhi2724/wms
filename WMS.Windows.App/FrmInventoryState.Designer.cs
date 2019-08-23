namespace WMS.Windows.App
{
    partial class FrmInventoryState
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
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn17 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn18 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn19 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn20 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn21 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventoryState));
            this.lblDetailTitle = new DevComponents.DotNetBar.LabelX();
            this.grdInventoryDetail = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnRefresh = new DevComponents.DotNetBar.ButtonItem();
            this.btnPrint = new DevComponents.DotNetBar.ButtonItem();
            this.btnGenerate = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDetailTitle
            // 
            // 
            // 
            // 
            this.lblDetailTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDetailTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDetailTitle.Location = new System.Drawing.Point(2, 84);
            this.lblDetailTitle.Name = "lblDetailTitle";
            this.lblDetailTitle.Size = new System.Drawing.Size(126, 23);
            this.lblDetailTitle.TabIndex = 20;
            this.lblDetailTitle.Text = "货位详情：";
            // 
            // grdInventoryDetail
            // 
            this.grdInventoryDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdInventoryDetail.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grdInventoryDetail.Location = new System.Drawing.Point(2, 120);
            this.grdInventoryDetail.Name = "grdInventoryDetail";
            this.grdInventoryDetail.PrimaryGrid.AllowEdit = false;
            this.grdInventoryDetail.PrimaryGrid.AutoGenerateColumns = false;
            this.grdInventoryDetail.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn17.DataPropertyName = "CargoSpaceStoreDetailID";
            gridColumn17.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn17.HeaderText = "序号";
            gridColumn17.Name = "colDetailID";
            gridColumn17.Visible = false;
            gridColumn18.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn18.DataPropertyName = "StructureCode";
            gridColumn18.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn18.HeaderText = "货位编码";
            gridColumn18.Name = "colStructureCode";
            gridColumn19.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            gridColumn19.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn19.DataPropertyName = "StructureName";
            gridColumn19.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn19.HeaderText = "货位";
            gridColumn19.Name = "colStructureName";
            gridColumn20.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            gridColumn20.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn20.DataPropertyName = "AreaType";
            gridColumn20.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn20.HeaderText = "货区类型";
            gridColumn20.Name = "colAreaType";
            gridColumn21.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            gridColumn21.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridColumn21.DataPropertyName = "ProductName";
            gridColumn21.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn21.HeaderText = "药品名称";
            gridColumn21.Name = "colProductName";
            gridColumn22.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn22.DataPropertyName = "ProductBatchNumber";
            gridColumn22.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn22.HeaderText = "批号";
            gridColumn22.Name = "colBatchNo";
            gridColumn23.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn23.DataPropertyName = "ProductionDate";
            gridColumn23.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl);
            gridColumn23.HeaderText = "生产日期";
            gridColumn23.Name = "colProduceDate";
            gridColumn24.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn24.DataPropertyName = "ProductValidDate";
            gridColumn24.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl);
            gridColumn24.HeaderText = "有效期至";
            gridColumn24.Name = "colValidateDate";
            gridColumn25.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn25.DataPropertyName = "ProductAmount";
            gridColumn25.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn25.HeaderText = "数量";
            gridColumn25.Name = "colAmount";
            gridColumn26.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            gridColumn26.DataPropertyName = "StockCondition";
            gridColumn26.HeaderText = "存储条件";
            gridColumn26.Name = "colStockCondition";
            gridColumn27.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn27.DataPropertyName = "ProductSpec";
            gridColumn27.HeaderText = "制剂规格";
            gridColumn27.Name = "colProductSpec";
            gridColumn28.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn28.DataPropertyName = "PackageSpec";
            gridColumn28.HeaderText = "包装规格";
            gridColumn28.Name = "colPackageSpec";
            gridColumn29.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn29.DataPropertyName = "DosageForm";
            gridColumn29.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn29.HeaderText = "剂型";
            gridColumn29.Name = "colDosageForm";
            gridColumn30.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn30.DataPropertyName = "PackagingSpecification";
            gridColumn30.HeaderText = "包装规格";
            gridColumn30.Name = "colPackagingSpecification";
            gridColumn31.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            gridColumn31.DataPropertyName = "PackagingProportion";
            gridColumn31.HeaderText = "包装比例";
            gridColumn31.Name = "colPackagingProportion";
            gridColumn32.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn32.DataPropertyName = "ProducerName";
            gridColumn32.HeaderText = "生产厂商";
            gridColumn32.Name = "colProducerName";
            this.grdInventoryDetail.PrimaryGrid.Columns.Add(gridColumn17);
            this.grdInventoryDetail.PrimaryGrid.Columns.Add(gridColumn18);
            this.grdInventoryDetail.PrimaryGrid.Columns.Add(gridColumn19);
            this.grdInventoryDetail.PrimaryGrid.Columns.Add(gridColumn20);
            this.grdInventoryDetail.PrimaryGrid.Columns.Add(gridColumn21);
            this.grdInventoryDetail.PrimaryGrid.Columns.Add(gridColumn22);
            this.grdInventoryDetail.PrimaryGrid.Columns.Add(gridColumn23);
            this.grdInventoryDetail.PrimaryGrid.Columns.Add(gridColumn24);
            this.grdInventoryDetail.PrimaryGrid.Columns.Add(gridColumn25);
            this.grdInventoryDetail.PrimaryGrid.Columns.Add(gridColumn26);
            this.grdInventoryDetail.PrimaryGrid.Columns.Add(gridColumn27);
            this.grdInventoryDetail.PrimaryGrid.Columns.Add(gridColumn28);
            this.grdInventoryDetail.PrimaryGrid.Columns.Add(gridColumn29);
            this.grdInventoryDetail.PrimaryGrid.Columns.Add(gridColumn30);
            this.grdInventoryDetail.PrimaryGrid.Columns.Add(gridColumn31);
            this.grdInventoryDetail.PrimaryGrid.Columns.Add(gridColumn32);
            this.grdInventoryDetail.PrimaryGrid.MultiSelect = false;
            this.grdInventoryDetail.PrimaryGrid.NoRowsText = "暂无记录";
            this.grdInventoryDetail.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grdInventoryDetail.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.grdInventoryDetail.PrimaryGrid.ShowRowGridIndex = true;
            this.grdInventoryDetail.Size = new System.Drawing.Size(1240, 427);
            this.grdInventoryDetail.TabIndex = 18;
            this.grdInventoryDetail.Text = "superGridControl2";
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
            this.btnGenerate,
            this.btnPrint});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(1240, 63);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.bar1.TabIndex = 25;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
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
            // btnPrint
            // 
            this.btnPrint.ImageIndex = 3;
            this.btnPrint.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Text = "打印";
            this.btnPrint.Visible = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.ImageIndex = 2;
            this.btnGenerate.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Text = "盘库";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // FrmInventoryState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 546);
            this.Controls.Add(this.lblDetailTitle);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.grdInventoryDetail);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmInventoryState";
            this.Text = "货位详情";
            this.Load += new System.EventHandler(this.FrmInventoryState_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblDetailTitle;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grdInventoryDetail;
        private System.Windows.Forms.ImageList imageList;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnRefresh;
        private DevComponents.DotNetBar.ButtonItem btnPrint;
        private DevComponents.DotNetBar.ButtonItem btnGenerate;
    }
}