using System;
using System.Collections.Generic;

namespace ReachOutdev
{
    public class Event
    {
        public DateTime DateTime { get; set; }
        public String Name { get; set; }
        public String Tag { get; set; }
        public String Description { get; set; }
        public Tuple<int, int> Location { get; set; }
        public String HostName { get; set; }
        public List<String> AttendeesNames { get; }
        //private image
        //private Account Host
        //private List<Account> Attendees

        public Event()
        {
            AttendeesNames = new List<String>();
        }
        public Event(String name, DateTime dateTime, Tuple<int, int> location, String hostName)
        {
            this.Name = name;
            this.DateTime = dateTime;
            this.Location = location;
            this.HostName = hostName;
            AttendeesNames = new List<String>();
        }

        public string GetEventInfo()
        {
            String eventInfo = "";
            eventInfo += Name;
            eventInfo += "-";
            eventInfo += DateTime;
            eventInfo += "-";
            eventInfo += Description;
            eventInfo += "-";
            eventInfo += Location.Item1;
            eventInfo += "-";
            eventInfo += Location.Item2;
            eventInfo += "-";
            eventInfo += Tag;
            eventInfo += "-";
            eventInfo += HostName;
            eventInfo += "-";
            eventInfo += AttendeesNames.Count;
            eventInfo += "-";
            foreach (String name in AttendeesNames)
            {
                eventInfo += name + "-";
            }

            return eventInfo;
        }

    }
}
