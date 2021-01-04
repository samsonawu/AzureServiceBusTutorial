using AzureServiceBus.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AzureServiceBus.Repo
{
    public interface ITransactionRepo
    {
       object Transfer(TransactionModel trans);
    }
}
