namespace ClientApplication
{
    partial class AllOptions
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
            OptionsTab = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            StopBtn = new Button();
            StartBtn = new Button();
            ChangePath = new Button();
            label1 = new Label();
            label2 = new Label();
            OptionsTab.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // OptionsTab
            // 
            OptionsTab.Controls.Add(tabPage1);
            OptionsTab.Controls.Add(tabPage2);
            OptionsTab.Controls.Add(tabPage3);
            OptionsTab.Location = new Point(12, 12);
            OptionsTab.Name = "OptionsTab";
            OptionsTab.SelectedIndex = 0;
            OptionsTab.Size = new Size(546, 426);
            OptionsTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(538, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(538, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(StopBtn);
            tabPage3.Controls.Add(StartBtn);
            tabPage3.Controls.Add(ChangePath);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(538, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // StopBtn
            // 
            StopBtn.Location = new Point(25, 147);
            StopBtn.Name = "StopBtn";
            StopBtn.Size = new Size(119, 33);
            StopBtn.TabIndex = 6;
            StopBtn.Text = "Stop service";
            StopBtn.UseVisualStyleBackColor = true;
            StopBtn.Click += StopBtn_Click;
            // 
            // StartBtn
            // 
            StartBtn.Location = new Point(25, 90);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(119, 33);
            StartBtn.TabIndex = 5;
            StartBtn.Text = "Start service";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += StartBtn_Click;
            // 
            // ChangePath
            // 
            ChangePath.Location = new Point(25, 33);
            ChangePath.Name = "ChangePath";
            ChangePath.Size = new Size(119, 33);
            ChangePath.TabIndex = 4;
            ChangePath.Text = "Change/Set path";
            ChangePath.UseVisualStyleBackColor = true;
            ChangePath.Click += ChangePath_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 41);
            label1.Name = "label1";
            label1.Size = new Size(216, 15);
            label1.TabIndex = 7;
            label1.Text = "Change or set path of RestClient service";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 127);
            label2.Name = "label2";
            label2.Size = new Size(156, 15);
            label2.TabIndex = 8;
            label2.Text = "Start/Stop RestClient Service";
            // 
            // AllOptions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 450);
            Controls.Add(OptionsTab);
            Name = "AllOptions";
            Text = "Options";
            OptionsTab.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl OptionsTab;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button ChangePath;
        private Button StartBtn;
        private Button StopBtn;
        private Label label2;
        private Label label1;
    }
}