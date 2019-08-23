namespace WMS.WinCE.App
{
    partial class FrmDemolitionConfirmation
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
            this.txtTargetBarcode = new System.Windows.Forms.TextBox();
            this.lblTargetBarcode = new System.Windows.Forms.Label();
            this.txtSourceStoreCode = new System.Windows.Forms.TextBox();
            this.lblTargetStoreCode = new System.Windows.Forms.Label();
            this.txtTargetSpec = new System.Windows.Forms.TextBox();
            this.lblTargetSpec = new System.Windows.Forms.Label();
            this.txtTargetProductName = new System.Windows.Forms.TextBox();
            this.lblTargetProductName = new System.Windows.Forms.Label();
            this.lblTargetAmount = new System.Windows.Forms.Label();
            this.txtTargetBatchNo = new System.Windows.Forms.TextBox();
            this.lblTargetBatchNo = new System.Windows.Forms.Label();
            this.lblTransferInAmount = new System.Windows.Forms.Label();
            this.txtProductAmount = new System.Windows.Forms.TextBox();
            this.txtTransferInAmount = new System.Windows.Forms.TextBox();
            this.txtTargetPackageSpec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.muConfirm);
            this.mainMenu.MenuItems.Add(this.muBack);
            // 
            // muConfirm
            // 
            this.muConfirm.Text = "移位";
            this.muConfirm.Click += new System.EventHandler(this.muConfirm_Click);
            // 
            // muBack
            // 
            this.muBack.Text = "返回";
            this.muBack.Click += new System.EventHandler(this.muBack_Click);
            // 
            // txtTargetBarcode
            // 
            this.txtTargetBarcode.Location = new System.Drawing.Point(110, 32);
            this.txtTargetBarcode.Name = "txtTargetBarcode";
            this.txtTargetBarcode.Size = new System.Drawing.Size(193, 27);
            this.txtTargetBarcode.TabIndex = 1;
            this.txtTargetBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTargetBarcode_KeyPress);
            // 
            // lblTargetBarcode
            // 
            this.lblTargetBarcode.Location = new System.Drawing.Point(3, 34);
            this.lblTargetBarcode.Name = "lblTargetBarcode";
            this.lblTargetBarcode.Size = new System.Drawing.Size(101, 20);
            this.lblTargetBarcode.Text = "目标条码：";
            // 
            // txtSourceStoreCode
            // 
            this.txtSourceStoreCode.Location = new System.Drawing.Point(110, 61);
            this.txtSourceStoreCode.Name = "txtSourceStoreCode";
            this.txtSourceStoreCode.ReadOnly = true;
            this.txtSourceStoreCode.Size = new System.Drawing.Size(193, 27);
            this.txtSourceStoreCode.TabIndex = 2;
            // 
            // lblTargetStoreCode
            // 
            this.lblTargetStoreCode.Location = new System.Drawing.Point(3, 63);
            this.lblTargetStoreCode.Name = "lblTargetStoreCode";
            this.lblTargetStoreCode.Size = new System.Drawing.Size(101, 20);
            this.lblTargetStoreCode.Text = "原货位号：";
            // 
            // txtTargetSpec
            // 
            this.txtTargetSpec.Location = new System.Drawing.Point(110, 121);
            this.txtTargetSpec.Name = "txtTargetSpec";
            this.txtTargetSpec.ReadOnly = true;
            this.txtTargetSpec.Size = new System.Drawing.Size(193, 27);
            this.txtTargetSpec.TabIndex = 4;
            // 
            // lblTargetSpec
            // 
            this.lblTargetSpec.Location = new System.Drawing.Point(3, 123);
            this.lblTargetSpec.Name = "lblTargetSpec";
            this.lblTargetSpec.Size = new System.Drawing.Size(101, 20);
            this.lblTargetSpec.Text = "规　　格：";
            // 
            // txtTargetProductName
            // 
            this.txtTargetProductName.Location = new System.Drawing.Point(110, 91);
            this.txtTargetProductName.Name = "txtTargetProductName";
            this.txtTargetProductName.ReadOnly = true;
            this.txtTargetProductName.Size = new System.Drawing.Size(193, 27);
            this.txtTargetProductName.TabIndex = 3;
            // 
            // lblTargetProductName
            // 
            this.lblTargetProductName.Location = new System.Drawing.Point(3, 93);
            this.lblTargetProductName.Name = "lblTargetProductName";
            this.lblTargetProductName.Size = new System.Drawing.Size(101, 20);
            this.lblTargetProductName.Text = "药品名称：";
            // 
            // lblTargetAmount
            // 
            this.lblTargetAmount.Location = new System.Drawing.Point(3, 214);
            this.lblTargetAmount.Name = "lblTargetAmount";
            this.lblTargetAmount.Size = new System.Drawing.Size(101, 20);
            this.lblTargetAmount.Text = "药品数量：";
            // 
            // txtTargetBatchNo
            // 
            this.txtTargetBatchNo.Location = new System.Drawing.Point(110, 181);
            this.txtTargetBatchNo.Name = "txtTargetBatchNo";
            this.txtTargetBatchNo.ReadOnly = true;
            this.txtTargetBatchNo.Size = new System.Drawing.Size(193, 27);
            this.txtTargetBatchNo.TabIndex = 6;
            // 
            // lblTargetBatchNo
            // 
            this.lblTargetBatchNo.Location = new System.Drawing.Point(3, 183);
            this.lblTargetBatchNo.Name = "lblTargetBatchNo";
            this.lblTargetBatchNo.Size = new System.Drawing.Size(101, 20);
            this.lblTargetBatchNo.Text = "药品批号：";
            // 
            // lblTransferInAmount
            // 
            this.lblTransferInAmount.Location = new System.Drawing.Point(3, 242);
            this.lblTransferInAmount.Name = "lblTransferInAmount";
            this.lblTransferInAmount.Size = new System.Drawing.Size(101, 20);
            this.lblTransferInAmount.Text = "拆零数量：";
            // 
            // txtProductAmount
            // 
            this.txtProductAmount.Location = new System.Drawing.Point(110, 211);
            this.txtProductAmount.Name = "txtProductAmount";
            this.txtProductAmount.ReadOnly = true;
            this.txtProductAmount.Size = new System.Drawing.Size(193, 27);
            this.txtProductAmount.TabIndex = 7;
            // 
            // txtTransferInAmount
            // 
            this.txtTransferInAmount.Location = new System.Drawing.Point(110, 240);
            this.txtTransferInAmount.Name = "txtTransferInAmount";
            this.txtTransferInAmount.ReadOnly = true;
            this.txtTransferInAmount.Size = new System.Drawing.Size(193, 27);
            this.txtTransferInAmount.TabIndex = 8;
            // 
            // txtTargetPackageSpec
            // 
            this.txtTargetPackageSpec.Location = new System.Drawing.Point(110, 151);
            this.txtTargetPackageSpec.Name = "txtTargetPackageSpec";
            this.txtTargetPackageSpec.ReadOnly = true;
            this.txtTargetPackageSpec.Size = new System.Drawing.Size(193, 27);
            this.txtTargetPackageSpec.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.Text = "包装规格：";
            // 
            // FrmDemolitionConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(318, 275);
            this.ControlBox = false;
            this.Controls.Add(this.txtTargetPackageSpec);
            this.Controls.Add(this.txtTransferInAmount);
            this.Controls.Add(this.txtProductAmount);
            this.Controls.Add(this.txtTargetBatchNo);
            this.Controls.Add(this.txtTargetSpec);
            this.Controls.Add(this.txtTargetProductName);
            this.Controls.Add(this.txtSourceStoreCode);
            this.Controls.Add(this.txtTargetBarcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTransferInAmount);
            this.Controls.Add(this.lblTargetAmount);
            this.Controls.Add(this.lblTargetBatchNo);
            this.Controls.Add(this.lblTargetSpec);
            this.Controls.Add(this.lblTargetProductName);
            this.Controls.Add(this.lblTargetStoreCode);
            this.Controls.Add(this.lblTargetBarcode);
            this.Menu = this.mainMenu;
            this.Name = "FrmDemolitionConfirmation";
            this.Text = "药品拆零";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem muConfirm;
        private System.Windows.Forms.MenuItem muBack;
        private System.Windows.Forms.TextBox txtTargetBarcode;
        private System.Windows.Forms.Label lblTargetBarcode;
        private System.Windows.Forms.TextBox txtSourceStoreCode;
        private System.Windows.Forms.Label lblTargetStoreCode;
        private System.Windows.Forms.TextBox txtTargetSpec;
        private System.Windows.Forms.Label lblTargetSpec;
        private System.Windows.Forms.TextBox txtTargetProductName;
        private System.Windows.Forms.Label lblTargetProductName;
        private System.Windows.Forms.Label lblTargetAmount;
        private System.Windows.Forms.TextBox txtTargetBatchNo;
        private System.Windows.Forms.Label lblTargetBatchNo;
        private System.Windows.Forms.Label lblTransferInAmount;
        private System.Windows.Forms.TextBox txtProductAmount;
        private System.Windows.Forms.TextBox txtTransferInAmount;
        private System.Windows.Forms.TextBox txtTargetPackageSpec;
        private System.Windows.Forms.Label label1;
    }
}