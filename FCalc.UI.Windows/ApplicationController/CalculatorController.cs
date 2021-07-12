using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FCalc.Domain.Model.Entities;
using FCalc.UI.Windows.ViewModel;
using Excel = Microsoft.Office.Interop.Excel;       // EXCEL APPLICATION.

namespace FCalc.UI.Windows.ApplicationController
{
    public class CalculatorController
    {
        CustomerController customerController;
        CommercialPlanController commercialPlanController;

        // CREATE EXCEL OBJECTS.
        Excel.Application xlApp = new Excel.Application();
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;

        private List<CalcProcess> data;

        public CalculatorController()
        {
            customerController = new CustomerController();
            commercialPlanController = new CommercialPlanController();
        }

        public void Excel2Grid(DataGridView grdPreview, Label lblMessages, string sFile)
        {
            try
            {
                lblMessages.Text = "Leyendo archivo...";
                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Open(sFile);
                data = new List<CalcProcess>();
                try
                {
                    // Probamos con tab Sheet1
                    xlWorkSheet = xlWorkBook.Worksheets["Sheet1"];
                }
                catch (Exception ex)
                {
                    // Probamos con tab Hoja1
                    xlWorkSheet = xlWorkBook.Worksheets["Hoja1"];
                }

                lblMessages.Text = "Limpiando columnas";

                grdPreview.Rows.Clear();
                grdPreview.Columns.Clear();

                int iRow, iCol;

                // FIRST, CREATE THE DataGridView COLUMN HEADERS.
                for (iCol = 1; iCol <= xlWorkSheet.Columns.Count; iCol++)
                {
                    lblMessages.Text = "Leyendo cabecera " + xlWorkSheet.Cells[1, iCol].value;
                    if (xlWorkSheet.Cells[1, iCol].value == null)
                    {
                        break;      // BREAK LOOP.
                    }
                    else
                    {
                        DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                        col.HeaderText = xlWorkSheet.Cells[1, iCol].value;
                        int colIndex = grdPreview.Columns.Add(col);        // ADD A NEW COLUMN.
                    }
                }

                // ADD ROWS TO THE GRID USING EXCEL DATA.
                for (iRow = 2; iCol <= xlWorkSheet.Rows.Count; iRow++)
                {
                    lblMessages.Text = "Leyendo celdas [" + iRow + ",1]:" + xlWorkSheet.Cells[iRow, 1].value + " y [" + iRow + ",1]:" + xlWorkSheet.Cells[iRow, 2].value;

                    var column1 = xlWorkSheet.Cells[iRow, 1].value;
                    var column2 = xlWorkSheet.Cells[iRow, 2].value;

                    if (column1 == null)
                    {
                        break;
                    }
                    else
                    {
                        // CREATE A STRING ARRAY USING THE VALUES IN EACH ROW OF THE SHEET.
                        string[] row = new string[] {
                            Convert.ToString(column1),
                            Convert.ToString(column2)
                        };

                        data.Add(new CalcProcess(Convert.ToString(column1), Convert.ToString(column2)));

                        // ADD A NEW ROW TO THE GRID USING THE ARRAY DATA.
                        grdPreview.Rows.Add(row);
                    }
                }

                lblMessages.Text = "Archivo Cargado con Exito!";
            }
            catch (Exception e)
            {
                MessageBox.Show("El archivo tiene problemas para ser leido: " + e);
                Console.Write("Error de lectura del archivo", e);
            }
            finally
            {
                xlWorkBook.Close();
                xlApp.Quit();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet);
            }
        }

        public void CalculateAllItems(DataGridView grdResult, Label lblMessages)
        {
            lblMessages.Text = "Calculando...";
            grdResult.Rows.Clear();
            grdResult.Columns.Clear();

            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = "RUC";
            grdResult.Columns.Add(col);
            col = new DataGridViewTextBoxColumn();
            col.HeaderText = "Total";
            grdResult.Columns.Add(col);

            foreach (CalcProcess cp in data)
            {
                var cpNew = DoCalcProcessItem(cp);

                string[] row = new string[] {
                        Convert.ToString(cpNew.ruc),
                        Convert.ToString(cpNew.total)
                    };

                grdResult.Rows.Add(row);
            }
            lblMessages.Text = "Proceso de calculo finalizado";
        }

        private CalcProcess DoCalcProcessItem(CalcProcess item)
        {
            List<CustomerViewModel> customerList = customerController.FindActiveCustomersByRUC(item.ruc);
            if (customerList.Count > 0)
            {
                CustomerViewModel customer = customerList[0];
                CommercialPlan commercialPlan = commercialPlanController.GetById(Convert.ToInt32(customer.idCommercialplan));
                
                if (commercialPlan != null)
                {
                    //Console.WriteLine("Comercial Plan " + commercialPlan.idPlantype);
                    item.total = Convert.ToDecimal(item.counter * commercialPlan.price);
                }
                else
                {
                    Console.WriteLine("Comercial Plan NO Encontrado: "+customer.idCommercialplan);
                }
            }
            else
            {
                Console.WriteLine("RUC NO encontrado" + item.ruc);
            }
            return item;
        }
    }
}
