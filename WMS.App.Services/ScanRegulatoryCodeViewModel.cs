namespace WMS.App.Services
{
    public class ScanRegulatoryCodeViewModel
    {
        public int Index { get; set; }
        public int StoreID { get; set; }
        public int StoreDetailID { get; set; }

        public string RegulatoryCode
        {
            get;
            set;
        }
        public string ProductCode { get; set; }
        public string ProductBarCode { get; set; }
    }
}