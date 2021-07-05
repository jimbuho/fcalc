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
    public partial class FrmPlanTypeList : Form
    {
        PlanTypeController controller;
        FrmPlanType frmPlanType;
        public FrmPlanTypeList()
        {
            InitializeComponent();
            controller = new PlanTypeController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPlanType = new FrmPlanType();
            frmPlanType.TopLevel = true;
            frmPlanType.Show();
        }

        private void FrmPlanTypeList_Load(object sender, EventArgs e)
        {
            doMainQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doMainQuery();
        }

        private void doMainQuery()
        {
            grdPlanTypes.DataSource = controller.FindActivePlanType();
        }
    }
}
