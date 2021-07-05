using FCalc.UI.Windows.ApplicationController;
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
        CustomerController controller;

        public FrmCustomerList()
        {
            InitializeComponent();
            controller = new CustomerController();
        }

        private void crearNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer = new FrmCustomer();
            frmCustomer.TopLevel = true;
            frmCustomer.Show();
        }

        private void FrmCustomerList_Load(object sender, EventArgs e)
        {
            doMainQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doMainQuery();
        }
        
        private void doMainQuery()
        {
            dgCustomersList.DataSource = controller.FindActiveCustomers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgCustomersList.DataSource = controller.FindActiveCustomersByRUC(txtRucSearch.Text);
        }
    }
}
