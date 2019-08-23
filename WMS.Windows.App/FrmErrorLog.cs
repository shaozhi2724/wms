using System;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using WMS.App.Services;
using WMS.Model;

namespace WMS.Windows.App
{
    public partial class FrmErrorLog : Office2007Form
    {
        private readonly StoreBill _storeBill;
        private IStoreBillService _service;
        public FrmErrorLog()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;
            _service = new StoreBillService();
        }
        public FrmErrorLog(StoreBill storeBill) : this()
        {
            _storeBill = storeBill;
            lblStoreCode.Text = storeBill.StoreCode;
        }

        private void FrmErrorLog_Load(object sender, EventArgs e)
        {
            SearchStoreOutErrorLogs();
        }
        private void SearchStoreOutErrorLogs()
        {
            var storeOutErrorLogs = _service.SearchStoreOutErrorLogs(_storeBill.StoreID);

            grdStoreOutErrorLog.PrimaryGrid.DataSource = storeOutErrorLogs;
            grdStoreOutErrorLog.Update();
        }
    }
}
