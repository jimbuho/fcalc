using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCalc.UI.Windows.ViewModel
{
    public class CustomerViewModel
    {
        public int idCustomer { get; set; }
        public string ruc { get; set; }
        public string legalName { get; set; }
        public string planName { get; set; }
        public string planType { get; set; }
        public Nullable<System.DateTime> creationDate { get; set; }
        public Nullable<int> idCommercialplan { get; set; }
        
    }
}
