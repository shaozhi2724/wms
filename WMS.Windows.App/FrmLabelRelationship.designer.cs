namespace WMS.Windows.App
{
    partial class FrmLabelRelationship
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLabelRelationship));
            this.grdWarehouse = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnRefresh = new DevComponents.DotNetBar.ButtonItem();
            this.btnSave = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.btnRelationshipEdit = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdWarehouse
            // 
            this.grdWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdWarehouse.ExpandButtonType = DevComponents.DotNetBar.SuperGrid.ExpandButtonType.None;
            this.grdWarehouse.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grdWarehouse.Location = new System.Drawing.Point(-1, 57);
            this.grdWarehouse.Name = "grdWarehouse";
            this.grdWarehouse.PrimaryGrid.AllowRowHeaderResize = true;
            this.grdWarehouse.PrimaryGrid.AllowRowResize = true;
            this.grdWarehouse.PrimaryGrid.AutoGenerateColumns = false;
            this.grdWarehouse.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn1.AllowEdit = false;
            gridColumn1.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.None;
            gridColumn1.DataPropertyName = "StructureID";
            gridColumn1.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn1.HeaderText = "序号";
            gridColumn1.Name = "";
            gridColumn1.ResizeMode = DevComponents.DotNetBar.SuperGrid.ColumnResizeMode.None;
            gridColumn1.Visible = false;
            gridColumn1.Width = 50;
            gridColumn2.AllowEdit = false;
            gridColumn2.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.None;
            gridColumn2.DataPropertyName = "StructureCode";
            gridColumn2.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn2.HeaderText = "存储单元编号";
            gridColumn2.Name = "";
            gridColumn3.AllowEdit = false;
            gridColumn3.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.None;
            gridColumn3.DataPropertyName = "StructureName";
            gridColumn3.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn3.HeaderText = "仓库名称";
            gridColumn3.Name = "";
            gridColumn4.AllowEdit = false;
            gridColumn4.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.None;
            gridColumn4.DataPropertyName = "StructureType";
            gridColumn4.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn4.HeaderText = "存储环境";
            gridColumn4.Name = "";
            gridColumn4.Width = 60;
            gridColumn5.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.None;
            gridColumn5.DataPropertyName = "LabelCode";
            gridColumn5.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridComboTreeEditControl);
            gridColumn5.HeaderText = "电子标签";
            gridColumn5.Name = "colLabelCode";
            gridColumn5.RenderType = typeof(DevComponents.DotNetBar.SuperGrid.GridComboTreeEditControl);
            gridColumn5.Width = 350;
            this.grdWarehouse.PrimaryGrid.Columns.Add(gridColumn1);
            this.grdWarehouse.PrimaryGrid.Columns.Add(gridColumn2);
            this.grdWarehouse.PrimaryGrid.Columns.Add(gridColumn3);
            this.grdWarehouse.PrimaryGrid.Columns.Add(gridColumn4);
            this.grdWarehouse.PrimaryGrid.Columns.Add(gridColumn5);
            this.grdWarehouse.PrimaryGrid.DefaultRowHeight = 30;
            this.grdWarehouse.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdWarehouse.PrimaryGrid.EnableNoRowsMarkup = true;
            this.grdWarehouse.PrimaryGrid.ExpandButtonType = DevComponents.DotNetBar.SuperGrid.ExpandButtonType.Square;
            this.grdWarehouse.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row;
            this.grdWarehouse.PrimaryGrid.MultiSelect = false;
            this.grdWarehouse.PrimaryGrid.NoRowsText = "暂无记录";
            this.grdWarehouse.PrimaryGrid.PrimaryColumnIndex = 1;
            this.grdWarehouse.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grdWarehouse.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.grdWarehouse.PrimaryGrid.ShowRowGridIndex = true;
            this.grdWarehouse.PrimaryGrid.ShowTreeButtons = true;
            this.grdWarehouse.PrimaryGrid.ShowTreeLines = true;
            this.grdWarehouse.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled;
            this.grdWarehouse.PrimaryGrid.UseAlternateRowStyle = true;
            this.grdWarehouse.Size = new System.Drawing.Size(871, 366);
            this.grdWarehouse.TabIndex = 18;
            this.grdWarehouse.TouchEnabled = false;
            this.grdWarehouse.BeginEdit += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridEditEventArgs>(this.grdWarehouse_BeginEdit);
            this.grdWarehouse.CloseEdit += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCloseEditEventArgs>(this.grdWarehouse_CloseEdit);
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.bar1.Images = this.imageList;
            this.bar1.ImageSize = DevComponents.DotNetBar.eBarImageSize.Large;
            this.bar1.ImagesLarge = this.imageList;
            this.bar1.ImagesMedium = this.imageList;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnRefresh,
            this.btnSave,
            this.btnDelete,
            this.btnRelationshipEdit});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(870, 59);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.bar1.TabIndex = 19;
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
            this.imageList.Images.SetKeyName(3, "edit.png");
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
            // btnSave
            // 
            this.btnSave.ImageIndex = 2;
            this.btnSave.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageIndex = 1;
            this.btnDelete.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRelationshipEdit
            // 
            this.btnRelationshipEdit.ImageIndex = 3;
            this.btnRelationshipEdit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnRelationshipEdit.Name = "btnRelationshipEdit";
            this.btnRelationshipEdit.Text = "反向关联";
            this.btnRelationshipEdit.Click += new System.EventHandler(this.btnRelationshipEdit_Click);
            // 
            // FrmLabelRelationship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 435);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.grdWarehouse);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLabelRelationship";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "货标关联";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLabelRelationship_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grdWarehouse;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnRefresh;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
        private System.Windows.Forms.ImageList imageList;
        private DevComponents.DotNetBar.ButtonItem btnSave;
        private DevComponents.DotNetBar.ButtonItem btnRelationshipEdit;

    }
}