namespace WMS.App.Services
{
    /// <summary>
    /// ��/��ⵥ״̬
    /// </summary>
    public enum StoreBillStatuses
    {
        /// <summary>
        /// �ȴ�
        /// </summary>
        Waiting = 0,
        /// <summary>
        /// ���ڳ�/���
        /// </summary>
        Processing = 1,
        /// <summary>
        /// ֹͣ
        /// </summary>
        Stop = 2,
        /// <summary>
        /// ���
        /// </summary>
        Complete = 3,
        /// <summary>
        /// �Ѹ���
        /// </summary>
        Reviewed = 4,
        /// <summary>
        /// ����쳣
        /// </summary>
        Error = 9
    }
}