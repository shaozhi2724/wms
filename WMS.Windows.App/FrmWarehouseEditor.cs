using System;
using System.Linq;
using DevComponents.DotNetBar;
using WMS.App.Services;
using WMS.Model;

namespace WMS.Windows.App
{
    public partial class FrmWarehouseEditor : Office2007Form 
    {
        private IWarehouseService _service;
        private ICategoryService _categoryService;
        public FrmWarehouseEditor()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;
            _service = new WarehouseService();
            _categoryService = new CategoryService();
        }
        public FrmWarehouseEditor(Warehouse warehouse)
            : this()
        {
            btnSave.Tag = warehouse;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var warehouse = btnSave.Tag as Warehouse;
            if (null == warehouse)
            {
                warehouse = new Warehouse
                {
                    WarehouseCode = txtWarehouseCode.Text.Trim(),
                    WarehouseName = txtWarehouseName.Text.Trim(),
                    WarehouseType = cbxEnvironment.SelectedValue.ToString(),
                    WarehousePurpose = txtPurpose.Text.Trim(),
                    WarehousePhone = txtPhone.Text.Trim(),
                    WarehouseLeader = txtCharge.Text.Trim(),
                    WarehouseRemark = txtRemark.Text.Trim()
                };
            }
            else
            {
                warehouse.WarehouseCode = txtWarehouseCode.Text.Trim();
                warehouse.WarehouseName = txtWarehouseName.Text.Trim();
                warehouse.WarehouseType = cbxEnvironment.SelectedValue.ToString();
                warehouse.WarehousePurpose = txtPurpose.Text.Trim();
                warehouse.WarehousePhone = txtPhone.Text.Trim();
                warehouse.WarehouseLeader = txtCharge.Text.Trim();
                warehouse.WarehouseRemark = txtRemark.Text.Trim();
            }
            _service.SaveWarehouse(warehouse);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadWarehouseDetail();
        }

        private void LoadWarehouseDetail()
        {
            var warehouse = btnSave.Tag as Warehouse;
            if (null == warehouse)
            {
                txtWarehouseCode.Text = string.Empty;
                txtWarehouseName.Text = string.Empty;
                cbxEnvironment.SelectedIndex = -1;
                txtPurpose.Text = string.Empty;
                txtPhone.Text = string.Empty;
                txtCharge.Text = string.Empty;
                txtRemark.Text = string.Empty;
            }
            else
            {
                txtWarehouseCode.Text = warehouse.WarehouseCode;
                txtWarehouseName.Text = warehouse.WarehouseName;
                cbxEnvironment.SelectedValue = warehouse.WarehouseType;
                txtPurpose.Text = warehouse.WarehousePurpose;
                txtPhone.Text = warehouse.WarehousePhone;
                txtCharge.Text = warehouse.WarehouseLeader;
                txtRemark.Text = warehouse.WarehouseRemark;
            }
        }

        private void FrmWarehouseEditor_Load(object sender, EventArgs e)
        {
            BindWarehouseTypes();
            LoadWarehouseDetail();
        }

        private void BindWarehouseTypes()
        {
            var categories = _categoryService.GetAllCategoriesByCode("StockConditionType").Select(p => new { ItemId = p.ItemID, ItemName = p.ItemName }).ToList();
            cbxEnvironment.DataSource = categories;
            cbxEnvironment.DisplayMember = "ItemName";
            cbxEnvironment.ValueMember = "ItemName";
        }
    }
}