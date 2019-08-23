using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;
using WMS.App.Services;
using WMS.Model;
using WMS.Windows.App.Properties;

namespace WMS.Windows.App
{
    public partial class FrmStoreOutMonitoring : Office2007Form
    {
        private System.Timers.Timer timerAutoRefresh;
        private System.Timers.Timer timerAutomatic;
        private GridRow _selectedRow;
        private GridRow _selectedDetailRow;
        private List<int> _errorBills;
        private IStoreBillService _service;
        private bool _isProcessing;
        public FrmStoreOutMonitoring()
        {
            InitializeComponent();
            //CheckForIllegalCrossThreadCalls = false;
            MessageBoxEx.EnableGlass = false;
            _service = new StoreBillService();
            _errorBills = new List<int>();
            _isProcessing = false;
            if(!Program.CurrentComputerAllowMonitoring())
            {
                MessageBoxEx.Show(this, "出入库监控机器标识未设置，或本机标识与系统设置不匹配，请联系管理员", "系统警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }

        }

        void timerAutomatic_Elapsed(object sender, ElapsedEventArgs e)
        {
            if(!Program.CurrentComputerAllowMonitoring())
            {
                MessageBoxEx.Show(this, "出入库监控机器标识未设置，或本机标识与系统设置不匹配，请联系管理员", "系统警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                timerAutomatic.Enabled = false;
                timerAutoRefresh.Enabled = false;
                return;
            }
            while(!this.IsHandleCreated)
            {

            }
            this.BeginInvoke(new Action(() =>
                             {
                                 SearchStoreOutRecodes();
                                 if (null == grdStoreOut.ActiveGrid)
                                 {
                                     return;
                                 }
                                 timerAutomatic.Enabled = false;
                                 var storeBills =
                                     _service.GetAllStoreOutBills()
                                             .Where(p => p.StoreStatusID == null || p.StoreStatusID == "0")
                                             .OrderBy(p => p.StoreCode)
                                             .Take(Settings.Default.MaxOutTaskCount)
                                             .ToList();

                                 foreach (var storeBill in storeBills)
                                 {
                                     if (null != storeBill &&
                                         (string.IsNullOrWhiteSpace(storeBill.StoreStatusID) ||
                                          storeBill.StoreStatusID == ((int) StoreBillStatuses.Waiting).ToString()))
                                     {
                                         SplitStoreBillDetailsAndUpdateDetailStatuses(storeBill);
                                     }
                                 }
                                 SearchStoreOutRecodes();
                                 grdStoreOut.Update();
                                 grdStoreOutDetail.Update();
                                 timerAutomatic.Enabled = true;
                             }));
            /*var row = (grdStoreOut.ActiveGrid.ActiveRow as GridRow);

            if (row != null)
            {
                var storeBill = row.DataItem as StoreBill;
                if (null != storeBill && (string.IsNullOrWhiteSpace(storeBill.StoreStatusID) || storeBill.StoreStatusID == ((int) StoreBillStatuses.Waiting).ToString()))
                {
                    timerAutomatic.Enabled = false;
                    SplitStoreBillDetailsAndUpdateDetailStatuses(storeBill);
                    SearchStoreOutRecodes();
                    grdStoreOut.Update();
                    grdStoreOutDetail.Update();
                    timerAutomatic.Enabled = true;
                }
            }*/
        }

        void timerAutoRefresh_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if(!Program.CurrentComputerAllowMonitoring())
            {
                MessageBoxEx.Show(this, "出入库监控机器标识未设置，或本机标识与系统设置不匹配，请联系管理员", "系统警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                timerAutomatic.Enabled = false;
                timerAutoRefresh.Enabled = false;
                return;
            }
            while(!this.IsHandleCreated)
            {
            }
            this.BeginInvoke(new Action(() =>
                                        {
                                            SearchStoreOutRecodes();
                                        }));
        }

        private void FrmStoreOutMonitoring_Load(object sender, EventArgs e)
        {
            SearchStoreOutRecodes();
            // 
            // timerAutomatic
            // 
            timerAutomatic = new System.Timers.Timer(Settings.Default.AutomaticOutStoreInterval * 1000);
            timerAutomatic.AutoReset = true;
            timerAutomatic.Elapsed += timerAutomatic_Elapsed;
            // 
            // timerAutoRefresh
            // 
            timerAutoRefresh = new System.Timers.Timer(10000);
            timerAutoRefresh.AutoReset = true;
            timerAutoRefresh.Enabled = true;
            this.timerAutoRefresh.Elapsed += timerAutoRefresh_Elapsed;

            swtAutomaticOut.Visible = Settings.Default.AutomaticOutStore;
            swtAutomaticOut.Value = Settings.Default.AutomaticOutStore;
            timerAutomatic.Enabled = Settings.Default.AutomaticOutStore;
            timerAutomatic.Interval = Settings.Default.AutomaticOutStoreInterval*1000;

        }

        private void SearchStoreOutRecodes()
        {
            _service.CheckAndFixStoreOutBillStatus();
            _errorBills = _service.GetAllStoreOutErrorBills();
            var storeBills = _service.GetAllStoreOutBills().OrderByDescending(p => p.StoreStatusID).ToList();
            btnOut.Enabled = storeBills.Any() && storeBills.Count(p => p.StoreStatusID == ((int)StoreBillStatuses.Processing).ToString()) < Settings.Default.MaxOutTaskCount;
            grdStoreOut.PrimaryGrid.DataSource = storeBills;
            grdStoreOut.PrimaryGrid.SetActive();
            if (grdStoreOut.PrimaryGrid.Rows.Count > 0)
            {
                try
                {
                    if (null != _selectedRow)
                    {
                        grdStoreOut.PrimaryGrid.SetActiveRow(_selectedRow);
                    }
                    else
                    {
                        if(grdStoreOut.PrimaryGrid.Rows.Count > 0)
                        {
                            grdStoreOut.PrimaryGrid.SetActiveRow((GridContainer) grdStoreOut.PrimaryGrid.Rows[0]);
                        }
                    }

                }
                catch (Exception)
                {
                    if(grdStoreOut.PrimaryGrid.Rows.Count > 0)
                    {
                        grdStoreOut.PrimaryGrid.SetActiveRow((GridContainer)grdStoreOut.PrimaryGrid.Rows[0]);
                    }
                }
            }
            grdStoreOut.Update();
            if (storeBills.Count <= 0)
            {
                lblStoreCode.Text = "";
                grdStoreOutDetail.PrimaryGrid.DataSource = null;
                grdStoreOutDetail.Update();
                return;
            }
            else
            {
                BindStoreBillDetails();
            }
        }

        private void grdStoreOut_RowActivated(object sender, GridRowActivatedEventArgs e)
        {
            _selectedRow = e.NewActiveRow as GridRow;
            if (_errorBills.Contains(Convert.ToInt32(_selectedRow[0].Value)))
            {
                btnErrorLog.Enabled = true;
            }
            else
            {
                btnErrorLog.Enabled = false;
            }
            BindStoreBillDetails();
        }

        private void BindStoreBillDetails()
        {
            if(null == grdStoreOut.ActiveGrid || null == grdStoreOut.ActiveGrid.ActiveRow)
            {
                grdStoreOutDetail.PrimaryGrid.DataSource = null;
                grdStoreOut.PrimaryGrid.SetActive();
                try
                {
                    if(null != _selectedRow)
                    {
                        grdStoreOut.PrimaryGrid.SetActiveRow(_selectedRow);
                    }
                    else
                    {
                        if(grdStoreOut.PrimaryGrid.Rows.Count > 0)
                        {
                            grdStoreOut.PrimaryGrid.SetActiveRow((GridContainer)grdStoreOut.PrimaryGrid.Rows[0]);
                        }
                    }

                }
                catch(Exception)
                {
                    if(grdStoreOut.PrimaryGrid.Rows.Count > 0)
                    {
                        grdStoreOut.PrimaryGrid.SetActiveRow((GridContainer)grdStoreOut.PrimaryGrid.Rows[0]);
                    }
                }
            }
            var row = (grdStoreOut.PrimaryGrid.ActiveRow as GridRow);
            if (row != null)
            {
                var storeBill = row.DataItem as StoreBill;
                //if (!string.IsNullOrWhiteSpace(storeBill.StoreStatusID) && Convert.ToInt32(storeBill.StoreStatusID) > 0)
                //{
                //    btnOut.Enabled = false;
                //}
                if(_errorBills.Contains(Convert.ToInt32(row[0].Value)))
                {
                    btnErrorLog.Enabled = true;
                }
                else
                {
                    btnErrorLog.Enabled = false;
                }
                var storeID = storeBill.StoreID;
                lblStoreCode.Text = storeBill.StoreCode;
                var details = _service.GetStoreBillDetails(storeID);

                grdStoreOutDetail.PrimaryGrid.DataSource = details;

                try
                {
                    if(null != _selectedDetailRow)
                    {
                        grdStoreOutDetail.PrimaryGrid.SetActiveRow(_selectedDetailRow);
                    }
                    else
                    {
                        if (grdStoreOutDetail.PrimaryGrid.Rows.Count > 0)
                        {
                            grdStoreOutDetail.PrimaryGrid.SetActiveRow((GridContainer)grdStoreOutDetail.PrimaryGrid.Rows[0]);
                        }
                    }

                }
                catch(Exception)
                {
                    if (grdStoreOutDetail.PrimaryGrid.Rows.Count > 0)
                    {
                        grdStoreOutDetail.PrimaryGrid.SetActiveRow((GridContainer)grdStoreOutDetail.PrimaryGrid.Rows[0]);
                    }

                }
                grdStoreOutDetail.Update();
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {

            if(!Program.CurrentComputerAllowMonitoring())
            {
                MessageBoxEx.Show(this, "出入库监控机器标识未设置，或本机标识与系统设置不匹配，请联系管理员", "系统警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBoxEx.EnableGlass = false;
            if (DialogResult.Yes ==
                MessageBoxEx.Show("确定出库？", "系统确认信息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                /*var row = (grdStoreOut.ActiveGrid.ActiveRow as GridRow);

                if (row != null)
                {
                    var data = row.DataItem as StoreBill;
                    var storeBill = _service.GetStoreBill(data.StoreID);
                    if (null != storeBill && (string.IsNullOrWhiteSpace(storeBill.StoreStatusID) || storeBill.StoreStatusID == ((int) StoreBillStatuses.Waiting).ToString()))
                    {
                        SplitStoreBillDetailsAndUpdateDetailStatuses(storeBill);
                    }

                }*/
                var storeBills = _service.GetAllStoreOutBills().Where(p => p.StoreStatusID == null || p.StoreStatusID == "0").OrderBy(p => p.StoreCode).Take(Settings.Default.MaxOutTaskCount).ToList();
                foreach(var storeBill in storeBills)
                {
                    if(null != storeBill && (string.IsNullOrWhiteSpace(storeBill.StoreStatusID) || storeBill.StoreStatusID == ((int)StoreBillStatuses.Waiting).ToString()))
                    {
                        SplitStoreBillDetailsAndUpdateDetailStatuses(storeBill);
                    }
                }
            }
            SearchStoreOutRecodes();

            if(grdStoreOut.PrimaryGrid.Rows.Count > 0)
            {
                try
                {
                    if(null != _selectedRow)
                    {
                        grdStoreOut.PrimaryGrid.SetActiveRow(_selectedRow);
                    }
                    else
                    {
                        if(grdStoreOut.PrimaryGrid.Rows.Count > 0)
                        {
                            grdStoreOut.PrimaryGrid.SetActiveRow((GridContainer)grdStoreOut.PrimaryGrid.Rows[0]);
                        }
                    }

                }
                catch(Exception)
                {
                    if(grdStoreOut.PrimaryGrid.Rows.Count > 0)
                    {
                        grdStoreOut.PrimaryGrid.SetActiveRow((GridContainer)grdStoreOut.PrimaryGrid.Rows[0]);
                    }
                }
            }

            if(grdStoreOutDetail.PrimaryGrid.Rows.Count > 0)
            {
                try
                {
                    if(null != _selectedDetailRow)
                    {
                        grdStoreOutDetail.PrimaryGrid.SetActiveRow(_selectedDetailRow);
                    }
                    else
                    {
                        if(grdStoreOutDetail.PrimaryGrid.Rows.Count > 0)
                        {
                            grdStoreOutDetail.PrimaryGrid.SetActiveRow((GridContainer)grdStoreOutDetail.PrimaryGrid.Rows[0]);
                        }
                    }

                }
                catch(Exception)
                {
                    if(grdStoreOutDetail.PrimaryGrid.Rows.Count > 0)
                    {
                        grdStoreOutDetail.PrimaryGrid.SetActiveRow((GridContainer)grdStoreOutDetail.PrimaryGrid.Rows[0]);
                    }
                }
            }
            grdStoreOut.Update();
            grdStoreOutDetail.Update();
            timerAutoRefresh.Enabled = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            if(!Program.CurrentComputerAllowMonitoring())
            {
                MessageBoxEx.Show(this, "出入库监控机器标识未设置，或本机标识与系统设置不匹配，请联系管理员", "系统警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SearchStoreOutRecodes();
        }

        private void SplitStoreBillDetailsAndUpdateDetailStatuses(StoreBill storeBill)
        {
            try
            {
                var storeID = storeBill.StoreID;
#if PDA
                var splitOutDetails = _service.SplitStoreOutBillDetailsForPDA(storeID);
                _errorBills = _service.GetAllStoreOutErrorBills();
                if (!_errorBills.Contains(storeID))
                {
                    _service.UpdateStoreBillStatus(storeID, StoreBillStatuses.Processing);
                }
#else
                var splitOutDetails = _service.SplitStoreOutBillDetails(storeID);
                _service.UpdateStoreBillStatus(storeID, StoreBillStatuses.Processing);
#endif
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void swtAutomaticOut_ValueChanged(object sender, EventArgs e)
        {
            if(!Program.CurrentComputerAllowMonitoring())
            {
                MessageBoxEx.Show("出入库监控机器标识未设置，或本机标识与系统设置不匹配，请联系管理员");
                return;
            }
            btnRefresh.Visible = btnOut.Visible = !swtAutomaticOut.Value;
            bar1.Refresh();
            timerAutomatic.Enabled = swtAutomaticOut.Value;

            timerAutoRefresh.Enabled = !timerAutomatic.Enabled;
        }

        private void timerAutomatic_Tick(object sender, EventArgs e)
        {

            if(!Program.CurrentComputerAllowMonitoring())
            {
                MessageBoxEx.Show(this, "出入库监控机器标识未设置，或本机标识与系统设置不匹配，请联系管理员", "系统警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                timerAutomatic.Enabled = false;
                timerAutoRefresh.Enabled = false;
                return;
            }
            SearchStoreOutRecodes();
            if (null == grdStoreOut.ActiveGrid)
            {
                return;
            }
            timerAutomatic.Enabled = false;
            var storeBills = _service.GetAllStoreOutBills().Where(p => p.StoreStatusID == null || p.StoreStatusID == "0").OrderBy(p => p.StoreCode).Take(Settings.Default.MaxOutTaskCount).ToList();
            
            foreach(var storeBill in storeBills)
            {
                if(null != storeBill && (string.IsNullOrWhiteSpace(storeBill.StoreStatusID) || storeBill.StoreStatusID == ((int)StoreBillStatuses.Waiting).ToString()))
                {
                    SplitStoreBillDetailsAndUpdateDetailStatuses(storeBill);
                }
            }
            SearchStoreOutRecodes();
            grdStoreOut.Update();
            grdStoreOutDetail.Update();
            timerAutomatic.Enabled = true;
            /*var row = (grdStoreOut.ActiveGrid.ActiveRow as GridRow);

            if (row != null)
            {
                var storeBill = row.DataItem as StoreBill;
                if (null != storeBill && (string.IsNullOrWhiteSpace(storeBill.StoreStatusID) || storeBill.StoreStatusID == ((int) StoreBillStatuses.Waiting).ToString()))
                {
                    timerAutomatic.Enabled = false;
                    SplitStoreBillDetailsAndUpdateDetailStatuses(storeBill);
                    SearchStoreOutRecodes();
                    grdStoreOut.Update();
                    grdStoreOutDetail.Update();
                    timerAutomatic.Enabled = true;
                }
            }*/
        }

        private void grdStoreOut_RowMouseUp(object sender, GridRowMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (null != e.GridRow)
                {
                    GridRow row = e.GridRow as GridRow;
                    if (null != row)
                    {
                        StoreBill bill = row.DataItem as StoreBill;
                        if (null != bill)
                        {
                            contextMenuBar1.SetContextMenuEx(grdStoreOutDetail, btnMenu);
                        }
                    }
                }
            }
        }

        private void btnManuallyComplete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes ==
                MessageBoxEx.Show(this, "确定要手动完成此出库任务？", "系统确认框", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2))
            {
                StoreBillDetailViewModel billDetail = btnMenu.Tag as StoreBillDetailViewModel;
                if (null != billDetail)
                {
                    _service.ManuallyCompleteOutTask(billDetail.DetailID);
                }
                SearchStoreOutRecodes();
            }
        }

        private void grdStoreOutDetail_RowMouseUp(object sender, GridRowMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (null != e.GridRow)
                {
                    GridRow row = e.GridRow as GridRow;
                    if (null != row)
                    {
                        StoreBillDetailViewModel billDetail = row.DataItem as StoreBillDetailViewModel;
                        if (null != billDetail)
                        {
                            btnMenu.Tag = billDetail;
                            contextMenuBar1.SetContextMenuEx(grdStoreOutDetail, btnMenu);
                        }
                    }
                }
            }
        }

        private void timerAutoRefresh_Tick(object sender, EventArgs e)
        {
            if(!Program.CurrentComputerAllowMonitoring())
            {
                MessageBoxEx.Show(this,"出入库监控机器标识未设置，或本机标识与系统设置不匹配，请联系管理员", "系统警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                timerAutomatic.Enabled = false;
                timerAutoRefresh.Enabled = false;
                return;
            }
            SearchStoreOutRecodes();
        }

        private void grdStoreOutDetail_RowActivated(object sender, GridRowActivatedEventArgs e)
        {
            _selectedDetailRow = e.NewActiveRow as GridRow;
        }

        private void btnErrorLog_Click(object sender, EventArgs e)
        {
            if(grdStoreOut.ActiveGrid != null)
            {
                var row = (grdStoreOut.ActiveGrid.ActiveRow as GridRow);

                if(row != null)
                {
                    var data = row.DataItem as StoreBill;
                    var storeId = data.StoreID;
                    var storeBill = _service.GetStoreBill(storeId);
                    FrmErrorLog frmErrorLog = new FrmErrorLog(storeBill);
                    frmErrorLog.Show(this);
                }
            }
        }

        private void grdStoreOut_GetRowCellStyle(object sender, GridGetRowCellStyleEventArgs e)
        {
            var gridRow = e.GridRow as GridRow;
            if(gridRow != null)
            {
                if(_errorBills.Contains(Convert.ToInt32(gridRow[0].Value)))
                {
                    e.Style.Background = new Background(Color.Red, Color.Red);
                }
            }
        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {
            _service.CheckAndFixStoreOutBillStatus();
        }
    }
}