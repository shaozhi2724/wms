namespace WMS.Windows.App
{
    partial class FrmCargoBarcodePrint
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
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            this.stiViewerControl = new Stimulsoft.Report.Viewer.StiViewerControl();
            this.SuspendLayout();
            // 
            // stiReport1
            // 
            this.stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport1.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport1.ReportAlias = "Report";
            this.stiReport1.ReportGuid = "a08a451d31584c67b28c2f512b3a9a4f";
            this.stiReport1.ReportName = "Report";
            this.stiReport1.ReportSource = null;
            this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport1.UseProgressInThread = false;
            // 
            // stiViewerControl
            // 
            this.stiViewerControl.AllowDrop = true;
            this.stiViewerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stiViewerControl.Location = new System.Drawing.Point(0, 0);
            this.stiViewerControl.Name = "stiViewerControl";
            this.stiViewerControl.PageViewMode = Stimulsoft.Report.Viewer.StiPageViewMode.SinglePage;
            this.stiViewerControl.Report = this.stiReport1;
            this.stiViewerControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stiViewerControl.ShowCloseButton = false;
            this.stiViewerControl.ShowEditor = false;
            this.stiViewerControl.ShowPageNew = false;
            this.stiViewerControl.ShowZoom = true;
            this.stiViewerControl.Size = new System.Drawing.Size(971, 622);
            this.stiViewerControl.TabIndex = 0;
            // 
            // FrmReportPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 622);
            this.Controls.Add(this.stiViewerControl);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmReportPreview";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "打印预览";
            this.ResumeLayout(false);

        }

        #endregion

        private Stimulsoft.Report.StiReport stiReport1;
        private Stimulsoft.Report.Viewer.StiViewerControl stiViewerControl;

    }
}