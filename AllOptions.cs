using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApplication
{
    public partial class AllOptions : Form
    {
        TemplateOptions optForm = new TemplateOptions();
        private static Process? _serviceProcess;
        string pathToExe = string.Empty;

        public AllOptions()
        {
            InitializeComponent();
            if (_serviceProcess == null || _serviceProcess.HasExited)
            {
                StopBtn.Enabled = false;
                StartBtn.Enabled = true;
            }
            else
            {
                StopBtn.Enabled = true;
                StartBtn.Enabled = false;
            }
            OptionsTab.Height = this.Height - 50;
            OptionsTab.Width = this.Width - 50;
            tabPage1.Text = "Templates";
            tabPage2.Text = "Smtp Options";
            tabPage3.Text = "Service Options";
            optForm.TopLevel = false;
            optForm.FormBorderStyle = FormBorderStyle.None;
            optForm.Dock = DockStyle.Fill;

            tabPage1.Controls.Add(optForm);
            optForm.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            _serviceProcess = new Process();
            _serviceProcess.StartInfo.FileName = GetRestClientPath();
            _serviceProcess.StartInfo.UseShellExecute = true;
            if (!string.IsNullOrEmpty(_serviceProcess.StartInfo.FileName))
                _serviceProcess.Start();
            else
                _serviceProcess = null;

            StopBtn.Enabled = true;
            StartBtn.Enabled = false;
        }

        public string GetRestClientPath()
        {
            string pathConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.txt");
            if (!File.Exists(pathConfig))
            {
                MessageBox.Show("Файл config.txt не найден!");
                return string.Empty;
            }
            string restClientPath = File.ReadAllText(pathConfig).Trim();
            if (!File.Exists(restClientPath))
            {
                MessageBox.Show($"RestClientFinal не найден по пути: {restClientPath}");
                return string.Empty;
            }
            return restClientPath;
        }

        private void ChangePath_Click(object sender, EventArgs e)
        {
            var path = string.Empty;
            using var ofd = new OpenFileDialog { Filter = "Executable|*.exe" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                pathToExe = path;
                File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.txt"), pathToExe);
            }

        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            if (_serviceProcess != null && !_serviceProcess.HasExited)
            {
                _serviceProcess.Kill();
                _serviceProcess = null;
                StopBtn.Enabled = false;
                StartBtn.Enabled = true;
            }
        }
    }
}
