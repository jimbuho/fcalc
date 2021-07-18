using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;       // EXCEL APPLICATION.
using FCalc.UI.Windows.ApplicationController;

namespace FCalc.UI.Windows.Forms
{
    public partial class FrmCalculator : Form
    {
        private CalculatorController controller;
        private ExecutionLogController executionLogController;

        public FrmCalculator()
        {
            InitializeComponent();
            controller = new CalculatorController();
            executionLogController = new ExecutionLogController();
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofdFileFinder.Title = "Archivo Excel a Procesar";
            ofdFileFinder.FileName = "";
            ofdFileFinder.Filter = "Excel File|*.xlsx;*.xls";

            if (ofdFileFinder.ShowDialog() == DialogResult.OK)
            {
                string sFileName = ofdFileFinder.FileName;
                if (sFileName.Trim() != "")
                {
                    controller.Excel2Grid(grdPreview, lblMessages, sFileName);
                    button2.Enabled = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (executionLogController.ThereAreExecutionLogsInThisMonth())
            {
                //MessageBox.Show("Ya existe procesamiento en este mes. Si quiere reintentarlo, dirigirse a la opcion <Deshabilitar Procesamiento del mes> en Historios");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Ha revisado todos los datos y confirma realizar el calculo de facturación de este mes?",
                       "Procesar Calculo", MessageBoxButtons.YesNo);
                 
                if (dialogResult == DialogResult.Yes)
                {
                    button2.Enabled = false;
                    controller.CalculateAllItems(grdResults, lblMessages);
                    button2.Enabled = true;
                }
            }
        }
    }
}
