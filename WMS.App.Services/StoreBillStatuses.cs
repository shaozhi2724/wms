namespace WMS.App.Services
{
    /// <summary>
    /// 出/入库单状态
    /// </summary>
    public enum StoreBillStatuses
    {
        /// <summary>
        /// 等待
        /// </summary>
        Waiting = 0,
        /// <summary>
        /// 正在出/入库
        /// </summary>
        Processing = 1,
        /// <summary>
        /// 停止
        /// </summary>
        Stop = 2,
        /// <summary>
        /// 完成
        /// </summary>
        Complete = 3,
        /// <summary>
        /// 已复核
        /// </summary>
        Reviewed = 4,
        /// <summary>
        /// 库存异常
        /// </summary>
        Error = 9
    }
}