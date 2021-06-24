using ACMEBodegas.UI.Windows.ApplicationController;
using FCalc.UI.Windows.ModelView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.windows.Forms
{
    public partial class FrmCustomer : Form
    {
        private CustomerController customerController;
        public FrmCustomer()
        {
            InitializeComponent();
            customerController = new CustomerController();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CustomerViewModel customerModelView = new CustomerViewModel();
            customerModelView.legalName = txtLegalName.Text;
            customerModelView.ruc = txtRUC.Text;
            if(customerController.CustomerInsert(customerModelView))
            {
                lblResult.Text = "Cliente guardado con exito";
            }
            else
            {
                lblResult.Text = "Cliente no pudo ser guardado";
            }
        }
    }
}
