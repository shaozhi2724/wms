using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using WMS.App.Services;
using WMS.Model;

namespace WMS.Windows.App
{
    public partial class FrmDrugs : Office2007Form
    {
        private IProductService _service;
        private ICategoryService _categoryService;
        
        public FrmDrugs()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;
            _service = new ProductService();
            _categoryService = new CategoryService();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmDrugEditor editor = new FrmDrugEditor();
            if (DialogResult.Yes == editor.ShowDialog(this))
            {
                BindDrugs();
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            BindDrugs();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var row = (grdDrugs.ActiveGrid.ActiveRow as GridRow);

            if (row != null)
            {
                FrmDrugEditor editor = new FrmDrugEditor(row.DataItem as Product);
                if (DialogResult.Yes == editor.ShowDialog(this))
                {
                    BindDrugs();
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBoxEx.EnableGlass = false;
            if (DialogResult.Yes ==
                MessageBoxEx.Show("确定删除？", "系统确认信息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                var row = (grdDrugs.ActiveGrid.ActiveRow as GridRow);

                if (row != null)
                {
                    var product = row.DataItem as Product;
                    if (product != null)
                    {
                        var productID = product.ProductID;
                        _service.DeleteProduct(productID);
                    }
                    BindDrugs();

                }
            }
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

        private void FrmDrugs_Load(object sender, EventArgs e)
        {
            BindStockConditions();

            BindDrugs();
        }

        private void BindDrugs()
        {
            var productName = txtProductName.Text.Trim();
            var productCode = txtProductCode.Text.Trim();
            var productBarcode = txtProductBarCode.Text.Trim();
            var producerName = txtProducerName.Text.Trim();
            var packagingProportion = txtPackagingProportion.Value;
            var entireCargoSpaceMaximum = txtEntireCargoSpaceMaximum.Value;
            var stockMinAmount = txtStockMinAmount.Value;
            var scatteredCargoSpaceMaximum = txtScatteredCargoSpaceMaximum.Value;
            var scatteredCargoSpaceMinimum = txtScatteredCargoSpaceMinimum.Value;
            var stockCondition = cbxStockCondition.SelectedValue.ToString();
            bool isSupervise = swbIsSupervise.Value;
            ProductSearchParameter productSearchParameter = new ProductSearchParameter
            {
                ProductName = productName,
                ProductCode = productCode,
                ProductBarcode = productBarcode,
                ProducerName = producerName,
                StockCondition = stockCondition,
                PackagingProportion = packagingProportion,
                EntireCargoSpaceMaximum = entireCargoSpaceMaximum,
                StockMinAmount = stockMinAmount,
                ScatteredCargoSpaceMaximum = scatteredCargoSpaceMaximum,
                ScatteredCargoSpaceMinimum = scatteredCargoSpaceMinimum,
                IsSupervise = isSupervise
            };

            var allProducts = _service.SearchProducts(productSearchParameter);
            grdDrugs.PrimaryGrid.DataSource = allProducts;
        }

        private void grdDrugs_RowDoubleClick(object sender, GridRowDoubleClickEventArgs e)
        {

            var row = (e.GridRow as GridRow);

            if (row != null)
            {
                FrmDrugEditor editor = new FrmDrugEditor(row.DataItem as Product);
                if (DialogResult.Yes == editor.ShowDialog(this))
                {
                    BindDrugs();
                }

            }
        }
    }
}