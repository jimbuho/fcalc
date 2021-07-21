using System;
using System.Windows.Forms;
using UI.windows.Forms;

namespace FCalc.UI.Windows.Forms
{
    public partial class MDIMain : Form
    {

        private FrmPlanTypeList frmPlanTypeList;
        private FrmCommercialPlanList frmCommercialPlanList;
        private FrmCustomerList frmCustomerList;
        private FrmCommercialPlanRangeList frmCommercialPlanRangeList;
        private FrmPlanType frmPlanType;
        private FrmCommercialPlan frmCommercialPlan;
        private FrmCustomer frmCustomer;
        private FrmCommercialPlanRange frmCommercialPlanRange;
        private FrmExecutionLog frmExecutionLog;
        public MDIMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            FrmCalculator calculator = new FrmCalculator();
            calculator.MdiParent = this;
            calculator.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void verTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {

          
            if (frmPlanTypeList == null )
            {
                frmPlanTypeList = new FrmPlanTypeList();
                frmPlanTypeList.MdiParent = this;
                frmPlanTypeList.Show();
            }
            else
            {
                if (frmPlanTypeList.IsHandleCreated)
                    frmPlanTypeList.Activate();
                else
                frmPlanTypeList = new FrmPlanTypeList();
                frmPlanTypeList.Show();
            }

        }
        private void vERTODOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCommercialPlanList == null)
            {
            frmCommercialPlanList = new FrmCommercialPlanList();
            frmCommercialPlanList.MdiParent = this;
            frmCommercialPlanList.Show();
            }
            else
            {
                if (frmCommercialPlanList.IsHandleCreated)
                    frmCommercialPlanList.Activate();
                else
                    frmCommercialPlanList = new FrmCommercialPlanList();
                frmCommercialPlanList.Show();
            }
        }

        private void verTodosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmCustomerList == null)
            {
            frmCustomerList = new FrmCustomerList();
            frmCustomerList.MdiParent = this;
            frmCustomerList.Show();
            }
            else
            {
                if (frmCustomerList.IsHandleCreated)
                    frmCustomerList.Activate();
                else
                    frmCustomerList = new FrmCustomerList();
                frmCustomerList.Show();
            }
        }

        private void verTodosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (frmCommercialPlanRangeList == null)
            {
                frmCommercialPlanRangeList = new FrmCommercialPlanRangeList();
                frmCommercialPlanRangeList.MdiParent = this;
                frmCommercialPlanRangeList.Show();
            }
            else
            {
                if (frmCommercialPlanRangeList.IsHandleCreated)
                    frmCommercialPlanRangeList.Activate();
                else
                    frmCommercialPlanRangeList = new FrmCommercialPlanRangeList();
                frmCommercialPlanRangeList.Show();
            }
        }

        private void crearNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if (frmPlanType == null)
           {
            frmPlanType = new FrmPlanType();
            frmPlanType.MdiParent = this;
            frmPlanType.Show();
           }
            else
            {
                if (frmPlanType.IsHandleCreated)
                    frmPlanType.Activate();
                else
                    frmPlanType = new FrmPlanType();
                frmPlanType.Show();
            }
        }

        private void crearNuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           if (frmCommercialPlan == null)
           {
            frmCommercialPlan = new FrmCommercialPlan();
            frmCommercialPlan.MdiParent = this;
            frmCommercialPlan.Show();
           }
            else
            {
                if (frmCommercialPlan.IsHandleCreated)
                    frmCommercialPlan.Activate();
                else
                    frmCommercialPlan = new FrmCommercialPlan();
                frmCommercialPlan.Show();
            }
        }
        private void crearNuevoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
             if (frmCommercialPlanRange == null)
             {
               frmCommercialPlanRange = new FrmCommercialPlanRange();
               frmCommercialPlanRange.MdiParent = this;
               frmCommercialPlanRange.Show();
             }
            else
            {
                if (frmCommercialPlanRange.IsHandleCreated)
                    frmCommercialPlanRange.Activate();
                else
                    frmCommercialPlanRange = new FrmCommercialPlanRange();
                frmCommercialPlanRange.Show();
            }
        }

        private void crearNuevoToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            if (frmCustomer == null)
            {
             frmCustomer = new FrmCustomer();
             frmCustomer.MdiParent = this;
             frmCustomer.Show();
            }
            else
            {
                if (frmCustomer.IsHandleCreated)
                    frmCustomer.Activate();
                else
                    frmCustomer = new FrmCustomer();
                frmCustomer.Show();
            }
        }

        private void historyToolMenuItem_Click(object sender, EventArgs e)
        {
          if (frmExecutionLog == null)
          {
            frmExecutionLog = new FrmExecutionLog();
            frmExecutionLog.MdiParent = this;
            frmExecutionLog.Show();
          }
            else
            {
                if (frmExecutionLog.IsHandleCreated)
                    frmExecutionLog.Activate();
                else
                    frmExecutionLog = new FrmExecutionLog();
                frmExecutionLog.Show();
            }
        }

        private void MDIMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
