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
    public partial class FrmExecutionLog : Form
    {
        private ExecutionLogController controller;
        public FrmExecutionLog()
        {
            InitializeComponent();
            controller = new ExecutionLogController();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmExecutionLog_Load(object sender, EventArgs e)
        {
            grdExecutionLog.DataSource = controller.FindActiveExecutionLogs();
        }
    }
}
