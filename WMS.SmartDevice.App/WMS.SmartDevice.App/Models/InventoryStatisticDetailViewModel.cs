using System;

namespace WMS.SmartDevice.App.Models
{
    public class InventoryStatisticDetailViewModel
    {
        public int DetailID { get; set; }
        public int InventoryStatisticID { get; set; }
        public Nullable<int> CargoSpaceStoreDetailID { get; set; }
        public Nullable<int> WarehouseID { get; set; }
        public Nullable<int> StructureID { get; set; }
        public string StructureCode { get; set; }
        public string StructureName { get; set; }
        public string AreaType { get; set; }
        public Nullable<int> ProductID { get; set; }
        public string ProductBatchNumber { get; set; }
        public Nullable<System.DateTime> ProductionDate { get; set; }
        public Nullable<System.DateTime> ProductValidDate { get; set; }
        public Nullable<int> ProductAmount { get; set; }
        public string Manufacturer { get; set; }
        public string DosageForm { get; set; }
        public string PackagingSpecification { get; set; }
        public string ProductName { get; set; }
        public string ProductSpec { get; set; }
        public string PackageSpec { get; set; }
        public string PackagingProportion { get; set; }
        public string PhysicType { get; set; }
        public Nullable<int> VerifiedProductID { get; set; }
        public string VerifiedProductBatchNumber { get; set; }
        public Nullable<System.DateTime> VerifiedProductionDate { get; set; }
        public Nullable<System.DateTime> VerifiedProductValidDate { get; set; }
        public Nullable<int> VerifiedProductAmount { get; set; }
        public string VerifiedManufacturer { get; set; }
        public string VerifiedDosageForm { get; set; }
        public string VerifiedPackagingSpecification { get; set; }
        public string VerifiedProductName { get; set; }
        public string VerifiedProductSpec { get; set; }
        public string VerifiedPackageSpec { get; set; }
        public string VerifiedPackagingProportion { get; set; }
        public string VerifiedPhysicType { get; set; }
        public Nullable<int> StatusID { get; set; }
        public string StatusName { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> VerifiedDate { get; set; }
        public string StockCondition { get; set; }
        public string VerifiedStockCondition { get; set; }
    }
}