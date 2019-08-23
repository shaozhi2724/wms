using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using WMS.WinCE.App.Models;
using WMS.WinCE.App.Utils;

namespace WMS.WinCE.App
{
    public partial class FrmDemolitionConfirmation : Form
    {
        public TransferProductViewModel SourceTransferProduct { get; set; }
        public FrmDemolitionConfirmation()
        {
            InitializeComponent();
        }

        private void muBack_Click(object sender, EventArgs e)
        {
            FrmDemolition.Instance().Show();
            this.Close();
        }

        // Singleton design patern
        private static FrmDemolitionConfirmation _Instance = null;
        public static FrmDemolitionConfirmation Instance()
        {
            if (_Instance == null || _Instance.IsDisposed)
            {
                _Instance = new FrmDemolitionConfirmation();
            }
            _Instance.BringToFront();
            return _Instance;
        }

        private void muConfirm_Click(object sender, EventArgs e)
        {
            string targetStructureCode = txtTargetBarcode.Text.Trim();
            if (!CanTransferProduct())
            {
                return;
            }

            if (DialogResult.Yes ==
                MessageBox.Show("确定移库？", "系统确认框", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
            {
                string query =
                "UPDATE WMS_CargoSpaceStoreDetail SET ProductAmount=ProductAmount-@TransferAmount WHERE ProductID=@ProductID AND ProductBatchNumber=@ProductBatchNumber AND StructureID=@SourceStructureID"
                + "\nIF NOT EXISTS(SELECT 1 FROM WMS_CargoSpaceStoreDetail WHERE ProductID=@ProductID AND ProductBatchNumber=@ProductBatchNumber AND StructureID=(SELECT StructureID FROM BFI_StorageStructure WHERE StructureCode=@TargetBarcode))"
                + "\nINSERT INTO WMS_CargoSpaceStoreDetail (StructureID,ProductID,ProductBatchNumber,ProductionDate,ProductValidDate,ProductAmount,Manufacturer,DosageForm,PackagingSpecification) SELECT (SELECT StructureID FROM BFI_StorageStructure WHERE StructureCode=@TargetBarcode),@ProductID,@ProductBatchNumber,(SELECT TOP 1 ProductionDate FROM WMS_CargoSpaceStoreDetail WHERE ProductID=@ProductID AND ProductBatchNumber=@ProductBatchNumber AND StructureID=@SourceStructureID),(SELECT TOP 1 ProductValidDate FROM WMS_CargoSpaceStoreDetail WHERE ProductID=@ProductID AND ProductBatchNumber=@ProductBatchNumber AND StructureID=@SourceStructureID),@TransferAmount,ProducerName,PhysicType,PackageSpec FROM dbo.BFI_Product AS P WHERE P.ProductID=@ProductID"
                + "\nELSE"
                + "\nUPDATE WMS_CargoSpaceStoreDetail SET ProductAmount=ProductAmount+@TransferAmount WHERE ProductID=@ProductID AND ProductBatchNumber=@ProductBatchNumber AND StructureID=(SELECT StructureID FROM BFI_StorageStructure WHERE StructureCode=@TargetBarcode)"
                + "\nDELETE WMS_CargoSpaceStoreDetail WHERE ProductID=@ProductID AND ProductBatchNumber=@ProductBatchNumber AND ProductAmount=0 AND StructureID=@SourceStructureID";
                try
                {
                    using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
                    {
                        conn.Open();

                        conn.Execute(query, new
                        {
                            TransferAmount = SourceTransferProduct.TransferAmount,
                            ProductID = SourceTransferProduct.ProductID,
                            ProductBatchNumber = SourceTransferProduct.ProductBatchNumber,
                            SourceStructureID = SourceTransferProduct.SourceStructureID,
                            TargetBarcode = targetStructureCode
                        }, null);

                        conn.Close();
                    }
                    MessageBox.Show("药品移库成功！");
                    var doc = FrmDemolition.Instance();
                    doc.Init();
                    doc.Show();
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("药品移库失败！");
                    LoadTargetProductDetail(SourceTransferProduct);
                }
            }
        }

        public void LoadTargetProductDetail(TransferProductViewModel model)
        {
            SourceTransferProduct = model;
            txtTargetBarcode.Text = "";
            txtSourceStoreCode.Text = model.SourceStructureCode;
            txtTargetProductName.Text = model.ProductName;
            txtTargetBatchNo.Text = model.ProductBatchNumber;
            txtTargetSpec.Text = model.ProductSpec;
            txtTargetPackageSpec.Text = model.PackageSpec;
            txtProductAmount.Text = model.ProductAmount.ToString();
            txtTransferInAmount.Text = model.TransferAmount.ToString();
        }

        private void txtTargetBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                CanTransferProduct();
            }
        }

        private bool CanTransferProduct()
        {
            string targetStructureCode = txtTargetBarcode.Text.Trim();
            string sourceStructureCode = txtSourceStoreCode.Text.Trim();
            if (string.IsNullOrEmpty(targetStructureCode))
            {

                MessageBox.Show("请扫描或输入目标货位条码！");
                return false;
            }
            if (targetStructureCode == sourceStructureCode)
            {
                MessageBox.Show("目标货位与原货位相同，不能在相同货位进行药品移库操作！");
                return false;
            }

            string query =
                "SELECT SS.StructureBarcode,SS.StructureCode AS TargetStructureCode,SS.StructureID AS TargetStructureID,CSSD.ProductID,P.ProductName,P.PackageSpec,P.ProductSpec,CSSD.ProductBatchNumber,CSSD.ProductAmount FROM dbo.WMS_CargoSpaceStoreDetail AS CSSD INNER JOIN dbo.BFI_StorageStructure AS SS ON SS.StructureID = CSSD.StructureID INNER JOIN dbo.BFI_Product AS P ON P.ProductID = CSSD.ProductID WHERE SS.StructureBarCode=@StructureBarcode";
            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var targetStructureProduct =
                    conn.Query<TransferProductViewModel>(query, new { StructureBarcode = targetStructureCode }).FirstOrDefault();

                conn.Close();
                if (null != targetStructureProduct)
                {
                    if (targetStructureProduct.ProductID != SourceTransferProduct.ProductID ||
                        targetStructureProduct.ProductBatchNumber != SourceTransferProduct.ProductBatchNumber)
                    {
                        MessageBox.Show("目标货位与原货位药品或批号不一致，不能进行药品移库操作！");
                        return false;
                    }
                }
                else
                {
                    string sql = "SELECT StructureID FROM dbo.BFI_StorageStructure WHERE StructureBarCode=@StructureBarcode";
                    conn.Open();
                    var targetStructureID =
                        conn.Query<int>(sql, new { StructureBarcode = targetStructureCode }).FirstOrDefault();

                    conn.Close();
                    if (targetStructureID == 0)
                    {
                        MessageBox.Show("目标货位不存在，不能进行药品移库操作！");
                        return false;
                    }
                }
            }
            return true;
        }
    }
}