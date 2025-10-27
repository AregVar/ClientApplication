namespace ClientApplication
{
    partial class TemplateOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            EditBtn = new Button();
            DeleteBtn = new Button();
            AddBtn = new Button();
            RefreshBtn = new Button();
            genderComboBox = new ComboBox();
            ViewBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(166, 133);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(622, 271);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(394, 71);
            label1.Name = "label1";
            label1.Size = new Size(196, 41);
            label1.TabIndex = 1;
            label1.Text = "All Templates";
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(378, 457);
            EditBtn.Margin = new Padding(3, 4, 3, 4);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(86, 31);
            EditBtn.TabIndex = 2;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(518, 457);
            DeleteBtn.Margin = new Padding(3, 4, 3, 4);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(86, 31);
            DeleteBtn.TabIndex = 3;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(646, 457);
            AddBtn.Margin = new Padding(3, 4, 3, 4);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(86, 31);
            AddBtn.TabIndex = 4;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // RefreshBtn
            // 
            RefreshBtn.Location = new Point(31, 245);
            RefreshBtn.Margin = new Padding(3, 4, 3, 4);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(113, 55);
            RefreshBtn.TabIndex = 5;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // genderComboBox
            // 
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(705, 83);
            genderComboBox.Margin = new Padding(3, 4, 3, 4);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(82, 28);
            genderComboBox.TabIndex = 23;
            genderComboBox.SelectedIndexChanged += genderComboBox_SelectedIndexChanged;
            // 
            // ViewBtn
            // 
            ViewBtn.Location = new Point(237, 457);
            ViewBtn.Margin = new Padding(3, 4, 3, 4);
            ViewBtn.Name = "ViewBtn";
            ViewBtn.Size = new Size(86, 31);
            ViewBtn.TabIndex = 24;
            ViewBtn.Text = "View";
            ViewBtn.UseVisualStyleBackColor = true;
            ViewBtn.Click += ViewBtn_Click;
            // 
            // TemplateOptions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(ViewBtn);
            Controls.Add(genderComboBox);
            Controls.Add(RefreshBtn);
            Controls.Add(AddBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TemplateOptions";
            Text = "Templates Options";
            Load += TemplateOptions_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button EditBtn;
        private Button DeleteBtn;
        private Button AddBtn;
        private Button RefreshBtn;
        private ComboBox genderComboBox;
        private Button ViewBtn;
    }
}