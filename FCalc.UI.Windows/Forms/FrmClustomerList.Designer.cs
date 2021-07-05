
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
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
            // FrmCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}