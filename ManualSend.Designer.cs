namespace ClientApplication
{
    partial class ManualSend
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NameLeb = new Label();
            LastNameLeb = new Label();
            ResiverLab = new Label();
            ResiverName = new TextBox();
            ResiverLastName = new TextBox();
            ResiverEmail = new TextBox();
            Gender = new TextBox();
            GenderLab = new Label();
            SendBtn = new Button();
            SendersEmail = new TextBox();
            SenderLab = new Label();
            Host = new TextBox();
            label1 = new Label();
            SmtpSetLab = new Label();
            Port = new TextBox();
            label2 = new Label();
            SenderPwd = new TextBox();
            label3 = new Label();
            button1 = new Button();
            MailSubject = new TextBox();
            MailSubjLab = new Label();
            Company = new TextBox();
            label4 = new Label();
            OptionsBtn = new Button();
            OptionsAll = new Button();
            SuspendLayout();
            // 
            // NameLeb
            // 
            NameLeb.AutoSize = true;
            NameLeb.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameLeb.Location = new Point(76, 54);
            NameLeb.Name = "NameLeb";
            NameLeb.Size = new Size(52, 21);
            NameLeb.TabIndex = 0;
            NameLeb.Text = "Name";
            // 
            // LastNameLeb
            // 
            LastNameLeb.AutoSize = true;
            LastNameLeb.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LastNameLeb.Location = new Point(61, 104);
            LastNameLeb.Name = "LastNameLeb";
            LastNameLeb.Size = new Size(84, 21);
            LastNameLeb.TabIndex = 1;
            LastNameLeb.Text = "Last Name";
            // 
            // ResiverLab
            // 
            ResiverLab.AutoSize = true;
            ResiverLab.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResiverLab.Location = new Point(51, 154);
            ResiverLab.Name = "ResiverLab";
            ResiverLab.Size = new Size(110, 21);
            ResiverLab.TabIndex = 2;
            ResiverLab.Text = "Resivers Email";
            // 
            // ResiverName
            // 
            ResiverName.Location = new Point(167, 56);
            ResiverName.Name = "ResiverName";
            ResiverName.Size = new Size(175, 23);
            ResiverName.TabIndex = 0;
            // 
            // ResiverLastName
            // 
            ResiverLastName.Location = new Point(167, 106);
            ResiverLastName.Name = "ResiverLastName";
            ResiverLastName.Size = new Size(175, 23);
            ResiverLastName.TabIndex = 1;
            // 
            // ResiverEmail
            // 
            ResiverEmail.Location = new Point(167, 154);
            ResiverEmail.Name = "ResiverEmail";
            ResiverEmail.Size = new Size(175, 23);
            ResiverEmail.TabIndex = 2;
            // 
            // Gender
            // 
            Gender.Location = new Point(167, 209);
            Gender.Name = "Gender";
            Gender.Size = new Size(175, 23);
            Gender.TabIndex = 3;
            // 
            // GenderLab
            // 
            GenderLab.AutoSize = true;
            GenderLab.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GenderLab.Location = new Point(76, 211);
            GenderLab.Name = "GenderLab";
            GenderLab.Size = new Size(61, 21);
            GenderLab.TabIndex = 6;
            GenderLab.Text = "Gender";
            // 
            // SendBtn
            // 
            SendBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SendBtn.Location = new Point(602, 354);
            SendBtn.Name = "SendBtn";
            SendBtn.Size = new Size(137, 39);
            SendBtn.TabIndex = 10;
            SendBtn.Text = "Send email";
            SendBtn.UseVisualStyleBackColor = true;
            SendBtn.Click += SendBtn_Click;
            // 
            // SendersEmail
            // 
            SendersEmail.Location = new Point(167, 261);
            SendersEmail.Name = "SendersEmail";
            SendersEmail.Size = new Size(175, 23);
            SendersEmail.TabIndex = 4;
            // 
            // SenderLab
            // 
            SenderLab.AutoSize = true;
            SenderLab.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SenderLab.Location = new Point(49, 263);
            SenderLab.Name = "SenderLab";
            SenderLab.Size = new Size(108, 21);
            SenderLab.TabIndex = 9;
            SenderLab.Text = "Senders email";
            // 
            // Host
            // 
            Host.Location = new Point(576, 147);
            Host.Name = "Host";
            Host.Size = new Size(175, 23);
            Host.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(483, 147);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 11;
            label1.Text = "SMTP host";
            // 
            // SmtpSetLab
            // 
            SmtpSetLab.AutoSize = true;
            SmtpSetLab.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SmtpSetLab.Location = new Point(546, 99);
            SmtpSetLab.Name = "SmtpSetLab";
            SmtpSetLab.Size = new Size(148, 28);
            SmtpSetLab.TabIndex = 13;
            SmtpSetLab.Text = "SMTP Settings";
            // 
            // Port
            // 
            Port.Location = new Point(576, 202);
            Port.Name = "Port";
            Port.Size = new Size(175, 23);
            Port.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(483, 202);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 14;
            label2.Text = "SMTP port";
            // 
            // SenderPwd
            // 
            SenderPwd.Location = new Point(576, 254);
            SenderPwd.Name = "SenderPwd";
            SenderPwd.Size = new Size(175, 23);
            SenderPwd.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(429, 256);
            label3.Name = "label3";
            label3.Size = new Size(137, 21);
            label3.TabIndex = 16;
            label3.Text = "Senders password";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(664, 0);
            button1.Name = "button1";
            button1.Size = new Size(136, 34);
            button1.TabIndex = 11;
            button1.Text = "Use DB to send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MailSubject
            // 
            MailSubject.Location = new Point(167, 304);
            MailSubject.Name = "MailSubject";
            MailSubject.Size = new Size(175, 23);
            MailSubject.TabIndex = 5;
            // 
            // MailSubjLab
            // 
            MailSubjLab.AutoSize = true;
            MailSubjLab.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MailSubjLab.Location = new Point(62, 306);
            MailSubjLab.Name = "MailSubjLab";
            MailSubjLab.Size = new Size(95, 21);
            MailSubjLab.TabIndex = 19;
            MailSubjLab.Text = "Mail Subject";
            // 
            // Company
            // 
            Company.Location = new Point(167, 354);
            Company.Name = "Company";
            Company.Size = new Size(175, 23);
            Company.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(76, 354);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 21;
            label4.Text = "Company";
            // 
            // OptionsBtn
            // 
            OptionsBtn.Location = new Point(0, 0);
            OptionsBtn.Name = "OptionsBtn";
            OptionsBtn.Size = new Size(75, 34);
            OptionsBtn.TabIndex = 22;
            OptionsBtn.Text = "Options";
            OptionsBtn.UseVisualStyleBackColor = true;
            OptionsBtn.Click += OptionsBtn_Click;
            // 
            // OptionsAll
            // 
            OptionsAll.Location = new Point(12, 404);
            OptionsAll.Name = "OptionsAll";
            OptionsAll.Size = new Size(75, 34);
            OptionsAll.TabIndex = 23;
            OptionsAll.Text = "Options";
            OptionsAll.UseVisualStyleBackColor = true;
            OptionsAll.Click += OptionsAll_Click;
            // 
            // ManualSend
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OptionsAll);
            Controls.Add(OptionsBtn);
            Controls.Add(Company);
            Controls.Add(label4);
            Controls.Add(MailSubject);
            Controls.Add(MailSubjLab);
            Controls.Add(button1);
            Controls.Add(SenderPwd);
            Controls.Add(label3);
            Controls.Add(Port);
            Controls.Add(label2);
            Controls.Add(SmtpSetLab);
            Controls.Add(Host);
            Controls.Add(label1);
            Controls.Add(SendersEmail);
            Controls.Add(SenderLab);
            Controls.Add(SendBtn);
            Controls.Add(Gender);
            Controls.Add(GenderLab);
            Controls.Add(ResiverEmail);
            Controls.Add(ResiverLastName);
            Controls.Add(ResiverName);
            Controls.Add(ResiverLab);
            Controls.Add(LastNameLeb);
            Controls.Add(NameLeb);
            Name = "ManualSend";
            Text = "Send an email to a person";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLeb;
        private Label LastNameLeb;
        private Label ResiverLab;
        private TextBox ResiverName;
        private TextBox ResiverLastName;
        private TextBox ResiverEmail;
        private TextBox Gender;
        private Label GenderLab;
        private Button SendBtn;
        private TextBox SendersEmail;
        private Label SenderLab;
        private TextBox Host;
        private Label label1;
        private Label SmtpSetLab;
        private TextBox Port;
        private Label label2;
        private TextBox SenderPwd;
        private Label label3;
        private Button button1;
        private TextBox MailSubject;
        private Label MailSubjLab;
        private TextBox Company;
        private Label label4;
        private Button OptionsBtn;
        private Button OptionsAll;
    }
}
