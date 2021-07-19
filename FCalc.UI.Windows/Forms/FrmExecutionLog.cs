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
        private string selectedDate;
        public FrmExecutionLog()
        {
            InitializeComponent();
            controller = new ExecutionLogController();
            selectedDate = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmExecutionLog_Load(object sender, EventArgs e)
        {
            grdExecutionLog.DataSource = controller.FindActiveExecutionLogs();
            grdExecutionLog.Columns[0].HeaderText = "ID REGISTRO";
            grdExecutionLog.Columns[1].HeaderText = "ID CIENTE";
            grdExecutionLog.Columns[2].HeaderText = "RECUENTO TRANSACCIONES";
            grdExecutionLog.Columns[3].HeaderText = "TOTAL CALCULO";
            grdExecutionLog.Columns[4].HeaderText = "FECHA CREACIÓN";
            grdExecutionLog.Columns[5].HeaderText = "MES";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            selectedDate = dateTimePicker1.Value.ToString("yyyy-MM");
            grdExecutionLog.DataSource = controller.FindActiveExecutionLogsByDate(selectedDate);
        }

        private void ExportGridToExcel()
        {
            if (selectedDate == null)
            {
                MessageBox.Show("Debe seleccionar una fecha para exportar a Excel los registros de ese mes");
                return;
            }

            try
            {
                String dateStr = selectedDate;
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                try
                {
                    worksheet = workbook.Sheets["Sheet1"];
                }
                catch (Exception e)
                {
                    worksheet = workbook.Sheets["Hoja1"];
                }
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "FACTURACION "+ dateStr;
                // storing header part in Excel  
                for (int i = 1; i < grdExecutionLog.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = grdExecutionLog.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < grdExecutionLog.Rows.Count; i++)
                {
                    for (int j = 0; j < grdExecutionLog.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = grdExecutionLog.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // save the application  
                workbook.SaveAs("c:\\output"+dateStr+".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application  
                app.Quit();
            }catch(Exception ex)
            {
                MessageBox.Show("Fin de procesamiento");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportGridToExcel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(selectedDate != null)
            {
                DialogResult dialogResult = MessageBox.Show("Confirma deshabilitar los registros del mes "+selectedDate+"?",
                    "Eliminar Registros", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    controller.DisableExcecutionLogByDate(selectedDate);
                    grdExecutionLog.DataSource = controller.FindActiveExecutionLogsByDate(selectedDate);
                    MessageBox.Show("Todos los registros del mes: " + selectedDate + " han sido deshabilitados con exito");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fecha para desahabilitar los registros de ese mes");
            }
        }
    }
}
