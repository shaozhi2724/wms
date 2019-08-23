using System;

namespace WMS.SmartDevice.App.Models
{
    public class UnqualifiedMoveDetailViewModel
    {
        public int UnqualifiedID { get; set; }
        public string ProductName { get; set; }
        public string UnqualifiedCode { get; set; }
        public string UnqualifiedStatus { get; set; }
        public string StoreTypeName { get; set; }
        public int Amount { get; set; }
        public string BatchNo { get; set; }
        public int DetailID { get; set; }
        public string PackageSpec { get; set; }
        public int ProductID { get; set; }
        public DateTime? ProduceDate { get; set; }
        public DateTime? ValidateDate { get; set; }
        public string PhysicType { get; set; }
        public string ProducerName { get; set; }
        public string PackagingProportion { get; set; }
    }
}