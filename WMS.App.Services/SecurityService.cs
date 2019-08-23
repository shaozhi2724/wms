using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using WMS.Model;

namespace WMS.App.Services
{
    public class SecurityService : ISecurityService
    {
        /// <summary>
        /// ��ȡMD5�����ַ���
        /// </summary>
        /// <param name="input">Ҫ�ӽ����ܵ��ַ���</param>
        /// <returns>���ܺ���ַ���</returns>
        public string GetEncryptPassword(string input)
        {
            using (MD5 md5 = new MD5CryptoServiceProvider())
            {
                byte[] bytes_md5_in = UTF8Encoding.Default.GetBytes(input);
                byte[] bytes_md5_out = md5.ComputeHash(bytes_md5_in);
                return BitConverter.ToString(bytes_md5_out).Replace("-", "");
            }
        }

        public void ChangePassword(Guid userId, string newPassword)
        {
            using (var db = new WMSContext())
            {
                var user = db.WMSUsers.Find(userId);
                if (user != null)
                {
                    user.Password = GetEncryptPassword(newPassword);
                }
                db.SaveChanges();
            }
        }

        public bool ValidateUser(string username, string password)
        {
            
            using (var db = new WMSContext())
            {
                username = username.ToLower();
                var user = db.WMSUsers.SingleOrDefault(p => p.Username.ToLower() == username);
                if (null == user)
                {
                    throw new Exception("�˺Ų����ڡ�");
                }
                if (!user.IsActive)
                {
                    throw new Exception("�˺��ѱ����ã��޷���¼������ϵ����Ա��");
                }
                return GetEncryptPassword(password) == user.Password;
            }
        }

        public List<WMSUser> GetAllUsers()
        {
            using (var db = new WMSContext())
            {
                return db.WMSUsers.ToList();
            }
        }

        public WMSUser GetUser(string username)
        {
            using (var db = new WMSContext())
            {
                username = username.ToLower();
                var user = db.WMSUsers.SingleOrDefault(p => p.Username.ToLower() == username);
                return user;
            }

        }

        public WMSUser GetUser(Guid userId)
        {
            using (var db = new WMSContext())
            {
                var user = db.WMSUsers.SingleOrDefault(p => p.UserId == userId);
                return user;
            }
        }

        public Guid SaveUser(WMSUser user)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.WMSUsers.Find(user.UserId);
                if (trackedEntity != null)
                {
                    db.Entry(trackedEntity).CurrentValues.SetValues(user);
                }
                else
                {
                    db.WMSUsers.Add(user);
                }
                db.SaveChanges();
                return user.UserId;
            }
        }

        public bool DeactiveUser(Guid userId)
        {
            using (var db = new WMSContext())
            {
                var user = db.WMSUsers.Find(userId);
                if (user != null)
                {
                    user.IsActive = false;
                }
                int result = db.SaveChanges();

                return result > 0;
            }
        }
    }
}