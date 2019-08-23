using System;

namespace WMS.App.Services
{
    public class InventoryDetailViewModel
    {
        public int? CargoSpaceStoreDetailID { get; set; }
        public int WarehouseID { get; set; }
        public int StructureID { get; set; }
        public string StructureCode { get; set; }
        public string StructureName { get; set; }
        public string AreaType { get; set; }
        public int? ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductBatchNumber { get; set; }
        public string StockCondition { get; set; }
        public DateTime? ProductionDate { get; set; }
        public DateTime? ProductValidDate { get; set; }
        public int? ProductAmount { get; set; }
        public string ProducerName { get; set; }
        public string Manufacturer { get; set; }
        public string ProductSpec { get; set; }
        public string PackagingSpecification { get; set; }
        public string PhysicType { get; set; }
        public string DosageForm { get; set; }
        public string PackagingProportion { get; set; }
        public string PackageSpec { get; set; }
    }
}