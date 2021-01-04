using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ASBRepo
{
    interface ITransactionRepo
    {
       object Transfer(Transaction transaction);
    }
}
