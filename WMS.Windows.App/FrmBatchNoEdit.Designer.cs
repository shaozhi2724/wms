namespace WMS.Windows.App
{
    partial class FrmBatchNoEdit
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
            this.panSearch = new DevComponents.DotNetBar.PanelEx();
            this.txtBatchNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtProductName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.lblBatchNo = new DevComponents.DotNetBar.LabelX();
            this.lblProductName = new DevComponents.DotNetBar.LabelX();
            this.panStore = new DevComponents.DotNetBar.ExpandablePanel();
            this.grdDrugs = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.panSearch.SuspendLayout();
            this.panStore.SuspendLayout();
            this.SuspendLayout();
            // 
            // panSearch
            // 
            this.panSearch.CanvasColor = System.Drawing.SystemColors.Control;
            this.panSearch.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panSearch.Controls.Add(this.txtBatchNo);
            this.panSearch.Controls.Add(this.txtProductName);
            this.panSearch.Controls.Add(this.btnSearch);
            this.panSearch.Controls.Add(this.lblBatchNo);
            this.panSearch.Controls.Add(this.lblProductName);
            this.panSearch.DisabledBackColor = System.Drawing.Color.Empty;
            this.panSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSearch.Location = new System.Drawing.Point(0, 0);
            this.panSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panSearch.Name = "panSearch";
            this.panSearch.Padding = new System.Windows.Forms.Padding(0, 46, 0, 0);
            this.panSearch.Size = new System.Drawing.Size(942, 56);
            this.panSearch.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panSearch.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panSearch.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panSearch.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panSearch.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panSearch.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panSearch.Style.GradientAngle = 90;
            this.panSearch.TabIndex = 0;
            // 
            // txtBatchNo
            // 
            // 
            // 
            // 
            this.txtBatchNo.Border.Class = "TextBoxBorder";
            this.txtBatchNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBatchNo.Location = new System.Drawing.Point(393, 14);
            this.txtBatchNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.PreventEnterBeep = true;
            this.txtBatchNo.Size = new System.Drawing.Size(191, 27);
            this.txtBatchNo.TabIndex = 2;
            // 
            // txtProductName
            // 
            // 
            // 
            // 
            this.txtProductName.Border.Class = "TextBoxBorder";
            this.txtProductName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProductName.Location = new System.Drawing.Point(93, 14);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PreventEnterBeep = true;
            this.txtProductName.Size = new System.Drawing.Size(191, 27);
            this.txtProductName.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Location = new System.Drawing.Point(626, 14);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 29);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "查询";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblBatchNo
            // 
            this.lblBatchNo.AutoSize = true;
            // 
            // 
            // 
            this.lblBatchNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblBatchNo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBatchNo.Location = new System.Drawing.Point(329, 14);
            this.lblBatchNo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblBatchNo.Name = "lblBatchNo";
            this.lblBatchNo.Size = new System.Drawing.Size(54, 24);
            this.lblBatchNo.TabIndex = 2;
            this.lblBatchNo.Text = "批号：";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            // 
            // 
            // 
            this.lblProductName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblProductName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblProductName.Location = new System.Drawing.Point(19, 14);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(85, 24);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "药品名称：";
            // 
            // panStore
            // 
            this.panStore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panStore.CanvasColor = System.Drawing.SystemColors.Control;
            this.panStore.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panStore.Controls.Add(this.grdDrugs);
            this.panStore.DisabledBackColor = System.Drawing.Color.Empty;
            this.panStore.ExpandButtonVisible = false;
            this.panStore.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panStore.HideControlsWhenCollapsed = true;
            this.panStore.Location = new System.Drawing.Point(0, 63);
            this.panStore.Name = "panStore";
            this.panStore.Size = new System.Drawing.Size(942, 460);
            this.panStore.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panStore.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panStore.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panStore.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panStore.Style.GradientAngle = 90;
            this.panStore.TabIndex = 23;
            this.panStore.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panStore.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panStore.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panStore.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panStore.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panStore.TitleStyle.GradientAngle = 90;
            this.panStore.TitleText = "在库药品查询结果";
            // 
            // grdDrugs
            // 
            this.grdDrugs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDrugs.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grdDrugs.Location = new System.Drawing.Point(0, 26);
            this.grdDrugs.Name = "grdDrugs";
            this.grdDrugs.PrimaryGrid.AllowEdit = false;
            this.grdDrugs.PrimaryGrid.AutoGenerateColumns = false;
            this.grdDrugs.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.DisplayedCells;
            gridColumn1.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn1.DataPropertyName = "CargoSpaceStoreDetailID";
            gridColumn1.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn1.HeaderText = "序号";
            gridColumn1.Name = "colCargoSpaceStoreDetailID";
            gridColumn1.Visible = false;
            gridColumn2.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn2.DataPropertyName = "StructureCode";
            gridColumn2.HeaderText = "货位编号";
            gridColumn2.Name = "colStructureCode";
            gridColumn3.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn3.DataPropertyName = "StructureName";
            gridColumn3.HeaderText = "货位名称";
            gridColumn3.Name = "colStructureName";
            gridColumn3.Visible = false;
            gridColumn4.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn4.DataPropertyName = "StructureName";
            gridColumn4.HeaderText = "货位位置";
            gridColumn4.Name = "colStructureLocation";
            gridColumn5.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn5.DataPropertyName = "ProductCode";
            gridColumn5.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn5.HeaderText = "药品编号";
            gridColumn5.Name = "colProductCode";
            gridColumn6.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn6.DataPropertyName = "ProductName";
            gridColumn6.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn6.HeaderText = "药品名称";
            gridColumn6.Name = "colProductName";
            gridColumn6.Width = 200;
            gridColumn7.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn7.DataPropertyName = "ProducerName";
            gridColumn7.HeaderText = "生产厂家";
            gridColumn7.Name = "colProducerName";
            gridColumn8.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn8.DataPropertyName = "ProductSpec";
            gridColumn8.HeaderText = "制剂规格";
            gridColumn8.Name = "colProductSpec";
            gridColumn8.Width = 200;
            gridColumn9.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn9.DataPropertyName = "PackageSpec";
            gridColumn9.HeaderText = "包装规格";
            gridColumn9.Name = "colPackageSpec";
            gridColumn10.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn10.DataPropertyName = "ProductBatchNumber";
            gridColumn10.HeaderText = "批号";
            gridColumn10.Name = "colBatchNo";
            gridColumn11.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn11.DataPropertyName = "PackagingProportion";
            gridColumn11.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn11.HeaderText = "包装比例";
            gridColumn11.Name = "colPackagingProportion";
            gridColumn12.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn12.DataPropertyName = "ProductBarCode";
            gridColumn12.HeaderText = "药品条码";
            gridColumn12.Name = "colProductBarCode";
            gridColumn13.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn13.DataPropertyName = "ProductionDate";
            gridColumn13.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl);
            gridColumn13.HeaderText = "生产日期";
            gridColumn13.Name = "colProductionDate";
            gridColumn14.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn14.DataPropertyName = "ProductValidDate";
            gridColumn14.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl);
            gridColumn14.HeaderText = "有效期至";
            gridColumn14.Name = "colProductValidDate";
            gridColumn15.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn15.DataPropertyName = "StockCondition";
            gridColumn15.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn15.HeaderText = "储存条件";
            gridColumn15.Name = "colStockCondition";
            gridColumn16.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn16.DataPropertyName = "PhysicType";
            gridColumn16.HeaderText = "剂型";
            gridColumn16.Name = "colPhysicType";
            gridColumn17.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn17.DataPropertyName = "ProductAmount";
            gridColumn17.HeaderText = "库存数量";
            gridColumn17.Name = "colProductAmount";
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn1);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn2);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn3);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn4);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn5);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn6);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn7);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn8);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn9);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn10);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn11);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn12);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn13);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn14);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn15);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn16);
            this.grdDrugs.PrimaryGrid.Columns.Add(gridColumn17);
            this.grdDrugs.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row;
            this.grdDrugs.PrimaryGrid.MultiSelect = false;
            this.grdDrugs.PrimaryGrid.NoRowsText = "暂无记录";
            this.grdDrugs.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grdDrugs.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.grdDrugs.PrimaryGrid.ShowRowGridIndex = true;
            this.grdDrugs.PrimaryGrid.UseAlternateRowStyle = true;
            this.grdDrugs.Size = new System.Drawing.Size(942, 434);
            this.grdDrugs.TabIndex = 13;
            this.grdDrugs.RowDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs>(this.grdDrugs_RowDoubleClick);
            // 
            // FrmBatchNoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 522);
            this.Controls.Add(this.panStore);
            this.Controls.Add(this.panSearch);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBatchNoEdit";
            this.Text = "库存管理";
            this.Load += new System.EventHandler(this.FrmBatchNoEdit_Load);
            this.panSearch.ResumeLayout(false);
            this.panSearch.PerformLayout();
            this.panStore.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panSearch;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.LabelX lblBatchNo;
        private DevComponents.DotNetBar.LabelX lblProductName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBatchNo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProductName;
        private DevComponents.DotNetBar.ExpandablePanel panStore;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grdDrugs;
    }
}