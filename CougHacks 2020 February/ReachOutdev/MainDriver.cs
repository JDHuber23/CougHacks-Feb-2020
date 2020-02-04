using System;

namespace ReachOutdev
{
    static class MainDriver
    {
        [STAThread]
        static void Main(string[] args)
        {
            AccountDriver testList = new AccountDriver();
            Account testAccount = new Account("Brent", "DumbPassword", 0);
            testList.Insert(testAccount);

            EventDriver eventDriver = new EventDriver();
            Event testEvent = new Event();
            testEvent.Name = "Dummy Event";
            testEvent.DateTime = new DateTime(2020, 2, 1, 18, 0, 0);
            testEvent.Description = "This event is stupid";
            testEvent.Location = new Tuple<int, int>(321, 32);
            testEvent.HostName = testAccount.UserName;
            eventDriver.Insert(testEvent);

            testAccount.EventHosting = testEvent.Name;
            testAccount.EventsAttending.Add(testEvent.Name);


            EventDriver eventDriver2 = new EventDriver();
            eventDriver.WriteToFile();
            eventDriver2.ReadFromFile();

            AccountDriver testList2 = new AccountDriver();
            testList.WriteToFile();
            testList2.ReadFromFile();

            Console.WriteLine(testList2.AccountDictionary[testAccount.UserName].GetInfo());
            Console.WriteLine(eventDriver2.Events[testEvent.Name].GetEventInfo());
            Console.ReadLine();
        }
    }
}
