using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventDrivenDemo.Events;

namespace EventDrivenDemo.Services
{
    public interface IAuditService
    {
        void Subscribe(ITransactionService transactionService);        
    }
}
