namespace WMS.App.Services
{
    public class StorageStructureTreeViewModel
    {
        public int WarehouseID { get; set; }
        public int StructureID { get; set; }
        public string StructureCode { get; set; }
        public string ParentStructureCode { get; set; }
        public string StructureName { get; set; }
        public string StructureType { get; set; }
        public int StructureStyle { get; set; }
        public string StructureLocation { get; set; }
        public string StructureBarCode { get; set; }

        public bool IsActive { get; set; }
    }
}