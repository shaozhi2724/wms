using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
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
    public partial class FrmProductForReview : Office2007Form
    {

        public List<MoreProductForReview> _mpfr = new List<MoreProductForReview>();

        public GridRow _forReview = new GridRow();

        public FrmProductForReview()
        {
            InitializeComponent();
        }

        private void FrmProductForReview_Load(object sender, EventArgs e)
        {
            BaindGrid();
            grdStoreOutDetail.Focus();

            //if (e.KeyChar == (char)Keys.Enter)
            //{
            //    _forReview = (grdStoreOutDetail.PrimaryGrid.ActiveRow as GridRow);
            //    this.DialogResult = DialogResult.Yes;
            //}
        }

        private void BaindGrid()
        {
            this.grdStoreOutDetail.PrimaryGrid.DataSource = _mpfr;
        }

        private void grdStoreOutDetail_RowDoubleClick(object sender, GridRowDoubleClickEventArgs e)
        {
            //MessageBox.Show("TestOK");
            _forReview = (grdStoreOutDetail.PrimaryGrid.ActiveRow as GridRow);
            this.DialogResult = DialogResult.Yes;
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == (Keys.Space))
            {
                _forReview = (grdStoreOutDetail.PrimaryGrid.ActiveRow as GridRow);
                this.DialogResult = DialogResult.Yes;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
