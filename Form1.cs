using Event_Project;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        [Serializable]
        public class BaseEvent
        {
            public string Name { get; set; }
            public DateTime Hour { get; set; }
            public string Place { get; set; }
            public DateTime Date { get; set; }
            public DateTime Period { get; set; }
            public string Description { get; set; }

            public string Event_Type { get; set; }

            public bool IsCompleted { get; set; }
        }

        [Serializable]
        public class AppointmentEvent : BaseEvent
        {
            public string[] Participance { get; set; }
        }

        [Serializable]
        public class ReminderEvent : BaseEvent
        {
            public DateTime TimeToRemind { get; set; }
        }

        [Serializable]
        public class RecurringEvent : ReminderEvent
        {
            public int RecurringTimes { get; set; }
            public int Times { get; set; }
        }

        public Form1()
        {
            InitializeComponent();

            // Call the LoadEventsFromFile function to load events when the form is created
            List<BaseEvent> upcomingEvents = EventUtility.LoadEventsFromFile("events.dat");
            DisplayEvents(upcomingEvents);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an event and add data to it
            Form2 form2 = new Form2();

            // Subscribe to the FormClosed event of Form2
            form2.FormClosed += Form2_FormClosed;

            // Show Form2
            form2.Show();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Reload and display events when Form2 is closed
            List<BaseEvent> upcomingEvents = EventUtility.LoadEventsFromFile("events.dat");
            DisplayEvents(upcomingEvents);
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            // Show or hide the removeButton based on whether any items are checked
            removeButton.Visible = listView1.CheckedItems.Count > 0;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Completed", 60); // Checkbox column
            listView1.ItemChecked += listView1_ItemChecked;
            removeButton.Visible = false;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // Remove selected events
            List<BaseEvent> events = EventUtility.LoadEventsFromFile("events.dat");

            foreach (ListViewItem selectedItem in listView1.CheckedItems)
            {
                string eventName = selectedItem.Text;

                // Find and remove the event from the list
                BaseEvent eventToRemove = events.FirstOrDefault(evt => evt.Name == eventName);
                if (eventToRemove != null)
                {
                    Console.WriteLine($"Event found and removed: {eventName}");
                    events.Remove(eventToRemove);
                }
            }

            // Save the updated list of events to the file
            EventUtility.SaveEventsToFile(events, "events.dat");

            // Reload and display events
            DisplayEvents(events);
        }

        private void DisplayEvents(List<BaseEvent> events)
        {
            listView1.Items.Clear();

            // Sort events by Date and Hour
            events.Sort((evt1, evt2) =>
            {
                int dateComparison = evt1.Date.CompareTo(evt2.Date);
                if (dateComparison != 0)
                    return dateComparison;
                return evt1.Hour.CompareTo(evt2.Hour);
            });

            foreach (var evt in events)
            {
                ListViewItem item = new ListViewItem(evt.Name);

                // Add common subitems
                item.SubItems.Add(evt.Place);
                item.SubItems.Add(evt.Date.ToString());
                item.SubItems.Add(evt.Hour.ToString("hh:mm tt"));
                item.SubItems.Add(evt.Description);
                item.SubItems.Add(evt.Period.ToString("hh:mm tt"));
                item.SubItems.Add(GetEventType(evt)); // Event type

                // Handle event-specific subitems
                if (evt is AppointmentEvent appointment)
                {
                    item.SubItems.Add(string.Join(", ", appointment.Participance)); // Participance
                    item.SubItems.Add(""); // Placeholder for RecurringEvent-specific subitem
                }
                else if (evt is RecurringEvent recurring)
                {
                    item.SubItems.Add(""); // Placeholder for AppointmentEvent-specific subitem
                    item.SubItems.Add($"Recurring Times: {recurring.RecurringTimes}, Times: {recurring.Times}"); // Recurring info
                }
                else if (evt is ReminderEvent reminder)
                {
                    item.SubItems.Add(""); // Placeholder for AppointmentEvent-specific subitem
                    item.SubItems.Add(""); // Placeholder for RecurringEvent-specific subitem
                    item.SubItems.Add($"Time to Remind: {reminder.TimeToRemind}"); // Reminder info
                }
                else
                {
                    item.SubItems.Add(""); // Placeholder for AppointmentEvent-specific subitem
                    item.SubItems.Add(""); // Placeholder for RecurringEvent-specific subitem
                    item.SubItems.Add(""); // Placeholder for ReminderEvent-specific subitem
                }

                item.SubItems.Add(GetAdditionalInfo(evt)); // Additional info

                listView1.Items.Add(item);
            }
        }


        private string GetEventType(BaseEvent evt)
        {
            if (evt is AppointmentEvent)
            {
                return "Appointment";
            }
            else if (evt is RecurringEvent)
            {
                return "Recurring";
            }
            else if (evt is ReminderEvent)
            {
                return "Reminder";
            }
            else
            {
                return "Unknown";
            }
        }

        private string GetAdditionalInfo(BaseEvent evt)
        {
            if (evt is AppointmentEvent appointment)
            {
                return $"Participants: {string.Join(", ", appointment.Participance)}";
            }
            else if (evt is RecurringEvent recurring)
            {
                return $"Recurring Times: {recurring.RecurringTimes}, Times: {recurring.Times}";
            }
            else if (evt is ReminderEvent reminder)
            {
                return $"Time to Remind: {reminder.TimeToRemind}";
            }
            else
            {
                return "Additional Info Not Available";
            }
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}