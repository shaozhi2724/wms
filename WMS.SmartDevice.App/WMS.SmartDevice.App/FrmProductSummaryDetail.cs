using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using WMS.SmartDevice.App.Models;
using WMS.SmartDevice.App.Utils;

namespace WMS.SmartDevice.App
{
    public partial class FrmProductSummaryDetail : Form
    {
        private static int _inventoryStatisticId;
        public FrmProductSummaryDetail()
        {
            InitializeComponent();
        }

        // Singleton design patern
        private static FrmProductSummaryDetail _Instance = null;
        public static FrmProductSummaryDetail Instance(int inventoryStatisticId)
        {
            if (_Instance == null || _Instance.IsDisposed)
            {
                _Instance = new FrmProductSummaryDetail();
            }
            _Instance.BringToFront();
            _inventoryStatisticId = inventoryStatisticId;
            return _Instance;
        }

        private void muBack_Click(object sender, EventArgs e)
        {
            FrmMain.Instance().Show();
            Close();
        }
        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                
                SearchInventoryTaskDetail();
            }
        }

        private void SearchInventoryTaskDetail()
        {
            string barCode = txtBarcode.Text.Trim();
            if (string.IsNullOrEmpty(barCode))
            {
                InitSearch();
                MessageBox.Show("请输入或扫描货位条码！");
                return;
            }
            string query = @"SELECT DetailID,
                                InventoryStatisticID,
                                CargoSpaceStoreDetailID,
                                WarehouseID,
                                StructureID,
                                StructureCode,
                                StructureName,
                                AreaType,
                                ProductID,
                                ProductBatchNumber,
                                ProductionDate,
                                ProductValidDate,
                                ProductAmount,
                                Manufacturer,
                                DosageForm,
                                PackagingSpecification,
                                ProductName,
                                ProductSpec,
                                PackageSpec,
                                PackagingProportion,
                                PhysicType,
                                StockCondition,
                                VerifiedProductID,
                                VerifiedProductBatchNumber,
                                VerifiedProductionDate,
                                VerifiedProductValidDate,
                                VerifiedProductAmount,
                                VerifiedManufacturer,
                                VerifiedDosageForm,
                                VerifiedPackagingSpecification,
                                VerifiedProductName,
                                VerifiedProductSpec,
                                VerifiedPackageSpec,
                                VerifiedPackagingProportion,
                                VerifiedPhysicType,
                                VerifiedStockCondition,
                                StatusID,
                                StatusName,
                                CreateDate,
                                VerifiedDate
                                FROM dbo.WMS_InventoryStatisticDetail
                                WHERE InventoryStatisticID=@InventoryStatisticID
                                AND StructureCode=@Barcode";
            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var inventory =
                    conn.Query<InventoryStatisticDetailViewModel>(query, new
                    {
                        InventoryStatisticID = _inventoryStatisticId,
                        Barcode = barCode
                    }).FirstOrDefault();
                if (null != inventory)
                {
                    txtBarcode.Tag = inventory.DetailID;
                    txtProductName.Text = inventory.ProductName;
                    txtSpec.Text = inventory.ProductSpec;
                    txtPackageSpec.Text = inventory.PackageSpec;
                    txtBatchNo.Text = inventory.ProductBatchNumber;
                    txtManufacturer.Text = inventory.Manufacturer;
                    txtManufactureDate.Text = inventory.ProductionDate.HasValue
                        ? inventory.ProductionDate.Value.ToString("yyyy-MM-dd")
                        : string.Empty;
                    txtValidityDate.Text = inventory.ProductValidDate.HasValue
                        ? inventory.ProductValidDate.Value.ToString("yyyy-MM-dd")
                        : string.Empty;
                    txtAmount.Text = inventory.ProductAmount.HasValue ? inventory.ProductAmount.Value.ToString() : "";
                }
                else
                {
                    InitSearch();
                }
                conn.Close();
            }
        }

        public void InitSearch()
        {
            txtBarcode.Tag = null;
            txtBarcode.Text = "";
            txtAmount.Text = "";
            txtBatchNo.Text = "";
            txtProductName.Text = "";
            txtManufacturer.Text = "";
            txtSpec.Text = "";
            txtPackageSpec.Text = "";
            txtManufactureDate.Text = "";
            txtValidityDate.Text = "";
            txtAmount.Text = "";
            txtVerifiedAmount.Text = "";
            txtBarcode.Focus();
        }

        private void muSummary_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text;
            string batchNo = txtBatchNo.Text;
            string barcode = txtBarcode.Text.Trim();
            int taskDetailId = 0;
            int verifiedAmount = 0;
            if (!string.IsNullOrEmpty(txtVerifiedAmount.Text))
            {
                verifiedAmount = int.Parse(txtVerifiedAmount.Text.Trim());
            }
            if (null != txtBarcode.Tag)
            {
                taskDetailId = (int) txtBarcode.Tag;
            }
            else
            {
                MessageBox.Show("货位盘点信息有误，请重新输入或扫描！");
                InitSearch();
                return;
            }
            string confirmMsg = string.Format("确定完成货位 {0} 的盘点任务?\n药品:{1}\n批号:{2}\n盘点数量: {3}", barcode, productName, batchNo, verifiedAmount);
            var dialogResult = MessageBox.Show(confirmMsg, "系统确认框", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1);
            if (dialogResult != DialogResult.Yes)
            {
                return;
            }

            if (taskDetailId > 0)
            {
                string sql = @"UPDATE dbo.WMS_InventoryStatisticDetail SET VerifiedProductAmount=@VerifiedProductAmount,StatusID=3,StatusName='完成盘点',VerifiedDate=GETDATE() WHERE DetailID=@DetailID
                               UPDATE dbo.WMS_InventoryStatistic SET StatusID=1,StatusName='正在盘点' WHERE InventoryStatisticID=@InventoryStatisticID AND StatusID=0
                               IF NOT EXISTS(SELECT 1 FROM dbo.WMS_InventoryStatisticDetail WHERE InventoryStatisticID=@InventoryStatisticID AND StatusID<>3)
                                   UPDATE dbo.WMS_InventoryStatistic SET StatusID=3,StatusName='完成盘点' WHERE InventoryStatisticID=@InventoryStatisticID";
                using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();
                    try
                    {
                        conn.Execute(
                            sql,
                            new
                            {
                                DetailID = taskDetailId,
                                InventoryStatisticID = _inventoryStatisticId,
                                VerifiedProductAmount = verifiedAmount
                            }, transaction);
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        MessageBox.Show("盘点信息保存失败，请重试！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk,
                            MessageBoxDefaultButton.Button1);
                        return;
                    }

                }
            }

            InitSearch();
        }
    }
}