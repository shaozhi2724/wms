using System;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;
using Stimulsoft.Report;
using WMS.Windows.App.Properties;

namespace WMS.Windows.App
{
    public partial class FrmMain : Office2007RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;
            MessageBoxEx.UseSystemLocalizedString = true;
            this.WindowState = FormWindowState.Maximized;

            btnSysConfig.Visible = Program.CurrentUser.Username == "系统管理员";
            switch (Program.CurrentUser.Rolename)
            {
                case "系统管理员":
                    if (Program.CurrentComputerAllowMonitoring())
                    {
                        tabStoreMonitoring.Select();
                    }
                    else
                    {
                        //tabStoreMonitoring.Visible = false;
                        rbarMonitoring.Visible = false;
                    }
                    break;
                case "仓库管理员":
                    tabStoreMonitoring.Visible = true;
                    tabSysSettings.Visible = true;
                    tabOperating.Visible = true;
                    tabInventory.Visible = true;

                    tabRegulatoryCode.Visible = false;
                    tabReview.Visible = false;

                    btnSysConfig.Visible = false;

                    if(Program.CurrentComputerAllowMonitoring())
                    {
                        tabStoreMonitoring.Select();
                    }
                    else
                    {
                        //tabStoreMonitoring.Visible = false;

                        rbarMonitoring.Visible = false;
                    }
                    break;
                case "复核员":
                    tabSysSettings.Visible = true;
                    tabRegulatoryCode.Visible = true;
                    tabReview.Visible = true;

                    tabStoreMonitoring.Visible = false;
                    tabOperating.Visible = false;
                    tabInventory.Visible = false;
                    tabUserManagement.Visible = false;

                    btnSysConfig.Visible = false;
                    tabReview.Select();
                    break;
            }
            Application.DoEvents();
        }

        private static FrmMain _Instance = null;
        public static FrmMain Instance()
        {
            if (_Instance == null || _Instance.IsDisposed)
            {
                _Instance = new FrmMain();
            }
            _Instance.BringToFront();
            return _Instance;
        }

        private void btnStoreInMonitoring_Click(object sender, EventArgs e)
        {
            if (Program.CurrentComputerAllowMonitoring())
            {
                string tabName = "入库监控";

                if (!IsOpenTab(tabName))
                {

                    FrmStoreInMonitoring doc = new FrmStoreInMonitoring();
                    doc.MdiParent = this;
                    doc.WindowState = FormWindowState.Maximized;
                    doc.Dock = DockStyle.Fill;
                    doc.Show();
                    doc.Update();
                }
            }
            else
            {
                MessageBoxEx.Show(this, "出入库监控机器标识未设置，或本机标识与系统设置不匹配，请联系管理员", "系统警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        /// <summary>
        /// 防止打开多个同样的子窗体,检查是否已打开某个子窗体,如果打开了就返回true,否则返回false
        /// </summary>
        /// <param name="tabName">子窗体的窗体名称</param>
        /// <returns></returns>
        private bool IsOpenTab(string tabName)
        {
            Settings.Default.Reload();
            bool isOpened = false;

            foreach (TabItem tab in tabStrip.Tabs)
            {
                if (tab.Text.Trim() == tabName)
                {
                    isOpened = true;
                    tabStrip.SelectedTab = tab;
                    break;
                }
            }

            return isOpened;
        }

        private void btnStoreOutMonitoring_Click(object sender, EventArgs e)
        {
            if (Program.CurrentComputerAllowMonitoring())
            {
                string tabName = "出库监控";
                if (!IsOpenTab(tabName))
                {

                    FrmStoreOutMonitoring doc = new FrmStoreOutMonitoring();
                    doc.MdiParent = this;
                    doc.WindowState = FormWindowState.Maximized;
                    doc.Dock = DockStyle.Fill;
                    doc.Show();
                    doc.Update();
                }
            }
            else
            {
                MessageBoxEx.Show(this, "出入库监控机器标识未设置，或本机标识与系统设置不匹配，请联系管理员", "系统警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Text += "  ("+Program.CurrentUser.Realname + ")";
            if (!CheckDbConnection())
            {
                FrmDBConnection dbConnection = new FrmDBConnection();
                dbConnection.ShowDialog(this);
            }
            else
            {
                switch (Program.CurrentUser.Rolename)
                {
                    case "系统管理员":
                    case "仓库管理员":
                        if (Program.CurrentComputerAllowMonitoring())
                        {
                            btnStoreInMonitoring_Click(null, null);
                        }
                        break;
                    case "复核员":
                        btnReview_Click(null, null);
                        break;
                }
            }

        }

        private bool CheckDbConnection()
        {
            try
            {
                return !string.IsNullOrWhiteSpace(DBManager.GetEFConnectionString());
            }
            catch (Exception ex)
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show(this, ex.Message);
            }
            return false;
        }

        private void btnLabelManagement_Click(object sender, EventArgs e)
        {
            string tabName = "标签管理";
            if (!IsOpenTab(tabName))
            {

                FrmLabelManagement doc = new FrmLabelManagement();
                doc.MdiParent = this;
                doc.WindowState = FormWindowState.Maximized;
                doc.Dock = DockStyle.Fill;
                doc.Show();
                doc.Update();
            }
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            string tabName = "仓库信息";
            if (!IsOpenTab(tabName))
            {

                FrmWarehouse doc = new FrmWarehouse();
                doc.MdiParent = this;
                doc.WindowState = FormWindowState.Maximized;
                doc.Dock = DockStyle.Fill;
                doc.Show();
                doc.Update();
            }
        }

        private void btnWarehouseUnit_Click(object sender, EventArgs e)
        {
            string tabName = "存储单元";
            if (!IsOpenTab(tabName))
            {

                FrmWarehouseUnit doc = new FrmWarehouseUnit();
                doc.MdiParent = this;
                doc.WindowState = FormWindowState.Maximized;
                doc.Dock = DockStyle.Fill;
                doc.Show();
                doc.Update();
            }
        }

        private void btnDrugManagement_Click(object sender, EventArgs e)
        {
            string tabName = "药品管理";
            if (!IsOpenTab(tabName))
            {

                FrmDrugs doc = new FrmDrugs();
                doc.MdiParent = this;
                doc.WindowState = FormWindowState.Maximized;
                doc.Dock = DockStyle.Fill;
                doc.Show();
                doc.Update();
            }
        }

        private void btnLabelRelationship_Click(object sender, EventArgs e)
        {
            string tabName = "货标关联";
            if (!IsOpenTab(tabName))
            {

                FrmLabelRelationship doc = new FrmLabelRelationship();
                doc.MdiParent = this;
                doc.WindowState = FormWindowState.Maximized;
                doc.Dock = DockStyle.Fill;
                doc.Show();
                doc.Update();
            }
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            string tabName = "出库复核";
            if (!IsOpenTab(tabName))
            {
                FrmStoreOutReview doc = new FrmStoreOutReview();
                doc.MdiParent = this;
                doc.WindowState = FormWindowState.Maximized;
                doc.Dock = DockStyle.Fill;
                doc.Show();
                doc.Update();
            }
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void btnDBConfig_Click(object sender, EventArgs e)
        {
            FrmDBConnection dbConnection = new FrmDBConnection();
            dbConnection.ShowDialog(this);
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitApplication(e);
        }

        private static void ExitApplication(FormClosingEventArgs e = null)
        {
            MessageBoxEx.EnableGlass = false;
            if (DialogResult.Yes ==
                MessageBoxEx.Show("确认退出系统？", "系统确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (null != e)
                {
                    e.Cancel = false;
                }
                Application.ExitThread();
            }
            else
            {
                if (null != e)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnCorpCode_Click(object sender, EventArgs e)
        {
            FrmCorpCodeSetting doc = new FrmCorpCodeSetting();
            doc.ShowDialog(this);
        }

        private void btnImportCode_Click(object sender, EventArgs e)
        {
            string tabName = "导入监管码";
            if (!IsOpenTab(tabName))
            {
                FrmImportCode doc = new FrmImportCode();
                doc.MdiParent = this;
                doc.WindowState = FormWindowState.Maximized;
                doc.Dock = DockStyle.Fill;
                doc.Show();
                doc.Update();
            }
        }

        private void btnExportTickets_Click(object sender, EventArgs e)
        {
            //string tabName = "导出单据";
            //if (!IsOpenTab(tabName))
            //{
            //    FrmExportTickets doc = new FrmExportTickets();
            //    doc.MdiParent = this;
            //    doc.WindowState = FormWindowState.Maximized;
            //    doc.Dock = DockStyle.Fill;
            //    doc.Show();
            //    doc.Update();
            //}
            FrmExportTickets doc = new FrmExportTickets();
            doc.ShowDialog(this);
        }

        private void btnStoreInHistory_Click(object sender, EventArgs e)
        {
            string tabName = "入库历史查询";
            if (!IsOpenTab(tabName))
            {
                FrmStoreInHistory doc = new FrmStoreInHistory();
                doc.MdiParent = this;
                doc.WindowState = FormWindowState.Maximized;
                doc.Dock = DockStyle.Fill;
                doc.Show();
                doc.Update();
            }
        }

        private void btnStoreOutHistory_Click(object sender, EventArgs e)
        {
            string tabName = "出库历史查询";
            if (!IsOpenTab(tabName))
            {
                FrmStoreOutHistory doc = new FrmStoreOutHistory();
                doc.MdiParent = this;
                doc.WindowState = FormWindowState.Maximized;
                doc.Dock = DockStyle.Fill;
                doc.Show();
                doc.Update();
            }
        }

        private void btnReviewHistory_Click(object sender, EventArgs e)
        {
            string tabName = "复核历史查询";
            if (!IsOpenTab(tabName))
            {
                FrmReviewHistory doc = new FrmReviewHistory();
                doc.MdiParent = this;
                doc.WindowState = FormWindowState.Maximized;
                doc.Dock = DockStyle.Fill;
                doc.Show();
                doc.Update();
            }
        }

        private void btnStoreQuery_Click(object sender, EventArgs e)
        {
            string tabName = "在库药品查询";
            if (!IsOpenTab(tabName))
            {
                FrmStoreQuery doc = new FrmStoreQuery();
                doc.MdiParent = this;
                doc.WindowState = FormWindowState.Maximized;
                doc.Dock = DockStyle.Fill;
                doc.Show();
                doc.Update();
            }
        }

        private void btnBatchNoEdit_Click(object sender, EventArgs e)
        {
            string tabName = "库存管理";
            if (!IsOpenTab(tabName))
            {
                FrmBatchNoEdit doc = new FrmBatchNoEdit();
                doc.MdiParent = this;
                doc.WindowState = FormWindowState.Maximized;
                doc.Dock = DockStyle.Fill;
                doc.Show();
                doc.Update();
            }
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            string tabName = "用户管理";
            if (!IsOpenTab(tabName))
            {
                FrmUserManagement doc = new FrmUserManagement();
                doc.MdiParent = this;
                doc.WindowState = FormWindowState.Maximized;
                doc.Dock = DockStyle.Fill;
                doc.Show();
                doc.Update();
            }
        }

        private void btnInventoryStatistic_Click(object sender, EventArgs e)
        {
            ShowInventoryStatisticForm();
        }

        public void ShowInventoryStatisticForm()
        {
            string tabName = "库存盘点";
            if (!IsOpenTab(tabName))
            {
                FrmInventoryStatistic doc = new FrmInventoryStatistic();
                doc.MdiParent = this;
                doc.WindowState = FormWindowState.Maximized;
                doc.Dock = DockStyle.Fill;
                doc.Show();
                doc.Update();
            }
        }

        private void btnCargoDetail_Click(object sender, EventArgs e)
        {
            string tabName = "货位详情";
            if (!IsOpenTab(tabName))
            {
                FrmInventoryState doc = new FrmInventoryState();
                doc.MdiParent = this;
                doc.WindowState = FormWindowState.Maximized;
                doc.Dock = DockStyle.Fill;
                doc.Show();
                doc.Update();
            }
        }

        private void btnInventoryHistory_Click(object sender, EventArgs e)
        {
            string tabName = "盘点历史";
            if (!IsOpenTab(tabName))
            {
                FrmInventoryStatisticHistory doc = new FrmInventoryStatisticHistory();
                doc.MdiParent = this;
                doc.WindowState = FormWindowState.Maximized;
                doc.Dock = DockStyle.Fill;
                doc.Show();
                doc.Update();
            }
        }

        private void btnSysConfig_Click(object sender, EventArgs e)
        {
            FrmSystemConfig doc = new FrmSystemConfig();
            doc.ShowDialog(this);
        }
    }
}