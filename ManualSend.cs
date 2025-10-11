using System.Diagnostics;
using System.Text;
using System.Text.Json;
using System.Xml.Linq;
using static System.Windows.Forms.Design.AxImporter;

namespace ClientApplication
{
    public partial class ManualSend : Form
    {
        DbSendEmail dbSendEmailForm;
        //AddTemplateFrm opt;
        //Options optionsForm;
        //AllOptions optAll;
        public ManualSend()
        {
            InitializeComponent();
            dbSendEmailForm = new DbSendEmail();
            //opt = new AddTemplateFrm();
            //optionsForm = new Options();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(templateComboBox.Text))
            {
                MessageBox.Show("Please select a template. Also do not forget to press Refresh to get genders from db. After that you can choose the templates");
                return;
            }
            var req = new
            {
                SenderEmail = SendersEmail.Text,
                SenderPwd = SenderPwd.Text,
                SMTPHost = Host.Text,
                SMTPPort = Port.Text,
                Name = ResiverName.Text,
                Lname = ResiverLastName.Text,
                Email = ResiverEmail.Text,
                Gender = templateComboBox.Text,
                Company = Company.Text,
                Subject = MailSubject.Text
            };

            string json = System.Text.Json.JsonSerializer.Serialize(req);

            using var client = new HttpClient();
            try
            {
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = client.PostAsync($"{(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServiceHost.txt"))).Trim()}/api/manualsender", content).Result;

                //if (response.IsSuccessStatusCode)
                //{
                //    MessageBox.Show("Emails sent successfully!");
                //}
                //else
                //{
                //    MessageBox.Show("Failed to send emails. Status code: " + response.StatusCode);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                client.Dispose();
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //dbSendEmailForm = new DbSendEmail();
            //dbSendEmailForm.Show();
            using var client = new HttpClient();
            try
            {
                var json = "{}";
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync($"{(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServiceHost.txt"))).Trim()}/api/people", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Request successful!");
                }
                else
                {
                    var errorText = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error: {response.StatusCode} \nText: {errorText}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                client.Dispose();
            }
        }

        //private void OptionsBtn_Click(object sender, EventArgs e)
        //{
        //    optionsForm = new Options();
        //    optionsForm.Show();
        //}

        //private void OptionsAll_Click(object sender, EventArgs e)
        //{
        //    optAll = new AllOptions();
        //    optAll.Show();
        //}

        private void ManualSend_Load(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            using var client = new HttpClient();
            var json = "{}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServiceHost.txt"))).Trim()}/api/gender", content);
            var gendersJson = await response.Content.ReadAsStringAsync();


            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            genderComboBox.Items.Clear();
            var genders = JsonSerializer.Deserialize<List<string>>(gendersJson, options);
            genderComboBox.Items.AddRange(genders.ToArray());
            templateComboBox.Items.Clear();
        }

        private async void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            templateComboBox.Items.Clear();
            var selectedGender = genderComboBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedGender)) return;

            using var client = new HttpClient();
            var requestJson = JsonSerializer.Serialize(new { Gender = selectedGender });
            var content = new StringContent(requestJson, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServiceHost.txt"))).Trim()}/api/gender/gettemplates", content);
            var templatesJson = await response.Content.ReadAsStringAsync();
            var templates = JsonSerializer.Deserialize<List<string>>(templatesJson);
            foreach (var template in templates)
            {
                Debug.WriteLine(template);
            }
            templateComboBox.Items.AddRange(templates.ToArray());
            templateComboBox.SelectedIndex = 0;
        }

        private void templateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
