using System.Collections.ObjectModel;

namespace TransactionModule.ViewModels
{
    public class TransactionLogViewModel
    {
        public TransactionLogViewModel()
        {
            // Eventually need to pass in a service here to load transactions, perform filtering, etc.
        }

        public Collection<Transaction> TransactionsCollection => 
            new Collection<Transaction> 
            {
                new Transaction(26.39m),
                new Transaction(54.58m)
            };
    }
}
