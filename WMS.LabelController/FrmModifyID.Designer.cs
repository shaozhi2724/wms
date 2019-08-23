namespace WMS.LabelController
{
    partial class FrmModifyID
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOldIDInfo = new System.Windows.Forms.Label();
            this.lblNewIDInfo = new System.Windows.Forms.Label();
            this.txtNewID = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblOldID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOldIDInfo
            // 
            this.lblOldIDInfo.AutoSize = true;
            this.lblOldIDInfo.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblOldIDInfo.Location = new System.Drawing.Point(24, 44);
            this.lblOldIDInfo.Name = "lblOldIDInfo";
            this.lblOldIDInfo.Size = new System.Drawing.Size(57, 17);
            this.lblOldIDInfo.TabIndex = 4;
            this.lblOldIDInfo.Text = "旧ID号：";
            // 
            // lblNewIDInfo
            // 
            this.lblNewIDInfo.AutoSize = true;
            this.lblNewIDInfo.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblNewIDInfo.Location = new System.Drawing.Point(24, 112);
            this.lblNewIDInfo.Name = "lblNewIDInfo";
            this.lblNewIDInfo.Size = new System.Drawing.Size(57, 17);
            this.lblNewIDInfo.TabIndex = 5;
            this.lblNewIDInfo.Text = "新ID号：";
            // 
            // txtNewID
            // 
            this.txtNewID.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtNewID.Location = new System.Drawing.Point(115, 107);
            this.txtNewID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewID.MaxLength = 4;
            this.txtNewID.Name = "txtNewID";
            this.txtNewID.Size = new System.Drawing.Size(216, 23);
            this.txtNewID.TabIndex = 0;
            this.txtNewID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewID_KeyPress);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(363, 35);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 39);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(363, 105);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 39);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblOldID
            // 
            this.lblOldID.AutoSize = true;
            this.lblOldID.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblOldID.Location = new System.Drawing.Point(111, 44);
            this.lblOldID.Name = "lblOldID";
            this.lblOldID.Size = new System.Drawing.Size(36, 17);
            this.lblOldID.TabIndex = 3;
            this.lblOldID.Text = "1001";
            // 
            // FrmModifyID
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 179);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNewID);
            this.Controls.Add(this.lblNewIDInfo);
            this.Controls.Add(this.lblOldID);
            this.Controls.Add(this.lblOldIDInfo);
            this.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModifyID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改ID号";
            this.Load += new System.EventHandler(this.FrmModifyID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOldIDInfo;
        private System.Windows.Forms.Label lblNewIDInfo;
        private System.Windows.Forms.TextBox txtNewID;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblOldID;
    }
}