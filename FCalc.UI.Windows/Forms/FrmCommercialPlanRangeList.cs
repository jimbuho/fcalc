using FCalc.Domain.Model.Entities;
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
    public partial class FrmCommercialPlanRangeList : Form
    {
        private CommercialPlanRangeController controller;
        private FrmCommercialPlanRange frmCommercialPlanRange;
        CommercialPlanRangeViewModel selectedItem;
        CommercialPlanController commercialPlanController;

        public FrmCommercialPlanRangeList()
        {
            InitializeComponent();
            controller = new CommercialPlanRangeController();
            commercialPlanController = new CommercialPlanController();
        }

        private void FrmCommercialPlanRangeList_Load(object sender, EventArgs e)
        {
            doQuery();
            LoadPlanType(cmbCommercialPlan);
            LoadPlanType(cmbFiltroTipoPlan);
            UpdateGrid();
        }

        public void LoadPlanType(ComboBox combo)
        {
            List<CommercialPlanViewModel> commercialPlans = commercialPlanController.FindActiveCommercialPlan();
            foreach (CommercialPlanViewModel commercialPlan in commercialPlans)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = $"{commercialPlan.name}";
                item.Value = commercialPlan.idCommercialplan;
                combo.Items.Add(item);
            }
        }

        private void doQuery()
        {
            grdCommercialPlanRange.DataSource = controller.FindActiveCommercialPlanRange();
            cmbFiltroTipoPlan.SelectedItem = null;
        }

        private void UpdateGrid()
        {
            grdCommercialPlanRange.Columns[0].HeaderText = "ID";
            grdCommercialPlanRange.Columns[1].HeaderText = "INICIO RANGO";
            grdCommercialPlanRange.Columns[2].HeaderText = "FIN RANGO";
            grdCommercialPlanRange.Columns[3].HeaderText = "PRECIO";
            grdCommercialPlanRange.Columns[4].HeaderText = "PLAN";
            grdCommercialPlanRange.Columns[5].HeaderText = "FECHA CREACÓN";
            grdCommercialPlanRange.Columns[6].HeaderText = "ID PLAN";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbFiltroTipoPlan.SelectedItem != null)
            {
                updateBySelectedPlan();
            }
            else
            {
                doQuery();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCommercialPlanRange = new FrmCommercialPlanRange();
            frmCommercialPlanRange.TopLevel = true;
            frmCommercialPlanRange.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            Int32 selectedRowCount = grdCommercialPlanRange.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                DialogResult dialogResult = MessageBox.Show("Confirma eliminar los registro seleccionados?",
                    "Eliminar Registros", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        Int32 id = Convert.ToInt32(grdCommercialPlanRange.Rows[grdCommercialPlanRange.SelectedRows[i].Index].Cells[0].Value);
                        controller.CustomerDelete(id);
                        sb.Append("Item #" + id + " ");
                    }

                    MessageBox.Show(sb.ToString(), "Fueron eliminados");
                    doQuery();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar registros antes de continuar");
            }
        }

        private void grdCommercialPlanRange_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            detectClickOnGrid();
        }
        private void grdCommercialPlanRange_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            detectClickOnGrid();
        }
        private void detectClickOnGrid()
        {
            
            DataGridViewRow row = grdCommercialPlanRange.Rows[grdCommercialPlanRange.CurrentCell.RowIndex];

            selectedItem = new CommercialPlanRangeViewModel();
            selectedItem.idPlanrange = Convert.ToInt32(row.Cells[0].Value);
            selectedItem.startRange = Convert.ToInt32(row.Cells[1].Value);
            selectedItem.endRange = Convert.ToInt32(row.Cells[2].Value);
            selectedItem.price = Convert.ToDecimal(row.Cells[3].Value);
            selectedItem.idCommercialplan= Convert.ToInt32(row.Cells[6].Value);
            /*
             * Mostramos al usuario los datos del registro seleccionado, notar que
             * debemos transformar los valores al tipo de datos que acepta cada componente
             */
            txtStartRange.Text =Convert.ToString( selectedItem.startRange);
            txtEndRange.Text = Convert.ToString(selectedItem.endRange);
            txtPrice.Text= Convert.ToString(selectedItem.price);

            int i = 0;
            foreach (var itemPlan in cmbCommercialPlan.Items)
            {
                ComboboxItem cbItem = (ComboboxItem)itemPlan;
                if (cbItem.Value == selectedItem.idCommercialplan)
                {
                    cmbCommercialPlan.SelectedIndex = i;
                }
                i++;
            }



        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedItem != null && selectedItem.startRange != null)
            {
                if (ValidarFormulario())
                {
                    selectedItem.startRange = Convert.ToInt32(txtStartRange.Text);
                    selectedItem.endRange = Convert.ToInt32(txtEndRange.Text);
                    selectedItem.price = Convert.ToDecimal(txtPrice.Text);
                    // Se toma el objeto seleccionado y luego se obtien el id (value)
                    ComboboxItem commercialPlanItem = (ComboboxItem)cmbCommercialPlan.SelectedItem;
                    selectedItem.idCommercialplan = commercialPlanItem.Value;

                    // Obtener los rangos de planes comerciales que sean iguales al elegido por el usuario
                    List<CommercialPlanRangeViewModel> listaRangos = controller.GetCommercialPlanRangeByCommecialPlan(Convert.ToInt32(selectedItem.idCommercialplan));

                    /*
                    * Si hay un registro seleccionado entonces lo mandamos a actualizar, al terminar
                    * conexito el guardado recargamos el GridControl.
                    */

                    if (controller.CommercialPlanRangeModify(selectedItem))
                    {
                        MessageBox.Show("Registro Modificado con exito");
                        doQuery();
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

        private void cmbFiltroTipoPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroTipoPlan.SelectedItem != null)
            {
                updateBySelectedPlan();
            }
        }

        private void updateBySelectedPlan()
        {
            ComboboxItem commercialPlanItem = (ComboboxItem)cmbFiltroTipoPlan.SelectedItem;
            CommercialPlan plan = commercialPlanController.GetById(commercialPlanItem.Value);
            List<CommercialPlanRangeViewModel> planRange = controller.GetCommercialPlanRangeByCommecialPlan(plan);

            grdCommercialPlanRange.DataSource = planRange;
        }

        private bool ValidarFormulario()
        {
            if (!Validator.ValidarCamposTexto(txtStartRange, "Inicio de Rango", 1))
            {
                return false;
            }
            if (!Validator.ValidarCamposTexto(txtEndRange, "Fin de Rango", 1))
            {
                return false;
            }
            if (!Validator.ValidarCamposTexto(txtPrice, "Precio", 1))
            {
                return false;
            }
            if (cmbCommercialPlan.SelectedItem == null)
            {
                MessageBox.Show("Debe elegir el Plan Comercial relacionado a este rango");
                return false;
            }

            return true;
        }


        private void txtField_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.ValidateNumbers(sender, e);
        }
    }
}
