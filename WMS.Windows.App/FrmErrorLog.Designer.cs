namespace WMS.Windows.App
{
    partial class FrmErrorLog
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
            this.lblTitle = new DevComponents.DotNetBar.LabelX();
            this.grdStoreOutErrorLog = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.lblStoreCode = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            // 
            // 
            // 
            this.lblTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(0, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(93, 23);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "出库单：";
            // 
            // grdStoreOutErrorLog
            // 
            this.grdStoreOutErrorLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdStoreOutErrorLog.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grdStoreOutErrorLog.Location = new System.Drawing.Point(0, 41);
            this.grdStoreOutErrorLog.Name = "grdStoreOutErrorLog";
            this.grdStoreOutErrorLog.PrimaryGrid.AllowEdit = false;
            this.grdStoreOutErrorLog.PrimaryGrid.AutoGenerateColumns = false;
            this.grdStoreOutErrorLog.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn1.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn1.DataPropertyName = "DetailID";
            gridColumn1.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn1.HeaderText = "序号";
            gridColumn1.Name = "colDetailID";
            gridColumn1.Visible = false;
            gridColumn2.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            gridColumn2.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridColumn2.DataPropertyName = "ProductName";
            gridColumn2.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn2.HeaderText = "药品名称";
            gridColumn2.Name = "colProductName";
            gridColumn3.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn3.DataPropertyName = "BatchNumber";
            gridColumn3.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn3.HeaderText = "批号";
            gridColumn3.Name = "colBatchNo";
            gridColumn4.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn4.DataPropertyName = "PackageSpec";
            gridColumn4.HeaderText = "包装规格";
            gridColumn4.Name = "colPackageSpec";
            gridColumn5.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn5.DataPropertyName = "ProduceDate";
            gridColumn5.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl);
            gridColumn5.HeaderText = "生产日期";
            gridColumn5.Name = "colProduceDate";
            gridColumn6.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn6.DataPropertyName = "ValidateDate";
            gridColumn6.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl);
            gridColumn6.HeaderText = "有效期至";
            gridColumn6.Name = "colValidateDate";
            gridColumn7.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            gridColumn7.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn7.DataPropertyName = "StructureName";
            gridColumn7.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn7.HeaderText = "货位";
            gridColumn7.Name = "colStructureName";
            gridColumn8.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn8.DataPropertyName = "StructureCode";
            gridColumn8.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn8.HeaderText = "货位编码";
            gridColumn8.Name = "colStructureCode";
            gridColumn9.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn9.DataPropertyName = "Amount";
            gridColumn9.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn9.HeaderText = "出库数量";
            gridColumn9.Name = "colAmount";
            gridColumn10.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn10.DataPropertyName = "StoreAmount";
            gridColumn10.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn10.HeaderText = "库存数量";
            gridColumn10.Name = "colStoreAmount";
            gridColumn11.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn11.DataPropertyName = "Reason";
            gridColumn11.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn11.HeaderText = "异常原因";
            gridColumn11.Name = "colDescription";
            this.grdStoreOutErrorLog.PrimaryGrid.Columns.Add(gridColumn1);
            this.grdStoreOutErrorLog.PrimaryGrid.Columns.Add(gridColumn2);
            this.grdStoreOutErrorLog.PrimaryGrid.Columns.Add(gridColumn3);
            this.grdStoreOutErrorLog.PrimaryGrid.Columns.Add(gridColumn4);
            this.grdStoreOutErrorLog.PrimaryGrid.Columns.Add(gridColumn5);
            this.grdStoreOutErrorLog.PrimaryGrid.Columns.Add(gridColumn6);
            this.grdStoreOutErrorLog.PrimaryGrid.Columns.Add(gridColumn7);
            this.grdStoreOutErrorLog.PrimaryGrid.Columns.Add(gridColumn8);
            this.grdStoreOutErrorLog.PrimaryGrid.Columns.Add(gridColumn9);
            this.grdStoreOutErrorLog.PrimaryGrid.Columns.Add(gridColumn10);
            this.grdStoreOutErrorLog.PrimaryGrid.Columns.Add(gridColumn11);
            this.grdStoreOutErrorLog.PrimaryGrid.MultiSelect = false;
            this.grdStoreOutErrorLog.PrimaryGrid.NoRowsText = "暂无记录";
            this.grdStoreOutErrorLog.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grdStoreOutErrorLog.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.grdStoreOutErrorLog.PrimaryGrid.ShowRowGridIndex = true;
            this.grdStoreOutErrorLog.Size = new System.Drawing.Size(942, 468);
            this.grdStoreOutErrorLog.TabIndex = 17;
            // 
            // lblStoreCode
            // 
            // 
            // 
            // 
            this.lblStoreCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStoreCode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStoreCode.Location = new System.Drawing.Point(99, 12);
            this.lblStoreCode.Name = "lblStoreCode";
            this.lblStoreCode.Size = new System.Drawing.Size(285, 23);
            this.lblStoreCode.TabIndex = 22;
            // 
            // FrmErrorLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 521);
            this.Controls.Add(this.lblStoreCode);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grdStoreOutErrorLog);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmErrorLog";
            this.Text = "库存异常信息";
            this.Load += new System.EventHandler(this.FrmErrorLog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblTitle;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grdStoreOutErrorLog;
        private DevComponents.DotNetBar.LabelX lblStoreCode;
    }
}