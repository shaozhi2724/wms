using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace WMS.Windows.App
{
    public partial class FrmDBConnection : Office2007Form
    {
        public FrmDBConnection()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;
        }

        private void chkIntegratedSecurity_CheckedChanged(object sender, EventArgs e)
        {
            // Enable/disable the authentication parameters
            lblUserName.Enabled = !chkIntegratedSecurity.Checked;
            txtUserName.Enabled = !chkIntegratedSecurity.Checked;
            lblPassword.Enabled = !chkIntegratedSecurity.Checked;
            txtPassword.Enabled = !chkIntegratedSecurity.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidatePage(true))
            {
                string sqlConnectionString;
                string efConnectionString;

                if (chkIntegratedSecurity.Checked)
                {
                    sqlConnectionString = DBManager.GenerateSQLConnectionString(txtServerName.Text.Trim(),
                        txtDatabaseName.Text.Trim());
                }
                else
                {
                    sqlConnectionString = DBManager.GenerateSQLConnectionString(txtServerName.Text.Trim(), txtDatabaseName.Text.Trim(), txtUserName.Text.Trim(), txtPassword.Text.Trim());
                }

                efConnectionString = DBManager.GenerateEFConnectionString(sqlConnectionString);

                // Write the connection strings to the application configuration files
                DBManager.WriteSQLConnectionString(sqlConnectionString);
                DBManager.WriteEFConnectionString(efConnectionString);

                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show(this, "数据库连接已创建。\n\n请重新启动程序！", "需要重启程序", MessageBoxButtons.OK, MessageBoxIcon.Asterisk,
                    MessageBoxDefaultButton.Button1);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool ValidatePage(bool triggerErrors)
        {
            // Start off assuming the page IS valid
            bool pageIsValid = true;

            if (string.IsNullOrEmpty(txtServerName.Text.Trim()))
            {
                if (triggerErrors)
                {
                    errorProvider.SetError(txtServerName,
                        "请指定数据库服务器名称！");
                }

                pageIsValid = false;
            }
            else
            {
                errorProvider.SetError(txtDatabaseName, string.Empty);
            }

            if (string.IsNullOrEmpty(txtDatabaseName.Text.Trim()))
            {
                if (triggerErrors)
                {
                    errorProvider.SetError(txtDatabaseName, "请指定数据库名称！");
                }

                pageIsValid = false;
            }
            else
            {
                errorProvider.SetError(txtDatabaseName, string.Empty);
            }

            if (!chkIntegratedSecurity.Checked)
            {
                if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
                {
                    if (triggerErrors)
                    {
                        errorProvider.SetError(txtUserName,
                            "如果未勾选“Windows身份认证”，请指定数据库登录用户名！");
                    }

                    pageIsValid = false;
                }
                else
                {
                    errorProvider.SetError(txtUserName, string.Empty);
                }

                if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
                {
                    if (triggerErrors)
                    {
                        errorProvider.SetError(txtPassword,
                            "如果未勾选“Windows身份认证”，请指定数据库登录密码！");
                    }

                    pageIsValid = false;
                }
                else
                {
                    errorProvider.SetError(txtPassword, string.Empty);
                }
            }

            return pageIsValid;
        }
    }
}
