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
            PlanTypeViewModel planTypeModelView = new PlanTypeViewModel();
            planTypeModelView.name = txtName.Text;
            planTypeModelView.isDynamic = chkIsDynamic.Checked;
            planTypeModelView.requireRange = chkRequireRange.Checked;
            
            if (controller.PlanTypeInsert(planTypeModelView))
            {
                MessageBox.Show("Tipo de Plan guardado con exito");
                this.Close();
            }
            else
            {

                MessageBox.Show("Tipo de Plan no pudo ser guardado");
            }
        }
    }
}
