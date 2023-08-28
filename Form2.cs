using Event_Project;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static WindowsFormsApp1.Form1;
using System.Runtime.Serialization.Formatters.Binary;

namespace Event_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBoxEventType.Items.Add("Appointment");
            comboBoxEventType.Items.Add("Recurring");
            comboBoxEventType.Items.Add("Reminder");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reset visibility of all fields to their default states
            labelTimeToRemind.Visible = false;
            timeToRemindBox.Visible = false;
            labelParticipants.Visible = false;
            ParticipantsBox.Visible = false;
            labelTimes.Visible = false;
            TimesBox.Visible = false;

            string selectedEventType = comboBoxEventType.SelectedItem?.ToString();

            if (selectedEventType == "Reminder")
            {
                labelTimeToRemind.Visible = true;
                timeToRemindBox.Visible = true;

                labelParticipants.Visible = false;
                ParticipantsBox.Visible = false;

                labelTimes.Visible = false;
                TimesBox.Visible = false;
            }
            else if (selectedEventType == "Appointment")
            {
                labelParticipants.Visible = true;
                ParticipantsBox.Visible = true;

                labelTimeToRemind.Visible = false;
                timeToRemindBox.Visible = false;

                labelTimes.Visible = false;
                TimesBox.Visible = false;
            }
            else if (selectedEventType == "Recurring")
            {
                labelTimes.Visible = true;
                TimesBox.Visible = true;

                labelTimeToRemind.Visible = true;
                timeToRemindBox.Visible = true;

                labelParticipants.Visible = false;
                ParticipantsBox.Visible = false;
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string selectedEventType = comboBoxEventType.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedEventType))
            {
                BaseEvent newEvent = null;

                if (selectedEventType == "Appointment")
                {
                    newEvent = new AppointmentEvent
                    {
                        Name = NameBox.Text,
                        Place = placeBox.Text,
                        Hour = hourBox.Value,
                        Date = dateBox.Value,
                        Description = descriptionBox.Text,
                        Participance = ParticipantsBox.Text.Split(',').Select(participant => participant.Trim()).ToArray(),
                        Period = periodBox.Value,
                        Event_Type = comboBoxEventType.Text
                    };
                }
                else if (selectedEventType == "Reminder")
                {
                    newEvent = new ReminderEvent
                    {
                        Name = NameBox.Text,
                        Place = placeBox.Text,
                        Description = descriptionBox.Text,
                        Hour = hourBox.Value,
                        Date = dateBox.Value,
                        TimeToRemind = timeToRemindBox.Value,
                        Period = periodBox.Value,
                        Event_Type = comboBoxEventType.Text
                    };
                }
                else if (selectedEventType == "Recurring")
                {
                    newEvent = new RecurringEvent
                    {
                        Name = NameBox.Text,
                        Place = placeBox.Text,
                        Description = descriptionBox.Text,
                        Times = Convert.ToInt32(TimesBox.Text),
                        Hour = hourBox.Value,
                        Date = dateBox.Value,
                        Period = periodBox.Value,
                        Event_Type = comboBoxEventType.Text
                    };
                }

                if (newEvent != null)
                {
                    // Load existing events, add the new event, and save back to the file
                    List<BaseEvent> existingEvents = EventUtility.LoadEventsFromFile("events.dat");
                    existingEvents.Add(newEvent);
                    EventUtility.SaveEventsToFile(existingEvents, "events.dat");
                }

                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelRecurringTime_Click(object sender, EventArgs e)
        {

        }

        private void labelTimeToRemind_Click(object sender, EventArgs e)
        {

        }

        private void labelTimes_Click(object sender, EventArgs e)
        {

        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private List<BaseEvent> LoadEventsFromFile(string fileName)
        {
            List<BaseEvent> events = new List<BaseEvent>();
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                if (fs.Length > 0)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    events = (List<BaseEvent>)formatter.Deserialize(fs);
                }
            }
            return events;
        }

            private void SaveEventsToFile(List<BaseEvent> events, string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, events);
            }
        }

        private void periodBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
