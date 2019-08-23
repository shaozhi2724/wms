namespace WMS.Windows.App
{
    partial class FrmImportCode
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
            this.txtFile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnBrowse = new DevComponents.DotNetBar.ButtonX();
            this.grdCodes = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.btnImport = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // txtFile
            // 
            // 
            // 
            // 
            this.txtFile.Border.Class = "TextBoxBorder";
            this.txtFile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFile.Location = new System.Drawing.Point(97, 23);
            this.txtFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFile.Name = "txtFile";
            this.txtFile.PreventEnterBeep = true;
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(298, 23);
            this.txtFile.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Excel文件|*.xls";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(24, 23);
            this.labelX1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(67, 19);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "导入文件：";
            // 
            // btnBrowse
            // 
            this.btnBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBrowse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBrowse.Location = new System.Drawing.Point(401, 23);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 24);
            this.btnBrowse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "浏览...";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // grdCodes
            // 
            this.grdCodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCodes.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grdCodes.Location = new System.Drawing.Point(23, 57);
            this.grdCodes.Name = "grdCodes";
            this.grdCodes.PrimaryGrid.AllowEdit = false;
            this.grdCodes.PrimaryGrid.AutoGenerateColumns = false;
            this.grdCodes.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn1.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            gridColumn1.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridColumn1.DataPropertyName = "Index";
            gridColumn1.HeaderText = "序号";
            gridColumn1.Name = "colIndex";
            gridColumn2.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn2.DataPropertyName = "Code";
            gridColumn2.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn2.HeaderText = "流通监管码";
            gridColumn2.Name = "colCode";
            gridColumn2.Width = 300;
            this.grdCodes.PrimaryGrid.Columns.Add(gridColumn1);
            this.grdCodes.PrimaryGrid.Columns.Add(gridColumn2);
            this.grdCodes.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row;
            this.grdCodes.PrimaryGrid.MultiSelect = false;
            this.grdCodes.PrimaryGrid.NoRowsText = "暂无记录";
            this.grdCodes.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grdCodes.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.grdCodes.PrimaryGrid.ShowRowGridIndex = true;
            this.grdCodes.PrimaryGrid.UseAlternateRowStyle = true;
            this.grdCodes.Size = new System.Drawing.Size(633, 298);
            this.grdCodes.TabIndex = 13;
            // 
            // btnImport
            // 
            this.btnImport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnImport.Enabled = false;
            this.btnImport.Location = new System.Drawing.Point(509, 23);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImport.TabIndex = 14;
            this.btnImport.Text = "确定导入";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // FrmImportCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 395);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.grdCodes);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtFile);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmImportCode";
            this.ShowIcon = false;
            this.Text = "导入监管码";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnBrowse;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grdCodes;
        private DevComponents.DotNetBar.ButtonX btnImport;
    }
}