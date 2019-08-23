namespace WMS.WinCE.App
{
    partial class FrmProductDestroyDetail
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
            this.muDestroy = new System.Windows.Forms.MenuItem();
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
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lvwDestroyDetails = new System.Windows.Forms.ListView();
            this.colStoreDetailID = new System.Windows.Forms.ColumnHeader();
            this.colProductName = new System.Windows.Forms.ColumnHeader();
            this.colBatchNo = new System.Windows.Forms.ColumnHeader();
            this.colPackageSpec = new System.Windows.Forms.ColumnHeader();
            this.colProductSpec = new System.Windows.Forms.ColumnHeader();
            this.colAmount = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStoreAmount = new System.Windows.Forms.NumericUpDown();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.muDestroy);
            this.mainMenu.MenuItems.Add(this.muBack);
            // 
            // muDestroy
            // 
            this.muDestroy.Text = "销毁";
            this.muDestroy.Click += new System.EventHandler(this.muDestroy_Click);
            // 
            // muBack
            // 
            this.muBack.Text = "返回";
            this.muBack.Click += new System.EventHandler(this.muBack_Click);
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(7, 79);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(110, 20);
            this.lblCode.Text = "包装规格：";
            // 
            // txtPackageSpec
            // 
            this.txtPackageSpec.Location = new System.Drawing.Point(94, 76);
            this.txtPackageSpec.Name = "txtPackageSpec";
            this.txtPackageSpec.ReadOnly = true;
            this.txtPackageSpec.Size = new System.Drawing.Size(211, 23);
            this.txtPackageSpec.TabIndex = 3;
            this.txtPackageSpec.TabStop = false;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(94, 28);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(211, 23);
            this.txtProductName.TabIndex = 4;
            this.txtProductName.TabStop = false;
            // 
            // lblProductName
            // 
            this.lblProductName.Location = new System.Drawing.Point(7, 30);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(109, 20);
            this.lblProductName.Text = "药品名称：";
            // 
            // lblAmount
            // 
            this.lblAmount.Location = new System.Drawing.Point(169, 104);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(70, 20);
            this.lblAmount.Text = "数量：";
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Location = new System.Drawing.Point(94, 52);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.ReadOnly = true;
            this.txtBatchNo.Size = new System.Drawing.Size(211, 23);
            this.txtBatchNo.TabIndex = 5;
            this.txtBatchNo.TabStop = false;
            // 
            // lblBatchNo
            // 
            this.lblBatchNo.Location = new System.Drawing.Point(7, 55);
            this.lblBatchNo.Name = "lblBatchNo";
            this.lblBatchNo.Size = new System.Drawing.Size(109, 20);
            this.lblBatchNo.Text = "药品批号：";
            // 
            // txtSpec
            // 
            this.txtSpec.Location = new System.Drawing.Point(58, 101);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.ReadOnly = true;
            this.txtSpec.Size = new System.Drawing.Size(105, 23);
            this.txtSpec.TabIndex = 7;
            this.txtSpec.TabStop = false;
            // 
            // lblSpec
            // 
            this.lblSpec.Location = new System.Drawing.Point(7, 104);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(66, 20);
            this.lblSpec.Text = "规格：";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(227, 101);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(78, 23);
            this.txtAmount.TabIndex = 6;
            this.txtAmount.TabStop = false;
            // 
            // lvwDestroyDetails
            // 
            this.lvwDestroyDetails.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwDestroyDetails.Columns.Add(this.colStoreDetailID);
            this.lvwDestroyDetails.Columns.Add(this.colProductName);
            this.lvwDestroyDetails.Columns.Add(this.colBatchNo);
            this.lvwDestroyDetails.Columns.Add(this.colPackageSpec);
            this.lvwDestroyDetails.Columns.Add(this.colProductSpec);
            this.lvwDestroyDetails.Columns.Add(this.colAmount);
            this.lvwDestroyDetails.FullRowSelect = true;
            this.lvwDestroyDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwDestroyDetails.Location = new System.Drawing.Point(7, 180);
            this.lvwDestroyDetails.Name = "lvwDestroyDetails";
            this.lvwDestroyDetails.Size = new System.Drawing.Size(298, 82);
            this.lvwDestroyDetails.TabIndex = 2;
            this.lvwDestroyDetails.View = System.Windows.Forms.View.Details;
            this.lvwDestroyDetails.ItemActivate += new System.EventHandler(this.lvwDestroyDetails_ItemActivate);
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.Text = "确认货位：";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(94, 154);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(211, 23);
            this.txtBarcode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.Text = "确认数量：";
            // 
            // txtStoreAmount
            // 
            this.txtStoreAmount.Location = new System.Drawing.Point(94, 127);
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
            this.txtStoreAmount.Size = new System.Drawing.Size(211, 24);
            this.txtStoreAmount.TabIndex = 16;
            this.txtStoreAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmProductDestroyDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(318, 275);
            this.ControlBox = false;
            this.Controls.Add(this.txtStoreAmount);
            this.Controls.Add(this.txtSpec);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwDestroyDetails);
            this.Controls.Add(this.lblSpec);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtBatchNo);
            this.Controls.Add(this.lblBatchNo);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtPackageSpec);
            this.Controls.Add(this.lblCode);
            this.Menu = this.mainMenu;
            this.Name = "FrmProductDestroyDetail";
            this.Text = "药品销毁";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.MenuItem muDestroy;
        private System.Windows.Forms.MenuItem muBack;
        private System.Windows.Forms.ListView lvwDestroyDetails;
        private System.Windows.Forms.ColumnHeader colStoreDetailID;
        private System.Windows.Forms.ColumnHeader colProductName;
        private System.Windows.Forms.ColumnHeader colBatchNo;
        private System.Windows.Forms.ColumnHeader colProductSpec;
        private System.Windows.Forms.ColumnHeader colAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.ColumnHeader colPackageSpec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtStoreAmount;
    }
}