using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.ServiceProcess;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClientApplication.SMTPOptions;

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
            this.MaximizeBox = false;
            string pathConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServiceName.txt");
            if (!File.Exists(pathConfig))
            {
                string input = Interaction.InputBox("Please enter your rest client service name", "Rest Service Name", $"RestClientService");
                //while (string.IsNullOrWhiteSpace(input))
                //{
                //    input = Interaction.InputBox("Please enter your rest service name", "Rest Service Name", "");
                //}
                File.WriteAllText(pathConfig, input.Trim());
            }
            string pathConfig1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServiceHost.txt");
            if (!File.Exists(pathConfig1) || string.IsNullOrEmpty(File.ReadAllText(pathConfig1)))
            {
                string input = Interaction.InputBox("Please enter your rest client service host. You can't let it be empty or space.", "Rest Service Host", "http://localhost:7038");
                while (string.IsNullOrWhiteSpace(input))
                {
                    input = Interaction.InputBox("Please enter your rest client service host. You can't let it be empty or space.", "Rest Service Host", "http://localhost:7038");
                }
                File.WriteAllText(pathConfig1, input.Trim());
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
            tabPage5.Text = "Schedule";
            
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
            string input = Interaction.InputBox("Please enter your rest client service name", "Rest Service Name", $"{(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServiceName.txt"))).Trim()}");
            //while (string.IsNullOrWhiteSpace(input))
            //{
            //    input = Interaction.InputBox("Please enter your rest service name", "Rest Service Name", "");
            //}
            if (string.IsNullOrEmpty(input))
                input = (File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServiceName.txt"))).Trim();

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

        private void button1_Click(object sender, EventArgs e)
        {
            string pathConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServiceHost.txt");
            string input = Interaction.InputBox("Please enter your rest client service Host", "Rest Service Host", $"{(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServiceHost.txt"))).Trim()}");

            while (string.IsNullOrWhiteSpace(input))
            {
                input = Interaction.InputBox("Please enter your rest service name. You can't let it be empty or space.", "Rest Service Host", $"{(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServiceHost.txt"))).Trim()}");
            }
            File.WriteAllText(pathConfig, input.Trim());
        }

        private async void ScheduleSave_Click(object sender, EventArgs e)
        {
            HttpClient _httpClient = new HttpClient();
            if (string.IsNullOrWhiteSpace(Hour.Text) || string.IsNullOrWhiteSpace(Minute.Text) || string.IsNullOrWhiteSpace(Interval.Text))
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }
            if (!int.TryParse(Hour.Text, out int result) || !int.TryParse(Minute.Text, out int result1) || !int.TryParse(Interval.Text, out int result2))
            {
                MessageBox.Show("Please enter valid data (int numbers only).");
                return;
            }
            if(int.Parse(Interval.Text) < 10)
            {
                MessageBox.Show("IntervalSeconds must be at least 10 seconds for safety.");
                return;
            }

            try
            {
                var schedule = new ScheduleDto { Hour = int.Parse(this.Hour.Text), Minute = int.Parse(this.Minute.Text), IntervalSeconds = int.Parse(this.Interval.Text) };
                var json = JsonSerializer.Serialize(schedule);

                var content = new StringContent(json, Encoding.UTF8, "application/json");


                var res = await _httpClient.PostAsync($"{(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServiceHost.txt"))).Trim()}/api/schedule/update", content);
                MessageBox.Show($"Update of the schedule successfull");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during the editing of the schedule: {ex.Message}");
            }

        }

        public class ScheduleDto
        {
            public int Hour { get; set; }
            public int Minute { get; set; }
            public int IntervalSeconds { get; set; }
        }
        private async void GetData()
        {
            try
            {
                HttpClient _httpClient = new HttpClient();
                var res = await _httpClient.GetAsync($"{(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServiceHost.txt"))).Trim()}/api/schedule");
                res.EnsureSuccessStatusCode();

                var json = await res.Content.ReadAsStringAsync();

                var schedule = JsonSerializer.Deserialize<ScheduleDto>(json,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                Hour.Text = schedule.Hour.ToString();
                Minute.Text = schedule.Minute.ToString();
                Interval.Text = schedule.IntervalSeconds.ToString();
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during the retrival of templates: {ex.Message}");
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
