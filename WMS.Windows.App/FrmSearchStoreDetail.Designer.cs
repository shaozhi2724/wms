namespace WMS.Windows.App
{
    partial class FrmSearchStoreDetail
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
            this.grdDrugs = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtProductCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // grdDrugs
            // 
            this.grdDrugs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDrugs.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grdDrugs.Location = new System.Drawing.Point(0, 41);
            this.grdDrugs.Name = "grdDrugs";
            this.grdDrugs.PrimaryGrid.AllowEdit = false;
            this.grdDrugs.PrimaryGrid.AutoGenerateColumns = false;
            this.grdDrugs.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.DisplayedCells;
            gridColumn1.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn1.DataPropertyName = "ProductID";
            gridColumn1.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn1.HeaderText = "序号";
            gridColumn1.Name = "colProductID";
            gridColumn1.Visible = false;
            gridColumn2.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn2.DataPropertyName = "ProductCode";
            gridColumn2.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn2.HeaderText = "药品编号";
            gridColumn2.Name = "colProductCode";
            gridColumn3.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn3.DataPropertyName = "ProductName";
            gridColumn3.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn3.HeaderText = "药品名称";
            gridColumn3.Name = "colProductName";
            gridColumn3.Width = 200;
            gridColumn4.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn4.DataPropertyName = "ProducerName";
            gridColumn4.HeaderText = "生产厂家";
            gridColumn4.Name = "colProducerName";
            gridColumn5.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn5.DataPropertyName = "PackageSpec";
            gridColumn5.HeaderText = "包装规格";
            gridColumn5.Name = "colPackageSpec";
            gridColumn6.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn6.DataPropertyName = "ProductBatchNumber";
            gridColumn6.HeaderText = "批号";
            gridColumn6.Name = "colBatchNo";
            gridColumn7.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn7.DataPropertyName = "ProductionDate";
            gridColumn7.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl);
            gridColumn7.HeaderText = "生产日期";
            gridColumn7.Name = "colProductionDate";
            gridColumn8.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn8.DataPropertyName = "ProductValidDate";
            gridColumn8.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl);
            gridColumn8.HeaderText = "有效期至";
            gridColumn8.Name = "colProductValidDate";
            gridColumn9.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn9.DataPropertyName = "PhysicType";
            gridColumn9.HeaderText = "剂型";
            gridColumn9.Name = "colPhysicType";
            gridColumn10.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn10.DataPropertyName = "ProductAmount";
            gridColumn10.HeaderText = "库存数量";
            gridColumn10.Name = "colProductAmount";
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
            this.grdDrugs.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row;
            this.grdDrugs.PrimaryGrid.MultiSelect = false;
            this.grdDrugs.PrimaryGrid.NoRowsText = "暂无记录";
            this.grdDrugs.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grdDrugs.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.grdDrugs.PrimaryGrid.ShowRowGridIndex = true;
            this.grdDrugs.PrimaryGrid.UseAlternateRowStyle = true;
            this.grdDrugs.Size = new System.Drawing.Size(654, 376);
            this.grdDrugs.TabIndex = 14;
            this.grdDrugs.RowDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs>(this.grdDrugs_RowDoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Location = new System.Drawing.Point(316, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "查询";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(22, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 16;
            this.labelX1.Text = "产品名称：";
            // 
            // txtProductCode
            // 
            // 
            // 
            // 
            this.txtProductCode.Border.Class = "TextBoxBorder";
            this.txtProductCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProductCode.ButtonCustom.Tooltip = "";
            this.txtProductCode.ButtonCustom2.Tooltip = "";
            this.txtProductCode.Location = new System.Drawing.Point(103, 12);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.PreventEnterBeep = true;
            this.txtProductCode.Size = new System.Drawing.Size(169, 21);
            this.txtProductCode.TabIndex = 17;
            this.txtProductCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductCode_KeyPress);
            // 
            // FrmSearchStoreDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 417);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grdDrugs);
            this.DoubleBuffered = true;
            this.Name = "FrmSearchStoreDetail";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择产品";
            this.Load += new System.EventHandler(this.FrmSearchStoreDetail_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grdDrugs;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProductCode;
    }
}