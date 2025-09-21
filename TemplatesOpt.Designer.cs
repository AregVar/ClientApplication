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
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(229, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(343, 203);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(316, 53);
            label1.Name = "label1";
            label1.Size = new Size(158, 32);
            label1.TabIndex = 1;
            label1.Text = "All Templates";
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(247, 344);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(75, 23);
            EditBtn.TabIndex = 2;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(369, 344);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 23);
            DeleteBtn.TabIndex = 3;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(481, 344);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 23);
            AddBtn.TabIndex = 4;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // RefreshBtn
            // 
            RefreshBtn.Location = new Point(91, 184);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(99, 41);
            RefreshBtn.TabIndex = 5;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(652, 28);
            button1.Name = "button1";
            button1.Size = new Size(99, 41);
            button1.TabIndex = 6;
            button1.Text = "Sync Data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(630, 72);
            label2.Name = "label2";
            label2.Size = new Size(142, 15);
            label2.TabIndex = 7;
            label2.Text = "Please sync data if service";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(635, 87);
            label3.Name = "label3";
            label3.Size = new Size(134, 15);
            label3.TabIndex = 8;
            label3.Text = "was turned on from app";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(543, 6);
            label4.Name = "label4";
            label4.Size = new Size(254, 15);
            label4.TabIndex = 9;
            label4.Text = "Sync data from the db of app and db of service";
            // 
            // TemplateOptions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(RefreshBtn);
            Controls.Add(AddBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
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
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}