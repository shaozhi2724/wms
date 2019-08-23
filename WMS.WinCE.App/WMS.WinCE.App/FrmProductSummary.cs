using System;
using System.Data.SqlClient;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using WMS.WinCE.App.Models;
using WMS.WinCE.App.Utils;

namespace WMS.WinCE.App
{
    public partial class FrmProductSummary : Form
    {
        private static int _inventoryStatisticId;
        List<InventoryStatisticViewModel> _models = new List<InventoryStatisticViewModel>();
        public FrmProductSummary()
        {
            InitializeComponent();
        }

        // Singleton design patern
        private static FrmProductSummary _Instance = null;
        public static FrmProductSummary Instance()
        {
            if (_Instance == null || _Instance.IsDisposed)
            {
                _Instance = new FrmProductSummary();
            }
            _Instance.BringToFront();
            return _Instance;
        }
        private void muBack_Click(object sender, EventArgs e)
        {
            FrmMain.Instance().Show();
            Close();
        }

        public void BindInventoryStatisticRecords()
        {
            txtInventoryStatisticCode.Text = "";
            txtStartDate.Text = "";
            txtEndDate.Text = "";
            lvwTask.Items.Clear();
            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                _models =
                    conn.Query<InventoryStatisticViewModel>("SELECT InventoryStatisticID,InventoryStatisticCode,StartDate,EndDate FROM [dbo].[WMS_InventoryStatistic] WHERE StatusName='等待盘点' OR  StatusName='正在盘点'")
                        .ToList();

                conn.Close();
                foreach (var item in _models)
                {
                    lvwTask.Items.Add(new ListViewItem(new string[]
                    {
                        item.InventoryStatisticID.ToString(),
                        item.InventoryStatisticCode,
                        item.StartDate.ToString("yyyy-MM-dd"),
                        item.EndDate.ToString("yyyy-MM-dd")

                    }));
                }
                muStartTask.Enabled = _models.Any();
            }

            if (_inventoryStatisticId > 0)
            {
                var inventoryStatistic = _models.FirstOrDefault(p => p.InventoryStatisticID == _inventoryStatisticId);
                InitTaskInfo(inventoryStatistic);
            }
            else
            {
                var inventoryStatistic = _models.FirstOrDefault();
                if (null != inventoryStatistic)
                {
                    _inventoryStatisticId = inventoryStatistic.InventoryStatisticID;

                    lvwTask.Tag = inventoryStatistic.InventoryStatisticID;

                    lvwTask.Items[0].Focused = true;
                    lvwTask.Items[0].Selected = true;
                    InitTaskInfo(inventoryStatistic);
                }
            }
        }

        private void InitTaskInfo(InventoryStatisticViewModel inventoryStatistic)
        {
            if (null == inventoryStatistic)
            {
                return;
            }
            txtInventoryStatisticCode.Text = inventoryStatistic.InventoryStatisticCode;
            txtStartDate.Text = inventoryStatistic.StartDate.ToString("yyyy-MM-dd");
            txtEndDate.Text = inventoryStatistic.EndDate.ToString("yyyy-MM-dd");
            foreach (ListViewItem item in lvwTask.Items)
            {
                if (item.SubItems[0].Text == inventoryStatistic.InventoryStatisticID.ToString())
                {
                    item.Selected = true;
                    break;
                }
            }
        }

        private void lvwTask_ItemActivate(object sender, EventArgs e)
        {
            if (lvwTask.SelectedIndices.Count > 0)
            {
                ListViewItem item = lvwTask.Items[lvwTask.SelectedIndices[0]];
                var selectedTaskID = int.Parse(item.SubItems[0].Text);
                var selectedTask = _models.FirstOrDefault(p => p.InventoryStatisticID == selectedTaskID);
                InitTaskInfo(selectedTask);
            }
        }

        private void muStartTask_Click(object sender, EventArgs e)
        {
            var selectedTaskID = 0;
            if (null != lvwTask.FocusedItem)
            {
                selectedTaskID = int.Parse(lvwTask.FocusedItem.SubItems[0].Text);
            }
            if (selectedTaskID == 0)
            {
                if (null != lvwTask.Tag)
                {
                    selectedTaskID = (int)lvwTask.Tag;
                }
            }

            var frm = FrmProductSummaryDetail.Instance(selectedTaskID);
            frm.Show();
            Close();
        }
    }

    public class InventoryStatisticViewModel
    {
        public int InventoryStatisticID { get; set; }
        public string InventoryStatisticCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}