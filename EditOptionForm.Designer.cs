namespace ClientApplication
{
    partial class EditOptionForm
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
            OptCategory = new TextBox();
            label3 = new Label();
            OptValue = new TextBox();
            label2 = new Label();
            label1 = new Label();
            OptName = new TextBox();
            UpdBtn = new Button();
            SuspendLayout();
            // 
            // OptCategory
            // 
            OptCategory.Location = new Point(56, 271);
            OptCategory.Name = "OptCategory";
            OptCategory.Size = new Size(100, 23);
            OptCategory.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 233);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 20;
            label3.Text = "Category";
            // 
            // OptValue
            // 
            OptValue.Location = new Point(56, 183);
            OptValue.Name = "OptValue";
            OptValue.Size = new Size(100, 23);
            OptValue.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 145);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 18;
            label2.Text = "Option value";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 67);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 17;
            label1.Text = "Option name";
            // 
            // OptName
            // 
            OptName.Location = new Point(56, 102);
            OptName.Name = "OptName";
            OptName.Size = new Size(100, 23);
            OptName.TabIndex = 16;
            // 
            // UpdBtn
            // 
            UpdBtn.Location = new Point(56, 342);
            UpdBtn.Name = "UpdBtn";
            UpdBtn.Size = new Size(141, 23);
            UpdBtn.TabIndex = 15;
            UpdBtn.Text = "Update the option";
            UpdBtn.UseVisualStyleBackColor = true;
            UpdBtn.Click += AddBtn_Click;
            // 
            // EditOptionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OptCategory);
            Controls.Add(label3);
            Controls.Add(OptValue);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(OptName);
            Controls.Add(UpdBtn);
            Name = "EditOptionForm";
            Text = "EditOptionForm";
            Load += EditOptionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox OptCategory;
        private Label label3;
        private TextBox OptValue;
        private Label label2;
        private Label label1;
        private TextBox OptName;
        private Button UpdBtn;
    }
}