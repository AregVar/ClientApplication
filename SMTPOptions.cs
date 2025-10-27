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
        string db_path;
        public SMTPOptions()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
        }

        public SMTPOptions(string dbpath)
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            db_path = dbpath;

            RefreshBtn.Click -= RefreshBtn_Click;
            
            RefreshBtn.Click += new EventHandler(RefreshAltBtn_Click);

            EditBtn.Click -= EditBtn_Click;
            EditBtn.Click += new EventHandler(EditAltBtn_Click);
        }

        private async void GetData()
        {
            try
            {
                
                var res = await _httpClient.GetAsync($"{(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServiceHost.txt"))).Trim()}/api/options");
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

        private void RefreshAltBtn_Click(object sender, EventArgs e)
        {
            GetDataAlt();
        }

        private void GetDataAlt()
        {
            try
            {
                var values = new List<Option>();
                using var connection = new SqliteConnection($"Data Source={db_path}");
                connection.Open();
                string sql = "SELECT * FROM OptionsTable";
                using var command = new SqliteCommand(sql, connection);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var info = new Option
                    {
                        OptionName = reader.GetString(0),
                        OptionValue = reader.GetString(1),
                        Category = reader.GetString(2)
                    };
                    values.Add(info);
                }

                var res = JsonSerializer.Serialize(values);

                var options = JsonSerializer.Deserialize<List<Option>>(res,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                dataGridView1.DataSource = options;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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

        private void EditAltBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("No row is selected");
                return;
            }

            string name = dataGridView1.CurrentRow.Cells["OptionName"].Value.ToString();
            string value = dataGridView1.CurrentRow.Cells["OptionValue"].Value.ToString();
            string category = dataGridView1.CurrentRow.Cells["Category"].Value.ToString();
            editForm = new EditOptionForm(name, value, category, db_path);
            editForm.ShowDialog();
            GetDataAlt();
        }

        public class Template
        {
            public long Id { get; set; }
            public string Name { get; set; }
            public string Body { get; set; }

            public string Gender { get; set; }
            public bool IsDefault { get; set; }

        }
        private async void SMTPOptions_Load(object sender, EventArgs e)
        {
            //await Task.Delay(20000);
            //GetData();
        }
    }
}
