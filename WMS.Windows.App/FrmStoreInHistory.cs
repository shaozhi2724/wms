using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using WMS.App.Services;
using WMS.Model;
using WMS.Windows.App.Properties;

namespace WMS.Windows.App
{
    public partial class FrmStoreInHistory : Office2007Form
    {
        private IStoreBillService _service;
        public FrmStoreInHistory()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;

            _service = new StoreBillService();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchStoreInRecodes();
        }

        private void FrmStoreInHistory_Load(object sender, EventArgs e)
        {
            datStoreInStartDate.Value = DateTime.Today;
            datStoreInEndDate.Value = DateTime.Today;

            SearchStoreInRecodes();
        }
        private void SearchStoreInRecodes()
        {
            string storeOutCode = txtStoreOutCode.Text.Trim();
            string dealerName = txtDealerName.Text.Trim();
            DateTime startDate = datStoreInStartDate.Value;
            DateTime endDate = datStoreInEndDate.Value;
            int storeOutType = cbxStoreInType.SelectedIndex + 1;

            var storeBills = _service.SearchStoreHistories(storeOutCode, storeOutType, dealerName, startDate, endDate, true);

            grdStoreIn.PrimaryGrid.DataSource = storeBills;
            grdStoreIn.Update();
            if (grdStoreIn.PrimaryGrid.Rows.Count > 0)
            {
                grdStoreIn.PrimaryGrid.SetActiveRow((GridContainer)grdStoreIn.PrimaryGrid.Rows[0]);
            }
            BindStoreBillDetails(null);
        }

        private void BindStoreBillDetails(GridRow activeRow)
        {
            if (activeRow == null)
            {
                activeRow = (grdStoreIn.ActiveRow as GridRow);
            }
            if (activeRow != null)
            {
                var storeBill = activeRow.DataItem as StoreBill;

                var storeID = storeBill.StoreID;
                lblStoreCode.Text = storeBill.StoreCode;
                if (Settings.Default.PrintCargoBarcode && 
                    storeBill.IsBillIn.HasValue && storeBill.IsBillIn.Value
                    && storeBill.StoreTypeID != 3)
                {
                    var details = _service.GetStoreInDetails(storeID);
                    grdStoreInDetail.PrimaryGrid.DataSource = details;
                }
                else
                {
                    var details = _service.GetStoreBillInDetails(storeID);
                    grdStoreInDetail.PrimaryGrid.DataSource = details;
                }
                if (grdStoreInDetail.PrimaryGrid.Rows.Count > 0)
                {
                    grdStoreInDetail.PrimaryGrid.SetActiveRow((GridContainer)grdStoreInDetail.PrimaryGrid.Rows[0]);
                }
                grdStoreInDetail.Update();
            }
            else
            {
                lblStoreCode.Text = string.Empty;
                grdStoreInDetail.PrimaryGrid.DataSource = null;

                btnPrintCargoCode.Enabled = false;
            }
        }

        private void grdStoreIn_RowActivated(object sender, GridRowActivatedEventArgs e)
        {
            btnPrintCargoCode.Enabled = false;
            var row = e.NewActiveRow as GridRow;
            BindStoreBillDetails(row);
        }

        private void btnPrintCargoCode_Click(object sender, EventArgs e)
        {

            var row = grdStoreInDetail.ActiveRow as GridRow;
            if (null != row)
            {
                var model = row.DataItem as StoreInBillDetailViewModel;
                if (null != model && !string.IsNullOrWhiteSpace(model.StructureCode))
                {
                    MessageBox.Show(string.Format("{0}-{1}", model.StoreID, model.DetailID));
                    FrmCargoBarcodePrint doc = new FrmCargoBarcodePrint(model.StoreID, model.DetailID);
                    doc.ShowDialog(this);
                }
            }
        }

        private void grdStoreInDetail_RowActivated(object sender, GridRowActivatedEventArgs e)
        {
            var row = e.NewActiveRow as GridRow;
            if (null != row)
            {
                var model = row.DataItem as StoreInBillDetailViewModel;
                if (null != model && !string.IsNullOrWhiteSpace(model.StructureCode))
                {
                    btnPrintCargoCode.Enabled = true;
                }
                else
                {
                    btnPrintCargoCode.Enabled = false;
                }
            }
            else
            {
                btnPrintCargoCode.Enabled = false;
            }
        }
    }
}
