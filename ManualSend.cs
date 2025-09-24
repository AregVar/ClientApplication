using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

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
            var req = new
            {
                SenderEmail = SendersEmail.Text,
                SenderPwd = SenderPwd.Text,
                SMTPHost = Host.Text,
                SMTPPort = Port.Text,
                Name = ResiverName.Text,
                Lname = ResiverLastName.Text,
                Email = ResiverEmail.Text,
                Gender = Gender.Text,
                Company = Company.Text,
                Subject = MailSubject.Text
            };

            string json = System.Text.Json.JsonSerializer.Serialize(req);

            var client = new HttpClient();
            try
            {
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = client.PostAsync("http://localhost:7038/api/manualsender", content).Result;

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

        private void button1_Click(object sender, EventArgs e)
        {
            dbSendEmailForm = new DbSendEmail();
            dbSendEmailForm.Show();
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
    }
}
