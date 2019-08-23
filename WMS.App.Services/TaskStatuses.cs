namespace WMS.App.Services
{
    /// <summary>
    /// 出入库任务状态
    /// </summary>
    public enum TaskStatuses
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
        Complete = 3
    }
}