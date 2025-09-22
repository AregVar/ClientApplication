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
    public partial class AddOptionForm : Form
    {
        public AddOptionForm()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string name = OptName.Text;
            string value = OptValue.Text;
            string category = Category.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(value))
            {
                MessageBox.Show("Please enter both template name and value.");
            }
            else
            {
                var req = new
                {
                    OptionName = name,
                    OptionValue = value,
                    Category = category
                };

                var json = System.Text.Json.JsonSerializer.Serialize(req);
                var client = new HttpClient();
                try
                {
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = client.PostAsync("https://localhost:7038/api/options", content).Result;
                    //EmailSend.TemplateAdd(name, body);
                    MessageBox.Show("Option added successfully.");
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
