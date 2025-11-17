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
            label6 = new Label();
            OpenLocalDbBtn = new Button();
            label2 = new Label();
            StopBtn = new Button();
            StartBtn = new Button();
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
            OptionsTab.Location = new Point(12, 12);
            OptionsTab.Name = "OptionsTab";
            OptionsTab.SelectedIndex = 0;
            OptionsTab.Size = new Size(796, 426);
            OptionsTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 3, 3, 3);
            tabPage1.Size = new Size(788, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 3, 3, 3);
            tabPage2.Size = new Size(538, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(OpenLocalDbBtn);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(StopBtn);
            tabPage3.Controls.Add(StartBtn);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 3, 3, 3);
            tabPage3.Size = new Size(538, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(185, 214);
            label6.Name = "label6";
            label6.Size = new Size(129, 15);
            label6.TabIndex = 10;
            label6.Text = "Opens local options.db";
            // 
            // OpenLocalDbBtn
            // 
            OpenLocalDbBtn.Location = new Point(25, 206);
            OpenLocalDbBtn.Name = "OpenLocalDbBtn";
            OpenLocalDbBtn.Size = new Size(119, 33);
            OpenLocalDbBtn.TabIndex = 9;
            OpenLocalDbBtn.Text = "Open local db";
            OpenLocalDbBtn.UseVisualStyleBackColor = true;
            OpenLocalDbBtn.Click += OpenLocalDbBtn_Click;
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
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 3, 3, 3);
            tabPage4.Size = new Size(538, 398);
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
            tabPage5.Location = new Point(4, 24);
            tabPage5.Margin = new Padding(3, 2, 3, 2);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3, 2, 3, 2);
            tabPage5.Size = new Size(538, 398);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // RefreshBtn
            // 
            RefreshBtn.Location = new Point(26, 170);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(99, 41);
            RefreshBtn.TabIndex = 12;
            RefreshBtn.Text = "Load Data";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // ScheduleSave
            // 
            ScheduleSave.Location = new Point(219, 183);
            ScheduleSave.Margin = new Padding(3, 2, 3, 2);
            ScheduleSave.Name = "ScheduleSave";
            ScheduleSave.Size = new Size(112, 28);
            ScheduleSave.TabIndex = 6;
            ScheduleSave.Text = "Save changes";
            ScheduleSave.UseVisualStyleBackColor = true;
            ScheduleSave.Click += ScheduleSave_Click;
            // 
            // Interval
            // 
            Interval.Location = new Point(146, 116);
            Interval.Margin = new Padding(3, 2, 3, 2);
            Interval.Name = "Interval";
            Interval.Size = new Size(110, 23);
            Interval.TabIndex = 5;
            // 
            // Minute
            // 
            Minute.Location = new Point(146, 74);
            Minute.Margin = new Padding(3, 2, 3, 2);
            Minute.Name = "Minute";
            Minute.Size = new Size(110, 23);
            Minute.TabIndex = 4;
            // 
            // Hour
            // 
            Hour.Location = new Point(146, 32);
            Hour.Margin = new Padding(3, 2, 3, 2);
            Hour.Name = "Hour";
            Hour.Size = new Size(110, 23);
            Hour.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 116);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 2;
            label5.Text = "interval in seconds";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 76);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 1;
            label4.Text = "Scheduled Minute";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 34);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 0;
            label3.Text = "Scheduled Hour";
            // 
            // ServiceNameChange
            // 
            ServiceNameChange.FlatStyle = FlatStyle.Popup;
            ServiceNameChange.Location = new Point(673, 12);
            ServiceNameChange.Name = "ServiceNameChange";
            ServiceNameChange.Size = new Size(123, 23);
            ServiceNameChange.TabIndex = 1;
            ServiceNameChange.Text = "Service Name";
            ServiceNameChange.UseVisualStyleBackColor = true;
            ServiceNameChange.Click += ServiceNameChange_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(544, 12);
            button1.Name = "button1";
            button1.Size = new Size(123, 23);
            button1.TabIndex = 2;
            button1.Text = "Service Host";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AllOptions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 450);
            Controls.Add(button1);
            Controls.Add(ServiceNameChange);
            Controls.Add(OptionsTab);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private Button StartBtn;
        private Button StopBtn;
        private Label label2;
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
        private Button OpenLocalDbBtn;
        private Label label6;
    }
}