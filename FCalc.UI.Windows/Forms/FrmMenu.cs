using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCalc.UI.Windows.Forms
{
    public partial class FrmMenu : Form
    {
        private FrmCustomerList frmCustomerList;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerList = new FrmCustomerList();
            frmCustomerList.TopLevel = true;
            frmCustomerList.Show();
        }
    }
}
