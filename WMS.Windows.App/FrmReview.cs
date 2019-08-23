using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using WMS.App.Services;
using WMS.Model;
using WMS.Windows.App.Properties;

namespace WMS.Windows.App
{
    public partial class FrmReview : Office2007Form
    {
        private IStoreBillService _service;
        private IReviewService _reviewService;
        private IProductService _productService;
        private List<WMSReviewHistory> _reviewHistories;
        private StoreBill _storeBill;
        private bool _isSupervise;
        public FrmReview()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;
            _service = new StoreBillService();
            _reviewService = new ReviewService();
            _productService = new ProductService();
            _reviewHistories = new List<WMSReviewHistory>();
        }
        public FrmReview(StoreBill storeBill) :this()
        {
            if (null == storeBill)
            {
                this.DialogResult = DialogResult.No;
                this.Close();
            }
            _isSupervise = false;
            _storeBill = storeBill;
            this.Text += string.Format(" - 单号: {0} （{1}）", storeBill.StoreCode, storeBill.DealerName);
            grdStoreOutDetail.Tag = storeBill.StoreID;
            if (storeBill.ReviewID.HasValue || _reviewService.IsReviewing(storeBill.StoreID))
            {
                if (System.Windows.Forms.DialogResult.OK ==
                    MessageBoxEx.Show(this, "此单正在复核或已复核", "系统提示", MessageBoxButtons.OK))
                {
                    this.DialogResult = DialogResult.No;
                    this.Close();
                }
            }
            else
            {
                SearchStoreBillDetail("");
                BindStoreDetails(storeBill.StoreID);
            }

        }


        protected override bool ProcessDialogKey(Keys keyData)
        {
            if(keyData == (Keys.Alt | Keys.F1))
            {
                var storeid = (int) grdStoreOutDetail.Tag;
                ReviewAllItems(storeid);
            }
            return base.ProcessDialogKey(keyData);
        }

        private void ReviewAllItems(int storeid)
        {
            if(grdReviewDetail.PrimaryGrid.Rows.Count > 0)
            {
                MessageBoxEx.Show("已有手动复核记录，请不要混用手动复核和一键复核！");
                return;
            }
            int rowCount = grdStoreOutDetail.PrimaryGrid.Rows.Count;
            for(int i = 0; i < rowCount; i++)
            {
                GridRow gridRow = grdStoreOutDetail.PrimaryGrid.Rows[i] as GridRow;
                var reviewId = (int) grdReviewDetail.Tag;
                var storeBillDetail = gridRow.DataItem as StoreBillOutDetailViewModel;
                if (null != storeBillDetail)
                {
                    BindReviewDetails(reviewId, storeBillDetail, true);
                }
            }
            EmptyStoreBillDetailInfo();
        }

        private void BindStoreDetails(int storeId)
        {
            var storeBillDetails = _service.GetAllCompletedStoreOutBillDetails(storeId);
            grdStoreOutDetail.PrimaryGrid.DataSource = storeBillDetails;
        }

        private void SearchStoreBillDetail(string barcode)
        {
            var storeID = (int) grdStoreOutDetail.Tag;
            int reviewId = GenerateReviewRecord(storeID);
            grdReviewDetail.Tag = reviewId;
        }

        private int GenerateReviewRecord(int storeId)
        {
            var review = _reviewService.GetByStoreId(storeId, Program.CurrentUser.Realname);
            if (null != review)
            {
                return review.ReviewID;
            }
            return 0;
        }

