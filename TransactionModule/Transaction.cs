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
        }

        public Transaction(decimal amount)
        {
            this.Amount = amount;
        }

        public decimal Amount { get; }

        public string FormattedAmount => this.Amount.ToString("C");
    }
}
