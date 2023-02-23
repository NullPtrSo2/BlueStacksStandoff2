using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace StandoffBlueStacks
{
    public partial class Form1 : Form
    {
        string version = "", cpu = "", gpu = "", gpuDriverVersion = "", ram = "";
        public Form1()
        {
            SetGpuInfo();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customName_TextChanged(object sender, EventArgs e)
        {

        }

        private void upgradeGpuDruverButton_Click(object sender, EventArgs e)
        {
            if (gpu.ToLower().Contains("amd") || gpu.ToLower().Contains("radeon") || gpu.ToLower().Contains("radeon rx"))
            {
                Process.Start("https://www.amd.com/en/support");
            }
            else if (gpu.ToLower().Contains("nvidia"))
            {
                Process.Start("https://www.nvidia.com/download/");
            }
            else if (gpu.ToLower().Contains("intel"))
            {
                Process.Start("https://www.intel.ru/content/www/ru/ru/download/18369/latest.html?");
            }
            else
            {
                MessageBox.Show("Извините, мы не смогли определить производителя вашей видеокарты :(");
            }
        }

        private void setNvidiaProfile_Click(object sender, EventArgs e)
        {
            if (gpu.ToLower().Contains("nvidia"))
            {
                Process.Start(Environment.CurrentDirectory.ToString() + @"\install_profile.bat");
            }
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == system_tab)
            {
                SetSystemInfo();
            }
        }

        public async void SetSystemInfo()
        {
            await Task.Run(() =>
            {
                using (ManagementObjectSearcher osInfo = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem"))
                {
                    foreach (ManagementObject osObject in osInfo.Get())
                    {
                        if (osObject["Caption"] != null)
                        {
                            version = osObject["Caption"].ToString();
                            osData.Text = $"Система: {osObject["Caption"]}";
                        }
                    }
                }

                using (RegistryKey cpuInfo = Registry.LocalMachine.OpenSubKey(@"Hardware\Description\System\CentralProcessor\0", RegistryKeyPermissionCheck.ReadSubTree))
                {
                    if (cpuInfo != null)
                    {
                        cpu = cpuInfo.GetValue("ProcessorNameString").ToString();
                    }
                }

                using (ManagementObjectSearcher ramInfo = new ManagementObjectSearcher("SELECT Capacity FROM Win32_PhysicalMemory"))
                {
                    foreach (ManagementObject ramObject in ramInfo.Get())
                    {
                        ram = (Convert.ToInt64(ramObject.Properties["Capacity"].Value) / 1024 / 1024 / 512).ToString();
                    }
                }

                SetGpuInfo();

                osData.Text = $"Характеристики вашего ПК:\nСистема: {version}\nПроцессор: {cpu}\nВидеокарта: {gpu}\nОперативная память: {ram} GB";
            });
        }

        public async void SetGpuInfo()
        {
            await Task.Run(() =>
            {
                using (ManagementObjectSearcher gpuInfo = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController"))
                {
                    foreach (ManagementObject gpuObject in gpuInfo.Get())
                    {
                        if (gpuObject["Name"] != null)
                        {
                            gpu = gpuObject["Name"].ToString();
                            gpuDriverVersion = gpuObject["DriverVersion"].ToString();
                        }
                    }
                }
                if (gpu.ToLower().Contains("nvidia"))
                {
                    setNvidiaProfile.Visible = true;
                }
                else
                {
                    setNvidiaProfile.Visible = false;
                }
                gpuData.Text = $"Видеокарта: {gpu}\nВерсия драйвера: {gpuDriverVersion}";
            });
        }

        private void setBlueStacksCustomName_Click(object sender, EventArgs e)
        {
            try
            {
                if (customName.Text != null && customName.Text != "")
                {
                    if (RegistryUtils.GetValue(@"Software\BlueStacks", "Version").ToString() != customName.Text)
                    {
                        RegistryUtils.SetValue(@"Software\BlueStacks", "ClientVersion", customName.Text);
                        RegistryUtils.SetValue(@"Software\BlueStacks", "Version", customName.Text);
                        MessageBox.Show($"Имя \"{customName.Text}\" установлено для BlueStacks");
                    }
                    else
                    {
                        MessageBox.Show($"Данное имя уже установлено для BlueStacks");
                    }
                }
                else
                {
                    MessageBox.Show("Имя не может быть пустым");
                }
            }
            catch (SecurityException)
            {
                MessageBox.Show("Запустите прогрпамму от имени администратора");
            }
        }
    }
}
