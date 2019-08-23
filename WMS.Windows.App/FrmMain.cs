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

            btnSysConfig.Visible = Program.CurrentUser.Username == "ϵͳ����Ա";
            switch (Program.CurrentUser.Rolename)
            {
                case "ϵͳ����Ա":
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
                case "�ֿ����Ա":
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
                case "����Ա":
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
                string tabName = "�����";

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
                MessageBoxEx.Show(this, "������ػ�����ʶδ���ã��򱾻���ʶ��ϵͳ���ò�ƥ�䣬����ϵ����Ա", "ϵͳ����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        /// <summary>
        /// ��ֹ�򿪶��ͬ�����Ӵ���,����Ƿ��Ѵ�ĳ���Ӵ���,������˾ͷ���true,���򷵻�false
        /// </summary>
        /// <param name="tabName">�Ӵ���Ĵ�������</param>
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
                string tabName = "������";
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
                MessageBoxEx.Show(this, "������ػ�����ʶδ���ã��򱾻���ʶ��ϵͳ���ò�ƥ�䣬����ϵ����Ա", "ϵͳ����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    case "ϵͳ����Ա":
                    case "�ֿ����Ա":
                        if (Program.CurrentComputerAllowMonitoring())
                        {
                            btnStoreInMonitoring_Click(null, null);
                        }
                        break;
                    case "����Ա":
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
            string tabName = "��ǩ����";
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
            string tabName = "�ֿ���Ϣ";
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
            string tabName = "�洢��Ԫ";
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
            string tabName = "ҩƷ����";
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
            string tabName = "�������";
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
            string tabName = "���⸴��";
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
                MessageBoxEx.Show("ȷ���˳�ϵͳ��", "ϵͳȷ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
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
            string tabName = "��������";
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
            //string tabName = "��������";
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
            string tabName = "�����ʷ��ѯ";
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
            string tabName = "������ʷ��ѯ";
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
            string tabName = "������ʷ��ѯ";
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
            string tabName = "�ڿ�ҩƷ��ѯ";
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
            string tabName = "������";
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
            string tabName = "�û�����";
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
            string tabName = "����̵�";
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
            string tabName = "��λ����";
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
            string tabName = "�̵���ʷ";
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