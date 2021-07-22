
using FCalc.Domain.Model.Entities;
using FCalc.UI.Windows.ApplicationController;
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

namespace FCalc.UI.Windows.Forms
{
    public partial class FrmCommercialPlan : Form
    {
        CommercialPlanController controller;
        PlanTypeController planTypeController;
        public FrmCommercialPlan()
        {
            InitializeComponent();
            controller = new CommercialPlanController();
            planTypeController = new PlanTypeController();
        }

        private void FrmCommercialPlan_Load(object sender, EventArgs e)
        {
            LoadPlanTypes();
        }

        private void LoadPlanTypes()
        {
            List<PlanTypeViewModel> planTypes = planTypeController.FindActivePlanType();
            foreach (PlanTypeViewModel planType in planTypes)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = $"{planType.name}";
                item.Value = planType.idPlantype;
                cmbPlanType.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                CommercialPlanViewModel commercialPlanModelView = new CommercialPlanViewModel();
                commercialPlanModelView.name = txtName.Text;
                commercialPlanModelView.price = Convert.ToDecimal(txtPrice.Text);
                ComboboxItem item = (ComboboxItem)cmbPlanType.SelectedItem;
                commercialPlanModelView.idPlantype = item.Value;

                if (controller.CommercialPlanInsert(commercialPlanModelView))
                {
                    MessageBox.Show("Tipo de Plan guardado con exito");
                    // Refresca la consulta del formulario
                    MDIMain parent = this.MdiParent as MDIMain;
                    if (parent != null && parent.frmCommercialPlanList != null)
                    {
                        // Recuerde este metodo "doMainQuery" debe ser publico y
                        // frmPlanTypeList debe tener la forma get-set
                        parent.frmCommercialPlanList.doMainQuery();
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

                    MessageBox.Show("Plan comercial no pudo ser guardado");
                }
            }
        }

        private bool ValidarFormulario()
        {
            if (!Validator.ValidarCamposTexto(txtName, "Nombre del Plan", 3))
            {
                return false;
            }
            else
            {
                List<CommercialPlanViewModel> plans = controller.FindActiveCommercialPlanByName(txtName.Text, -1);
                if(plans.Count > 0)
                {
                    MessageBox.Show("Ya existen planes comerciales con ese nombre: ");
                    /*foreach(CommercialPlanViewModel plan in plans) {
                        MessageBox.Show(plan.idCommercialplan+": "+plan.name);
                    }*/
                    
                    return false;
                }
            }
            if (!Validator.ValidarCamposTexto(txtPrice, "Precio del Plan", 1))
            {
                return false;
            }

            if (cmbPlanType.SelectedItem == null)
            {
                MessageBox.Show("Debe elegir un tipo de plan");
                return false;
            }

            return true;
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.ValidateNumbers(sender, e);
        }
    }
}
