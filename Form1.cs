
using System.Collections.Generic;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace EpicGameUploader
{
    public partial class Form1 : Form
    {
        private const string LogFilePath = "log.txt";

        private class SettingData
        {
            public string organizationId = "";
            public string productID = "";
            public string artifactID = "";
            public string productVersion = "1.0";
            public string appArgs = "";
            public string IgnoreList = "";
        }
        private string EpicBPTFile;
        private string EpicUploadDirectory;
        private string EpicAppLaunch;
        private string CloudDir;
        public string ProjectName;

        public string BPTClientID = "";
        public string BPTClientSecret = "";

        SettingData settings;

        private bool m_ReadLogFileFlag;

        public Form1()
        {
            m_ReadLogFileFlag = false;

            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            if (settings == null)
            {
                settings = new SettingData();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Win64Toggle.Checked = true;
            FileInfo epicBPTFileInfo = new FileInfo("Engine/Binaries/Win64/BuildPatchTool.exe");
            if (File.Exists("BPTClient.txt"))
            {
                string[] lines = File.ReadAllLines("BPTClient.txt");
                BPTClientID = lines[0].Trim();
                BPTClientSecret = lines[1].Trim();
                CloudDir = lines[2].Trim();
                ProjectName = lines[3].Trim();
            }
            EpicBPTFile = epicBPTFileInfo.FullName.Replace("\\", "/");
            this.tBoxUploadTool.Text = EpicBPTFile;
            ReloadContent();
        }

        private void ReloadContent()
        {
            string EpicOnlineServicesConfigPath;
            if (MacOSToggle.Checked)
            {
                EpicUploadDirectory = $"../../Builds/StandaloneOSX Epic/{ProjectName}.app";
                EpicAppLaunch = $"Contents/MacOS/{ProjectName}";
                EpicOnlineServicesConfigPath = $"{EpicUploadDirectory}/Contents/Resources/Data/StreamingAssets/EOS/EpicOnlineServicesConfig.json";
            }
            else if (Win64Toggle.Checked)
            {
                EpicUploadDirectory = "../../Builds/StandaloneWindows64 Epic";
                EpicAppLaunch = $"{ProjectName}.exe";
                EpicOnlineServicesConfigPath = $"{EpicUploadDirectory}/{ProjectName}_Data/StreamingAssets/EOS/EpicOnlineServicesConfig.json";
            }
            else if (DLC1Toggle.Checked)
            {
                EpicUploadDirectory = "../../Builds/DLC1";
                EpicAppLaunch = string.Empty;
                EpicOnlineServicesConfigPath = $"EpicOnlineServicesConfig_DLC1.json";
            }
            else
            {
                MessageBox.Show("Unkonow type");
                return;
            }
            eosConfigFilePathLabel.Text = $"EOSConfigPath: {EpicOnlineServicesConfigPath}";
            EpicUploadDirectory = new DirectoryInfo(EpicUploadDirectory).FullName.Replace("\\", "/");
            if (!Directory.Exists(EpicUploadDirectory))
            {
                MessageBox.Show("Not found directory: \n" + EpicUploadDirectory);
                return;
            }
            settings = LitJson.JsonMapper.ToObject<SettingData>(File.ReadAllText(EpicOnlineServicesConfigPath));

            this.uploadDirectoryTbox.Text = EpicUploadDirectory;
            this.tBoxIgnore.Text = "忽略上传的文件夹或文件(相对于游戏.exe所在目录)\n" + settings.IgnoreList;
            this.tBoxBuildVersion.Text = settings.productVersion;
            this.tBoxOrganizationId.Text = settings.organizationId;
            this.tBoxProductId.Text = settings.productID;
            this.tBoxArtifactId.Text = settings.artifactID;
            this.tBoxBPTClientId.Text = BPTClientID;
            this.tBoxBPTClientSecret.Text = BPTClientSecret;
            this.tBoxCloudDir.Text = CloudDir;
            this.tBoxAppArgs.Text = settings.appArgs;
        }

        private void UploadGame()
        {
            StringBuilder strBuilder = new StringBuilder();
            //strBuilder.AppendFormat(settings.EpicBPTFile);
            strBuilder.AppendFormat(" -OrganizationId=\"{0}\"", settings.organizationId);
            strBuilder.AppendFormat(" -ProductId=\"{0}\"", settings.productID);
            strBuilder.AppendFormat(" -ArtifactId=\"{0}\"", settings.artifactID);
            strBuilder.AppendFormat(" -ClientId=\"{0}\"", BPTClientID);
            strBuilder.AppendFormat(" -ClientSecret=\"{0}\"", BPTClientSecret);
            strBuilder.Append(" -mode=\"UploadBinary\"");
            strBuilder.AppendFormat(" -BuildRoot=\"{0}\"", EpicUploadDirectory);
            strBuilder.AppendFormat(" -CloudDir=\"{0}\"", CloudDir);
            string buildVersion = settings.productVersion;
            if (Win64Toggle.Checked)
                buildVersion = settings.productVersion + "Win64";
            else if (MacOSToggle.Checked)
                buildVersion = settings.productVersion + "MacOS";
            else if (DLC1Toggle.Checked)
                buildVersion = settings.productVersion + "DLC1";
            else
                MessageBox.Show("Unknown platform");
            strBuilder.AppendFormat(" -BuildVersion=\"{0}\"", buildVersion);
            strBuilder.AppendFormat(" -AppLaunch=\"{0}\"", EpicAppLaunch);
            strBuilder.AppendFormat(" -AppArgs=\"{0}\"", settings.appArgs);
            if (!string.IsNullOrWhiteSpace(settings.IgnoreList))
            {
            }

            tBoxIgnore.Text += "\r\nUploadGame, waiting...\n";

            ProcessStartInfo processStartInfo = new ProcessStartInfo(EpicBPTFile, strBuilder.ToString())
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardInput = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
            };
            int exitCode = 0;
            using (FileStream logFileStream = new FileStream(LogFilePath, FileMode.Create, FileAccess.Write))
            {
                {
                    string str = processStartInfo.FileName;
                    byte[] bytes = Encoding.UTF8.GetBytes(str);
                    logFileStream.Write(bytes, 0, bytes.Length);
                    str = processStartInfo.Arguments;
                    bytes = Encoding.UTF8.GetBytes(str);
                    logFileStream.Write(bytes, 0, bytes.Length);
                    str = $"\n{DateTime.Now}\n";
                    bytes = Encoding.UTF8.GetBytes(str);
                    logFileStream.Write(bytes, 0, bytes.Length);
                }
                using (Process process = Process.Start(processStartInfo) ?? throw new Exception($"{nameof(process)} start failed, {processStartInfo.FileName}"))
                {
                    process.OutputDataReceived += (object sender, DataReceivedEventArgs e) =>
                    {
                        string str = e.Data ?? string.Empty;
                        byte[] bytes = Encoding.UTF8.GetBytes(str);
                        logFileStream.Write(bytes, 0, bytes.Length);
                        bytes = Encoding.UTF8.GetBytes("\r\n");
                        logFileStream.Write(bytes, 0, bytes.Length);
                    };
                    process.ErrorDataReceived += (object sender, DataReceivedEventArgs e) =>
                    {
                        string str = e.Data ?? string.Empty;
                        byte[] bytes = Encoding.UTF8.GetBytes(str);
                        logFileStream.Write(bytes, 0, bytes.Length);
                        bytes = Encoding.UTF8.GetBytes("\r\n");
                        logFileStream.Write(bytes, 0, bytes.Length);
                    };

                    process.BeginErrorReadLine();
                    process.BeginOutputReadLine();

                    process.WaitForExit(1000 * 1000);
                    logFileStream.Dispose();
                    m_ReadLogFileFlag = true;

                    // time out, kill process
                    if (!process.HasExited)
                    {
                        MessageBox.Show("timeout!");
                        process.Kill();
                        return;
                    }
                    process.WaitForExit();
                    exitCode = process.ExitCode;
                }
            }
            MessageBox.Show("finish with exit code " + exitCode);
        }
        private void RefreshIgnoreFile()
        {
            List<string> ignoreFileList = new List<string>();
            var ignoreList = settings.IgnoreList.Split('\n');
            var uploadDir = EpicUploadDirectory;
            foreach (var ignoreItem in ignoreList)
            {
                var item = ignoreItem.Trim();
                if (string.IsNullOrWhiteSpace(item)) continue;
                if (Path.HasExtension(item))
                {
                    var file = Path.Combine(uploadDir, item);
                    if (File.Exists(file))
                    {
                        var name = item;
                        if (!ignoreFileList.Contains(name))
                            ignoreFileList.Add(name);
                    }

                }
                else
                {
                    var path = Path.Combine(uploadDir, item);
                    if (Directory.Exists(path))
                    {
                        var files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
                        foreach (var file in files)
                        {
                            var name = file.Substring(uploadDir.Length + 1);
                            if (!ignoreFileList.Contains(name))
                                ignoreFileList.Add(name);
                        }
                    }
                }
            }
            //this.ignoreListText.AppendText(LitJson.JsonMapper.ToJson(ignoreFileList));
        }


        private void tBoxUploadTool_TextChanged(object sender, EventArgs e)
        {
            EpicBPTFile = this.tBoxUploadTool.Text;
        }

        private void uploadDirectoryTbox_TextChanged(object sender, EventArgs e)
        {
            EpicUploadDirectory = this.uploadDirectoryTbox.Text;
        }

        private void tBoxOrganizationId_TextChanged(object sender, EventArgs e)
        {
            settings.organizationId = this.tBoxOrganizationId.Text;
        }

        private void tBoxProductId_TextChanged(object sender, EventArgs e)
        {
            settings.productID = this.tBoxProductId.Text;
        }

        private void tBoxArtifactId_TextChanged(object sender, EventArgs e)
        {
            settings.artifactID = this.tBoxArtifactId.Text;
        }

        private void tBoxBPTClientId_TextChanged(object sender, EventArgs e)
        {
            BPTClientID = this.tBoxBPTClientId.Text;
        }

        private void tBoxBPTClientSecret_TextChanged(object sender, EventArgs e)
        {
            BPTClientSecret = this.tBoxBPTClientSecret.Text;
        }

        private void tBoxCloudDir_TextChanged(object sender, EventArgs e)
        {
            CloudDir = this.tBoxCloudDir.Text;
        }

        private void tBoxBuildVersion_TextChanged(object sender, EventArgs e)
        {
            settings.productVersion = this.tBoxBuildVersion.Text;
        }

        private void tBoxAppArgs_TextChanged(object sender, EventArgs e)
        {
            settings.appArgs = this.tBoxAppArgs.Text;
        }

        private void uploadToolSelectBt_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "可执行文件(*.exe)|*.exe";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.tBoxUploadTool.Text = dialog.FileName;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://dev.epicgames.com/docs/epic-games-store/publishing-tools/store-presence/upload-binaries/bpt-instructions-150?sessionInvalidated=true";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void uploadAppSelectBt_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "可执行文件(*.exe)|*.exe";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.uploadDirectoryTbox.Text = dialog.FileName;
            }
        }

        private void UploadBt_Click(object sender, EventArgs e)
        {
            if (!File.Exists(EpicBPTFile))
            {
                if (MessageBox.Show("Epic上传工具无效，请重新选择。", "错误", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    return;
                }
            }

            if (!Directory.Exists(EpicUploadDirectory))
            {
                if (MessageBox.Show("游戏exe文件夹无效，请重新选择。", "错误", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    return;
                }
            }
            RefreshIgnoreFile();
            UploadGame();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            ReloadContent();
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if (m_ReadLogFileFlag)
            {
                m_ReadLogFileFlag = false;
                string content = File.ReadAllText(LogFilePath);
                tBoxIgnore.Text += content;
            }
        }
    }
}