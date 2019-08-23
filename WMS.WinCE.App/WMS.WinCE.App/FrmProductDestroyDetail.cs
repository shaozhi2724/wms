using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using WMS.WinCE.App.Models;
using WMS.WinCE.App.Utils;

namespace WMS.WinCE.App
{
    public partial class FrmProductDestroyDetail : Form
    {
        public int DestroyID { get; set; }

        public FrmProductDestroyDetail()
        {
            InitializeComponent();
        }
        // Singleton design patern
        private static FrmProductDestroyDetail _Instance = null;
        public static FrmProductDestroyDetail Instance()
        {
            if (_Instance == null || _Instance.IsDisposed)
            {
                _Instance = new FrmProductDestroyDetail();
            }
            _Instance.BringToFront();
            return _Instance;
        }

        private void muBack_Click(object sender, EventArgs e)
        {
            var doc = FrmProductDestroy.Instance(DestroyID);
            doc.BindDestroyRecords();
            doc.Show();
            Close();
        }

        private void muDestroy_Click(object sender, EventArgs e)
        {
            //取值必须在模态窗口弹出前，否则取不到值
            int selectedDetailId = 0;
            if (null != lvwDestroyDetails.FocusedItem)
            {
                selectedDetailId = int.Parse(lvwDestroyDetails.FocusedItem.SubItems[0].Text);
            }
            if (selectedDetailId == 0)
            {
                selectedDetailId = (int)lvwDestroyDetails.Tag;
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
                MessageBox.Show("请选择要销毁的药品！");
                return;
            }
            //if (storeAmount > billAmount)
            //{
            //    MessageBox.Show("销毁数量不能大于存放数量！");
            //    return;
            //}
            var dialogResult = MessageBox.Show("确定销毁?", "系统确认框", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (dialogResult != DialogResult.Yes)
            {
                return;
            }

            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var structures =
                    conn.Query<DestroyDetailViewModel>(
                        "SELECT SS.StructureID,ProductID,ProductBatchNumber AS BatchNo,ProductAmount AS Amount FROM dbo.WMS_CargoSpaceStoreDetail AS CSSD LEFT JOIN dbo.BFI_StorageStructure AS SS ON SS.StructureID = CSSD.StructureID WHERE SS.AreaType='不合格品' AND SS.StructureCode=@StructureCode",
                        new { StructureCode = barcode });
                var structure = structures.FirstOrDefault();
                if (null == structure)
                {
                    MessageBox.Show("货位信息有误，请重新输入！");
                    return;
                }

                var destroyDetails =
                    conn.Query<DestroyDetailViewModel>(
                        "SELECT DetailID,PDD.DestroyID,PD.DestroyCode,P.ProductID,P.ProductName,P.PackageSpec,P.ProductSpec,BatchNo,(PDD.Amount-ISNULL(PDD.Reservation1,0)) AS Amount,CSSD.StructureID, SS.StructureCode FROM BUS_ProdcutDestroyDetail AS PDD INNER JOIN BUS_ProdcutDestroy AS PD ON PD.DestroyID = PDD.DestroyID LEFT JOIN BFI_Product AS P ON P.ProductID=PDD.ProductID LEFT JOIN dbo.WMS_CargoSpaceStoreDetail AS CSSD ON CSSD.ProductID=PDD.ProductID AND CSSD.ProductBatchNumber=PDD.BatchNo LEFT JOIN dbo.BFI_StorageStructure AS SS ON SS.StructureID=CSSD.StructureID WHERE SS.AreaType='不合格品' AND PDD.DetailID=@DetailID AND ISNULL(PDD.Reservation2,'0')<>'3'",
                        new { DetailID = selectedDetailId });
                if (destroyDetails.Any())
                {

                    var destroyDetail = destroyDetails.First();
                    SqlTransaction transaction = conn.BeginTransaction();
                    try
                    {

                        if (structure.ProductID != destroyDetail.ProductID ||
                            structure.BatchNo != destroyDetail.BatchNo)
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
                            + "\nUPDATE BUS_ProdcutDestroyDetail SET Reservation1=(CAST(ISNULL(Reservation1, 0) AS INT)+@ProductAmount), Reservation2=CASE WHEN (CAST(ISNULL(Reservation1, 0) AS INT)+@ProductAmount)=Amount THEN '3' ELSE '1' END, Reservation3=CASE WHEN (CAST(ISNULL(Reservation1, 0) AS INT)+@ProductAmount)=Amount THEN '已销毁' ELSE '正在销毁' END WHERE DetailID=@DetailID",
                            //保存出库历史记录
                            //+ "\nINSERT INTO WMS_StoreOutHistory(StoreCode,StructureID,ProductID,ProductBatchNumber,ProductionDate,ProductValidDate,ProductAmount,Manufacturer,DosageForm,PackagingSpecification,StoreOutDate) VALUES(@StoreCode,@StructureID,@ProductID,@ProductBatchNumber,@ProductionDate,@ProductValidDate,@ProductAmount,@Manufacturer,@DosageForm,@PackagingSpecification,GETDATE())",
                            new
                            {
                                DetailID = destroyDetail.DetailID,
                                StructureID = structure.StructureID,
                                ProductID = destroyDetail.ProductID,
                                ProductBatchNumber = destroyDetail.BatchNo,
                                ProductAmount = amount
                            }, transaction);
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        MessageBox.Show("药品销毁失败！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk,
                            MessageBoxDefaultButton.Button1);
                        return;
                    }
                    string destroyDetailStatusSql = "SELECT DISTINCT(ISNULL(Reservation2,'1')) AS DetailCount FROM dbo.BUS_ProdcutDestroyDetail WHERE DestroyID=@DestroyID";
                    var destroyDetailStatuses = conn.Query<string>(destroyDetailStatusSql, new { DestroyID = DestroyID });
                    if (destroyDetailStatuses.All(p => p == "3"))
                    {
                        //销毁单完成
                        conn.Execute(
                            "UPDATE BUS_ProdcutDestroy SET DestroyStatusID=4, DestroyStatus='已销毁' WHERE DestroyID=@DestroyID",
                            new { DestroyID = DestroyID }, null);
                    }
                    else
                    {
                        //正在销毁

                        conn.Execute(
                            "UPDATE BUS_ProdcutDestroy SET DestroyStatusID='3', DestroyStatus='正在销毁' WHERE DestroyID=@DestroyID",
                            new { DestroyID = DestroyID }, null);
                    }
                }
            }
            BindDestroyDetailRecords(DestroyID);
        }

