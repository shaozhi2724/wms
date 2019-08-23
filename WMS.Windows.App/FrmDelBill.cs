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
using WMS.Model;

namespace WMS.Windows.App
{
    public partial class FrmDelBill : Office2007Form
    {

        private IStoreBillService _service = new StoreBillService();

        public FrmDelBill()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string storeCode = txtCode.Text.Trim();
            if (storeCode == "")
            {
                MessageBoxEx.Show("请输入完整单据号。", "系统确认信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int storeID = _service.getStoreBillID(storeCode);
            if (storeID == 0)
            {
                MessageBoxEx.Show("输入单据号不存在，请确认后重新输入。", "系统确认信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var storeBills = _service.GetStoreBill(storeCode);
            grdStoreOut.PrimaryGrid.DataSource = storeBills;
            var details = _service.GetStoreBillDetail(storeID);
            grdStoreOutDetail.PrimaryGrid.DataSource = details;
        }

        private void SearchStoreRecords()
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string storeCode = txtCode.Text.Trim();
            if (storeCode == "")
            {
                MessageBoxEx.Show("请输入完整单据号。", "系统确认信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int storeID = _service.getStoreBillID(storeCode);
            if (storeID == 0)
            {
                MessageBoxEx.Show("输入单据号不存在，请确认后重新输入。", "系统确认信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool isDel = _service.DelStoreBill(storeCode);
            if (isDel)
            {
                MessageBoxEx.Show("删除成功", "系统确认信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grdStoreOut.PrimaryGrid.DataSource = null;
                grdStoreOutDetail.PrimaryGrid.DataSource = null;
            }
            else
            {
                MessageBoxEx.Show("删除失败，该单已完成或者明细中有已完成的明细。不能删除", "系统确认信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            string storeCode = txtCode.Text.Trim();
            if (storeCode == "")
            {
                MessageBoxEx.Show("请输入完整单据号。", "系统确认信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int storeID = _service.getStoreBillID(storeCode);
            if (storeID == 0)
            {
                MessageBoxEx.Show("输入单据号不存在，请确认后重新输入。", "系统确认信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool isDel = _service.PassStoreBill(storeCode);
            if (isDel)
            {
                MessageBoxEx.Show("直接通过成功", "系统确认信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grdStoreOut.PrimaryGrid.DataSource = null;
                grdStoreOutDetail.PrimaryGrid.DataSource = null;
            }
            else
            {
                MessageBoxEx.Show("直接通过失败，该单已完成或者明细中有已完成的明细。不能删除", "系统确认信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelOnly_Click(object sender, EventArgs e)
        {
            var row = (grdStoreOutDetail.ActiveGrid.ActiveRow as GridRow);

            if (row != null)
            {
                var storeBill = row.DataItem as StoreInBillDetailViewModel;
                bool isDelDetail = _service.DelStoreBillDetail(storeBill.DetailID);
                if (isDelDetail)
                {
                    MessageBoxEx.Show("删除明细成功", "系统确认信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
