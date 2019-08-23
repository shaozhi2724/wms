using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMS.App.Services
{
    public class MoreProductForReview
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string BatchNo { get; set; }
        public string ProductBarCode { get; set; }
        public string ProductSpec { get; set; }
        public string PackageSpec { get; set; }
        public string ProducerName { get; set; }
        public int StoreOutAmount { get; set; }
    }
}
