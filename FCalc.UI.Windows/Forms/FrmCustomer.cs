﻿using FCalc.UI.Windows.ApplicationController;
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
        private CustomerController customerController;
        private CommercialPlanController commercialPlanController;
        public FrmCustomer()
        {
            InitializeComponent();
            customerController = new CustomerController();
            commercialPlanController = new CommercialPlanController();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CustomerViewModel customerModelView = new CustomerViewModel();
            customerModelView.legalName = txtLegalName.Text;
            customerModelView.ruc = txtRUC.Text;
            ComboboxItem commercialPlanItem = (ComboboxItem)cmbCommecialPlan.SelectedItem;
            customerModelView.idCommercialplan = commercialPlanItem.Value;
            if (customerController.CustomerInsert(customerModelView))
            {
                MessageBox.Show("Cliente guardado con exito");
                this.Close();
            }
            else
            {

                MessageBox.Show("Cliente no pudo ser guardado");
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
            return true;
        }
    }
}
