
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
                commercialPlanModelView.price = Decimal.Parse(txtPrice.Text);
                ComboboxItem item = (ComboboxItem)cmbPlanType.SelectedItem;
                commercialPlanModelView.idPlantype = item.Value;

                if (controller.CommercialPlanInsert(commercialPlanModelView))
                {
                    MessageBox.Show("Plan comercial guardado con exito");
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
                List<CommercialPlanViewModel> plans = controller.FindActiveCommercialPlanByName(txtName.Text);
                if(plans.Count > 0)
                {
                    MessageBox.Show("Ya existen planes comerciales con ese nombre");
                    return false;
                }
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
