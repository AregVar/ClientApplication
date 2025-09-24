namespace ClientApplication
{
    partial class AddTemplateFrm
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
            AddBtn = new Button();
            TemplateBody = new RichTextBox();
            TemplateName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(585, 149);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(141, 23);
            AddBtn.TabIndex = 0;
            AddBtn.Text = "Add the template";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // TemplateBody
            // 
            TemplateBody.Location = new Point(33, 192);
            TemplateBody.Name = "TemplateBody";
            TemplateBody.Size = new Size(734, 219);
            TemplateBody.TabIndex = 2;
            TemplateBody.Text = "";
            TemplateBody.TextChanged += TemplateBody_TextChanged;
            // 
            // TemplateName
            // 
            TemplateName.Location = new Point(33, 114);
            TemplateName.Name = "TemplateName";
            TemplateName.Size = new Size(100, 23);
            TemplateName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 79);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 5;
            label1.Text = "Template name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 157);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 6;
            label2.Text = "Template body";
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(779, 13);
            webView21.Name = "webView21";
            webView21.Size = new Size(401, 398);
            webView21.TabIndex = 15;
            webView21.ZoomFactor = 1D;
            // 
            // AddTemplateFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 450);
            Controls.Add(webView21);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TemplateName);
            Controls.Add(TemplateBody);
            Controls.Add(AddBtn);
            Name = "AddTemplateFrm";
            Text = "Add Template";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddBtn;
        private RichTextBox TemplateBody;
        private TextBox TemplateName;
        private Label label1;
        private Label label2;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}