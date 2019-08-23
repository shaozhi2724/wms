using System;
using System.Data.SqlClient;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using WMS.SmartDevice.App.Models;
using WMS.SmartDevice.App.Utils;

namespace WMS.SmartDevice.App
{
    public partial class FrmUnqualifiedStoreIn : Form
    {
        private static int _storeId;

        private List<StoreBillInViewModel> _models = new List<StoreBillInViewModel>();

        public FrmUnqualifiedStoreIn()
        {
            InitializeComponent();
        }

        public FrmUnqualifiedStoreIn(int storeId)
            : this()
        {
            _storeId = storeId;
        }

        // Singleton design patern
        private static FrmUnqualifiedStoreIn _Instance = null;
        public static FrmUnqualifiedStoreIn Instance(int storeId)
        {
            if (_Instance == null || _Instance.IsDisposed)
            {
                _Instance = new FrmUnqualifiedStoreIn(storeId);
            }
            _storeId = storeId;
            _Instance.BringToFront();
            return _Instance;
        }

        private void lvwStoreInBills_ItemActivate(object sender, EventArgs e)
        {
            if (lvwStoreInBills.SelectedIndices.Count > 0)
            {
                ListViewItem item = lvwStoreInBills.Items[lvwStoreInBills.SelectedIndices[0]];
#if SY
                //顺义PDA：第一列显示药品名称
                var selectedStoreId = (int)item.Tag;
#else
                //其他PDA：第一列显示入库单ID
                var selectedStoreId = int.Parse(item.SubItems[0].Text);
#endif
                lvwStoreInBills.Tag = selectedStoreId;
                var selectedStore = _models.FirstOrDefault(p => p.StoreID == selectedStoreId);
                InitStoreInfo(selectedStore);
            }
        }

        private void muStoreIn_Click(object sender, EventArgs e)
        {
            if (null == lvwStoreInBills.Tag)
            {
                MessageBox.Show("请选择入库单！");
                return;
            }
            var selectedStoreID = (int)lvwStoreInBills.Tag;
            var frm = FrmUnqualifiedStoreInDetail.Instance();
            frm.BindStoreInDetailRecords(selectedStoreID);
            frm.Show();
        }

        private void muBack_Click(object sender, EventArgs e)
        {
            FrmMain.Instance().Show();
            Close();
        }

        private void InitStoreInfo(StoreBillInViewModel store)
        {
            if (null == store)
            {
                return;
            }
            txtStoreCode.Text = store.StoreCode;
            txtStoreTypeName.Text = store.StoreTypeName;
            txtDealerName.Text = store.DealerName;
            foreach (ListViewItem item in lvwStoreInBills.Items)
            {
                if (item.SubItems[0].Text == store.StoreID.ToString())
                {
                    item.Selected = true;
                    break;
                }
            }
        }

#if SY
        public void BindStoreInRecords()
        {
            txtStoreCode.Text = "";
            txtStoreTypeName.Text = "";
            txtDealerName.Text = "";
            lvwStoreInBills.Items.Clear();
            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                _models =
                    conn.Query<StoreBillInViewModel>("SELECT SB.StoreID,ISNULL(P.ProductName,'') AS ProductName,StoreCode,StoreTypeName,DealerName FROM BUS_StoreBill AS SB LEFT JOIN BUS_StoreBillDetail AS SBD ON SBD.StoreID = SB.StoreID LEFT JOIN dbo.BFI_Product AS P ON P.ProductID = SBD.ProductID WHERE IsBillIn=1 AND StoreTypeID=3 AND CAST(ISNULL(SB.Reservation1,'0') AS INT)<3")
                        .ToList();

                conn.Close();
                foreach (var item in _models)
                {
                    ListViewItem viewitem = new ListViewItem(new string[]
                    {
                        item.ProductName,
                        item.StoreCode,
                        item.StoreTypeName,
                        item.DealerName

                    });
                    viewitem.Tag = item.StoreID;
                    lvwStoreInBills.Items.Add(viewitem);
                }
                muStoreIn.Enabled = _models.Any();
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

                    lvwStoreInBills.Tag = store.StoreID;
                    lvwStoreInBills.Items[0].Focused = true;
                    lvwStoreInBills.Items[0].Selected = true;
                    InitStoreInfo(store);
                }
            }
        }
#else
        public void BindStoreInRecords()
        {
            txtStoreCode.Text = "";
            txtStoreTypeName.Text = "";
            txtDealerName.Text = "";
            lvwStoreInBills.Items.Clear();
            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                _models =
                    conn.Query<StoreBillInViewModel>("SELECT StoreID,StoreCode,StoreTypeName,DealerName FROM BUS_StoreBill WHERE IsBillIn=1 AND StoreTypeID=3 AND CAST(ISNULL(Reservation1,'0') AS INT)<3")
                        .ToList();

                conn.Close();
                foreach (var item in _models)
                {
                    lvwStoreInBills.Items.Add(new ListViewItem(new string[]
                    {
                        item.StoreID.ToString(),
                        item.StoreCode,
                        item.StoreTypeName,
                        item.DealerName

                    }));
                }
                muStoreIn.Enabled = _models.Any();
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

                    lvwStoreInBills.Tag = store.StoreID;
                    lvwStoreInBills.Items[0].Focused = true;
                    lvwStoreInBills.Items[0].Selected = true;
                    InitStoreInfo(store);
                }
            }
        }
#endif
    }
}