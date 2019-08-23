namespace WMS.WinCE.App
{
    partial class FrmMain
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
            this.muExit = new System.Windows.Forms.MenuItem();
            this.muSetting = new System.Windows.Forms.MenuItem();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnDemolition = new System.Windows.Forms.Button();
            this.btnCollection = new System.Windows.Forms.Button();
            this.btnProductSummary = new System.Windows.Forms.Button();
            this.btnInitStoreIn = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnStoreIn = new System.Windows.Forms.Button();
            this.btnStoreOut = new System.Windows.Forms.Button();
            this.btnUnqualifiedStoreIn = new System.Windows.Forms.Button();
            this.btnUnqualifiedMove = new System.Windows.Forms.Button();
            this.panUnqualified = new System.Windows.Forms.Panel();
            this.lblUnqualified = new System.Windows.Forms.Label();
            this.btnPurchaseReturn = new System.Windows.Forms.Button();
            this.btnDestroy = new System.Windows.Forms.Button();
            this.panUnqualified.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.muExit);
            this.mainMenu.MenuItems.Add(this.muSetting);
            // 
            // muExit
            // 
            this.muExit.Text = "退出";
            this.muExit.Click += new System.EventHandler(this.muExit_Click);
            // 
            // muSetting
            // 
            this.muSetting.Text = "设置";
            this.muSetting.Click += new System.EventHandler(this.muSetting_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(47, 65);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(104, 30);
            this.btnTransfer.TabIndex = 3;
            this.btnTransfer.Text = "药品移库";
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnDemolition
            // 
            this.btnDemolition.Location = new System.Drawing.Point(172, 65);
            this.btnDemolition.Name = "btnDemolition";
            this.btnDemolition.Size = new System.Drawing.Size(104, 30);
            this.btnDemolition.TabIndex = 4;
            this.btnDemolition.Text = "药品拆零";
            this.btnDemolition.Click += new System.EventHandler(this.btnDemolition_Click);
            // 
            // btnCollection
            // 
            this.btnCollection.Location = new System.Drawing.Point(47, 99);
            this.btnCollection.Name = "btnCollection";
            this.btnCollection.Size = new System.Drawing.Size(104, 30);
            this.btnCollection.TabIndex = 5;
            this.btnCollection.Text = "信息采集";
            this.btnCollection.Click += new System.EventHandler(this.btnCollection_Click);
            // 
            // btnProductSummary
            // 
            this.btnProductSummary.Location = new System.Drawing.Point(172, 99);
            this.btnProductSummary.Name = "btnProductSummary";
            this.btnProductSummary.Size = new System.Drawing.Size(104, 30);
            this.btnProductSummary.TabIndex = 6;
            this.btnProductSummary.Text = "药品盘点";
            this.btnProductSummary.Click += new System.EventHandler(this.btnProductSummary_Click);
            // 
            // btnInitStoreIn
            // 
            this.btnInitStoreIn.Location = new System.Drawing.Point(47, 134);
            this.btnInitStoreIn.Name = "btnInitStoreIn";
            this.btnInitStoreIn.Size = new System.Drawing.Size(104, 30);
            this.btnInitStoreIn.TabIndex = 7;
            this.btnInitStoreIn.Text = "期初入库";
            this.btnInitStoreIn.Click += new System.EventHandler(this.btnInitStoreIn_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(172, 134);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(104, 30);
            this.btnInventory.TabIndex = 8;
            this.btnInventory.Text = "库存查询";
            this.btnInventory.Click += new System.EventHandler(this.btnInventoryQuery_Click);
            // 
            // btnStoreIn
            // 
            this.btnStoreIn.Location = new System.Drawing.Point(47, 31);
            this.btnStoreIn.Name = "btnStoreIn";
            this.btnStoreIn.Size = new System.Drawing.Size(104, 30);
            this.btnStoreIn.TabIndex = 1;
            this.btnStoreIn.Text = "药品入库";
            this.btnStoreIn.Click += new System.EventHandler(this.btnStoreIn_Click);
            // 
            // btnStoreOut
            // 
            this.btnStoreOut.Location = new System.Drawing.Point(172, 31);
            this.btnStoreOut.Name = "btnStoreOut";
            this.btnStoreOut.Size = new System.Drawing.Size(104, 30);
            this.btnStoreOut.TabIndex = 2;
            this.btnStoreOut.Text = "药品出库";
            this.btnStoreOut.Click += new System.EventHandler(this.btnStoreOut_Click);
            // 
            // btnUnqualifiedStoreIn
            // 
            this.btnUnqualifiedStoreIn.Location = new System.Drawing.Point(7, 28);
            this.btnUnqualifiedStoreIn.Name = "btnUnqualifiedStoreIn";
            this.btnUnqualifiedStoreIn.Size = new System.Drawing.Size(100, 30);
            this.btnUnqualifiedStoreIn.TabIndex = 9;
            this.btnUnqualifiedStoreIn.Text = "入库";
            this.btnUnqualifiedStoreIn.Click += new System.EventHandler(this.btnUnqualifiedStoreIn_Click);
            // 
            // btnUnqualifiedMove
            // 
            this.btnUnqualifiedMove.Location = new System.Drawing.Point(128, 28);
            this.btnUnqualifiedMove.Name = "btnUnqualifiedMove";
            this.btnUnqualifiedMove.Size = new System.Drawing.Size(102, 30);
            this.btnUnqualifiedMove.TabIndex = 10;
            this.btnUnqualifiedMove.Text = "移库";
            this.btnUnqualifiedMove.Click += new System.EventHandler(this.btnUnqualifiedMove_Click);
            // 
            // panUnqualified
            // 
            this.panUnqualified.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panUnqualified.Controls.Add(this.lblUnqualified);
            this.panUnqualified.Controls.Add(this.btnUnqualifiedMove);
            this.panUnqualified.Controls.Add(this.btnUnqualifiedStoreIn);
            this.panUnqualified.Location = new System.Drawing.Point(44, 168);
            this.panUnqualified.Name = "panUnqualified";
            this.panUnqualified.Size = new System.Drawing.Size(235, 62);
            // 
            // lblUnqualified
            // 
            this.lblUnqualified.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblUnqualified.Location = new System.Drawing.Point(67, 6);
            this.lblUnqualified.Name = "lblUnqualified";
            this.lblUnqualified.Size = new System.Drawing.Size(79, 20);
            this.lblUnqualified.Text = "不合格品";
            // 
            // btnPurchaseReturn
            // 
            this.btnPurchaseReturn.Location = new System.Drawing.Point(47, 236);
            this.btnPurchaseReturn.Name = "btnPurchaseReturn";
            this.btnPurchaseReturn.Size = new System.Drawing.Size(104, 30);
            this.btnPurchaseReturn.TabIndex = 12;
            this.btnPurchaseReturn.Text = "采购退回";
            this.btnPurchaseReturn.Click += new System.EventHandler(this.btnPurchaseReturn_Click);
            // 
            // btnDestroy
            // 
            this.btnDestroy.Location = new System.Drawing.Point(170, 236);
            this.btnDestroy.Name = "btnDestroy";
            this.btnDestroy.Size = new System.Drawing.Size(104, 30);
            this.btnDestroy.TabIndex = 14;
            this.btnDestroy.Text = "药品销毁";
            this.btnDestroy.Click += new System.EventHandler(this.btnDestroy_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(245, 297);
            this.ControlBox = false;
            this.Controls.Add(this.btnDestroy);
            this.Controls.Add(this.btnPurchaseReturn);
            this.Controls.Add(this.btnStoreOut);
            this.Controls.Add(this.btnStoreIn);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnInitStoreIn);
            this.Controls.Add(this.btnProductSummary);
            this.Controls.Add(this.btnCollection);
            this.Controls.Add(this.btnDemolition);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.panUnqualified);
            this.Menu = this.mainMenu;
            this.Name = "FrmMain";
            this.Text = "DQS RF扫描系统－博科智信";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panUnqualified.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem muExit;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnDemolition;
        private System.Windows.Forms.Button btnCollection;
        private System.Windows.Forms.Button btnProductSummary;
        private System.Windows.Forms.Button btnInitStoreIn;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnStoreIn;
        private System.Windows.Forms.Button btnStoreOut;
        private System.Windows.Forms.MenuItem muSetting;
        private System.Windows.Forms.Button btnUnqualifiedStoreIn;
        private System.Windows.Forms.Button btnUnqualifiedMove;
        private System.Windows.Forms.Panel panUnqualified;
        private System.Windows.Forms.Label lblUnqualified;
        private System.Windows.Forms.Button btnPurchaseReturn;
        private System.Windows.Forms.Button btnDestroy;
    }
}

