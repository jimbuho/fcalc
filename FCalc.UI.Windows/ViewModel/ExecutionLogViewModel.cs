using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCalc.UI.Windows.ViewModel
{
    public class ExecutionLogViewModel
    {
        public int idExecutionlog { get; set; }
        public string ruc { get; set; }
        public Nullable<int> transactionsCount { get; set; }
        public Nullable<decimal> totalCalc { get; set; }

        public string planName { get; set; }
        public string planType { get; set; }

        public string isDinamic { get; set; }

        public string isRange { get; set; }

        public Nullable<System.DateTime> creationDate { get; set; }

        public Nullable<int> idCustomer { get; set; }

        public Nullable<int> month { get; set; }
    }
}
