namespace WMS.Windows.App
{
    partial class FrmScanSuperviseCode
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
            this.txtStoreCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.grdCodes = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtRegulatoryCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtProductCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // txtStoreCode
            // 
            // 
            // 
            // 
            this.txtStoreCode.Border.Class = "TextBoxBorder";
            this.txtStoreCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStoreCode.ButtonCustom.Tooltip = "";
            this.txtStoreCode.ButtonCustom2.Tooltip = "";
            this.txtStoreCode.Location = new System.Drawing.Point(118, 11);
            this.txtStoreCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStoreCode.Name = "txtStoreCode";
            this.txtStoreCode.PreventEnterBeep = true;
            this.txtStoreCode.ReadOnly = true;
            this.txtStoreCode.Size = new System.Drawing.Size(226, 27);
            this.txtStoreCode.TabIndex = 1;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(24, 15);
            this.labelX1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(88, 19);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "出库单号：";
            // 
            // grdCodes
            // 
            this.grdCodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCodes.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grdCodes.Location = new System.Drawing.Point(23, 101);
            this.grdCodes.Name = "grdCodes";
            this.grdCodes.PrimaryGrid.AllowEdit = false;
            this.grdCodes.PrimaryGrid.AutoGenerateColumns = false;
            this.grdCodes.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn1.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn1.DataPropertyName = "ScannedRegulatoryCode";
            gridColumn1.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn1.HeaderText = "监管码";
            gridColumn1.Name = "colCode";
            gridColumn1.Width = 300;
            gridColumn2.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn2.DataPropertyName = "ProductBarcode";
            gridColumn2.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn2.HeaderText = "药品条码";
            gridColumn2.Name = "colProduct";
            this.grdCodes.PrimaryGrid.Columns.Add(gridColumn1);
            this.grdCodes.PrimaryGrid.Columns.Add(gridColumn2);
            this.grdCodes.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row;
            this.grdCodes.PrimaryGrid.MultiSelect = false;
            this.grdCodes.PrimaryGrid.NoRowsText = "暂无记录";
            this.grdCodes.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grdCodes.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.grdCodes.PrimaryGrid.ShowRowGridIndex = true;
            this.grdCodes.PrimaryGrid.UseAlternateRowStyle = true;
            this.grdCodes.Size = new System.Drawing.Size(662, 268);
            this.grdCodes.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Location = new System.Drawing.Point(275, 387);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 27);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(24, 62);
            this.labelX2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(88, 19);
            this.labelX2.TabIndex = 17;
            this.labelX2.Text = "监管码：";
            // 
            // txtRegulatoryCode
            // 
            // 
            // 
            // 
            this.txtRegulatoryCode.Border.Class = "TextBoxBorder";
            this.txtRegulatoryCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRegulatoryCode.ButtonCustom.Tooltip = "";
            this.txtRegulatoryCode.ButtonCustom2.Tooltip = "";
            this.txtRegulatoryCode.Location = new System.Drawing.Point(118, 58);
            this.txtRegulatoryCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegulatoryCode.Name = "txtRegulatoryCode";
            this.txtRegulatoryCode.PreventEnterBeep = true;
            this.txtRegulatoryCode.Size = new System.Drawing.Size(567, 27);
            this.txtRegulatoryCode.TabIndex = 0;
            this.txtRegulatoryCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegulatoryCode_KeyPress);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(365, 15);
            this.labelX3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(88, 19);
            this.labelX3.TabIndex = 19;
            this.labelX3.Text = "药品：";
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
            this.txtProductCode.Location = new System.Drawing.Point(459, 11);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.PreventEnterBeep = true;
            this.txtProductCode.ReadOnly = true;
            this.txtProductCode.Size = new System.Drawing.Size(226, 27);
            this.txtProductCode.TabIndex = 2;
            // 
            // FrmScanSuperviseCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 418);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtRegulatoryCode);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grdCodes);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtStoreCode);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmScanSuperviseCode";
            this.ShowIcon = false;
            this.Text = "扫描监管码";
            this.Load += new System.EventHandler(this.FrmScanSuperviseCode_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtStoreCode;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grdCodes;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRegulatoryCode;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProductCode;
    }
}