        private void FrmReview_Load(object sender, EventArgs e)
        {
            txtProductBarCode.Focus();
            if(!Settings.Default.AllowNoCodeReview && !_reviewService.CanReview())
            {
                MessageBoxEx.Show("无可用流通监管码，请导入流通监管码后重试！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                this.Close();
            }
        }

        private void txtProductSpell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                var spell = txtProductSpell.Text.Trim().ToLower();
                bool found = false;

                foreach(GridElement row in grdStoreOutDetail.PrimaryGrid.Rows)
                {
                    var gridRow = (row as GridRow);
                    if (gridRow != null)
                    {
                        var data = gridRow.DataItem as StoreBillOutDetailViewModel;
                        if(data != null && !string.IsNullOrWhiteSpace(data.ProductSpell) && data.ProductSpell.ToLower().Contains(spell))
                        {
                            //grdStoreOutDetail.ActiveGrid.SetActiveRow(gridRow);
                            //grdStoreOutDetail.PrimaryGrid.SetActiveRow(gridRow);
                            //grdStoreOutDetail.Update();
                            gridRow.SetActive(true);
                            found = true;
                            txtAmount.Text = gridRow.Cells["colStoreOutAmount"].Value.ToString();
                            txtAmount.Focus();
                            break;
                        }
                    }
                }
                if(!found)
                {
                    MessageBoxEx.Show("请输入的助记码或扫描正确的条码！");
                }
            }
        }

        private void txtProductBarCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                var barcode = txtProductBarCode.Text.Trim();
                bool found = false;
                //if (null == grdStoreOutDetail.ActiveGrid)
                //{
                //    grdStoreOutDetail.PrimaryGrid.InitialActiveRow = RelativeRow.FirstRow;
                //}
                foreach (GridElement row in grdStoreOutDetail.PrimaryGrid.Rows)
                {
                    var gridRow = (row as GridRow);
                    if (gridRow != null && (null != gridRow.Cells["colProductBarCode"].Value &&　barcode == gridRow.Cells["colProductBarCode"].Value.ToString()))
                    {
                        grdStoreOutDetail.PrimaryGrid.SetActiveRow(gridRow);
                        found = true;
                        txtAmount.Text = gridRow.Cells["colStoreOutAmount"].Value.ToString();
                        txtAmount.Focus();
                        break;
                    }
                }
                if (!found)
                {
                    MessageBoxEx.Show("请输入或扫描正确的条码！");
                }
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;//消除不合适字符
            }

            if (e.KeyChar == (char) Keys.Enter)
            {
                int amount = 0;
                if (!int.TryParse(txtAmount.Text, out amount))
                {
                    MessageBoxEx.Show("请输入正确的数值！");
                    return;
                }
                if (amount <= 0)
                {
                    MessageBoxEx.Show("请输入正确的数值！");
                    return;
                }
                if (grdStoreOutDetail.PrimaryGrid.Rows.Count > 0)
                {
                    if (null == grdStoreOutDetail.ActiveGrid)
                    {
                        MessageBoxEx.Show("请选择一个出库单明细！");
                        return;
                    }
                    if (null == grdStoreOutDetail.ActiveGrid.ActiveRow)
                    {
                        MessageBoxEx.Show("请选择一个出库单明细！");
                        return;
                    }

                    var gridRow = grdStoreOutDetail.ActiveGrid.ActiveRow as GridRow;
                    var reviewId = (int) grdReviewDetail.Tag;
                    var storeBillDetail = gridRow.DataItem as StoreBillOutDetailViewModel;
                    if (null != storeBillDetail)
                    {
                        BindReviewDetails(reviewId, storeBillDetail);
                    }
                    EmptyStoreBillDetailInfo();
                    //grdStoreOutDetail.ActiveGrid.SetActiveRow(grdStoreOutDetail.ActiveGrid.FirstSelectableRow);
                    txtProductBarCode.Focus();
                }
            }
        }

        private void BindReviewDetails(int reviewId, StoreBillOutDetailViewModel storeBillDetail, bool isOneKeyComplete = false)
        {
            int reviewAmount = storeBillDetail.Amount.Value;
            if(!isOneKeyComplete)
            {
                reviewAmount = int.Parse(txtAmount.Text.Trim());
            }
            try
            {

                string reviewResult = swtStatus.Value ? swtStatus.OnText : swtStatus.OffText;
                var reviewDetails = _reviewService.GetReviewDetails(reviewId, reviewAmount, storeBillDetail, reviewResult);
                grdReviewDetail.PrimaryGrid.DataSource = reviewDetails;

                var storeDetails = _service.GetAllCompletedStoreOutBillDetails(storeBillDetail.StoreID);
                //一键完成不检测是否需要扫描电子监管码
                if (!isOneKeyComplete)
                {
                    //药品是否需要扫描电子监管码
                    var product = _productService.GetProduct(storeBillDetail.ProductID);
                    if(null != product)
                    {
                        if((product.IsSupervise.HasValue && product.IsSupervise.Value) 
                            || !string.IsNullOrWhiteSpace(product.SuperviseSignBar))
                        {
                            _isSupervise = true;
                            if (Settings.Default.UseYuanboControl)
                            {
                                FrmScanSuperviseCodeYuanbo doc = new FrmScanSuperviseCodeYuanbo(storeBillDetail);
                                doc.ShowDialog();
                            }
                            else
                            {
                                FrmScanSuperviseCode doc = new FrmScanSuperviseCode(storeBillDetail);
                                doc.ShowDialog();
                            }
                        }
                    }
                }

                foreach (var storeBillOutDetailViewModel in storeDetails)
                {
                    var reviewedDetails = reviewDetails.Where(
                        p =>
                            p.ProductName == storeBillOutDetailViewModel.ProductName 
                            && p.ProductCode == storeBillOutDetailViewModel.ProductCode
                            && p.BatchNo == storeBillOutDetailViewModel.BatchNo
                            && p.PackageSpec == storeBillOutDetailViewModel.PackageSpec
                            && p.ProductSpec == storeBillOutDetailViewModel.ProductSpec);
                    storeBillOutDetailViewModel.Amount -= reviewedDetails.Sum(p => p.Amount);
                    //if (null != reviewDetail)
                    //{
                    //    int outAmount = storeBillOutDetailViewModel.Amount.Value;
                    //    storeBillOutDetailViewModel.Amount -= reviewDetail.Amount;
                    //    //_reviewHistories.Add(new WMSReviewHistory
                    //    //{
                    //    //    ReviewID = reviewId,
                    //    //    DetailID = reviewDetail.DetailID,
                    //    //    ProductID = reviewDetail.ProductID,
                    //    //    BatchNo = reviewDetail.BatchNo,
                    //    //    ProduceDate = reviewDetail.ProduceDate,
                    //    //    ValidateDate = reviewDetail.ValidateDate,
                    //    //    Amount = outAmount,
                    //    //    ReviewAmount = reviewDetail.Amount,
                    //    //    ReviewResult = swtStatus.Value ? "合格" : "不合格",
                    //    //    CreateDate = DateTime.Now,
                    //    //    CreateUserID = Program.CurrentUser.UserId
                    //    //});
                    //}
                }
                grdStoreOutDetail.PrimaryGrid.DataSource = storeDetails.OrderByDescending(p => p.Amount).ToList();
                var canComplete = storeDetails.All(p => p.Amount == 0);

                btnSave.Enabled = canComplete;
                btnPrint.Enabled = canComplete;
                btnPrintTicket.Enabled = canComplete;
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
                return;
            }
        }

        private void grdStoreOutDetail_RowActivated(object sender, DevComponents.DotNetBar.SuperGrid.GridRowActivatedEventArgs e)
        {
            BindStoreBillDetailInfo();
        }

        private void BindStoreBillDetailInfo()
        {
            var row = (grdStoreOutDetail.PrimaryGrid.ActiveRow as GridRow);

            if (row != null)
            {
                var storeBill = row.DataItem as StoreBillOutDetailViewModel;
                if (null != storeBill)
                {
                    txtBatchNo.Text = storeBill.BatchNo;
                    txtProductCode.Text = storeBill.ProductCode;
                    txtPackageSpec.Text = storeBill.PackageSpec;
                    txtProducerName.Text = storeBill.ProducerName;
                    txtProductCode.Text = storeBill.ProductCode;
                    txtProductName.Text = storeBill.ProductName;
                    txtProductSpec.Text = storeBill.ProductSpec;
                    txtAuthorizedNo.Text = storeBill.AuthorizedNo;
                    txtProductBarCode.Text = storeBill.ProductBarCode;
                    txtAmount.Text = row.Cells["colStoreOutAmount"].Value.ToString();
                    SearchStoreBillDetail(storeBill.ProductBarCode);

                    row.SetActive(true);
                    txtProductBarCode.Focus();
                }
            }
            else
            {
                EmptyStoreBillDetailInfo();
            }
        }

        private void EmptyStoreBillDetailInfo()
        {
            txtBatchNo.Text = string.Empty;
            txtProductCode.Text = string.Empty;
            txtPackageSpec.Text = string.Empty;
            txtProducerName.Text = string.Empty;
            txtProductCode.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtProductSpec.Text = string.Empty;
            txtAuthorizedNo.Text = string.Empty;

            txtProductBarCode.Text = string.Empty;
            txtAmount.Text = string.Empty;
            if (null != grdStoreOutDetail.ActiveGrid)
            {
                grdStoreOutDetail.ActiveGrid.SetActiveRow(null);
                grdStoreOutDetail.ActiveGrid.ClearSelectedRows();
            }
            grdStoreOutDetail.PrimaryGrid.SetActiveRow(null);
            grdStoreOutDetail.PrimaryGrid.ClearSelectedRows();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes ==
                MessageBoxEx.Show("确定取消复核？", "系统提示框", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1))
            {
                if (null != grdReviewDetail.Tag)
                {
                    int reviewId = (int) grdReviewDetail.Tag;
                    _reviewService.CancelReview(reviewId);
                }
                this.DialogResult = DialogResult.No;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CompleteReview())
            {
                return;
            }
            this.DialogResult = DialogResult.Yes;
        }

        private bool CompleteReview()
        {
            if (!CheckReviewAction())
            {
                return true;
            }

            bool reviewCompleted = false;
            int reviewId = (int) grdReviewDetail.Tag;
            bool wmsStandalone = Settings.Default.WMSStandalone;
            if (wmsStandalone)
            {
                reviewCompleted = _reviewService.CompleteReview(reviewId, Settings.Default.AllowNoCodeReview);
            }
            else
            {
                reviewCompleted = _reviewService.CompleteReviewAndBill(reviewId, Settings.Default.AllowNoCodeReview);
            }

            if (reviewCompleted)
            {
                txtProductBarCode.Enabled = false;
                txtAmount.Enabled = false;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;

                if (_isSupervise)
                {
                    if (Settings.Default.UseYuanboControl)
                    {
                        try
                        {
                            Yuanbo.Service.Controls.UploadFile.CreateFile(_storeBill.StoreCode, "");

                            return reviewCompleted;
                        }
                        catch (Exception ex)
                        {
                            MessageBoxEx.Show(ex.Message);
                            return false;
                        }
                    }
                }
            }
            return reviewCompleted;
        }

        private bool CheckReviewAction()
        {
            if (!Settings.Default.AllowNoCodeReview && !_reviewService.CanReview())
            {
                MessageBoxEx.Show("无可用流通监管码，请导入流通监管码后重试！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }

        private void btnPrintTicket_Click(object sender, EventArgs e)
        {
            if (!CheckReviewAction())
            {
                return;
            }

            int reviewId = (int)grdReviewDetail.Tag;
            if (!IsReviewCompleted(reviewId))
            {
                if (!CompleteReview())
                {
                    return;
                }
            }
            btnCancel.Enabled = false;
            FrmReportPreview doc = new FrmReportPreview(reviewId, "SmallReport");
            doc.ShowDialog(this);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!CheckReviewAction())
            {
                return;
            }
            int reviewId = (int)grdReviewDetail.Tag;
            if (!IsReviewCompleted(reviewId))
            {
                if (!CompleteReview())
                {
                    return;
                }
            }
            btnCancel.Enabled = false;
            FrmReportPreview doc = new FrmReportPreview(reviewId, "Report");
            doc.ShowDialog(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            int reviewId = (int) grdReviewDetail.Tag;
            if (!IsReviewCompleted(reviewId))
            {
                if (DialogResult.Yes ==
                    MessageBoxEx.Show("复核未完成，是否取消复核并关闭？", "系统提示框", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1))
                {
                    _reviewService.CancelReview(reviewId);
                }
                else
                {
                    return;
                }
            }
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private bool IsReviewCompleted(int reviewId)
        {
            var review = _reviewService.GetByReviewId(reviewId);
            return (null != review) && review.StatusID.HasValue && review.StatusID == 1;
        }

        private void btnBackPrint_Click(object sender, EventArgs e)
        {
            if (!CheckReviewAction())
            {
                return;
            }
            int reviewId = (int)grdReviewDetail.Tag;
            if (!IsReviewCompleted(reviewId))
            {
                if (!CompleteReview())
                {
                    return;
                }
            }
            btnCancel.Enabled = false;
            FrmReportPreview doc = new FrmReportPreview(reviewId, "BackReport");
            doc.ShowDialog(this);
        }
    }
}