using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using DevComponents.DotNetBar;
using ICSharpCode.SharpZipLib.Zip;

namespace WMS.App.Updater
{
    public partial class UpdateForm : Office2007Form
    {
        private const int extraWaitMilliseconds = 1000;

        public string Manifest { get; set; }
        public string Executible { get; set; }
        protected string ZipFile { get; set; }
        protected bool Updating { get; set; }

        public UpdateForm()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            Updating = true;

            try
            {
                ZipFile = System.IO.Path.GetTempFileName();

                // read manifest
                XDocument doc = XDocument.Load(Manifest);
                string title = (string) doc.Root.Element("appname");//Path.GetFileNameWithoutExtension(Manifest);
                lblTitle.Text = string.Format(lblTitle.Text, title);
                lblInfo.Text = string.Format(lblInfo.Text, title, (string)doc.Root.Element("version"), (DateTime)doc.Root.Element("date"));
                linkInfo.LinkClicked += (o, args) =>
                    {
                        linkInfo.LinkVisited = true;
                        System.Diagnostics.Process.Start((string)doc.Root.Element("info"));
                    };

                // download update zip
                lblStatus.Text = "正在下载更新...";
                using (var web = new WebClient())
                {
                    web.DownloadProgressChanged += new DownloadProgressChangedEventHandler((s, args) => progressBar1.Value = args.ProgressPercentage);
                    web.DownloadFileCompleted += new AsyncCompletedEventHandler(OnDownloadCompleted);
                    web.DownloadFileAsync(new Uri((string)doc.Root.Element("download")), ZipFile);
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
                lblStatus.Text = "错误: 下载失败！";
                Updating = false;
            }
        }

        private void OnDownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            System.Threading.Thread.Sleep(extraWaitMilliseconds); //don't go too fast
            if (e.Error != null)
            {
                Trace.WriteLine(e.Error);
                lblStatus.Text = "错误: 下载失败！";
                Updating = false;
                return;
            }

            lblStatus.Text = "正在更新...";
            progressBar1.Value = 0;
            picDownload.Visible = false;
            picZip.Visible = true;

            new System.Threading.Thread(new ThreadStart(Unzip)).Start();
        }

        private void Unzip()
        {
            try
            {
                string appPath = Path.GetDirectoryName(Application.ExecutablePath);

                // unzip update
                using (var fileStream = new FileStream(ZipFile, FileMode.Open, FileAccess.Read))
                using (ZipInputStream s = new ZipInputStream(fileStream))
                {
                    ZipEntry entry;
                    while ((entry = s.GetNextEntry()) != null)
                    {
                        string path = Path.GetDirectoryName(Path.Combine(appPath, entry.Name));

                        if (entry.IsDirectory)
                        {
                            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                        }
                        else
                        {
                            //write the data to disk
                            string name = entry.Name.EndsWith("Updater.exe") ? entry.Name.Replace(".exe", ".exe.tmp") : entry.Name;
                            using (FileStream fs = File.Create(Path.Combine(appPath, name)))
                            {
                                byte[] buffer = new byte[1024];
                                int read = buffer.Length;
                                while (true)
                                {
                                    read = s.Read(buffer, 0, buffer.Length);
                                    if (read > 0) fs.Write(buffer, 0, read);
                                    else break;
                                }
                            }
                        }
                        UpdateProgress(((float)s.Position / (float)fileStream.Length) * 100F);
                        System.Threading.Thread.Sleep(extraWaitMilliseconds); //don't go too fast
                    }
                }
                UnzipFinished();
            }
            catch (Exception ex)
            {
                UnzipFailed(ex);
            }
        }

        private void UnzipFinished()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(UnzipFinished));
                return;
            }

            Cleanup();
        }

        private void UnzipFailed(Exception ex)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<Exception>(UnzipFailed), ex);
                return;
            }

            Trace.WriteLine(ex);
            lblStatus.Text = "错误: 解压缩更新数据包失败！";
            Updating = false;
        }

        private void UpdateProgress(float percent)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<float>(UpdateProgress), percent);
                return;
            }

            progressBar1.Value = (int)percent;
        }

        private void Cleanup()
        {
            System.Threading.Thread.Sleep(extraWaitMilliseconds); //don't go too fast
            lblStatus.Text = "正在清理...";
            progressBar1.Value = 50;
            picZip.Visible = false;
            picCleanup.Visible = true;

            try
            {
                // delete zip
                System.IO.File.Delete(ZipFile);
                new System.Threading.Thread(new ThreadStart(Finish)).Start();
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
                lblStatus.Text = "错误: 清理失败！";
                Updating = false;
            }
        }

        private void Finish()
        {
            if (InvokeRequired)
            {
                System.Threading.Thread.Sleep(extraWaitMilliseconds); //don't go too fast
                Invoke(new Action(Finish));
                return;
            }

            progressBar1.Value = 100;
            lblStatus.Text = "系统更新成功!";
            System.Threading.Thread.Sleep(extraWaitMilliseconds); //don't go too fast
            Updating = false;

            try
            {
                // relaunch app
                System.Diagnostics.Process.Start(Executible);

                // close
                this.Close();
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
                lblStatus.Text = "错误: 主程序重启失败！";
            }
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (Updating)
            {
                e.Cancel = MessageBoxEx.Show("停止更新并关闭?", "更新中",
                    MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes;
            }
        }

    }
}
