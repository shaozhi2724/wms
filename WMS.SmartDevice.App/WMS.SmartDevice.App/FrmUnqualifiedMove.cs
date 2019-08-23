using System;
using System.Data.SqlClient;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using WMS.SmartDevice.App.Models;
using WMS.SmartDevice.App.Utils;

namespace WMS.SmartDevice.App
{
    public partial class FrmUnqualifiedMove : Form
    {
        private static int _unqualifiedID;

        private List<UnqualifiedMoveViewModel> _models = new List<UnqualifiedMoveViewModel>();

        public FrmUnqualifiedMove()
        {
            InitializeComponent();
        }

        public FrmUnqualifiedMove(int unqualifiedID)
            : this()
        {
            _unqualifiedID = unqualifiedID;
        }

        // Singleton design patern
        private static FrmUnqualifiedMove _Instance = null;
        public static FrmUnqualifiedMove Instance(int unqualifiedID)
        {
            if (_Instance == null || _Instance.IsDisposed)
            {
                _Instance = new FrmUnqualifiedMove(unqualifiedID);
            }
            _unqualifiedID = unqualifiedID;
            _Instance.BringToFront();
            return _Instance;
        }

        private void lvwStoreInBills_ItemActivate(object sender, EventArgs e)
        {
            if (lvwStoreInBills.SelectedIndices.Count > 0)
            {
                ListViewItem item = lvwStoreInBills.Items[lvwStoreInBills.SelectedIndices[0]];
//#if SY
//                //顺义PDA：第一列显示药品名称
//                var selectedUnqualifiedId = (int)item.Tag;
//#else
                //其他PDA：第一列显示入库单ID
                var selectedUnqualifiedId = int.Parse(item.SubItems[0].Text);
//#endif
                lvwStoreInBills.Tag = selectedUnqualifiedId;
                var selectedModel = _models.FirstOrDefault(p => p.UnqualifiedID == selectedUnqualifiedId);
                InitStoreInfo(selectedModel);
            }
        }

        private void muStoreIn_Click(object sender, EventArgs e)
        {
            if (null == lvwStoreInBills.Tag)
            {
                MessageBox.Show("请选择不合格品移库单！");
                return;
            }
            var selectedStoreID = (int)lvwStoreInBills.Tag;
            var frm = FrmUnqualifiedMoveDetail.Instance();
            frm.UnqualifiedID = selectedStoreID;
            frm.BindStoreInDetailRecords(selectedStoreID);
            frm.Show();
        }

        private void muBack_Click(object sender, EventArgs e)
        {
            FrmMain.Instance().Show();
            Close();
        }

        private void InitStoreInfo(UnqualifiedMoveViewModel model)
        {
            if (null == model)
            {
                return;
            }
            txtStoreCode.Text = model.UnqualifiedCode;
            txtStoreTypeName.Text = model.StoreTypeName;
            txtStatus.Text = model.UnqualifiedStatus;
            foreach (ListViewItem item in lvwStoreInBills.Items)
            {
                if (item.SubItems[0].Text == model.UnqualifiedID.ToString())
                {
                    item.Selected = true;
                    break;
                }
            }
        }
        public void BindStoreInRecords()
        {
            txtStoreCode.Text = "";
            txtStoreTypeName.Text = "";
            txtStatus.Text = "";
            lvwStoreInBills.Items.Clear();
            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                _models =
                    conn.Query<UnqualifiedMoveViewModel>("SELECT UnqualifiedID,UnqualifiedCode,'不合格品' AS StoreTypeName,UnqualifiedStatusID,UnqualifiedStatus FROM [dbo].[BUS_ProductUnqualified] WHERE UnqualifiedStatusID=2 OR UnqualifiedStatusID=3")
                        .ToList();

                conn.Close();
                foreach (var item in _models)
                {
                    lvwStoreInBills.Items.Add(new ListViewItem(new string[]
                    {
                        item.UnqualifiedID.ToString(),
                        item.UnqualifiedCode,
                        item.StoreTypeName,
                        item.UnqualifiedStatus

                    }));
                }
                muStoreIn.Enabled = _models.Any();
            }
            if (_unqualifiedID > 0)
            {
                var model = _models.FirstOrDefault(p => p.UnqualifiedID == _unqualifiedID);
                InitStoreInfo(model);
            }
            else
            {
                var model = _models.FirstOrDefault();
                if (null != model)
                {
                    _unqualifiedID = model.UnqualifiedID;

                    lvwStoreInBills.Tag = model.UnqualifiedID;
                    lvwStoreInBills.Items[0].Focused = true;
                    lvwStoreInBills.Items[0].Selected = true;
                    InitStoreInfo(model);
                }
            }
        }
    }
}