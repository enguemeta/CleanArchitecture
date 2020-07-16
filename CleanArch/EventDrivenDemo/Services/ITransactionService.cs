using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventDrivenDemo.Events;

namespace EventDrivenDemo.Services
{
    public interface ITransactionService
    {
        event EventHandler<TransactionProcessedEventArgs> OnTransactionProcessed;
        void MakeDeposit(decimal amount);
        void MakeWithdrawal(decimal amount);
        void ProcessDeposit(decimal amount);
        void ProcessWithdrawal(decimal amount);
    }
}
