using System;
using System.Windows.Forms;
using WMS.SmartDevice.App.Utils;
using WMS.SmartDevice.App.Models;

namespace WMS.SmartDevice.App
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [MTAThread]
        static void Main()
        {
            LoadApplicationConfig();
            Application.Run(new FrmLogin());
        }

        public static void LoadApplicationConfig()
        {
            string dbServerName = MobileConfiguration.Settings["DBServerName"];
            string dbServerPort = MobileConfiguration.Settings["DBServerPort"];
            string dbDatabaseName = MobileConfiguration.Settings["DBDatabaseName"];
            string dbUserName = MobileConfiguration.Settings["DBUserName"];
            string dbPassword = MobileConfiguration.Settings["DBPassword"];

            ConnectionString = string.Format("Data Source={0},{1};Initial Catalog={2};User ID={3};Password={4};",
                dbServerName, dbServerPort, dbDatabaseName, dbUserName, dbPassword);

            SystemSignPosition = bool.Parse(MobileConfiguration.Settings["SystemSignPosition"]);
            PrintCargoBarcode = bool.Parse(MobileConfiguration.Settings["PrintCargoBarcode"]);
        }

        public static string ConnectionString { get; private set; }

        public static bool SystemSignPosition { get; private set; }
        public static bool PrintCargoBarcode { get; private set; }
        public static WMSUser CurrentUser { get; set; }
    }
}