using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCalc.UI.Windows.ViewModel
{
    public class CalcProcess
    {
        public int counter { get; set; }
        public string ruc { get; set; }
        public decimal total { get; set; }

        public CalcProcess(string ruc, string counter)
        {
            this.ruc = ruc;
            this.counter = Convert.ToInt32(counter);
        }
    }
}
