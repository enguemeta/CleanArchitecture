using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventDrivenDemo.Events
{
    public class TransactionProcessedEventArgs : EventArgs
    {
        public decimal Amount { get; set; }
        public TransactionType TransactionType;

        public TransactionProcessedEventArgs(decimal amount, TransactionType transactionType)
        {
            Amount = amount;
            TransactionType = transactionType;
        }
    }

    public enum TransactionType
    {
        Deposit,
        Withdrawal
    }
}
