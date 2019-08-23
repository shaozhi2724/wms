namespace WMS.WinCE.App
{
    partial class FrmProductDestroy
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
            this.txtDestroyDate = new System.Windows.Forms.TextBox();
            this.mainMenu = new System.Windows.Forms.MainMenu();
            this.muDestroy = new System.Windows.Forms.MenuItem();
            this.muBack = new System.Windows.Forms.MenuItem();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtDestroyCode = new System.Windows.Forms.TextBox();
            this.txtDestroyCause = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lvwDestroyBills = new System.Windows.Forms.ListView();
            this.colDestroyId = new System.Windows.Forms.ColumnHeader();
            this.colDestroyCode = new System.Windows.Forms.ColumnHeader();
            this.colDestroyCause = new System.Windows.Forms.ColumnHeader();
            this.colDestroyDate = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // txtDestroyDate
            // 
            this.txtDestroyDate.AcceptsReturn = true;
            this.txtDestroyDate.AcceptsTab = true;
            this.txtDestroyDate.Location = new System.Drawing.Point(98, 89);
            this.txtDestroyDate.Name = "txtDestroyDate";
            this.txtDestroyDate.ReadOnly = true;
            this.txtDestroyDate.Size = new System.Drawing.Size(205, 23);
            this.txtDestroyDate.TabIndex = 3;
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
            this.lblCode.Location = new System.Drawing.Point(4, 37);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(105, 24);
            this.lblCode.Text = "销毁单号：";
            // 
            // txtDestroyCode
            // 
            this.txtDestroyCode.AcceptsReturn = true;
            this.txtDestroyCode.AcceptsTab = true;
            this.txtDestroyCode.Location = new System.Drawing.Point(98, 36);
            this.txtDestroyCode.Name = "txtDestroyCode";
            this.txtDestroyCode.ReadOnly = true;
            this.txtDestroyCode.Size = new System.Drawing.Size(205, 23);
            this.txtDestroyCode.TabIndex = 1;
            // 
            // txtDestroyCause
            // 
            this.txtDestroyCause.AcceptsReturn = true;
            this.txtDestroyCause.AcceptsTab = true;
            this.txtDestroyCause.Location = new System.Drawing.Point(98, 62);
            this.txtDestroyCause.Name = "txtDestroyCause";
            this.txtDestroyCause.ReadOnly = true;
            this.txtDestroyCause.Size = new System.Drawing.Size(205, 23);
            this.txtDestroyCause.TabIndex = 2;
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(4, 64);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(105, 23);
            this.lblType.Text = "销毁原因：";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(4, 91);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(105, 22);
            this.lblDate.Text = "销毁时间：";
            // 
            // lvwDestroyBills
            // 
            this.lvwDestroyBills.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwDestroyBills.Columns.Add(this.colDestroyId);
            this.lvwDestroyBills.Columns.Add(this.colDestroyCode);
            this.lvwDestroyBills.Columns.Add(this.colDestroyCause);
            this.lvwDestroyBills.Columns.Add(this.colDestroyDate);
            this.lvwDestroyBills.FullRowSelect = true;
            this.lvwDestroyBills.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwDestroyBills.Location = new System.Drawing.Point(4, 120);
            this.lvwDestroyBills.Name = "lvwDestroyBills";
            this.lvwDestroyBills.Size = new System.Drawing.Size(299, 141);
            this.lvwDestroyBills.TabIndex = 4;
            this.lvwDestroyBills.View = System.Windows.Forms.View.Details;
            this.lvwDestroyBills.ItemActivate += new System.EventHandler(this.lvwStoreBills_ItemActivate);
            // 
            // colDestroyId
            // 
            this.colDestroyId.Text = "序号";
            this.colDestroyId.Width = 60;
            // 
            // colDestroyCode
            // 
            this.colDestroyCode.Text = "销毁单号";
            this.colDestroyCode.Width = 88;
            // 
            // colDestroyCause
            // 
            this.colDestroyCause.Text = "销毁原因";
            this.colDestroyCause.Width = 86;
            // 
            // colDestroyDate
            // 
            this.colDestroyDate.Text = "销毁时间";
            this.colDestroyDate.Width = 62;
            // 
            // FrmProductDestroy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(228, 297);
            this.ControlBox = false;
            this.Controls.Add(this.txtDestroyDate);
            this.Controls.Add(this.txtDestroyCause);
            this.Controls.Add(this.txtDestroyCode);
            this.Controls.Add(this.lvwDestroyBills);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblCode);
            this.Menu = this.mainMenu;
            this.Name = "FrmProductDestroy";
            this.Text = "药品销毁单据";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem muDestroy;
        private System.Windows.Forms.TextBox txtDestroyCode;
        private System.Windows.Forms.MenuItem muBack;
        private System.Windows.Forms.TextBox txtDestroyCause;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDestroyDate;
        private System.Windows.Forms.ListView lvwDestroyBills;
        private System.Windows.Forms.ColumnHeader colDestroyId;
        private System.Windows.Forms.ColumnHeader colDestroyCode;
        private System.Windows.Forms.ColumnHeader colDestroyCause;
        private System.Windows.Forms.ColumnHeader colDestroyDate;
        private System.Windows.Forms.Label lblCode;
    }
}