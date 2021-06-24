using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.windows.Forms;

namespace FCalc.UI.Windows.Forms
{
    public partial class FrmCustomerList : Form
    {
        FrmCustomer frmCustomer;

        public FrmCustomerList()
        {
            InitializeComponent();
        }

        private void crearNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer = new FrmCustomer();
            frmCustomer.TopLevel = true;
            frmCustomer.Show();
        }
    }
}
