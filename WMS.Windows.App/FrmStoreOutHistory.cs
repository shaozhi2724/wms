using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;
using WMS.App.Services;
using WMS.Model;
using WMS.Windows.App.Properties;

namespace WMS.Windows.App
{
    public partial class FrmStoreOutHistory : Office2007Form
    {
        private IStoreBillService _service;
        private IRegulatoryCodeService _regulatoryCodeService;
        private IDealerService _dealerService;

        private List<RegulatoryCustomer> _customers;
        private List<string> _errorLogs;

        public FrmStoreOutHistory()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;
            _service = new StoreBillService();
            _regulatoryCodeService = new RegulatoryCodeService();
            _dealerService = new DealerService();
        }

        private void FrmStoreOutHistory_Load(object sender, EventArgs e)
        {
            datStoreOutStartDate.Value = DateTime.Today;
            datStoreOutEndDate.Value = DateTime.Today;
            SearchStoreOutRecodes();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchStoreOutRecodes();
        }
        private void SearchStoreOutRecodes()
        {
            string storeOutCode = txtStoreOutCode.Text.Trim();
            string dealerName = txtDealerName.Text.Trim();
            DateTime startDate = datStoreOutStartDate.Value;
            DateTime endDate = datStoreOutEndDate.Value;
            int storeOutType = cbxStoreOutType.SelectedIndex + 1;

            var storeBills = _service.SearchStoreHistories(storeOutCode, storeOutType, dealerName, startDate, endDate, false);

            grdStoreOut.PrimaryGrid.DataSource = storeBills;
            grdStoreOut.Update();
            if (grdStoreOut.PrimaryGrid.Rows.Count > 0)
            {
                grdStoreOut.PrimaryGrid.SetActiveRow((GridContainer)grdStoreOut.PrimaryGrid.Rows[0]);
            }
            BindStoreBillDetails(null);
        }

