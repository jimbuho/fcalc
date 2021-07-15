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

            // TODO Validar Tipos de datos: Validador.isNumber(txtStartRange.Text)

            CommercialPlanRangeViewModel commercialPlanRangeModelView = new CommercialPlanRangeViewModel();
            commercialPlanRangeModelView.startRange = textToNumber(txtStartRange.Text, true);
            commercialPlanRangeModelView.endRange = textToNumber(txtEndRange.Text, false);
            commercialPlanRangeModelView.price = Decimal.Parse(txtPrice.Text);
            ComboboxItem commercialPlanItem = (ComboboxItem)cmbCommercialPlan.SelectedItem;
            commercialPlanRangeModelView.idCommercialplan = commercialPlanItem.Value;

            
            // Obtener los rangos de planes comerciales que sean iguales al elegido por el usuario
            List<CommercialPlanRangeViewModel> listaRangos = controller.GetCommercialPlanRangeByCommecialPlan(Convert.ToInt32(commercialPlanRangeModelView.idCommercialplan));

            // Valido que no hayan rangos que incluyan o sean iguales al que esta ingresando el usuario
            if (!validarExistenciaRangos(listaRangos, Convert.ToInt32(commercialPlanRangeModelView.startRange), 
                Convert.ToInt32(commercialPlanRangeModelView.endRange)))
            {
                MessageBox.Show("Ya hay un rango similar al elegido");
            }
            else
            {

                if (controller.CommercialPlanRangeInsert(commercialPlanRangeModelView))
                {
                    MessageBox.Show("Rango de Plan Comercial guardado con exito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Rango de Plan Comercial no pudo ser guardado");
                }
            }
        }

        private Boolean validarExistenciaRangos(List<CommercialPlanRangeViewModel> listaRangos, int inicio, int fin)
        {
            /*
             * TODO Controlar que el rango no sea igual o incluido en un rango existe
             */
            foreach(CommercialPlanRangeViewModel item in listaRangos)
            {
                if(item.startRange == inicio)
                {
                    return false;
                }
            }

            return true;
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
