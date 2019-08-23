using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using DevComponents.DotNetBar;
using Stimulsoft.Report.Dictionary;
using WMS.Windows.App.Properties;

namespace WMS.Windows.App
{
    public partial class FrmCargoBarcodePrint : Office2007Form
    {
        public FrmCargoBarcodePrint()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;
        }

        public FrmCargoBarcodePrint(int storeId, int detailId)
            : this()
        {
            string reportName = "CargoBarcode.mrt";
            string reportFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,reportName);
            stiReport1["StoreID"] = storeId;
            stiReport1["DetailID"] = detailId;
            stiReport1.Load(reportFile);
            stiReport1.Dictionary.Databases["DQS"] = new StiSqlDatabase("DQS",
                ConfigurationManager.ConnectionStrings["DbConnectStrings"].ConnectionString);
            stiReport1.Compile();
            stiReport1.Render(false);
            this.stiViewerControl.Refresh();
        }
    }
}
