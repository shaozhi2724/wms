using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using WMS.App.Services;
using WMS.Model;
using WMS.Windows.App.Properties;

namespace WMS.Windows.App
{
    public partial class FrmInventoryStatisticHistory : Office2007Form
    {
        private IStoreBillService _service;
        private IInventoryService _inventoryService;
        public FrmInventoryStatisticHistory()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;

            _service = new StoreBillService();
            _inventoryService = new InventoryService();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchInventoryStatisticHistories();
        }

        private void FrmInventoryStatisticHistory_Load(object sender, EventArgs e)
        {
            datStartDate.Value = DateTime.Today;
            datEndDate.Value = DateTime.Today;

            SearchInventoryStatisticHistories();
        }
        private void SearchInventoryStatisticHistories()
        {
            string inventoryStatisCode = txtStatisticCode.Text.Trim();
            DateTime startDate = datStartDate.Value;
            DateTime endDate = datEndDate.Value;

            var inventoryStatisticTasks = _service.SearchInventoryStatisticHistories(inventoryStatisCode, startDate, endDate);

            grdInventoryStatistic.PrimaryGrid.DataSource = inventoryStatisticTasks;
            if (grdInventoryStatistic.PrimaryGrid.Rows.Count > 0)
            {
                grdInventoryStatistic.PrimaryGrid.SetActiveRow((GridContainer)grdInventoryStatistic.PrimaryGrid.Rows[0]);
            }
            grdInventoryStatistic.Update();
            BindInventoryStatisticDetails(null);
        }

        private void BindInventoryStatisticDetails(GridRow activeRow)
        {
            if (activeRow == null)
            {
                activeRow = (grdInventoryStatistic.PrimaryGrid.ActiveRow as GridRow);
            }
            if (activeRow != null)
            {
                var inventoryStatistic = activeRow.DataItem as InventoryStatistic;

                var inventoryStatisticID = inventoryStatistic.InventoryStatisticID;
                lblStoreCode.Text = inventoryStatistic.InventoryStatisticCode;

                var details = _service.GetInventoryStatisticDetails(inventoryStatisticID);
                grdInventoryStatisticDetail.PrimaryGrid.DataSource = details;
                grdInventoryStatisticDetail.Update();
            }
            else
            {
                lblStoreCode.Text = string.Empty;
                grdInventoryStatisticDetail.PrimaryGrid.DataSource = null;
            }
        }

        private void grdInventoryStatistic_RowActivated(object sender, GridRowActivatedEventArgs e)
        {
            var row = e.NewActiveRow as GridRow;
            if (null != row)
            {
                var model = row.DataItem as InventoryStatistic;
                btnPrint.Enabled = null != model;
                btnUpdateStore.Enabled = null != model && model.StatusID == 3;
                btnRefresh.Enabled = null != model && model.StatusID < 3;
            }
            else
            {
                btnPrint.Enabled = false;
                btnUpdateStore.Enabled = false;
                btnRefresh.Enabled = false;
            }
            BindInventoryStatisticDetails(row);
        }


        //private void grdInventoryStatisticDetail_RowActivated(object sender, GridRowActivatedEventArgs e)
        //{
        //    var row = e.NewActiveRow as GridRow;
            
        //}

        private void btnPrint_Click(object sender, EventArgs e)
        {
            GridRow activeRow = (grdInventoryStatistic.ActiveRow as GridRow);

            if (activeRow != null)
            {
                var inventoryStatistic = activeRow.DataItem as InventoryStatistic;

                var inventoryStatisticID = inventoryStatistic.InventoryStatisticID;
                FrmReportPreview doc = new FrmReportPreview(inventoryStatisticID, "InventoryStatistic");
                doc.ShowDialog(this);
            }
        }

        private void btnUpdateStore_Click(object sender, EventArgs e)
        {
            MessageBoxEx.EnableGlass = false;
            string message = "修改库存";
            if (!Settings.Default.WMSStandalone)
            {
                message += "并同步业务库存";
            }
            if (DialogResult.Yes ==
                MessageBoxEx.Show("确定" + message + "？", "系统确认信息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                var row = (grdInventoryStatistic.ActiveGrid.ActiveRow as GridRow);

                if (row != null)
                {
                    try
                    {
                        var data = row.DataItem as InventoryStatistic;

                        _inventoryService.UpdateCargoStoreAmountAndBusinessAmount(data.InventoryStatisticID, !Settings.Default.WMSStandalone, Program.CurrentUser.Realname);
                        MessageBoxEx.Show("成功" + message + "。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception exception)
                    {
                        MessageBoxEx.Show(string.Format("操作失败\n错误信息：\n{0}", exception.Message), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                SearchInventoryStatisticHistories();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MessageBoxEx.EnableGlass = false;
            if (DialogResult.Yes ==
                MessageBoxEx.Show("确定自动更新未盘点记录，并完成盘点任务？", "系统确认信息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                var row = (grdInventoryStatistic.ActiveGrid.ActiveRow as GridRow);

                if (row != null)
                {
                    try
                    {
                        var data = row.DataItem as InventoryStatistic;

                        _inventoryService.CompleteTaskManually(data.InventoryStatisticID);
                        
                    }
                    catch (Exception exception)
                    {
                        MessageBoxEx.Show(string.Format("操作失败\n错误信息：\n{0}", exception.Message), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                SearchInventoryStatisticHistories();
            }
        }
    }
}
