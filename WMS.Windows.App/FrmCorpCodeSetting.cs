using System;
using System.IO;
using DevComponents.DotNetBar;

namespace WMS.Windows.App
{
    public partial class FrmCorpCodeSetting : Office2007Form
    {

        string _file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CorpCode.dat");
        public FrmCorpCodeSetting()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;
        }

        private void FrmCorpCodeSetting_Load(object sender, EventArgs e)
        {
            if (!File.Exists(_file))
            {
                File.AppendAllText(_file,"");
            }
            var corpCode = File.ReadAllText(_file);
            txtCorpCode.Text = corpCode;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var corpCode = txtCorpCode.Text.Trim();
            File.WriteAllText(_file, corpCode);
        }
    }
}
