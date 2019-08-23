using System;
using System.Data.SqlClient;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using WMS.SmartDevice.App.Models;
using WMS.SmartDevice.App.Utils;

namespace WMS.SmartDevice.App
{
    public partial class FrmStoreOut : Form
    {
        private static int _storeId;
        List<StoreBillOutViewModel> _models = new List<StoreBillOutViewModel>();
        public FrmStoreOut()
        {
            InitializeComponent();
        }

        public FrmStoreOut(int storeId) : this()
        {
            _storeId = storeId;
        }

        // Singleton design patern
        private static FrmStoreOut _Instance = null;
        public static FrmStoreOut Instance(int storeId)
        {
            if (_Instance == null || _Instance.IsDisposed)
            {
                _Instance = new FrmStoreOut(storeId);
            }
            _storeId = storeId;
            
            _Instance.BringToFront();
            return _Instance;
        }
        private void muBack_Click(object sender, EventArgs e)
        {
            FrmMain.Instance().Show();
            Close();
        }

        public void BindStoreOutRecords()
        {
            txtStoreCode.Text = "";
            txtStoreTypeName.Text = "";
            txtDealerName.Text = "";
            txtReviewIdentity.Text = "";
            lvwStoreBills.Items.Clear();
            lvwStoreBills.Tag = _storeId;
            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                _models =
                    conn.Query<StoreBillOutViewModel>("SELECT DISTINCT SB.StoreID,SB.StoreCode,SB.StoreTypeName,SB.DealerName FROM BUS_StoreBill AS SB INNER JOIN dbo.WMS_PDATask AS T ON T.StoreID = SB.StoreID LEFT JOIN WMS_StoreOutReviewIdentity AS R ON R.StoreID=SB.StoreID WHERE SB.IsBillIn=0 AND ISNULL(SB.BillStyle,'正常')<>'直调' AND CAST(ISNULL(SB.Reservation1,'0') AS INT)<3 AND CAST(ISNULL(SB.Reservation1,'0') AS INT)>0 AND (R.OperationUsername IS NULL OR R.OperationUsername=@Username)", new { Username = Program.CurrentUser.Username })
                        .ToList();

                conn.Close();
                foreach (var item in _models)
                {
                    lvwStoreBills.Items.Add(new ListViewItem(new string[]
                    {
                        item.StoreCode,
                        item.StoreTypeName,
                        item.DealerName,
                        item.StoreID.ToString()

                    }));
                }
                muStoreOut.Enabled = _models.Any();
            }

            if (_storeId > 0)
            {
                var store = _models.FirstOrDefault(p => p.StoreID == _storeId);
                InitStoreInfo(store);
            }
            else
            {
                var store = _models.FirstOrDefault();
                if (null != store)
                {
                    _storeId = store.StoreID;

                    lvwStoreBills.Tag = store.StoreID;

                    lvwStoreBills.Items[0].Focused = true;
                    lvwStoreBills.Items[0].Selected = true;
                    InitStoreInfo(store);
                }
            }
        }

        private void InitStoreInfo(StoreBillOutViewModel store)
        {
            if (null == store)
            {
                return;
            }
            txtStoreCode.Text = store.StoreCode;
            txtStoreTypeName.Text = store.StoreTypeName;
            txtDealerName.Text = store.DealerName;
            foreach (ListViewItem item in lvwStoreBills.Items)
            {
                if (item.SubItems[3].Text == store.StoreID.ToString())
                {
                    item.Selected = true;
                    break;
                }
            }
        }

        private void muStoreOut_Click(object sender, EventArgs e)
        {
            var selectedStoreID = 0;
            if (null != lvwStoreBills.FocusedItem)
            {
                selectedStoreID = int.Parse(lvwStoreBills.FocusedItem.SubItems[3].Text);
            }
            if (selectedStoreID == 0)
            {
                selectedStoreID = (int)lvwStoreBills.Tag;
            }
            string identityCode = txtReviewIdentity.Text.Trim();
            string storeCode = txtStoreCode.Text.Trim();
            string pdaIdentity = DeviceHelper.GetDeviceId();
            string operationUsername = Program.CurrentUser.Username;
            string realName = Program.CurrentUser.Realname;
            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                string sql = @"IF NOT EXISTS(SELECT 1 FROM dbo.WMS_StoreOutReviewIdentity WHERE StoreID=@StoreID)
BEGIN
	INSERT INTO dbo.WMS_StoreOutReviewIdentity
	        (ReviewIdentityCode
	        ,StoreID
	        ,StoreCode
	        ,PDAIdentity
	        ,OperationUsername
	        ,OperationRealname
	        ,RelatedDate
	        ,IsReviewed
	        ,ReviewCode
	        ,ReviewDate
	        ,ReviewPerson
	        )
	VALUES  (@ReviewIdentityCode
	        ,@StoreID
	        ,@StoreCode
	        ,@PDAIdentity
	        ,@OperationUsername
	        ,@OperationRealname
	        ,GETDATE()
	        ,0
	        ,NULL
	        ,NULL
	        ,NULL
	        )
END";
                conn.Execute(sql, new
                {
                    ReviewIdentityCode = identityCode,
                    StoreID = selectedStoreID,
                    StoreCode = storeCode,
                    PDAIdentity = pdaIdentity,
                    OperationUsername = operationUsername,
                    OperationRealname = realName
                }, null);


                string sqlCheck = @"SELECT PDAIdentity FROM dbo.WMS_StoreOutReviewIdentity WHERE StoreID=@StoreID AND OperationUsername=@OperationUsername";

                var result = conn.Query<string>(sqlCheck, new { StoreID = selectedStoreID, OperationUsername = operationUsername });
                if (result.Count() == 0)
                {
                    MessageBox.Show("其他用户已出库此单，请选择其他出库单！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk,
                            MessageBoxDefaultButton.Button1);
                    BindStoreOutRecords();
                    return;
                }
            }
            var frm = FrmStoreOutDetail.Instance();
            frm.BindStoreOutDetailRecords(selectedStoreID);
            frm.Show();
            Close();
        }

        private void lvwStoreBills_ItemActivate(object sender, EventArgs e)
        {
            if (lvwStoreBills.SelectedIndices.Count > 0)
            {
                ListViewItem item = lvwStoreBills.Items[lvwStoreBills.SelectedIndices[0]];
                var selectedStoreId = int.Parse(item.SubItems[3].Text);
                var selectedStore = _models.FirstOrDefault(p => p.StoreID == selectedStoreId);
                InitStoreInfo(selectedStore);
            }
        }
    }
}