using System;
using System.Data.SqlClient;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using WMS.SmartDevice.App.Models;
using WMS.SmartDevice.App.Utils;

namespace WMS.SmartDevice.App
{
    public partial class FrmProductDestroy : Form
    {
        private static int _destroyId;
        List<ProductDestroyViewModel> _models = new List<ProductDestroyViewModel>();
        public FrmProductDestroy()
        {
            InitializeComponent();
        }

        public FrmProductDestroy(int destroyId)
            : this()
        {
            _destroyId = destroyId;
        }

        // Singleton design patern
        private static FrmProductDestroy _Instance = null;
        public static FrmProductDestroy Instance(int destroyId)
        {
            if (_Instance == null || _Instance.IsDisposed)
            {
                _Instance = new FrmProductDestroy(destroyId);
            }
            _destroyId = destroyId;
            _Instance.BringToFront();
            return _Instance;
        }
        private void muBack_Click(object sender, EventArgs e)
        {
            FrmMain.Instance().Show();
            Close();
        }

        public void BindDestroyRecords()
        {
            txtDestroyCode.Text = "";
            txtDestroyCause.Text = "";
            txtDestroyDate.Text = "";
            lvwDestroyBills.Items.Clear();
            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                _models =
                    conn.Query<ProductDestroyViewModel>("SELECT DestroyID,DestroyCode,DestroyCause,DestroyProcedure,DestroyResult,DestroyDate,UnqualifiedID,UnqualifiedCode,Transactor,TransactorSpell,DestroyStatusID,DestroyStatus FROM BUS_ProdcutDestroy WHERE ISNULL(DestroyStatus,'等待销毁')='已审核' OR ISNULL(DestroyStatus,'等待销毁')='等待销毁'")
                        .ToList();

                conn.Close();
                foreach (var item in _models)
                {
                    lvwDestroyBills.Items.Add(new ListViewItem(new string[]
                    {
                        item.DestroyID.ToString(),
                        item.DestroyCode,
                        item.DestroyCause,
                        item.DestroyDate.ToString("yyyy-MM-dd")

                    }));
                }
                muDestroy.Enabled = _models.Any();
            }

            if (_destroyId > 0)
            {
                var destroy = _models.FirstOrDefault(p => p.DestroyID == _destroyId);
                InitDestroyInfo(destroy);
            }
            else
            {
                var destroy = _models.FirstOrDefault();
                if (null != destroy)
                {
                    _destroyId = destroy.DestroyID;

                    lvwDestroyBills.Tag = destroy.DestroyID;

                    lvwDestroyBills.Items[0].Focused = true;
                    lvwDestroyBills.Items[0].Selected = true;
                    InitDestroyInfo(destroy);
                }
            }
        }

        private void InitDestroyInfo(ProductDestroyViewModel destroy)
        {
            if (null == destroy)
            {
                return;
            }
            txtDestroyCode.Text = destroy.DestroyCode;
            txtDestroyCause.Text = destroy.DestroyCause;
            txtDestroyDate.Text = destroy.DestroyDate.ToString("yyyy-MM-dd");
            foreach (ListViewItem item in lvwDestroyBills.Items)
            {
                if (item.SubItems[0].Text == destroy.DestroyID.ToString())
                {
                    item.Selected = true;
                    break;
                }
            }
        }

        private void muDestroy_Click(object sender, EventArgs e)
        {
            var selectedDestroyID = 0;
            if (null != lvwDestroyBills.FocusedItem)
            {
                selectedDestroyID = int.Parse(lvwDestroyBills.FocusedItem.SubItems[0].Text);
            }
            if (selectedDestroyID == 0)
            {
                if (null != lvwDestroyBills.Tag)
                {
                    selectedDestroyID = (int)lvwDestroyBills.Tag;
                }
            }

            var frm = FrmProductDestroyDetail.Instance();
            frm.BindDestroyDetailRecords(selectedDestroyID);
            frm.Show();
            Close();
        }

        private void lvwStoreBills_ItemActivate(object sender, EventArgs e)
        {
            if (lvwDestroyBills.SelectedIndices.Count > 0)
            {
                ListViewItem item = lvwDestroyBills.Items[lvwDestroyBills.SelectedIndices[0]];
                var selectedDestroyID = int.Parse(item.SubItems[0].Text);
                var selectedDestroy = _models.FirstOrDefault(p => p.DestroyID == selectedDestroyID);
                InitDestroyInfo(selectedDestroy);
            }
        }
    }
}