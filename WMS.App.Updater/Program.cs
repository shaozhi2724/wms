using System;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace WMS.App.Updater
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-CN");

            if (args.Length != 2)
            {
                MessageBoxEx.Show("升级程序未发现必需清单和可执行参数。", "升级错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // TODO : better error messages
            var f = new UpdateForm();
            f.Manifest = args[0];
            f.Executible = args[1];
            Application.Run(f);
        }
    }
}
