using System;
using System.Collections.Generic;
using WMS.Model;

namespace WMS.App.Services
{
    public interface ISecurityService
    {
        bool ValidateUser(string username, string password);

        List<WMSUser> GetAllUsers();

        WMSUser GetUser(string username);

        WMSUser GetUser(Guid userId);

        Guid SaveUser(WMSUser user);

        bool DeactiveUser(Guid userId);

        string GetEncryptPassword(string input);
        void ChangePassword(Guid userId, string newPassword);
    }
}