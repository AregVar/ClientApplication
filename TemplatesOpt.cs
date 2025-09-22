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
        public TemplateOptions()
        {
            InitializeComponent();
        }

        private async void TemplateOptions_Load(object sender, EventArgs e)
        {
            GetData();
        }



        private async void GetData()
        {
            try
            {
                var res = await _httpClient.GetAsync("https://localhost:7038/api/templates");
                res.EnsureSuccessStatusCode();

                var json = await res.Content.ReadAsStringAsync();

                var templates = JsonSerializer.Deserialize<List<Template>>(json,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                dataGridView1.DataSource = templates;
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
        }

        private void DataSync()
        {
            string sourcePath = "options.db";
            string path = (optionsForm.GetRestClientPath()).Substring(0, (optionsForm.GetRestClientPath()).IndexOf("\\bin"));
            string targetPath = Path.Combine(path, "options.db");

            using var sourceConn = new SqliteConnection($"Data Source={sourcePath}");
            using var targetConn = new SqliteConnection($"Data Source={targetPath}");

            sourceConn.Open();
            targetConn.Open();

            string tableName = "Templates";



            var clearCmd = targetConn.CreateCommand();
            clearCmd.CommandText = $"DELETE FROM {tableName}";
            int deleted = clearCmd.ExecuteNonQuery();
           

            
            var selectCmd = sourceConn.CreateCommand();
            selectCmd.CommandText = $"SELECT Id, Name, Body FROM {tableName}";

            using var reader = selectCmd.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string body = reader.GetString(2);

                var insertCmd = targetConn.CreateCommand();
                insertCmd.CommandText = $"INSERT INTO {tableName} (Id, Name, Body) VALUES (@id, @name, @body)";
                insertCmd.Parameters.AddWithValue("@id", id);
                insertCmd.Parameters.AddWithValue("@name", name);
                insertCmd.Parameters.AddWithValue("@body", body);
                insertCmd.ExecuteNonQuery();
            }

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
                    var res = await _httpClient.DeleteAsync($"https://localhost:7038/api/templates/{dataGridView1.CurrentRow.Cells["Id"].Value}");
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
            editForm = new EditFrm(id, name, body);
            editForm.ShowDialog();
            GetData();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSync();
        }
    }
}
