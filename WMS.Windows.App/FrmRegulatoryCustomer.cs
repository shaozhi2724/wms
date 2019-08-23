using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using WMS.Windows.App.Properties;
using WMS.App.Services;
using WMS.Model;

namespace WMS.Windows.App
{
    public partial class FrmRegulatoryCustomer : Office2007Form
    {
        private IDealerService _dealerService;
        private List<RegulatoryCustomer> _customers;

        public FrmRegulatoryCustomer()
        {
            InitializeComponent();
            MessageBoxEx.EnableGlass = false;
            _dealerService = new DealerService();

            _customers = GetCustomers();
        }

        private void FrmRegulatoryCustomer_Load(object sender, EventArgs e)
        {
            cbxCustomerType.SelectedIndex = 1;
            //LoadSettings();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
            MessageBoxEx.EnableGlass = false;
            MessageBoxEx.Show(this,
                              "往来单位匹配成功！",
                              "系统提示",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Asterisk,
                              MessageBoxDefaultButton.Button1);

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private List<RegulatoryCustomer> GetCustomers()
        {
            List<RegulatoryCustomer> customers = new List<RegulatoryCustomer>();
            int index = 1;
            string customerFile = Path.Combine(Settings.Default.OutDataFolder, "Customers.txt");
            if (!File.Exists(customerFile))
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

            var dealers = _dealerService.GetAllDealers();
            
            //customer.txt中有，dealer中有或没有
            var customerToDealers = from c in customers
                                    from d in dealers
                                    where c.CustomerName == d.DealerName || c.CustomerName == d.Reservation9
                                    select new RegulatoryCustomer
                                           {
                                               CustomerId = c.CustomerId,
                                               CustomerName = c.CustomerName,
                                               CustomerSpell = c.CustomerSpell,
                                               CustomerCode = c.CustomerCode,
                                               ContactPerson = c.ContactPerson,
                                               DealerID = d != null ? d.DealerID : 0,
                                               DealerName = d != null ? d.DealerName : ""
                                           };

            //customer.txt中没有，dealer中有
            //var dealerToCustomers = from d in dealers
            //                        from c in customers
            //                        where d.DealerName == c.CustomerName || c.CustomerName == d.Reservation9
            //                        select new RegulatoryCustomer
            //                               {
            //                                   CustomerId = c != null ? c.CustomerId : 0,
            //                                   CustomerName = c != null ? c.CustomerName : (d != null ? d.Reservation9 : ""),
            //                                   CustomerSpell = c != null ? c.CustomerSpell : "",
            //                                   CustomerCode = c != null ? c.CustomerCode : "",
            //                                   ContactPerson = c != null ? c.ContactPerson : "",
            //                                   DealerID = d.DealerID,
            //                                   DealerName = d.DealerName
            //                               };
            var dealerToCustomers = from d in dealers
                                    join c in customers on d.DealerName equals c.CustomerName into g
                                    from s in g.DefaultIfEmpty()
                                    select new RegulatoryCustomer
                                    {
                                        CustomerId = s != null ? s.CustomerId : 0,
                                        CustomerName = s != null ? s.CustomerName : d.Reservation9,
                                        CustomerSpell = s != null ? s.CustomerSpell : "",
                                        CustomerCode = s != null ? s.CustomerCode : "",
                                        ContactPerson = s != null ? s.ContactPerson : "",
                                        DealerID = d.DealerID,
                                        DealerName = d.DealerName
                                    };

            var allCustomers = customerToDealers
                .Union(dealerToCustomers)
                .Distinct(new Compare<RegulatoryCustomer>(
                              (x, y) => (null != x && null != y)
                                        && (x.CustomerName == y.CustomerName)
                                        && (x.DealerName == y.DealerName)))
                .OrderBy(p => p.DealerName)
                .ThenBy(p => p.CustomerName)
                .ToList();

            return allCustomers;
        }

        private void LoadSettings()
        {
            string name = txtName.Text.Trim();

            var customerList = _customers.Where(p => !string.IsNullOrWhiteSpace(p.CustomerName)).ToList();
            if(cbxCustomerType.SelectedIndex == 0)
            {
                var regulatoryCustomers = _customers
                    .Where(p => !string.IsNullOrWhiteSpace(p.CustomerName) && p.CustomerName == p.DealerName)
                    .Where(p => p.DealerName.Contains(name) || p.CustomerName.Contains(name))
                    .ToList();
                grdCustomers.PrimaryGrid.DataSource = regulatoryCustomers;

                grdCustomers.PrimaryGrid.Columns["colCustomerCode"].Visible = true;
            }
            else
            {
                var regulatoryCustomers = _customers
                    .Where(p => !string.IsNullOrWhiteSpace(p.DealerName) && (string.IsNullOrWhiteSpace(p.CustomerName) || (p.CustomerName != p.DealerName)))
                    .Where(p => p.DealerName.Contains(name) || (!string.IsNullOrWhiteSpace(p.CustomerName) && p.CustomerName.Contains(name)))
                    .ToList();
                grdCustomers.PrimaryGrid.DataSource = regulatoryCustomers;
                grdCustomers.PrimaryGrid.Columns["colCustomerCode"].Visible = false;
            }
            dealerBindingSource.DataSource = customerList;
            grdCustomers.PrimaryGrid.Columns["colCustomerName"].EditorType = typeof(DealerComboBox);
            grdCustomers.PrimaryGrid.Columns["colCustomerName"].EditorParams = new object[] { dealerBindingSource, "CustomerName", "CustomerName" };
            
        }

        private void SaveSettings()
        {
            Dictionary<int, string> customers = new Dictionary<int, string>();
            foreach (GridElement row in grdCustomers.PrimaryGrid.Rows)
            {
                var gridRow = (row as GridRow);
                if (gridRow != null)
                {
                    if (gridRow.RowDirty)
                    {
                        var data = gridRow.DataItem as RegulatoryCustomer;
                        if (!customers.ContainsKey(data.DealerID))
                        {
                            customers.Add(data.DealerID, data.CustomerName);
                        }
                    }
                }
            }
            _dealerService.UpdateRegulatoryCustomerName(customers);
        }

        private void cbxCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            LoadSettings();
        }
    }

    internal class DealerComboBox : GridComboBoxExEditControl
    {
        public DealerComboBox(BindingSource bind, string displayField, string valueField)
        {
            DataSource = bind;
            DisplayMember = displayField;
            ValueMember = valueField;
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }

    }


    public delegate bool EqualsComparer<T>(T x, T y);

    public class Compare<T> : IEqualityComparer<T>
    {
        private EqualsComparer<T> _equalsComparer;

        public Compare(EqualsComparer<T> equalsComparer)
        {
            this._equalsComparer = equalsComparer;
        }

        public bool Equals(T x, T y)
        {
            if(null != this._equalsComparer)
                return this._equalsComparer(x, y);
            else
                return false;
        }

        public int GetHashCode(T obj)
        {
            return obj.ToString().GetHashCode();
        }
    }
}