
namespace FCalc.UI.Windows.Forms
{
    partial class FrmCustomerList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.crearNuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgCustomersList = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.txtRucSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Plan = new System.Windows.Forms.Label();
            this.cmbCommecialPlan = new System.Windows.Forms.ComboBox();
            this.txtLegalName = new System.Windows.Forms.TextBox();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomersList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearNuevoClienteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // crearNuevoClienteToolStripMenuItem
            // 
            this.crearNuevoClienteToolStripMenuItem.Name = "crearNuevoClienteToolStripMenuItem";
            this.crearNuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.crearNuevoClienteToolStripMenuItem.Text = "Crear Nuevo Cliente";
            this.crearNuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.crearNuevoClienteToolStripMenuItem_Click);
            // 
            // dgCustomersList
            // 
            this.dgCustomersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomersList.Location = new System.Drawing.Point(12, 92);
            this.dgCustomersList.Name = "dgCustomersList";
            this.dgCustomersList.RowHeadersWidth = 51;
            this.dgCustomersList.RowTemplate.Height = 24;
            this.dgCustomersList.Size = new System.Drawing.Size(776, 346);
            this.dgCustomersList.TabIndex = 1;
            this.dgCustomersList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomersList_CellClick);
            this.dgCustomersList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomersList_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "Refrescar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtRucSearch
            // 
            this.txtRucSearch.Location = new System.Drawing.Point(250, 54);
            this.txtRucSearch.Name = "txtRucSearch";
            this.txtRucSearch.Size = new System.Drawing.Size(147, 22);
            this.txtRucSearch.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar por RUC:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Plan
            // 
            this.Plan.AutoSize = true;
            this.Plan.Location = new System.Drawing.Point(15, 533);
            this.Plan.Name = "Plan";
            this.Plan.Size = new System.Drawing.Size(102, 17);
            this.Plan.TabIndex = 13;
            this.Plan.Text = "Plan Comercial";
            // 
            // cmbCommecialPlan
            // 
            this.cmbCommecialPlan.FormattingEnabled = true;
            this.cmbCommecialPlan.Location = new System.Drawing.Point(136, 527);
            this.cmbCommecialPlan.Name = "cmbCommecialPlan";
            this.cmbCommecialPlan.Size = new System.Drawing.Size(195, 24);
            this.cmbCommecialPlan.TabIndex = 12;
            // 
            // txtLegalName
            // 
            this.txtLegalName.Location = new System.Drawing.Point(136, 487);
            this.txtLegalName.Name = "txtLegalName";
            this.txtLegalName.Size = new System.Drawing.Size(542, 22);
            this.txtLegalName.TabIndex = 11;
            // 
            // txtRUC
            // 
            this.txtRUC.Location = new System.Drawing.Point(136, 453);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(195, 22);
            this.txtRUC.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Razón Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "RUC";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(563, 521);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 41);
            this.button3.TabIndex = 14;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(685, 521);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 41);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(428, 534);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 17);
            this.lblId.TabIndex = 16;
            // 
            // FrmCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 574);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Plan);
            this.Controls.Add(this.cmbCommecialPlan);
            this.Controls.Add(this.txtLegalName);
            this.Controls.Add(this.txtRUC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRucSearch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgCustomersList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmCustomerList";
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmCustomerList_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem crearNuevoClienteToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgCustomersList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtRucSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Plan;
        private System.Windows.Forms.ComboBox cmbCommecialPlan;
        private System.Windows.Forms.TextBox txtLegalName;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblId;
    }
}