using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using WMS.App.Services;
using WMS.Model;
using WMS.Windows.App.Properties;
using Yuanbo.Service.Controls;

namespace WMS.Windows.App
{
    public partial class FrmReviewHistory : Office2007Form
    {

        private IReviewService _service;
        public FrmReviewHistory()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;
            _service = new ReviewService();
        }



        private void SearchReviewRecords()
        {
            string reviewCode = txtStoreOutReviewCode.Text.Trim();
            string dealerName = txtDealerName.Text.Trim();
            DateTime startDate = datReviewStartDate.Value;
            DateTime endDate = datReviewEndDate.Value;
            int storeTypeId = cbxStoreOutType.SelectedIndex + 1;
            string productName = txtProductName.Text.Trim();
            var reviews = _service.SearchReviews(reviewCode, dealerName, storeTypeId, startDate, endDate, productName);
            grdStoreOutDetail.PrimaryGrid.DataSource = reviews;
        }

        private void FrmReviewHistory_Load(object sender, EventArgs e)
        {
            datReviewStartDate.Value = DateTime.Today;
            datReviewEndDate.Value = DateTime.Today;
            SearchReviewRecords();

            //btnUpload.Visible = Settings.Default.UseYuanboControl;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchReviewRecords();
        }

        private void grdStoreOutDetail_RowDoubleClick(object sender, DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs e)
        {
            var model = (e.GridRow as GridRow).DataItem as ReviewHistoryViewModel;
            FrmReviewHistoryDetail doc = new FrmReviewHistoryDetail(model);
            doc.ShowDialog(this);
            SearchReviewRecords();
        }

    }
}
