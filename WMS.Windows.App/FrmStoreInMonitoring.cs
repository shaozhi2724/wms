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
    public partial class FrmStoreInMonitoring : Office2007Form
    {
        private GridRow _selectedRow;
        private GridRow _selectedDetailRow;
        private IStoreBillService _service;
        private System.Timers.Timer timerAutoRefresh;
        public FrmStoreInMonitoring()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;
            _service = new StoreBillService();

            if(!Program.CurrentComputerAllowMonitoring())
            {
                MessageBoxEx.Show(this, "出入库监控机器标识未设置，或本机标识与系统设置不匹配，请联系管理员", "系统警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void FrmStoreInMonitoring_Load(object sender, EventArgs e)
        {

            btnPrint.Visible = Settings.Default.PrintCargoBarcode;
            SearchStoreInRecodes();
            // 
            // timerAutoRefresh
            // 
            timerAutoRefresh = new System.Timers.Timer(10000);
            timerAutoRefresh.AutoReset = true;
            timerAutoRefresh.Enabled = true;
            this.timerAutoRefresh.Elapsed += timerAutoRefresh_Elapsed;
        }

        private void SearchStoreInRecodes()
        {
            _service.CheckAndFixStoreInBillStatus();
            var storeBills = _service.GetAllStoreInBills();
            if (!Settings.Default.SystemSignStoreInPosition)
            {
                btnIn.Enabled = storeBills.Any();
            }
            else
            {
                btnIn.Enabled = storeBills.Any() && storeBills.All(p => p.StoreStatusID == ((int)StoreBillStatuses.Waiting).ToString());
            }

            grdStoreOut.PrimaryGrid.DataSource = storeBills;
            grdStoreOut.PrimaryGrid.SetActive();
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
            grdStoreOut.Update();
            BindStoreBillDetails();
        }

        private void grdStoreOut_RowActivated(object sender, GridRowActivatedEventArgs e)
        {
            _selectedRow = e.NewActiveRow as GridRow;
            btnPrint.Enabled = false;
            BindStoreBillDetails();
        }

        private void BindStoreBillDetails()
        {
            if (null == grdStoreOut.ActiveGrid || null == grdStoreOut.ActiveGrid.ActiveRow)
            {
                grdStoreOutDetail.PrimaryGrid.DataSource = null;
                btnPrint.Enabled = false;
                return;
            }

            var row = (grdStoreOut.ActiveGrid.ActiveRow as GridRow);

            if (row != null)
            {
                var storeBill = row.DataItem as StoreBill;
                if (!string.IsNullOrWhiteSpace(storeBill.StoreStatusID) && Convert.ToInt32(storeBill.StoreStatusID) > 0)
                {
                    btnIn.Enabled = false;
                }
                else
                {
                    btnIn.Enabled = true;
                }
                var storeID = storeBill.StoreID;
                lblStoreCode.Text = storeBill.StoreCode;
                var details = _service.GetStoreBillInDetails(storeID);
                grdStoreOutDetail.PrimaryGrid.DataSource = details;
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
                grdStoreOutDetail.Update();
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SearchStoreInRecodes();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

            if(!Program.CurrentComputerAllowMonitoring())
            {
                MessageBoxEx.Show(this, "出入库监控机器标识未设置，或本机标识与系统设置不匹配，请联系管理员", "系统警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBoxEx.EnableGlass = false;
            if (DialogResult.Yes ==
                MessageBoxEx.Show("确定入库？", "系统确认信息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                var row = (grdStoreOut.ActiveGrid.ActiveRow as GridRow);

                if (row != null)
                {
                    var data = row.DataItem as StoreBill;

                    var storeBill = _service.GetStoreBill(data.StoreID);
                    if (null != storeBill && (string.IsNullOrWhiteSpace(storeBill.StoreStatusID) || storeBill.StoreStatusID == ((int)StoreBillStatuses.Waiting).ToString()))
                    {
                        SplitStoreBillDetailsAndUpdateDetailStatuses(storeBill);
                    }

                }
            }
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
            SearchStoreInRecodes();
            timerAutoRefresh.Enabled = true;
        }

        private void SplitStoreBillDetailsAndUpdateDetailStatuses(StoreBill storeBill)
        {
            try
            {
                var storeCode = storeBill.StoreCode;
                var storeID = storeBill.StoreID;
                bool systemSignPosition = Settings.Default.SystemSignStoreInPosition;
                bool printCargoBarcode = Settings.Default.PrintCargoBarcode;
                _service.CheckRegulatoryCode(Settings.Default.AllowNoCodeStoreIn, storeCode);
                var splitInDetails = _service.SplitStoreInBillDetails(storeID, systemSignPosition, printCargoBarcode);
                _service.UpdateStoreInBillStatus(storeID, StoreBillStatuses.Processing);
                _service.RelateRegulatoryCode(Settings.Default.AllowNoCodeStoreIn, storeCode);
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void grdStoreOutDetail_RowActivated(object sender, GridRowActivatedEventArgs e)
        {
            _selectedDetailRow = e.NewActiveRow as GridRow;
            var row = e.NewActiveRow as GridRow;
            if (null != row)
            {
                var model = row.DataItem as StoreInBillDetailViewModel;
                if (null != model && !string.IsNullOrWhiteSpace(model.StructureCode))
                {
                    btnPrint.Enabled = true;
                }
                else
                {
                    btnPrint.Enabled = false;
                }
            }
            else
            {
                btnPrint.Enabled = false;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var row = grdStoreOutDetail.ActiveRow as GridRow;
            if (null != row)
            {
                var model = row.DataItem as StoreInBillDetailViewModel;
                if (null != model && !string.IsNullOrWhiteSpace(model.StructureCode))
                {
                    //MessageBox.Show(string.Format("{0}-{1}", model.StoreID, model.DetailID));
                    FrmCargoBarcodePrint doc = new FrmCargoBarcodePrint(model.StoreID, model.DetailID);
                    doc.ShowDialog(this);
                }
            }
        }

        private void timerAutoRefresh_Tick(object sender, EventArgs e)
        {

            if(!Program.CurrentComputerAllowMonitoring())
            {
                MessageBoxEx.Show(this, "出入库监控机器标识未设置，或本机标识与系统设置不匹配，请联系管理员", "系统警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                timerAutoRefresh.Enabled = false;
                return;
            }
            SearchStoreInRecodes();
        }
        void timerAutoRefresh_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if(!Program.CurrentComputerAllowMonitoring())
            {
                MessageBoxEx.Show(this, "出入库监控机器标识未设置，或本机标识与系统设置不匹配，请联系管理员", "系统警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                timerAutoRefresh.Enabled = false;
                return;
            }
            while(!this.IsHandleCreated)
            {
            }
            this.BeginInvoke(new Action(() =>
            {
                SearchStoreInRecodes();
            }));
        }

    }
}