        private void grdStoreOut_RowActivated(object sender, GridRowActivatedEventArgs e)
        {
            var row = e.NewActiveRow as GridRow;
            BindStoreBillDetails(row);
        }
        private void BindStoreBillDetails(GridRow activeRow)
        {
            if (activeRow == null)
            {
                activeRow = (grdStoreOut.ActiveRow as GridRow);
            }
            if (activeRow != null)
            {
                var storeBill = activeRow.DataItem as StoreBill;

                var storeID = storeBill.StoreID;
                lblStoreCode.Text = storeBill.StoreCode;
                var details = _service.GetStoreBillDetails(storeID);
                grdStoreOutDetail.PrimaryGrid.DataSource = details;
            }
            else
            {
                lblStoreCode.Text = string.Empty;
                grdStoreOutDetail.PrimaryGrid.DataSource = null;
            }
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            _errorLogs = new List<string>();
            SelectedElementCollection selectedElements = grdStoreOut.GetSelectedRows();
            if(selectedElements.Count == 0)
            {
                return;
            }
            _customers = GetCustomers();
            if (null == _customers || !_customers.Any())
            {
                return;
            }


            foreach (GridElement gridElement in selectedElements)
            {
                var row = gridElement as GridRow;
                var storeBill = row.DataItem as StoreBill;
                if (null != storeBill)
                {
                    List<RegulatorySaleOrder> saleOrders = GetSaleCodes(storeBill);
                    if (saleOrders.Any())
                    {
                        if(GenerateAndSaveXmlFiles(saleOrders, storeBill.StoreCode))
                        {
                            _service.UpdateStoreBillRegulatoryStatus(storeBill.StoreID);
                        }
                    }
                }
            }

            if (null != _errorLogs && _errorLogs.Any())
            {
                StringBuilder errorMessage = new StringBuilder("以下单据生成电子监管网文件有错误：\n");
                for (int i = 1; i <= _errorLogs.Count; i++)
                {
                    errorMessage.AppendFormat("\n{0} - {1}", i, _errorLogs[i - 1]);
                }
                MessageBoxEx.Show(this,
                                  errorMessage.ToString(),
                                  "生成错误",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);

                if(_errorLogs.Any(p => p.Contains("未找到相应的监管网往来单位")))
                {
                    FrmRegulatoryCustomer doc = new FrmRegulatoryCustomer();
                    if(DialogResult.OK == doc.ShowDialog(this))
                    {
                        btnGen_Click(sender, e);
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        private List<RegulatoryCustomer> GetCustomers()
        {
            List<RegulatoryCustomer> customers = new List<RegulatoryCustomer>();
            int index = 1;
            string customerFile = Path.Combine(Settings.Default.OutDataFolder, "Customers.txt");
            if(!File.Exists(customerFile))
            {
                MessageBoxEx.Show(this,
                                  string.Format("Customers.txt文件不存在，请检查 {0} 是否存在！", customerFile),
                                  "文件错误",
                                  MessageBoxButtons.OK);
                return null;
            }
            List<string> lines = File.ReadAllLines(customerFile, Encoding.Default).ToList();
            foreach (string line in lines)
            {
                string customerName = string.Empty;
                string customerSpell = string.Empty;
                string customerCode = string.Empty;
                string contactPerson = string.Empty;
                string[] columns = line.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);
                if (columns[0].Contains(" ") || columns[0].Contains("　"))
                {
                    string[] subColumns = columns[0].Split(new[] {' ', '　'}, StringSplitOptions.RemoveEmptyEntries);
                    customerName = subColumns[0];
                    if (subColumns.Length == 2)
                    {
                        contactPerson = subColumns[1];
                    }
                }
                else
                {
                    customerName = columns[0];
                }
                customerSpell = columns[1];
                customerCode = columns[2];

                customers.Add(new RegulatoryCustomer
                              {
                                  CustomerId = index,
                                  CustomerName = customerName,
                                  CustomerSpell = customerSpell,
                                  CustomerCode = customerCode,
                                  ContactPerson = contactPerson
                              });
                index++;
            }
            return customers;
        }

        private List<RegulatorySaleOrder> GetSaleCodes(StoreBill storeBill)
        {
            string customerCode = string.Empty;
            List<RegulatorySaleOrder> saleOrders = new List<RegulatorySaleOrder>();
            var regulatoryCodes = _regulatoryCodeService.GetScannedRegulatoryCodes(storeBill.StoreID);
            if(!regulatoryCodes.Any())
            {
                _errorLogs.Add(string.Format("出库单 {0} 中所有药品均未扫描相应的电子监管码", storeBill.StoreCode));
            }
            var customer = _customers.FirstOrDefault(p => p.CustomerName == storeBill.DealerName);
            if(null == customer)
            {
                var dealer = _dealerService.GetDealerById(storeBill.DealerID.Value);
                if(null != dealer)
                {
                    customer = _customers.FirstOrDefault(p => p.CustomerName == dealer.Reservation9);
                }
            }
            if(null == customer)
            {
                _errorLogs.Add(string.Format("出库单 {0} 未找到相应的监管网往来单位 “{1}”", storeBill.StoreCode, storeBill.DealerName));
            }
            else
            {
                customerCode = customer.CustomerCode;
                saleOrders = (from s in regulatoryCodes
                              select new RegulatorySaleOrder
                                     {
                                         CorpOrderID = storeBill.StoreCode,
                                         Code = s.ScannedRegulatoryCode,
                                         Actor = s.CreateUsername,
                                         ActDate = s.CreateDate.HasValue ? s.CreateDate.Value.Date : DateTime.Today,
                                         CorpProductID = string.Empty,
                                         CorpBatchNo = string.Empty,
                                         ToCorpID = customerCode
                                     }).ToList();
            }

            return saleOrders;
        }

        private bool GenerateAndSaveXmlFiles(List<RegulatorySaleOrder> saleOrders, string orderCode)
        {
            string templateFileName = "P_SalWHO_Template.xml";
            string templateFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, templateFileName);
            if(!File.Exists(templateFile))
            {
                MessageBoxEx.Show(this,
                                  string.Format("XML 模板文件不存在，请检查 {0} 是否存在！", templateFile),
                                  "文件生成错误",
                                  MessageBoxButtons.OK);
                return false;
            }

            XElement root = XElement.Load(templateFile);
            var eventNode = root.Descendants("DataField").First();
            var elements = from c in saleOrders
                           select new XElement("Data",
                                               new XAttribute("CorpOrderID", c.CorpOrderID),
                                               new XAttribute("Code", c.Code),
                                               new XAttribute("Actor", c.Actor),
                                               new XAttribute("ActDate", c.ActDate.ToString("yyyy-MM-dd")),
                                               new XAttribute("CorpProductID", c.CorpProductID),
                                               new XAttribute("CorpBatchNo", c.CorpBatchNo),
                                               new XAttribute("ToCorpID", c.ToCorpID)
                               );
            eventNode.ReplaceAll(elements);
            string saveFileName = templateFileName.Replace("_Template.xml", string.Format("_{0}.xml", orderCode));
            string saveFile = Path.Combine(Settings.Default.InDataFolder, saveFileName);
            root.Save(saveFile);
            return true;
        }

        private void grdStoreOut_GetRowCellStyle(object sender, GridGetRowCellStyleEventArgs e)
        {
            var gridRow = e.GridRow as GridRow;
            if(gridRow != null)
            {
                if(null != gridRow["colExportStatus"].Value && !string.IsNullOrWhiteSpace(gridRow["colExportStatus"].Value.ToString()))
                {
                    e.Style.Background = new Background(Color.Red, Color.Red);
                }
            }
        }
    }

    public class RegulatoryCustomer
    {
        public int CustomerId
        {
            get;
            set;
        }
        public string CustomerCode
        {
            get;
            set;
        }
        public string CustomerName
        {
            get;
            set;
        }
        public string CustomerSpell
        {
            get;
            set;
        }
        public string ContactPerson
        {
            get;
            set;
        }
        public int DealerID { get; set; }
        public string DealerName { get; set; }
    }
    public class RegulatorySaleOrder
    {
        public string CorpOrderID
        {
            get;
            set;
        }
        public string Code
        {
            get;
            set;
        }
        public string Actor
        {
            get;
            set;
        }
        public DateTime ActDate
        {
            get;
            set;
        }
        public string CorpProductID
        {
            get;
            set;
        }
        public string CorpBatchNo
        {
            get;
            set;
        }
        public string ToCorpID
        {
            get;
            set;
        }
    }
}
