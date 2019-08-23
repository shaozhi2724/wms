namespace WMS.SmartDevice.App
{
    partial class FrmProductSummary
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
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.mainMenu = new System.Windows.Forms.MainMenu();
            this.muStartTask = new System.Windows.Forms.MenuItem();
            this.muBack = new System.Windows.Forms.MenuItem();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtInventoryStatisticCode = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lvwTask = new System.Windows.Forms.ListView();
            this.colTaskId = new System.Windows.Forms.ColumnHeader();
            this.colTaskCode = new System.Windows.Forms.ColumnHeader();
            this.colStartDate = new System.Windows.Forms.ColumnHeader();
            this.colEndDate = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // txtEndDate
            // 
            this.txtEndDate.AcceptsReturn = true;
            this.txtEndDate.AcceptsTab = true;
            this.txtEndDate.Location = new System.Drawing.Point(84, 71);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(149, 25);
            this.txtEndDate.TabIndex = 3;
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.muStartTask);
            this.mainMenu.MenuItems.Add(this.muBack);
            // 
            // muStartTask
            // 
            this.muStartTask.Text = "开始盘点";
            this.muStartTask.Click += new System.EventHandler(this.muStartTask_Click);
            // 
            // muBack
            // 
            this.muBack.Text = "返回";
            this.muBack.Click += new System.EventHandler(this.muBack_Click);
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(4, 15);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(92, 24);
            this.lblCode.Text = "盘点单号：";
            // 
            // txtInventoryStatisticCode
            // 
            this.txtInventoryStatisticCode.AcceptsReturn = true;
            this.txtInventoryStatisticCode.AcceptsTab = true;
            this.txtInventoryStatisticCode.Location = new System.Drawing.Point(84, 14);
            this.txtInventoryStatisticCode.Name = "txtInventoryStatisticCode";
            this.txtInventoryStatisticCode.ReadOnly = true;
            this.txtInventoryStatisticCode.Size = new System.Drawing.Size(149, 25);
            this.txtInventoryStatisticCode.TabIndex = 1;
            // 
            // txtStartDate
            // 
            this.txtStartDate.AcceptsReturn = true;
            this.txtStartDate.AcceptsTab = true;
            this.txtStartDate.Location = new System.Drawing.Point(84, 42);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(149, 25);
            this.txtStartDate.TabIndex = 2;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Location = new System.Drawing.Point(4, 45);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(92, 23);
            this.lblStartDate.Text = "开始时间：";
            // 
            // lblEndDate
            // 
            this.lblEndDate.Location = new System.Drawing.Point(4, 74);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(92, 22);
            this.lblEndDate.Text = "结束时间：";
            // 
            // lvwTask
            // 
            this.lvwTask.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwTask.Columns.Add(this.colTaskId);
            this.lvwTask.Columns.Add(this.colTaskCode);
            this.lvwTask.Columns.Add(this.colStartDate);
            this.lvwTask.Columns.Add(this.colEndDate);
            this.lvwTask.FullRowSelect = true;
            this.lvwTask.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwTask.Location = new System.Drawing.Point(4, 105);
            this.lvwTask.Name = "lvwTask";
            this.lvwTask.Size = new System.Drawing.Size(229, 158);
            this.lvwTask.TabIndex = 4;
            this.lvwTask.View = System.Windows.Forms.View.Details;
            this.lvwTask.ItemActivate += new System.EventHandler(this.lvwTask_ItemActivate);
            // 
            // colTaskId
            // 
            this.colTaskId.Text = "序号";
            this.colTaskId.Width = 60;
            // 
            // colTaskCode
            // 
            this.colTaskCode.Text = "盘点单号";
            this.colTaskCode.Width = 60;
            // 
            // colStartDate
            // 
            this.colStartDate.Text = "开始时间";
            this.colStartDate.Width = 60;
            // 
            // colEndDate
            // 
            this.colEndDate.Text = "结束时间";
            this.colEndDate.Width = 60;
            // 
            // FrmProductSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 266);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtInventoryStatisticCode);
            this.Controls.Add(this.lvwTask);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblCode);
            this.Menu = this.mainMenu;
            this.Name = "FrmProductSummary";
            this.Text = "药品盘点任务";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem muStartTask;
        private System.Windows.Forms.TextBox txtInventoryStatisticCode;
        private System.Windows.Forms.MenuItem muBack;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.ListView lvwTask;
        private System.Windows.Forms.ColumnHeader colTaskId;
        private System.Windows.Forms.ColumnHeader colTaskCode;
        private System.Windows.Forms.ColumnHeader colStartDate;
        private System.Windows.Forms.ColumnHeader colEndDate;
        private System.Windows.Forms.Label lblCode;
    }
}