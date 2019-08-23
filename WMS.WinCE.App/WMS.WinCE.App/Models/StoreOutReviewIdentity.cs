using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace WMS.SmartDevice.App.Models
{
    public class StoreOutReviewIdentity
    {
        public int ReviewIdentityID { get; set; }
        public string ReviewIdentityCode { get; set; }
        public int StoreID { get; set; }
        public string StoreCode { get; set; }
        public string PDAIdentity { get; set; }
        public string OperationUsername { get; set; }
        public string OperationRealname { get; set; }
        public System.DateTime RelatedDate { get; set; }
        public bool IsReviewed { get; set; }
        public string ReviewCode { get; set; }
        public DateTime? ReviewDate { get; set; }
        public string ReviewPerson { get; set; }
    }
}
