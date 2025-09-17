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
    public partial class DbSendEmail : Form
    {
        public DbSendEmail()
        {
            InitializeComponent();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {

            var req = new
            {
                SenderEmail = SendersEmail.Text,
                SenderPwd = Password.Text,
                SMTPHost = Host.Text,
                SMTPPort = Port.Text
            };

            string json = System.Text.Json.JsonSerializer.Serialize(req);

            var client = new HttpClient();
            try
            {
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = client.PostAsync("https://localhost:7038/api/people", content).Result;

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

        private void Close_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
