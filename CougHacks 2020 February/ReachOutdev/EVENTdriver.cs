using System;
using System.Collections.Generic;
using System.IO;

namespace ReachOutdev
{
    public class EventDriver
    {
        public Dictionary<String, Event> Events;

        public EventDriver()
        {
            Events = new Dictionary<String, Event>();
        }

        public void Insert(Event newEvent)
        {
            Events.Add(newEvent.Name, newEvent);
        }

        public void WriteToFile()
        {
            using (System.IO.StreamWriter file =
<<<<<<< HEAD
                new System.IO.StreamWriter(@Path.GetFullPath(Directory.GetCurrentDirectory()) + "\\EventData.txt"))
=======
                new System.IO.StreamWriter(@Path.GetFullPath(Directory.GetCurrentDirectory()) + "\\dum.txt"))
>>>>>>> master
            {
                foreach (KeyValuePair<String, Event> myEventPair in Events)
                {
                    file.WriteLine(myEventPair.Value.GetEventInfo());
                }
            };
        }

        public void ReadFromFile()
        {
<<<<<<< HEAD
            using (System.IO.StreamReader file = new System.IO.StreamReader(Path.GetFullPath(Directory.GetCurrentDirectory()) + "\\EventData.txt"))
=======
            using (System.IO.StreamReader file = new System.IO.StreamReader(Path.GetFullPath(Directory.GetCurrentDirectory()) + "\\dum.txt"))
>>>>>>> master
            {
                String line = file.ReadLine();
                while (line != null)
                {
                    Event newEvent = new Event();
                    String[] lineArray = line.Split('-');

                    newEvent.Name = lineArray[0];
                    newEvent.DateTime = Convert.ToDateTime(lineArray[1]);
                    newEvent.Description = lineArray[2];
                    newEvent.Location = new Tuple<int, int>(Convert.ToInt32(lineArray[3]), Convert.ToInt32(lineArray[4]));
                    newEvent.Tag = lineArray[5];
                    newEvent.HostName = lineArray[6];

                    int count = Convert.ToInt32(lineArray[7]) + 7;
                    for (int i = 7; i < count; i++)
                    {
                        newEvent.AttendeesNames.Add(lineArray[i]);
                    }

                    Insert(newEvent);
                    line = file.ReadLine();

                }
            }
        }
    }
}
