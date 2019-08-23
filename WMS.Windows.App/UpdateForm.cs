using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace WMS.Windows.App
{
    public partial class UpdateForm : Office2007Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        public string Info { get { return lblInfo.Text; } set { lblInfo.Text = value; } }
        public string MoreInfoLink { get; set; }

        private void linkInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkInfo.LinkVisited = true;
            System.Diagnostics.Process.Start(MoreInfoLink);
        }
    }
}
