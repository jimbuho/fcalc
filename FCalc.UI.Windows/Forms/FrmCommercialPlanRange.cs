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
    public partial class FrmCommercialPlanRange : Form
    {
        CommercialPlanRangeController controller;
        CommercialPlanController commercialPlanController;
        public FrmCommercialPlanRange()
        {
            InitializeComponent();
            controller = new CommercialPlanRangeController();
            commercialPlanController = new CommercialPlanController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {

                // TODO Validar Tipos de datos: Validador.isNumber(txtStartRange.Text)

                CommercialPlanRangeViewModel commercialPlanRangeModelView = new CommercialPlanRangeViewModel();
                commercialPlanRangeModelView.startRange = textToNumber(txtStartRange.Text, true);
                commercialPlanRangeModelView.endRange = textToNumber(txtEndRange.Text, false);
                commercialPlanRangeModelView.price = Convert.ToDecimal(txtPrice.Text);
                ComboboxItem commercialPlanItem = (ComboboxItem)cmbCommercialPlan.SelectedItem;
                commercialPlanRangeModelView.idCommercialplan = commercialPlanItem.Value;


                // Obtener los rangos de planes comerciales que sean iguales al elegido por el usuario
                List<CommercialPlanRangeViewModel> listaRangos = controller.GetCommercialPlanRangeByCommecialPlan(Convert.ToInt32(commercialPlanRangeModelView.idCommercialplan));

                // Valido que no hayan rangos que incluyan o sean iguales al que esta ingresando el usuario
                if (!Validator.validarExistenciaRangos(listaRangos, Convert.ToInt32(commercialPlanRangeModelView.startRange),
                    Convert.ToInt32(commercialPlanRangeModelView.endRange)))
                {
                    MessageBox.Show("Ingrese un rango correcto");
                }
                else
                {

                    if (controller.CommercialPlanRangeInsert(commercialPlanRangeModelView))
                    {
                        MessageBox.Show("Tipo de Plan guardado con exito");
                        // Refresca la consulta del formulario
                        MDIMain parent = this.MdiParent as MDIMain;
                        if (parent != null && parent.frmCommercialPlanRangeList != null)
                        {
                            // Recuerde este metodo "doMainQuery" debe ser publico y
                            // frmPlanTypeList debe tener la forma get-set
                            parent.frmCommercialPlanRangeList.UpdateGrid();
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
                        MessageBox.Show("Rango de Plan Comercial no pudo ser guardado");
                    }
                }
            }
        }

        private bool ValidarFormulario()
        {
            if (!Validator.ValidarCamposTexto(txtStartRange, "Inicio de Rango", 1))
            {
                return false;
            }
            if (!Validator.ValidarCamposTexto(txtEndRange, "Fin de Rango", 1))
            {
                return false;
            }
            if (!Validator.ValidarCamposTexto(txtPrice, "Precio", 1))
            {
                return false;
            }
            if(cmbCommercialPlan.SelectedItem == null)
            {
                MessageBox.Show("Debe elegir el Plan Comercial relacionado a este rango");
                return false;
            }

            return true;
        }


        private void txtField_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.ValidateNumbers(sender, e);
        }

        private void txtEndRange_TextChanged(object sender, EventArgs e)
        {

        }

        private Int32 textToNumber(string text, Boolean isInit)
        {
            if (text != "")
            {
                return Int32.Parse(text);
            }
            else
            {
                if (isInit)
                {
                    return Int32.Parse("0");
                }
                else
                {
                    return Int32.Parse("10000000");
                }
            }
        }

        private void FrmCommercialPlanRange_Load(object sender, EventArgs e)
        {
            List<CommercialPlanViewModel> commercialPlans = commercialPlanController.FindActiveCommercialPlan();
            foreach (CommercialPlanViewModel commercialPlan in commercialPlans)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = $"{commercialPlan.name}";
                item.Value = commercialPlan.idCommercialplan;
                cmbCommercialPlan.Items.Add(item);
            }
        }
                
    }
}
