namespace WMS.Windows.App
{
    partial class FrmExportTickets
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
            this.btnExport = new DevComponents.DotNetBar.ButtonX();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lblTotalCodeCount = new DevComponents.DotNetBar.LabelX();
            this.lblUsedCodesCount = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.lblExportedCodesCount = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.lblCanUsedCodesCount = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExport.Location = new System.Drawing.Point(100, 200);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(87, 30);
            this.btnExport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "导出";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Excel 文件|*.xls";
            this.saveFileDialog.Title = "保存导出单据";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(30, 21);
            this.labelX1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(109, 30);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "流通监管码总量：";
            // 
            // lblTotalCodeCount
            // 
            // 
            // 
            // 
            this.lblTotalCodeCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTotalCodeCount.Location = new System.Drawing.Point(159, 21);
            this.lblTotalCodeCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTotalCodeCount.Name = "lblTotalCodeCount";
            this.lblTotalCodeCount.Size = new System.Drawing.Size(224, 30);
            this.lblTotalCodeCount.TabIndex = 2;
            // 
            // lblUsedCodesCount
            // 
            // 
            // 
            // 
            this.lblUsedCodesCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblUsedCodesCount.Location = new System.Drawing.Point(159, 59);
            this.lblUsedCodesCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblUsedCodesCount.Name = "lblUsedCodesCount";
            this.lblUsedCodesCount.Size = new System.Drawing.Size(224, 30);
            this.lblUsedCodesCount.TabIndex = 4;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(77, 59);
            this.labelX3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(62, 30);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "未导出：";
            // 
            // lblExportedCodesCount
            // 
            // 
            // 
            // 
            this.lblExportedCodesCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblExportedCodesCount.Location = new System.Drawing.Point(159, 97);
            this.lblExportedCodesCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblExportedCodesCount.Name = "lblExportedCodesCount";
            this.lblExportedCodesCount.Size = new System.Drawing.Size(224, 30);
            this.lblExportedCodesCount.TabIndex = 6;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(81, 97);
            this.labelX5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(58, 30);
            this.labelX5.TabIndex = 5;
            this.labelX5.Text = "已导出：";
            // 
            // lblCanUsedCodesCount
            // 
            // 
            // 
            // 
            this.lblCanUsedCodesCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCanUsedCodesCount.Location = new System.Drawing.Point(159, 135);
            this.lblCanUsedCodesCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblCanUsedCodesCount.Name = "lblCanUsedCodesCount";
            this.lblCanUsedCodesCount.Size = new System.Drawing.Size(224, 30);
            this.lblCanUsedCodesCount.TabIndex = 8;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(81, 135);
            this.labelX7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(58, 30);
            this.labelX7.TabIndex = 7;
            this.labelX7.Text = "未使用：";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(207, 200);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 30);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "关闭";
            // 
            // FrmExportTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 256);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCanUsedCodesCount);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.lblExportedCodesCount);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.lblUsedCodesCount);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.lblTotalCodeCount);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnExport);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmExportTickets";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "导出单据";
            this.Load += new System.EventHandler(this.FrmExportTickets_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX lblTotalCodeCount;
        private DevComponents.DotNetBar.LabelX lblUsedCodesCount;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX lblExportedCodesCount;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX lblCanUsedCodesCount;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.ButtonX btnClose;
    }
}