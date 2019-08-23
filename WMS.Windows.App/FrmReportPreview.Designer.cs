namespace WMS.Windows.App
{
    partial class FrmReportPreview
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportPreview));
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            this.stiViewerControl = new Stimulsoft.Report.Viewer.StiViewerControl();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnPrint = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
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
            this.stiViewerControl.Location = new System.Drawing.Point(0, 61);
            this.stiViewerControl.Name = "stiViewerControl";
            this.stiViewerControl.PageViewMode = Stimulsoft.Report.Viewer.StiPageViewMode.SinglePage;
            this.stiViewerControl.Report = this.stiReport1;
            this.stiViewerControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stiViewerControl.ShowCloseButton = false;
            this.stiViewerControl.ShowEditor = false;
            this.stiViewerControl.ShowPageNew = false;
            this.stiViewerControl.ShowToolbar = false;
            this.stiViewerControl.ShowZoom = true;
            this.stiViewerControl.Size = new System.Drawing.Size(971, 561);
            this.stiViewerControl.TabIndex = 0;
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.bar1.Images = this.imageList;
            this.bar1.ImageSize = DevComponents.DotNetBar.eBarImageSize.Large;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnPrint});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(971, 61);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.bar1.TabIndex = 21;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "refresh.png");
            this.imageList.Images.SetKeyName(1, "cancel.png");
            this.imageList.Images.SetKeyName(2, "save.png");
            this.imageList.Images.SetKeyName(3, "print.png");
            // 
            // btnPrint
            // 
            this.btnPrint.ImageIndex = 3;
            this.btnPrint.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Text = "打印";
            this.btnPrint.Tooltip = "打印货物码";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FrmReportPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 622);
            this.Controls.Add(this.stiViewerControl);
            this.Controls.Add(this.bar1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmReportPreview";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "打印预览";
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Stimulsoft.Report.StiReport stiReport1;
        private Stimulsoft.Report.Viewer.StiViewerControl stiViewerControl;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnPrint;
        private System.Windows.Forms.ImageList imageList;

    }
}