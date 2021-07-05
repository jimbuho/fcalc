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
            CommercialPlanRangeViewModel commercialPlanRangeModelView = new CommercialPlanRangeViewModel();
            commercialPlanRangeModelView.startRange = Int32.Parse(txtStartRange.Text);
            commercialPlanRangeModelView.endRange = Int32.Parse(txtEndRange.Text);
            commercialPlanRangeModelView.price = Decimal.Parse(txtPrice.Text);
            ComboboxItem commercialPlanItem = (ComboboxItem)cmbCommercialPlan.SelectedItem;
            commercialPlanRangeModelView.idCommercialplan = commercialPlanItem.Value;
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
