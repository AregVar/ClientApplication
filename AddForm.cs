using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ClientApplication
{
    public partial class AddTemplateFrm : Form
    {
        public AddTemplateFrm()
        {
            InitializeComponent();
            TemplateBody.TextChanged += TemplateBody_TextChanged;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string name = TemplateName.Text;
            string body = TemplateBody.Text;
            string gender = Gender.Text;
            bool IsDefault = this.IsDef.Checked;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(body) || string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Please enter template name, gender and body.");
            }
            else
            {
                var req = new
                {
                    Name = name,
                    Body = body,
                    Gender = gender,
                    IsDefault = IsDefault
                };

                var json = System.Text.Json.JsonSerializer.Serialize(req);
                var client = new HttpClient();
                try
                {
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = client.PostAsync($"{(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServiceHost.txt"))).Trim()}/api/templates", content).Result;
                    //EmailSend.TemplateAdd(name, body);
                    MessageBox.Show("Template added/updated successfully.");
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
        }

        private async void TemplateBody_TextChanged(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async();
            webView21.NavigateToString(TemplateBody.Text);
        }
    }
}
