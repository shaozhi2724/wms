using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using WMS.WinCE.App.Models;
using WMS.WinCE.App.Utils;

namespace WMS.WinCE.App
{
    public partial class FrmPurchaseReturnStoreOut : Form
    {
        private static int _storeId;
        List<StoreBillOutViewModel> _models = new List<StoreBillOutViewModel>();
        public FrmPurchaseReturnStoreOut()
        {
            InitializeComponent();
        }

        public FrmPurchaseReturnStoreOut(int storeId)
            : this()
        {
            _storeId = storeId;
        }

        // Singleton design patern
        private static FrmPurchaseReturnStoreOut _Instance = null;
        public static FrmPurchaseReturnStoreOut Instance(int storeId)
        {
            if (_Instance == null || _Instance.IsDisposed)
            {
                _Instance = new FrmPurchaseReturnStoreOut(storeId);
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
            lvwStoreBills.Items.Clear();
            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                _models =
                    conn.Query<StoreBillOutViewModel>("SELECT StoreID,StoreCode,StoreTypeName,DealerName FROM BUS_StoreBill WHERE IsBillIn=0 AND ISNULL(BillStyle,'正常')<>'直调' AND StoreTypeName='采购退货' AND CAST(ISNULL(Reservation1,'0') AS INT)<3")
                        .ToList();

                conn.Close();
                foreach (var item in _models)
                {
                    lvwStoreBills.Items.Add(new ListViewItem(new string[]
                    {
                        item.StoreID.ToString(),
                        item.StoreCode,
                        item.StoreTypeName,
                        item.DealerName

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
                if (item.SubItems[0].Text == store.StoreID.ToString())
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
                selectedStoreID = int.Parse(lvwStoreBills.FocusedItem.SubItems[0].Text);
            }
            if (selectedStoreID == 0)
            {
                if (null != lvwStoreBills.Tag)
                {
                    selectedStoreID = (int)lvwStoreBills.Tag;
                }
            }

            var frm = FrmPurchaseReturnStoreOutDetail.Instance();
            frm.BindStoreOutDetailRecords(selectedStoreID);
            frm.Show();
            Close();
        }

        private void lvwStoreBills_ItemActivate(object sender, EventArgs e)
        {
            if (lvwStoreBills.SelectedIndices.Count > 0)
            {
                ListViewItem item = lvwStoreBills.Items[lvwStoreBills.SelectedIndices[0]];
                var selectedStoreId = int.Parse(item.SubItems[0].Text);
                var selectedStore = _models.FirstOrDefault(p => p.StoreID == selectedStoreId);
                InitStoreInfo(selectedStore);
            }
        }
    }
}