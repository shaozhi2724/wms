using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using WMS.App.Services;
using WMS.Model;

namespace WMS.Windows.App
{
    public partial class FrmUserManagement : Office2007Form
    {
        private ISecurityService _service;
        public FrmUserManagement()
        {
            InitializeComponent();
            MessageBoxEx.EnableGlass = false;
            _service = new SecurityService();
        }

        private void FrmUserManagement_Load(object sender, EventArgs e)
        {
            BindUsers();
        }

        private void BindUsers()
        {
            var users = _service.GetAllUsers();
            grdUsers.PrimaryGrid.DataSource = users;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindUsers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmUserEditor editor = new FrmUserEditor();
            if (DialogResult.Yes == editor.ShowDialog(this))
            {
                BindUsers();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var row = (grdUsers.ActiveGrid.ActiveRow as GridRow);

            if (row != null)
            {
                FrmUserEditor editor = new FrmUserEditor(row.DataItem as WMSUser);
                if (DialogResult.Yes == editor.ShowDialog(this))
                {
                    BindUsers();
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            var row = (grdUsers.ActiveGrid.ActiveRow as GridRow);

            if (row != null)
            {
                var user = row.DataItem as WMSUser;
                if (user != null)
                {
                    MessageBoxEx.EnableGlass = false;
                    if (DialogResult.Yes ==
                        MessageBoxEx.Show(string.Format("确定禁用 {0}？", user.Realname), "系统确认信息", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning))
                    {
                        var userId = user.UserId;
                        _service.DeactiveUser(userId);
                    }
                    BindUsers();

                }
            }
        }
    }
}
