using System;

namespace WMS.WinCE.App.Models
{
    public class CargoSpaceStoreDetail
    {
        public int CargoSpaceStoreDetailID { get; set; }
        public string StoreCode { get; set; }
        public int StructureID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public string ProductBatchNumber { get; set; }
        public Nullable<System.DateTime> ProductionDate { get; set; }
        public Nullable<System.DateTime> ProductValidDate { get; set; }
        public Nullable<int> ProductAmount { get; set; }
        public string Manufacturer { get; set; }
        public string DosageForm { get; set; }
        public string PackagingSpecification { get; set; }
    }
}