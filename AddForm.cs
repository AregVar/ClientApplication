using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WriteEmail;

namespace ClientApplication
{
    public partial class AddTemplateFrm : Form
    {
        public AddTemplateFrm()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string name = TemplateName.Text;
            string body = TemplateBody.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(body))
            {
                MessageBox.Show("Please enter both template name and body.");
            }
            else
            {
                var req = new
                {
                    Name = name,
                    Body = body
                };
                
                var json = System.Text.Json.JsonSerializer.Serialize(req);
                var client = new HttpClient();
                try
                {
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = client.PostAsync("https://localhost:7038/api/templates", content).Result;
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
    }
}
