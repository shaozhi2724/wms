using System;
using System.Windows.Forms;
using WMS.WinCE.App.Utils;

namespace WMS.WinCE.App
{
    public partial class FrmSetting : Form
    {
        public FrmSetting()
        {
            InitializeComponent();
        }

        // Singleton design patern
        private static FrmSetting _Instance = null;
        public static FrmSetting Instance()
        {
            if (_Instance == null || _Instance.IsDisposed)
            {
                _Instance = new FrmSetting();
            }
            _Instance.BringToFront();
            return _Instance;
        }

        public void LoadSettings()
        {
            var settings = MobileConfiguration.Settings;
            txtServer.Text = settings["DBServerName"];
            txtPort.Text = settings["DBServerPort"];
            txtDatabase.Text = settings["DBDatabaseName"];
            txtUsername.Text = settings["DBUserName"];
            txtPassword.Text = settings["DBPassword"];
            chkSystemSignPosition.Checked = bool.Parse(settings["SystemSignPosition"]);
            chkPrintCargoBarcode.Checked = bool.Parse(settings["PrintCargoBarcode"]);
        }

        private void muSave_Click(object sender, EventArgs e)
        {
            string server = txtServer.Text.Trim();
            string port = txtPort.Text.Trim();
            string database = txtDatabase.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            bool systemSignPosition = chkSystemSignPosition.Checked;
            bool printCargoBarcode = chkPrintCargoBarcode.Checked;

            try
            {
                MobileConfiguration.Save(server, port, database, username, password, systemSignPosition, printCargoBarcode);

                MessageBox.Show("设置成功！");
            }
            catch (Exception)
            {
                MessageBox.Show("设置失败，请退出重试！");
            }
        }

        private void muExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}