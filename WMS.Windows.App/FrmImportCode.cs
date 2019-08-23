using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using DevComponents.DotNetBar;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using WMS.App.Services;

namespace WMS.Windows.App
{
    public partial class FrmImportCode : Office2007Form
    {
        private IRegulatoryCodeService _service;
        private List<CodeViewModel> _codes;
        public FrmImportCode()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;
            _service = new RegulatoryCodeService();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog(this);

        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            var file = openFileDialog.FileName;
            txtFile.Text = file;

            LoadExcelData(file);
        }

        private void LoadExcelData(string filename)
        {
            _codes = new List<CodeViewModel>();
            try
            {
                using (FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    HSSFWorkbook hssfworkbook = new HSSFWorkbook(file);
                    ISheet sheet1 = hssfworkbook.GetSheet("Sheet1");
                    int rowCount = (sheet1 as HSSFSheet).LastRowNum;
                    for (int i = 1; i <= rowCount; i++)
                    {
                        var code = sheet1.GetRow(i).GetCell(0).StringCellValue;
                        if (!string.IsNullOrWhiteSpace(code))
                        {
                            _codes.Add(new CodeViewModel
                            {
                                Index = i,
                                Code = code
                            });
                        }
                    }
                    grdCodes.PrimaryGrid.DataSource = _codes;
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
            btnImport.Enabled = _codes.Any();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CorpCode.dat");
            if (!File.Exists(file))
            {
                MessageBoxEx.Show("请先输入企业编码！");
                FrmCorpCodeSetting doc = new FrmCorpCodeSetting();
                if (System.Windows.Forms.DialogResult.Yes == doc.ShowDialog(this))
                {
                    ImportCodes(file);
                }
            }
            else
            {
                ImportCodes(file);
            }
        }

        private void ImportCodes(string file)
        {
            string corpCode = File.ReadAllText(file);
            var importedCodes = _service.ImportCodes(_codes, corpCode);
            if (importedCodes > 0)
            {
                MessageBoxEx.Show(string.Format("流通监管码导入成功！共导入 {0} 条记录！", importedCodes));
                _codes = new List<CodeViewModel>();
                grdCodes.PrimaryGrid.DataSource = _codes;
                txtFile.Text = string.Empty;
                btnImport.Enabled = false;
            }
            else
            {
                MessageBoxEx.Show("流通监管码导入失败！数据重复导入，请检查文件后重试!");
            }
        }
    }

    
}
