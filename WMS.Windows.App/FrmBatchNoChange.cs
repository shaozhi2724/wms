using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using WMS.App.Services;

namespace WMS.Windows.App
{
    public partial class FrmBatchNoChange : Office2007Form
    {
        private ICargoSpaceStoreDetailService _service;
        public FrmBatchNoChange()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;
        }

        public FrmBatchNoChange(InventoryViewModel model) : this()
        {
            _service = new CargoSpaceStoreDetailService();

            txtOldBatchNo.Text = model.ProductBatchNumber;
            txtNewBatchNo.Text = model.ProductBatchNumber;
            if (model.ProductionDate.HasValue)
            {
                datProductionDate.Value = model.ProductionDate.Value;
            }
            if (model.ProductValidDate.HasValue)
            {
                datValidDate.Value = model.ProductValidDate.Value;
            }
            if (model.ProductAmount.HasValue)
            {
                txtOldStoreAmount.Value = model.ProductAmount.Value;
                txtNewStoreAmount.Value = model.ProductAmount.Value;
            }
            btnSave.Tag = model.CargoSpaceStoreDetailID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBoxEx.EnableGlass = false;
            if (ValidatePage(true))
            {
                int detailId = (int) btnSave.Tag;
                string oldBatchNo = txtOldBatchNo.Text.Trim();
                string newBatchNo = txtNewBatchNo.Text.Trim();
                int oldAmount = txtOldStoreAmount.Value;
                int newAmount = txtNewStoreAmount.Value;
                DateTime productionDate = datProductionDate.Value;
                DateTime validDate = datValidDate.Value;
                if (_service.UpdateBatchNoAndAmount(detailId, oldBatchNo, newBatchNo, oldAmount, newAmount, productionDate, validDate, Program.CurrentUser.Realname))
                {
                    
                    MessageBoxEx.Show(this, "批号、库存修改成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBoxEx.Show(this, "批号、库存修改失败！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                }
            }
        }

        private bool ValidatePage(bool triggerErrors)
        {
            // Start off assuming the page IS valid
            bool pageIsValid = true;

            if (string.IsNullOrEmpty(txtNewBatchNo.Text.Trim()))
            {
                if (triggerErrors)
                {
                    errorProvider.SetError(txtNewBatchNo,
                        "请指定新的批号！");
                }

                pageIsValid = false;
            }
            else
            {
                errorProvider.SetError(txtNewBatchNo, string.Empty);
            }


            return pageIsValid;
        }
    }
}
