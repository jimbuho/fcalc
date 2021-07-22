using FCalc.UI.Windows.ApplicationController;
using FCalc.UI.Windows.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.windows.Forms;

namespace FCalc.UI.Windows.Forms
{
    public partial class FrmCommercialPlanList : Form
    {
        private CommercialPlanController controller;
        PlanTypeController planTypeController;
        FrmCommercialPlan frmCommercialPlan;
        CommercialPlanViewModel selectedItem;
        public FrmCommercialPlanList()
        {
            InitializeComponent();
            controller = new CommercialPlanController();
            planTypeController = new PlanTypeController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCommercialPlan = new FrmCommercialPlan();
            frmCommercialPlan.TopLevel = true;
            frmCommercialPlan.Show();
        }

        private void FrmCommercialPlanList_Load(object sender, EventArgs e)
        {
            doMainQuery();
            
            List<PlanTypeViewModel> planTypes = planTypeController.FindActivePlanType();
            foreach (PlanTypeViewModel planType in planTypes)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = $"{planType.name}";
                item.Value = planType.idPlantype;
                cmbPlanType.Items.Add(item);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doMainQuery();
        }

        public void doMainQuery()
        {
            grdCommercialPlanList.DataSource = controller.FindActiveCommercialPlan();
            grdCommercialPlanList.Columns[0].HeaderText = "ID";
            grdCommercialPlanList.Columns[1].HeaderText = "NOMBRE";
            grdCommercialPlanList.Columns[2].HeaderText = "TIPO PLAN";
            grdCommercialPlanList.Columns[3].HeaderText = "PRECIO";
            grdCommercialPlanList.Columns[4].HeaderText = "FECHA CREACIÓN";
            grdCommercialPlanList.Columns[5].HeaderText = "ID TIPO PLAN";
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
                    selectedItem.name = txtName.Text;
                    selectedItem.price = Convert.ToDecimal(txtPrice.Text);
                    // Se toma el objeto seleccionado y luego se obtien el id (value)
                    ComboboxItem commercialPlanItem = (ComboboxItem)cmbPlanType.SelectedItem;
                    selectedItem.idPlantype = commercialPlanItem.Value;

                    if (controller.CommercialPlanModify(selectedItem))
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
          
            Int32 selectedRowCount = grdCommercialPlanList.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                DialogResult dialogResult = MessageBox.Show("Confirma eliminar los registro seleccionados?",
                    "Eliminar Registros", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        Int32 id = Convert.ToInt32(grdCommercialPlanList.Rows[grdCommercialPlanList.SelectedRows[i].Index].Cells[0].Value);
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

        private void grdCommercialPlanList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            detectClickOnGrid();
        }

        private void grdCommercialPlanList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            detectClickOnGrid();
        }
        private void detectClickOnGrid()
        {

            DataGridViewRow row = grdCommercialPlanList.Rows[grdCommercialPlanList.CurrentCell.RowIndex];

            selectedItem = new CommercialPlanViewModel();
            selectedItem.idCommercialplan = Convert.ToInt32(row.Cells[0].Value);
            selectedItem.name = Convert.ToString(row.Cells[1].Value);
            selectedItem.idPlantype = Convert.ToInt32(row.Cells[5].Value);
            selectedItem.price = Convert.ToDecimal(row.Cells[3].Value);

            /*
             * Mostramos al usuario los datos del registro seleccionado, notar que
             * debemos transformar los valores al tipo de datos que acepta cada componente
             */
            txtName.Text = Convert.ToString(selectedItem.name);
            txtPrice.Text = Convert.ToString(selectedItem.price);
            int i = 0;
            foreach (var itemPlan in cmbPlanType.Items)
            {
                ComboboxItem cbItem = (ComboboxItem)itemPlan;
                if (cbItem.Value == selectedItem.idPlantype)
                {
                    cmbPlanType.SelectedIndex = i;
                }
                i++;
            }
        }

        private bool ValidarFormulario()
        {
            if (!Validator.ValidarCamposTexto(txtName, "Nombre del Plan", 3))
            {
                return false;
            }
            else
            {
                List<CommercialPlanViewModel> plans = controller.FindActiveCommercialPlanByName(txtName.Text, selectedItem.idCommercialplan);
                if (plans.Count > 0)
                {
                    MessageBox.Show("Ya existen planes comerciales con ese nombre");
                    return false;
                }
            }
            if (!Validator.ValidarCamposTexto(txtPrice, "Precio del Plan", 1))
            {
                return false;
            }

            if (cmbPlanType.SelectedItem == null)
            {
                MessageBox.Show("Debe elegir un tipo de plan");
                return false;
            }

            return true;
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.ValidateNumbers(sender, e);
        }
    }
}
