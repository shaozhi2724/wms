using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using WMS.SmartDevice.App.Models;
using WMS.SmartDevice.App.Utils;

namespace WMS.SmartDevice.App
{
    public partial class FrmProductTransferSource : Form
    {
        public FrmProductTransferSource()
        {
            InitializeComponent();
        }

        private void muBack_Click(object sender, EventArgs e)
        {
            FrmMain.Instance().Show();
            Close();
        }

        // Singleton design patern
        private static FrmProductTransferSource _Instance = null;
        public static FrmProductTransferSource Instance()
        {
            if (_Instance == null || _Instance.IsDisposed)
            {
                _Instance = new FrmProductTransferSource();
            }
            _Instance.BringToFront();
            return _Instance;
        }

        private void muNext_Click(object sender, EventArgs e)
        {
            var transferAmount = (int)txtTransferOutAmount.Value;
            string barcode = txtSourceBarcode.Text;
            if (string.IsNullOrEmpty(barcode))
            {
                MessageBox.Show("请扫描或输入原位条码！");
                return;
            }
            if (null == TransferSourceProduct)
            {
                LoadProductDetailBySturctureCode();
            }

            if (transferAmount > TransferSourceProduct.ProductAmount)
            {
                MessageBox.Show("移出数量超过库存数量，请重新输入移出数量！");
                return;
            }

            TransferSourceProduct.TransferAmount = transferAmount;
            FrmProductTransferConfirmation doc = FrmProductTransferConfirmation.Instance();

            doc.LoadTargetProductDetail(TransferSourceProduct);
            doc.Show();
            Close();
        }

        private void txtSourceBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                LoadProductDetailBySturctureCode();
            }
        }

        private void LoadProductDetailBySturctureCode()
        {
            string structureCode = txtSourceBarcode.Text.Trim();
            string query =
                "SELECT SS.StructureBarcode,SS.StructureCode AS SourceStructureCode,SS.StructureID AS SourceStructureID,CSSD.ProductID,P.ProductName,P.PackageSpec,P.ProductSpec,CSSD.ProductBatchNumber,CSSD.ProductAmount FROM dbo.WMS_CargoSpaceStoreDetail AS CSSD INNER JOIN dbo.BFI_StorageStructure AS SS ON SS.StructureID = CSSD.StructureID INNER JOIN dbo.BFI_Product AS P ON P.ProductID = CSSD.ProductID WHERE SS.StructureBarCode=@StructureBarcode";
            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var transferProductViewModels = conn.Query<TransferProductViewModel>(query, new { StructureBarcode = structureCode});
                
                conn.Close();
                muNext.Enabled = transferProductViewModels.Any();
                if (!transferProductViewModels.Any())
                {
                    MessageBox.Show("原货位无药品，不能进行移位操作！");
                    return;
                }
                TransferSourceProduct = transferProductViewModels.FirstOrDefault();
                if (null != TransferSourceProduct)
                {
                    TransferSourceProduct = transferProductViewModels.FirstOrDefault();

                    txtSourceAmount.Text = TransferSourceProduct.ProductAmount.ToString();
                    txtSourceStoreCode.Text = TransferSourceProduct.SourceStructureCode;
                    txtSourceBatchNo.Text = TransferSourceProduct.ProductBatchNumber;
                    txtSourceSpec.Text = TransferSourceProduct.ProductSpec;
                    txtSourcePackageSpec.Text = TransferSourceProduct.PackageSpec;
                    txtSourceProductName.Text = TransferSourceProduct.ProductName;
                }
            }
        }

        public void Init()
        {
            txtSourceAmount.Text = "";
            txtSourceBarcode.Text = "";
            txtSourceBatchNo.Text = "";
            txtSourceProductName.Text = "";
            txtSourceSpec.Text = "";
            txtSourcePackageSpec.Text = "";
            txtSourceStoreCode.Text = "";
            txtTransferOutAmount.Text = "";
        }

        public TransferProductViewModel TransferSourceProduct { get; set; }
    }
}