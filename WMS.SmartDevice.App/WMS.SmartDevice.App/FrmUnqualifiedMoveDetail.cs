using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using WMS.SmartDevice.App.Models;
using WMS.SmartDevice.App.Utils;

namespace WMS.SmartDevice.App
{
    public partial class FrmUnqualifiedMoveDetail : Form
    {
        public int UnqualifiedID { get; set; }

        public FrmUnqualifiedMoveDetail()
        {
            InitializeComponent();
        }
        // Singleton design patern
        private static FrmUnqualifiedMoveDetail _Instance = null;
        public static FrmUnqualifiedMoveDetail Instance()
        {
            if (_Instance == null || _Instance.IsDisposed)
            {
                _Instance = new FrmUnqualifiedMoveDetail();
            }
            _Instance.BringToFront();
            return _Instance;
        }
        private void muBack_Click(object sender, EventArgs e)
        {
            var doc = FrmUnqualifiedMove.Instance(UnqualifiedID);
            doc.BindStoreInRecords();
            doc.Show();
            Close();
        }

        private void muSaveStoreIn_Click(object sender, EventArgs e)
        {
            //取值必须在模态窗口弹出前，否则取不到值
            int selectedDetailId = 0;
            if (null != lvwStoreDetails.FocusedItem)
            {
                selectedDetailId = int.Parse(lvwStoreDetails.FocusedItem.SubItems[0].Text);
            }
            if (selectedDetailId == 0)
            {
                selectedDetailId = (int) lvwStoreDetails.Tag;
            }

            var barcode = txtBarcode.Text.Trim();
            var sourceBarcode = txtSourceBarcode.Text.Trim();
            int storeAmount = (int) txtStoreAmount.Value;
            int billAmount = 0;
            if (!string.IsNullOrEmpty(txtAmount.Text))
            {
                billAmount = int.Parse(txtAmount.Text.Trim());
            }

            if (selectedDetailId == 0)
            {
                MessageBox.Show("请选择要移库的药品！");
                return;
            }
            if (storeAmount > billAmount)
            {
                MessageBox.Show("移出数量不能大于明细数量！");
                return;
            }
            var dialogResult = MessageBox.Show("确定移库?", "系统确认框", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (dialogResult != DialogResult.Yes)
            {
                return;
            }

            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var structureIDs =
                    conn.Query<int>(
                        "SELECT StructureID FROM BFI_StorageStructure WHERE StructureCode=@StructureCode",
                        new {StructureCode = barcode});
                int structureID = structureIDs.FirstOrDefault();
                if (structureID == 0)
                {
                    MessageBox.Show("目的货位信息有误，请重新输入！");
                    return;
                }

                var sourceStructures = conn.Query<StoreInDetailViewModel>(
                        "SELECT CSSD.ProductID,CSSD.ProductBatchNumber AS BatchNo,CSSD.ProductAmount AS Amount,SS.AreaType FROM BFI_StorageStructure AS SS LEFT JOIN dbo.WMS_CargoSpaceStoreDetail AS CSSD ON CSSD.StructureID = SS.StructureID WHERE SS.StructureCode=@StructureCode",
                        new { StructureCode = sourceBarcode });
                if (sourceStructures.Any())
                {
                    var structure = sourceStructures.FirstOrDefault();
                    if (null == structure)
                    {
                        MessageBox.Show("原货位信息有误，请重新输入！");
                        return;
                    }
                    else
                    {

                        var sourceAmount = structure.Amount;
                        if (sourceAmount < storeAmount)
                        {
                            MessageBox.Show("原货位药品数量不足，请重新输入移出数量！");
                            return;
                        }
                    }
                }

                var structures = conn.Query<StoreInDetailViewModel>(
                        "SELECT CSSD.ProductID,CSSD.ProductBatchNumber AS BatchNo,CSSD.ProductAmount AS Amount,SS.AreaType FROM BFI_StorageStructure AS SS LEFT JOIN dbo.WMS_CargoSpaceStoreDetail AS CSSD ON CSSD.StructureID = SS.StructureID WHERE SS.StructureCode=@StructureCode",
                        new { StructureCode = barcode });

                if (structures.Any())
                {
                    var structure = structures.FirstOrDefault();
                    if (structure.ProductID > 0)
                    {
                        var billDetails =
                            conn.Query<StoreInDetailViewModel>(
                                "SELECT SBD.ProductID,P.StockCondition,SBD.BatchNo FROM dbo.BUS_StoreBillDetail AS SBD INNER JOIN dbo.BFI_Product AS P ON P.ProductID=SBD.ProductID WHERE SBD.DetailID=@DetailID",
                                new {DetailID = selectedDetailId});
                        var billDetail = billDetails.FirstOrDefault();
                        if (null != billDetail)
                        {
                            if (structure.ProductID != billDetail.ProductID || structure.BatchNo != billDetail.BatchNo)
                            {
                                MessageBox.Show("同一货位只能放同一批号的同一药品，请重新输入！");
                                return;
                            }
                            if (!structure.AreaType.Contains("不合格"))
                            {
                                MessageBox.Show("不合格品必须存放在不合格品区，请重新输入货位信息！");
                                return;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("货位未找到，请重新输入货位信息！");
                    return;
                }


                var storeBillDetails =
                    conn.Query<UnqualifiedMoveDetailViewModel>(
                        "SELECT DetailID,PU.UnqualifiedID,PU.UnqualifiedCode,PUD.ProductID,P.ProductName,P.ProductSpec,PUD.BatchNo,P.PhysicType,P.ProducerName,P.PackagingProportion,PUD.ProduceDate,PUD.ValidateDate,(Amount-CAST(ISNULL(PUD.Reservation1,0) AS INT)) AS Amount FROM BUS_ProductUnqualifiedDetail AS PUD INNER JOIN BUS_ProductUnqualified AS PU ON PUD.UnqualifiedID=PU.UnqualifiedID INNER JOIN BFI_Product AS P ON PUD.ProductID=P.ProductID WHERE PUD.DetailID=@DetailID",
                        new {DetailID = selectedDetailId});
                if (storeBillDetails.Any())
                {

                    var storeBillDetail = storeBillDetails.First();
                    CargoSpaceStoreDetail cargoSpaceStoreDetail = new CargoSpaceStoreDetail
                    {
                        StoreCode = storeBillDetail.UnqualifiedCode,
                        ProductID = storeBillDetail.ProductID,
                        ProductAmount = storeAmount,
                        ProductBatchNumber = storeBillDetail.BatchNo,
                        StructureID = structureID,
                        DosageForm = storeBillDetail.PhysicType,
                        Manufacturer = storeBillDetail.ProducerName,
                        PackagingSpecification = storeBillDetail.PackagingProportion,
                        ProductionDate = storeBillDetail.ProduceDate,
                        ProductValidDate = storeBillDetail.ValidateDate
                    };
                    SqlTransaction transaction = conn.BeginTransaction();
                    try
                    {

                        conn.Execute(
                            "UPDATE WMS_CargoSpaceStoreDetail SET ProductAmount=ProductAmount-@ProductAmount WHERE ProductID=@ProductID AND ProductBatchNumber=@ProductBatchNumber AND StructureID=(SELECT StructureID FROM dbo.BFI_StorageStructure WHERE StructureCode=@SourceStructureCode)"
                            //保存入库货位信息,如无记录新增，否则更新入库数量
                            +"\nIF NOT EXISTS(SELECT 1 FROM WMS_CargoSpaceStoreDetail WHERE StructureID=@StructureID AND ProductID=@ProductID AND ProductBatchNumber=@ProductBatchNumber)"
                            +"\nINSERT INTO WMS_CargoSpaceStoreDetail(StoreCode,StructureID,ProductID,ProductBatchNumber,ProductionDate,ProductValidDate,ProductAmount,Manufacturer,DosageForm,PackagingSpecification) VALUES(@StoreCode,@StructureID,@ProductID,@ProductBatchNumber,@ProductionDate,@ProductValidDate,@ProductAmount,@Manufacturer,@DosageForm,@PackagingSpecification)"
                            +"\nELSE UPDATE WMS_CargoSpaceStoreDetail SET ProductAmount=(ProductAmount+@ProductAmount) WHERE StructureID=@StructureID AND ProductID=@ProductID AND ProductBatchNumber=@ProductBatchNumber"
                                //更新入库明细表入库数量,状态
                            +"\nUPDATE BUS_ProductUnqualifiedDetail SET Reservation1=(CAST(ISNULL(Reservation1,0) AS INT)+@ProductAmount), Reservation2=CASE WHEN (CAST(ISNULL(Reservation1,0) AS INT)+@ProductAmount)=0 THEN Reservation2 WHEN Amount=(CAST(ISNULL(Reservation1,0) AS INT)+@ProductAmount) THEN '3' ELSE '1' END, Reservation3=CASE WHEN (CAST(ISNULL(Reservation1,0) AS INT)+@ProductAmount)=0 THEN Reservation3 WHEN Amount=(CAST(ISNULL(Reservation1,0) AS INT)+@ProductAmount) THEN '完成移库' ELSE '正在移库' END WHERE DetailID=@DetailID"
                            +"\nDELETE WMS_CargoSpaceStoreDetail WHERE ProductID=@ProductID AND ProductBatchNumber=@ProductBatchNumber AND ProductAmount=0",
                            //保存入库历史记录
                            //+"\nINSERT INTO WMS_StoreInHistory(StoreCode,StructureID,ProductID,ProductBatchNumber,ProductionDate,ProductValidDate,ProductAmount,Manufacturer,DosageForm,PackagingSpecification,StoreInDate) VALUES(@StoreCode,@StructureID,@ProductID,@ProductBatchNumber,@ProductionDate,@ProductValidDate,@ProductAmount,@Manufacturer,@DosageForm,@PackagingSpecification,GETDATE())",
                            new
                            {
                                SourceStructureCode = sourceBarcode,
                                DetailID = storeBillDetail.DetailID,
                                StoreCode = cargoSpaceStoreDetail.StoreCode,
                                StructureID = cargoSpaceStoreDetail.StructureID,
                                ProductID = cargoSpaceStoreDetail.ProductID,
                                ProductBatchNumber = cargoSpaceStoreDetail.ProductBatchNumber,
                                ProductionDate = cargoSpaceStoreDetail.ProductionDate,
                                ProductValidDate = cargoSpaceStoreDetail.ProductValidDate,
                                ProductAmount = cargoSpaceStoreDetail.ProductAmount,
                                Manufacturer = cargoSpaceStoreDetail.Manufacturer,
                                DosageForm = cargoSpaceStoreDetail.DosageForm,
                                PackagingSpecification = cargoSpaceStoreDetail.PackagingSpecification
                            }, transaction);
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        MessageBox.Show("移库失败！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk,
                            MessageBoxDefaultButton.Button1);
                        return;
                    }

                    string storeBillDetailStatusSql = "SELECT DISTINCT(Reservation2) AS DetailCount FROM dbo.BUS_ProductUnqualifiedDetail WHERE UnqualifiedID=@UnqualifiedID";
                    var storeBillDetailStatuses = conn.Query<string>(storeBillDetailStatusSql, new { UnqualifiedID = UnqualifiedID });
                    if (storeBillDetailStatuses.All(p => p == "3"))
                    {
                        //不合格品移库单完成
                        conn.Execute(
                            "UPDATE BUS_ProductUnqualified SET UnqualifiedStatusID=4, UnqualifiedStatus='已处理' WHERE UnqualifiedID=@UnqualifiedID",
                            new { UnqualifiedID = UnqualifiedID }, null);
                    }
                }
            }
            BindStoreInDetailRecords(UnqualifiedID);
        }

        public void BindStoreInDetailRecords(int unqualifiedID)
        {
            if (unqualifiedID > 0)
            {
                UnqualifiedID = unqualifiedID;
            }

            txtAmount.Text = "";
            txtSourceBarcode.Text = "";
            txtProductName.Text = "";
            txtBatchNo.Text = "";
            txtStoreAmount.Text = "";
            txtBarcode.Text = "";
            txtPackageSpec.Text = "";

            lvwStoreDetails.Items.Clear();
            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var storeBillDetails =
                    conn.Query<UnqualifiedMoveDetailViewModel>(
                        "SELECT PUD.DetailID,PUD.UnqualifiedID,PU.UnqualifiedCode,PUD.ProductID,P.ProductName,P.PackageSpec,PUD.BatchNo,PUD.ProduceDate,PUD.ValidateDate,(PUD.Amount-CAST(ISNULL(PUD.Reservation1,0) AS INT)) AS Amount FROM [dbo].[BUS_ProductUnqualifiedDetail] AS PUD INNER JOIN dbo.BUS_ProductUnqualified AS PU ON PU.UnqualifiedID=PUD.UnqualifiedID INNER JOIN dbo.BFI_Product AS P ON P.ProductID=PUD.ProductID WHERE PUD.UnqualifiedID=@UnqualifiedID AND ISNULL(PUD.Reservation2,'1')='1'",
                        new { UnqualifiedID = UnqualifiedID });
                conn.Close();
                foreach (var item in storeBillDetails)
                {
                    lvwStoreDetails.Items.Add(new ListViewItem(new string[]
                    {
                        item.DetailID.ToString(),
                        item.ProductName,
                        item.BatchNo,
                        item.PackageSpec,
                        item.Amount.ToString()
                    }));
                }
                muSaveStoreIn.Enabled = storeBillDetails.Any();
                if (storeBillDetails.Any())
                {
                    var detail = storeBillDetails.FirstOrDefault();
                    if (null != detail)
                    {
                        lvwStoreDetails.Tag = detail.DetailID;
                        lvwStoreDetails.Items[0].Selected = true;
                        LoadDetailInfo(detail.DetailID);
                    }
                }
                else
                {
                    var doc = FrmUnqualifiedMove.Instance(UnqualifiedID);
                    doc.BindStoreInRecords();
                    doc.Show();
                    Close();
                }
            }
        }

        private void lvwStoreDetails_ItemActivate(object sender, EventArgs e)
        {
            if (lvwStoreDetails.SelectedIndices.Count > 0)
            {
                ListViewItem item = lvwStoreDetails.Items[lvwStoreDetails.SelectedIndices[0]];
                var selectedDetailId = int.Parse(item.SubItems[0].Text);
                LoadDetailInfo(selectedDetailId);
            }
        }

        private void LoadDetailInfo(int selectedDetailId)
        {
            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var storeBillDetails =
                    conn.Query<UnqualifiedMoveDetailViewModel>(
                        "SELECT PUD.DetailID,PUD.UnqualifiedID,PU.UnqualifiedCode,PUD.ProductID,P.ProductName,P.PackageSpec,PUD.BatchNo,PUD.ProduceDate,PUD.ValidateDate,(PUD.Amount-CAST(ISNULL(PUD.Reservation1,0) AS INT)) AS Amount FROM [dbo].[BUS_ProductUnqualifiedDetail] AS PUD INNER JOIN dbo.BUS_ProductUnqualified AS PU ON PU.UnqualifiedID=PUD.UnqualifiedID INNER JOIN dbo.BFI_Product AS P ON P.ProductID=PUD.ProductID WHERE PUD.DetailID=@DetailID",
                        new {DetailID = selectedDetailId});
                conn.Close();
                if (storeBillDetails.Any())
                {
                    txtSourceBarcode.Tag = selectedDetailId;
                    var storeBillDetail = storeBillDetails.First();
                    this.Text = storeBillDetail.UnqualifiedCode;
                    txtAmount.Text = storeBillDetail.Amount.ToString();
                    txtStoreAmount.Value = storeBillDetail.Amount;
                    txtBatchNo.Text = storeBillDetail.BatchNo;
                    txtProductName.Text = storeBillDetail.ProductName;
                    txtPackageSpec.Text = storeBillDetail.PackageSpec;
                }
            }
        }

        private void FrmUnqualifiedStoreInDetail_Activated(object sender, EventArgs e)
        {
        }

        private void txtSourceBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;

                this.muSaveStoreIn.Enabled = CheckProduct();
            }
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                this.muSaveStoreIn.Enabled = CanTransferProduct();
            }
        }

        private bool CheckProduct()
        {
            string sourceStructureCode = txtSourceBarcode.Text.Trim();
            string productName = txtProductName.Text.Trim();
            string batchNo = txtBatchNo.Text.Trim();
            string query =
                "SELECT SS.StructureBarcode,SS.StructureCode AS SourceStructureCode,SS.StructureID AS SourceStructureID,CSSD.ProductID,P.ProductName,P.ProductSpec,CSSD.ProductBatchNumber,CSSD.ProductAmount FROM dbo.WMS_CargoSpaceStoreDetail AS CSSD INNER JOIN dbo.BFI_StorageStructure AS SS ON SS.StructureID = CSSD.StructureID INNER JOIN dbo.BFI_Product AS P ON P.ProductID = CSSD.ProductID WHERE SS.StructureBarCode=@StructureBarcode";
            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var sourceStructureProduct =
                    conn.Query<TransferProductViewModel>(query, new { StructureBarcode = sourceStructureCode }).FirstOrDefault();

                conn.Close();
                if (null != sourceStructureProduct)
                {
                    if (sourceStructureProduct.ProductName != productName ||
                        sourceStructureProduct.ProductBatchNumber != batchNo)
                    {
                        MessageBox.Show("原货位药品或批号与移库单明细不一致，不能进行不合格品移库操作！");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("原货位药品或批号与移库单明细不一致，不能进行不合格品移库操作！");
                    return false;
                }
            }
            return true;
        }

        private bool CanTransferProduct()
        {
            string targetStructureCode = txtBarcode.Text.Trim();
            string sourceStructureCode = txtSourceBarcode.Text.Trim();
            string productName = txtProductName.Text.Trim();
            string batchNo = txtBatchNo.Text.Trim();
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
                "SELECT SS.StructureBarcode,SS.StructureCode AS TargetStructureCode,SS.StructureID AS TargetStructureID,CSSD.ProductID,P.ProductName,P.ProductSpec,CSSD.ProductBatchNumber,CSSD.ProductAmount FROM dbo.WMS_CargoSpaceStoreDetail AS CSSD INNER JOIN dbo.BFI_StorageStructure AS SS ON SS.StructureID = CSSD.StructureID INNER JOIN dbo.BFI_Product AS P ON P.ProductID = CSSD.ProductID WHERE SS.StructureBarCode=@StructureBarcode";
            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var targetStructureProduct =
                    conn.Query<TransferProductViewModel>(query, new { StructureBarcode = targetStructureCode }).FirstOrDefault();

                conn.Close();
                if (null != targetStructureProduct)
                {
                    if (targetStructureProduct.ProductName != productName ||
                        targetStructureProduct.ProductBatchNumber != batchNo)
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