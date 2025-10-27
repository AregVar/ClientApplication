using Microsoft.Web.WebView2.Core;
using System.Diagnostics;
using System.Text;
using System.Text.Json;
using System.Xml.Linq;
using static System.Windows.Forms.Design.AxImporter;

namespace ClientApplication
{
    public partial class ManualSend : Form
    {
        
        public ManualSend()
        {
            InitializeComponent();
            
        }

        private async void SendBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(templateComboBox.Text))
            {
                MessageBox.Show("Please select a template. Also do not forget to press Refresh to get genders from db. After that you can choose the templates", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(ResiverName.Text))
            {
                MessageBox.Show("Please enter persons first name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(ResiverLastName.Text))
            {
                MessageBox.Show("Please enter persons last name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(ResiverEmail.Text))
            {
                MessageBox.Show("Please enter persons email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(SendersEmail.Text))
            {
                MessageBox.Show("Please enter senders email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(Port.Text))
            {
                MessageBox.Show("Please enter SMTP port", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(Host.Text))
            {
                MessageBox.Show("Please enter SMTP host", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(SenderPwd.Text))
            {
                MessageBox.Show("Please enter senders email password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            string json = JsonSerializer.Serialize(req);

            using var client = new HttpClient();
            try
            {
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = client.PostAsync($"{(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServiceHost.txt"))).Trim()}/api/manualsender", content).Result;

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Emails sent successfully. Status code: " + response.StatusCode);
                }
                else
                {
                    var errorText = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Failed to send emails. Status code: " + response.StatusCode+", error: " +errorText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                client.Dispose();
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            
            //http://localhost:7038
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
                    MessageBox.Show($"An error occured: {errorText} {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "An error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                client.Dispose();
            }
        }

        private void ManualSend_Load(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "An error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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
                templateComboBox.Items.AddRange(templates.ToArray());
                templateComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "An error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void templateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
