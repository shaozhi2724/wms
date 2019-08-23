namespace WMS.WinCE.App
{
    partial class FrmInitStoreIn
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
            this.muConfirm = new System.Windows.Forms.MenuItem();
            this.muBack = new System.Windows.Forms.MenuItem();
            this.lvwProductDetails = new System.Windows.Forms.ListView();
            this.colProductCode = new System.Windows.Forms.ColumnHeader();
            this.colProductName = new System.Windows.Forms.ColumnHeader();
            this.colProductSpec = new System.Windows.Forms.ColumnHeader();
            this.colPackageSpec = new System.Windows.Forms.ColumnHeader();
            this.colPhysicType = new System.Windows.Forms.ColumnHeader();
            this.colFactory = new System.Windows.Forms.ColumnHeader();
            this.lblManufactureDate = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblValidityDate = new System.Windows.Forms.Label();
            this.txtBatchNo = new System.Windows.Forms.TextBox();
            this.lblBatchNo = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductBarcode = new System.Windows.Forms.TextBox();
            this.lblProductBarcode = new System.Windows.Forms.Label();
            this.txtStoreBarcode = new System.Windows.Forms.TextBox();
            this.lblStoreBarcode = new System.Windows.Forms.Label();
            this.txtManufactureDate = new System.Windows.Forms.TextBox();
            this.txtValidityDate = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.muConfirm);
            this.mainMenu.MenuItems.Add(this.muBack);
            // 
            // muConfirm
            // 
            this.muConfirm.Text = "期初入库";
            this.muConfirm.Click += new System.EventHandler(this.muConfirm_Click);
            // 
            // muBack
            // 
            this.muBack.Text = "返回";
            this.muBack.Click += new System.EventHandler(this.muBack_Click);
            // 
            // lvwProductDetails
            // 
            this.lvwProductDetails.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwProductDetails.Columns.Add(this.colProductCode);
            this.lvwProductDetails.Columns.Add(this.colProductName);
            this.lvwProductDetails.Columns.Add(this.colProductSpec);
            this.lvwProductDetails.Columns.Add(this.colPackageSpec);
            this.lvwProductDetails.Columns.Add(this.colPhysicType);
            this.lvwProductDetails.Columns.Add(this.colFactory);
            this.lvwProductDetails.FullRowSelect = true;
            this.lvwProductDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwProductDetails.Location = new System.Drawing.Point(11, 173);
            this.lvwProductDetails.Name = "lvwProductDetails";
            this.lvwProductDetails.Size = new System.Drawing.Size(295, 87);
            this.lvwProductDetails.TabIndex = 3;
            this.lvwProductDetails.View = System.Windows.Forms.View.Details;
            this.lvwProductDetails.ItemActivate += new System.EventHandler(this.lvwProductDetails_ItemActivate);
            // 
            // colProductCode
            // 
            this.colProductCode.Text = "药品编号";
            this.colProductCode.Width = 62;
            // 
            // colProductName
            // 
            this.colProductName.Text = "药品名称";
            this.colProductName.Width = 61;
            // 
            // colProductSpec
            // 
            this.colProductSpec.Text = "规格";
            this.colProductSpec.Width = 69;
            // 
            // colPackageSpec
            // 
            this.colPackageSpec.Text = "包装规格";
            this.colPackageSpec.Width = 60;
            // 
            // colPhysicType
            // 
            this.colPhysicType.Text = "制剂规格";
            this.colPhysicType.Width = 42;
            // 
            // colFactory
            // 
            this.colFactory.Text = "生产厂家";
            this.colFactory.Width = 60;
            // 
            // lblManufactureDate
            // 
            this.lblManufactureDate.Location = new System.Drawing.Point(11, 127);
            this.lblManufactureDate.Name = "lblManufactureDate";
            this.lblManufactureDate.Size = new System.Drawing.Size(102, 20);
            this.lblManufactureDate.Text = "生产日期：";
            // 
            // lblAmount
            // 
            this.lblAmount.Location = new System.Drawing.Point(173, 103);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(67, 20);
            this.lblAmount.Text = "数量：";
            // 
            // lblValidityDate
            // 
            this.lblValidityDate.Location = new System.Drawing.Point(11, 150);
            this.lblValidityDate.Name = "lblValidityDate";
            this.lblValidityDate.Size = new System.Drawing.Size(101, 20);
            this.lblValidityDate.Text = "有效期至：";
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Location = new System.Drawing.Point(68, 100);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.Size = new System.Drawing.Size(99, 23);
            this.txtBatchNo.TabIndex = 5;
            // 
            // lblBatchNo
            // 
            this.lblBatchNo.Location = new System.Drawing.Point(11, 103);
            this.lblBatchNo.Name = "lblBatchNo";
            this.lblBatchNo.Size = new System.Drawing.Size(74, 20);
            this.lblBatchNo.Text = "批号：";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(109, 76);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(197, 23);
            this.txtProductName.TabIndex = 2;
            this.txtProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductName_KeyPress);
            // 
            // lblProductName
            // 
            this.lblProductName.ForeColor = System.Drawing.Color.Red;
            this.lblProductName.Location = new System.Drawing.Point(11, 78);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(103, 20);
            this.lblProductName.Text = "药品名称：";
            // 
            // txtProductBarcode
            // 
            this.txtProductBarcode.Location = new System.Drawing.Point(109, 52);
            this.txtProductBarcode.Name = "txtProductBarcode";
            this.txtProductBarcode.Size = new System.Drawing.Size(197, 23);
            this.txtProductBarcode.TabIndex = 1;
            this.txtProductBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductBarcode_KeyPress);
            // 
            // lblProductBarcode
            // 
            this.lblProductBarcode.ForeColor = System.Drawing.Color.Red;
            this.lblProductBarcode.Location = new System.Drawing.Point(11, 54);
            this.lblProductBarcode.Name = "lblProductBarcode";
            this.lblProductBarcode.Size = new System.Drawing.Size(103, 20);
            this.lblProductBarcode.Text = "药品条码：";
            // 
            // txtStoreBarcode
            // 
            this.txtStoreBarcode.Location = new System.Drawing.Point(109, 28);
            this.txtStoreBarcode.Name = "txtStoreBarcode";
            this.txtStoreBarcode.Size = new System.Drawing.Size(197, 23);
            this.txtStoreBarcode.TabIndex = 4;
            // 
            // lblStoreBarcode
            // 
            this.lblStoreBarcode.Location = new System.Drawing.Point(11, 30);
            this.lblStoreBarcode.Name = "lblStoreBarcode";
            this.lblStoreBarcode.Size = new System.Drawing.Size(103, 20);
            this.lblStoreBarcode.Text = "货位条码：";
            // 
            // txtManufactureDate
            // 
            this.txtManufactureDate.Location = new System.Drawing.Point(108, 124);
            this.txtManufactureDate.Name = "txtManufactureDate";
            this.txtManufactureDate.Size = new System.Drawing.Size(198, 23);
            this.txtManufactureDate.TabIndex = 7;
            // 
            // txtValidityDate
            // 
            this.txtValidityDate.Location = new System.Drawing.Point(108, 148);
            this.txtValidityDate.Name = "txtValidityDate";
            this.txtValidityDate.Size = new System.Drawing.Size(198, 23);
            this.txtValidityDate.TabIndex = 8;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(226, 100);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(80, 23);
            this.txtAmount.TabIndex = 6;
            // 
            // FrmInitStoreIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(228, 297);
            this.ControlBox = false;
            this.Controls.Add(this.txtBatchNo);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtValidityDate);
            this.Controls.Add(this.txtManufactureDate);
            this.Controls.Add(this.txtStoreBarcode);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductBarcode);
            this.Controls.Add(this.lblStoreBarcode);
            this.Controls.Add(this.lvwProductDetails);
            this.Controls.Add(this.lblManufactureDate);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblValidityDate);
            this.Controls.Add(this.lblBatchNo);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductBarcode);
            this.Menu = this.mainMenu;
            this.Name = "FrmInitStoreIn";
            this.Text = "期初入库";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem muConfirm;
        private System.Windows.Forms.MenuItem muBack;
        private System.Windows.Forms.ListView lvwProductDetails;
        private System.Windows.Forms.ColumnHeader colProductCode;
        private System.Windows.Forms.ColumnHeader colProductName;
        private System.Windows.Forms.ColumnHeader colProductSpec;
        private System.Windows.Forms.ColumnHeader colPhysicType;
        private System.Windows.Forms.ColumnHeader colFactory;
        private System.Windows.Forms.Label lblManufactureDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblValidityDate;
        private System.Windows.Forms.TextBox txtBatchNo;
        private System.Windows.Forms.Label lblBatchNo;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductBarcode;
        private System.Windows.Forms.Label lblProductBarcode;
        private System.Windows.Forms.TextBox txtStoreBarcode;
        private System.Windows.Forms.Label lblStoreBarcode;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtManufactureDate;
        private System.Windows.Forms.TextBox txtValidityDate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ColumnHeader colPackageSpec;
    }
}