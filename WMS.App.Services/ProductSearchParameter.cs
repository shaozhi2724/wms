namespace WMS.App.Services
{
    public class ProductSearchParameter
    {
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string ProductBarcode { get; set; }
        public string ProducerName { get; set; }
        public int PackagingProportion { get; set; }
        public int EntireCargoSpaceMaximum { get; set; }
        public int StockMinAmount { get; set; }
        public int ScatteredCargoSpaceMaximum { get; set; }
        public int ScatteredCargoSpaceMinimum { get; set; }
        public string StockCondition { get; set; }

        public bool IsSupervise { get; set; }
    }
}