using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCalc.UI.Windows.ViewModel
{
    public class PlanTypeViewModel
    {
        public int idPlantype { get; set; }
        public string name { get; set; }
        public Nullable<bool> requireRange { get; set; }
        public Nullable<bool> isDynamic { get; set; }
       // public string status { get; set; }
        public Nullable<System.DateTime> creationDate { get; set; }
    }
}
