namespace WMS.SmartDevice.App
{
    partial class FrmCollection
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
            this.muSaveDetail = new System.Windows.Forms.MenuItem();
            this.muBack = new System.Windows.Forms.MenuItem();
            this.lblScatteredAmount = new System.Windows.Forms.Label();
            this.lblEntireAmount = new System.Windows.Forms.Label();
            this.txtPackagingProportion = new System.Windows.Forms.TextBox();
            this.lblPackagingProportion = new System.Windows.Forms.Label();
            this.txtProductBarcode = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblStoreEnvironment = new System.Windows.Forms.Label();
            this.cbxStoreEnvironment = new System.Windows.Forms.ComboBox();
            this.lvwProductDetails = new System.Windows.Forms.ListView();
            this.colProductCode = new System.Windows.Forms.ColumnHeader();
            this.colProductName = new System.Windows.Forms.ColumnHeader();
            this.colProductSpec = new System.Windows.Forms.ColumnHeader();
            this.colPhysicType = new System.Windows.Forms.ColumnHeader();
            this.colFactory = new System.Windows.Forms.ColumnHeader();
            this.txtEntireAmount = new System.Windows.Forms.TextBox();
            this.txtScatteredAmount = new System.Windows.Forms.TextBox();
            this.txtScatteredAlaramAmount = new System.Windows.Forms.TextBox();
            this.lblScatteredAlaramAmount = new System.Windows.Forms.Label();
            this.txtStoreAlaramAmount = new System.Windows.Forms.TextBox();
            this.lblStoreAlaramAmount = new System.Windows.Forms.Label();
            this.colPackageSpec = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.muSaveDetail);
            this.mainMenu.MenuItems.Add(this.muBack);
            // 
            // muSaveDetail
            // 
            this.muSaveDetail.Text = "保存明细";
            this.muSaveDetail.Click += new System.EventHandler(this.muSaveDetail_Click);
            // 
            // muBack
            // 
            this.muBack.Text = "返回";
            this.muBack.Click += new System.EventHandler(this.muBack_Click);
            // 
            // lblScatteredAmount
            // 
            this.lblScatteredAmount.Location = new System.Drawing.Point(5, 137);
            this.lblScatteredAmount.Name = "lblScatteredAmount";
            this.lblScatteredAmount.Size = new System.Drawing.Size(103, 20);
            this.lblScatteredAmount.Text = "零货最大数量：";
            this.lblScatteredAmount.Visible = false;
            // 
            // lblEntireAmount
            // 
            this.lblEntireAmount.Location = new System.Drawing.Point(5, 111);
            this.lblEntireAmount.Name = "lblEntireAmount";
            this.lblEntireAmount.Size = new System.Drawing.Size(103, 20);
            this.lblEntireAmount.Text = "整货最大数量：";
            this.lblEntireAmount.Visible = false;
            // 
            // txtPackagingProportion
            // 
            this.txtPackagingProportion.Location = new System.Drawing.Point(83, 56);
            this.txtPackagingProportion.Name = "txtPackagingProportion";
            this.txtPackagingProportion.Size = new System.Drawing.Size(154, 21);
            this.txtPackagingProportion.TabIndex = 3;
            // 
            // lblPackagingProportion
            // 
            this.lblPackagingProportion.Location = new System.Drawing.Point(3, 57);
            this.lblPackagingProportion.Name = "lblPackagingProportion";
            this.lblPackagingProportion.Size = new System.Drawing.Size(74, 20);
            this.lblPackagingProportion.Text = "包装比例：";
            // 
            // txtProductBarcode
            // 
            this.txtProductBarcode.Location = new System.Drawing.Point(83, 31);
            this.txtProductBarcode.Name = "txtProductBarcode";
            this.txtProductBarcode.Size = new System.Drawing.Size(154, 21);
            this.txtProductBarcode.TabIndex = 2;
            //this.txtProductBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductBarcode_KeyPress);
            // 
            // lblBarcode
            // 
            this.lblBarcode.Location = new System.Drawing.Point(3, 32);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(74, 20);
            this.lblBarcode.Text = "药品条码：";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(83, 6);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(154, 21);
            this.txtProductName.TabIndex = 1;
            this.txtProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductName_KeyPress);
            // 
            // lblProductName
            // 
            this.lblProductName.Location = new System.Drawing.Point(3, 7);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(74, 20);
            this.lblProductName.Text = "药品名称：";
            // 
            // lblStoreEnvironment
            // 
            this.lblStoreEnvironment.Location = new System.Drawing.Point(5, 84);
            this.lblStoreEnvironment.Name = "lblStoreEnvironment";
            this.lblStoreEnvironment.Size = new System.Drawing.Size(74, 20);
            this.lblStoreEnvironment.Text = "存储条件：";
            // 
            // cbxStoreEnvironment
            // 
            this.cbxStoreEnvironment.Location = new System.Drawing.Point(83, 82);
            this.cbxStoreEnvironment.Name = "cbxStoreEnvironment";
            this.cbxStoreEnvironment.Size = new System.Drawing.Size(154, 22);
            this.cbxStoreEnvironment.TabIndex = 4;
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
            this.lvwProductDetails.Location = new System.Drawing.Point(3, 107);
            this.lvwProductDetails.Name = "lvwProductDetails";
            this.lvwProductDetails.Size = new System.Drawing.Size(234, 161);
            this.lvwProductDetails.TabIndex = 9;
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
            this.colProductSpec.Width = 53;
            // 
            // colPhysicType
            // 
            this.colPhysicType.Text = "制剂规格";
            this.colPhysicType.Width = 70;
            // 
            // colFactory
            // 
            this.colFactory.Text = "生产厂家";
            this.colFactory.Width = 60;
            // 
            // txtEntireAmount
            // 
            this.txtEntireAmount.Location = new System.Drawing.Point(103, 109);
            this.txtEntireAmount.Name = "txtEntireAmount";
            this.txtEntireAmount.Size = new System.Drawing.Size(121, 21);
            this.txtEntireAmount.TabIndex = 5;
            this.txtEntireAmount.Visible = false;
            // 
            // txtScatteredAmount
            // 
            this.txtScatteredAmount.Location = new System.Drawing.Point(103, 134);
            this.txtScatteredAmount.Name = "txtScatteredAmount";
            this.txtScatteredAmount.Size = new System.Drawing.Size(122, 21);
            this.txtScatteredAmount.TabIndex = 6;
            this.txtScatteredAmount.Visible = false;
            // 
            // txtScatteredAlaramAmount
            // 
            this.txtScatteredAlaramAmount.Location = new System.Drawing.Point(103, 158);
            this.txtScatteredAlaramAmount.Name = "txtScatteredAlaramAmount";
            this.txtScatteredAlaramAmount.Size = new System.Drawing.Size(122, 21);
            this.txtScatteredAlaramAmount.TabIndex = 7;
            this.txtScatteredAlaramAmount.Visible = false;
            // 
            // lblScatteredAlaramAmount
            // 
            this.lblScatteredAlaramAmount.Location = new System.Drawing.Point(5, 159);
            this.lblScatteredAlaramAmount.Name = "lblScatteredAlaramAmount";
            this.lblScatteredAlaramAmount.Size = new System.Drawing.Size(103, 20);
            this.lblScatteredAlaramAmount.Text = "零货预警数量：";
            this.lblScatteredAlaramAmount.Visible = false;
            // 
            // txtStoreAlaramAmount
            // 
            this.txtStoreAlaramAmount.Location = new System.Drawing.Point(103, 181);
            this.txtStoreAlaramAmount.Name = "txtStoreAlaramAmount";
            this.txtStoreAlaramAmount.Size = new System.Drawing.Size(122, 21);
            this.txtStoreAlaramAmount.TabIndex = 8;
            this.txtStoreAlaramAmount.Visible = false;
            // 
            // lblStoreAlaramAmount
            // 
            this.lblStoreAlaramAmount.Location = new System.Drawing.Point(5, 182);
            this.lblStoreAlaramAmount.Name = "lblStoreAlaramAmount";
            this.lblStoreAlaramAmount.Size = new System.Drawing.Size(103, 20);
            this.lblStoreAlaramAmount.Text = "库存预警数量：";
            this.lblStoreAlaramAmount.Visible = false;
            // 
            // colPackageSpec
            // 
            this.colPackageSpec.Text = "包装规格";
            this.colPackageSpec.Width = 60;
            // 
            // FrmCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.lvwProductDetails);
            this.Controls.Add(this.txtStoreAlaramAmount);
            this.Controls.Add(this.txtScatteredAlaramAmount);
            this.Controls.Add(this.txtScatteredAmount);
            this.Controls.Add(this.txtEntireAmount);
            this.Controls.Add(this.lblStoreAlaramAmount);
            this.Controls.Add(this.lblScatteredAlaramAmount);
            this.Controls.Add(this.cbxStoreEnvironment);
            this.Controls.Add(this.lblStoreEnvironment);
            this.Controls.Add(this.lblScatteredAmount);
            this.Controls.Add(this.lblEntireAmount);
            this.Controls.Add(this.txtPackagingProportion);
            this.Controls.Add(this.lblPackagingProportion);
            this.Controls.Add(this.txtProductBarcode);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductName);
            this.Menu = this.mainMenu;
            this.Name = "FrmCollection";
            this.Text = "信息采集";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem muSaveDetail;
        private System.Windows.Forms.MenuItem muBack;
        private System.Windows.Forms.Label lblScatteredAmount;
        private System.Windows.Forms.Label lblEntireAmount;
        private System.Windows.Forms.TextBox txtPackagingProportion;
        private System.Windows.Forms.Label lblPackagingProportion;
        private System.Windows.Forms.TextBox txtProductBarcode;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblStoreEnvironment;
        private System.Windows.Forms.ComboBox cbxStoreEnvironment;
        private System.Windows.Forms.ListView lvwProductDetails;
        private System.Windows.Forms.ColumnHeader colProductCode;
        private System.Windows.Forms.ColumnHeader colProductName;
        private System.Windows.Forms.ColumnHeader colProductSpec;
        private System.Windows.Forms.ColumnHeader colPhysicType;
        private System.Windows.Forms.ColumnHeader colFactory;
        private System.Windows.Forms.TextBox txtEntireAmount;
        private System.Windows.Forms.TextBox txtScatteredAmount;
        private System.Windows.Forms.TextBox txtScatteredAlaramAmount;
        private System.Windows.Forms.Label lblScatteredAlaramAmount;
        private System.Windows.Forms.TextBox txtStoreAlaramAmount;
        private System.Windows.Forms.Label lblStoreAlaramAmount;
        private System.Windows.Forms.ColumnHeader colPackageSpec;
    }
}