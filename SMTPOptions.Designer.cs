namespace ClientApplication
{
    partial class SMTPOptions
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
            RefreshBtn = new Button();
            EditBtn = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // RefreshBtn
            // 
            RefreshBtn.Location = new Point(126, 198);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(99, 41);
            RefreshBtn.TabIndex = 11;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(407, 354);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(75, 23);
            EditBtn.TabIndex = 8;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(368, 67);
            label1.Name = "label1";
            label1.Size = new Size(132, 32);
            label1.TabIndex = 7;
            label1.Text = "All Options";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(264, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(343, 203);
            dataGridView1.TabIndex = 6;
            // 
            // SMTPOptions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RefreshBtn);
            Controls.Add(EditBtn);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "SMTPOptions";
            Text = "SMTPOptions";
            Load += SMTPOptions_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RefreshBtn;
        private Button EditBtn;
        private Label label1;
        private DataGridView dataGridView1;
    }
}