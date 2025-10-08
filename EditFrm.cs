using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static ClientApplication.SMTPOptions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ClientApplication
{
    public partial class EditFrm : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private long Id;
        private string Name;
        private string Body;
        private string TemplGender;
        private bool IsDefault;
        public EditFrm(long id, string name, string body, string gender, bool isdef)
        {
            InitializeComponent();
            Name = name;
            Body = body;
            Id = id;
            genderComboBox.Items.Add(gender);
            if (gender == "man")
            {
                genderComboBox.Items.Add("woman");
            }
            else
            {
                genderComboBox.Items.Add("man");
            }
            genderComboBox.SelectedIndex = 0;
            TemplGender = genderComboBox.Text;
            //TemplGender = gedner;
            IsDefault = isdef;



            TemplateBody.TextChanged += TemplateBody_TextChanged;
            this.Resize += TemplatesForm_Resize;
            IsOnlyOneDef();
        }

        private void EditFrm_Load(object sender, EventArgs e)
        {
            TemplateName.Text = Name;
            TemplateBody.Text = Body;
            TemplateId.Text = Id.ToString();
            TemplateId.ReadOnly = true;
            //Gender.Text = TemplGender;
            IsDef.Checked = IsDefault;
            webView21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            //TemplateBody.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TemplateBody.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom;
            UpdBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.MinimumSize = new Size(1200, 400);

        }

        public async void IsOnlyOneDef()
        {
            var res = await _httpClient.GetAsync($"{(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServiceHost.txt"))).Trim()}/api/templates"); res.EnsureSuccessStatusCode();

            var json = await res.Content.ReadAsStringAsync();

            var templates = JsonSerializer.Deserialize<List<Template>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            int defCount = 0;
            foreach (var template in templates)
            {
                if (template.IsDefault == true && template.Name != TemplateName.Text && template.Gender == genderComboBox.Text)
                {
                    //MessageBox.Show($"{template.Name} {template.IsDefault}");
                    defCount++;
                    break;
                }
            }
            if (defCount == 0 && IsDef.Checked)
            {
                IsDef.Enabled = false;
                genderComboBox.Enabled = false;
            }
            else
            {
                IsDef.Enabled = true;
                genderComboBox.Enabled = true;
            }

        }

        private async void UpdBtn_Click(object sender, EventArgs e)
        {


            if (TemplateName.Text == Name && TemplateBody.Text == Body && genderComboBox.Text == TemplGender && IsDef.Checked == IsDefault)
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
                var template = new Template { Name = this.TemplateName.Text, Body = this.TemplateBody.Text, Gender = this.genderComboBox.Text, IsDefault = IsDef.Checked };
                var json = JsonSerializer.Serialize(template);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var res = await _httpClient.PutAsync($"{(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServiceHost.txt"))).Trim()}/api/templates/{Id}", content);
                MessageBox.Show($"Update of the template successfull");

                Name = TemplateName.Text;
                Body = TemplateBody.Text;
                TemplGender = genderComboBox.Text;
                IsDefault = IsDef.Checked;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during the deletion of the template: {ex.Message}");
            }
            finally
            {
                Close();
            }

            

        }
        private class Template
        {
            public string? Name { get; set; }
            public string? Body { get; set; }
            public string? Gender { get; set; }
            public bool IsDefault { get; set; }
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private async void TemplateBody_TextChanged(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async();
            webView21.NavigateToString(TemplateBody.Text);
        }

        private void TemplatesForm_Resize(object sender, EventArgs e)
        {
            //webView21.Left = 10;
            //webView21.Top = 10;
            //webView21.Width = this.ClientSize.Width - 20;
            //webView21.Height = this.ClientSize.Height / 2 - 20;

            //// RichTextBox под webView2
            //TemplateBody.Left = 10;
            //TemplateBody.Top = webView21.Bottom + 10;
            //TemplateBody.Width = this.ClientSize.Width - 20;
            //TemplateBody.Height = this.ClientSize.Height - webView21.Height - 30;

            //// Меняем размер шрифта (увеличиваем на 1)
            //if (TemplateBody.Font.Size < 30) // ограничение, чтобы не рос бесконечно
            //{
            //    float newSize = TemplateBody.Font.Size + 1;
            //    TemplateBody.Font = new Font(TemplateBody.Font.FontFamily, newSize);
        }

        private void Gender_TextChanged(object sender, EventArgs e)
        {
            //IsOnlyOneDef();
        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsOnlyOneDef();
        }
    }
}


