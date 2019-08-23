using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using WMS.App.Services;
using WMS.Model;

namespace WMS.Windows.App
{
    public partial class FrmUserEditor : Office2007Form
    {
        private Dictionary<string, string> _roles = new Dictionary<string, string>
        {
            {"系统管理员", "系统管理员"},
            {"仓库管理员", "仓库管理员"},
            {"拣货员", "拣货员"},
            {"复核员", "复核员"},
        };
        private ISecurityService _service;
        public FrmUserEditor()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;

            _service = new SecurityService();
        }
        public FrmUserEditor(WMSUser user)
            : this()
        {
            btnSave.Tag = user;
        }

        private void BindRoles()
         {
             cbxRole.DataSource = new BindingSource(_roles, null);
             cbxRole.DisplayMember = "Value";
             cbxRole.ValueMember = "Key";
         }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidatePage())
            {
                return;
            }
            var user = btnSave.Tag as WMSUser;
            if (null == user)
            {
                user = new WMSUser
                {
                    UserId = Guid.NewGuid(),
                    Username = txtUsername.Text.Trim(),
                    Realname = txtRealname.Text.Trim(),
                    Password = _service.GetEncryptPassword(txtPassword.Text.Trim()),
                    Rolename = cbxRole.SelectedValue.ToString(),
                    IsActive = swtIsActive.Value,
                    CreateDate = DateTime.Now
                };
            }
            else
            {
                user.Username = txtUsername.Text.Trim();
                if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    user.Password = _service.GetEncryptPassword(txtPassword.Text.Trim());
                }
                user.Realname = txtRealname.Text.Trim();
                user.Rolename = cbxRole.SelectedValue.ToString();
                user.IsActive = swtIsActive.Value;
                user.ModifyDate = DateTime.Now;
            }
            _service.SaveUser(user);
            this.DialogResult = DialogResult.Yes;
        }

        private bool ValidatePage()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBoxEx.Show("请输入用户名", "系统提示");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtRealname.Text))
            {
                MessageBoxEx.Show("请输入姓名", "系统提示");
                return false;
            }
            if (null == btnSave.Tag)
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBoxEx.Show("请输入密码", "系统提示");
                    return false;
                }
                if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
                {
                    MessageBoxEx.Show("请输入确认密码", "系统提示");
                    return false;
                }
                if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
                {
                    MessageBoxEx.Show("密码与确认密码不一致，请重新输入", "系统提示");
                    return false;
                }
            }
            else
            {
                if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
                {
                    MessageBoxEx.Show("密码与确认密码不一致，请重新输入", "系统提示");
                    return false;
                }
            }
            return true;
        }


        private void FrmUserEditor_Load(object sender, EventArgs e)
        {
            BindRoles();
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            var user = btnSave.Tag as WMSUser;
            if (null != user)
            {
                txtUsername.Text = user.Username;
                txtRealname.Text = user.Realname;
                cbxRole.SelectedValue = user.Rolename;
                swtIsActive.Value = user.IsActive;
            }

        }
    }
}