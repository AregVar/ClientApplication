using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;


namespace ClientApplication
{
    public partial class EditOptionForm : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();
        string OptionName;
        string OptionValue;
        string Category;

        string db_path;
        public EditOptionForm(string optionName, string optionValue, string category)
        {
            InitializeComponent();
            OptionName = optionName;
            OptionValue = optionValue;
            Category = category;
            this.MinimumSize = new Size(300, 500);
        }

        public EditOptionForm(string optionName, string optionValue, string category, string dbpath)
        {
            InitializeComponent();
            OptionName = optionName;
            OptionValue = optionValue;
            Category = category;
            this.MinimumSize = new Size(300, 500);
            db_path = dbpath;

            UpdBtn.Click -= EditBtn_Click;
            UpdBtn.Click += new EventHandler(EditAltBtn_Click);
        }



        private async void EditBtn_Click(object sender, EventArgs e)
        {
            if (OptValue.Text == OptionValue && OptCategory.Text == Category)
            {
                MessageBox.Show("No changes detected.");
                return;
            }
            
            if (OptName.Text == "SMTPPort" && !int.TryParse(OptValue.Text, out int re1))
            {
                MessageBox.Show("The port can only be int");
                return;
            }

            var confirm = MessageBox.Show($"You are about to update the option: {OptionName}, are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
            {
                return;
            }

            try
            {
                var option = new Options { OptionName = this.OptName.Text, OptionValue = this.OptValue.Text, Category = this.OptCategory.Text };
                var json = JsonSerializer.Serialize(option);
                
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var res = await _httpClient.PutAsync($"{(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServiceHost.txt"))).Trim()}/api/options", content);
                MessageBox.Show($"Update of the option successfull");

                OptionValue = OptValue.Text;
                Category = OptCategory.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during the editing of the option: {ex.Message}");
            }
            Close();
        }

        private async void EditAltBtn_Click(object sender, EventArgs e)
        {
            if (OptValue.Text == OptionValue && OptCategory.Text == Category)
            {
                MessageBox.Show("No changes detected.");
                return;
            }

            if (OptName.Text == "SMTPPort" && !int.TryParse(OptValue.Text, out int re2))
            {
                MessageBox.Show("The port can only be int");
                return;
            }

            var confirm = MessageBox.Show($"You are about to update the option: {OptionName}, are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
            {
                return;
            }

            try
            {
                using var connection = new SqliteConnection($"Data Source={db_path};Mode=ReadWrite;");
                connection.Open();
                string sql = "UPDATE OptionsTable SET OptionValue = @value, Category = @category WHERE OptionName = @name";
                using var command = new SqliteCommand(sql, connection);
                command.Parameters.AddWithValue("@name", OptName.Text);
                command.Parameters.AddWithValue("@value", OptValue.Text);
                command.Parameters.AddWithValue("@category", OptCategory.Text);
                command.ExecuteNonQuery();

                MessageBox.Show($"Update of the option successfull");

                OptionValue = OptValue.Text;
                Category = OptCategory.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during the editing of the option: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private class Options
        {
            public string? OptionName { get; set; }
            public string? OptionValue { get; set; }
            public string? Category { get; set; }
        }

        private void EditOptionForm_Load(object sender, EventArgs e)
        {
            OptName.Text = OptionName;
            OptValue.Text = OptionValue;
            OptCategory.Text = Category;
            OptName.ReadOnly = true;
        }
    }
}
