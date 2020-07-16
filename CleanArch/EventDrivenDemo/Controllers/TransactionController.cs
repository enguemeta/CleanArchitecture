using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventDrivenDemo.Services;
using Microsoft.AspNetCore.Mvc;



namespace EventDrivenDemo.Controllers
{
    public class TransactionController : Controller
    {
        private readonly ITransactionService _transactionService;
        private readonly IAuditService _auditService;

        public TransactionController(ITransactionService transactionService, IAuditService auditService)
        {
            _transactionService = transactionService;
            _auditService = auditService;
            _auditService.Subscribe(_transactionService);
        }

        [HttpPost("deposit")]
        public IActionResult MakeDeposit([FromQuery] decimal amount)
        {
            _transactionService.MakeDeposit(amount);
            return Ok();
        }

        [HttpPost("withdrawal")]
        public IActionResult MakeWithdrawal([FromQuery] decimal amount)
        {
            _transactionService.MakeWithdrawal(amount);
            return Ok();
        }       
    }
}
