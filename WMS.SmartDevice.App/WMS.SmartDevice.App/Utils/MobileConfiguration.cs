using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;

namespace WMS.SmartDevice.App.Utils
{
    public static class MobileConfiguration
    {
        public static NameValueCollection Settings;

        static MobileConfiguration()
        {
            LoadSettings();
        }

        private static void LoadSettings()
        {
            string appPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
            string configFile = Path.Combine(appPath, "App.config");

            if (!File.Exists(configFile))
            {
                throw new FileNotFoundException(string.Format("应用程序配置文件 '{0}' 不存在！", configFile));
            }

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(configFile);
            XmlNodeList nodeList = xmlDocument.GetElementsByTagName("appSettings");
            Settings = new NameValueCollection();

            foreach (XmlNode node in nodeList)
            {
                foreach (XmlNode key in node.ChildNodes)
                {
                    Settings.Add(key.Attributes["key"].Value, key.Attributes["value"].Value);
                }
            }
        }

        public static void Save(string server, string port, string database, string username, string password, bool systemSignPosition, bool printCargoBarcode)
        {
            string appPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
            string configFile = Path.Combine(appPath, "App.config");

            if (!File.Exists(configFile))
            {
                throw new FileNotFoundException(string.Format("应用程序配置文件 '{0}' 不存在！", configFile));
            }

            var doc = XDocument.Load(configFile);
            var data = from s in doc.Descendants("appSettings").Descendants("add")
                select s;
            foreach (var element in data)
            {
                switch (element.Attribute("key").Value)
                {
                    case "DBServerName":
                        element.Attribute("value").Value = server;
                        break;
                    case "DBServerPort":
                        element.Attribute("value").Value = port;
                        break;
                    case "DBDatabaseName":
                        element.Attribute("value").Value = database;
                        break;
                    case "DBUserName":
                        element.Attribute("value").Value = username;
                        break;
                    case "DBPassword":
                        element.Attribute("value").Value = password;
                        break;
                    case "SystemSignPosition":
                        element.Attribute("value").Value = systemSignPosition.ToString();
                        break;
                    case "PrintCargoBarcode":
                        element.Attribute("value").Value = printCargoBarcode.ToString();
                        break;
                }
            }
            doc.Save(configFile);
            LoadSettings();
            Program.LoadApplicationConfig();
        }
    }
}
