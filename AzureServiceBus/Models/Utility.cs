using AzureServiceBus.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureServiceBus.Models
{
    public class Utility
    {
        private readonly IQueueService queue;
        public Utility()
        {

        }
        private async Task PublishMessage(TransactionModel trans)
        {
            await queue.SendMessageAsync(trans, "personqueue");
            trans = new TransactionModel();
        }
    }

    public class ResponseObject
    {
        public object Response { get; set; }

        public string StatusCode { get; set; }

        public string Description { get; set; }


    }
}
