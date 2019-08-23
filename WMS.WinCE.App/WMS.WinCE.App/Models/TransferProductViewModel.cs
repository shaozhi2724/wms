namespace WMS.WinCE.App.Models
{
    public class TransferProductViewModel
    {
        public int? ProductID { get; set; }
        public string ProductName { get; set; }
        public int? ProductAmount { get; set; }
        public int SourceStructureID { get; set; }
        public int TargetStructureID { get; set; }
        public string SourceStructureCode { get; set; }
        public string TargetStructureCode { get; set; }
        public string ProductBatchNumber { get; set; }
        public string ProductSpec { get; set; }

        public int TransferAmount { get; set; }
        public string PackagingProportion { get; set; }
        public string PackageSpec { get; set; }
    }
}