using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WMS.WinCE.App
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        // Singleton design patern
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

        private void muExit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes ==
                MessageBox.Show("确定退出DQS RF扫描系统？", "退出确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1))
            {
                Process thisProcess = Process.GetCurrentProcess();
                thisProcess.Kill();
            }
        }

        private void btnStoreIn_Click(object sender, EventArgs e)
        {
            if (Program.PrintCargoBarcode)
            {
                var doc = FrmSystemStoreIn.Instance();
                doc.Show();
            }
            else
            {
                var doc = FrmStoreIn.Instance(-1);
                doc.BindStoreInRecords();
                doc.Show();
            }
        }

        private void btnStoreOut_Click(object sender, EventArgs e)
        {
            var doc = FrmStoreOut.Instance(-1);
            doc.BindStoreOutRecords();
            doc.Show();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            var doc = FrmProductTransferSource.Instance();
            doc.Init();
            doc.Show();
        }

        private void btnDemolition_Click(object sender, EventArgs e)
        {
            FrmDemolition doc = FrmDemolition.Instance();
            doc.Init();
            doc.Show();
        }

        private void btnCollection_Click(object sender, EventArgs e)
        {
            FrmCollection doc = FrmCollection.Instance();
            doc.Init();
            doc.Show();
        }

        private void btnProductSummary_Click(object sender, EventArgs e)
        {
            FrmProductSummary doc = FrmProductSummary.Instance();
            doc.Show();
        }

        private void btnInitStoreIn_Click(object sender, EventArgs e)
        {
            FrmInitStoreIn doc = FrmInitStoreIn.Instance();
            doc.SearchProducts();
            doc.Show();
        }

        private void btnInventoryQuery_Click(object sender, EventArgs e)
        {
            FrmInventoryQuery doc = FrmInventoryQuery.Instance();
            doc.InitSearch();
            doc.Show();
        }

        private void muSetting_Click(object sender, EventArgs e)
        {
            FrmSetting doc = FrmSetting.Instance();
            doc.LoadSettings();
            doc.Show();
        }

        private void btnUnqualifiedStoreIn_Click(object sender, EventArgs e)
        {
            var doc = FrmUnqualifiedStoreIn.Instance(-1);
            doc.BindStoreInRecords();
            doc.Show();
        }

        private void btnUnqualifiedMove_Click(object sender, EventArgs e)
        {
            var doc = FrmUnqualifiedMove.Instance(-1);
            doc.BindStoreInRecords();
            doc.Show();

        }

        private void btnPurchaseReturn_Click(object sender, EventArgs e)
        {
            var doc = FrmPurchaseReturnStoreOut.Instance(-1);
            doc.BindStoreOutRecords();
            doc.Show();

        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {

            var doc = FrmProductDestroy.Instance(-1);
            doc.BindDestroyRecords();
            doc.Show();
        }
    }
}