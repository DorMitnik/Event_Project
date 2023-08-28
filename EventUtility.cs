using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using static WindowsFormsApp1.Form1;

namespace Event_Project
{
    public static class EventUtility
    {
        public static List<BaseEvent> LoadEventsFromFile(string fileName)
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

        public static void SaveEventsToFile(List<BaseEvent> events, string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, events);
            }
        }
    }
}
