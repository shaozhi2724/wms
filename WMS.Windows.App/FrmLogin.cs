using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using DevComponents.DotNetBar;
using WMS.App.Services;
using WMS.Model;
using WMS.Windows.App.Properties;

namespace WMS.Windows.App
{
    public partial class FrmLogin : Office2007Form
    {
        private readonly ISecurityService _service;
        public FrmLogin()
        {
            InitializeComponent();
            _service = new SecurityService();
            
            MessageBoxEx.EnableGlass = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidatedUser())
                {
                    Program.IsLoginIn = true;

                    this.Close();
                }
                else
                {
                    Program.IsLoginIn = false;
                    Program.CurrentUser = null;

                    MessageBoxEx.Show(this, "用户名或密码错误，请输入正确的用户名密码。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(this, ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private bool ValidatedUser()
        {
            string userName = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(userName))
            {
                throw new Exception("账号不能为空.");
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("密码不能为空.");
            }
            if (userName == "root" && password == Settings.Default.RootPassword)//root最高权限
            {
                Program.CurrentUser = new WMSUser
                {
                    UserId = Guid.Empty,
                    Username = "系统管理员",
                    Realname = "超级管理员",
                    Rolename = "系统管理员",
                    IsActive = true
                };
                return true;
            }
            if (_service.ValidateUser(userName, password))
            {
                Program.CurrentUser = _service.GetUser(userName);
                return true;
            }
            return false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowUpdateDialog(Version appVersion, Version newVersion, XDocument doc)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<Version, Version, XDocument>(ShowUpdateDialog), appVersion, newVersion, doc);
                return;
            }

            using (UpdateForm f = new UpdateForm())
            {
                f.Text = string.Format(f.Text, Application.ProductName, appVersion);
                f.MoreInfoLink = (string)doc.Root.Element("info");
                f.Info = string.Format(f.Info, newVersion, (DateTime)doc.Root.Element("date"));
                if (f.ShowDialog(this) == DialogResult.OK)
                {
                    Updater.LaunchUpdater(doc);
                    this.Close();
                }
            }
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            if (Settings.Default.AutoCheckForUpdate)
            {
                ThreadPool.QueueUserWorkItem((w) => Updater.CheckForUpdate(ShowUpdateDialog));
            }
            txtUsername.Focus();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            FrmChangePassword doc = new FrmChangePassword();
            doc.ShowDialog(this);
        }
    }
}
