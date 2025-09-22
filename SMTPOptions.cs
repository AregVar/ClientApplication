using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApplication
{
    public partial class SMTPOptions : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();
        AllOptions allOptionsForm;
        AddOptionForm addOptionForm;
        EditOptionForm editForm;
        public SMTPOptions()
        {
            InitializeComponent();
        }

        private async void GetData()
        {
            try
            {
                var res = await _httpClient.GetAsync("https://localhost:7038/api/options");
                res.EnsureSuccessStatusCode();

                var json = await res.Content.ReadAsStringAsync();

                var options = JsonSerializer.Deserialize<List<Option>>(json,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                dataGridView1.DataSource = options;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during the retrival of templates: {ex.Message}");
            }
        }

        public class Option
        {
            public string? OptionName { get; set; }
            public string? OptionValue { get; set; }
            public string? Category { get; set; }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var confirm = MessageBox.Show($"You are about to delete the option: {dataGridView1.CurrentRow.Cells["OptionName"].Value}, are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.No)
                {
                    return;
                }

                try
                {
                    var res = await _httpClient.DeleteAsync($"https://localhost:7038/api/options/{dataGridView1.CurrentRow.Cells["OptionName"].Value}");
                    GetData();
                    MessageBox.Show($"Deletion of the option successfull");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during the option of the template: {ex.Message}");
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

            string name = dataGridView1.CurrentRow.Cells["OptionName"].Value.ToString();
            string value = dataGridView1.CurrentRow.Cells["OptionValue"].Value.ToString();
            string category = dataGridView1.CurrentRow.Cells["Category"].Value.ToString();
            editForm = new EditOptionForm(name, value, category);
            editForm.ShowDialog();
            GetData();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            addOptionForm = new AddOptionForm();
            addOptionForm.ShowDialog();
            GetData();
        }

        private void DataSync()
        {
            allOptionsForm = new AllOptions();
            string sourcePath = "options.db";
            string path = (allOptionsForm.GetRestClientPath()).Substring(0, (allOptionsForm.GetRestClientPath()).IndexOf("\\bin"));
            string targetPath = Path.Combine(path, "options.db");

            using var sourceConn = new SqliteConnection($"Data Source={sourcePath}");
            using var targetConn = new SqliteConnection($"Data Source={targetPath}");

            sourceConn.Open();
            targetConn.Open();

            string tableName = "OptionsTable";



            var clearCmd = targetConn.CreateCommand();
            clearCmd.CommandText = $"DELETE FROM {tableName}";
            int deleted = clearCmd.ExecuteNonQuery();



            var selectCmd = sourceConn.CreateCommand();
            selectCmd.CommandText = $"SELECT OptionName, OptionValue, Category FROM {tableName}";

            using var reader = selectCmd.ExecuteReader();

            while (reader.Read())
            {
                
                string name = reader.GetString(0);
                string value = reader.GetString(1);
                string category = reader.GetString(2);

                var insertCmd = targetConn.CreateCommand();
                insertCmd.CommandText = $"INSERT INTO {tableName} (OptionName, OptionValue, Category) VALUES (@name, @value, @category)";
                insertCmd.Parameters.AddWithValue("@name", name);
                insertCmd.Parameters.AddWithValue("@value", value);
                insertCmd.Parameters.AddWithValue("@category", category);
                insertCmd.ExecuteNonQuery();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataSync();
        }
    }
}
