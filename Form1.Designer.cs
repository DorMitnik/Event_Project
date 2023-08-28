namespace WindowsFormsApp1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Event_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Place = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Period = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Event_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Participance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Recurring_info = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Reminder_info = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Additional_info = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Event";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Event_name,
            this.Place,
            this.Date,
            this.Hour,
            this.Description,
            this.Period,
            this.Event_Type,
            this.Participance,
            this.Recurring_info,
            this.Reminder_info,
            this.Additional_info});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(171, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1951, 815);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Event_name
            // 
            this.Event_name.Text = "Name";
            this.Event_name.Width = 194;
            // 
            // Place
            // 
            this.Place.Text = "Place";
            this.Place.Width = 171;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 135;
            // 
            // Hour
            // 
            this.Hour.Text = "Hour";
            this.Hour.Width = 156;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 323;
            // 
            // Period
            // 
            this.Period.Text = "Period";
            this.Period.Width = 140;
            // 
            // Event_Type
            // 
            this.Event_Type.Text = "EventType";
            this.Event_Type.Width = 275;
            // 
            // Participance
            // 
            this.Participance.Text = "Participance";
            this.Participance.Width = 187;
            // 
            // Recurring_info
            // 
            this.Recurring_info.Text = "Recurring Info ";
            this.Recurring_info.Width = 109;
            // 
            // Reminder_info
            // 
            this.Reminder_info.Text = "Reminder Info";
            this.Reminder_info.Width = 188;
            // 
            // Additional_info
            // 
            this.Additional_info.Text = "Additional Info";
            this.Additional_info.Width = 90;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(10, 149);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(135, 82);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2152, 984);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Event_name;
        private System.Windows.Forms.ColumnHeader Place;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Hour;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Period;
        private System.Windows.Forms.ColumnHeader Event_Type;
        private System.Windows.Forms.ColumnHeader Participance;
        private System.Windows.Forms.ColumnHeader Recurring_info;
        private System.Windows.Forms.ColumnHeader Reminder_info;
        private System.Windows.Forms.ColumnHeader Additional_info;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button removeButton;
    }
}

