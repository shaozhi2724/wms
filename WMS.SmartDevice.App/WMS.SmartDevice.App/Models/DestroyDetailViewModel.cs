namespace WMS.SmartDevice.App.Models
{
    public class DestroyDetailViewModel
    {
        public int StructureID { get; set; }
        public int ProductID { get; set; }
        public int DetailID { get; set; }
        public string ProductName { get; set; }
        public string BatchNo { get; set; }
        public string PackageSpec { get; set; }
        public string ProductSpec { get; set; }
        public int? Amount { get; set; }
        public int DestroyID { get; set; }
        public string DestroyCode { get; set; }
    }
}