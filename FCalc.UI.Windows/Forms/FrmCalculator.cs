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

        public FrmCalculator()
        {
            InitializeComponent();
            controller = new CalculatorController();
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {

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
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(controller.CalculateAllItems());
        }
    }
}
