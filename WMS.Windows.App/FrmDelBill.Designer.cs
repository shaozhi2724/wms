namespace WMS.Windows.App
{
    partial class FrmDelBill
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
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn18 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn19 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn20 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn21 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn22 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnDel = new DevComponents.DotNetBar.ButtonX();
            this.grdStoreOutDetail = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.grdStoreOut = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.btnPass = new DevComponents.DotNetBar.ButtonX();
            this.btnDelOnly = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Location = new System.Drawing.Point(299, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "查询";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "单据编号：";
            // 
            // txtCode
            // 
            // 
            // 
            // 
            this.txtCode.Border.Class = "TextBoxBorder";
            this.txtCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCode.ButtonCustom.Tooltip = "";
            this.txtCode.ButtonCustom2.Tooltip = "";
            this.txtCode.Location = new System.Drawing.Point(75, 14);
            this.txtCode.Name = "txtCode";
            this.txtCode.PreventEnterBeep = true;
            this.txtCode.Size = new System.Drawing.Size(175, 21);
            this.txtCode.TabIndex = 2;
            // 
            // btnDel
            // 
            this.btnDel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDel.Location = new System.Drawing.Point(406, 14);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // grdStoreOutDetail
            // 
            this.grdStoreOutDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdStoreOutDetail.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grdStoreOutDetail.Location = new System.Drawing.Point(0, 239);
            this.grdStoreOutDetail.Name = "grdStoreOutDetail";
            this.grdStoreOutDetail.PrimaryGrid.AllowEdit = false;
            this.grdStoreOutDetail.PrimaryGrid.AutoGenerateColumns = false;
            this.grdStoreOutDetail.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
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
            gridColumn4.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn4.DataPropertyName = "ProductSpec";
            gridColumn4.HeaderText = "制剂规格";
            gridColumn4.Name = "colProductSpec";
            gridColumn5.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn5.DataPropertyName = "PackageSpec";
            gridColumn5.HeaderText = "包装规格";
            gridColumn5.Name = "colPackageSpec";
            gridColumn6.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn6.DataPropertyName = "BatchNo";
            gridColumn6.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn6.HeaderText = "批号";
            gridColumn6.Name = "colBatchNo";
            gridColumn7.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn7.DataPropertyName = "ProducerName";
            gridColumn7.HeaderText = "生产厂商";
            gridColumn7.Name = "colProducerName";
            gridColumn8.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn8.DataPropertyName = "ProduceDateString";
            gridColumn8.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn8.HeaderText = "生产日期";
            gridColumn8.Name = "colProduceDate";
            gridColumn9.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn9.DataPropertyName = "ValidateDateString";
            gridColumn9.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn9.HeaderText = "有效期";
            gridColumn9.Name = "colValidateDate";
            gridColumn10.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            gridColumn10.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn10.DataPropertyName = "StructureName";
            gridColumn10.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn10.HeaderText = "货位";
            gridColumn10.Name = "colStructureName";
            gridColumn11.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn11.DataPropertyName = "StructureCode";
            gridColumn11.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn11.HeaderText = "货位编码";
            gridColumn11.Name = "colStructureCode";
            gridColumn12.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn12.DataPropertyName = "Amount";
            gridColumn12.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn12.HeaderText = "数量";
            gridColumn12.Name = "colAmount";
            gridColumn13.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn13.DataPropertyName = "PackagingAmount";
            gridColumn13.HeaderText = "件数";
            gridColumn13.Name = "colPackagingAmount";
            gridColumn13.Visible = false;
            gridColumn14.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn14.DataPropertyName = "StatusName";
            gridColumn14.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn14.HeaderText = "状态";
            gridColumn14.Name = "colStatusName";
            gridColumn15.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            gridColumn15.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn15.DataPropertyName = "ControlTypeString";
            gridColumn15.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn15.HeaderText = "说明";
            gridColumn15.Name = "colControlType";
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn1);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn2);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn3);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn4);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn5);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn6);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn7);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn8);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn9);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn10);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn11);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn12);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn13);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn14);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn15);
            this.grdStoreOutDetail.PrimaryGrid.MultiSelect = false;
            this.grdStoreOutDetail.PrimaryGrid.NoRowsText = "暂无记录";
            this.grdStoreOutDetail.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grdStoreOutDetail.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.grdStoreOutDetail.PrimaryGrid.ShowRowGridIndex = true;
            this.grdStoreOutDetail.Size = new System.Drawing.Size(811, 236);
            this.grdStoreOutDetail.TabIndex = 15;
            this.grdStoreOutDetail.Text = "superGridControl2";
            // 
            // grdStoreOut
            // 
            this.grdStoreOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdStoreOut.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grdStoreOut.Location = new System.Drawing.Point(0, 47);
            this.grdStoreOut.Name = "grdStoreOut";
            this.grdStoreOut.PrimaryGrid.AllowEdit = false;
            this.grdStoreOut.PrimaryGrid.AutoGenerateColumns = false;
            this.grdStoreOut.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn16.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            gridColumn16.DataPropertyName = "StoreID";
            gridColumn16.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn16.HeaderText = "序号";
            gridColumn16.Name = "colStoreID";
            gridColumn16.Visible = false;
            gridColumn17.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn17.DataPropertyName = "StoreCode";
            gridColumn17.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn17.HeaderText = "单据编号";
            gridColumn17.Name = "colStoreCode";
            gridColumn18.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn18.DataPropertyName = "StoreTypeName";
            gridColumn18.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn18.HeaderText = "单据类型";
            gridColumn18.Name = "colStoreTypeName";
            gridColumn19.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn19.DataPropertyName = "DealerName";
            gridColumn19.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn19.HeaderText = "往来单位";
            gridColumn19.Name = "colDealerName";
            gridColumn20.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn20.DataPropertyName = "";
            gridColumn20.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn20.HeaderText = "时间";
            gridColumn20.Name = "colStoreBillDate";
            gridColumn21.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn21.DataPropertyName = "StoreStatusName";
            gridColumn21.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn21.HeaderText = "状态";
            gridColumn21.Name = "colStoreBillStatus";
            gridColumn22.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn22.DataPropertyName = "StoreRemark";
            gridColumn22.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn22.HeaderText = "说明";
            gridColumn22.Name = "colStoreRemark";
            this.grdStoreOut.PrimaryGrid.Columns.Add(gridColumn16);
            this.grdStoreOut.PrimaryGrid.Columns.Add(gridColumn17);
            this.grdStoreOut.PrimaryGrid.Columns.Add(gridColumn18);
            this.grdStoreOut.PrimaryGrid.Columns.Add(gridColumn19);
            this.grdStoreOut.PrimaryGrid.Columns.Add(gridColumn20);
            this.grdStoreOut.PrimaryGrid.Columns.Add(gridColumn21);
            this.grdStoreOut.PrimaryGrid.Columns.Add(gridColumn22);
            this.grdStoreOut.PrimaryGrid.MultiSelect = false;
            this.grdStoreOut.PrimaryGrid.NoRowsText = "暂无记录";
            this.grdStoreOut.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grdStoreOut.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.grdStoreOut.PrimaryGrid.ShowRowGridIndex = true;
            this.grdStoreOut.PrimaryGrid.UseAlternateRowStyle = true;
            this.grdStoreOut.Size = new System.Drawing.Size(811, 186);
            this.grdStoreOut.TabIndex = 14;
            this.grdStoreOut.Text = "superGridControl1";
            // 
            // btnPass
            // 
            this.btnPass.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPass.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPass.Location = new System.Drawing.Point(508, 14);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(75, 23);
            this.btnPass.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPass.TabIndex = 0;
            this.btnPass.Text = "通过";
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // btnDelOnly
            // 
            this.btnDelOnly.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelOnly.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelOnly.Location = new System.Drawing.Point(604, 14);
            this.btnDelOnly.Name = "btnDelOnly";
            this.btnDelOnly.Size = new System.Drawing.Size(75, 23);
            this.btnDelOnly.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelOnly.TabIndex = 0;
            this.btnDelOnly.Text = "单条删除";
            this.btnDelOnly.Click += new System.EventHandler(this.btnDelOnly_Click);
            // 
            // FrmDelBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 476);
            this.Controls.Add(this.grdStoreOutDetail);
            this.Controls.Add(this.grdStoreOut);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.btnDelOnly);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSearch);
            this.DoubleBuffered = true;
            this.Name = "FrmDelBill";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "删除单据";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCode;
        private DevComponents.DotNetBar.ButtonX btnDel;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grdStoreOutDetail;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grdStoreOut;
        private DevComponents.DotNetBar.ButtonX btnPass;
        private DevComponents.DotNetBar.ButtonX btnDelOnly;

    }
}