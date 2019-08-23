using System;
using WMS.Model;

namespace WMS.App.Services
{
    public class InventoryViewModel : Product
    {
        public string StructureCode { get; set; }
        public string StructureName { get; set; }
        public string StructureLocation { get; set; }
        public string ProductBatchNumber { get; set; }
        public int? ProductAmount { get; set; }
        public DateTime? ProductionDate { get; set; }
        public DateTime? ProductValidDate { get; set; }
        public int CargoSpaceStoreDetailID { get; set; }
        public string AreaType { get; set; }
    }
}