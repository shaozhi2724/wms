namespace WMS.SmartDevice.App
{
    partial class FrmStoreOutDetail
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
            this.muSaveStoreOut = new System.Windows.Forms.MenuItem();
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
            this.txtStructurecode = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lvwStoreDetails = new System.Windows.Forms.ListView();
            this.colCargoSpaceStoreDetailID = new System.Windows.Forms.ColumnHeader();
            this.colProductName = new System.Windows.Forms.ColumnHeader();
            this.colBatchNo = new System.Windows.Forms.ColumnHeader();
            this.colAmount = new System.Windows.Forms.ColumnHeader();
            this.colPackageSpec = new System.Windows.Forms.ColumnHeader();
            this.colProductSpec = new System.Windows.Forms.ColumnHeader();
            this.colStoreDetailID = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.muSaveStoreOut);
            this.mainMenu.MenuItems.Add(this.muBack);
            // 
            // muSaveStoreOut
            // 
            this.muSaveStoreOut.Text = "出库";
            this.muSaveStoreOut.Click += new System.EventHandler(this.muSaveStoreOut_Click);
            // 
            // muBack
            // 
            this.muBack.Text = "返回";
            this.muBack.Click += new System.EventHandler(this.muBack_Click);
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(3, 61);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(74, 20);
            this.lblCode.Text = "包装规格：";
            // 
            // txtPackageSpec
            // 
            this.txtPackageSpec.Location = new System.Drawing.Point(84, 60);
            this.txtPackageSpec.Name = "txtPackageSpec";
            this.txtPackageSpec.ReadOnly = true;
            this.txtPackageSpec.Size = new System.Drawing.Size(153, 21);
            this.txtPackageSpec.TabIndex = 3;
            this.txtPackageSpec.TabStop = false;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(83, 7);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(153, 21);
            this.txtProductName.TabIndex = 4;
            this.txtProductName.TabStop = false;
            // 
            // lblProductName
            // 
            this.lblProductName.Location = new System.Drawing.Point(3, 8);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(74, 20);
            this.lblProductName.Text = "药品名称：";
            // 
            // lblAmount
            // 
            this.lblAmount.Location = new System.Drawing.Point(3, 90);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(50, 20);
            this.lblAmount.Text = "数量：";
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Location = new System.Drawing.Point(83, 33);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.ReadOnly = true;
            this.txtBatchNo.Size = new System.Drawing.Size(153, 21);
            this.txtBatchNo.TabIndex = 5;
            this.txtBatchNo.TabStop = false;
            // 
            // lblBatchNo
            // 
            this.lblBatchNo.Location = new System.Drawing.Point(3, 34);
            this.lblBatchNo.Name = "lblBatchNo";
            this.lblBatchNo.Size = new System.Drawing.Size(74, 20);
            this.lblBatchNo.Text = "药品批号：";
            // 
            // txtSpec
            // 
            this.txtSpec.Location = new System.Drawing.Point(153, 89);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.ReadOnly = true;
            this.txtSpec.Size = new System.Drawing.Size(83, 21);
            this.txtSpec.TabIndex = 7;
            this.txtSpec.TabStop = false;
            // 
            // lblSpec
            // 
            this.lblSpec.Location = new System.Drawing.Point(113, 90);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(45, 20);
            this.lblSpec.Text = "规格：";
            // 
            // txtStructurecode
            // 
            this.txtStructurecode.Location = new System.Drawing.Point(83, 118);
            this.txtStructurecode.Name = "txtStructurecode";
            this.txtStructurecode.ReadOnly = true;
            this.txtStructurecode.Size = new System.Drawing.Size(153, 21);
            this.txtStructurecode.TabIndex = 8;
            this.txtStructurecode.TabStop = false;
            // 
            // lblBarcode
            // 
            this.lblBarcode.Location = new System.Drawing.Point(3, 120);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(74, 20);
            this.lblBarcode.Text = "货位：";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(46, 89);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(61, 21);
            this.txtAmount.TabIndex = 6;
            this.txtAmount.TabStop = false;
            // 
            // lvwStoreDetails
            // 
            this.lvwStoreDetails.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwStoreDetails.Columns.Add(this.colCargoSpaceStoreDetailID);
            this.lvwStoreDetails.Columns.Add(this.colProductName);
            this.lvwStoreDetails.Columns.Add(this.colBatchNo);
            this.lvwStoreDetails.Columns.Add(this.colAmount);
            this.lvwStoreDetails.Columns.Add(this.colPackageSpec);
            this.lvwStoreDetails.Columns.Add(this.colProductSpec);
            this.lvwStoreDetails.Columns.Add(this.colStoreDetailID);
            this.lvwStoreDetails.FullRowSelect = true;
            this.lvwStoreDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwStoreDetails.Location = new System.Drawing.Point(5, 170);
            this.lvwStoreDetails.Name = "lvwStoreDetails";
            this.lvwStoreDetails.Size = new System.Drawing.Size(232, 95);
            this.lvwStoreDetails.TabIndex = 2;
            this.lvwStoreDetails.View = System.Windows.Forms.View.Details;
            this.lvwStoreDetails.ItemActivate += new System.EventHandler(this.lvwStoreDetails_ItemActivate);
            // 
            // colCargoSpaceStoreDetailID
            // 
            this.colCargoSpaceStoreDetailID.Text = "货位号";
            this.colCargoSpaceStoreDetailID.Width = 80;
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
            // colAmount
            // 
            this.colAmount.Text = "数量";
            this.colAmount.Width = 60;
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
            // colStoreDetailID
            // 
            this.colStoreDetailID.Text = "序号";
            this.colStoreDetailID.Width = 46;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.Text = "出库货位：";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(82, 144);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(154, 21);
            this.txtBarcode.TabIndex = 1;
            // 
            // FrmStoreOutDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwStoreDetails);
            this.Controls.Add(this.txtStructurecode);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtSpec);
            this.Controls.Add(this.lblSpec);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtBatchNo);
            this.Controls.Add(this.lblBatchNo);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtPackageSpec);
            this.Controls.Add(this.lblCode);
            this.Menu = this.mainMenu;
            this.Name = "FrmStoreOutDetail";
            this.Text = "药品出库";
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
        private System.Windows.Forms.TextBox txtStructurecode;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.MenuItem muSaveStoreOut;
        private System.Windows.Forms.MenuItem muBack;
        private System.Windows.Forms.ListView lvwStoreDetails;
        private System.Windows.Forms.ColumnHeader colStoreDetailID;
        private System.Windows.Forms.ColumnHeader colProductName;
        private System.Windows.Forms.ColumnHeader colBatchNo;
        private System.Windows.Forms.ColumnHeader colProductSpec;
        private System.Windows.Forms.ColumnHeader colAmount;
        private System.Windows.Forms.ColumnHeader colCargoSpaceStoreDetailID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.ColumnHeader colPackageSpec;
    }
}