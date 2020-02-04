using System.Collections.Generic;

namespace ReachOutdev
{
    public class Account
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Kudos { get; set; }
        public string EventHosting { get; set; }
        public List<string> EventsAttending { get; }

        public Account()
        {
            EventsAttending = new List<string>();
        }

        public Account(string UserName, string Password, int Kudos)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.Kudos = Kudos;
            EventsAttending = new List<string>();
        }

        // public get info
        public string GetInfo()
        {
            string info = ("");
            info += UserName; //0
            info += "-";
            info += Password; //1
            info += "-";
            info += Kudos; //2 
            info += "-";
            info += EventHosting; //3 
            info += "-";
            info += EventsAttending.Count; //4
            info += "-";
            foreach(string myEvent in EventsAttending)
            {
                info += myEvent;
                info += "-";
            }
            return info;
        }
    }
}
