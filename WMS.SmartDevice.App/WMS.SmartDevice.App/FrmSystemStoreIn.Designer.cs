namespace WMS.SmartDevice.App
{
    partial class FrmSystemStoreIn
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
            this.muStoreIn = new System.Windows.Forms.MenuItem();
            this.muBack = new System.Windows.Forms.MenuItem();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtStoreCode = new System.Windows.Forms.TextBox();
            this.txtRecommendPosition = new System.Windows.Forms.TextBox();
            this.lblRecomment = new System.Windows.Forms.Label();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblSpec = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPackageSpec = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblStoreCode = new System.Windows.Forms.Label();
            this.lblBatchNo = new System.Windows.Forms.Label();
            this.txtBatchNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.muStoreIn);
            this.mainMenu.MenuItems.Add(this.muBack);
            // 
            // muStoreIn
            // 
            this.muStoreIn.Enabled = false;
            this.muStoreIn.Text = "入库";
            this.muStoreIn.Click += new System.EventHandler(this.muStoreIn_Click);
            // 
            // muBack
            // 
            this.muBack.Text = "返回";
            this.muBack.Click += new System.EventHandler(this.muBack_Click);
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(4, 4);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(74, 24);
            this.lblCode.Text = "货物码：";
            // 
            // txtStoreCode
            // 
            this.txtStoreCode.AcceptsReturn = true;
            this.txtStoreCode.AcceptsTab = true;
            this.txtStoreCode.Location = new System.Drawing.Point(84, 3);
            this.txtStoreCode.Name = "txtStoreCode";
            this.txtStoreCode.Size = new System.Drawing.Size(153, 25);
            this.txtStoreCode.TabIndex = 1;
            this.txtStoreCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStoreCode_KeyPress);
            // 
            // txtRecommendPosition
            // 
            this.txtRecommendPosition.Location = new System.Drawing.Point(83, 201);
            this.txtRecommendPosition.Name = "txtRecommendPosition";
            this.txtRecommendPosition.ReadOnly = true;
            this.txtRecommendPosition.Size = new System.Drawing.Size(154, 25);
            this.txtRecommendPosition.TabIndex = 9;
            // 
            // lblRecomment
            // 
            this.lblRecomment.Location = new System.Drawing.Point(3, 204);
            this.lblRecomment.Name = "lblRecomment";
            this.lblRecomment.Size = new System.Drawing.Size(74, 20);
            this.lblRecomment.Text = "分配货位：";
            // 
            // txtSpec
            // 
            this.txtSpec.Location = new System.Drawing.Point(83, 116);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.ReadOnly = true;
            this.txtSpec.Size = new System.Drawing.Size(154, 25);
            this.txtSpec.TabIndex = 6;
            this.txtSpec.TabStop = false;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(83, 172);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(154, 25);
            this.txtArea.TabIndex = 8;
            // 
            // lblArea
            // 
            this.lblArea.Location = new System.Drawing.Point(3, 175);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(74, 20);
            this.lblArea.Text = "存放库区：";
            // 
            // lblSpec
            // 
            this.lblSpec.Location = new System.Drawing.Point(3, 120);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(74, 20);
            this.lblSpec.Text = "　　规格：";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(83, 144);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(154, 25);
            this.txtAmount.TabIndex = 7;
            this.txtAmount.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.Text = "包装规格：";
            // 
            // txtPackageSpec
            // 
            this.txtPackageSpec.Location = new System.Drawing.Point(83, 88);
            this.txtPackageSpec.Name = "txtPackageSpec";
            this.txtPackageSpec.ReadOnly = true;
            this.txtPackageSpec.Size = new System.Drawing.Size(154, 25);
            this.txtPackageSpec.TabIndex = 5;
            this.txtPackageSpec.TabStop = false;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(83, 230);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(154, 25);
            this.txtBarcode.TabIndex = 2;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // lblProductName
            // 
            this.lblProductName.Location = new System.Drawing.Point(3, 33);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(74, 20);
            this.lblProductName.Text = "药品名称：";
            // 
            // lblBarcode
            // 
            this.lblBarcode.Location = new System.Drawing.Point(3, 233);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(74, 20);
            this.lblBarcode.Text = "确认货位：";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(83, 32);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(154, 25);
            this.txtProductName.TabIndex = 3;
            this.txtProductName.TabStop = false;
            // 
            // lblStoreCode
            // 
            this.lblStoreCode.Location = new System.Drawing.Point(3, 146);
            this.lblStoreCode.Name = "lblStoreCode";
            this.lblStoreCode.Size = new System.Drawing.Size(74, 20);
            this.lblStoreCode.Text = "存放数量：";
            // 
            // lblBatchNo
            // 
            this.lblBatchNo.Location = new System.Drawing.Point(3, 61);
            this.lblBatchNo.Name = "lblBatchNo";
            this.lblBatchNo.Size = new System.Drawing.Size(74, 20);
            this.lblBatchNo.Text = "药品批号：";
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Location = new System.Drawing.Point(83, 60);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.ReadOnly = true;
            this.txtBatchNo.Size = new System.Drawing.Size(154, 25);
            this.txtBatchNo.TabIndex = 4;
            this.txtBatchNo.TabStop = false;
            // 
            // FrmSystemStoreIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 266);
            this.Controls.Add(this.txtRecommendPosition);
            this.Controls.Add(this.lblRecomment);
            this.Controls.Add(this.txtSpec);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblSpec);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPackageSpec);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblStoreCode);
            this.Controls.Add(this.lblBatchNo);
            this.Controls.Add(this.txtBatchNo);
            this.Controls.Add(this.txtStoreCode);
            this.Controls.Add(this.lblCode);
            this.Menu = this.mainMenu;
            this.Name = "FrmSystemStoreIn";
            this.Text = "药品入库单据";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem muStoreIn;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtStoreCode;
        private System.Windows.Forms.MenuItem muBack;
        private System.Windows.Forms.TextBox txtRecommendPosition;
        private System.Windows.Forms.Label lblRecomment;
        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblSpec;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPackageSpec;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblStoreCode;
        private System.Windows.Forms.Label lblBatchNo;
        private System.Windows.Forms.TextBox txtBatchNo;
    }
}