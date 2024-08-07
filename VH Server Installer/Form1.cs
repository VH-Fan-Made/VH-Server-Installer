using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net;
using VH_Server_Installer.Resources.AdditionalFiles;
using VH_Server_Installer.Resources.Releases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.ApplicationServices;
using System.IO.Compression;
using Microsoft.Win32;
using System.Windows.Forms;
using VH_Server_Installer.Resources.Java;
using WindowsShortcutFactory;
using Microsoft.Win32.TaskScheduler;

namespace VH_Server_Installer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        private string installPath;
        private string tempPath = System.IO.Path.GetTempPath();
        private string vhdlPath;
        private string javaPath;
        private List<JavaRuntime> javaRuntimes;

        private void Form1_Load(object sender, EventArgs e)
        {
            ReleaseList? releaseList = getData();
            if (releaseList != null)
            {
                foreach (Release release in releaseList.data)
                {
                    if (release.hasServerPack)
                    {
                        comboBox1.Items.Add(release.fileName);
                    }
                }
                comboBox1.SelectedIndex = 0;
            }
            PopulateComboBox2();

            lockControls(false);
        }

        private ReleaseList? getData()
        {
            string url = "https://www.curseforge.com/api/v1/mods/711537/files?pageIndex=0&pageSize=120&sort=dateCreated&sortDescending=true&removeAlphas=true";
            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    json_data = w.DownloadString(url);
                    status("Searching the Vault Hunters server files...");
                    return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<ReleaseList>(json_data) : null;
                }
                catch (Exception) { }
                // if string with JSON data is not empty, deserialize it to class and return its instance 
            }
            return null;
        }
        private AdditionalFilesList? getAdditionalFiles(int id)
        {
            string url = "https://www.curseforge.com/api/v1/mods/711537/files/" + id.ToString() + "/additional-files";
            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    json_data = w.DownloadString(url);
                    status("Vault Hunters Server files Found!!! Downloading...");
                    return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<AdditionalFilesList>(json_data) : null;
                }
                catch (Exception) { }
                // if string with JSON data is not empty, deserialize it to class and return its instance 
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            status("Downloading Server files...");
            lockControls(true);
            ReleaseList? releaseList = getData();
            if (releaseList != null)
            {
                foreach (Release release in releaseList.data)
                {
                    if (release.hasServerPack)
                    {
                        if (comboBox1.Text == release.fileName)
                        {
                            AdditionalFilesList? afl = getAdditionalFiles(release.id);
                            if (afl != null)
                            {

                                vhdlPath = Path.Join(tempPath, afl.data[0].fileName);
                                DownloadFile("https://www.curseforge.com/api/v1/mods/711537/files/" + afl.data[0].id + "/download", vhdlPath, "");
                                status("Server files Downloaded!!!");
                                //Process.Start("explorer.exe", tempPath + afl.data[0].fileName);
                            }
                        }
                    }
                }
                comboBox1.SelectedIndex = 0;
            }
            lockControls(false);
        }

        private string DownloadFile(string url, string filename, string? path = null)
        {
            string tempPath = System.IO.Path.GetTempPath();
            string fullPath = tempPath + filename;
            if (path != null)
            {
                fullPath = Path.Combine(path, filename);
            }

            WebClient webClient = new WebClient();
            webClient.Headers.Add("Accept: text/html, application/xhtml+xml, */*");
            webClient.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
            Uri uri = new Uri(url);
            webClient.DownloadFile(uri, fullPath);
            return fullPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lockControls(true);
            DialogResult dialogResult = folderBrowserDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                status("Downloading Forge Server...");
                installPath = folderBrowserDialog1.SelectedPath;
                string url = "https://maven.minecraftforge.net/net/minecraftforge/forge/1.18.2-40.2.9/forge-1.18.2-40.2.9-installer.jar";
                string name = "installer.jar";
                string path = DownloadFile(url, name);
                textBox1.Text = installPath;
                status("Starting Forge Installer!!!");
                runCMD(path);
            }
            lockControls(false);
        }

        private void runCMD(string command)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = false;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine("\"" + command + "\"");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lockControls(true);
            status("Please install the forge Server...");
            Clipboard.SetText(textBox1.Text);
            try
            {
                Process process = Process.GetProcessesByName("javaw")[0];
                if (process != null)
                {
                    process.WaitForInputIdle();
                    IntPtr s = process.MainWindowHandle;
                    SetForegroundWindow(s);

                    //Console.Write(�Proccess found: � +process.ToString());
                }
                //listProcess();
            }
            catch (Exception exc)
            {
                //Console.WriteLine(�ERROR: Application is not running!\nException: � +exc.Message);
                //Console.ReadKey();
            }
            lockControls(false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                lockControls(true);
                status("Extracting Modpack files...");
                ZipFile.ExtractToDirectory(vhdlPath, installPath);
                status("Done extracting!!!");
                lockControls(false);
            }
            else MessageBox.Show("You did not set a Server Location.\nPlease Select a location before trying again. \nStep 1...", "Something is wrong!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lockControls(bool _lock)
        {
            if (_lock) toolStripStatusLabel1.BackColor = Color.Red;
            else toolStripStatusLabel1.BackColor = Color.Green;
            button1.Enabled = !_lock;
            button2.Enabled = !_lock;
            button3.Enabled = !_lock;
            button4.Enabled = !_lock;
            comboBox1.Enabled = !_lock;

        }

        private void status(string status)
        {
            toolStripStatusLabel2.Text = status;
        }

        private string[] getJava()
        {
            string[] result = new string[1];
            return result;
        }

        private void PopulateComboBox2()
        {
            javaRuntimes = this.SearchKey("Installer\\Products", "DisplayName", "bin\\java.exe", "DisplayVersion");
            foreach (JavaRuntime javaRuntime in javaRuntimes)
            {
                comboBox2.Items.Add(javaRuntime.Name);
                if (javaRuntime.Name.Contains("17"))
                {
                    comboBox2.Text = javaRuntime.Name;
                }
            }
            if (javaRuntimes.Count == 0)
            {

            }
        }

        private List<JavaRuntime> SearchKey(string keyname, string data, string valueToFind, string returnValue)
        {

            List<JavaRuntime> javaRuntimes = new();
            RegistryKey uninstallKey = Registry.ClassesRoot.OpenSubKey(keyname);
            var programs = uninstallKey.GetSubKeyNames();

            foreach (var program in programs)
            {
                RegistryKey subkey = uninstallKey.OpenSubKey(program);
                foreach (string value in subkey.GetValueNames())
                {
                    if (subkey.GetValue(value).ToString().Contains(valueToFind))
                    {
                        JavaRuntime runtime = new();
                        runtime.Name = subkey.GetValue("ProductName").ToString();
                        runtime.Path = subkey.GetValue("ProductIcon").ToString();
                        javaRuntimes.Add(runtime);
                    }

                }
            }

            return javaRuntimes;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PopulateComboBox2();
        }

        private void downoadLink(string link)
        {
            Process myProcess = new Process();
            myProcess.StartInfo.UseShellExecute = true;
            myProcess.StartInfo.FileName = link;
            myProcess.Start();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            downoadLink("https://download.oracle.com/java/17/archive/jdk-17.0.11_windows-x64_bin.msi");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            downoadLink("https://download.java.net/java/GA/jdk17.0.2/dfd4a8d0985749f896bed50d7138ee7f/8/GPL/openjdk-17.0.2_windows-x64_bin.zip");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            downoadLink("https://aka.ms/download-jdk/microsoft-jdk-17.0.12-windows-x64.msi");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string java = "java";
            if (javaPath.Length > 0)
            {
                java = javaPath;
            }
            string sequence = "@user_jvm_args.txt @libraries/net/minecraftforge/forge/1.18.2-40.2.9/win_args.txt %*";
            if (checkBox1.Checked)
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                using var shortcut = new WindowsShortcut
                {
                    WorkingDirectory = installPath,
                    Arguments = sequence,
                    Path = java,
                    Description = "Start your Vault Hunters Server"
                };
                shortcut.Save(desktopPath + "\\Start VH Server.lnk");
            }
            if (checkBox2.Checked)
            {
                ExecAction ea = new();
                ea.WorkingDirectory = installPath;
                ea.Arguments = sequence;
                ea.Path = java;
                string taskName = "Start Vault Hunters Server";
                TaskDefinition td = TaskService.Instance.NewTask();
                td.RegistrationInfo.Description = "An automated startup for your Vault Hunters Server";
                td.Actions.Add(ea);
                td.Triggers.AddNew(TaskTriggerType.Logon);
                var folder = TaskService.Instance.RootFolder.CreateFolder("Vault Hunters");
                folder.RegisterTaskDefinition(taskName, td);

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (javaRuntimes != null)
            {
                foreach (var javaRuntime in javaRuntimes)
                {
                    if (javaRuntime.Name == comboBox2.Text)
                    {
                        javaPath = javaRuntime.Path;
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button7.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            serverSettingsForm settingsForm = new serverSettingsForm(installPath);
            settingsForm.ShowDialog();
        }
    }
}