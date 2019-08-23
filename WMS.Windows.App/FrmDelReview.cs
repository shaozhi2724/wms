using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMS.App.Services;

namespace WMS.Windows.App
{
    public partial class FrmDelReview : Office2007Form
    {
        private IReviewService _reviewService;
        int _storeID;
        string _storeCode;
        public FrmDelReview()
        {
            InitializeComponent();
        }
        public FrmDelReview(int storeID,string storeCode)
        {
            InitializeComponent();
            _reviewService = new ReviewService();
            _storeID = storeID;
            _storeCode = storeCode;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string mes = _reviewService.GenerateApproval(Program.CurrentUser.Realname, _storeID, _storeCode, txtResult.Text);
            MessageBox.Show(mes, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }
    }
}
