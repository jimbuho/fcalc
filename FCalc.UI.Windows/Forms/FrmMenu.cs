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
    public partial class FrmMenu : Form
    {
        private FrmCustomerList frmCustomerList;
        private FrmCommercialPlanList frmCommercialPlanList;
        private FrmPlanTypeList frmPlanTypeList;
        private FrmCommercialPlanRangeList frmCommercialPlanRangeList;
        private FrmExecutionLog executionLog;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerList = new FrmCustomerList();
            frmCustomerList.TopLevel = true;
            frmCustomerList.Show();
        }

        private void planesComercialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCommercialPlanList = new FrmCommercialPlanList();
            frmCommercialPlanList.TopLevel = true;
            frmCommercialPlanList.Show();
        }

        private void tiposDePlanesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlanTypeList = new FrmPlanTypeList();
            frmPlanTypeList.TopLevel = true;
            frmPlanTypeList.Show();
        }

        private void rangosDePlanComercialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCommercialPlanRangeList = new FrmCommercialPlanRangeList();
            frmCommercialPlanRangeList.TopLevel = true;
            frmCommercialPlanRangeList.Show();
        }

        private void historicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            executionLog = new FrmExecutionLog();
            executionLog.TopLevel = true;
            executionLog.Show();
        }
    }
}
