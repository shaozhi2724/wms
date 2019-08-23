using System;
using System.Data.SqlClient;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using WMS.SmartDevice.App.Models;
using WMS.SmartDevice.App.Utils;

namespace WMS.SmartDevice.App
{
    public partial class FrmCollection : Form
    {
        public FrmCollection()
        {
            InitializeComponent();
            BindStockConditions();
        }
        // Singleton design patern
        private static FrmCollection _Instance = null;
        public static FrmCollection Instance()
        {
            if (_Instance == null || _Instance.IsDisposed)
            {
                _Instance = new FrmCollection();
            }
            _Instance.BringToFront();
            return _Instance;
        }
        private void muBack_Click(object sender, EventArgs e)
        {
            FrmMain.Instance().Show();
            this.Close();
        }

        private void muSaveDetail_Click(object sender, EventArgs e)
        {
            //取值必须在模态窗口弹出前，否则取不到值
            int selectedProductId = 0;
            if (null != lvwProductDetails.FocusedItem)
            {
                selectedProductId = (int)lvwProductDetails.Tag;
            }

            var barcode = txtProductBarcode.Text.Trim();
            string productName = txtProductName.Text.Trim();
            string stockCondition = cbxStoreEnvironment.SelectedValue.ToString();
            string packagingProportion = txtPackagingProportion.Text.Trim();

            int storeAlaramAmount = -1;
            int entireAmount = -1;
            int scatteredAmount = -1;
            int scatteredAlaramAmount = -1;
            try
            {
                storeAlaramAmount = int.Parse(txtStoreAlaramAmount.Text.Trim());
            }
            catch (Exception)
            {
            }

            try
            {
                entireAmount = int.Parse(txtEntireAmount.Text.Trim());
            }
            catch (Exception)
            {
            }

            try
            {
                scatteredAmount = int.Parse(txtScatteredAmount.Text.Trim());
            }
            catch (Exception)
            {
            }

            try
            {
                scatteredAlaramAmount = int.Parse(txtScatteredAlaramAmount.Text.Trim());
            }
            catch (Exception)
            {
            }

            if (selectedProductId == 0)
            {
                MessageBox.Show("请选择要更新的药品！");
                return;
            }
            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("请输入药品名称！");
                return;
            }
            if (string.IsNullOrEmpty(packagingProportion))
            {
                MessageBox.Show("请输入药品包装比例！");
                return;
            }
            var dialogResult = MessageBox.Show("确定保存药品信息?", "系统确认框", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button1);
            if (dialogResult != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
                {
                    string commandText = "UPDATE BFI_Product SET ProductName=@ProductName,ProductBarCode=@ProductBarCode";
                    if (storeAlaramAmount >= 0)
                    {
                        commandText = string.Concat(commandText, ",StockMinAmount=", storeAlaramAmount);
                    }
                    if (entireAmount >= 0)
                    {
                        commandText = string.Concat(commandText, ",EntireCargoSpaceMaximum=", entireAmount);
                    }
                    if (scatteredAmount >= 0)
                    {
                        commandText = string.Concat(commandText, ",ScatteredCargoSpaceMaximum=", scatteredAmount);
                    }
                    if (scatteredAlaramAmount >= 0)
                    {
                        commandText = string.Concat(commandText, ",ScatteredCargoSpaceMinimum=", scatteredAlaramAmount);
                    }

                    commandText = string.Concat(commandText,
                        ",StockCondition=@StockCondition,PackagingProportion=@PackagingProportion WHERE ProductID=@ProductID");
                    conn.Open();
                    var rowsEffected =
                        conn.Execute(commandText,
                            new
                            {
                                ProductID = selectedProductId,
                                ProductName = productName,
                                ProductBarCode = barcode,
                                PackagingProportion = packagingProportion,
                                StockCondition = stockCondition
                            }, null);

                    conn.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("保存药品信息失败！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk,
                            MessageBoxDefaultButton.Button1);
            }

            Init();
        }

