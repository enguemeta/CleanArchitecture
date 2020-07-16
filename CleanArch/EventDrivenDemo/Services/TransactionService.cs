using System;
using EventDrivenDemo.Events;

namespace EventDrivenDemo.Services
{
    public class TransactionService : ITransactionService
    {
        public event EventHandler<TransactionProcessedEventArgs> OnTransactionProcessed; 

        public void MakeDeposit(decimal amount)
        {
            ProcessDeposit(amount);
            OnTransactionProcessed?.Invoke(this, new TransactionProcessedEventArgs(amount, TransactionType.Deposit));
        }

        public void MakeWithdrawal(decimal amount)
        {
            ProcessWithdrawal(amount);
            OnTransactionProcessed?.Invoke(this, new TransactionProcessedEventArgs(amount, TransactionType.Withdrawal));
        }

        public void ProcessDeposit(decimal amount)
        {}

        public void ProcessWithdrawal(decimal amount)
        {}
    }
}
