namespace ClientApplication
{
    partial class DbSendEmail
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
            SendBtn = new Button();
            SmtpSetLab = new Label();
            Host = new TextBox();
            label1 = new Label();
            Port = new TextBox();
            label2 = new Label();
            Password = new TextBox();
            label3 = new Label();
            SendersEmail = new TextBox();
            SenderLab = new Label();
            Close = new Button();
            SuspendLayout();
            // 
            // SendBtn
            // 
            SendBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SendBtn.Location = new Point(306, 335);
            SendBtn.Name = "SendBtn";
            SendBtn.Size = new Size(218, 39);
            SendBtn.TabIndex = 16;
            SendBtn.Text = "Send emails with DB data";
            SendBtn.UseVisualStyleBackColor = true;
            SendBtn.Click += SendBtn_Click;
            // 
            // SmtpSetLab
            // 
            SmtpSetLab.AutoSize = true;
            SmtpSetLab.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SmtpSetLab.Location = new Point(341, 44);
            SmtpSetLab.Name = "SmtpSetLab";
            SmtpSetLab.Size = new Size(148, 28);
            SmtpSetLab.TabIndex = 14;
            SmtpSetLab.Text = "SMTP Settings";
            // 
            // Host
            // 
            Host.Location = new Point(328, 105);
            Host.Name = "Host";
            Host.Size = new Size(175, 23);
            Host.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(235, 105);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 15;
            label1.Text = "SMTP host";
            // 
            // Port
            // 
            Port.Location = new Point(328, 153);
            Port.Name = "Port";
            Port.Size = new Size(175, 23);
            Port.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(235, 153);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 17;
            label2.Text = "SMTP port";
            // 
            // Password
            // 
            Password.Location = new Point(328, 245);
            Password.Name = "Password";
            Password.Size = new Size(175, 23);
            Password.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(181, 247);
            label3.Name = "label3";
            label3.Size = new Size(137, 21);
            label3.TabIndex = 19;
            label3.Text = "Senders password";
            // 
            // SendersEmail
            // 
            SendersEmail.Location = new Point(328, 199);
            SendersEmail.Name = "SendersEmail";
            SendersEmail.Size = new Size(175, 23);
            SendersEmail.TabIndex = 14;
            // 
            // SenderLab
            // 
            SenderLab.AutoSize = true;
            SenderLab.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SenderLab.Location = new Point(210, 201);
            SenderLab.Name = "SenderLab";
            SenderLab.Size = new Size(108, 21);
            SenderLab.TabIndex = 21;
            SenderLab.Text = "Senders email";
            // 
            // Close
            // 
            Close.Location = new Point(699, 3);
            Close.Name = "Close";
            Close.Size = new Size(98, 39);
            Close.TabIndex = 17;
            Close.Text = "Back to main page";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // DbSendEmail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Close);
            Controls.Add(SendersEmail);
            Controls.Add(SenderLab);
            Controls.Add(Password);
            Controls.Add(label3);
            Controls.Add(Port);
            Controls.Add(label2);
            Controls.Add(Host);
            Controls.Add(label1);
            Controls.Add(SmtpSetLab);
            Controls.Add(SendBtn);
            Name = "DbSendEmail";
            Text = "Send emails with DB info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SendBtn;
        private Label SmtpSetLab;
        private TextBox Host;
        private Label label1;
        private TextBox Port;
        private Label label2;
        private TextBox Password;
        private Label label3;
        private TextBox SendersEmail;
        private Label SenderLab;
        private Button Close;
    }
}