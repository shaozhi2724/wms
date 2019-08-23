using System;

namespace WMS.WinCE.App.Models
{
    public class StoreOutDetailViewModel
    {
        public int PDATaskID { get; set; }

        public int BillDetailID { get; set; }

        public int DetailID { get; set; }

        public int StoreID { get; set; }

        public string StoreCode { get; set; }

        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string ProductSpec { get; set; }

        public string BatchNo { get; set; }

        public int? Amount { get; set; }

        public string PhysicType { get; set; }

        public string ProducerName { get; set; }

        public string PackagingProportion { get; set; }

        public DateTime? ProduceDate { get; set; }

        public DateTime? ValidateDate { get; set; }

        public int? StructureID { get; set; }

        public string StructureCode { get; set; }

        public string PackageSpec { get; set; }
    }
}