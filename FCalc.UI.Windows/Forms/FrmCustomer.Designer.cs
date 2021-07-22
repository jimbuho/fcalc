
namespace UI.windows.Forms
{
    partial class FrmCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.txtLegalName = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.cmbCommecialPlan = new System.Windows.Forms.ComboBox();
            this.Plan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "RUC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Razón Social";
            // 
            // txtRUC
            // 
            this.txtRUC.Location = new System.Drawing.Point(169, 13);
            this.txtRUC.MaxLength = 13;
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(195, 22);
            this.txtRUC.TabIndex = 2;
            // 
            // txtLegalName
            // 
            this.txtLegalName.Location = new System.Drawing.Point(169, 47);
            this.txtLegalName.MaxLength = 64;
            this.txtLegalName.Name = "txtLegalName";
            this.txtLegalName.Size = new System.Drawing.Size(529, 22);
            this.txtLegalName.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.Location = new System.Drawing.Point(584, 114);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 46);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(48, 143);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(184, 17);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Ingrese los datos del cliente";
            // 
            // cmbCommecialPlan
            // 
            this.cmbCommecialPlan.FormattingEnabled = true;
            this.cmbCommecialPlan.Location = new System.Drawing.Point(169, 87);
            this.cmbCommecialPlan.Name = "cmbCommecialPlan";
            this.cmbCommecialPlan.Size = new System.Drawing.Size(195, 24);
            this.cmbCommecialPlan.TabIndex = 6;
            // 
            // Plan
            // 
            this.Plan.AutoSize = true;
            this.Plan.Location = new System.Drawing.Point(48, 93);
            this.Plan.Name = "Plan";
            this.Plan.Size = new System.Drawing.Size(102, 17);
            this.Plan.TabIndex = 7;
            this.Plan.Text = "Plan Comercial";
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(707, 199);
            this.Controls.Add(this.Plan);
            this.Controls.Add(this.cmbCommecialPlan);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtLegalName);
            this.Controls.Add(this.txtRUC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NUEVO CLIENTE";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.TextBox txtLegalName;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ComboBox cmbCommecialPlan;
        private System.Windows.Forms.Label Plan;
    }
}