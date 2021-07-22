using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FCalc.UI.Windows.ApplicationController;
using FCalc.UI.Windows.ViewModel;

namespace FCalc.UI.Windows.Forms
{
    public partial class FrmPlanTypeList : Form
    {
        PlanTypeController controller;
        PlanTypeViewModel selectedItem;
        public FrmPlanTypeList()
        {
            InitializeComponent();
            controller = new PlanTypeController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MDIMain parent = this.MdiParent as MDIMain;
            if (parent != null)
            {
                // Recuerde crear este metodo en el formulario MDI Como publico
                parent.OpenFormPlanType();
            }
            else
            {
                MessageBox.Show("Parent Not exists");
            }
        }

        private void FrmPlanTypeList_Load(object sender, EventArgs e)
        {
            doMainQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doMainQuery();
        }

        public void doMainQuery()
        {
            grdPlanTypes.DataSource = controller.FindActivePlanType();
            grdPlanTypes.Columns[0].HeaderText = "ID";
            grdPlanTypes.Columns[1].HeaderText = "NOMBRE";
            grdPlanTypes.Columns[2].HeaderText = "RANGO";
            grdPlanTypes.Columns[3].HeaderText = "DINAMICO";
            grdPlanTypes.Columns[4].HeaderText = "FECHA CREACIÓN";
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
            Int32 selectedRowCount = grdPlanTypes.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                DialogResult dialogResult = MessageBox.Show("Confirma eliminar los registro seleccionados?",
                    "Eliminar Registros", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        Int32 id = Convert.ToInt32(grdPlanTypes.Rows[grdPlanTypes.SelectedRows[i].Index].Cells[0].Value);
                        controller.PlanTypeDelete(id);
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

        private void button3_Click(object sender, EventArgs e)
        {
            /*
             * Si hay un registro seleccionado entonces lo mandamos a actualizar, al terminar
             * conexito el guardado recargamos el GridControl.
             */
            if (selectedItem != null && selectedItem.name != null)
            {
                if (ValidarFormulario())
                {
                    // Aqui copiamos todo los valores cambiados del formulario hacia el objeto antes de 
                    // enviarlo a cambiar en la base de datos
                    selectedItem.name = txtName.Text;
                    selectedItem.isDynamic = chkIsDynamic.Checked;
                    selectedItem.requireRange = chkRequireRange.Checked;

                    if (controller.PlanTypeModify(selectedItem))
                    {
                        MessageBox.Show("Registro Modificado con exito");
                        doMainQuery();
                        // Importante vaciar el registro actual para obligar al usuario a seleccionarlo
                        selectedItem = null;
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error en la modificacion");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar el registro a modificar");
            }
        }

        private void grdPlanTypes_CellClick(Object sender, DataGridViewCellEventArgs e)
        {
            // Ante este evento detectamos click sobre la celda
            detectClickOnGrid();
        }

        private void grdPlanTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ante este evento detectamos click sobre el contenido de la celda
            detectClickOnGrid();
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
            DataGridViewRow row = grdPlanTypes.Rows[grdPlanTypes.CurrentCell.RowIndex];

            selectedItem = new PlanTypeViewModel();
            selectedItem.idPlantype = Convert.ToInt32(row.Cells[0].Value);
            selectedItem.name = Convert.ToString(row.Cells[1].Value);
            selectedItem.requireRange = Convert.ToBoolean(row.Cells[2].Value);
            selectedItem.isDynamic = Convert.ToBoolean(row.Cells[3].Value);

            /*
             * Mostramos al usuario los datos del registro seleccionado, notar que
             * debemos transformar los valores al tipo de datos que acepta cada componente
             */
            txtName.Text = selectedItem.name;
            chkIsDynamic.Checked = selectedItem.isDynamic.Value;
            chkRequireRange.Checked = selectedItem.requireRange.Value;
            lblId.Text = Convert.ToString(selectedItem.idPlantype);
        }

        private bool ValidarFormulario()
        {
            if (!Validator.ValidarCamposTexto(txtName, "Nombre del Tipo de Plan", 3))
            {
                return false;
            }
            else
            {
                List<PlanTypeViewModel> plans = controller.FindActivePlanTypeByName(txtName.Text, selectedItem.idPlantype);
                if (plans.Count > 0)
                {
                    MessageBox.Show("Ya existen tipos de plan con ese nombre");
                    return false;
                }
            }

            return true;
        }
    }
}
