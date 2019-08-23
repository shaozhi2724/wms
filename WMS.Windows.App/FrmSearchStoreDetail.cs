using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMS.App.Services;

namespace WMS.Windows.App
{
    public partial class FrmSearchStoreDetail : Office2007Form
    {

        private IInventoryService _service;

        public InventoryViewModel model;
        public FrmSearchStoreDetail()
        {
            InitializeComponent();
            _service = new InventoryService();
        }

        private void FrmSearchStoreDetail_Load(object sender, EventArgs e)
        {
            SearchStoreDetails();
            txtProductCode.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchStoreDetails();
        }

        private void SearchStoreDetails()
        {
            string productcode = txtProductCode.Text.Trim();
            var storeDetails = _service.SearchStoreDetail(productcode);
            grdDrugs.PrimaryGrid.DataSource = storeDetails;
        }

        private void grdDrugs_RowDoubleClick(object sender, DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs e)
        {
            model = (e.GridRow as GridRow).DataItem as InventoryViewModel;
            this.DialogResult = DialogResult.OK;
        }

        private void txtProductCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSearch_Click(null, null);
                grdDrugs.Focus();
            }
        }
    }
}
