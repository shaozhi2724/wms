namespace WMS.App.Updater
{
    partial class UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.lblInfo = new DevComponents.DotNetBar.LabelX();
            this.lblTitle = new DevComponents.DotNetBar.LabelX();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.linkInfo = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picDownload = new System.Windows.Forms.PictureBox();
            this.picZip = new System.Windows.Forms.PictureBox();
            this.picCleanup = new System.Windows.Forms.PictureBox();
            this.lblStatus = new DevComponents.DotNetBar.LabelX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCleanup)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lblInfo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblInfo.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInfo.Location = new System.Drawing.Point(46, 72);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(642, 28);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "新版本 {1}，更新日期 {2}";
            // 
            // lblTitle
            // 
            // 
            // 
            // 
            this.lblTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(40, 27);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(600, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "正在更新 {0}";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(46, 113);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(651, 43);
            this.progressBar1.TabIndex = 4;
            // 
            // linkInfo
            // 
            this.linkInfo.AutoSize = true;
            this.linkInfo.Location = new System.Drawing.Point(620, 181);
            this.linkInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkInfo.Name = "linkInfo";
            this.linkInfo.Size = new System.Drawing.Size(69, 20);
            this.linkInfo.TabIndex = 5;
            this.linkInfo.TabStop = true;
            this.linkInfo.Text = "更多信息";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(649, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // picDownload
            // 
            this.picDownload.Enabled = false;
            this.picDownload.Image = ((System.Drawing.Image)(resources.GetObject("picDownload.Image")));
            this.picDownload.Location = new System.Drawing.Point(46, 164);
            this.picDownload.Margin = new System.Windows.Forms.Padding(4);
            this.picDownload.Name = "picDownload";
            this.picDownload.Size = new System.Drawing.Size(36, 37);
            this.picDownload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDownload.TabIndex = 8;
            this.picDownload.TabStop = false;
            // 
            // picZip
            // 
            this.picZip.Enabled = false;
            this.picZip.Image = ((System.Drawing.Image)(resources.GetObject("picZip.Image")));
            this.picZip.Location = new System.Drawing.Point(46, 164);
            this.picZip.Margin = new System.Windows.Forms.Padding(4);
            this.picZip.Name = "picZip";
            this.picZip.Size = new System.Drawing.Size(36, 37);
            this.picZip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picZip.TabIndex = 9;
            this.picZip.TabStop = false;
            this.picZip.Visible = false;
            // 
            // picCleanup
            // 
            this.picCleanup.Enabled = false;
            this.picCleanup.Image = ((System.Drawing.Image)(resources.GetObject("picCleanup.Image")));
            this.picCleanup.Location = new System.Drawing.Point(46, 164);
            this.picCleanup.Margin = new System.Windows.Forms.Padding(4);
            this.picCleanup.Name = "picCleanup";
            this.picCleanup.Size = new System.Drawing.Size(36, 37);
            this.picCleanup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCleanup.TabIndex = 10;
            this.picCleanup.TabStop = false;
            this.picCleanup.Visible = false;
            // 
            // lblStatus
            // 
            // 
            // 
            // 
            this.lblStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStatus.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStatus.Location = new System.Drawing.Point(86, 167);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(519, 36);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "正在读取清单文件…";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 237);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.picCleanup);
            this.Controls.Add(this.picZip);
            this.Controls.Add(this.picDownload);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkInfo);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统更新 ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCleanup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblInfo;
        private DevComponents.DotNetBar.LabelX lblTitle;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.LinkLabel linkInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picDownload;
        private System.Windows.Forms.PictureBox picZip;
        private System.Windows.Forms.PictureBox picCleanup;
        private DevComponents.DotNetBar.LabelX lblStatus;
        private DevComponents.DotNetBar.StyleManager styleManager1;
    }
}

