using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using System.Data.SqlClient;
using System.Linq;
using WMS.SmartDevice.App.Models;
using WMS.SmartDevice.App.Utils;

namespace WMS.SmartDevice.App
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void muSetting_Click(object sender, EventArgs e)
        {
            FrmSetting doc = FrmSetting.Instance();
            doc.LoadSettings();
            doc.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isValid = false;
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {

                MessageBox.Show("请输入帐号！");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("请输入密码！");
                return;
            }
            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var users = conn.Query<WMSUser>("SELECT UserId,Username,Realname,Password,Rolename,IsActive FROM WMS_User WHERE LOWER(Username)=@Username", new { Username = username.ToLower() })
                        .ToList();
                conn.Close();

                if (!users.Any())
                {
                    MessageBox.Show("账号不存在！");
                    return;
                }
                var user = users.First();
                if (!user.IsActive)
                {
                    MessageBox.Show("账号已被禁用，无法登录。请联系管理员。");
                    return;
                }
                isValid = GetEncryptPassword(password) == user.Password;
                if (isValid)
                {
                    Program.CurrentUser = user;
                    FrmMain.Instance().Show();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("账号或密码错误，请输入正确的账号密码。", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                }
            }

        }
        public string GetEncryptPassword(string input)
        {
            using (MD5 md5 = new MD5CryptoServiceProvider())
            {
                byte[] bytes_md5_in = UTF8Encoding.Default.GetBytes(input);
                byte[] bytes_md5_out = md5.ComputeHash(bytes_md5_in);
                return BitConverter.ToString(bytes_md5_out).Replace("-", "");
            }
        }

        private void muExit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes ==
                MessageBox.Show("确定退出DQS RF扫描系统？", "退出确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1))
            {
                Application.Exit();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            lblDeviceNumber.Text = DeviceHelper.GetDeviceId();
        }
    }
}