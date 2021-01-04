using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureServiceBus.Models
{
    public class TransactionModel
    {
        public string debitAccount { get; set; }
        public string creditAccount { get; set; }
        public string amount { get; set; }
    }
}
