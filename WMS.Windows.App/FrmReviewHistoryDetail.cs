using System;
using DevComponents.DotNetBar;
using WMS.App.Services;

namespace WMS.Windows.App
{
    public partial class FrmReviewHistoryDetail : Office2007Form
    {
        private IReviewService _reviewService;

        public FrmReviewHistoryDetail()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;
            _reviewService = new ReviewService();
        }
        public FrmReviewHistoryDetail(ReviewHistoryViewModel model)
            : this()
        {
            grdReviewDetail.Tag = model.ReviewID;
            BindReviewDetails(model.ReviewID);

        }

        private void BindReviewDetails(int reviewId)
        {
            try
            {
                var reviewDetails = _reviewService.GetReviewDetails(reviewId);
                grdReviewDetail.PrimaryGrid.DataSource = reviewDetails;

            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
                return;
            }
        }

        private void btnPrintTicket_Click(object sender, EventArgs e)
        {
            int reviewId = (int) grdReviewDetail.Tag;
            FrmReportPreview doc = new FrmReportPreview(reviewId, "SmallReport");
            doc.ShowDialog(this);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int reviewId = (int)grdReviewDetail.Tag;
            FrmReportPreview doc = new FrmReportPreview(reviewId, "Report");
            doc.ShowDialog(this);
        }

        private void btnBackPrint_Click(object sender, EventArgs e)
        {
            int reviewId = (int)grdReviewDetail.Tag;
            FrmReportPreview doc = new FrmReportPreview(reviewId, "BackReport");
            doc.ShowDialog(this);
        }
    }
}