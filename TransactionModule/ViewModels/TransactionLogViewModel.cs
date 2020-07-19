using System;
using System.Collections.ObjectModel;
using TransactCommon;

namespace TransactionModule.ViewModels
{
    public class TransactionLogViewModel
    {
        public Collection<Transaction> TransactionsCollection =>
            new Collection<Transaction>
            {
                new Transaction(26.39m, DateTime.Now),
                new Transaction(54.58m, new DateTime(1997, 4, 23))
            };
    }
}