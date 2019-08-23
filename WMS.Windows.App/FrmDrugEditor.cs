using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using WMS.App.Services;
using WMS.Model;

namespace WMS.Windows.App
{
    public partial class FrmDrugEditor : Office2007Form
    {

        private IProductService _service;
        private ICategoryService _categoryService;
        public FrmDrugEditor()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;

            _service = new ProductService();
            _categoryService = new CategoryService();
        }
        public FrmDrugEditor(Product product) : this()
        {
            btnSave.Tag = product;
        }

        private void BindStockConditions()
        {
            Dictionary<string, string> _stockConditions = new Dictionary<string, string>
            {
                {"","请选择"}
            };
            var stockConditions = _categoryService.GetAllCategoriesByCode("StockConditionType").Select(p => p.ItemName);
            foreach (var stockCondition in stockConditions)
            {
                _stockConditions.Add(stockCondition, stockCondition);
            }
            cbxStockCondition.DataSource = new BindingSource(_stockConditions, null);
            cbxStockCondition.DisplayMember = "Value";
            cbxStockCondition.ValueMember = "Key";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var product = btnSave.Tag as Product;
            if (null == product)
            {
                product = new Product
                {
                    ProductName = txtProductName.Text.Trim(),
                    ProductCode = txtProductCode.Text.Trim(),
                    ProductBarCode = txtProductBarCode.Text.Trim(),
                    ProducerName = txtProducerName.Text.Trim(),
                    StockCondition = cbxStockCondition.SelectedValue.ToString(),
                    PackagingProportion = txtPackagingProportion.Text.Trim(),
                    EntireCargoSpaceMaximum = txtEntireCargoSpaceMaximum.Value,
                    ScatteredCargoSpaceMaximum = txtScatteredCargoSpaceMaximum.Value,
                    ScatteredCargoSpaceMinimum = txtScatteredCargoSpaceMinimum.Value,
                    StockMinAmount = txtStockMinAmount.Value,
                    IsSupervise = swbIsSupervise.Value,
                    CreateDate = DateTime.Now
                };
            }
            else
            {
                product.ProductName = txtProductName.Text.Trim();
                product.ProductCode = txtProductCode.Text.Trim();
                product.ProductBarCode = txtProductBarCode.Text.Trim();
                product.ProducerName = txtProducerName.Text.Trim();
                product.StockCondition = cbxStockCondition.SelectedValue.ToString();
                product.PackagingProportion = txtPackagingProportion.Text.Trim();
                product.EntireCargoSpaceMaximum = txtEntireCargoSpaceMaximum.Value;
                product.ScatteredCargoSpaceMaximum = txtScatteredCargoSpaceMaximum.Value;
                product.ScatteredCargoSpaceMinimum = txtScatteredCargoSpaceMinimum.Value;
                product.StockMinAmount = txtStockMinAmount.Value;
                product.IsSupervise = swbIsSupervise.Value;
                product.LastModifyDate = DateTime.Now;
            }
            _service.SaveProduct(product);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadProductDetail();
        }

        private void LoadProductDetail()
        {
            var product = btnSave.Tag as Product;
            if (null == product)
            {
                txtProductName.Text = string.Empty;
                txtProductCode.Text = string.Empty;
                txtProductBarCode.Text = string.Empty;
                txtProducerName.Text = string.Empty;
                cbxStockCondition.SelectedIndex = -1;
                txtPackagingProportion.Text = string.Empty;
                txtEntireCargoSpaceMaximum.Value = 0;
                txtScatteredCargoSpaceMaximum.Value = 0;
                txtScatteredCargoSpaceMinimum.Value = 0;
                txtStockMinAmount.Value = 0;
                swbIsSupervise.Value = false;
            }
            else
            {
                txtProductName.Text = product.ProductName;
                txtProductCode.Text = product.ProductCode;
                txtProductBarCode.Text = product.ProductBarCode;
                txtProducerName.Text = product.ProducerName;
                if (!string.IsNullOrWhiteSpace(product.StockCondition))
                {
                    cbxStockCondition.SelectedValue = product.StockCondition;
                }
                if (!string.IsNullOrWhiteSpace(product.PackagingProportion))
                {
                    var packagingProportion = 1;
                    int.TryParse(product.PackagingProportion, out packagingProportion);
                    txtPackagingProportion.Value = packagingProportion;
                }
                if (product.EntireCargoSpaceMaximum != null)
                {
                    txtEntireCargoSpaceMaximum.Value = product.EntireCargoSpaceMaximum.Value;
                }
                if (product.ScatteredCargoSpaceMaximum != null)
                {
                    txtScatteredCargoSpaceMaximum.Value = product.ScatteredCargoSpaceMaximum.Value;
                }
                if (product.ScatteredCargoSpaceMinimum != null)
                {
                    txtScatteredCargoSpaceMinimum.Value = product.ScatteredCargoSpaceMinimum.Value;
                }
                if (product.StockMinAmount != null)
                {
                    txtStockMinAmount.Value = product.StockMinAmount.Value;
                }
                if(product.IsSupervise.HasValue && product.IsSupervise.Value)
                {
                    swbIsSupervise.Value = product.IsSupervise.Value;
                }
            }
        }

        private void FrmDrugEditor_Load(object sender, EventArgs e)
        {
            BindStockConditions();
            LoadProductDetail();
        }
    }
}