        public void SearchProducts()
        {
            txtEntireAmount.Text = "";
            txtPackagingProportion.Text = "";

            txtScatteredAlaramAmount.Text = "";
            txtScatteredAmount.Text = "";
            txtStoreAlaramAmount.Text = "";
            cbxStoreEnvironment.SelectedIndex = 0;
            lvwProductDetails.Items.Clear();
            lvwProductDetails.Tag = null;

            string productName = txtProductName.Text.Trim();
            string barcode = txtProductBarcode.Text.Trim();
            if (string.IsNullOrEmpty(productName) && string.IsNullOrEmpty(barcode))
            {
                return;
            }

            string query =
                "SELECT ProductID,ChinesePinyin,ProductCode,ProductName,ProductBarCode,ProductSpec,PackageSpec,PackagingProportion,StockCondition,ProductSpec,PhysicType,ProducerName,EntireCargoSpaceMaximum,ScatteredCargoSpaceMaximum FROM BFI_Product WHERE 1=1";

            if (!string.IsNullOrEmpty(productName))
            {
                query = string.Concat(query, " AND (ProductName LIKE '%", productName, "%'", " OR ProductSpell LIKE '%", productName, "%')");
            }
            else if (!string.IsNullOrEmpty(barcode))
            {
                query = string.Concat(query, " AND ProductBarCode='", barcode, "'");
            }

            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var products =
                    conn.Query<Product>(query)
                        .ToList();

                conn.Close();
                foreach (var item in products)
                {
                    var listViewItem = new ListViewItem(new string[]
                    {
                        item.ProductCode,
                        item.ProductName,
                        item.ProductSpec,
                        item.PackageSpec,
                        item.PhysicType,
                        item.ProducerName
                    });
                    listViewItem.Tag = item.ProductID;
                    lvwProductDetails.Items.Add(listViewItem);
                }
                if (products.Any())
                {
                    lvwProductDetails.Items[0].Focused = true;
                }
            }
        }

        private void txtProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;

                txtProductBarcode.Text = "";
                SearchProducts();
            }
        }

        //private void txtProductBarcode_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Return)
        //    {
        //        e.Handled = true;
        //        txtProductName.Text = "";
        //        SearchProducts();
        //    }
        //}

        private void BindStockConditions()
        {
            Dictionary<string, string> types = new Dictionary<string, string>
            {
                {"","请选择"}
            };
            var query =
                "SELECT ItemName FROM dbo.SYS_Category WHERE CategoryCode='StockConditionType' ORDER BY StatusSort";
            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var categories = conn.Query<string>(query);
                foreach (var category in categories)
                {
                    types.Add(category, category);
                }
            }
            cbxStoreEnvironment.DataSource = new BindingSource(types, null);
            cbxStoreEnvironment.DisplayMember = "Value";
            cbxStoreEnvironment.ValueMember = "Key";
        }

        private void lvwProductDetails_ItemActivate(object sender, EventArgs e)
        {
            if (lvwProductDetails.SelectedIndices.Count > 0)
            {
                ListViewItem item = lvwProductDetails.Items[lvwProductDetails.SelectedIndices[0]];
                var selectedProductId = (int)(item.Tag);

                lvwProductDetails.Tag = selectedProductId;
                string query =
                "SELECT ProductID,ProductCode,ProductName,ProductSpec,PackageSpec,ProductBarCode,PackagingProportion,StockCondition,EntireCargoSpaceMaximum,ScatteredCargoSpaceMaximum,ScatteredCargoSpaceMinimum,StockMinAmount FROM BFI_Product WHERE ProductID=@ProductID";

                using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
                {
                    conn.Open();
                    var product =
                        conn.Query<Product>(query, new {ProductID = selectedProductId}).FirstOrDefault();
                    if (null != product)
                    {
                        txtProductName.Text = product.ProductName;
                        txtProductBarcode.Text = product.ProductBarCode;
                        txtPackagingProportion.Text = product.PackagingProportion;
                        cbxStoreEnvironment.SelectedValue = product.StockCondition;
                        txtEntireAmount.Text = product.EntireCargoSpaceMaximum.HasValue
                            ? product.EntireCargoSpaceMaximum.ToString()
                            : string.Empty;
                        txtScatteredAmount.Text = product.ScatteredCargoSpaceMaximum.HasValue
                            ? product.ScatteredCargoSpaceMaximum.ToString()
                            : string.Empty;
                        txtScatteredAlaramAmount.Text = product.ScatteredCargoSpaceMinimum.HasValue
                            ? product.ScatteredCargoSpaceMinimum.ToString()
                            : string.Empty;
                        txtStoreAlaramAmount.Text = product.StockMinAmount.HasValue
                            ? product.StockMinAmount.ToString()
                            : string.Empty;
                    }
                    conn.Close();
                }
            }
        }

        public void Init()
        {
            txtEntireAmount.Text = "";
            txtPackagingProportion.Text = "";
            txtProductBarcode.Text = "";
            txtProductName.Text = "";
            txtScatteredAlaramAmount.Text = "";
            txtScatteredAmount.Text = "";
            txtStoreAlaramAmount.Text = "";
            lvwProductDetails.Tag = null;
        }
    }
}