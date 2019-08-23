using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WMS.LabelController
{
    public partial class FrmModifyID : Form
    {
        private string _id;
        public string OldID
        {
            get
            {
                return _id;
            }
        }

        public string NewID { get; set; }

        public FrmModifyID()
        {
            InitializeComponent();
        }

        public FrmModifyID(string id)
        {
            InitializeComponent();
            this._id = id;
        }

        private void FrmModifyID_Load(object sender, EventArgs e)
        {
            lblOldID.Text = this._id.Trim();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string newID = txtNewID.Text.Trim();
            if (Regex.IsMatch(newID, "^[0-9]{4}$"))
            {
                this.NewID = newID;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                WinMessage.ShowInformation("新ID号必须是4位有效数字。");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtNewID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
