using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using WMS.App.Services;

namespace WMS.Windows.App
{
    public partial class FrmStoreQuery : Office2007Form
    {

        private IInventoryService _service;
        private readonly Dictionary<string, string> _structureTypes = new Dictionary<string, string>
            {
                {"合格品","合格品"},
                {"不合格品","不合格品"},
                {"退货","退货"}
            };
        public FrmStoreQuery()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;
            _service = new InventoryService();
        }
        private void SearchStoreRecords()
        {
            string structureCode = txtStructurCode.Text.Trim();
            string productName = txtProductName.Text.Trim();
            string batchNumber = string.Empty;
            string areaType = cbxStructureType.SelectedValue.ToString();
            var inventories = _service.SearchInventory(structureCode, productName, batchNumber, areaType);
            grdDrugs.PrimaryGrid.DataSource = inventories;
        }
        private void BindStructureTypes()
        {
            cbxStructureType.DataSource = new BindingSource(_structureTypes, null);
            cbxStructureType.DisplayMember = "Value";
            cbxStructureType.ValueMember = "Key";
        }
        private void FrmStoreQuery_Load(object sender, EventArgs e)
        {
            BindStructureTypes();
            cbxStructureType.SelectedValue = "合格品";
            SearchStoreRecords();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchStoreRecords();
        }

        private void btnGenerateBusinessStore_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes ==
                MessageBoxEx.Show("确定更新业务库存？", "系统确认框", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1))
            {
                var generateSuccess = _service.GenerateBusinessInventory(Program.CurrentUser.Realname, "WMS在库药品查询手动更新");
                if (generateSuccess)
                {
                    MessageBoxEx.Show("业务库存更新成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBoxEx.Show("业务库存更新失败！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
