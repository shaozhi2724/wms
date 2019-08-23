using DevComponents.DotNetBar;
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
    public partial class FrmInsertStoreDetail : Office2007Form
    {

        private ICargoSpaceStoreDetailService _service;
        public FrmInsertStoreDetail()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidatePage())
            {
                int structureID = _service.GetStructureID(txtStructureCode.Text);
                if (structureID == 0)
                {
                    MessageBox.Show("货位无效，请重新输入！");
                    return;
                }
                if (structureID == 1)
                {
                    MessageBox.Show("货位已被占用，请重新输入！");
                    return;
                }
                int productid = (int)btnSave.Tag;
                string batchNo = txtNewBatchNo.Text.Trim();
                int amount = txtNewStoreAmount.Value;
                DateTime productionDate = datProductionDate.Value;
                DateTime validDate = datValidDate.Value;
                string manufacturer = txtProducerName.Text;
                string dosageForm = txtPhysicType.Text;
                string packageSpec = txtPackageSpec.Text;
                if (_service.SaveStoreDetail(structureID, productid, batchNo, productionDate,
                    validDate, amount, manufacturer, dosageForm, packageSpec))
                {

                    MessageBoxEx.Show(this, "添加成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBoxEx.Show(this, "添加失败！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                }
            }
        }

        private bool ValidatePage()
        {
            if (txtProductCode.Text.Trim() == "")
            {
                MessageBoxEx.Show(this, "请选择产品。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return false;
            }
            if (txtNewBatchNo.Text.Trim() == "")
            {
                MessageBoxEx.Show(this, "请输入批号。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return false;
            }
            if (datProductionDate.Text.Trim() == "")
            {
                MessageBoxEx.Show(this, "请输入生产日期。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return false;
            }
            if (datValidDate.Text.Trim() == "")
            {
                MessageBoxEx.Show(this, "请输入有效期至。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return false;
            }
            if (txtNewStoreAmount.Text.Trim() == "")
            {
                MessageBoxEx.Show(this, "请输入库存数量。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return false;
            }
            if (txtStructureCode.Text.Trim() == "")
            {
                MessageBoxEx.Show(this, "请输入货位位置。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }

        private void txtProductCode_Click(object sender, EventArgs e)
        {
            using (FrmSearchStoreDetail frm = new FrmSearchStoreDetail())
            {
                if (DialogResult.OK == frm.ShowDialog())
                {
                    InventoryViewModel model = frm.model;
                    _service = new CargoSpaceStoreDetailService();

                    txtProductCode.Text = model.ProductCode;
                    txtProductName.Text = model.ProductName;
                    txtPackageSpec.Text = model.PackageSpec;
                    txtPhysicType.Text = model.PhysicType;
                    txtProducerName.Text = model.ProducerName;
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
                        txtNewStoreAmount.Value = model.ProductAmount.Value;
                    }
                    btnSave.Tag = model.ProductID;
                }
                txtNewStoreAmount.Focus();
            }
            txtNewStoreAmount.Focus();
        }

        private void txtNewStoreAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtStructureCode.Focus();
            }
        }

        private void txtStructureCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSave_Click(null, null);
            }
        }

        private void FrmInsertStoreDetail_Load(object sender, EventArgs e)
        {
            txtProductCode.Focus();
        }

        private void txtProductCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtProductCode_Click(null, null);
            }
        }
    }
}
