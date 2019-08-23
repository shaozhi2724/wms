using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Management;
using System.Windows.Forms;
using System.Xml;
using DevComponents.DotNetBar;
using WMS.Model;
using WMS.Windows.App.Properties;

namespace WMS.Windows.App
{
    public partial class FrmSystemConfig : Office2007Form
    {
        private List<ConfigSettings> ConfigSettingsList;
        public FrmSystemConfig()
        {
            this.ConfigSettingsList = new List<ConfigSettings>();
            InitializeComponent();
            //AppSettingManager.InitAppSettingManager();
            MessageBoxEx.EnableGlass = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidatePage(true))
            {
                SaveSettings();
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show(this, "系统配置已修改。\n\n请重新启动程序！", "需要重启程序", MessageBoxButtons.OK, MessageBoxIcon.Asterisk,
                    MessageBoxDefaultButton.Button1);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool ValidatePage(bool triggerErrors)
        {
            // Start off assuming the page IS valid
            bool pageIsValid = true;

            if (string.IsNullOrEmpty(txtRemoteManifest.Text.Trim()))
            {
                if (triggerErrors)
                {
                    errorProvider.SetError(txtRemoteManifest,
                        "自动升级信息文件URL地址！");
                }

                pageIsValid = false;
            }
            else
            {
                errorProvider.SetError(txtRemoteManifest, string.Empty);
            }

            if (string.IsNullOrEmpty(txtRootPassword.Text.Trim()))
            {
                if (triggerErrors)
                {
                    errorProvider.SetError(txtRootPassword, "超级用户密码！");
                }

                pageIsValid = false;
            }
            else
            {
                errorProvider.SetError(txtRootPassword, string.Empty);
            }

            return pageIsValid;
        }

        private void FrmSystemConfig_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void LoadSettings()
        {
            swbAllowNoCodeReview.Value = Settings.Default.AllowNoCodeReview;
            swbAutomaticOutStore.Value = Settings.Default.AutomaticOutStore;
            swbPrintCargoBarcode.Value = Settings.Default.PrintCargoBarcode;
            swbSystemSignStoreInPosition.Value = Settings.Default.SystemSignStoreInPosition;
            swbWMSStandalone.Value = Settings.Default.WMSStandalone;

            txtAutomaticOutStoreInterval.Value = Settings.Default.AutomaticOutStoreInterval;
            txtAutomaticOutStoreTaskCount.Value = Settings.Default.MaxOutTaskCount;
            txtRemoteManifest.Text = Settings.Default.RemoteManifest;
            txtRootPassword.Text = Settings.Default.RootPassword;
            txtInDir.Text = Settings.Default.InDataFolder;
            txtOutDir.Text = Settings.Default.OutDataFolder;
            swbYuanBo.Value = Settings.Default.UseYuanboControl;
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string file = config.FilePath;
            ConfigXmlDocument doc = new ConfigXmlDocument();
            doc.Load(file);
            XmlNode node = doc.GetElementsByTagName("applicationSettings")[0];
            this.ConfigSettingsList.Clear();
            IEnumerator enumerator = node.FirstChild.ChildNodes.GetEnumerator();
            while (enumerator != null && enumerator.MoveNext())
            {
                XmlNode current = (XmlNode) enumerator.Current;
                if (current.NodeType == XmlNodeType.Element)
                {
                    ConfigSettings item = new ConfigSettings();
                    item.SettingName = current.Attributes[0].Value;
                    item.SerializeAs = current.Attributes[1].Value;
                    item.SettingValue = current.FirstChild.InnerText;
                    this.ConfigSettingsList.Add(item);
                }
            }

            using (var db = new WMSContext())
            {
                var currentMonitComputer = db.WMSMonitoringSettings.ToList().LastOrDefault();
                if (null != currentMonitComputer)
                {
                    txtComputerId.Text = currentMonitComputer.ComputerId;
                }
            }
        }

        private void SaveSettings()
        {
            ConfigSettingsList.Find(p => p.SettingName == "AllowNoCodeReview").SettingValue =
                swbAllowNoCodeReview.Value.ToString();
            ConfigSettingsList.Find(p => p.SettingName == "AutomaticOutStore").SettingValue =
                swbAutomaticOutStore.Value.ToString();
            ConfigSettingsList.Find(p => p.SettingName == "PrintCargoBarcode").SettingValue =
                swbPrintCargoBarcode.Value.ToString();
            ConfigSettingsList.Find(p => p.SettingName == "SystemSignStoreInPosition").SettingValue =
                swbSystemSignStoreInPosition.Value.ToString();
            ConfigSettingsList.Find(p => p.SettingName == "WMSStandalone").SettingValue =
                swbWMSStandalone.Value.ToString();
            ConfigSettingsList.Find(p => p.SettingName == "AutomaticOutStoreInterval").SettingValue =
                txtAutomaticOutStoreInterval.Value.ToString();
            ConfigSettingsList.Find(p => p.SettingName == "MaxOutTaskCount").SettingValue =
                txtAutomaticOutStoreTaskCount.Value.ToString();
            ConfigSettingsList.Find(p => p.SettingName == "RemoteManifest").SettingValue =
                txtRemoteManifest.Text.Trim();
            ConfigSettingsList.Find(p => p.SettingName == "RootPassword").SettingValue =
                txtRootPassword.Text.Trim();
            ConfigSettingsList.Find(p => p.SettingName == "InDataFolder").SettingValue =
                txtInDir.Text.Trim();
            ConfigSettingsList.Find(p => p.SettingName == "OutDataFolder").SettingValue =
                txtOutDir.Text.Trim();
            ConfigSettingsList.Find(p => p.SettingName == "UseYuanboControl").SettingValue =
                swbYuanBo.Value.ToString();

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string file = config.FilePath;
            ConfigXmlDocument doc = new ConfigXmlDocument();
            doc.Load(file);
            XmlNode node = doc.GetElementsByTagName("applicationSettings")[0];

            IEnumerator enumerator = node.FirstChild.ChildNodes.GetEnumerator();
            while (enumerator != null && enumerator.MoveNext())
            {
                XmlNode current = (XmlNode) enumerator.Current;
                if (current.NodeType == XmlNodeType.Element)
                {
                    ConfigSettings settings = this.ConfigSettingsList.Find(p => p.SettingName == current.Attributes[0].Value);
                    if (settings != null)
                    {
                        current.Attributes[0].Value = settings.SettingName;
                        current.Attributes[1].Value = settings.SerializeAs;
                        current.FirstChild.InnerText = settings.SettingValue;
                    }
                }
            }
            doc.Save(file);

            ConfigurationManager.RefreshSection("applicationSettings");

            Settings.Default.Reload();

            using(var db = new WMSContext())
            {
                string computerId = txtComputerId.Text.Trim();
                var currentMonitComputer = db.WMSMonitoringSettings.ToList().LastOrDefault();
                if(null != currentMonitComputer)
                {
                    if(currentMonitComputer.ComputerId != computerId)
                    {
                        if(DialogResult.Yes == MessageBoxEx.Show(this, "出入库机器标识有更改，确定要保存？", "重要提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                        {
                            db.WMSMonitoringSettings.Add(new WMSMonitoringSetting
                                                         {
                                                             ComputerId = computerId
                                                         });
                        }
                    }
                }
                else
                {
                    db.WMSMonitoringSettings.Add(new WMSMonitoringSetting
                                                         {
                                                             ComputerId = computerId
                                                         });
                }
                db.SaveChanges();
            }
        }

        private void btnInDir_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK == fbdInDir.ShowDialog(this))
            {
                txtInDir.Text = fbdInDir.SelectedPath;
            }
        }

        private void btnOutDir_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK == fbdOutDir.ShowDialog())
            {
                txtOutDir.Text = fbdOutDir.SelectedPath;
            }
        }

        private void btnSetCustomers_Click(object sender, EventArgs e)
        {
            FrmRegulatoryCustomer doc = new FrmRegulatoryCustomer();
            doc.ShowDialog(this);
        }

        private void btnGetMac_Click(object sender, EventArgs e)
        {
            txtComputerId.Text = Program.GetBoardID();
        }



        
    }
    public class ConfigSettings
    {
        private string _serializeAs;
        private string _settingName;
        private string _settingValue;

        public string SerializeAs
        {
            get
            {
                return this._serializeAs;
            }
            set
            {
                this._serializeAs = value;
            }
        }

        public string SettingName
        {
            get
            {
                return this._settingName;
            }
            set
            {
                this._settingName = value;
            }
        }

        public string SettingValue
        {
            get
            {
                return this._settingValue;
            }
            set
            {
                this._settingValue = value;
            }
        }
    }
}
