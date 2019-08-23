namespace WMS.LabelController
{
    public class WinMessage
    {
        /// <summary>
        /// 显示系统提示对话框
        /// </summary>
        /// <param name="message">消息内容</param>
        public static void ShowInformation(string message)
        {
            System.Windows.Forms.MessageBox.Show(message, "系统提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }

        /// <summary>
        /// 显示系统警告对话框
        /// </summary>
        /// <param name="message">消息内容</param>
        public static void ShowWarning(string message)
        {
            System.Windows.Forms.MessageBox.Show(message, "系统警告", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
        }

        /// <summary>
        /// 显示系统错误对话框
        /// </summary>
        /// <param name="message">消息内容</param>
        public static void ShowError(string message)
        {
            System.Windows.Forms.MessageBox.Show(message, "系统错误", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }

        /// <summary>
        /// 显示系统询问对话框
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <returns>选择结果</returns>
        public static System.Windows.Forms.DialogResult ShowQuestion(string message)
        {
            return System.Windows.Forms.MessageBox.Show(message, "系统询问", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question);
        }
    }
}
