namespace WMS.Windows.App
{
    partial class FrmWarehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWarehouse));
            this.grdWarehouse = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnRefresh = new DevComponents.DotNetBar.ButtonItem();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnEdit = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.btnStatus = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdWarehouse
            // 
            this.grdWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdWarehouse.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grdWarehouse.Location = new System.Drawing.Point(1, 65);
            this.grdWarehouse.Name = "grdWarehouse";
            this.grdWarehouse.PrimaryGrid.AllowEdit = false;
            this.grdWarehouse.PrimaryGrid.AutoGenerateColumns = false;
            this.grdWarehouse.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn1.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridColumn1.DataPropertyName = "WarehouseID";
            gridColumn1.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn1.HeaderText = "序号";
            gridColumn1.Name = "colRowNumber";
            gridColumn1.Visible = false;
            gridColumn2.DataPropertyName = "WarehouseCode";
            gridColumn2.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn2.HeaderText = "仓库编号";
            gridColumn2.Name = "colWarehouseCode";
            gridColumn3.DataPropertyName = "WarehouseName";
            gridColumn3.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn3.HeaderText = "仓库名称";
            gridColumn3.Name = "colWarehouseName";
            gridColumn3.Width = 150;
            gridColumn4.DataPropertyName = "WarehousePurpose";
            gridColumn4.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn4.HeaderText = "仓库用途";
            gridColumn4.Name = "colWarehousePurpose";
            gridColumn5.DataPropertyName = "WarehouseType";
            gridColumn5.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn5.HeaderText = "存储环境";
            gridColumn5.Name = "colWarehouseType";
            gridColumn6.DataPropertyName = "IsActive";
            gridColumn6.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            gridColumn6.HeaderText = "是否启用";
            gridColumn6.Name = "colIsActive";
            gridColumn6.RenderType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            gridColumn7.DataPropertyName = "WarehousePhone";
            gridColumn7.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn7.HeaderText = "仓库电话";
            gridColumn7.Name = "colWarehousePhone";
            gridColumn8.DataPropertyName = "WarehouseLeader";
            gridColumn8.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn8.HeaderText = "负责人";
            gridColumn8.Name = "colWarehouseLeader";
            gridColumn9.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            gridColumn9.DataPropertyName = "WarehouseRemark";
            gridColumn9.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn9.HeaderText = "备注";
            gridColumn9.Name = "colWarehouseRemark";
            this.grdWarehouse.PrimaryGrid.Columns.Add(gridColumn1);
            this.grdWarehouse.PrimaryGrid.Columns.Add(gridColumn2);
            this.grdWarehouse.PrimaryGrid.Columns.Add(gridColumn3);
            this.grdWarehouse.PrimaryGrid.Columns.Add(gridColumn4);
            this.grdWarehouse.PrimaryGrid.Columns.Add(gridColumn5);
            this.grdWarehouse.PrimaryGrid.Columns.Add(gridColumn6);
            this.grdWarehouse.PrimaryGrid.Columns.Add(gridColumn7);
            this.grdWarehouse.PrimaryGrid.Columns.Add(gridColumn8);
            this.grdWarehouse.PrimaryGrid.Columns.Add(gridColumn9);
            this.grdWarehouse.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.grdWarehouse.PrimaryGrid.DefaultVisualStyles.CellStyles.Empty.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.grdWarehouse.PrimaryGrid.DefaultVisualStyles.CellStyles.Selected.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.grdWarehouse.PrimaryGrid.FocusCuesEnabled = false;
            this.grdWarehouse.PrimaryGrid.GroupRowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.Never;
            this.grdWarehouse.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row;
            this.grdWarehouse.PrimaryGrid.MultiSelect = false;
            this.grdWarehouse.PrimaryGrid.NoRowsText = "暂无记录";
            this.grdWarehouse.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grdWarehouse.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.grdWarehouse.PrimaryGrid.ShowRowGridIndex = true;
            this.grdWarehouse.PrimaryGrid.ShowRowInfo = false;
            this.grdWarehouse.PrimaryGrid.ShowWhitespaceRowLines = false;
            this.grdWarehouse.PrimaryGrid.UseAlternateRowStyle = true;
            this.grdWarehouse.ShowCustomFilterHelp = false;
            this.grdWarehouse.Size = new System.Drawing.Size(848, 358);
            this.grdWarehouse.TabIndex = 18;
            this.grdWarehouse.TouchEnabled = false;
            this.grdWarehouse.RowActivated += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowActivatedEventArgs>(this.grdWarehouse_RowActivated);
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.bar1.Images = this.imageList;
            this.bar1.ImagesLarge = this.imageList;
            this.bar1.ImagesMedium = this.imageList;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnRefresh,
            this.btnAdd,
            this.btnEdit,
            this.btnDelete,
            this.btnStatus});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(859, 63);
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
            this.imageList.Images.SetKeyName(3, "add.png");
            this.imageList.Images.SetKeyName(4, "edit.png");
            this.imageList.Images.SetKeyName(5, "Stop.png");
            this.imageList.Images.SetKeyName(6, "check.png");
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
            // btnAdd
            // 
            this.btnAdd.ImageIndex = 3;
            this.btnAdd.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ImageIndex = 4;
            this.btnEdit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "修改";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageIndex = 1;
            this.btnDelete.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.ImageIndex = 5;
            this.btnStatus.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Text = "启/停用";
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // FrmWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 435);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.grdWarehouse);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmWarehouse";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "仓库信息";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmWarehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grdWarehouse;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnRefresh;
        private DevComponents.DotNetBar.ButtonItem btnEdit;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
        private System.Windows.Forms.ImageList imageList;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.ButtonItem btnStatus;

    }
}