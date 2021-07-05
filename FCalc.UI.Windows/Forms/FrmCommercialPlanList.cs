using FCalc.UI.Windows.ApplicationController;
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
    public partial class FrmCommercialPlanList : Form
    {
        private CommercialPlanController controller;
        FrmCommercialPlan frmCommercialPlan;
        public FrmCommercialPlanList()
        {
            InitializeComponent();
            controller = new CommercialPlanController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCommercialPlan = new FrmCommercialPlan();
            frmCommercialPlan.TopLevel = true;
            frmCommercialPlan.Show();
        }

        private void FrmCommercialPlanList_Load(object sender, EventArgs e)
        {
            doMainQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doMainQuery();
        }

        private void doMainQuery()
        {
            grdCommercialPlanList.DataSource = controller.FindActiveCommercialPlan();
        }
    }
}
