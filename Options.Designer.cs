namespace ClientApplication
{
    partial class Options
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
            StartBtn = new Button();
            StopBtn = new Button();
            TemplateBtn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // StartBtn
            // 
            StartBtn.Location = new Point(107, 124);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(119, 33);
            StartBtn.TabIndex = 0;
            StartBtn.Text = "Start service";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += StartBtn_Click;
            // 
            // StopBtn
            // 
            StopBtn.Location = new Point(107, 187);
            StopBtn.Name = "StopBtn";
            StopBtn.Size = new Size(119, 33);
            StopBtn.TabIndex = 1;
            StopBtn.Text = "Stop service";
            StopBtn.UseVisualStyleBackColor = true;
            StopBtn.Click += StopBtn_Click;
            // 
            // TemplateBtn
            // 
            TemplateBtn.Location = new Point(107, 266);
            TemplateBtn.Name = "TemplateBtn";
            TemplateBtn.Size = new Size(119, 33);
            TemplateBtn.TabIndex = 2;
            TemplateBtn.Text = "Template settings";
            TemplateBtn.UseVisualStyleBackColor = true;
            TemplateBtn.Click += TemplateBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(107, 57);
            button1.Name = "button1";
            button1.Size = new Size(119, 33);
            button1.TabIndex = 3;
            button1.Text = "Change/Set path";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Options
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 450);
            Controls.Add(button1);
            Controls.Add(TemplateBtn);
            Controls.Add(StopBtn);
            Controls.Add(StartBtn);
            Name = "Options";
            Text = "Options";
            ResumeLayout(false);
        }

        #endregion

        private Button StartBtn;
        private Button StopBtn;
        private Button TemplateBtn;
        private Button button1;
    }
}