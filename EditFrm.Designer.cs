namespace ClientApplication
{
    partial class EditFrm
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
            TemplateName = new TextBox();
            TemplateBody = new RichTextBox();
            UpdBtn = new Button();
            label3 = new Label();
            TemplateId = new TextBox();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            Gender = new TextBox();
            label4 = new Label();
            label5 = new Label();
            IsDef = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 146);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 11;
            label2.Text = "Template body";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 79);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 10;
            label1.Text = "Template name";
            // 
            // TemplateName
            // 
            TemplateName.Location = new Point(33, 103);
            TemplateName.Name = "TemplateName";
            TemplateName.Size = new Size(100, 23);
            TemplateName.TabIndex = 9;
            // 
            // TemplateBody
            // 
            TemplateBody.Location = new Point(33, 172);
            TemplateBody.Name = "TemplateBody";
            TemplateBody.Size = new Size(734, 219);
            TemplateBody.TabIndex = 8;
            TemplateBody.Text = "";
            // 
            // UpdBtn
            // 
            UpdBtn.Location = new Point(585, 129);
            UpdBtn.Name = "UpdBtn";
            UpdBtn.Size = new Size(141, 23);
            UpdBtn.TabIndex = 7;
            UpdBtn.Text = "Update the template";
            UpdBtn.UseVisualStyleBackColor = true;
            UpdBtn.Click += UpdBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 15);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 13;
            label3.Text = "Template id";
            // 
            // TemplateId
            // 
            TemplateId.Location = new Point(33, 44);
            TemplateId.Name = "TemplateId";
            TemplateId.Size = new Size(100, 23);
            TemplateId.TabIndex = 12;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(792, 15);
            webView21.Name = "webView21";
            webView21.Size = new Size(449, 423);
            webView21.TabIndex = 14;
            webView21.ZoomFactor = 1D;
            webView21.Click += webView21_Click;
            // 
            // Gender
            // 
            Gender.Location = new Point(188, 103);
            Gender.Name = "Gender";
            Gender.Size = new Size(100, 23);
            Gender.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(323, 79);
            label4.Name = "label4";
            label4.Size = new Size(163, 15);
            label4.TabIndex = 21;
            label4.Text = "Is default template for gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(188, 79);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 20;
            label5.Text = "Template gender";
            // 
            // IsDef
            // 
            IsDef.AutoSize = true;
            IsDef.Location = new Point(392, 107);
            IsDef.Name = "IsDef";
            IsDef.Size = new Size(15, 14);
            IsDef.TabIndex = 22;
            IsDef.UseVisualStyleBackColor = true;
            // 
            // EditFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 450);
            Controls.Add(IsDef);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(Gender);
            Controls.Add(webView21);
            Controls.Add(label3);
            Controls.Add(TemplateId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TemplateName);
            Controls.Add(TemplateBody);
            Controls.Add(UpdBtn);
            Name = "EditFrm";
            Text = "Edit Tempate";
            Load += EditFrm_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox TemplateName;
        private RichTextBox TemplateBody;
        private Button UpdBtn;
        private Label label3;
        private TextBox TemplateId;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private TextBox Gender;
        private Label label4;
        private Label label5;
        private CheckBox IsDef;
    }
}