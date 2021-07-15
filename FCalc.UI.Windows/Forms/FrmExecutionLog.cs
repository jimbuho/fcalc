﻿using FCalc.UI.Windows.ApplicationController;
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString("yyyy-MM");
            grdExecutionLog.DataSource = controller.FindActiveExecutionLogsByDate(date);
        }

        private void ExportGridToExcel()
        {
            try
            {
                String dateStr = dateTimePicker1.Value.ToString("yyyy-MM");
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
                MessageBox.Show("Tenemos un problema para exportar su reporte a Excel: "+ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportGridToExcel();
        }
    }
}
