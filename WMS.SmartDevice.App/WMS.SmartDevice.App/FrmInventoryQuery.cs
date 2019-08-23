using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using WMS.SmartDevice.App.Models;
using WMS.SmartDevice.App.Utils;

namespace WMS.SmartDevice.App
{
    public partial class FrmInventoryQuery : Form
    {
        public FrmInventoryQuery()
        {
            InitializeComponent();
        }

        // Singleton design patern
        private static FrmInventoryQuery _Instance = null;
        public static FrmInventoryQuery Instance()
        {
            if (_Instance == null || _Instance.IsDisposed)
            {
                _Instance = new FrmInventoryQuery();
            }
            _Instance.BringToFront();
            return _Instance;
        }
        private void muBack_Click(object sender, EventArgs e)
        {
            FrmMain.Instance().Show();
            this.Close();
        }

        private void muQuery_Click(object sender, EventArgs e)
        {
            SearchProductInventory();
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                SearchProductInventory();
            }
        }

        private void SearchProductInventory()
        {
            string barCode = txtBarcode.Text.Trim();
            if (string.IsNullOrEmpty(barCode))
            {
                InitSearch();
                MessageBox.Show("请输入或扫描货位条码！");
                return;
            }
            string query = "SELECT CargoSpaceStoreDetailID,StoreCode,SS.StructureID,CSSD.ProductID,P.ProductName,P.PackageSpec,P.ProductSpec,ProductBatchNumber,ProductionDate,ProductValidDate,ProductAmount,Manufacturer,DosageForm,PackagingSpecification FROM WMS_CargoSpaceStoreDetail AS CSSD LEFT JOIN dbo.BFI_Product AS P ON P.ProductID=CSSD.ProductID INNER JOIN dbo.BFI_StorageStructure AS SS ON SS.StructureID = CSSD.StructureID WHERE SS.StructureBarcode=@Barcode";
            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var inventory =
                    conn.Query<InventoryViewModel>(query, new { Barcode = barCode }).FirstOrDefault();
                if (null != inventory)
                {
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
                    txtAmount.Text = inventory.ProductAmount.HasValue ? inventory.ProductAmount.Value.ToString() : "0";
                }
                conn.Close();
            }
        }

        public void InitSearch()
        {
            txtBarcode.Text = "";
            txtAmount.Text = "";
            txtBatchNo.Text = "";
            txtProductName.Text = "";
            txtManufacturer.Text = "";
            txtSpec.Text = "";
            txtPackageSpec.Text = "";
            txtManufactureDate.Text = "";
            txtValidityDate.Text = "";

        }
    }
}