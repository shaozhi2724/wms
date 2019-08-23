using System;

namespace WMS.SmartDevice.App.Models
{
    public class ProductDestroyViewModel
    {
        public int DestroyID { get; set; }
        public string DestroyCode { get; set; }
        public string DestroyCause { get; set; }
        public DateTime DestroyDate { get; set; }
    }
}