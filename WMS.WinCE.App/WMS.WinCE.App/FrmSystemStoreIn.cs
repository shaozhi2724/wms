using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using WMS.WinCE.App.Models;
using WMS.WinCE.App.Utils;

namespace WMS.WinCE.App
{
    public partial class FrmSystemStoreIn : Form
    {
        private int _storeID;
        private int _detailID;

        public FrmSystemStoreIn()
        {
            InitializeComponent();
        }

        // Singleton design patern
        private static FrmSystemStoreIn _Instance = null;

        public static FrmSystemStoreIn Instance()
        {
            if (_Instance == null || _Instance.IsDisposed)
            {
                _Instance = new FrmSystemStoreIn();
            }
            _Instance.BringToFront();
            return _Instance;
        }

        private void muStoreIn_Click(object sender, EventArgs e)
        {
            if (_storeID == 0 || _detailID == 0)
            {
                MessageBox.Show("货物码错误，请重新扫描！");
                return;
            }
            var barcode = txtBarcode.Text.Trim();
            string recommendCode = txtRecommendPosition.Text.Trim();
            int amount = int.Parse(txtAmount.Text.Trim());
            if (barcode != recommendCode)
            {
                MessageBox.Show("确认货位错误，请重新扫描！");
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
                        new { StructureCode = barcode });
                int structureID = structureIDs.FirstOrDefault();
                if (structureID == 0)
                {
                    MessageBox.Show("货位信息有误，请重新输入！");
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
                            "SELECT SBD.ProductID,P.StockCondition,SBD.BatchNo,SBD.StatusName FROM dbo.WMS_StoreInDetail AS SBD INNER JOIN dbo.BFI_Product AS P ON P.ProductID=SBD.ProductID WHERE SBD.DetailID=@DetailID",
                            new { DetailID = _detailID });
                    var billDetail = billDetails.FirstOrDefault();
                    if (billDetail.StatusName == "完成入库")
                    {
                        MessageBox.Show("此入库任务已完成，不能重复入库！");
                        return;
                    }
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
                            new { StructureID = structureID });

