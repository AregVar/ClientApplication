using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ClientApplication
{
    public partial class TemplateOptions : Form
    {
        AddTemplateFrm addTemplateForm = new AddTemplateFrm();
        EditFrm editForm;
        Options optionsForm = new Options();
        private readonly HttpClient _httpClient = new HttpClient();
        private List<Template>? allTemplates = new List<Template>();
        public TemplateOptions()
        {
            InitializeComponent();
        }

        private async void TemplateOptions_Load(object sender, EventArgs e)
        {
            //await Task.Delay(20000);
            //GetData();
        }



        private async void GetData()
        {
            try
            {
                var res = await _httpClient.GetAsync($"{(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServiceHost.txt"))).Trim()}/api/templates");
                res.EnsureSuccessStatusCode();

                var json = await res.Content.ReadAsStringAsync();

                allTemplates = JsonSerializer.Deserialize<List<Template>>(json,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                dataGridView1.DataSource = new BindingList<Template>(allTemplates);
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.ReadOnly = true;
                genderComboBox.Items.Clear();
                //genderComboBox.Items.Clear();
                //genderComboBox.Items.Add("All");
                foreach (var template in allTemplates)
                {
                    if (!genderComboBox.Items.Contains("All"))
                        genderComboBox.Items.Add("All");
                    if (!genderComboBox.Items.Contains(template.Gender))
                        genderComboBox.Items.Add(template.Gender);
                }

                genderComboBox.SelectedIndex = 0;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during the retrival of templates: {ex.Message}");
            }
        }

        private class Template
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Body { get; set; }

            public string Gender { get; set; }
            public bool IsDefault { get; set; }
        }



        private async void RefreshBtn_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            addTemplateForm = new AddTemplateFrm();
            addTemplateForm.ShowDialog();
            GetData();
        }

        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var confirm = MessageBox.Show($"You are about to delete the template with ID: {dataGridView1.CurrentRow.Cells["Id"].Value}, are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.No)
                {
                    return;
                }

                try
                {
                    var res = await _httpClient.DeleteAsync($"{(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServiceHost.txt"))).Trim()}/api/templates/{dataGridView1.CurrentRow.Cells["Id"].Value}");
                    GetData();
                    MessageBox.Show($"Deletion of the template successfull");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during the deletion of the template: {ex.Message}");
                }

            }
            else
            {
                MessageBox.Show("No row is selected");
            }

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("No row is selected");
                return;
            }
            long id = Convert.ToInt64(dataGridView1.CurrentRow.Cells["Id"].Value);
            string name = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            string body = dataGridView1.CurrentRow.Cells["Body"].Value.ToString();
            string gender = dataGridView1.CurrentRow.Cells["Gender"].Value.ToString();
            bool isdef = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["IsDefault"].Value);
            editForm = new EditFrm(id, name, body, gender, isdef);
            editForm.ShowDialog();
            GetData();

        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (genderComboBox.SelectedItem == null) return;

            string selectedGender = genderComboBox.SelectedItem.ToString();

            if (selectedGender == "All")
            {
                dataGridView1.DataSource = new BindingList<Template>(allTemplates);
            }
            else
            {
                var filtered = allTemplates
                    .Where(t => t.Gender == selectedGender)
                    .ToList();

                dataGridView1.DataSource = new BindingList<Template>(filtered);
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.ReadOnly = true;

            }

        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("No row is selected");
                return;
            }
            long id = Convert.ToInt64(dataGridView1.CurrentRow.Cells["Id"].Value);
            string name = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            string body = dataGridView1.CurrentRow.Cells["Body"].Value.ToString();
            string gender = dataGridView1.CurrentRow.Cells["Gender"].Value.ToString();
            bool isdef = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["IsDefault"].Value);
            var editForm = new EditFrm(true, id, name, body, gender, isdef);
            
            editForm.ShowDialog();
        }
    }
}
