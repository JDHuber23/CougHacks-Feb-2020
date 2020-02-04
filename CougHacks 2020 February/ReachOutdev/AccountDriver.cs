using System;
using System.Collections.Generic;
using System.IO;

namespace ReachOutdev
{
    public class AccountDriver
    {
        public Dictionary<string, Account> AccountDictionary;

        public AccountDriver()
        {
            AccountDictionary = new Dictionary<string, Account>();
        }

        public void Insert(Account newAccount)
        {
            // add to HashTable using (key, account) notation
            AccountDictionary.Add(newAccount.UserName, newAccount);
        }
        public Account LogIn(string trialName, string trialPass)
        {
<<<<<<< HEAD
=======
            if (!AccountDictionary.ContainsKey("trialName"))
            {
                return null;
            }
>>>>>>> master
            Account temp = AccountDictionary[trialName];
            if (temp.Password.Equals(trialPass))
            {
                return temp;
            }
            else
            {
                return null;
            }
        }

        public void WriteToFile()
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@Path.GetFullPath(Directory.GetCurrentDirectory()) + "\\AccountData.txt"))
            {
                foreach (KeyValuePair<string, Account> accountPair in AccountDictionary)
                {
                    file.WriteLine(accountPair.Value.GetInfo());
                }
            }
        }

        public void ReadFromFile()
        {
            using (System.IO.StreamReader file = new System.IO.StreamReader(@Path.GetFullPath(Directory.GetCurrentDirectory()) + "\\AccountData.txt"))
            {
                String line = file.ReadLine();
                while (line != null)
                {
                    Account newAccount = new Account();
                    string[] lineArray = line.Split('-');

                    newAccount.UserName = lineArray[0];
                    newAccount.Password = lineArray[1];
                    newAccount.Kudos = Convert.ToInt32(lineArray[2]);
                    newAccount.EventHosting = lineArray[3];

                    int count = Convert.ToInt32(lineArray[4]);
                    for (int i = 5; i < count + 5; i++)
                    {
                        newAccount.EventsAttending.Add(lineArray[i]);
                    }

                    Insert(newAccount);
                    line = file.ReadLine();
                }
            }
        }
    }
}

