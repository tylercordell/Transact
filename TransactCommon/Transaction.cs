using System;
using TransactCommon.Enums;

namespace TransactCommon
{
    public class Transaction
    {
        private decimal _amount;

        public Transaction()
        {
            Amount = 0.00m;
            Date = DateTime.MinValue;
        }

        public Transaction(decimal amount, DateTime date)
        {
            Amount = amount;
            Date = date;
        }

        public decimal Amount
        {
            get => _amount;

            set
            {
                if (TransactionType != TransactionType.Transfer)
                {
                    if (value > 0)
                        TransactionType = TransactionType.Income;
                    else if (value < 0) TransactionType = TransactionType.Expense;
                }

                _amount = value;
            }
        }

        public string FormattedAmount => Amount.ToString("C");

        public DateTime Date { get; }

        public string FormattedDate => Date.ToShortDateString();

        public TransactionType TransactionType { get; set; }
    }
}