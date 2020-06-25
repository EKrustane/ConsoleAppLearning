using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLearning
{
    class Transaction
    {
        public decimal Amount {get; }
        public DateTime TransactionDate { get; }
        public string Note { get; }

        public Transaction(decimal amount, string note)
        {
            this.Amount = amount;
            this.TransactionDate = DateTime.Now;
            this.Note = note;
        }
    }
}
