namespace WMS.WinCE.App
{
    partial class FrmProductSummaryDetail
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu;

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
            this.mainMenu = new System.Windows.Forms.MainMenu();
            this.muSummary = new System.Windows.Forms.MenuItem();
            this.muBack = new System.Windows.Forms.MenuItem();
            this.txtVerifiedAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPackageSpec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblManufactureDate = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblValidityDate = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtValidityDate = new System.Windows.Forms.TextBox();
            this.txtManufactureDate = new System.Windows.Forms.TextBox();
            this.txtBatchNo = new System.Windows.Forms.TextBox();
            this.lblBatchNo = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.lblSpec = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.muSummary);
            this.mainMenu.MenuItems.Add(this.muBack);
            // 
            // muSummary
            // 
            this.muSummary.Text = "完成";
            this.muSummary.Click += new System.EventHandler(this.muSummary_Click);
            // 
            // muBack
            // 
            this.muBack.Text = "返回";
            this.muBack.Click += new System.EventHandler(this.muBack_Click);
            // 
            // txtVerifiedAmount
            // 
            this.txtVerifiedAmount.Location = new System.Drawing.Point(88, 234);
            this.txtVerifiedAmount.Name = "txtVerifiedAmount";
            this.txtVerifiedAmount.Size = new System.Drawing.Size(142, 25);
            this.txtVerifiedAmount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.Text = "盘点数量：";
            // 
            // txtPackageSpec
            // 
            this.txtPackageSpec.Location = new System.Drawing.Point(88, 80);
            this.txtPackageSpec.Name = "txtPackageSpec";
            this.txtPackageSpec.ReadOnly = true;
            this.txtPackageSpec.Size = new System.Drawing.Size(142, 25);
            this.txtPackageSpec.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.Text = "包装规格：";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(88, 5);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(142, 25);
            this.txtBarcode.TabIndex = 1;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // lblBarcode
            // 
            this.lblBarcode.Location = new System.Drawing.Point(8, 6);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(94, 20);
            this.lblBarcode.Text = "货位条码：";
            // 
            // lblManufactureDate
            // 
            this.lblManufactureDate.Location = new System.Drawing.Point(8, 156);
            this.lblManufactureDate.Name = "lblManufactureDate";
            this.lblManufactureDate.Size = new System.Drawing.Size(94, 20);
            this.lblManufactureDate.Text = "生产日期：";
            // 
            // lblAmount
            // 
            this.lblAmount.Location = new System.Drawing.Point(8, 206);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(92, 20);
            this.lblAmount.Text = "药品数量：";
            // 
            // lblValidityDate
            // 
            this.lblValidityDate.Location = new System.Drawing.Point(8, 180);
            this.lblValidityDate.Name = "lblValidityDate";
            this.lblValidityDate.Size = new System.Drawing.Size(92, 20);
            this.lblValidityDate.Text = "有效期至：";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(88, 205);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(142, 25);
            this.txtAmount.TabIndex = 71;
            // 
            // txtValidityDate
            // 
            this.txtValidityDate.Location = new System.Drawing.Point(88, 180);
            this.txtValidityDate.Name = "txtValidityDate";
            this.txtValidityDate.ReadOnly = true;
            this.txtValidityDate.Size = new System.Drawing.Size(142, 25);
            this.txtValidityDate.TabIndex = 70;
            // 
            // txtManufactureDate
            // 
            this.txtManufactureDate.Location = new System.Drawing.Point(88, 155);
            this.txtManufactureDate.Name = "txtManufactureDate";
            this.txtManufactureDate.ReadOnly = true;
            this.txtManufactureDate.Size = new System.Drawing.Size(142, 25);
            this.txtManufactureDate.TabIndex = 69;
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Location = new System.Drawing.Point(88, 130);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.ReadOnly = true;
            this.txtBatchNo.Size = new System.Drawing.Size(142, 25);
            this.txtBatchNo.TabIndex = 68;
            // 
            // lblBatchNo
            // 
            this.lblBatchNo.Location = new System.Drawing.Point(8, 131);
            this.lblBatchNo.Name = "lblBatchNo";
            this.lblBatchNo.Size = new System.Drawing.Size(94, 20);
            this.lblBatchNo.Text = "药批批号：";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(88, 105);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.ReadOnly = true;
            this.txtManufacturer.Size = new System.Drawing.Size(142, 25);
            this.txtManufacturer.TabIndex = 67;
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.Location = new System.Drawing.Point(8, 106);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(94, 20);
            this.lblManufacturer.Text = "生产厂家：";
            // 
            // txtSpec
            // 
            this.txtSpec.Location = new System.Drawing.Point(88, 55);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.ReadOnly = true;
            this.txtSpec.Size = new System.Drawing.Size(142, 25);
            this.txtSpec.TabIndex = 65;
            // 
            // lblSpec
            // 
            this.lblSpec.Location = new System.Drawing.Point(8, 56);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(94, 20);
            this.lblSpec.Text = "药品规格：";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(88, 30);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(142, 25);
            this.txtProductName.TabIndex = 64;
            // 
            // lblProductName
            // 
            this.lblProductName.Location = new System.Drawing.Point(8, 31);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(94, 20);
            this.lblProductName.Text = "药品名称：";
            // 
            // FrmProductSummaryDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.txtPackageSpec);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtValidityDate);
            this.Controls.Add(this.txtManufactureDate);
            this.Controls.Add(this.txtBatchNo);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.txtSpec);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtVerifiedAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.lblManufactureDate);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblValidityDate);
            this.Controls.Add(this.lblBatchNo);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.lblSpec);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu;
            this.Name = "FrmProductSummaryDetail";
            this.Text = "药品盘点";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem muSummary;
        private System.Windows.Forms.MenuItem muBack;
        private System.Windows.Forms.TextBox txtVerifiedAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPackageSpec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblManufactureDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblValidityDate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtValidityDate;
        private System.Windows.Forms.TextBox txtManufactureDate;
        private System.Windows.Forms.TextBox txtBatchNo;
        private System.Windows.Forms.Label lblBatchNo;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.Label lblSpec;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
    }
}