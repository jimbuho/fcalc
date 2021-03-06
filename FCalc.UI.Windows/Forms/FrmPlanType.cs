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
    public partial class FrmPlanType : Form
    {
        PlanTypeController controller;
        public FrmPlanType()
        {
            InitializeComponent();
            controller = new PlanTypeController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                PlanTypeViewModel planTypeModelView = new PlanTypeViewModel();
                planTypeModelView.name = txtName.Text;
                planTypeModelView.isDynamic = chkIsDynamic.Checked;
                planTypeModelView.requireRange = chkRequireRange.Checked;

                if (controller.PlanTypeInsert(planTypeModelView))
                {
                    MessageBox.Show("Tipo de Plan guardado con exito");
                    // Refresca la consulta del formulario
                    MDIMain parent = this.MdiParent as MDIMain;
                    if (parent!=null && parent.frmPlanTypeList != null)
                    {
                        // Recuerde este metodo "doMainQuery" debe ser publico y
                        // frmPlanTypeList debe tener la forma get-setp
                        parent.frmPlanTypeList.doMainQuery();
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

                    MessageBox.Show("Tipo de Plan no pudo ser guardado");
                }
            }
        }

        private bool ValidarFormulario()
        {
            if (!Validator.ValidarCamposTexto(txtName, "Nombre del Tipo de Plan", 3))
            {
                return false;
            }
            else
            {
                List<PlanTypeViewModel> plans = controller.FindActivePlanTypeByName(txtName.Text, -1);
                if (plans.Count > 0)
                {
                    MessageBox.Show("Ya existen tipos de plan con ese nombre");
                    return false;
                }
            }

            return true;
        }
    }
}
