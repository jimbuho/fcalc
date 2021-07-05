using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCalc.UI.Windows.ViewModel
{
    public class CommercialPlanViewModel
    {
        public int idCommercialplan { get; set; }
        public string name { get; set; }
        public Nullable<int> idPlantype { get; set; }
        public Nullable<decimal> price { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> creationDate { get; set; }
    }
}
