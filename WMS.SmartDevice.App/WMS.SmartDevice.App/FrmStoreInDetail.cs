using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using WMS.SmartDevice.App.Models;
using WMS.SmartDevice.App.Utils;

namespace WMS.SmartDevice.App
{
    public partial class FrmStoreInDetail : Form
    {
        public int StoreID { get; set; }

        public FrmStoreInDetail()
        {
            InitializeComponent();
        }
        // Singleton design patern
        private static FrmStoreInDetail _Instance = null;
        public static FrmStoreInDetail Instance()
        {
            if (_Instance == null || _Instance.IsDisposed)
            {
                _Instance = new FrmStoreInDetail();
            }
            _Instance.BringToFront();
            return _Instance;
        }
        private void muBack_Click(object sender, EventArgs e)
        {
            var doc = FrmStoreIn.Instance(StoreID);
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
            var recommendCode = txtRecommendPosition.Text.Trim();
            var barcode = txtBarcode.Text.Trim();
            int amount = int.Parse(txtAmount.Text.Trim());
            if (Program.SystemSignPosition)
            {
                if (barcode != recommendCode)
                {
                    MessageBox.Show("货位信息有误，请重新扫描！");
                    tabControl.SelectedIndex = 1;
                    return;
                }
            }
            if (selectedDetailId == 0)
            {
                MessageBox.Show("请选择要入库的药品！");

                tabControl.SelectedIndex = 1;
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

                    tabControl.SelectedIndex = 1;
                    return;
                }

                var structures = conn.Query<StoreInDetailViewModel>(
                        "SELECT CSSD.ProductID,CSSD.ProductBatchNumber AS BatchNo,CSSD.ProductAmount AS Amount FROM BFI_StorageStructure AS SS LEFT JOIN dbo.WMS_CargoSpaceStoreDetail AS CSSD ON CSSD.StructureID = SS.StructureID WHERE SS.StructureCode=@StructureCode",
                        new { StructureCode = barcode });

                if (structures.Any())
                {
                    var structure = structures.FirstOrDefault();
                    var billDetails =
                        conn.Query<StoreInDetailViewModel>(
                            "SELECT SBD.ProductID,P.StockCondition,SBD.BatchNo FROM dbo.WMS_StoreInDetail AS SBD INNER JOIN dbo.BFI_Product AS P ON P.ProductID=SBD.ProductID WHERE SBD.DetailID=@DetailID",
                            new {DetailID = selectedDetailId});
                    var billDetail = billDetails.FirstOrDefault();
                    if (structure.ProductID > 0)
                    {

                        if (null != billDetail)
                        {
                            if (structure.ProductID != billDetail.ProductID || structure.BatchNo != billDetail.BatchNo)
                            {
                                MessageBox.Show("同一货位只能放同一批号的同一药品，请重新输入！");
                                return;
                            }
                        }

                    }
                    var stockConditions =
                        conn.Query<string>(
                            "SELECT W.WarehouseType from dbo.BFI_StorageStructure AS SS INNER JOIN dbo.BFI_Warehouse AS W ON W.WarehouseID = SS.WarehouseID WHERE SS.StructureID=@StructureID",
                            new {StructureID = structureID});
#if !SY
                    if (stockConditions.Any())
                    {
                        var stockCondition = stockConditions.FirstOrDefault();
                        if (null != stockCondition && stockCondition != billDetail.StockCondition)
                        {
                            MessageBox.Show("仓库存储环境与药品存储条件不一致，请重新输入货位信息！");
                            return;
                        }
                    }
#endif
                }
                else
                {
                    MessageBox.Show("货位未找到，请重新输入货位信息！");
                    return;
                }


                var storeBillDetails =
                    conn.Query<StoreInDetailViewModel>(
                        "SELECT DetailID,BSB.StoreID,BSB.StoreCode,P.ProductID,P.ProductName,P.ProductSpec,SBD.BatchNo,P.PhysicType,P.ProducerName,P.PackagingProportion,SBD.ProduceDate,SBD.ValidateDate, Amount FROM WMS_StoreInDetail AS SBD INNER JOIN BUS_StoreBill AS BSB ON SBD.StoreID=BSB.StoreID INNER JOIN BFI_Product AS P ON SBD.ProductID=P.ProductID WHERE SBD.DetailID=@DetailID",
                        new {DetailID = selectedDetailId});
                if (storeBillDetails.Any())
                {

                    var storeBillDetail = storeBillDetails.First();
                    CargoSpaceStoreDetail cargoSpaceStoreDetail = new CargoSpaceStoreDetail
                    {
                        StoreCode = storeBillDetail.StoreCode,
                        ProductID = storeBillDetail.ProductID,
                        ProductAmount = amount,
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
                        string sql = "IF NOT EXISTS(SELECT 1 FROM WMS_CargoSpaceStoreDetail WHERE StructureID=@StructureID AND ProductID=@ProductID AND ProductBatchNumber=@ProductBatchNumber)"
                                     +
                                     "\nINSERT INTO WMS_CargoSpaceStoreDetail(StoreCode,StructureID,ProductID,ProductBatchNumber,ProductionDate,ProductValidDate,ProductAmount,Manufacturer,DosageForm,PackagingSpecification) VALUES(@StoreCode,@StructureID,@ProductID,@ProductBatchNumber,@ProductionDate,@ProductValidDate,@ProductAmount,@Manufacturer,@DosageForm,@PackagingSpecification)"
                                     +
                                     "\nELSE UPDATE WMS_CargoSpaceStoreDetail SET ProductAmount=(ProductAmount+@ProductAmount) WHERE StructureID=@StructureID AND ProductID=@ProductID AND ProductBatchNumber=@ProductBatchNumber"
                            //更新入库明细表入库数量,状态
                                     +
                                     "\nUPDATE WMS_StoreInDetail SET StoreAmount=(StoreAmount+@ProductAmount), StatusID=CASE WHEN (StoreAmount+@ProductAmount)=0 THEN StatusID WHEN Amount=(StoreAmount+@ProductAmount) THEN 3 ELSE 1 END, StatusName=CASE WHEN (StoreAmount+@ProductAmount)=0 THEN StatusName WHEN Amount=(StoreAmount+@ProductAmount) THEN '完成入库' ELSE '正在入库' END WHERE DetailID=@DetailID"
                                     +
                                     "\nUPDATE BUS_StoreBillDetail SET StoreAmount=(StoreAmount+@ProductAmount), Reservation1=CASE WHEN (StoreAmount+@ProductAmount)=0 THEN Reservation1 WHEN Amount=(StoreAmount+@ProductAmount) THEN '3' ELSE '1' END, Reservation2=CASE WHEN (StoreAmount+@ProductAmount)=0 THEN Reservation2 WHEN Amount=(StoreAmount+@ProductAmount) THEN '完成入库' ELSE '正在入库' END WHERE DetailID=(SELECT StoreBillDetailID FROM WMS_StoreInDetail WHERE DetailID=@DetailID)"
                            //保存入库历史记录
                                     +
                                     "\nINSERT INTO WMS_StoreInHistory(StoreCode,StructureID,ProductID,ProductBatchNumber,ProductionDate,ProductValidDate,ProductAmount,Manufacturer,DosageForm,PackagingSpecification,StoreInDate) VALUES(@StoreCode,@StructureID,@ProductID,@ProductBatchNumber,@ProductionDate,@ProductValidDate,@ProductAmount,@Manufacturer,@DosageForm,@PackagingSpecification,GETDATE())";
                        if (Program.SystemSignPosition)
                        {
                            sql = "IF NOT EXISTS(SELECT 1 FROM WMS_CargoSpaceStoreDetail WHERE StructureID=@StructureID AND ProductID=@ProductID AND ProductBatchNumber=@ProductBatchNumber)"
                                     +
                                     "\nINSERT INTO WMS_CargoSpaceStoreDetail(StoreCode,StructureID,ProductID,ProductBatchNumber,ProductionDate,ProductValidDate,ProductAmount,Manufacturer,DosageForm,PackagingSpecification) VALUES(@StoreCode,@StructureID,@ProductID,@ProductBatchNumber,@ProductionDate,@ProductValidDate,@ProductAmount,@Manufacturer,@DosageForm,@PackagingSpecification)"
                                     +
                                     "\nELSE UPDATE WMS_CargoSpaceStoreDetail SET ProductAmount=(ProductAmount+@ProductAmount) WHERE StructureID=@StructureID AND ProductID=@ProductID AND ProductBatchNumber=@ProductBatchNumber"
                            //更新入库明细表入库数量,状态
                                     +
                                     "\nUPDATE WMS_StoreInDetail SET StatusID=3, StatusName='完成入库' WHERE DetailID=@DetailID"
                                     +
                                     "\nUPDATE BUS_StoreBillDetail SET StoreAmount=(StoreAmount+@ProductAmount), Reservation1=CASE WHEN (StoreAmount+@ProductAmount)=0 THEN Reservation1 WHEN Amount=(StoreAmount+@ProductAmount) THEN '3' ELSE '1' END, Reservation2=CASE WHEN (StoreAmount+@ProductAmount)=0 THEN Reservation2 WHEN Amount=(StoreAmount+@ProductAmount) THEN '完成入库' ELSE '正在入库' END WHERE DetailID=(SELECT StoreBillDetailID FROM WMS_StoreInDetail WHERE DetailID=@DetailID)"
                            //保存入库历史记录
                                     +
                                     "\nINSERT INTO WMS_StoreInHistory(StoreCode,StructureID,ProductID,ProductBatchNumber,ProductionDate,ProductValidDate,ProductAmount,Manufacturer,DosageForm,PackagingSpecification,StoreInDate) VALUES(@StoreCode,@StructureID,@ProductID,@ProductBatchNumber,@ProductionDate,@ProductValidDate,@ProductAmount,@Manufacturer,@DosageForm,@PackagingSpecification,GETDATE())";
                        }
                        conn.Execute(
                            //保存入库货位信息,如无记录新增，否则更新入库数量
                            sql,
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
                            "UPDATE BUS_StoreBill SET Reservation1='2', Reservation2='停止' WHERE StoreID=@StoreID",
                            new { StoreID = StoreID }, null);
                    }
                }
            }
            BindStoreInDetailRecords(StoreID);

