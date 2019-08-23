using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using WMS.SmartDevice.App.Models;
using WMS.SmartDevice.App.Utils;

namespace WMS.SmartDevice.App
{
    public partial class FrmUnqualifiedStoreInDetail : Form
    {
        public int StoreID { get; set; }

        public FrmUnqualifiedStoreInDetail()
        {
            InitializeComponent();
        }
        // Singleton design patern
        private static FrmUnqualifiedStoreInDetail _Instance = null;
        public static FrmUnqualifiedStoreInDetail Instance()
        {
            if (_Instance == null || _Instance.IsDisposed)
            {
                _Instance = new FrmUnqualifiedStoreInDetail();
            }
            _Instance.BringToFront();
            return _Instance;
        }
        private void muBack_Click(object sender, EventArgs e)
        {
            var doc = FrmUnqualifiedStoreIn.Instance(StoreID);
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
            int storeAmount = (int) txtStoreAmount.Value;
            int billAmount = 0;
            if (!string.IsNullOrEmpty(txtAmount.Text))
            {
                billAmount = int.Parse(txtAmount.Text.Trim());
            }

            if (selectedDetailId == 0)
            {
                MessageBox.Show("请选择要入库的药品！");
                return;
            }
            if (storeAmount > billAmount)
            {
                MessageBox.Show("存放数量不能大于入库数量！");
                return;
            }
            var dialogResult = MessageBox.Show("确定入库?", "系统确认框", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
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
                    MessageBox.Show("货位信息有误，请重新输入！");
                    return;
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
                    conn.Query<StoreInDetailViewModel>(
                        "SELECT DetailID,BSB.StoreID,BSB.StoreCode,P.ProductID,P.ProductName,P.ProductSpec,SBD.BatchNo,P.PhysicType,P.ProducerName,P.PackagingProportion,SBD.ProduceDate,SBD.ValidateDate,(Amount-StoreAmount) AS Amount FROM BUS_StoreBillDetail AS SBD INNER JOIN BUS_StoreBill AS BSB ON SBD.StoreID=BSB.StoreID INNER JOIN BFI_Product AS P ON SBD.ProductID=P.ProductID WHERE SBD.DetailID=@DetailID",
                        new {DetailID = selectedDetailId});
                if (storeBillDetails.Any())
                {

                    var storeBillDetail = storeBillDetails.First();
                    CargoSpaceStoreDetail cargoSpaceStoreDetail = new CargoSpaceStoreDetail
                    {
                        StoreCode = storeBillDetail.StoreCode,
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
                            //保存入库货位信息,如无记录新增，否则更新入库数量
                            "IF NOT EXISTS(SELECT 1 FROM WMS_CargoSpaceStoreDetail WHERE StructureID=@StructureID AND ProductID=@ProductID AND ProductBatchNumber=@ProductBatchNumber)"
                            +"\nINSERT INTO WMS_CargoSpaceStoreDetail(StoreCode,StructureID,ProductID,ProductBatchNumber,ProductionDate,ProductValidDate,ProductAmount,Manufacturer,DosageForm,PackagingSpecification) VALUES(@StoreCode,@StructureID,@ProductID,@ProductBatchNumber,@ProductionDate,@ProductValidDate,@ProductAmount,@Manufacturer,@DosageForm,@PackagingSpecification)"
                            + "\nELSE UPDATE WMS_CargoSpaceStoreDetail SET ProductAmount=(ProductAmount+@ProductAmount) WHERE StructureID=@StructureID AND ProductID=@ProductID AND ProductBatchNumber=@ProductBatchNumber"
                            //更新入库明细表入库数量,状态
                            + "\nUPDATE BUS_StoreBillDetail SET StoreAmount=(StoreAmount+@ProductAmount), Reservation1=CASE WHEN (StoreAmount+@ProductAmount)=0 THEN Reservation1 WHEN Amount=(StoreAmount+@ProductAmount) THEN '3' ELSE '1' END, Reservation2=CASE WHEN (StoreAmount+@ProductAmount)=0 THEN Reservation2 WHEN Amount=(StoreAmount+@ProductAmount) THEN '完成入库' ELSE '正在入库' END WHERE DetailID=@DetailID"
                            //保存入库历史记录
                            +"\nINSERT INTO WMS_StoreInHistory(StoreCode,StructureID,ProductID,ProductBatchNumber,ProductionDate,ProductValidDate,ProductAmount,Manufacturer,DosageForm,PackagingSpecification,StoreInDate) VALUES(@StoreCode,@StructureID,@ProductID,@ProductBatchNumber,@ProductionDate,@ProductValidDate,@ProductAmount,@Manufacturer,@DosageForm,@PackagingSpecification,GETDATE())",
                            new
                            {
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
                        MessageBox.Show("入库失败！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk,
                            MessageBoxDefaultButton.Button1);
                        return;
                    }

                    string storeBillDetailStatusSql = "SELECT DISTINCT(Reservation1) AS DetailCount FROM dbo.BUS_StoreBillDetail WHERE StoreID=@StoreID";
                    var storeBillDetailStatuses = conn.Query<string>(storeBillDetailStatusSql, new {StoreID = StoreID});
                    if (storeBillDetailStatuses.All(p => p == "3"))
                    {
                        //入库单完成
                        conn.Execute(
                            "UPDATE BUS_StoreBill SET Reservation1='3', Reservation2='完成入库' WHERE StoreID=@StoreID",
                            new {StoreID = StoreID}, null);
                        //入库单完成
                        conn.Execute("UPDATE BUS_Bill SET BillStatus=5, BillStatusName='已入库' WHERE BillID=(SELECT PurchaseBillID FROM dbo.BUS_StoreBill WHERE StoreID=@StoreID)",
                            new {StoreID = StoreID}, null);
                    }
                    else if (storeBillDetailStatuses.Any(p => p == "1"))
                    {
                        //正在入库

                        conn.Execute(
                            "UPDATE BUS_StoreBill SET Reservation1='1', Reservation2='正在入库' WHERE StoreID=@StoreID",
                            new { StoreID = StoreID }, null);
                    }
                    else if (storeBillDetailStatuses.Any(p => p == "2"))
                    {
                        //停止入库
                        conn.Execute(
                            "UPDATE BUS_StoreBill SET Reservation1='2', Reservation2='停止入库' WHERE StoreID=@StoreID",
                            new { StoreID = StoreID }, null);
                    }
                }
            }
            BindStoreInDetailRecords(StoreID);
        }

        public void BindStoreInDetailRecords(int storeId)
        {
            StoreID = storeId;

            txtAmount.Text = "";
            txtPackageSpec.Text = "";
            txtSpec.Text = "";
            txtProductName.Text = "";
            txtBatchNo.Text = "";
            txtStoreAmount.Text = "";
            txtBarcode.Text = "";

            lvwStoreDetails.Items.Clear();
            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var storeBillDetails =
                    conn.Query<StoreInDetailViewModel>(
                        "SELECT DetailID,BSB.StoreID,BSB.StoreCode,P.ProductID,P.ProductName,P.PackageSpec,P.ProductSpec,BatchNo,(Amount-StoreAmount) AS Amount FROM BUS_StoreBillDetail AS SBD, BUS_StoreBill AS BSB, BFI_Product AS P WHERE SBD.StoreID=BSB.StoreID AND SBD.ProductID=P.ProductID AND SBD.StoreID=@StoreID AND CAST(ISNULL(SBD.Reservation1,'0') AS INT)<3",
                        new{StoreID=storeId});
                conn.Close();
                foreach (var item in storeBillDetails)
                {
                    lvwStoreDetails.Items.Add(new ListViewItem(new string[]
                    {
                        item.DetailID.ToString(),
                        item.ProductName,
                        item.BatchNo,
                        item.PackageSpec,
                        item.ProductSpec,
                        item.Amount.HasValue ? item.Amount.Value.ToString() : string.Empty,
                        string.Empty
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
                    conn.Query<StoreInDetailViewModel>(
                        "SELECT DetailID,BSB.StoreID,BSB.StoreCode,P.ProductID,P.ProductName,P.ProductSpec,P.PackageSpec,BatchNo,(Amount-StoreAmount) AS Amount FROM BUS_StoreBillDetail AS SBD, BUS_StoreBill AS BSB, BFI_Product AS P WHERE SBD.StoreID=BSB.StoreID AND SBD.ProductID=P.ProductID AND SBD.DetailID=@DetailID",
                        new {DetailID = selectedDetailId});
                conn.Close();
                if (storeBillDetails.Any())
                {
                    txtPackageSpec.Tag = selectedDetailId;
                    var storeBillDetail = storeBillDetails.First();
                    this.Text = storeBillDetail.StoreCode;
                    txtPackageSpec.Text = storeBillDetail.PackageSpec;
                    txtAmount.Text = storeBillDetail.Amount.HasValue ? storeBillDetail.Amount.Value.ToString() : "";
                    txtBatchNo.Text = storeBillDetail.BatchNo;
                    txtProductName.Text = storeBillDetail.ProductName;
                    txtSpec.Text = storeBillDetail.ProductSpec;

                    //var productID = storeBillDetail.ProductID;
                    //var batchNo = storeBillDetail.BatchNo;

                    //var autoPositionSql =
                    //    "SELECT SS.StructureBarCode FROM dbo.WMS_CargoSpaceStoreDetail AS CSSD INNER JOIN dbo.BFI_StorageStructure AS SS ON SS.StructureID = CSSD.StructureID WHERE ProductID=@ProductID AND ProductBatchNumber=@ProductBatchNumber";

                    int amount = 0;
                    if (storeBillDetail.Amount.HasValue)
                    {
                        amount = storeBillDetail.Amount.Value;
                        if (amount > 0)
                        {
                            txtStoreAmount.Value = amount;
                        }
                    }
                }
            }
        }

        private void FrmUnqualifiedStoreInDetail_Activated(object sender, EventArgs e)
        {
            BindStoreInDetailRecords(StoreID);
        }
    }
}