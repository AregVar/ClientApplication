using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApplication
{
    public partial class Options : Form
    {
        private string pathToExe = string.Empty; 
        private static TemplateOptions? _templateOptions;
        private static Process? _serviceProcess;
        public Options()
        {
            InitializeComponent();


            //_serviceProcess = new Process();
            //_serviceProcess.StartInfo.FileName = GetRestClientPath();
            //_serviceProcess.StartInfo.UseShellExecute = true;
            //if(!string.IsNullOrEmpty(_serviceProcess.StartInfo.FileName))
            //    _serviceProcess.Start();
            //else
            //    _serviceProcess = null;

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

        private void StartBtn_Click(object sender, EventArgs e)
        {
            //if (_serviceProcess == null || _serviceProcess.HasExited)
            //{

                //_serviceProcess = new Process();
                //_serviceProcess.StartInfo.FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RestClientFinal.exe");
                //_serviceProcess.StartInfo.UseShellExecute = true;



                //_serviceProcess = new Process();
                //_serviceProcess.StartInfo.FileName = GetRestClientPath();
                //_serviceProcess.StartInfo.UseShellExecute = true;
                //if (!string.IsNullOrEmpty(_serviceProcess.StartInfo.FileName))
                //    _serviceProcess.Start();
                //else
                //    _serviceProcess = null;

                _serviceProcess = new Process();
                _serviceProcess.StartInfo.FileName = GetRestClientPath();
                _serviceProcess.StartInfo.UseShellExecute = true;
                if (!string.IsNullOrEmpty(_serviceProcess.StartInfo.FileName))
                    _serviceProcess.Start();
                else
                    _serviceProcess = null;

                MessageBox.Show(AppDomain.CurrentDomain.BaseDirectory + " " + GetRestClientPath());
                StopBtn.Enabled = true;
                StartBtn.Enabled = false;

            //}
            

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

        private void TemplateBtn_Click(object sender, EventArgs e)
        {
            _templateOptions = new TemplateOptions();
            _templateOptions.Show();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            var path = string.Empty;
            using var ofd = new OpenFileDialog { Filter = "Executable|*.exe" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                pathToExe = path;
                File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.txt"), pathToExe);
            }
            
            MessageBox.Show(pathToExe);
        }
    }
}
