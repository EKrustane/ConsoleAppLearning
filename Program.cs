using System;
using System.Collections.Generic;

namespace ConsoleAppLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> persons = new List<Human>();
            persons.Add(new Human("Jenifer","Lopez",25,"Brown"));
            persons.Add(new Human("Anna", "Liepa", 16, "Blue"));
            persons.Add(new Human("Mikelis", "Johnson", 14, "Green"));
            persons.Add(new Human("Agnese", "Egle", 19, "Gray"));

            //persons[1].SetAge(15);

            //persons[0].Introduce();
            //persons[1].Introduce();
            //persons[2].Introduce();
            //persons[3].Introduce();

            //for (int i=0; i<persons.Count; i++)
            //{
                //persons[i].Introduce();
            //}

            foreach(var person in persons)
            {
                person.Introduce();
            }

            //int a = 126724684;
            //Console.WriteLine(a.ToString()[2]);
            //string text = "Ermine";
            //Console.WriteLine(text[1]);

            //create some accounts here
            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(new BankAccount("Jenifer", 200, "EUR"));
            accounts.Add(new BankAccount("Anna", 5000, "EUR"));
            accounts.Add(new BankAccount("Mikelis", 30, "EUR"));
            foreach (var account in accounts)
            {
                account.PrintInfo();
            }
        }
    }


}
