namespace WMS.Windows.App
{
    partial class FrmProductForReview
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
            this.grdStoreOutDetail = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.SuspendLayout();
            // 
            // grdStoreOutDetail
            // 
            this.grdStoreOutDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdStoreOutDetail.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grdStoreOutDetail.Location = new System.Drawing.Point(0, 0);
            this.grdStoreOutDetail.Name = "grdStoreOutDetail";
            this.grdStoreOutDetail.PrimaryGrid.AllowEdit = false;
            this.grdStoreOutDetail.PrimaryGrid.AutoGenerateColumns = false;
            this.grdStoreOutDetail.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn1.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn1.DataPropertyName = "DetailID";
            gridColumn1.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn1.HeaderText = "序号";
            gridColumn1.Name = "colDetailID";
            gridColumn1.Visible = false;
            gridColumn2.DataPropertyName = "ProductCode";
            gridColumn2.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn2.HeaderText = "编码";
            gridColumn2.Name = "colProductCode";
            gridColumn3.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            gridColumn3.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridColumn3.DataPropertyName = "ProductName";
            gridColumn3.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn3.HeaderText = "药品名称";
            gridColumn3.Name = "colProductName";
            gridColumn4.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            gridColumn4.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn4.DataPropertyName = "BatchNo";
            gridColumn4.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn4.HeaderText = "批号";
            gridColumn4.Name = "colBatchNo";
            gridColumn5.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn5.DataPropertyName = "ProductSpec";
            gridColumn5.HeaderText = "制剂规格";
            gridColumn5.Name = "colProductSpec";
            gridColumn6.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn6.DataPropertyName = "PackageSpec";
            gridColumn6.HeaderText = "包装规格";
            gridColumn6.Name = "colPackageSpec";
            gridColumn7.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn7.DataPropertyName = "ProducerName";
            gridColumn7.HeaderText = "生产厂商";
            gridColumn7.Name = "colProducerName";
            gridColumn8.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn8.DataPropertyName = "StoreOutAmount";
            gridColumn8.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn8.HeaderText = "数量";
            gridColumn8.Name = "colStoreOutAmount";
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn1);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn2);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn3);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn4);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn5);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn6);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn7);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn8);
            this.grdStoreOutDetail.PrimaryGrid.MultiSelect = false;
            this.grdStoreOutDetail.PrimaryGrid.NoRowsText = "暂无记录";
            this.grdStoreOutDetail.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grdStoreOutDetail.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.grdStoreOutDetail.PrimaryGrid.ShowRowGridIndex = true;
            this.grdStoreOutDetail.Size = new System.Drawing.Size(766, 305);
            this.grdStoreOutDetail.TabIndex = 12;
            this.grdStoreOutDetail.Text = "superGridControl";
            this.grdStoreOutDetail.RowDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs>(this.grdStoreOutDetail_RowDoubleClick);
            // 
            // FrmProductForReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 305);
            this.Controls.Add(this.grdStoreOutDetail);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductForReview";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "回车选择药品";
            this.Load += new System.EventHandler(this.FrmProductForReview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grdStoreOutDetail;
    }
}