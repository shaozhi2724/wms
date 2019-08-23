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
using WMS.Windows.App.Properties;

namespace WMS.Windows.App
{
    public partial class FrmExportTickets : Office2007Form
    {
        private IRegulatoryCodeService _service;
        public FrmExportTickets()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;
            _service = new RegulatoryCodeService();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var dialogResult = saveFileDialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                var filename = saveFileDialog.FileName;
                var exportTickets = _service.GenExportTickets();
                var codes = exportTickets.Select(p => p.RegulatoryCode).Distinct().ToList();

                //Resources.上传单据
                HSSFWorkbook hssfworkbook = new HSSFWorkbook(new MemoryStream(Resources.上传单据));
                HSSFSheet sheet1 = (HSSFSheet) hssfworkbook.GetSheet("Sheet1");
                int rowCount = exportTickets.Count;

                for (int i = 1; i <= rowCount; i++)
                {
                    var ticket = exportTickets[i - 1];
                    IRow row = sheet1.CreateRow(i);
                    for (int j = 0; j < 15; j++)
                    {
                        row.CreateCell(j, CellType.STRING);
                    }
                    row.Cells[0].SetCellValue(ticket.RegulatoryCode);
                    row.Cells[1].SetCellValue(ticket.CorpCode);
                    row.Cells[2].SetCellValue(ticket.ReviewCode);
                    row.Cells[3].SetCellValue(i.ToString());
                    row.Cells[4].SetCellValue(ticket.DealerCode);
                    row.Cells[5].SetCellValue(ticket.DealerName);
                    row.Cells[6].SetCellValue(ticket.DealerAddress);
                    row.Cells[7].SetCellValue(ParseStoreTypeCode(ticket.StoreTypeName));
                    row.Cells[8].SetCellValue(ticket.ReviewDate.ToString("yyyyMMdd"));
                    row.Cells[9].SetCellValue(ticket.ProductCode);
                    row.Cells[10].SetCellValue(ticket.BatchNo);
                    row.Cells[11].SetCellValue(string.Format("{0:00}",ticket.Amount));
                    row.Cells[12].SetCellValue(ticket.ProduceDate.ToString("yyyyMMdd"));
                    row.Cells[13].SetCellValue(ticket.ValidateDate.ToString("yyyyMMdd"));
                    row.Cells[14].SetCellValue(ticket.ReviewRemark);
                }

                FileStream file = new FileStream(filename, FileMode.Create);
                hssfworkbook.Write(file);
                file.Close();

                _service.UpdateCodesStatusToExported(codes);

                MessageBoxEx.Show("导出成功!", "系统提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(string.Format("导出失败！\n 错误信息：{0}", ex.Message), "错误信息", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private string ParseStoreTypeCode(string storeTypeName)
        {
            string code = string.Empty;
            Dictionary<string, string> dic = new Dictionary<string, string>
            {
                {"销售出库","01"},
                {"销售出货","01"},
                {"采购入库","02"},
                {"采购入货","02"},
                {"采购进货","02"},
                {"盘盈","03"},
                {"盘亏","04"},
                {"销售退货","05"},
                {"采购退货","06"}
            };

            dic.TryGetValue(storeTypeName, out code);
            return code;
        }

        private void FrmExportTickets_Load(object sender, EventArgs e)
        {
            RegulatoryCodeStatisticViewMode statistic = _service.GetStatistics();
            lblTotalCodeCount.Text = statistic.TotalCount.ToString();
            lblUsedCodesCount.Text = statistic.UsedCount.ToString();
            lblExportedCodesCount.Text = statistic.ExportedCount.ToString();
            lblCanUsedCodesCount.Text = statistic.UnUsedCount.ToString();
            btnExport.Enabled = statistic.UsedCount > 0;
        }
    }
}