                    if (stockConditions.Any())
                    {
                        var stockCondition = stockConditions.FirstOrDefault();
                        if (null != stockCondition && stockCondition != billDetail.StockCondition)
                        {
                            MessageBox.Show("仓库存储环境与药品存储条件不一致，请重新输入货位信息！");
                            return;
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
                        "SELECT DetailID,BSB.StoreID,BSB.StoreCode,P.ProductID,P.ProductName,P.ProductSpec,SBD.BatchNo,P.PhysicType,P.ProducerName,P.PackagingProportion,SBD.ProduceDate,SBD.ValidateDate, Amount FROM WMS_StoreInDetail AS SBD INNER JOIN BUS_StoreBill AS BSB ON SBD.StoreID=BSB.StoreID INNER JOIN BFI_Product AS P ON SBD.ProductID=P.ProductID WHERE SBD.DetailID=@DetailID",
                        new { DetailID = _detailID });
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
                        //更新入库明细表入库数量,状态
                        string  sql = "UPDATE WMS_StoreInDetail SET StatusID=3, StatusName='完成入库' WHERE DetailID=@DetailID"
                                     + "\nUPDATE BUS_StoreBillDetail SET StoreAmount=(StoreAmount+@ProductAmount), Reservation1=CASE WHEN (StoreAmount+@ProductAmount)=0 THEN Reservation1 WHEN Amount=(StoreAmount+@ProductAmount) THEN '3' ELSE '1' END, Reservation2=CASE WHEN (StoreAmount+@ProductAmount)=0 THEN Reservation2 WHEN Amount=(StoreAmount+@ProductAmount) THEN '完成入库' ELSE '正在入库' END WHERE DetailID=(SELECT StoreBillDetailID FROM WMS_StoreInDetail WHERE DetailID=@DetailID)"
                                     //保存入库历史记录
                                     + "\nINSERT INTO WMS_StoreInHistory(StoreCode,StructureID,ProductID,ProductBatchNumber,ProductionDate,ProductValidDate,ProductAmount,Manufacturer,DosageForm,PackagingSpecification,StoreInDate) VALUES(@StoreCode,@StructureID,@ProductID,@ProductBatchNumber,@ProductionDate,@ProductValidDate,@ProductAmount,@Manufacturer,@DosageForm,@PackagingSpecification,GETDATE())";

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
                    var storeBillDetailStatuses = conn.Query<string>(storeBillDetailStatusSql, new { StoreID = _storeID });
                    if (storeBillDetailStatuses.All(p => p == "3"))
                    {
                        //入库单完成
                        conn.Execute(
                            "UPDATE BUS_StoreBill SET Reservation1='3', Reservation2='完成入库' WHERE StoreID=@StoreID",
                            new { StoreID = _storeID }, null);
                    }
                    else if (storeBillDetailStatuses.Any(p => p == "1"))
                    {
                        //正在入库

                        conn.Execute(
                            "UPDATE BUS_StoreBill SET Reservation1='1', Reservation2='正在入库' WHERE StoreID=@StoreID",
                            new { StoreID = _storeID }, null);
                    }
                    else if (storeBillDetailStatuses.Any(p => p == "2"))
                    {
                        //停止入库
                        conn.Execute(
                            "UPDATE BUS_StoreBill SET Reservation1='2', Reservation2='停止' WHERE StoreID=@StoreID",
                            new { StoreID = _storeID }, null);
                    }
                    MessageBox.Show("入库成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("数据错误，请重新扫描货物码！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk,
                            MessageBoxDefaultButton.Button1);
                }
                InitControls();
            }
        }

        private void InitControls()
        {
            _storeID = 0;
            _detailID = 0;
            muStoreIn.Enabled = false;
            this.Text = "请扫描货物码";
            txtStoreCode.Text = "";
            txtBarcode.Text = "";
            txtAmount.Text = "";
            txtArea.Text = "";
            txtBatchNo.Text = "";
            txtPackageSpec.Text = "";
            txtProductName.Text = "";
            txtRecommendPosition.Text = "";
            txtSpec.Text = "";
            txtStoreCode.Focus();
        }

        private void muBack_Click(object sender, EventArgs e)
        {
            FrmMain.Instance().Show();
            Close();
        }

        private void txtStoreCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter || e.KeyChar == (char) Keys.Return)
            {
                e.Handled = true;
                try
                {
                    LoadStoreInTaskInfo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Asterisk,
                        MessageBoxDefaultButton.Button1);
                }
                txtBarcode.Focus();
            }
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char) Keys.Enter || e.KeyChar == (char) Keys.Return)
            {
                e.Handled = true;
                var structureBarcode = txtBarcode.Text.Trim();
                string recommendPosition = txtRecommendPosition.Text.Trim();
                muStoreIn.Enabled = structureBarcode == recommendPosition;
            }
        }

        private void LoadStoreInTaskInfo()
        {
            string code = txtStoreCode.Text.Trim();
            if (!string.IsNullOrEmpty(code))
            {
                if (!code.Contains('-'))
                {
                    MessageBox.Show("货物码错误，请重新扫描！");
                }
                var codeValues = code.Split('-');
                _storeID = int.Parse(codeValues[0]);
                _detailID = int.Parse(codeValues[1]);

                using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
                {
                    conn.Open();
                    string sql =
                        "SELECT DetailID,BSB.StoreID,BSB.StoreCode,P.ProductID,P.ProductName,P.ProductSpec,P.PackageSpec,BatchNo,Amount,SBD.StructureCode,SS.StructureName,SBD.StatusName FROM WMS_StoreInDetail AS SBD, BUS_StoreBill AS BSB, BFI_Product AS P, dbo.BFI_StorageStructure AS SS WHERE SBD.StoreID=BSB.StoreID AND SBD.ProductID=P.ProductID AND SS.StructureID = SBD.StructureID AND SBD.DetailID=@DetailID";
                    var storeBillDetails =
                        conn.Query<StoreInDetailViewModel>(
                            sql,
                            new {DetailID = _detailID});

                    if (storeBillDetails.Any())
                    {
                        var storeBillDetail = storeBillDetails.First();
                        this.Text = storeBillDetail.StoreCode;
                        txtPackageSpec.Text = storeBillDetail.PackageSpec;
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
                            }
                        }

                        txtArea.Text = storeBillDetail.StructureName;
                        txtRecommendPosition.Text = storeBillDetail.StructureCode;
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("货物码错误，请重新扫描！");
                    }
                }
            }

        }
    }
}