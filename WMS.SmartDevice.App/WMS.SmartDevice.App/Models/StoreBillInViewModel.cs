namespace WMS.SmartDevice.App.Models
{
    /// <summary>
    /// 入库单视图模型
    /// </summary>
    public class StoreBillInViewModel
    {
        /// <summary>
        /// 入库单序号
        /// </summary>
        public int StoreID { get; set; }

        /// <summary>
        /// 入库单号
        /// </summary>
        public string StoreCode { get; set; }

        /// <summary>
        /// 入库类型
        /// </summary>
        public string StoreTypeName { get; set; }

        /// <summary>
        /// 往来单位
        /// </summary>
        public string DealerName { get; set; }

        public  string ProductName { get; set; }
    }
}