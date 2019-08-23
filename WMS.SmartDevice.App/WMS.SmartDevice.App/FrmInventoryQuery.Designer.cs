namespace WMS.SmartDevice.App
{
    partial class FrmInventoryQuery
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
            this.muQuery = new System.Windows.Forms.MenuItem();
            this.muBack = new System.Windows.Forms.MenuItem();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblManufactureDate = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblValidityDate = new System.Windows.Forms.Label();
            this.txtBatchNo = new System.Windows.Forms.TextBox();
            this.lblBatchNo = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.lblSpec = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtManufactureDate = new System.Windows.Forms.TextBox();
            this.txtValidityDate = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtPackageSpec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.muQuery);
            this.mainMenu.MenuItems.Add(this.muBack);
            // 
            // muQuery
            // 
            this.muQuery.Text = "查询";
            this.muQuery.Click += new System.EventHandler(this.muQuery_Click);
            // 
            // muBack
            // 
            this.muBack.Text = "返回";
            this.muBack.Click += new System.EventHandler(this.muBack_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(86, 12);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(142, 25);
            this.txtBarcode.TabIndex = 1;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // lblBarcode
            // 
            this.lblBarcode.Location = new System.Drawing.Point(6, 13);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(91, 20);
            this.lblBarcode.Text = "货位条码：";
            // 
            // lblManufactureDate
            // 
            this.lblManufactureDate.Location = new System.Drawing.Point(6, 175);
            this.lblManufactureDate.Name = "lblManufactureDate";
            this.lblManufactureDate.Size = new System.Drawing.Size(91, 20);
            this.lblManufactureDate.Text = "生产日期：";
            // 
            // lblAmount
            // 
            this.lblAmount.Location = new System.Drawing.Point(6, 229);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(91, 20);
            this.lblAmount.Text = "药品数量：";
            // 
            // lblValidityDate
            // 
            this.lblValidityDate.Location = new System.Drawing.Point(6, 201);
            this.lblValidityDate.Name = "lblValidityDate";
            this.lblValidityDate.Size = new System.Drawing.Size(91, 20);
            this.lblValidityDate.Text = "有效期至：";
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Location = new System.Drawing.Point(86, 147);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.ReadOnly = true;
            this.txtBatchNo.Size = new System.Drawing.Size(142, 25);
            this.txtBatchNo.TabIndex = 6;
            // 
            // lblBatchNo
            // 
            this.lblBatchNo.Location = new System.Drawing.Point(6, 148);
            this.lblBatchNo.Name = "lblBatchNo";
            this.lblBatchNo.Size = new System.Drawing.Size(91, 20);
            this.lblBatchNo.Text = "药批批号：";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(86, 120);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.ReadOnly = true;
            this.txtManufacturer.Size = new System.Drawing.Size(142, 25);
            this.txtManufacturer.TabIndex = 5;
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.Location = new System.Drawing.Point(6, 121);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(91, 20);
            this.lblManufacturer.Text = "生产厂家：";
            // 
            // txtSpec
            // 
            this.txtSpec.Location = new System.Drawing.Point(86, 67);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.ReadOnly = true;
            this.txtSpec.Size = new System.Drawing.Size(142, 25);
            this.txtSpec.TabIndex = 3;
            // 
            // lblSpec
            // 
            this.lblSpec.Location = new System.Drawing.Point(6, 68);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(91, 20);
            this.lblSpec.Text = "药品规格：";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(86, 39);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(142, 25);
            this.txtProductName.TabIndex = 2;
            // 
            // lblProductName
            // 
            this.lblProductName.Location = new System.Drawing.Point(6, 40);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(91, 20);
            this.lblProductName.Text = "药品名称：";
            // 
            // txtManufactureDate
            // 
            this.txtManufactureDate.Location = new System.Drawing.Point(86, 174);
            this.txtManufactureDate.Name = "txtManufactureDate";
            this.txtManufactureDate.ReadOnly = true;
            this.txtManufactureDate.Size = new System.Drawing.Size(142, 25);
            this.txtManufactureDate.TabIndex = 7;
            // 
            // txtValidityDate
            // 
            this.txtValidityDate.Location = new System.Drawing.Point(86, 201);
            this.txtValidityDate.Name = "txtValidityDate";
            this.txtValidityDate.ReadOnly = true;
            this.txtValidityDate.Size = new System.Drawing.Size(142, 25);
            this.txtValidityDate.TabIndex = 8;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(86, 228);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(142, 25);
            this.txtAmount.TabIndex = 9;
            // 
            // txtPackageSpec
            // 
            this.txtPackageSpec.Location = new System.Drawing.Point(86, 94);
            this.txtPackageSpec.Name = "txtPackageSpec";
            this.txtPackageSpec.ReadOnly = true;
            this.txtPackageSpec.Size = new System.Drawing.Size(142, 25);
            this.txtPackageSpec.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.Text = "包装规格：";
            // 
            // FrmInventoryQuery
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.lblManufactureDate);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblValidityDate);
            this.Controls.Add(this.lblBatchNo);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.lblSpec);
            this.Controls.Add(this.lblProductName);
            this.Menu = this.mainMenu;
            this.Name = "FrmInventoryQuery";
            this.Text = "库存查询";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem muQuery;
        private System.Windows.Forms.MenuItem muBack;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblManufactureDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblValidityDate;
        private System.Windows.Forms.TextBox txtBatchNo;
        private System.Windows.Forms.Label lblBatchNo;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.Label lblSpec;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtManufactureDate;
        private System.Windows.Forms.TextBox txtValidityDate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtPackageSpec;
        private System.Windows.Forms.Label label1;
    }
}