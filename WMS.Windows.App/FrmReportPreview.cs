using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using DevComponents.DotNetBar;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;
using WMS.App.Services;
using WMS.Windows.App.Properties;

namespace WMS.Windows.App
{
    public partial class FrmReportPreview : Office2007Form
    {
        private IReviewService _reviewService;
        private int _reviewId;
        private string _reportName;
        public FrmReportPreview()
        {
            InitializeComponent();
            MessageBoxEx.EnableGlass = false;
            _reviewService = new ReviewService();
            //StiOptions.Engine.GlobalEvents.ReportPrintingPage += GlobalEvents_ReportPrintingPage;
        }

        private void GlobalEvents_ReportPrintingPage(object sender, EventArgs e)
        {
            if(_reportName == "Report")
            {
                _reviewService.UpdatePrintTimes(_reviewId);
            }
        }
        public FrmReportPreview(int reviewId, string reportName) : this()
        {
            _reviewId = reviewId;
            _reportName = reportName;
            //if (reportName == "Report")
            //{
            //    _reviewService.UpdatePrintTimes(_reviewId);
            //}
            string reportFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,reportName+".mrt");
            if (!File.Exists(reportFile))
            {
                MessageBoxEx.Show(string.Format("打印模板-{0}不存在", reportFile), "文件不存在");
                return;
            }
            stiReport1["ReviewID"] = reviewId;
            stiReport1.Load(reportFile);
            string reportScriptFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ReportFunction.cs");
            if (!File.Exists(reportScriptFile))
            {
                File.AppendAllText(reportScriptFile, Resources.ReportFunction);
            }
            stiReport1.Dictionary.Databases["DQS"] = new StiSqlDatabase("DQS",
                ConfigurationManager.ConnectionStrings["DbConnectStrings"].ConnectionString);
            stiReport1.Script = string.Format("{0}\n{1}", stiReport1.Script,File.ReadAllText(reportScriptFile));
            stiReport1.Compile();
            stiReport1.Render(false);
            this.stiViewerControl.Refresh();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(_reportName == "Report")
            {
                _reviewService.UpdatePrintTimes(_reviewId);
            }
            stiReport1.Print(true);
        }
    }
}
