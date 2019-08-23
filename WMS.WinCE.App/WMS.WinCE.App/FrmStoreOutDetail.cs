using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using WMS.WinCE.App.Models;
using WMS.WinCE.App.Utils;

namespace WMS.WinCE.App
{
    public partial class FrmStoreOutDetail : Form
    {
        public int StoreID { get; set; }

        public FrmStoreOutDetail()
        {
            InitializeComponent();
        }
        // Singleton design patern
        private static FrmStoreOutDetail _Instance = null;
        public static FrmStoreOutDetail Instance()
        {
            if (_Instance == null || _Instance.IsDisposed)
            {
                _Instance = new FrmStoreOutDetail();
            }
            _Instance.BringToFront();
            return _Instance;
        }

        private void muBack_Click(object sender, EventArgs e)
        {
            var doc = FrmStoreOut.Instance(StoreID);
            doc.BindStoreOutRecords();
            doc.Show();
            Close();
        }

        private void muSaveStoreOut_Click(object sender, EventArgs e)
        {
            //取值必须在模态窗口弹出前，否则取不到值
            int selectedDetailId = 0;
            if (null != lvwStoreDetails.FocusedItem)
            {
                selectedDetailId = int.Parse(lvwStoreDetails.FocusedItem.SubItems[0].Text);
            }
            if (selectedDetailId == 0)
            {
                selectedDetailId = (int)lvwStoreDetails.Tag;
            }
            var barcode = txtBarcode.Text.Trim();
            var structureCode = txtStructurecode.Text.Trim();
            //int storeAmount = (int)txtStoreAmount.Value;
            int billAmount = 0;
            if (!string.IsNullOrEmpty(txtAmount.Text))
            {
                billAmount = int.Parse(txtAmount.Text.Trim());
            }

            if (selectedDetailId == 0)
            {
                MessageBox.Show("请选择要出库的药品！");
                return;
            }
            if (barcode != structureCode)
            {
                MessageBox.Show("出库货位不匹配，请重新输入或扫描出库货位！");
                return;
            }
            //if (storeAmount > billAmount)
            //{
            //    MessageBox.Show("出库数量不能大于存放数量！");
            //    return;
            //}
            var dialogResult = MessageBox.Show("确定出库?", "系统确认框", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
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
                var storeBillDetails =
                    conn.Query<StoreOutDetailViewModel>(
                        "SELECT PDATaskID,BillDetailID,T.StoreID,StoreCode,T.ProductID,T.ProductName,T.ProductSpec,BatchNo,P.PhysicType,P.ProducerName,P.PackagingProportion,T.ProduceDate,T.ValidateDate,Amount FROM WMS_PDATask AS T INNER JOIN dbo.BUS_StoreBill AS SB ON SB.StoreID = T.StoreID INNER JOIN dbo.BFI_Product AS P ON P.ProductID=T.ProductID WHERE PDATaskID=@PDATaskID",
                        new { PDATaskID = selectedDetailId });
                if (storeBillDetails.Any())
                {

                    var storeBillDetail = storeBillDetails.First();
                    CargoSpaceStoreDetail cargoSpaceStoreDetail = new CargoSpaceStoreDetail
                    {
                        StoreCode = storeBillDetail.StoreCode,
                        ProductID = storeBillDetail.ProductID,
                        ProductAmount = billAmount,
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
                            //更新库存数量
                            "UPDATE WMS_CargoSpaceStoreDetail SET ProductAmount=(ProductAmount-@ProductAmount) WHERE StructureID=@StructureID AND ProductID=@ProductID AND ProductBatchNumber=@ProductBatchNumber"
                            + "\nDELETE WMS_CargoSpaceStoreDetail WHERE ProductAmount<=0"
                            //更新入库明细表入库数量,状态
                            + "\nUPDATE WMS_PDATask SET TaskStatusID=CASE WHEN (Amount-@ProductAmount)=0 THEN '3' ELSE '1' END, TaskStatus=CASE WHEN (Amount-@ProductAmount)=0 THEN '完成出库' ELSE '正在出库' END WHERE PDATaskID=@PDATaskID"
                            + "\nUPDATE WMS_StoreBillDetail SET StatusID=CASE WHEN (Amount-@ProductAmount)=0 THEN '3' ELSE '1' END, StatusName=CASE WHEN (Amount-@ProductAmount)=0 THEN '完成出库' ELSE '正在出库' END WHERE WMSDetailID=(SELECT WMSDetailID FROM WMS_PDATask WHERE PDATaskID=@PDATaskID)"
                            + "\nUPDATE BUS_StoreBillDetail SET StoreAmount=(StoreAmount-@ProductAmount), Reservation1=CASE WHEN (StoreAmount-@ProductAmount)=0 THEN '3' ELSE '1' END, Reservation2=CASE WHEN (StoreAmount-@ProductAmount)=0 THEN '完成出库' ELSE '正在出库' END WHERE DetailID=(SELECT BillDetailID FROM WMS_PDATask WHERE PDATaskID=@PDATaskID)"
                            //保存出库历史记录
                            + "\nINSERT INTO WMS_StoreOutHistory(StoreCode,StructureID,ProductID,ProductBatchNumber,ProductionDate,ProductValidDate,ProductAmount,Manufacturer,DosageForm,PackagingSpecification,StoreOutDate) VALUES(@StoreCode,@StructureID,@ProductID,@ProductBatchNumber,@ProductionDate,@ProductValidDate,@ProductAmount,@Manufacturer,@DosageForm,@PackagingSpecification,GETDATE())",
                            new
                            {
                                PDATaskID = storeBillDetail.PDATaskID,
                                DetailID = storeBillDetail.BillDetailID,
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
                        MessageBox.Show("出库失败！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk,
                            MessageBoxDefaultButton.Button1);
                        return;
                    }
                    string storeBillDetailStatusSql = "SELECT DISTINCT(Reservation1) AS DetailCount FROM dbo.BUS_StoreBillDetail WHERE StoreID=@StoreID";
                    var storeBillDetailStatuses = conn.Query<string>(storeBillDetailStatusSql, new { StoreID = StoreID });
                    if (storeBillDetailStatuses.All(p => p == "3"))
                    {
                        //出库单完成
                        conn.Execute(
                            "UPDATE BUS_StoreBill SET Reservation1='3', Reservation2='已出库' WHERE StoreID=@StoreID",
                            new { StoreID = StoreID }, null);
                    }
                    else if (storeBillDetailStatuses.Any(p => p == "1"))
                    {
                        //正在出库

                        conn.Execute(
                            "UPDATE BUS_StoreBill SET Reservation1='1', Reservation2='正在出库' WHERE StoreID=@StoreID",
                            new { StoreID = StoreID }, null);
                    }
                    else if (storeBillDetailStatuses.Any(p => p == "2"))
                    {
                        //停止出库
                        conn.Execute(
                            "UPDATE BUS_StoreBill SET Reservation1='2', Reservation2='停止' WHERE StoreID=@StoreID",
                            new { StoreID = StoreID }, null);
                    }
                }
            }
            BindStoreOutDetailRecords(StoreID);
        }

        public void BindStoreOutDetailRecords(int storeId)
        {
            StoreID = storeId;

            //txtStoreAmount.Text = "";
            txtPackageSpec.Text = "";
            txtSpec.Text = "";
            txtProductName.Text = "";
            txtBatchNo.Text = "";
            txtAmount.Text = "";
            txtStructurecode.Text = "";
            txtBarcode.Text = "";

            lvwStoreDetails.Items.Clear();
            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var storeBillDetails =
                    conn.Query<StoreOutDetailViewModel>(
                        //"SELECT DetailID,BSB.StoreID,BSB.StoreCode,P.ProductID,P.ProductName,P.ProductSpec,BatchNo,StoreAmount AS Amount,CSSD.StructureID, SS.StructureCode FROM BUS_StoreBillDetail AS SBD INNER JOIN BUS_StoreBill AS BSB ON BSB.StoreID = SBD.StoreID LEFT JOIN BFI_Product AS P ON P.ProductID=SBD.ProductID LEFT JOIN dbo.WMS_CargoSpaceStoreDetail AS CSSD ON CSSD.ProductID=SBD.ProductID AND CSSD.ProductBatchNumber=SBD.BatchNo LEFT JOIN dbo.BFI_StorageStructure AS SS ON SS.StructureID=CSSD.StructureID WHERE SBD.StoreID=@StoreID AND ISNULL(SBD.Reservation1,'0')<>'3'",
                        "SELECT T.PDATaskID,T.BillDetailID,T.StoreID,T.ProductID,T.ProductName,P.ProductSpec,P.PackageSpec,T.BatchNo,T.Amount,T.StructureID,T.StructureCode FROM dbo.WMS_PDATask AS T INNER JOIN dbo.BUS_StoreBillDetail AS BD ON BD.DetailID=T.BillDetailID INNER JOIN dbo.BFI_Product AS P ON P.ProductID = T.ProductID WHERE T.StoreID=@StoreID AND ISNULL(T.TaskStatusID,0)<>3",
                        new { StoreID = storeId });
                conn.Close();
                foreach (var item in storeBillDetails)
                {
                    lvwStoreDetails.Items.Add(new ListViewItem(new string[]
                    {
                        item.PDATaskID.ToString(),
                        item.ProductName,
                        item.BatchNo,
                        item.PackageSpec,
                        item.ProductSpec,
                        item.Amount.HasValue ? item.Amount.Value.ToString() : string.Empty,
                        item.StructureCode
                    }));
                }
                muSaveStoreOut.Enabled = storeBillDetails.Any();
                if (storeBillDetails.Any())
                {
                    var detail = storeBillDetails.FirstOrDefault();
                    if (null != detail)
                    {
                        lvwStoreDetails.Tag = detail.PDATaskID;
                        lvwStoreDetails.Items[0].Selected = true;
                        lvwStoreDetails.Items[0].Focused = true;
                        LoadDetailInfo(detail.PDATaskID);
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
                    conn.Query<StoreOutDetailViewModel>(
                        "SELECT BillDetailID,T.StoreID,StoreCode,T.ProductID,T.ProductName,P.ProductSpec,P.PackageSpec,T.BatchNo,T.Amount,StructureID,StructureCode FROM WMS_PDATask AS T INNER JOIN dbo.BUS_StoreBill AS SB ON SB.StoreID = T.StoreID INNER JOIN dbo.BUS_StoreBillDetail AS BD ON BD.DetailID=T.BillDetailID INNER JOIN dbo.BFI_Product AS P ON P.ProductID = BD.ProductID WHERE T.PDATaskID=@PDATaskID",
                        new {PDATaskID = selectedDetailId});
                conn.Close();
                if (storeBillDetails.Any())
                {
                    //txtStoreCode.Tag = selectedDetailId;
                    var storeBillDetail = storeBillDetails.First();
                    //txtStoreCode.Text = storeBillDetail.StoreCode;
                    this.Text = storeBillDetail.StoreCode;
                    txtPackageSpec.Text = storeBillDetail.PackageSpec;
                    txtAmount.Text = storeBillDetail.Amount.HasValue ? storeBillDetail.Amount.Value.ToString() : "";
                    txtBatchNo.Text = storeBillDetail.BatchNo;
                    txtProductName.Text = storeBillDetail.ProductName;
                    txtSpec.Text = storeBillDetail.ProductSpec;
                    txtStructurecode.Text = storeBillDetail.StructureCode;
                }
            }
        }
    }
}