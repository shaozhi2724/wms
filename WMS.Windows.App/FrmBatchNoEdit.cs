using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using WMS.App.Services;

namespace WMS.Windows.App
{
    public partial class FrmBatchNoEdit : Office2007Form
    {

        private IInventoryService _service;
        public FrmBatchNoEdit()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;
            _service = new InventoryService();
        }
        private void SearchStoreRecords()
        {
            string structureCode = string.Empty;
            string batchNumber = txtBatchNo.Text.Trim();
            string productName = txtProductName.Text.Trim();
            string areaType = "合格品";
            var inventories = _service.SearchInventory(structureCode, productName, batchNumber, areaType);
            grdDrugs.PrimaryGrid.DataSource = inventories;
        }

        private void FrmBatchNoEdit_Load(object sender, EventArgs e)
        {
            SearchStoreRecords();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchStoreRecords();
        }

        private void grdDrugs_RowDoubleClick(object sender, GridRowDoubleClickEventArgs e)
        {
            var model = (e.GridRow as GridRow).DataItem as InventoryViewModel;
            FrmBatchNoChange doc = new FrmBatchNoChange(model);
            if (DialogResult.OK == doc.ShowDialog(this))
            {
                SearchStoreRecords();
            }
        }

    }
}
