using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionModule
{
    public class Transaction
    {
        public Transaction()
        {
            this.Amount = 0.00m;
            this.Date = DateTime.MinValue;
        }

        public Transaction(decimal amount, DateTime date)
        {
            this.Amount = amount;
            this.Date = date;
        }

        public decimal Amount { get; }

        public string FormattedAmount => this.Amount.ToString("C");

        public DateTime Date { get; }

        public string FormattedDate => this.Date.ToShortDateString();
    }
}
