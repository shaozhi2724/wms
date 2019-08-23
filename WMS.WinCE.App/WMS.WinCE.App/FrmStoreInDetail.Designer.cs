namespace WMS.WinCE.App
{
    partial class FrmStoreInDetail
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabTasks = new System.Windows.Forms.TabPage();
            this.lvwStoreDetails = new System.Windows.Forms.ListView();
            this.colStoreDetailID = new System.Windows.Forms.ColumnHeader();
            this.colProductName = new System.Windows.Forms.ColumnHeader();
            this.colBatchNo = new System.Windows.Forms.ColumnHeader();
            this.colPackageSpec = new System.Windows.Forms.ColumnHeader();
            this.colProductSpec = new System.Windows.Forms.ColumnHeader();
            this.colAmount = new System.Windows.Forms.ColumnHeader();
            this.colStructureCode = new System.Windows.Forms.ColumnHeader();
            this.tabDetail = new System.Windows.Forms.TabPage();
            this.txtRecommendPosition = new System.Windows.Forms.TextBox();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtPackageSpec = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtBatchNo = new System.Windows.Forms.TextBox();
            this.lblRecomment = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblSpec = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblStoreCode = new System.Windows.Forms.Label();
            this.lblBatchNo = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabTasks.SuspendLayout();
            this.tabDetail.SuspendLayout();
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabTasks);
            this.tabControl.Controls.Add(this.tabDetail);
            this.tabControl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.tabControl.Location = new System.Drawing.Point(6, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(298, 232);
            this.tabControl.TabIndex = 0;
            // 
            // tabTasks
            // 
            this.tabTasks.AutoScroll = true;
            this.tabTasks.Controls.Add(this.lvwStoreDetails);
            this.tabTasks.Location = new System.Drawing.Point(4, 23);
            this.tabTasks.Name = "tabTasks";
            this.tabTasks.Size = new System.Drawing.Size(290, 205);
            this.tabTasks.Text = "入库任务";
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
            this.lvwStoreDetails.Columns.Add(this.colStructureCode);
            this.lvwStoreDetails.FullRowSelect = true;
            this.lvwStoreDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwStoreDetails.Location = new System.Drawing.Point(5, 7);
            this.lvwStoreDetails.Name = "lvwStoreDetails";
            this.lvwStoreDetails.Size = new System.Drawing.Size(276, 195);
            this.lvwStoreDetails.TabIndex = 0;
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
            // colStructureCode
            // 
            this.colStructureCode.Text = "货位号";
            this.colStructureCode.Width = 60;
            // 
            // tabDetail
            // 
            this.tabDetail.AutoScroll = true;
            this.tabDetail.Controls.Add(this.txtRecommendPosition);
            this.tabDetail.Controls.Add(this.txtSpec);
            this.tabDetail.Controls.Add(this.txtArea);
            this.tabDetail.Controls.Add(this.txtAmount);
            this.tabDetail.Controls.Add(this.txtPackageSpec);
            this.tabDetail.Controls.Add(this.txtBarcode);
            this.tabDetail.Controls.Add(this.txtProductName);
            this.tabDetail.Controls.Add(this.txtBatchNo);
            this.tabDetail.Controls.Add(this.lblRecomment);
            this.tabDetail.Controls.Add(this.lblArea);
            this.tabDetail.Controls.Add(this.lblSpec);
            this.tabDetail.Controls.Add(this.lblCode);
            this.tabDetail.Controls.Add(this.lblProductName);
            this.tabDetail.Controls.Add(this.lblBarcode);
            this.tabDetail.Controls.Add(this.lblStoreCode);
            this.tabDetail.Controls.Add(this.lblBatchNo);
            this.tabDetail.Location = new System.Drawing.Point(4, 23);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.Size = new System.Drawing.Size(290, 205);
            this.tabDetail.Text = "入库明细";
            // 
            // txtRecommendPosition
            // 
            this.txtRecommendPosition.Location = new System.Drawing.Point(100, 153);
            this.txtRecommendPosition.Name = "txtRecommendPosition";
            this.txtRecommendPosition.ReadOnly = true;
            this.txtRecommendPosition.Size = new System.Drawing.Size(184, 23);
            this.txtRecommendPosition.TabIndex = 9;
            // 
            // txtSpec
            // 
            this.txtSpec.Location = new System.Drawing.Point(100, 77);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.ReadOnly = true;
            this.txtSpec.Size = new System.Drawing.Size(184, 23);
            this.txtSpec.TabIndex = 6;
            this.txtSpec.TabStop = false;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(100, 127);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(184, 23);
            this.txtArea.TabIndex = 8;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(100, 101);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(184, 23);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.TabStop = false;
            // 
            // txtPackageSpec
            // 
            this.txtPackageSpec.Location = new System.Drawing.Point(100, 52);
            this.txtPackageSpec.Name = "txtPackageSpec";
            this.txtPackageSpec.ReadOnly = true;
            this.txtPackageSpec.Size = new System.Drawing.Size(184, 23);
            this.txtPackageSpec.TabIndex = 4;
            this.txtPackageSpec.TabStop = false;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(100, 180);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(184, 23);
            this.txtBarcode.TabIndex = 1;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(100, 3);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(184, 23);
            this.txtProductName.TabIndex = 2;
            this.txtProductName.TabStop = false;
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Location = new System.Drawing.Point(100, 27);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.ReadOnly = true;
            this.txtBatchNo.Size = new System.Drawing.Size(184, 23);
            this.txtBatchNo.TabIndex = 3;
            this.txtBatchNo.TabStop = false;
            // 
            // lblRecomment
            // 
            this.lblRecomment.Location = new System.Drawing.Point(3, 156);
            this.lblRecomment.Name = "lblRecomment";
            this.lblRecomment.Size = new System.Drawing.Size(105, 20);
            this.lblRecomment.Text = "分配货位：";
            // 
            // lblArea
            // 
            this.lblArea.Location = new System.Drawing.Point(3, 130);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(105, 20);
            this.lblArea.Text = "存放库区：";
            // 
            // lblSpec
            // 
            this.lblSpec.Location = new System.Drawing.Point(3, 79);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(105, 20);
            this.lblSpec.Text = "　　规格：";
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(3, 55);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(105, 20);
            this.lblCode.Text = "包装规格：";
            // 
            // lblProductName
            // 
            this.lblProductName.Location = new System.Drawing.Point(3, 5);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(105, 20);
            this.lblProductName.Text = "药品名称：";
            // 
            // lblBarcode
            // 
            this.lblBarcode.Location = new System.Drawing.Point(3, 183);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(105, 20);
            this.lblBarcode.Text = "确认货位：";
            // 
            // lblStoreCode
            // 
            this.lblStoreCode.Location = new System.Drawing.Point(3, 103);
            this.lblStoreCode.Name = "lblStoreCode";
            this.lblStoreCode.Size = new System.Drawing.Size(105, 20);
            this.lblStoreCode.Text = "存放数量：";
            // 
            // lblBatchNo
            // 
            this.lblBatchNo.Location = new System.Drawing.Point(3, 29);
            this.lblBatchNo.Name = "lblBatchNo";
            this.lblBatchNo.Size = new System.Drawing.Size(105, 20);
            this.lblBatchNo.Text = "药品批号：";
            // 
            // FrmStoreInDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(318, 275);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl);
            this.Menu = this.mainMenu;
            this.Name = "FrmStoreInDetail";
            this.Text = "药品入库";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmStoreInDetail_Activated);
            this.tabControl.ResumeLayout(false);
            this.tabTasks.ResumeLayout(false);
            this.tabDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem muSaveStoreIn;
        private System.Windows.Forms.MenuItem muBack;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTasks;
        private System.Windows.Forms.ListView lvwStoreDetails;
        private System.Windows.Forms.ColumnHeader colStoreDetailID;
        private System.Windows.Forms.ColumnHeader colProductName;
        private System.Windows.Forms.ColumnHeader colBatchNo;
        private System.Windows.Forms.ColumnHeader colProductSpec;
        private System.Windows.Forms.ColumnHeader colAmount;
        private System.Windows.Forms.ColumnHeader colStructureCode;
        private System.Windows.Forms.TabPage tabDetail;
        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.Label lblSpec;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtPackageSpec;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblStoreCode;
        private System.Windows.Forms.Label lblBatchNo;
        private System.Windows.Forms.TextBox txtBatchNo;
        private System.Windows.Forms.TextBox txtRecommendPosition;
        private System.Windows.Forms.Label lblRecomment;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ColumnHeader colPackageSpec;
    }
}