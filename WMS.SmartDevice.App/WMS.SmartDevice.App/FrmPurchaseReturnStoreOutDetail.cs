using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using WMS.SmartDevice.App.Models;
using WMS.SmartDevice.App.Utils;

namespace WMS.SmartDevice.App
{
    public partial class FrmPurchaseReturnStoreOutDetail : Form
    {
        public int StoreID { get; set; }

        public FrmPurchaseReturnStoreOutDetail()
        {
            InitializeComponent();
        }
        // Singleton design patern
        private static FrmPurchaseReturnStoreOutDetail _Instance = null;
        public static FrmPurchaseReturnStoreOutDetail Instance()
        {
            if (_Instance == null || _Instance.IsDisposed)
            {
                _Instance = new FrmPurchaseReturnStoreOutDetail();
            }
            _Instance.BringToFront();
            return _Instance;
        }

        private void muBack_Click(object sender, EventArgs e)
        {
            var doc = FrmPurchaseReturnStoreOut.Instance(StoreID);
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
            int billAmount = 0;
            if (!string.IsNullOrEmpty(txtAmount.Text))
            {
                billAmount = int.Parse(txtAmount.Text.Trim());
            }
            int amount = (int)txtStoreAmount.Value;

            if (selectedDetailId == 0)
            {
                MessageBox.Show("请选择要退货的药品！");
                return;
            }
            //if (!String.Equals(barcode, structureCode, StringComparison.CurrentCultureIgnoreCase))
            //{
            //    MessageBox.Show("出库货位不匹配，请重新输入或扫描出库货位！");
            //    return;
            //}
            //if (storeAmount > billAmount)
            //{
            //    MessageBox.Show("出库数量不能大于存放数量！");
            //    return;
            //}
            var dialogResult = MessageBox.Show("确定退货?", "系统确认框", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (dialogResult != DialogResult.Yes)
            {
                return;
            }

            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var structures =
                    conn.Query<StoreOutDetailViewModel>(
                        "SELECT SS.StructureID,ProductID,ProductBatchNumber AS BatchNo,ProductAmount AS Amount FROM dbo.WMS_CargoSpaceStoreDetail AS CSSD LEFT JOIN dbo.BFI_StorageStructure AS SS ON SS.StructureID = CSSD.StructureID WHERE SS.StructureCode=@StructureCode",
                        new { StructureCode = barcode });
                var structure = structures.FirstOrDefault();
                if (null == structure)
                {
                    MessageBox.Show("货位信息有误，请重新输入！");
                    return;
                }

                var storeBillDetails =
                    conn.Query<StoreOutDetailViewModel>(
                        "SELECT DetailID,BSB.StoreID,BSB.StoreCode,P.ProductID,P.ProductName,P.PackageSpec,P.ProductSpec,BatchNo,(SBD.Amount-ISNULL(SBD.StoreAmount,0)) AS Amount,CSSD.StructureID, SS.StructureCode FROM BUS_StoreBillDetail AS SBD INNER JOIN BUS_StoreBill AS BSB ON BSB.StoreID = SBD.StoreID LEFT JOIN BFI_Product AS P ON P.ProductID=SBD.ProductID LEFT JOIN dbo.WMS_CargoSpaceStoreDetail AS CSSD ON CSSD.ProductID=SBD.ProductID AND CSSD.ProductBatchNumber=SBD.BatchNo LEFT JOIN dbo.BFI_StorageStructure AS SS ON SS.StructureID=CSSD.StructureID WHERE SBD.DetailID=@DetailID AND ISNULL(SBD.Reservation1,'0')<>'3'",
                        new { DetailID = selectedDetailId });
                if (storeBillDetails.Any())
                {

                    var storeBillDetail = storeBillDetails.First();
                    SqlTransaction transaction = conn.BeginTransaction();
                    try
                    {

                        if (structure.ProductID != storeBillDetail.ProductID ||
                            structure.BatchNo != storeBillDetail.BatchNo)
                        {
                            MessageBox.Show("货位信息有误，请重新输入！");
                            return;
                        }

                        if (structure.Amount < amount)
                        {
                            MessageBox.Show("货位存放药品数量不足，请重新输入！");
                            return;
                        }
                        conn.Execute(
                            //更新库存数量
                            "UPDATE WMS_CargoSpaceStoreDetail SET ProductAmount=(ProductAmount-@ProductAmount) WHERE StructureID=@StructureID AND ProductID=@ProductID AND ProductBatchNumber=@ProductBatchNumber"
                            + "\nDELETE WMS_CargoSpaceStoreDetail WHERE ProductAmount<=0"
                            //更新入库明细表入库数量,状态
                            + "\nUPDATE BUS_StoreBillDetail SET StoreAmount=(StoreAmount-@ProductAmount), Reservation1=CASE WHEN (StoreAmount-@ProductAmount)=0 THEN '3' ELSE '1' END, Reservation2=CASE WHEN (StoreAmount-@ProductAmount)=0 THEN '完成出库' ELSE '正在出库' END WHERE DetailID=@DetailID",
                            //保存出库历史记录
                            //+ "\nINSERT INTO WMS_StoreOutHistory(StoreCode,StructureID,ProductID,ProductBatchNumber,ProductionDate,ProductValidDate,ProductAmount,Manufacturer,DosageForm,PackagingSpecification,StoreOutDate) VALUES(@StoreCode,@StructureID,@ProductID,@ProductBatchNumber,@ProductionDate,@ProductValidDate,@ProductAmount,@Manufacturer,@DosageForm,@PackagingSpecification,GETDATE())",
                            new
                            {
                                DetailID = storeBillDetail.DetailID,
                                StructureID = structure.StructureID,
                                ProductID = storeBillDetail.ProductID,
                                ProductBatchNumber = storeBillDetail.BatchNo,
                                ProductAmount = amount
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
                            "UPDATE BUS_StoreBill SET Reservation1='3', Reservation2='完成退货' WHERE StoreID=@StoreID",
                            new { StoreID = StoreID }, null);
                    }
                    else if (storeBillDetailStatuses.Any(p => p == "1"))
                    {
                        //正在出库

                        conn.Execute(
                            "UPDATE BUS_StoreBill SET Reservation1='1', Reservation2='正在退货' WHERE StoreID=@StoreID",
                            new { StoreID = StoreID }, null);
                    }
                    else if (storeBillDetailStatuses.Any(p => p == "2"))
                    {
                        //停止出库
                        conn.Execute(
                            "UPDATE BUS_StoreBill SET Reservation1='2', Reservation2='停止退货' WHERE StoreID=@StoreID",
                            new { StoreID = StoreID }, null);
                    }
                }
            }
            BindStoreOutDetailRecords(StoreID);
        }

        public void BindStoreOutDetailRecords(int storeId)
        {
            StoreID = storeId;

            txtPackageSpec.Text = "";
            txtSpec.Text = "";
            txtProductName.Text = "";
            txtBatchNo.Text = "";
            txtAmount.Text = "";
            txtBarcode.Text = "";
            txtStoreAmount.Text = "";

            lvwStoreDetails.Items.Clear();
            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var sql =
                    "UPDATE BUS_StoreBillDetail SET StoreAmount=Amount WHERE StoreID=@StoreID AND ISNULL(StoreAmount,0)=0 AND ISNULL(Reservation1,'0')<>'3'";
                conn.Execute(sql, new {StoreID = storeId}, null);

                var storeBillDetails =
                    conn.Query<StoreOutDetailViewModel>(
                        //"SELECT DetailID,BSB.StoreID,BSB.StoreCode,P.ProductID,P.ProductName,P.PackageSpec,P.ProductSpec,BatchNo,(SBD.Amount-ISNULL(SBD.StoreAmount,0)) AS Amount,CSSD.StructureID, SS.StructureCode FROM BUS_StoreBillDetail AS SBD INNER JOIN BUS_StoreBill AS BSB ON BSB.StoreID = SBD.StoreID LEFT JOIN BFI_Product AS P ON P.ProductID=SBD.ProductID LEFT JOIN dbo.WMS_CargoSpaceStoreDetail AS CSSD ON CSSD.ProductID=SBD.ProductID AND CSSD.ProductBatchNumber=SBD.BatchNo LEFT JOIN dbo.BFI_StorageStructure AS SS ON SS.StructureID=CSSD.StructureID WHERE SBD.StoreID=@StoreID AND ISNULL(SBD.Reservation1,'0')<>'3'",
                        "SELECT DetailID,BSB.StoreID,BSB.StoreCode,P.ProductID,P.ProductName,P.PackageSpec,P.ProductSpec,BatchNo,SBD.StoreAmount AS Amount FROM BUS_StoreBillDetail AS SBD INNER JOIN BUS_StoreBill AS BSB ON BSB.StoreID=SBD.StoreID LEFT JOIN BFI_Product AS P ON P.ProductID=SBD.ProductID WHERE SBD.StoreID=@StoreID AND ISNULL(SBD.Reservation1,'0')<>'3'",
                        new { StoreID = storeId });
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
                        item.Amount.HasValue ? item.Amount.Value.ToString() : string.Empty//,
                        //item.StructureCode
                    }));
                }
                muSaveStoreOut.Enabled = storeBillDetails.Any();
                if (storeBillDetails.Any())
                {
                    var detail = storeBillDetails.FirstOrDefault();
                    if (null != detail)
                    {
                        lvwStoreDetails.Tag = detail.DetailID;
                        lvwStoreDetails.Items[0].Selected = true;
                        lvwStoreDetails.Items[0].Focused = true;
                        LoadDetailInfo(detail.DetailID);
                    }
                }
                else
                {
                    var doc = FrmPurchaseReturnStoreOut.Instance(StoreID);
                    doc.BindStoreOutRecords();
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
                    conn.Query<StoreOutDetailViewModel>(
                        "SELECT BD.DetailID,BD.StoreID,SB.StoreCode,BD.ProductID,P.ProductName,P.ProductSpec,P.PackageSpec,BD.BatchNo,BD.StoreAmount AS Amount FROM dbo.BUS_StoreBillDetail AS BD INNER JOIN dbo.BUS_StoreBill AS SB ON SB.StoreID = BD.StoreID INNER JOIN dbo.BFI_Product AS P ON P.ProductID = BD.ProductID WHERE BD.DetailID=@DetailID",
                        new { DetailID = selectedDetailId });
                conn.Close();
                if (storeBillDetails.Any())
                {
                    var storeBillDetail = storeBillDetails.First();
                    this.Text = storeBillDetail.StoreCode;
                    txtPackageSpec.Text = storeBillDetail.PackageSpec;
                    txtAmount.Text = storeBillDetail.Amount.HasValue ? storeBillDetail.Amount.Value.ToString() : "";
                    txtStoreAmount.Maximum = storeBillDetail.Amount.Value;
                    txtStoreAmount.Value = storeBillDetail.Amount.Value;
                    txtBatchNo.Text = storeBillDetail.BatchNo;
                    txtProductName.Text = storeBillDetail.ProductName;
                    txtSpec.Text = storeBillDetail.ProductSpec;
                }
            }
        }
    }
}