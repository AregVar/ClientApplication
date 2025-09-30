using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApplication
{
    public partial class AllOptions : Form
    {
        TemplateOptions optForm = new TemplateOptions();
        SMTPOptions smtpForm = new SMTPOptions();
        private static Process? _serviceProcess;
        string pathToExe = string.Empty;
        ManualSend manualSendForm = new ManualSend();
        string ServiceName;


        public AllOptions()
        {
            InitializeComponent();
            string pathConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServiceName.txt");
            if (!File.Exists(pathConfig))
            {
                string input = Interaction.InputBox("Please enter your rest service name", "Rest Service Name", "");
                //while (string.IsNullOrWhiteSpace(input))
                //{
                //    input = Interaction.InputBox("Please enter your rest service name", "Rest Service Name", "");
                //}
                File.WriteAllText(pathConfig, input.Trim());
            }
            using var reader = new StreamReader(pathConfig);
            ServiceName = reader.ReadToEnd().Trim();
            bool exists = ServiceController.GetServices().Any(s => s.ServiceName == ServiceName);
            if (!exists)
            {
                OptionsTab.TabPages.Remove(tabPage3);
            }
            else
            {
                ServiceController sc = new ServiceController(ServiceName);
                if (sc.Status == ServiceControllerStatus.Stopped)
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

            OptionsTab.Height = this.Height - 50;
            OptionsTab.Width = this.Width - 50;
            tabPage1.Text = "Templates";
            tabPage2.Text = "Smtp Options";
            tabPage3.Text = "Service Options";
            tabPage4.Text = "Sending Preview";
            optForm.TopLevel = false;
            optForm.FormBorderStyle = FormBorderStyle.None;
            optForm.Dock = DockStyle.Fill;
            smtpForm.TopLevel = false;
            smtpForm.FormBorderStyle = FormBorderStyle.None;
            smtpForm.Dock = DockStyle.Fill;
            manualSendForm.TopLevel = false;
            manualSendForm.FormBorderStyle = FormBorderStyle.None;
            manualSendForm.Dock = DockStyle.Fill;


            tabPage1.Controls.Add(optForm);
            optForm.Show();
            tabPage2.Controls.Add(smtpForm);
            smtpForm.Show();
            tabPage4.Controls.Add(manualSendForm);
            manualSendForm.Show();
        }


        private void StartBtn_Click(object sender, EventArgs e)
        {
            ServiceController sc = new ServiceController(ServiceName);

            if (sc.Status == ServiceControllerStatus.Stopped)
            {
                sc.Start();
                sc.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(10));
            }
            StopBtn.Enabled = true;
            StartBtn.Enabled = false;
        }

        //public string GetRestClientName()
        //{
        //    string pathConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.txt");
        //    if (!File.Exists(pathConfig))
        //    {
        //        MessageBox.Show("file config.txt not found!");
        //        return string.Empty;
        //    }
        //    string restClientPath = File.ReadAllText(pathConfig).Trim();
        //    if (!File.Exists(restClientPath))
        //    {
        //        MessageBox.Show($"RestClientFinal не найден по пути: {restClientPath}");
        //        return string.Empty;
        //    }
        //    return restClientPath;
        //}

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
            ServiceController sc = new ServiceController(ServiceName);

            if (sc.Status == ServiceControllerStatus.Running)
            {
                sc.Stop();
                sc.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(10));
            }
            StopBtn.Enabled = false;
            StartBtn.Enabled = true;
        }

        private void ServiceNameChange_Click(object sender, EventArgs e)
        {
            string pathConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServiceName.txt");
            string input = Interaction.InputBox("Please enter your rest service name", "Rest Service Name", "");
            //while (string.IsNullOrWhiteSpace(input))
            //{
            //    input = Interaction.InputBox("Please enter your rest service name", "Rest Service Name", "");
            //}
            File.WriteAllText(pathConfig, input.Trim());
            ServiceName = input.Trim();
            bool exists = ServiceController.GetServices().Any(s => s.ServiceName == ServiceName);
            if (!exists)
            {
                OptionsTab.TabPages.Remove(tabPage3);
            }
            else
            {
                if (!OptionsTab.TabPages.Contains(tabPage3))
                    OptionsTab.TabPages.Insert(2, tabPage3);
              
                ServiceController sc = new ServiceController(ServiceName);
                if (sc.Status == ServiceControllerStatus.Stopped)
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

        }
    }
}
