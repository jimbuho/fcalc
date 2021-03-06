using FCalc.UI.Windows.ApplicationController;
using FCalc.UI.Windows.Forms;
using FCalc.UI.Windows.ViewModel;
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
        FrmCustomerList frmCustomerList;
        private CustomerController customerController;
        private CommercialPlanController commercialPlanController;
        CustomerController controller;
       

        public FrmCustomer()
        {
            InitializeComponent();
            customerController = new CustomerController();
            commercialPlanController = new CommercialPlanController();
            frmCustomerList = new FrmCustomerList();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                CustomerViewModel customerModelView = new CustomerViewModel();
                customerModelView.legalName = txtLegalName.Text;
                customerModelView.ruc = txtRUC.Text;
                ComboboxItem commercialPlanItem = (ComboboxItem)cmbCommecialPlan.SelectedItem;
                customerModelView.idCommercialplan = commercialPlanItem.Value;
                if (customerController.CustomerInsert(customerModelView))
                {
                    MessageBox.Show("Tipo de Plan guardado con exito");
                    // Refresca la consulta del formulario
                    MDIMain parent = this.MdiParent as MDIMain;
                    if (parent != null && parent.frmCustomerList != null)
                    {
                        // Recuerde este metodo "doMainQuery" debe ser publico y
                        // frmPlanTypeList debe tener la forma get-set
                        parent.frmCustomerList.doMainQuery();
                    }
                    else
                    {
                        MessageBox.Show("Parent Not exists");
                    }
                    // Cierra el formulario actual
                    this.Close();
                }
                else
                {

                    MessageBox.Show("Cliente no pudo ser guardado");
                }
            }
        }
      
            private void FrmCustomer_Load(object sender, EventArgs e)
        {
            List<CommercialPlanViewModel> commercialPlans = commercialPlanController.FindActiveCommercialPlan();
            foreach (CommercialPlanViewModel commercialPlan in commercialPlans)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = $"{commercialPlan.name}";
                item.Value = commercialPlan.idCommercialplan;
                cmbCommecialPlan.Items.Add(item);
            }
        }

        private bool ValidarFormulario()
        {
            if(!Validator.ValidarCamposTexto(txtLegalName, "Razon Social", 5))
            {
                return false;
            }
            if (cmbCommecialPlan.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un plan comercial");
                return false;
            }
            if (!Validator.VerificaRuc(txtRUC.Text))
            {
                MessageBox.Show("Debe ingresar un RUC valido");
                return false;
            }
            else
            {
                List<CustomerViewModel> customers = customerController.FindActiveCustomersByRUC(txtRUC.Text, -1);
                if (customers.Count > 0)
                {
                    MessageBox.Show("Ya existe un cliente con ese RUC");
                    return false;
                }
            }
            return true;
        }
    }
}
