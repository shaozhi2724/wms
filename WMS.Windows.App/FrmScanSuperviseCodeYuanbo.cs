using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using WMS.App.Services;
using WMS.Model;
using Yuanbo.Service.Controls;

namespace WMS.Windows.App
{
    public partial class FrmScanSuperviseCodeYuanbo : Office2007Form
    {
        UCScanCode ucScanCode;
        private IRegulatoryCodeService _service;
        private IStoreBillService _storeBillService;
        private StoreBillOutDetailViewModel _storeBillOutDetail;
        private List<WMSScannedRegulatoryCode> _codes;
        public FrmScanSuperviseCodeYuanbo()
        {
            InitializeComponent();
            MessageBoxEx.EnableGlass = false;
            _service = new RegulatoryCodeService();
            _storeBillService = new StoreBillService();
            _codes = new List<WMSScannedRegulatoryCode>();
        }

        public FrmScanSuperviseCodeYuanbo(StoreBillOutDetailViewModel storeBillDetail)
            : this()
        {
            _storeBillOutDetail = storeBillDetail;
            _codes = _service.GetScannedRegulatoryCodes(_storeBillOutDetail.StoreID);

            var storeBill = _storeBillService.GetStoreBill(_storeBillOutDetail.StoreID);
            string storeOutTypeName = "SalesWareHouseOut";
            
            if (storeBill.StoreTypeID == 1)
            {
                //1	销售出货
                storeOutTypeName = "SalesWareHouseOut";
            }
            else
            {
                //2	采购退货
                storeOutTypeName = "ReturnWareHouseOut";
            }
            ucScanCode = new UCScanCode(_storeBillOutDetail.StoreCode, storeBill.DealerName, "", "WareHouseOut", storeOutTypeName, DateTime.Now);
            ucScanCode.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(ucScanCode);
        }

        /*private void txtRegulatoryCode_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(txtRegulatoryCode.Text))
                {
                    _service.SaveScannedRegulatoryCodes(_storeBillOutDetail,
                                                        txtRegulatoryCode.Text.Trim(),
                                                        Program.CurrentUser.Username);
                }

                _codes = _service.GetScannedRegulatoryCodes(_storeBillOutDetail.StoreID);
                grdCodes.PrimaryGrid.DataSource = _codes;
            }
        }*/

        private void FrmScanSuperviseCode_Load(object sender, EventArgs e)
        {
            //txtProductCode.Text = _storeBillOutDetail.ProductName;
            //txtStoreCode.Text = _storeBillOutDetail.StoreCode;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ucScanCode.SaveInfo();
            this.DialogResult = DialogResult.None;
            Close();
        }
    }
}