        public void BindDestroyDetailRecords(int destroyId)
        {
            DestroyID = destroyId;

            txtPackageSpec.Text = "";
            txtSpec.Text = "";
            txtProductName.Text = "";
            txtBatchNo.Text = "";
            txtAmount.Text = "";
            txtBarcode.Text = "";
            txtStoreAmount.Text = "";

            lvwDestroyDetails.Items.Clear();
            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var sql =
                    "UPDATE BUS_ProdcutDestroyDetail SET Reservation1=0 WHERE DestroyID=@DestroyID AND ISNULL(Reservation1,0)=0 AND ISNULL(Reservation2,'0')<>'3'";
                conn.Execute(sql, new { DestroyID = destroyId }, null);

                var destroyDetails =
                    conn.Query<DestroyDetailViewModel>(
                        "SELECT DetailID,PD.DestroyID,PD.DestroyCode,P.ProductID,P.ProductName,P.PackageSpec,P.ProductSpec,BatchNo,(Amount-CAST(ISNULL(PDD.Reservation1, 0) AS INT)) AS Amount FROM dbo.BUS_ProdcutDestroyDetail AS PDD INNER JOIN dbo.BUS_ProdcutDestroy AS PD ON PD.DestroyID=PDD.DestroyID LEFT JOIN BFI_Product AS P ON P.ProductID=PDD.ProductID WHERE PDD.DestroyID=@DestroyID AND ISNULL(PDD.Reservation2,'0')<>'3'",
                        new { DestroyID = destroyId });
                conn.Close();
                foreach (var item in destroyDetails)
                {
                    lvwDestroyDetails.Items.Add(new ListViewItem(new string[]
                    {
                        item.DetailID.ToString(),
                        item.ProductName,
                        item.BatchNo,
                        item.PackageSpec,
                        item.ProductSpec,
                        item.Amount.HasValue ? item.Amount.Value.ToString() : string.Empty
                    }));
                }
                muDestroy.Enabled = destroyDetails.Any();
                if (destroyDetails.Any())
                {
                    var detail = destroyDetails.FirstOrDefault();
                    if (null != detail)
                    {
                        lvwDestroyDetails.Tag = detail.DetailID;
                        lvwDestroyDetails.Items[0].Selected = true;
                        lvwDestroyDetails.Items[0].Focused = true;
                        LoadDetailInfo(detail.DetailID);
                    }
                }
                else
                {
                    var doc = FrmProductDestroy.Instance(DestroyID);
                    doc.BindDestroyRecords();
                    doc.Show();
                    Close();
                }
            }
        }

        private void lvwDestroyDetails_ItemActivate(object sender, EventArgs e)
        {
            if (lvwDestroyDetails.SelectedIndices.Count > 0)
            {
                ListViewItem item = lvwDestroyDetails.Items[lvwDestroyDetails.SelectedIndices[0]];
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
                    conn.Query<DestroyDetailViewModel>(
                        "SELECT PDD.DetailID,PDD.DestroyID,PD.DestroyCode,PDD.ProductID,P.ProductName,P.ProductSpec,P.PackageSpec,PDD.BatchNo,(Amount-CAST(ISNULL(PDD.Reservation1, 0) AS INT)) AS Amount FROM dbo.BUS_ProdcutDestroyDetail AS PDD INNER JOIN dbo.BUS_ProdcutDestroy AS PD ON PD.DestroyID = PDD.DestroyID INNER JOIN dbo.BFI_Product AS P ON P.ProductID = PDD.ProductID WHERE PDD.DetailID=@DetailID",
                        new { DetailID = selectedDetailId });
                conn.Close();
                if (storeBillDetails.Any())
                {
                    var storeBillDetail = storeBillDetails.First();
                    this.Text = storeBillDetail.DestroyCode;
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