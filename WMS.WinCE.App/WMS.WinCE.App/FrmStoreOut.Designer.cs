﻿namespace WMS.WinCE.App
{
    partial class FrmStoreOut
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
            this.txtDealerName = new System.Windows.Forms.TextBox();
            this.mainMenu = new System.Windows.Forms.MainMenu();
            this.muStoreOut = new System.Windows.Forms.MenuItem();
            this.muBack = new System.Windows.Forms.MenuItem();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtStoreCode = new System.Windows.Forms.TextBox();
            this.txtStoreTypeName = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDealer = new System.Windows.Forms.Label();
            this.lvwStoreBills = new System.Windows.Forms.ListView();
            this.colStoreId = new System.Windows.Forms.ColumnHeader();
            this.colStoreCode = new System.Windows.Forms.ColumnHeader();
            this.colStoreTypeName = new System.Windows.Forms.ColumnHeader();
            this.colDealerName = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // txtDealerName
            // 
            this.txtDealerName.AcceptsReturn = true;
            this.txtDealerName.AcceptsTab = true;
            this.txtDealerName.Location = new System.Drawing.Point(100, 95);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.ReadOnly = true;
            this.txtDealerName.Size = new System.Drawing.Size(215, 23);
            this.txtDealerName.TabIndex = 3;
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.muStoreOut);
            this.mainMenu.MenuItems.Add(this.muBack);
            // 
            // muStoreOut
            // 
            this.muStoreOut.Text = "出库";
            this.muStoreOut.Click += new System.EventHandler(this.muStoreOut_Click);
            // 
            // muBack
            // 
            this.muBack.Text = "返回";
            this.muBack.Click += new System.EventHandler(this.muBack_Click);
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(3, 39);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(100, 27);
            this.lblCode.Text = "出库单号：";
            // 
            // txtStoreCode
            // 
            this.txtStoreCode.AcceptsReturn = true;
            this.txtStoreCode.AcceptsTab = true;
            this.txtStoreCode.Location = new System.Drawing.Point(100, 38);
            this.txtStoreCode.Name = "txtStoreCode";
            this.txtStoreCode.ReadOnly = true;
            this.txtStoreCode.Size = new System.Drawing.Size(215, 23);
            this.txtStoreCode.TabIndex = 1;
            // 
            // txtStoreTypeName
            // 
            this.txtStoreTypeName.AcceptsReturn = true;
            this.txtStoreTypeName.AcceptsTab = true;
            this.txtStoreTypeName.Location = new System.Drawing.Point(100, 66);
            this.txtStoreTypeName.Name = "txtStoreTypeName";
            this.txtStoreTypeName.ReadOnly = true;
            this.txtStoreTypeName.Size = new System.Drawing.Size(215, 23);
            this.txtStoreTypeName.TabIndex = 2;
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(3, 68);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(100, 27);
            this.lblType.Text = "出库类型：";
            // 
            // lblDealer
            // 
            this.lblDealer.Location = new System.Drawing.Point(3, 96);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(100, 27);
            this.lblDealer.Text = "往来单位：";
            // 
            // lvwStoreBills
            // 
            this.lvwStoreBills.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwStoreBills.Columns.Add(this.colStoreId);
            this.lvwStoreBills.Columns.Add(this.colStoreCode);
            this.lvwStoreBills.Columns.Add(this.colStoreTypeName);
            this.lvwStoreBills.Columns.Add(this.colDealerName);
            this.lvwStoreBills.FullRowSelect = true;
            this.lvwStoreBills.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwStoreBills.Location = new System.Drawing.Point(3, 129);
            this.lvwStoreBills.Name = "lvwStoreBills";
            this.lvwStoreBills.Size = new System.Drawing.Size(312, 136);
            this.lvwStoreBills.TabIndex = 4;
            this.lvwStoreBills.View = System.Windows.Forms.View.Details;
            this.lvwStoreBills.ItemActivate += new System.EventHandler(this.lvwStoreBills_ItemActivate);
            // 
            // colStoreId
            // 
            this.colStoreId.Text = "序号";
            this.colStoreId.Width = 60;
            // 
            // colStoreCode
            // 
            this.colStoreCode.Text = "出库单号";
            this.colStoreCode.Width = 80;
            // 
            // colStoreTypeName
            // 
            this.colStoreTypeName.Text = "出库类型";
            this.colStoreTypeName.Width = 81;
            // 
            // colDealerName
            // 
            this.colDealerName.Text = "往来单位";
            this.colDealerName.Width = 87;
            // 
            // FrmStoreOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(318, 275);
            this.ControlBox = false;
            this.Controls.Add(this.txtDealerName);
            this.Controls.Add(this.txtStoreTypeName);
            this.Controls.Add(this.txtStoreCode);
            this.Controls.Add(this.lvwStoreBills);
            this.Controls.Add(this.lblDealer);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblCode);
            this.Menu = this.mainMenu;
            this.Name = "FrmStoreOut";
            this.Text = "药品出库单据";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem muStoreOut;
        private System.Windows.Forms.TextBox txtStoreCode;
        private System.Windows.Forms.MenuItem muBack;
        private System.Windows.Forms.TextBox txtStoreTypeName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.TextBox txtDealerName;
        private System.Windows.Forms.ListView lvwStoreBills;
        private System.Windows.Forms.ColumnHeader colStoreId;
        private System.Windows.Forms.ColumnHeader colStoreCode;
        private System.Windows.Forms.ColumnHeader colStoreTypeName;
        private System.Windows.Forms.ColumnHeader colDealerName;
        private System.Windows.Forms.Label lblCode;
    }
}