using AzureServiceBus.Models;
using AzureServiceBus.Repo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace AzureServiceBus.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Transactions : ControllerBase
    {
        private readonly ITransactionRepo _transactionRepo;
        private ResponseObject responseObject;
        public Transactions(ITransactionRepo transactionRepo)
        {
            _transactionRepo = transactionRepo;
        }
        [HttpPost]
        public IActionResult Transfer(TransactionModel trans)
        {
            try
            {
                _transactionRepo.Transfer(trans);
            }

            catch (Exception ex)
            {
                responseObject = new ResponseObject()
                {
                    Response = null,
                    Description = ex.Message,
                    StatusCode = "99"
                };
                return StatusCode(500, responseObject);
            }
            return null;
        }
    }
}
