namespace WMS.Windows.App
{
    partial class FrmDelReview
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
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtResult = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSubmit = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(21, 43);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(83, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "提交原因：";
            // 
            // txtResult
            // 
            // 
            // 
            // 
            this.txtResult.Border.Class = "TextBoxBorder";
            this.txtResult.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtResult.ButtonCustom.Tooltip = "";
            this.txtResult.ButtonCustom2.Tooltip = "";
            this.txtResult.Location = new System.Drawing.Point(110, 43);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.PreventEnterBeep = true;
            this.txtResult.Size = new System.Drawing.Size(243, 113);
            this.txtResult.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSubmit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSubmit.Location = new System.Drawing.Point(155, 198);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FrmDelReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 266);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.labelX2);
            this.DoubleBuffered = true;
            this.Name = "FrmDelReview";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "提交返单信息";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtResult;
        private DevComponents.DotNetBar.ButtonX btnSubmit;
    }
}