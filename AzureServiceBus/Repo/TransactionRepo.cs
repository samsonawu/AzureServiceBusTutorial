using AzureServiceBus.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace AzureServiceBus.Repo
{
    public class TransactionRepo : ITransactionRepo
    {
        public object Transfer(TransactionModel transaction)
        {
            throw new NotImplementedException();
        }
    }
}
