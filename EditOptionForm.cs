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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ClientApplication
{
    public partial class EditOptionForm : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();
        string OptionName;
        string OptionValue;
        string Category;
        public EditOptionForm(string optionName, string optionValue, string category)
        {
            InitializeComponent();
            OptionName = optionName;
            OptionValue = optionValue;
            Category = category;
            this.MinimumSize = new Size(300, 500);
        }



        private async void AddBtn_Click(object sender, EventArgs e)
        {
            if (OptValue.Text == OptionValue && OptCategory.Text == Category)
            {
                MessageBox.Show("No changes detected.");
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
