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
            label2 = new Label();
            label1 = new Label();
            StopBtn = new Button();
            StartBtn = new Button();
            ChangePath = new Button();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            RefreshBtn = new Button();
            ScheduleSave = new Button();
            Interval = new TextBox();
            Minute = new TextBox();
            Hour = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ServiceNameChange = new Button();
            button1 = new Button();
            OptionsTab.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // OptionsTab
            // 
            OptionsTab.Controls.Add(tabPage1);
            OptionsTab.Controls.Add(tabPage2);
            OptionsTab.Controls.Add(tabPage3);
            OptionsTab.Controls.Add(tabPage4);
            OptionsTab.Controls.Add(tabPage5);
            OptionsTab.Location = new Point(14, 16);
            OptionsTab.Margin = new Padding(3, 4, 3, 4);
            OptionsTab.Name = "OptionsTab";
            OptionsTab.SelectedIndex = 0;
            OptionsTab.Size = new Size(624, 568);
            OptionsTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(616, 535);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(616, 535);
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
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(616, 535);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 169);
            label2.Name = "label2";
            label2.Size = new Size(198, 20);
            label2.TabIndex = 8;
            label2.Text = "Start/Stop RestClient Service";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 55);
            label1.Name = "label1";
            label1.Size = new Size(271, 20);
            label1.TabIndex = 7;
            label1.Text = "Change or set path of RestClient service";
            label1.Visible = false;
            // 
            // StopBtn
            // 
            StopBtn.Location = new Point(29, 196);
            StopBtn.Margin = new Padding(3, 4, 3, 4);
            StopBtn.Name = "StopBtn";
            StopBtn.Size = new Size(136, 44);
            StopBtn.TabIndex = 6;
            StopBtn.Text = "Stop service";
            StopBtn.UseVisualStyleBackColor = true;
            StopBtn.Click += StopBtn_Click;
            // 
            // StartBtn
            // 
            StartBtn.Location = new Point(29, 120);
            StartBtn.Margin = new Padding(3, 4, 3, 4);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(136, 44);
            StartBtn.TabIndex = 5;
            StartBtn.Text = "Start service";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += StartBtn_Click;
            // 
            // ChangePath
            // 
            ChangePath.Location = new Point(29, 44);
            ChangePath.Margin = new Padding(3, 4, 3, 4);
            ChangePath.Name = "ChangePath";
            ChangePath.Size = new Size(136, 44);
            ChangePath.TabIndex = 4;
            ChangePath.Text = "Change/Set path";
            ChangePath.UseVisualStyleBackColor = true;
            ChangePath.Visible = false;
            ChangePath.Click += ChangePath_Click;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(3, 4, 3, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 4, 3, 4);
            tabPage4.Size = new Size(616, 535);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(RefreshBtn);
            tabPage5.Controls.Add(ScheduleSave);
            tabPage5.Controls.Add(Interval);
            tabPage5.Controls.Add(Minute);
            tabPage5.Controls.Add(Hour);
            tabPage5.Controls.Add(label5);
            tabPage5.Controls.Add(label4);
            tabPage5.Controls.Add(label3);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(616, 535);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // RefreshBtn
            // 
            RefreshBtn.Location = new Point(30, 227);
            RefreshBtn.Margin = new Padding(3, 4, 3, 4);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(113, 55);
            RefreshBtn.TabIndex = 12;
            RefreshBtn.Text = "Load Data";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // ScheduleSave
            // 
            ScheduleSave.Location = new Point(250, 244);
            ScheduleSave.Name = "ScheduleSave";
            ScheduleSave.Size = new Size(128, 38);
            ScheduleSave.TabIndex = 6;
            ScheduleSave.Text = "Save changes";
            ScheduleSave.UseVisualStyleBackColor = true;
            ScheduleSave.Click += ScheduleSave_Click;
            // 
            // Interval
            // 
            Interval.Location = new Point(167, 154);
            Interval.Name = "Interval";
            Interval.Size = new Size(125, 27);
            Interval.TabIndex = 5;
            // 
            // Minute
            // 
            Minute.Location = new Point(167, 98);
            Minute.Name = "Minute";
            Minute.Size = new Size(125, 27);
            Minute.TabIndex = 4;
            // 
            // Hour
            // 
            Hour.Location = new Point(167, 43);
            Hour.Name = "Hour";
            Hour.Size = new Size(125, 27);
            Hour.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 154);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 2;
            label5.Text = "interval in seconds";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 101);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 1;
            label4.Text = "Scheduled Minute";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 46);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 0;
            label3.Text = "Scheduled Hour";
            // 
            // ServiceNameChange
            // 
            ServiceNameChange.FlatStyle = FlatStyle.Popup;
            ServiceNameChange.Location = new Point(769, 16);
            ServiceNameChange.Margin = new Padding(3, 4, 3, 4);
            ServiceNameChange.Name = "ServiceNameChange";
            ServiceNameChange.Size = new Size(141, 31);
            ServiceNameChange.TabIndex = 1;
            ServiceNameChange.Text = "Service Name";
            ServiceNameChange.UseVisualStyleBackColor = true;
            ServiceNameChange.Click += ServiceNameChange_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(622, 16);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(141, 31);
            button1.TabIndex = 2;
            button1.Text = "Service Host";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AllOptions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 600);
            Controls.Add(button1);
            Controls.Add(ServiceNameChange);
            Controls.Add(OptionsTab);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AllOptions";
            Text = "Options";
            OptionsTab.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
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
        private TabPage tabPage4;
        private Button ServiceNameChange;
        private Button button1;
        private TabPage tabPage5;
        private Button ScheduleSave;
        private TextBox Interval;
        private TextBox Minute;
        private TextBox Hour;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button RefreshBtn;
    }
}