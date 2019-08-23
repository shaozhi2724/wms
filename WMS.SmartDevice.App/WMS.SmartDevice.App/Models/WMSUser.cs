using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace WMS.SmartDevice.App.Models
{
    public class WMSUser
    {
        public System.Guid UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public string Realname { get; set; }
    }
}
