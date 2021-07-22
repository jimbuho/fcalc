using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FCalc.UI.Windows.ApplicationController;
using FCalc.UI.Windows.ViewModel;
using UI.windows.Forms;

namespace FCalc.UI.Windows.Forms
{
    public partial class FrmCustomerList : Form
    {
        FrmCustomer frmCustomer;
        CustomerController controller;
        CommercialPlanController commercialPlanController;
        CustomerViewModel selectedItem;
        PlanTypeViewModel value;

        public FrmCustomerList()
        {
            InitializeComponent();
            controller = new CustomerController();
            commercialPlanController = new CommercialPlanController();
            value = new PlanTypeViewModel();
        }

        private void crearNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer = new FrmCustomer();
            frmCustomer.TopLevel = true;
            frmCustomer.Show();
        }

        private void FrmCustomerList_Load(object sender, EventArgs e)
        {
            doMainQuery();

            List<CommercialPlanViewModel> commercialPlans = commercialPlanController.FindActiveCommercialPlan();
            foreach (CommercialPlanViewModel commercialPlan in commercialPlans)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = $"{commercialPlan.name}";
                item.Value = commercialPlan.idCommercialplan;
                cmbCommecialPlan.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doMainQuery();
        }

        public void doMainQuery()
        {
            dgCustomersList.DataSource = controller.FindActiveCustomers();
            dgCustomersList.Columns[0].HeaderText = "ID";
            dgCustomersList.Columns[1].HeaderText = "RUC";
            dgCustomersList.Columns[2].HeaderText = "NOMBRE";
            dgCustomersList.Columns[3].HeaderText = "PLAN";
            dgCustomersList.Columns[4].HeaderText = "TIPO DE PLAN";
            dgCustomersList.Columns[5].HeaderText = "FECHA CREACIÓN";
            dgCustomersList.Columns[6].HeaderText = "ID PLAN";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MDIMain parent = this.MdiParent as MDIMain;
            if (parent != null)
            {
                // Recuerde crear este metodo en el formulario MDI Como publico
                parent.OpenFormCustomer();
            }
            else
            {
                MessageBox.Show("Parent Not exists");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
             * Si hay un registro seleccionado entonces lo mandamos a actualizar, al terminar
             * conexito el guardado recargamos el GridControl.
             */
            if (selectedItem != null && selectedItem.ruc != null)
            {
                if (ValidarFormulario())
                {
                    // Aqui copiamos todo los valores cambiados del formulario hacia el objeto antes de 
                    // enviarlo a cambiar en la base de datos
                    selectedItem.ruc = txtRUC.Text;
                    selectedItem.legalName = txtLegalName.Text;
                    // Se toma el objeto seleccionado y luego se obtien el id (value)
                    ComboboxItem commercialPlanItem = (ComboboxItem)cmbCommecialPlan.SelectedItem;
                    selectedItem.idCommercialplan = commercialPlanItem.Value;
                   

                    if (controller.CustomerModify(selectedItem))
                    {
                        MessageBox.Show("Registro Modificado con exito");
                        doMainQuery();
                        // Importante vaciar el registro actual para obligar al usuario a seleccionarlo
                        selectedItem = null;
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error en la modificación");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar el registro a modificar");
            }

        }
        private void dgCustomersList_CellClick(Object sender, DataGridViewCellEventArgs e)
        {
            // Ante este evento detectamos click sobre la celda
            detectClickOnGrid();
        }
        private void dgCustomersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            detectClickOnGrid();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*
             * 
             * En este metodo tomamos todas las filas seleccionadas por el usuario y
             * extramos de cada fila el ID (columna 0) para proceder a eliminar (status=0)
             * el registro si el usuario previamente acepta dicha eliminacion:
             * 
             */
            Int32 selectedRowCount = dgCustomersList.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                DialogResult dialogResult = MessageBox.Show("Confirma eliminar los registro seleccionados?",
                    "Eliminar Registros", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        Int32 id = Convert.ToInt32(dgCustomersList.Rows[dgCustomersList.SelectedRows[i].Index].Cells[0].Value);
                        controller.CustomerDelete(id);
                        sb.Append("Item #" + id + " ");
                    }

                    MessageBox.Show(sb.ToString(), "Fueron eliminados");
                    doMainQuery();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar registros antes de continuar");
            }
        }
        private void detectClickOnGrid()
        {
            /*
             * 
             * Aqui copiamos el registro de la fila seleccionada por el usuario en el GridControl
             * hacia cada campo del objeto selectedItem (que es del tipo ViewModel correspondiente
             * a este modulo, ejemplo: PlayTypViewModel). Con esto tenemos listos el objeto a ser
             * enviado a modificar hacia la base de datos cuando el usuario pulse el boton "Modificar"
             * 
             */
            DataGridViewRow row = dgCustomersList.Rows[dgCustomersList.CurrentCell.RowIndex];

            selectedItem = new CustomerViewModel();
            selectedItem.idCustomer = Convert.ToInt32(row.Cells[0].Value);
            selectedItem.ruc = Convert.ToString(row.Cells[1].Value);
            selectedItem.legalName = Convert.ToString(row.Cells[2].Value);
            selectedItem.idCommercialplan = Convert.ToInt32(row.Cells[6].Value);
            /*
             * Mostramos al usuario los datos del registro seleccionado, notar que
             * debemos transformar los valores al tipo de datos que acepta cada componente
             */
            txtRUC.Text = selectedItem.ruc;
            txtLegalName.Text = selectedItem.legalName;

            int i = 0;
            foreach (var itemPlan in cmbCommecialPlan.Items)
            {
                ComboboxItem cbItem = (ComboboxItem)itemPlan;
                if (cbItem.Value == selectedItem.idCommercialplan)
                {
                    cmbCommecialPlan.SelectedIndex = i;
                }
                i++;
            }

        }

        private void txtRucSearch_TextChanged(object sender, EventArgs e)
        {
            dgCustomersList.DataSource = controller.FindActiveCustomersByRUC(txtRucSearch.Text);
        }

        private bool ValidarFormulario()
        {
            if (!Validator.ValidarCamposTexto(txtLegalName, "Razon Social", 5))
            {
                return false;
            }
            if(cmbCommecialPlan.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un plan comercial");
                return false;
            }
            if (!Validator.VerificaRuc(txtRUC.Text))
            {
                MessageBox.Show("Debe ingresar un RUC valido");
                return false;
            }
            else
            {
                List<CustomerViewModel> customers = controller.FindActiveCustomersByRUC(txtRUC.Text);
                if (customers.Count > 0)
                {
                    MessageBox.Show("Ya existe un cliente con ese RUC");
                    return false;
                }
            }
            return true;
        }
    }
}

