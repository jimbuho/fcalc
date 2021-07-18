
namespace FCalc.UI.Windows.Forms
{
    partial class FrmMenu
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
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planesComercialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDePlanesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rangosDePlanComercialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.planesComercialesToolStripMenuItem,
            this.tiposDePlanesToolStripMenuItem,
            this.rangosDePlanComercialToolStripMenuItem,
            this.historicoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // planesComercialesToolStripMenuItem
            // 
            this.planesComercialesToolStripMenuItem.Name = "planesComercialesToolStripMenuItem";
            this.planesComercialesToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.planesComercialesToolStripMenuItem.Text = "Planes Comerciales";
            this.planesComercialesToolStripMenuItem.Click += new System.EventHandler(this.planesComercialesToolStripMenuItem_Click);
            // 
            // tiposDePlanesToolStripMenuItem
            // 
            this.tiposDePlanesToolStripMenuItem.Name = "tiposDePlanesToolStripMenuItem";
            this.tiposDePlanesToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.tiposDePlanesToolStripMenuItem.Text = "Tipos de Planes";
            this.tiposDePlanesToolStripMenuItem.Click += new System.EventHandler(this.tiposDePlanesToolStripMenuItem_Click);
            // 
            // rangosDePlanComercialToolStripMenuItem
            // 
            this.rangosDePlanComercialToolStripMenuItem.Name = "rangosDePlanComercialToolStripMenuItem";
            this.rangosDePlanComercialToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.rangosDePlanComercialToolStripMenuItem.Text = "Rangos de Plan Comercial";
            this.rangosDePlanComercialToolStripMenuItem.Click += new System.EventHandler(this.rangosDePlanComercialToolStripMenuItem_Click);
            // 
            // historicoToolStripMenuItem
            // 
            this.historicoToolStripMenuItem.Name = "historicoToolStripMenuItem";
            this.historicoToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.historicoToolStripMenuItem.Text = "Historico";
            this.historicoToolStripMenuItem.Click += new System.EventHandler(this.historicoToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 669);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.Text = "MENU PRINCIPAL";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planesComercialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDePlanesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rangosDePlanComercialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicoToolStripMenuItem;
    }
}