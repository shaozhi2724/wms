﻿namespace WMS.SmartDevice.App
{
    partial class FrmDemolition
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
            this.muNext = new System.Windows.Forms.MenuItem();
            this.muBack = new System.Windows.Forms.MenuItem();
            this.txtSourceBarcode = new System.Windows.Forms.TextBox();
            this.lblSourceBarcode = new System.Windows.Forms.Label();
            this.txtSourceStoreCode = new System.Windows.Forms.TextBox();
            this.lblSourceStoreCode = new System.Windows.Forms.Label();
            this.txtSourceSpec = new System.Windows.Forms.TextBox();
            this.lblSourceSpec = new System.Windows.Forms.Label();
            this.txtSourceProductName = new System.Windows.Forms.TextBox();
            this.lblSourceProductName = new System.Windows.Forms.Label();
            this.lblSourceProductAmount = new System.Windows.Forms.Label();
            this.txtSourceBatchNo = new System.Windows.Forms.TextBox();
            this.lblSourceBatchNo = new System.Windows.Forms.Label();
            this.lblTransferOutAmount = new System.Windows.Forms.Label();
            this.txtTransferOutAmount = new System.Windows.Forms.NumericUpDown();
            this.txtSourceAmount = new System.Windows.Forms.TextBox();
            this.txtSourcePackageSpec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.muNext);
            this.mainMenu.MenuItems.Add(this.muBack);
            // 
            // muNext
            // 
            this.muNext.Text = "下一步";
            this.muNext.Click += new System.EventHandler(this.muNext_Click);
            // 
            // muBack
            // 
            this.muBack.Text = "返回";
            this.muBack.Click += new System.EventHandler(this.muBack_Click);
            // 
            // txtSourceBarcode
            // 
            this.txtSourceBarcode.Location = new System.Drawing.Point(86, 25);
            this.txtSourceBarcode.Name = "txtSourceBarcode";
            this.txtSourceBarcode.Size = new System.Drawing.Size(142, 21);
            this.txtSourceBarcode.TabIndex = 1;
            this.txtSourceBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSourceBarcode_KeyPress);
            // 
            // lblSourceBarcode
            // 
            this.lblSourceBarcode.Location = new System.Drawing.Point(6, 26);
            this.lblSourceBarcode.Name = "lblSourceBarcode";
            this.lblSourceBarcode.Size = new System.Drawing.Size(74, 20);
            this.lblSourceBarcode.Text = "原位条码：";
            // 
            // txtSourceStoreCode
            // 
            this.txtSourceStoreCode.Location = new System.Drawing.Point(86, 52);
            this.txtSourceStoreCode.Name = "txtSourceStoreCode";
            this.txtSourceStoreCode.ReadOnly = true;
            this.txtSourceStoreCode.Size = new System.Drawing.Size(142, 21);
            this.txtSourceStoreCode.TabIndex = 2;
            // 
            // lblSourceStoreCode
            // 
            this.lblSourceStoreCode.Location = new System.Drawing.Point(6, 53);
            this.lblSourceStoreCode.Name = "lblSourceStoreCode";
            this.lblSourceStoreCode.Size = new System.Drawing.Size(74, 20);
            this.lblSourceStoreCode.Text = "原货位号：";
            // 
            // txtSourceSpec
            // 
            this.txtSourceSpec.Location = new System.Drawing.Point(86, 106);
            this.txtSourceSpec.Name = "txtSourceSpec";
            this.txtSourceSpec.ReadOnly = true;
            this.txtSourceSpec.Size = new System.Drawing.Size(142, 21);
            this.txtSourceSpec.TabIndex = 4;
            // 
            // lblSourceSpec
            // 
            this.lblSourceSpec.Location = new System.Drawing.Point(6, 107);
            this.lblSourceSpec.Name = "lblSourceSpec";
            this.lblSourceSpec.Size = new System.Drawing.Size(74, 20);
            this.lblSourceSpec.Text = "规　　格：";
            // 
            // txtSourceProductName
            // 
            this.txtSourceProductName.Location = new System.Drawing.Point(86, 79);
            this.txtSourceProductName.Name = "txtSourceProductName";
            this.txtSourceProductName.ReadOnly = true;
            this.txtSourceProductName.Size = new System.Drawing.Size(142, 21);
            this.txtSourceProductName.TabIndex = 3;
            // 
            // lblSourceProductName
            // 
            this.lblSourceProductName.Location = new System.Drawing.Point(6, 80);
            this.lblSourceProductName.Name = "lblSourceProductName";
            this.lblSourceProductName.Size = new System.Drawing.Size(74, 20);
            this.lblSourceProductName.Text = "药品名称：";
            // 
            // lblSourceProductAmount
            // 
            this.lblSourceProductAmount.Location = new System.Drawing.Point(6, 196);
            this.lblSourceProductAmount.Name = "lblSourceProductAmount";
            this.lblSourceProductAmount.Size = new System.Drawing.Size(74, 20);
            this.lblSourceProductAmount.Text = "药品数量：";
            // 
            // txtSourceBatchNo
            // 
            this.txtSourceBatchNo.Location = new System.Drawing.Point(86, 167);
            this.txtSourceBatchNo.Name = "txtSourceBatchNo";
            this.txtSourceBatchNo.ReadOnly = true;
            this.txtSourceBatchNo.Size = new System.Drawing.Size(142, 21);
            this.txtSourceBatchNo.TabIndex = 6;
            // 
            // lblSourceBatchNo
            // 
            this.lblSourceBatchNo.Location = new System.Drawing.Point(6, 168);
            this.lblSourceBatchNo.Name = "lblSourceBatchNo";
            this.lblSourceBatchNo.Size = new System.Drawing.Size(74, 20);
            this.lblSourceBatchNo.Text = "药品批号：";
            // 
            // lblTransferOutAmount
            // 
            this.lblTransferOutAmount.Location = new System.Drawing.Point(6, 222);
            this.lblTransferOutAmount.Name = "lblTransferOutAmount";
            this.lblTransferOutAmount.Size = new System.Drawing.Size(74, 20);
            this.lblTransferOutAmount.Text = "拆零数量：";
            // 
            // txtTransferOutAmount
            // 
            this.txtTransferOutAmount.Location = new System.Drawing.Point(86, 222);
            this.txtTransferOutAmount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtTransferOutAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTransferOutAmount.Name = "txtTransferOutAmount";
            this.txtTransferOutAmount.Size = new System.Drawing.Size(142, 22);
            this.txtTransferOutAmount.TabIndex = 8;
            this.txtTransferOutAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtSourceAmount
            // 
            this.txtSourceAmount.Location = new System.Drawing.Point(86, 194);
            this.txtSourceAmount.Name = "txtSourceAmount";
            this.txtSourceAmount.ReadOnly = true;
            this.txtSourceAmount.Size = new System.Drawing.Size(142, 21);
            this.txtSourceAmount.TabIndex = 7;
            // 
            // txtSourcePackageSpec
            // 
            this.txtSourcePackageSpec.Location = new System.Drawing.Point(86, 136);
            this.txtSourcePackageSpec.Name = "txtSourcePackageSpec";
            this.txtSourcePackageSpec.ReadOnly = true;
            this.txtSourcePackageSpec.Size = new System.Drawing.Size(142, 21);
            this.txtSourcePackageSpec.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.Text = "包装规格：";
            // 
            // FrmDemolition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.txtSourcePackageSpec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTransferOutAmount);
            this.Controls.Add(this.lblTransferOutAmount);
            this.Controls.Add(this.lblSourceProductAmount);
            this.Controls.Add(this.txtSourceAmount);
            this.Controls.Add(this.txtSourceBatchNo);
            this.Controls.Add(this.lblSourceBatchNo);
            this.Controls.Add(this.txtSourceSpec);
            this.Controls.Add(this.lblSourceSpec);
            this.Controls.Add(this.txtSourceProductName);
            this.Controls.Add(this.lblSourceProductName);
            this.Controls.Add(this.txtSourceStoreCode);
            this.Controls.Add(this.lblSourceStoreCode);
            this.Controls.Add(this.txtSourceBarcode);
            this.Controls.Add(this.lblSourceBarcode);
            this.Menu = this.mainMenu;
            this.Name = "FrmDemolition";
            this.Text = "药品拆零";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem muNext;
        private System.Windows.Forms.MenuItem muBack;
        private System.Windows.Forms.TextBox txtSourceBarcode;
        private System.Windows.Forms.Label lblSourceBarcode;
        private System.Windows.Forms.TextBox txtSourceStoreCode;
        private System.Windows.Forms.Label lblSourceStoreCode;
        private System.Windows.Forms.TextBox txtSourceSpec;
        private System.Windows.Forms.Label lblSourceSpec;
        private System.Windows.Forms.TextBox txtSourceProductName;
        private System.Windows.Forms.Label lblSourceProductName;
        private System.Windows.Forms.Label lblSourceProductAmount;
        private System.Windows.Forms.TextBox txtSourceBatchNo;
        private System.Windows.Forms.Label lblSourceBatchNo;
        private System.Windows.Forms.Label lblTransferOutAmount;
        private System.Windows.Forms.NumericUpDown txtTransferOutAmount;
        private System.Windows.Forms.TextBox txtSourceAmount;
        private System.Windows.Forms.TextBox txtSourcePackageSpec;
        private System.Windows.Forms.Label label1;
    }
}