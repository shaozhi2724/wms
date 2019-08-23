using System;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using WMS.App.Services;
using WMS.Model;
using WMS.Windows.App.Properties;

namespace WMS.Windows.App
{
    public partial class FrmStoreOutReview : Office2007Form
    {
        private IStoreBillService _service;
        private IReviewService _reviewService;
        public FrmStoreOutReview()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;
            _service = new StoreBillService();
            _reviewService = new ReviewService();
        }

        private void FrmStoreOutReview_Load(object sender, EventArgs e)
        {
            BindStoreOutRecords();
        }

        private void BindStoreOutRecords()
        {
            var storeBills = _service.GetAllNotReviewedCompletedStoreOutBills();
            grdStoreOutDetail.PrimaryGrid.DataSource = storeBills;
            if (storeBills.Count > 0)
            {
                btnReview.Enabled = true;

                grdStoreOutDetail.PrimaryGrid.SetActive();
                if (grdStoreOutDetail.PrimaryGrid.Rows.Count > 0)
                {
                    grdStoreOutDetail.PrimaryGrid.SetActiveRow((GridContainer) grdStoreOutDetail.PrimaryGrid.Rows[0]);
                }
            }
            else
            {
                EmptyStoreBillInfo();
                btnReview.Enabled = false;
            }
        }

        private void BindStoreOutRecordsByReviewIdentity(string identityCode)
        {
            if(string.IsNullOrWhiteSpace(identityCode))
            {
                BindStoreOutRecords();
            }
            else
            {
                var storeBills = _service.GetNotReviewedCompletedStoreOutBillByReviewIdentity(identityCode);
                grdStoreOutDetail.PrimaryGrid.DataSource = storeBills;
                if(storeBills.Count > 0)
                {
                    btnReview.Enabled = true;

                    grdStoreOutDetail.PrimaryGrid.SetActive();
                    if(grdStoreOutDetail.PrimaryGrid.Rows.Count > 0)
                    {
                        grdStoreOutDetail.PrimaryGrid.SetActiveRow((GridContainer)grdStoreOutDetail.PrimaryGrid.Rows[0]);
                    }
                }
                else
                {
                    EmptyStoreBillInfo();
                    btnReview.Enabled = false;
                }
            }
        }

        private void SearchStoreOutRecords()
        {
            string identityCode = txtReviewIdentity.Text.Trim();
            if(!string.IsNullOrWhiteSpace(identityCode))
            {
                BindStoreOutRecordsByReviewIdentity(identityCode);
            }
            else
            {
                BindStoreOutRecords();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string identityCode = txtReviewIdentity.Text.Trim();
            if (!string.IsNullOrWhiteSpace(identityCode))
            {
                BindStoreOutRecordsByReviewIdentity(identityCode);
            }
            else
            {
                BindStoreOutRecords();
            }
        }

        private void btnReview_Click(object sender, EventArgs e)
        {

            if (!Settings.Default.AllowNoCodeReview && !_reviewService.CanReview())
            {
                MessageBoxEx.Show("无可用流通监管码，请导入流通监管码后重试！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                return;
            }
            var row = (grdStoreOutDetail.ActiveGrid.ActiveRow as GridRow);

            if (row != null)
            {
                var storeBill = row.DataItem as StoreBill;
                //判断是否已经有人复核这单
                if (_reviewService.HaveReviewCode(storeBill.StoreCode))
                {
                    MessageBoxEx.Show("该单已经有人复核或已经复核完成，请重新选择！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);
                    SearchStoreOutRecords();
                    return;
                }
                FrmReview doc = new FrmReview(row.DataItem as StoreBill);
                if (!doc.IsDisposed)
                {
                    var dialogResult = doc.ShowDialog(this);

                    if (DialogResult.Yes == dialogResult)
                    {
                        SearchStoreOutRecords();
                    }
                }
                else
                {
                    SearchStoreOutRecords();
                }
            }

        }

        private void grdStoreOutDetail_RowActivated(object sender, GridRowActivatedEventArgs e)
        {
            BindStoreBillInfo();
        }

        private void BindStoreBillInfo()
        {
            if (null != grdStoreOutDetail.ActiveGrid 
                && null != grdStoreOutDetail.ActiveGrid.ActiveRow
                && grdStoreOutDetail.ActiveGrid.Rows.Count > 0)
            {
                var row = (grdStoreOutDetail.ActiveGrid.ActiveRow as GridRow);

                if (row != null)
                {
                    var storeBill = row.DataItem as StoreBill;
                    txtProviderName.Text = storeBill.DealerName;
                    txtStoreOutCode.Text = storeBill.StoreCode;
                    txtStoreType.Text = storeBill.StoreTypeName;
                }
                else
                {
                    EmptyStoreBillInfo();
                }
            }
            else
            {
                EmptyStoreBillInfo();
            }
        }

        private void EmptyStoreBillInfo()
        {
            txtProviderName.Text = string.Empty;
            txtStoreOutCode.Text = string.Empty;
            txtStoreType.Text = string.Empty;
        }

        private void txtReviewIdentity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                string identityCode = txtReviewIdentity.Text.Trim();
                BindStoreOutRecordsByReviewIdentity(identityCode);
                var storeBills = _service.GetNotReviewedCompletedStoreOutBillByReviewIdentity(identityCode);
                if(storeBills.Count > 0)
                {
                    if(!Settings.Default.AllowNoCodeReview && !_reviewService.CanReview())
                    {
                        MessageBoxEx.Show("无可用流通监管码，请导入流通监管码后重试！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1);
                        return;
                    }
                    FrmReview doc = new FrmReview(storeBills.First());
                    if(!doc.IsDisposed)
                    {
                        var dialogResult = doc.ShowDialog(this);

                        if(DialogResult.Yes == dialogResult)
                        {
                            EmptyStoreBillInfo();
                            SearchStoreOutRecords();
                        }
                    }
                    else
                    {
                        EmptyStoreBillInfo();
                        SearchStoreOutRecords();
                    }
                }
                else
                {
                    EmptyStoreBillInfo();
                    btnReview.Enabled = false;
                }
            }
        }

        private void btnDelReview_Click(object sender, EventArgs e)
        {
            var row = (grdStoreOutDetail.ActiveGrid.ActiveRow as GridRow);

            if (row != null)
            {
                var storeBill = row.DataItem as StoreBill;
                using (FrmDelReview del = new FrmDelReview(storeBill.StoreID, storeBill.StoreCode))
                {
                    if (del.ShowDialog() == DialogResult.OK)
                    {
                        BindStoreOutRecords();
                    }
                }
            }
        }
    }
}