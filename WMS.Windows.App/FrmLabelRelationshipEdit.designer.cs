namespace WMS.Windows.App
{
    partial class FrmLabelRelationshipEdit
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
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn5 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn6 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLabelRelationshipEdit));
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn7 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn8 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.grdWarehouse = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnSave = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.cbxELabels = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.grdStructures = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdWarehouse
            // 
            this.grdWarehouse.ExpandButtonType = DevComponents.DotNetBar.SuperGrid.ExpandButtonType.None;
            this.grdWarehouse.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grdWarehouse.Location = new System.Drawing.Point(386, 116);
            this.grdWarehouse.Name = "grdWarehouse";
            this.grdWarehouse.PrimaryGrid.AllowRowHeaderResize = true;
            this.grdWarehouse.PrimaryGrid.AllowRowResize = true;
            this.grdWarehouse.PrimaryGrid.AutoGenerateColumns = false;
            this.grdWarehouse.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn5.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.None;
            gridColumn5.DataPropertyName = "LabelCode";
            gridColumn5.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridComboTreeEditControl);
            gridColumn5.HeaderText = "电子标签";
            gridColumn5.Name = "colLabelCode";
            gridColumn5.RenderType = typeof(DevComponents.DotNetBar.SuperGrid.GridComboTreeEditControl);
            gridColumn5.Width = 350;
            gridColumn6.AllowEdit = false;
            gridColumn6.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.None;
            gridColumn6.DataPropertyName = "StructureCode";
            gridColumn6.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn6.HeaderText = "存储单元编号";
            gridColumn6.Name = "colStructureCode";
            this.grdWarehouse.PrimaryGrid.Columns.Add(gridColumn5);
            this.grdWarehouse.PrimaryGrid.Columns.Add(gridColumn6);
            this.grdWarehouse.PrimaryGrid.DefaultRowHeight = 30;
            this.grdWarehouse.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdWarehouse.PrimaryGrid.EnableNoRowsMarkup = true;
            this.grdWarehouse.PrimaryGrid.ExpandButtonType = DevComponents.DotNetBar.SuperGrid.ExpandButtonType.Square;
            this.grdWarehouse.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row;
            this.grdWarehouse.PrimaryGrid.NoRowsText = "暂无记录";
            this.grdWarehouse.PrimaryGrid.PrimaryColumnIndex = 1;
            this.grdWarehouse.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grdWarehouse.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.grdWarehouse.PrimaryGrid.ShowRowGridIndex = true;
            this.grdWarehouse.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled;
            this.grdWarehouse.PrimaryGrid.UseAlternateRowStyle = true;
            this.grdWarehouse.Size = new System.Drawing.Size(454, 395);
            this.grdWarehouse.TabIndex = 18;
            this.grdWarehouse.TouchEnabled = false;
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
            this.btnSave,
            this.btnDelete,
            this.btnClose});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(840, 59);
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
            this.imageList.Images.SetKeyName(4, "door_in.png");
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
            // cbxELabels
            // 
            this.cbxELabels.DisplayMember = "LabelCode";
            this.cbxELabels.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxELabels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxELabels.FormattingEnabled = true;
            this.cbxELabels.ItemHeight = 17;
            this.cbxELabels.Location = new System.Drawing.Point(90, 76);
            this.cbxELabels.Name = "cbxELabels";
            this.cbxELabels.Size = new System.Drawing.Size(143, 23);
            this.cbxELabels.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxELabels.TabIndex = 20;
            this.cbxELabels.ValueMember = "LabelID";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(9, 76);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 22;
            this.labelX1.Text = "电子标签：";
            // 
            // grdStructures
            // 
            this.grdStructures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdStructures.ExpandButtonType = DevComponents.DotNetBar.SuperGrid.ExpandButtonType.None;
            this.grdStructures.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grdStructures.Location = new System.Drawing.Point(0, 116);
            this.grdStructures.Name = "grdStructures";
            this.grdStructures.PrimaryGrid.AllowRowHeaderResize = true;
            this.grdStructures.PrimaryGrid.AllowRowResize = true;
            this.grdStructures.PrimaryGrid.AutoGenerateColumns = false;
            this.grdStructures.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn7.AllowEdit = false;
            gridColumn7.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.None;
            gridColumn7.DataPropertyName = "StructureID";
            gridColumn7.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn7.HeaderText = "序号";
            gridColumn7.Name = "colRowNumber";
            gridColumn7.ResizeMode = DevComponents.DotNetBar.SuperGrid.ColumnResizeMode.None;
            gridColumn7.Visible = false;
            gridColumn7.Width = 50;
            gridColumn8.AllowEdit = false;
            gridColumn8.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.None;
            gridColumn8.DataPropertyName = "StructureCode";
            gridColumn8.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn8.HeaderText = "存储单元编号";
            gridColumn8.Name = "colStructureCode";
            this.grdStructures.PrimaryGrid.Columns.Add(gridColumn7);
            this.grdStructures.PrimaryGrid.Columns.Add(gridColumn8);
            this.grdStructures.PrimaryGrid.DefaultRowHeight = 30;
            this.grdStructures.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdStructures.PrimaryGrid.EnableNoRowsMarkup = true;
            this.grdStructures.PrimaryGrid.ExpandButtonType = DevComponents.DotNetBar.SuperGrid.ExpandButtonType.Square;
            this.grdStructures.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row;
            this.grdStructures.PrimaryGrid.NoRowsText = "暂无记录";
            this.grdStructures.PrimaryGrid.PrimaryColumnIndex = 1;
            this.grdStructures.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grdStructures.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.RowWithCellHighlight;
            this.grdStructures.PrimaryGrid.ShowRowGridIndex = true;
            this.grdStructures.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled;
            this.grdStructures.PrimaryGrid.UseAlternateRowStyle = true;
            this.grdStructures.Size = new System.Drawing.Size(342, 395);
            this.grdStructures.TabIndex = 23;
            this.grdStructures.TouchEnabled = false;
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Location = new System.Drawing.Point(255, 76);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 23);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "添加选中的存储单元";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnClose.ImageIndex = 4;
            this.btnClose.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnClose.Name = "btnClose";
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmLabelRelationshipEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 517);
            this.ControlBox = false;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grdStructures);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cbxELabels);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.grdWarehouse);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLabelRelationshipEdit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "货标关联";
            this.Load += new System.EventHandler(this.FrmRelationshipEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grdWarehouse;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
        private System.Windows.Forms.ImageList imageList;
        private DevComponents.DotNetBar.ButtonItem btnSave;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxELabels;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grdStructures;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.ButtonItem btnClose;

    }
}