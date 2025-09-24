using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using Microsoft.Web.WebView2.WinForms;

namespace ClientApplication
{
    public partial class EditFrm : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private long Id;
        private string Name;
        private string Body;
        public EditFrm(long id, string name, string body)
        {
            InitializeComponent();
            Name = name;
            Body = body;
            Id = id;

            TemplateBody.TextChanged += TemplateBody_TextChanged;
        }

        private void EditFrm_Load(object sender, EventArgs e)
        {
            TemplateName.Text = Name;
            TemplateBody.Text = Body;
            TemplateId.Text = Id.ToString();
            TemplateId.ReadOnly = true;
        }

        private async void UpdBtn_Click(object sender, EventArgs e)
        {


            if (TemplateName.Text == Name && TemplateBody.Text == Body)
            {
                MessageBox.Show("No changes detected.");
                return;
            }

            var confirm = MessageBox.Show($"You are about to update the template with ID: {Id}, are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
            {
                return;
            }

            try
            {
                var template = new Template { Name = this.TemplateName.Text, Body = this.TemplateBody.Text };
                var json = JsonSerializer.Serialize(template);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var res = await _httpClient.PutAsync($"http://localhost:7038/api/templates/{Id}", content);
                MessageBox.Show($"Update of the template successfull");

                Name = TemplateName.Text;
                Body = TemplateBody.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during the deletion of the template: {ex.Message}");
            }

        }
        private class Template
        {
            public string? Name { get; set; }
            public string? Body { get; set; }
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private async void TemplateBody_TextChanged(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async();
            webView21.NavigateToString(TemplateBody.Text);
        }
    }
}
