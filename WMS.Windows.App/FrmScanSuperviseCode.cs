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

namespace WMS.Windows.App
{
    public partial class FrmScanSuperviseCode : Office2007Form
    {
        private IRegulatoryCodeService _service;
        private StoreBillOutDetailViewModel _storeBillOutDetail;
        private List<WMSScannedRegulatoryCode> _codes;
        public FrmScanSuperviseCode()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;
            _service = new RegulatoryCodeService();
            _codes = new List<WMSScannedRegulatoryCode>();
        }

        public FrmScanSuperviseCode(StoreBillOutDetailViewModel storeBillDetail) :this()
        {
            _storeBillOutDetail = storeBillDetail;
            _codes = _service.GetScannedRegulatoryCodes(_storeBillOutDetail.StoreID);
        }

        private void txtRegulatoryCode_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
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
        }

        private void FrmScanSuperviseCode_Load(object sender, EventArgs e)
        {
            grdCodes.PrimaryGrid.DataSource = _codes;
            txtProductCode.Text = _storeBillOutDetail.ProductName;
            txtStoreCode.Text = _storeBillOutDetail.StoreCode;
            txtRegulatoryCode.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            Close();
        }
    }
}
