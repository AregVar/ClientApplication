namespace ClientApplication
{
    partial class AddOptionForm
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
            label2 = new Label();
            label1 = new Label();
            OptName = new TextBox();
            AddBtn = new Button();
            OptValue = new TextBox();
            Category = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 137);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 11;
            label2.Text = "Option value";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 59);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 10;
            label1.Text = "Option name";
            // 
            // OptName
            // 
            OptName.Location = new Point(33, 94);
            OptName.Name = "OptName";
            OptName.Size = new Size(100, 23);
            OptName.TabIndex = 9;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(33, 334);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(141, 23);
            AddBtn.TabIndex = 7;
            AddBtn.Text = "Add the option";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // OptValue
            // 
            OptValue.Location = new Point(33, 175);
            OptValue.Name = "OptValue";
            OptValue.Size = new Size(100, 23);
            OptValue.TabIndex = 12;
            // 
            // Category
            // 
            Category.Location = new Point(33, 263);
            Category.Name = "Category";
            Category.Size = new Size(100, 23);
            Category.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 225);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 13;
            label3.Text = "Category";
            // 
            // AddOptionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Category);
            Controls.Add(label3);
            Controls.Add(OptValue);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(OptName);
            Controls.Add(AddBtn);
            Name = "AddOptionForm";
            Text = "AddOptionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox OptName;
        private Button AddBtn;
        private TextBox OptValue;
        private TextBox Category;
        private Label label3;
    }
}