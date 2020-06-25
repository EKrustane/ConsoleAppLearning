using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ConsoleAppLearning
{
    class BankAccount
    {
        private List<Transaction> transactions = new List<Transaction>();
        private static int accountNumber = 123;
        private int count = 0;

        public string Number { get; }
        public string Owner { get; }
        public decimal Balance {
            get
            {
                decimal balance = 0;
                foreach (var t in transactions)
                {
                    balance += t.Amount;
                }
                return balance;
            }
        }
        public DateTime Created { get; }
        public string Currency { get; }

        public BankAccount(string owner, decimal balance, string currency)
        {
            
            this.Number = accountNumber.ToString();
            accountNumber++;
            this.Owner = owner;
            this.MakeDeposit(balance, "Initial balance");
            this.Currency = currency;
            this.Created = DateTime.Now;
            count++;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Account number {this.Number} created on {this.Created.ToShortDateString()} belongs to {this.Owner} with a balance {this.Balance}{this.Currency}");
        }
        public void MakeDeposit(decimal amount, string note)
        {
            if (amount < 0)
            {
                Console.WriteLine("Amount must be positive");
                return;
            }
            Transaction deposit = new Transaction(amount, note);
            transactions.Add(deposit);
            if (count>0)
            {
                ShowAllDeposits(amount, note);
            }
            
        }
        public void MakeWithdrawal(decimal amount, string note)
        {
            if (amount < 0)
            {
                Console.WriteLine("Amount must be positive");
                return;
            }
            else if (amount > this.Balance)
            {
                Console.WriteLine("You do not have sufficient funds");
                return;
            }
            Transaction withdrawal = new Transaction(-amount, note);
            transactions.Add(withdrawal);
            ShowAllWithdrawal(amount, note);
        }
        public void ShowAllDeposits(decimal amount, string note)
        {

            Console.WriteLine($"{amount} EUR is added to {this.Owner}'s account. Note: {note}.");

            
        }
        public void ShowAllWithdrawal(decimal amount, string note)
        {
            Console.WriteLine($"{amount} EUR is removed from {this.Owner}'s account. Note: {note}.");
        }
    }
}
