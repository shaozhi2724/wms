using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using WMS.SmartDevice.App.Models;
using WMS.SmartDevice.App.Utils;

namespace WMS.SmartDevice.App
{
    public partial class FrmInitStoreIn : Form
    {
        public FrmInitStoreIn()
        {
            InitializeComponent();
        }
        // Singleton design patern
        private static FrmInitStoreIn _Instance = null;
        public static FrmInitStoreIn Instance()
        {
            if (_Instance == null || _Instance.IsDisposed)
            {
                _Instance = new FrmInitStoreIn();
            }
            _Instance.BringToFront();
            return _Instance;
        }
        private void muBack_Click(object sender, EventArgs e)
        {
            FrmMain.Instance().Show();
            this.Close();
        }

        private void muConfirm_Click(object sender, EventArgs e)
        {
            //取值必须在模态窗口弹出前，否则取不到值
            int selectedProductId = 0;
            if (null != lvwProductDetails.FocusedItem)
            {
                if (null == lvwProductDetails.Tag)
                {
                    selectedProductId = (int) lvwProductDetails.FocusedItem.Tag;
                }
                else
                {
                    selectedProductId = (int)lvwProductDetails.Tag;
                }
            }

            var barcode = txtStoreBarcode.Text.Trim();
            string batchNumber = txtBatchNo.Text.Trim();
            int amount = -1;
            try
            {
                amount = int.Parse(txtAmount.Text.Trim());
            }
            catch (Exception)
            {
            }

            DateTime manufactureDate = DateTime.MinValue.Date;
            DateTime validityDate = DateTime.MinValue.Date;
            try
            {
                manufactureDate = DateTime.ParseExact(txtManufactureDate.Text.Trim(), "yyyyMMdd", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
            }

            try
            {
                validityDate = DateTime.ParseExact(txtValidityDate.Text.Trim(), "yyyyMMdd", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
            }


            if (selectedProductId == 0)
            {
                MessageBox.Show("请选择要入库的药品！");
                return;
            }
            if (string.IsNullOrEmpty(barcode))
            {
                MessageBox.Show("请输入或扫描要入库药品所在货位号！");
                return;
            }

            if (amount <= 0)
            {
                MessageBox.Show("请输入正确的入库数量！");
                return;
            }
            var dialogResult = MessageBox.Show("确定保存入库信息?", "系统确认框", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button1);
            if (dialogResult != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
                {
                    //检测仓库库存
                    string checkStoreSql =
                        "SELECT CargoSpaceStoreDetailID FROM WMS_CargoSpaceStoreDetail AS CSSD INNER JOIN BFI_StorageStructure AS SS ON SS.StructureID = CSSD.StructureID WHERE SS.StructureCode=@StructureCode";
                    //检测仓库货位
                    string checkStructureCodeSql =
                        "SELECT COUNT(1) FROM BFI_StorageStructure WHERE StructureCode=@StructureCode";

                    string productSql =
                        "SELECT ProductID,ChinesePinyin,ProductCode,ProductName,ProductBarCode,ProductSpec,PackagingProportion,StockCondition,ProductSpec,PhysicType,ProducerName,EntireCargoSpaceMaximum,ScatteredCargoSpaceMaximum FROM BFI_Product WHERE ProductID=@ProductID";

                    string sql =
                        //保存仓库库存
                        "INSERT INTO WMS_CargoSpaceStoreDetail(StructureID,ProductID,ProductBatchNumber,ProductionDate,ProductValidDate,ProductAmount,Manufacturer,DosageForm,PackagingSpecification) SELECT (SELECT TOP 1 StructureID FROM BFI_StorageStructure WHERE StructureCode=@StructureCode),@ProductID,@ProductBatchNumber,@ProductionDate,@ProductValidDate,@ProductAmount,ProducerName,PhysicType,PackagingProportion FROM BFI_Product WHERE ProductID=@ProductID";
                    //保存业务库存记录
                    //+ "\nINSERT INTO BUS_StoreDetail(ProductID,BatchNo,ProduceDate,ValidateDate,Amount,CreateDate) VALUES(@ProductID,@ProductBatchNumber,@ProductionDate,@ProductValidDate,@ProductAmount,GETDATE())";

                    string updateSql =
                        //保存仓库库存
                        "UPDATE WMS_CargoSpaceStoreDetail SET StructureID=(SELECT TOP 1 StructureID FROM BFI_StorageStructure WHERE StructureCode=@StructureCode),ProductID=@ProductID,ProductBatchNumber=@ProductBatchNumber,ProductionDate=@ProductionDate,ProductValidDate=@ProductValidDate,ProductAmount=@ProductAmount,Manufacturer=@Manufacturer,DosageForm=@DosageForm,PackagingSpecification=@PackagingSpecification WHERE CargoSpaceStoreDetailID=@CargoSpaceStoreDetailID";
                    //保存业务库存记录
                    //+ "\nINSERT INTO BUS_StoreDetail(ProductID,BatchNo,ProduceDate,ValidateDate,Amount,CreateDate) VALUES(@ProductID,@ProductBatchNumber,@ProductionDate,@ProductValidDate,@ProductAmount,GETDATE())";

                    conn.Open();

                    var structures = conn.Query<int>(checkStructureCodeSql, new { StructureCode = barcode });
                    if (!structures.Any())
                    {
                        MessageBox.Show("请输入或扫描正确的货位号！");
                        return;
                    }

                    var product = conn.Query<Product>(productSql, new {ProductID = selectedProductId}).FirstOrDefault();
                    if (null != product)
                    {
                        var cargoSpaceStoreDetailIDs = conn.Query<int>(checkStoreSql, new {StructureCode = barcode});
                        if (cargoSpaceStoreDetailIDs.Any())
                        {
                            var storeDetailID = cargoSpaceStoreDetailIDs.First();
                            if (DialogResult.Yes ==
                                MessageBox.Show("指定的货位已存在入库药品，是否替换？", "系统信息", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
                            {
                                var rowsEffected =
                                    conn.Execute(updateSql,
                                        new
                                        {
                                            ProductID = selectedProductId,
                                            StructureCode = barcode,
                                            ProductBatchNumber = batchNumber,
                                            ProductionDate = manufactureDate == DateTime.MinValue ? DBNull.Value.ToString() : manufactureDate.ToString("yyyyMMdd"),
                                            ProductValidDate = validityDate == DateTime.MinValue ? DBNull.Value.ToString() : validityDate.ToString("yyyyMMdd"),
                                            ProductAmount = amount,
                                            Manufacturer = product.ProducerName,
                                            DosageForm = product.PhysicType,
                                            PackagingSpecification = product.PackageSpec,
                                            CargoSpaceStoreDetailID = storeDetailID
                                        }, null);
                            }
                            else
                            {
                                return;
                            }

                        }
                        else
                        {
                            var rowsEffected =
                                conn.Execute(sql,
                                    new
                                    {
                                        ProductID = selectedProductId,
                                        StructureCode = barcode,
                                        ProductBatchNumber = batchNumber,
                                        ProductionDate = manufactureDate == DateTime.MinValue ? DBNull.Value.ToString() : manufactureDate.ToString("yyyyMMdd"),
                                        ProductValidDate = validityDate == DateTime.MinValue ? DBNull.Value.ToString() : validityDate.ToString("yyyyMMdd"),
                                        ProductAmount = amount,
                                        Manufacturer = product.ProducerName,
                                        DosageForm = product.PhysicType,
                                        PackagingSpecification = product.PackageSpec
                                    }, null);
                        }

                    }

                    ////统计保存业务库存记录 - 每次清空后计算
                    //var updateStoreDetailSql = "DELETE BUS_StoreDetail"
                    //                           + "\nINSERT INTO BUS_StoreDetail(ProductID,BatchNo,ProduceDate,ValidateDate,Amount,CreateDate)"
                    //                           + "\nSELECT ProductID,ProductBatchNumber,ProductionDate,ProductValidDate,SUM(ProductAmount),GETDATE()"
                    //                           + "\nFROM dbo.WMS_CargoSpaceStoreDetail"
                    //                           + "\nGROUP BY ProductID,ProductBatchNumber,ProductionDate,ProductValidDate";
                    //conn.Execute(updateStoreDetailSql, null, null);
                    conn.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("保存药品入库信息失败！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk,
                            MessageBoxDefaultButton.Button1);
            }

            SearchProducts();
        }

        public void SearchProducts()
        {
            lvwProductDetails.Items.Clear();
            lvwProductDetails.Tag = null;

            txtAmount.Text = "";
            txtBatchNo.Text = "";
            txtManufactureDate.Text = "";
            txtValidityDate.Text = "";
            txtStoreBarcode.Text = "";

            string productName = txtProductName.Text.Trim();
            string barcode = txtProductBarcode.Text.Trim();

            if (string.IsNullOrEmpty(productName) && string.IsNullOrEmpty(barcode))
            {
                return;
            }

            string query =
                "SELECT ISNULL(SD.StoreDetailID, 0) AS StoreDetailID,P.ProductID,P.ChinesePinyin,P.ProductCode,P.ProductName,P.ProductBarCode,SD.BatchNo,SD.ProduceDate,SD.ValidateDate,P.ProductSpec,PackageSpec,P.PackagingProportion,P.StockCondition,P.ProductSpec,P.PhysicType,P.ProducerName,P.EntireCargoSpaceMaximum,P.ScatteredCargoSpaceMaximum FROM dbo.BUS_StoreDetail AS SD RIGHT JOIN BFI_Product AS P ON P.ProductID=SD.ProductID WHERE 1=1";

            if (!string.IsNullOrEmpty(barcode))
            {
                query = string.Concat(query, " AND P.ProductBarCode LIKE '%", barcode, "%'");
            }
            if (!string.IsNullOrEmpty(productName))
            {
                query = string.Concat(query, " AND (P.ProductName LIKE '%", productName, "%' OR P.ProductSpell LIKE '%", productName, "%')");
            }
            query = string.Concat(query, " ORDER BY P.ProductID");
            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var products =
                    conn.Query<ProductViewModel>(query)
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
                    listViewItem.Tag = string.Concat(item.ProductID, "-", item.StoreDetailID);
                    lvwProductDetails.Items.Add(listViewItem);
                }
            }
        }

        private void lvwProductDetails_ItemActivate(object sender, EventArgs e)
        {
            if (lvwProductDetails.SelectedIndices.Count > 0)
            {
                ListViewItem item = lvwProductDetails.Items[lvwProductDetails.SelectedIndices[0]];
                var selectedProductString = (string) (item.Tag);
                var strings = selectedProductString.Split('-');
                var selectedProductId = int.Parse(strings[0]);
                var selectedStoreDetailID = int.Parse(strings[1]);

                lvwProductDetails.Tag = selectedProductId;

                string query = "SELECT ISNULL(SD.StoreDetailID, 0) AS StoreDetailID,P.ProductID,P.ChinesePinyin,P.ProductCode,P.ProductName,P.ProductBarCode,SD.BatchNo,ISNULL(SD.Amount,0) AS Amount,SD.ProduceDate,SD.ValidateDate,P.ProductSpec,PackageSpec,P.PackagingProportion,P.StockCondition,P.ProductSpec,P.PhysicType,P.ProducerName,P.EntireCargoSpaceMaximum,P.ScatteredCargoSpaceMaximum FROM dbo.BUS_StoreDetail AS SD RIGHT JOIN BFI_Product AS P ON P.ProductID=SD.ProductID WHERE P.ProductID=@ProductID AND ISNULL(SD.StoreDetailID, 0)=@StoreDetailID";
                using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
                {
                    conn.Open();
                    var product =
                        conn.Query<ProductViewModel>(query, new { ProductID = selectedProductId, StoreDetailID = selectedStoreDetailID}).FirstOrDefault();
                    if (null != product)
                    {
                        txtProductName.Text = product.ProductName;
                        txtProductBarcode.Text = product.ProductBarCode;
                        txtBatchNo.Text = !string.IsNullOrEmpty(product.BatchNo) ? product.BatchNo : "";
                        txtManufactureDate.Text = product.ProduceDate.HasValue ? product.ProduceDate.Value.ToString("yyyyMMdd") : "";
                        txtValidityDate.Text = product.ValidateDate.HasValue ? product.ValidateDate.Value.ToString("yyyyMMdd") : "";
                        txtAmount.Text = product.Amount.ToString();
                    }
                    conn.Close();
                }
            }
        }

        private void txtProductBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                SearchProducts();
            }
        }

        private void txtProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                SearchProducts();
            }
        }
    }
}