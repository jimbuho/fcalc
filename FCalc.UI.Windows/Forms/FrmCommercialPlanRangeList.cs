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
    public partial class FrmCommercialPlanRangeList : Form
    {
        private CommercialPlanRangeController controller;
        private FrmCommercialPlanRange frmCommercialPlanRange;
        public FrmCommercialPlanRangeList()
        {
            InitializeComponent();
            controller = new CommercialPlanRangeController();
        }

        private void FrmCommercialPlanRangeList_Load(object sender, EventArgs e)
        {
            doQuery();
        }

        private void doQuery()
        {
            grdCommercialPlanRange.DataSource = controller.FindActiveCommercialPlanRange();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCommercialPlanRange = new FrmCommercialPlanRange();
            frmCommercialPlanRange.TopLevel = true;
            frmCommercialPlanRange.Show();
        }
    }
}
