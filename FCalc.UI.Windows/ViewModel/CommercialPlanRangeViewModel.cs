using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCalc.UI.Windows.ViewModel
{
    public class CommercialPlanRangeViewModel
    {
        internal string plantype;
        public int idPlanrange { get; set; }
        public Nullable<int> startRange { get; set; }
        public Nullable<int> endRange { get; set; }
        public Nullable<decimal> price { get; set; }
        public string planType1 { get; set; }    
       // public string status { get; set; }
        public Nullable<System.DateTime> creationDate { get; set; }
        public Nullable<int> idCommercialplan { get; set; }
    }
}
