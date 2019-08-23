using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using WMS.App.Services;
using WMS.Model;
using WMS.Windows.App.Properties;

namespace WMS.Windows.App
{
    public partial class FrmInventoryStatistic : Office2007Form
    {
        private IStoreBillService _service;
        public FrmInventoryStatistic()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;

            _service = new StoreBillService();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchInventoryStatisticRecodes();
        }

        private void FrmInventoryStatistic_Load(object sender, EventArgs e)
        {
            datStartDate.Value = DateTime.Today;
            datEndDate.Value = DateTime.Today;

            SearchInventoryStatisticRecodes();
        }
        private void SearchInventoryStatisticRecodes()
        {
            string inventoryStatisCode = txtStatisticCode.Text.Trim();
            DateTime startDate = datStartDate.Value;
            DateTime endDate = datEndDate.Value;

            var inventoryStatisticTasks = _service.SearchInventoryStatisticTasks(inventoryStatisCode, startDate, endDate);

            grdInventoryStatistic.PrimaryGrid.DataSource = inventoryStatisticTasks;
            if (grdInventoryStatistic.PrimaryGrid.Rows.Count > 0)
            {
                grdInventoryStatistic.PrimaryGrid.SetActiveRow((GridContainer)grdInventoryStatistic.PrimaryGrid.Rows[0]);
            }
            grdInventoryStatistic.Update();
            BindInventoryStatisticDetails(null);
        }

        private void BindInventoryStatisticDetails(GridRow activeRow)
        {
            if (activeRow == null)
            {
                activeRow = (grdInventoryStatistic.ActiveRow as GridRow);
            }
            if (activeRow != null)
            {
                var inventoryStatistic = activeRow.DataItem as InventoryStatistic;

                var inventoryStatisticID = inventoryStatistic.InventoryStatisticID;
                lblStoreCode.Text = inventoryStatistic.InventoryStatisticCode;

                var details = _service.GetInventoryStatisticDetails(inventoryStatisticID);
                grdInventoryStatisticDetail.PrimaryGrid.DataSource = details;
                grdInventoryStatisticDetail.Update();
            }
            else
            {
                lblStoreCode.Text = string.Empty;
                grdInventoryStatisticDetail.PrimaryGrid.DataSource = null;
            }
        }

        private void grdInventoryStatistic_RowActivated(object sender, GridRowActivatedEventArgs e)
        {
            var row = e.NewActiveRow as GridRow;
            BindInventoryStatisticDetails(row);
        }


        private void grdInventoryStatisticDetail_RowActivated(object sender, GridRowActivatedEventArgs e)
        {
            //var row = e.NewActiveRow as GridRow;
            //if (null != row)
            //{
            //    var model = row.DataItem as StoreInBillDetailViewModel;
            //    if (null != model && !string.IsNullOrWhiteSpace(model.StructureCode))
            //    {
            //        btnPrintCargoCode.Enabled = true;
            //    }
            //    else
            //    {
            //        btnPrintCargoCode.Enabled = false;
            //    }
            //}
            //else
            //{
            //    btnPrintCargoCode.Enabled = false;
            //}
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            FrmInventoryTaskGen doc = new FrmInventoryTaskGen();
            var dialogResult = doc.ShowDialog(this);
            if (System.Windows.Forms.DialogResult.OK == dialogResult)
            {
                SearchInventoryStatisticRecodes();
            }
        }
    }
}
