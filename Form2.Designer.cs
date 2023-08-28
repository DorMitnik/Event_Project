namespace Event_Project
{
    partial class Form2
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
            this.comboBoxEventType = new System.Windows.Forms.ComboBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.placeBox = new System.Windows.Forms.TextBox();
            this.ParticipantsBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelParticipants = new System.Windows.Forms.Label();
            this.labelTimeToRemind = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.hourBox = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTimes = new System.Windows.Forms.Label();
            this.TimesBox = new System.Windows.Forms.ComboBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.timeToRemindBox = new System.Windows.Forms.DateTimePicker();
            this.periodBox = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEventType
            // 
            this.comboBoxEventType.FormattingEnabled = true;
            this.comboBoxEventType.Location = new System.Drawing.Point(269, 40);
            this.comboBoxEventType.Name = "comboBoxEventType";
            this.comboBoxEventType.Size = new System.Drawing.Size(237, 33);
            this.comboBoxEventType.TabIndex = 0;
            this.comboBoxEventType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(1, 114);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(237, 31);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Event Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(1, 185);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(237, 31);
            this.descriptionBox.TabIndex = 4;
            this.descriptionBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // placeBox
            // 
            this.placeBox.Location = new System.Drawing.Point(1, 256);
            this.placeBox.Name = "placeBox";
            this.placeBox.Size = new System.Drawing.Size(237, 31);
            this.placeBox.TabIndex = 5;
            this.placeBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ParticipantsBox
            // 
            this.ParticipantsBox.Location = new System.Drawing.Point(376, 114);
            this.ParticipantsBox.Name = "ParticipantsBox";
            this.ParticipantsBox.Size = new System.Drawing.Size(229, 31);
            this.ParticipantsBox.TabIndex = 8;
            this.ParticipantsBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Place";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Hour";
            // 
            // labelParticipants
            // 
            this.labelParticipants.AutoSize = true;
            this.labelParticipants.Location = new System.Drawing.Point(429, 86);
            this.labelParticipants.Name = "labelParticipants";
            this.labelParticipants.Size = new System.Drawing.Size(131, 25);
            this.labelParticipants.TabIndex = 14;
            this.labelParticipants.Text = "Participance";
            // 
            // labelTimeToRemind
            // 
            this.labelTimeToRemind.AutoSize = true;
            this.labelTimeToRemind.Location = new System.Drawing.Point(404, 157);
            this.labelTimeToRemind.Name = "labelTimeToRemind";
            this.labelTimeToRemind.Size = new System.Drawing.Size(169, 25);
            this.labelTimeToRemind.TabIndex = 15;
            this.labelTimeToRemind.Text = "Time To Remind";
            this.labelTimeToRemind.Click += new System.EventHandler(this.labelTimeToRemind_Click);
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(1, 335);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(237, 31);
            this.dateBox.TabIndex = 16;
            this.dateBox.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // hourBox
            // 
            this.hourBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.hourBox.Location = new System.Drawing.Point(-8, 397);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(273, 31);
            this.hourBox.TabIndex = 17;
            this.hourBox.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Period";
            // 
            // labelTimes
            // 
            this.labelTimes.AutoSize = true;
            this.labelTimes.Location = new System.Drawing.Point(452, 262);
            this.labelTimes.Name = "labelTimes";
            this.labelTimes.Size = new System.Drawing.Size(70, 25);
            this.labelTimes.TabIndex = 21;
            this.labelTimes.Text = "Times";
            this.labelTimes.Click += new System.EventHandler(this.labelTimes_Click);
            // 
            // TimesBox
            // 
            this.TimesBox.FormattingEnabled = true;
            this.TimesBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.TimesBox.Location = new System.Drawing.Point(376, 303);
            this.TimesBox.Name = "TimesBox";
            this.TimesBox.Size = new System.Drawing.Size(230, 33);
            this.TimesBox.TabIndex = 22;
            this.TimesBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(430, 551);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(130, 47);
            this.SendButton.TabIndex = 24;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // timeToRemindBox
            // 
            this.timeToRemindBox.Location = new System.Drawing.Point(375, 196);
            this.timeToRemindBox.Name = "timeToRemindBox";
            this.timeToRemindBox.Size = new System.Drawing.Size(230, 31);
            this.timeToRemindBox.TabIndex = 25;
            // 
            // periodBox
            // 
            this.periodBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.periodBox.Location = new System.Drawing.Point(1, 491);
            this.periodBox.Name = "periodBox";
            this.periodBox.Size = new System.Drawing.Size(250, 31);
            this.periodBox.TabIndex = 26;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 713);
            this.Controls.Add(this.periodBox);
            this.Controls.Add(this.timeToRemindBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.TimesBox);
            this.Controls.Add(this.labelTimes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hourBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.labelTimeToRemind);
            this.Controls.Add(this.labelParticipants);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ParticipantsBox);
            this.Controls.Add(this.placeBox);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.comboBoxEventType);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEventType;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox placeBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label labelTimeToRemind;
        private System.Windows.Forms.Label labelParticipants;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ParticipantsBox;
        private System.Windows.Forms.DateTimePicker hourBox;
        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox TimesBox;
        private System.Windows.Forms.Label labelTimes;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.DateTimePicker timeToRemindBox;
        private System.Windows.Forms.DateTimePicker periodBox;
    }
}