namespace WMS.SmartDevice.App.Models
{
    /// <summary>
    /// 出库单视图模型
    /// </summary>
    public class StoreBillOutViewModel
    {
        /// <summary>
        /// 出库单序号
        /// </summary>
        public int StoreID { get; set; }

        /// <summary>
        /// 出库单号
        /// </summary>
        public string StoreCode { get; set; }

        /// <summary>
        /// 出库类型
        /// </summary>
        public string StoreTypeName { get; set; }

        /// <summary>
        /// 往来单位
        /// </summary>
        public string DealerName { get; set; }
    }
}