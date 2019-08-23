using System;
using DevComponents.DotNetBar;
using WMS.App.Services;

namespace WMS.Windows.App
{
    public partial class FrmInventoryState : Office2007Form
    {
        private IStoreBillService _service;
        public FrmInventoryState()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;

            _service = new StoreBillService();
        }

        private void FrmInventoryState_Load(object sender, EventArgs e)
        {
            BindInventoryRecodes();
        }
        private void BindInventoryRecodes()
        {
            var inventoryDetails = _service.GetAllInventoryDetails();

            grdInventoryDetail.PrimaryGrid.DataSource = inventoryDetails;
            grdInventoryDetail.Update();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            FrmInventoryTaskGen doc = new FrmInventoryTaskGen();
            var dialogResult = doc.ShowDialog(this);
            if (System.Windows.Forms.DialogResult.OK == dialogResult)
            {
                (this.MdiParent as FrmMain).ShowInventoryStatisticForm();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindInventoryRecodes();
        }
    }
}
