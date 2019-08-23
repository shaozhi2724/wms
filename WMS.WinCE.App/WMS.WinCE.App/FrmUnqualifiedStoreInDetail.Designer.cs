namespace WMS.WinCE.App
{
    partial class FrmUnqualifiedStoreInDetail
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
            this.muSaveStoreIn = new System.Windows.Forms.MenuItem();
            this.muBack = new System.Windows.Forms.MenuItem();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtPackageSpec = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtBatchNo = new System.Windows.Forms.TextBox();
            this.lblBatchNo = new System.Windows.Forms.Label();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.lblSpec = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblStoreCode = new System.Windows.Forms.Label();
            this.lvwStoreDetails = new System.Windows.Forms.ListView();
            this.colStoreDetailID = new System.Windows.Forms.ColumnHeader();
            this.colProductName = new System.Windows.Forms.ColumnHeader();
            this.colBatchNo = new System.Windows.Forms.ColumnHeader();
            this.colPackageSpec = new System.Windows.Forms.ColumnHeader();
            this.colProductSpec = new System.Windows.Forms.ColumnHeader();
            this.colAmount = new System.Windows.Forms.ColumnHeader();
            this.colCargoSpaceStoreDetailID = new System.Windows.Forms.ColumnHeader();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtStoreAmount = new System.Windows.Forms.NumericUpDown();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.muSaveStoreIn);
            this.mainMenu.MenuItems.Add(this.muBack);
            // 
            // muSaveStoreIn
            // 
            this.muSaveStoreIn.Text = "入库";
            this.muSaveStoreIn.Click += new System.EventHandler(this.muSaveStoreIn_Click);
            // 
            // muBack
            // 
            this.muBack.Text = "返回";
            this.muBack.Click += new System.EventHandler(this.muBack_Click);
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(5, 83);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(104, 20);
            this.lblCode.Text = "包装规格：";
            // 
            // txtPackageSpec
            // 
            this.txtPackageSpec.Location = new System.Drawing.Point(99, 80);
            this.txtPackageSpec.Name = "txtPackageSpec";
            this.txtPackageSpec.ReadOnly = true;
            this.txtPackageSpec.Size = new System.Drawing.Size(205, 23);
            this.txtPackageSpec.TabIndex = 4;
            this.txtPackageSpec.TabStop = false;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(99, 29);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(205, 23);
            this.txtProductName.TabIndex = 5;
            this.txtProductName.TabStop = false;
            // 
            // lblProductName
            // 
            this.lblProductName.Location = new System.Drawing.Point(5, 31);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(104, 20);
            this.lblProductName.Text = "药品名称：";
            // 
            // lblAmount
            // 
            this.lblAmount.Location = new System.Drawing.Point(5, 108);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(63, 20);
            this.lblAmount.Text = "数量：";
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Location = new System.Drawing.Point(99, 54);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.ReadOnly = true;
            this.txtBatchNo.Size = new System.Drawing.Size(205, 23);
            this.txtBatchNo.TabIndex = 6;
            this.txtBatchNo.TabStop = false;
            // 
            // lblBatchNo
            // 
            this.lblBatchNo.Location = new System.Drawing.Point(5, 57);
            this.lblBatchNo.Name = "lblBatchNo";
            this.lblBatchNo.Size = new System.Drawing.Size(104, 20);
            this.lblBatchNo.Text = "药品批号：";
            // 
            // txtSpec
            // 
            this.txtSpec.Location = new System.Drawing.Point(211, 106);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.ReadOnly = true;
            this.txtSpec.Size = new System.Drawing.Size(93, 23);
            this.txtSpec.TabIndex = 8;
            this.txtSpec.TabStop = false;
            // 
            // lblSpec
            // 
            this.lblSpec.Location = new System.Drawing.Point(156, 108);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(65, 20);
            this.lblSpec.Text = "规格：";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(99, 162);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(205, 23);
            this.txtBarcode.TabIndex = 1;
            // 
            // lblBarcode
            // 
            this.lblBarcode.Location = new System.Drawing.Point(5, 164);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(104, 20);
            this.lblBarcode.Text = "存放货位：";
            // 
            // lblStoreCode
            // 
            this.lblStoreCode.Location = new System.Drawing.Point(5, 136);
            this.lblStoreCode.Name = "lblStoreCode";
            this.lblStoreCode.Size = new System.Drawing.Size(104, 20);
            this.lblStoreCode.Text = "存放数量：";
            // 
            // lvwStoreDetails
            // 
            this.lvwStoreDetails.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwStoreDetails.Columns.Add(this.colStoreDetailID);
            this.lvwStoreDetails.Columns.Add(this.colProductName);
            this.lvwStoreDetails.Columns.Add(this.colBatchNo);
            this.lvwStoreDetails.Columns.Add(this.colPackageSpec);
            this.lvwStoreDetails.Columns.Add(this.colProductSpec);
            this.lvwStoreDetails.Columns.Add(this.colAmount);
            this.lvwStoreDetails.Columns.Add(this.colCargoSpaceStoreDetailID);
            this.lvwStoreDetails.FullRowSelect = true;
            this.lvwStoreDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwStoreDetails.Location = new System.Drawing.Point(8, 191);
            this.lvwStoreDetails.Name = "lvwStoreDetails";
            this.lvwStoreDetails.Size = new System.Drawing.Size(296, 77);
            this.lvwStoreDetails.TabIndex = 3;
            this.lvwStoreDetails.View = System.Windows.Forms.View.Details;
            this.lvwStoreDetails.ItemActivate += new System.EventHandler(this.lvwStoreDetails_ItemActivate);
            // 
            // colStoreDetailID
            // 
            this.colStoreDetailID.Text = "序号";
            this.colStoreDetailID.Width = 46;
            // 
            // colProductName
            // 
            this.colProductName.Text = "药品名称";
            this.colProductName.Width = 61;
            // 
            // colBatchNo
            // 
            this.colBatchNo.Text = "批号";
            this.colBatchNo.Width = 47;
            // 
            // colPackageSpec
            // 
            this.colPackageSpec.Text = "包装规格";
            this.colPackageSpec.Width = 60;
            // 
            // colProductSpec
            // 
            this.colProductSpec.Text = "规格";
            this.colProductSpec.Width = 42;
            // 
            // colAmount
            // 
            this.colAmount.Text = "数量";
            this.colAmount.Width = 60;
            // 
            // colCargoSpaceStoreDetailID
            // 
            this.colCargoSpaceStoreDetailID.Text = "货位号";
            this.colCargoSpaceStoreDetailID.Width = 60;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(63, 106);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(89, 23);
            this.txtAmount.TabIndex = 7;
            this.txtAmount.TabStop = false;
            // 
            // txtStoreAmount
            // 
            this.txtStoreAmount.Location = new System.Drawing.Point(99, 133);
            this.txtStoreAmount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtStoreAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtStoreAmount.Name = "txtStoreAmount";
            this.txtStoreAmount.Size = new System.Drawing.Size(205, 24);
            this.txtStoreAmount.TabIndex = 2;
            this.txtStoreAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmUnqualifiedStoreInDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(318, 275);
            this.ControlBox = false;
            this.Controls.Add(this.txtStoreAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.txtSpec);
            this.Controls.Add(this.lvwStoreDetails);
            this.Controls.Add(this.txtBatchNo);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtPackageSpec);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.lblStoreCode);
            this.Controls.Add(this.lblSpec);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblBatchNo);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblCode);
            this.Menu = this.mainMenu;
            this.Name = "FrmUnqualifiedStoreInDetail";
            this.Text = "不合格品入库";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmUnqualifiedStoreInDetail_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtPackageSpec;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtBatchNo;
        private System.Windows.Forms.Label lblBatchNo;
        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.Label lblSpec;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblStoreCode;
        private System.Windows.Forms.MenuItem muSaveStoreIn;
        private System.Windows.Forms.MenuItem muBack;
        private System.Windows.Forms.ListView lvwStoreDetails;
        private System.Windows.Forms.ColumnHeader colStoreDetailID;
        private System.Windows.Forms.ColumnHeader colProductName;
        private System.Windows.Forms.ColumnHeader colBatchNo;
        private System.Windows.Forms.ColumnHeader colProductSpec;
        private System.Windows.Forms.ColumnHeader colAmount;
        private System.Windows.Forms.ColumnHeader colCargoSpaceStoreDetailID;
        private System.Windows.Forms.ColumnHeader colPackageSpec;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.NumericUpDown txtStoreAmount;
    }
}