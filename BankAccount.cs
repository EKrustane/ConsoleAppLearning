using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ConsoleAppLearning
{
    class BankAccount
    {
        public string Number { get; set; }
        public string Owner { get; set; }
        public decimal Balance { get; set; }
        public DateTime Created { get; set; }
        public string Currency { get; set; }

        public BankAccount()
        {

        }

        public void PrintInfo()
        {
            Console.WriteLine($"Account number {this.Number} created on {this.Created.ToShortDateString()} belongs to {this.Owner} with a balance {this.Balance}{this.Currency}");
        }
    }
}