            tabControl.SelectedIndex = 0;
        }

        public void BindStoreInDetailRecords(int storeId)
        {
            StoreID = storeId;

            txtAmount.Text = "";
            txtPackageSpec.Text = "";
            txtSpec.Text = "";
            txtProductName.Text = "";
            txtBatchNo.Text = "";
            txtBarcode.Text = "";

            lvwStoreDetails.Items.Clear();
            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var storeBillDetails =
                    conn.Query<StoreInDetailViewModel>(
                        "SELECT DetailID,BSB.StoreID,BSB.StoreCode,P.ProductID,P.ProductName,P.PackageSpec,P.ProductSpec,BatchNo,CASE ISNULL(StoreAmount,0) WHEN 0 THEN Amount ELSE Amount-ISNULL(StoreAmount,0) END AS Amount,StructureCode FROM WMS_StoreInDetail AS SBD, BUS_StoreBill AS BSB, BFI_Product AS P WHERE SBD.StoreID=BSB.StoreID AND SBD.ProductID=P.ProductID AND SBD.StoreID=@StoreID AND CAST(ISNULL(SBD.StatusID,'0') AS INT)<3",
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
                        item.StructureCode
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
                tabControl.SelectedIndex = 1;
            }
        }

        private void LoadDetailInfo(int selectedDetailId)
        {
            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                string sql = "SELECT DetailID,BSB.StoreID,BSB.StoreCode,P.ProductID,P.ProductName,P.ProductSpec,P.PackageSpec,BatchNo,Amount,SBD.StructureCode,SS.StructureName FROM WMS_StoreInDetail AS SBD, BUS_StoreBill AS BSB, BFI_Product AS P, dbo.BFI_StorageStructure AS SS WHERE SBD.StoreID=BSB.StoreID AND SBD.ProductID=P.ProductID AND SS.StructureID = SBD.StructureID AND SBD.DetailID=@DetailID";
                if (!Program.SystemSignPosition)
                {
                    sql = "SELECT DetailID,BSB.StoreID,BSB.StoreCode,P.ProductID,P.ProductName,P.ProductSpec,P.PackageSpec,BatchNo,Amount,SBD.StructureCode, '' AS StructureName FROM WMS_StoreInDetail AS SBD, BUS_StoreBill AS BSB, BFI_Product AS P WHERE SBD.StoreID=BSB.StoreID AND SBD.ProductID=P.ProductID AND SBD.DetailID=@DetailID";
                }
                var storeBillDetails =
                    conn.Query<StoreInDetailViewModel>(
                        sql,
                        new {DetailID = selectedDetailId});
                
                if (storeBillDetails.Any())
                {
                    txtPackageSpec.Tag = selectedDetailId;
                    var storeBillDetail = storeBillDetails.First();
                    this.Text = storeBillDetail.StoreCode;
                    txtPackageSpec.Text = storeBillDetail.PackageSpec;
                    //txtAmount.Text = storeBillDetail.Amount.HasValue ? storeBillDetail.Amount.Value.ToString() : "";
                    txtBatchNo.Text = storeBillDetail.BatchNo;
                    txtProductName.Text = storeBillDetail.ProductName;
                    txtSpec.Text = storeBillDetail.ProductSpec;

                    int amount = 0;
                    if (storeBillDetail.Amount.HasValue)
                    {
                        amount = storeBillDetail.Amount.Value;
                        if (amount > 0)
                        {
                            if (Program.SystemSignPosition)
                            {
                                txtAmount.Text = amount.ToString();
                            }
                            else
                            {
                                var billAmounts =
                                    conn.Query<int>(
                                        "SELECT StoreAmount FROM BUS_StoreBillDetail WHERE DetailID=(SELECT StoreBillDetailID FROM WMS_StoreInDetail WHERE DetailID=@DetailID)",
                                        new {DetailID = selectedDetailId});
                                int billAmount = billAmounts.FirstOrDefault();
                                txtAmount.Text = (amount - billAmount).ToString();
                            }
                        }
                    }

                    txtArea.Text = storeBillDetail.StructureName;
                    txtRecommendPosition.Text = storeBillDetail.StructureCode;
#if SY
                    var productID = storeBillDetail.ProductID;
                    var batchNo = storeBillDetail.BatchNo;

                    //var autoPositionSql =
                    //    "SELECT TOP 1 SS.StructureBarCode,SS.StructureName,W.WarehouseType FROM dbo.BFI_StorageStructure AS SS INNER JOIN dbo.BFI_Warehouse AS W ON W.WarehouseID = SS.WarehouseID AND SS.IsMinStructure=1 LEFT OUTER JOIN dbo.WMS_CargoSpaceStoreDetail AS CSSD ON CSSD.StructureID = SS.StructureID WHERE ISNULL(CSSD.ProductAmount, 0)=0 AND SS.AreaType IN('整货','零货') AND W.WarehouseType=(SELECT StockCondition FROM dbo.BFI_Product WHERE ProductID=@ProductID)";
                    //顺义，不分整货零货
                    var autoPositionSql =
                        "IF EXISTS(SELECT 1 FROM dbo.WMS_CargoSpaceStoreDetail WHERE ProductID=@ProductID AND ProductBatchNumber=@ProductBatchNumber) "
                        + "SELECT TOP 1 SS.StructureBarCode,SS.StructureName,W.WarehouseType "
                        + "FROM dbo.BFI_StorageStructure AS SS "
                        + "INNER JOIN dbo.BFI_Warehouse AS W "
                        + "ON W.WarehouseID = SS.WarehouseID AND SS.IsMinStructure=1 "
                        + "LEFT OUTER JOIN dbo.WMS_CargoSpaceStoreDetail AS CSSD "
                        + "ON CSSD.StructureID = SS.StructureID "
                        + "WHERE SS.AreaType IN('整货','零货') AND CSSD.ProductID=@ProductID AND ProductBatchNumber=@ProductBatchNumber "
                        + "ELSE "
                        + "SELECT TOP 1 SS.StructureBarCode,SS.StructureName,W.WarehouseType "
                        + "FROM dbo.BFI_StorageStructure AS SS "
                        + "INNER JOIN dbo.BFI_Warehouse AS W "
                        + "ON W.WarehouseID = SS.WarehouseID AND SS.IsMinStructure=1 "
                        + "LEFT OUTER JOIN dbo.WMS_CargoSpaceStoreDetail AS CSSD "
                        + "ON CSSD.StructureID = SS.StructureID "
                        + "WHERE ISNULL(CSSD.ProductAmount, 0)=0 AND SS.AreaType IN('整货','零货') "
                        + "AND W.WarehouseType=(SELECT StockCondition FROM dbo.BFI_Product WHERE ProductID=@ProductID)";
                    var recommendPositions = conn.Query<RecommendPositionViewModel>(autoPositionSql, new { ProductID = productID, ProductBatchNumber = batchNo });
                    var recommendPosition = recommendPositions.FirstOrDefault();
                    if (null != recommendPosition)
                    {
                        txtArea.Text = recommendPosition.StructureName;
                        txtRecommendPosition.Text = recommendPosition.StructureBarCode;
                    }
#endif
                    conn.Close();
                }
            }

            if (!Program.SystemSignPosition)
            {
                txtAmount.Enabled = true;
                txtAmount.ReadOnly = false;
/*#if !SY
                lblRecomment.Visible = false;
                txtRecommendPosition.Visible = false;

                lblArea.Visible = false;
                txtArea.Visible = false;

                txtBarcode.Location = txtArea.Location;
                lblBarcode.Location = lblArea.Location;
#endif
 */
            }
        }

        private void FrmStoreInDetail_Activated(object sender, EventArgs e)
        {
            BindStoreInDetailRecords(StoreID);
        }
    }
}