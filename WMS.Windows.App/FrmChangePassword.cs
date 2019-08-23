using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using WMS.App.Services;
using WMS.Model;
using WMS.Windows.App.Properties;

namespace WMS.Windows.App
{
    public partial class FrmChangePassword : Office2007Form
    {
        private readonly ISecurityService _service;
        public FrmChangePassword()
        {
            InitializeComponent();
            _service = new SecurityService();
            
            MessageBoxEx.EnableGlass = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidatePage())
                {
                    var user = _service.GetUser(txtUsername.Text.Trim());
                    if (null == user)
                    {
                        MessageBoxEx.Show("用户名不存在，请重新输入", "系统提示");
                        return;
                    }
                    if (user.Password != _service.GetEncryptPassword(txtOldPassword.Text.Trim()))
                    {
                        MessageBoxEx.Show("旧密码错误，请重新输入", "系统提示");
                        return;
                    }
                    _service.ChangePassword(user.UserId, txtNewPassword.Text.Trim());
                    this.DialogResult = DialogResult.Yes;
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(this, ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private bool ValidatePage()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBoxEx.Show("请输入用户名", "系统提示");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtOldPassword.Text))
            {
                MessageBoxEx.Show("请输入旧密码", "系统提示");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                MessageBoxEx.Show("请输入新密码", "系统提示");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBoxEx.Show("请输入确认密码", "系统提示");
                return false;
            }
            if (txtNewPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                MessageBoxEx.Show("新密码与确认密码不一致，请重新输入", "系统提示");
                return false;
            }

            
            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
    }
}
