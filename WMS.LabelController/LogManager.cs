using System;
using System.IO;
using System.Text;

namespace WMS.LabelController
{
    public class LogManager
    {
        /// <summary>
        /// 写本地操作日志
        /// </summary>
        /// <param name="logs"></param>
        public static void WriteLocalLog(string logs)
        {

            string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs");

            if (!Directory.Exists(logPath))
            {
                Directory.CreateDirectory(logPath);
            }

            string fileName = Path.Combine(logPath, DateTime.Now.ToString("yyyyMMdd") + ".log");
            //改写文件
            using (FileStream fs = new FileStream(fileName, FileMode.Append))
            {
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                try
                {
                    sw.Write(logs);
                    sw.Flush();
                }
                finally
                {
                    sw.Close();
                    sw.Dispose();
                    fs.Close();
                    fs.Dispose();
                }
            }
        }
    }
}
