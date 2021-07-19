
namespace FCalc.UI.Windows.Forms
{
    partial class FrmCommercialPlanRange
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
            this.txtStartRange = new System.Windows.Forms.TextBox();
            this.txtEndRange = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbCommercialPlan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStartRange
            // 
            this.txtStartRange.Location = new System.Drawing.Point(112, 38);
            this.txtStartRange.Name = "txtStartRange";
            this.txtStartRange.Size = new System.Drawing.Size(123, 22);
            this.txtStartRange.TabIndex = 0;
            this.txtStartRange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtField_KeyPress);
            // 
            // txtEndRange
            // 
            this.txtEndRange.Location = new System.Drawing.Point(112, 77);
            this.txtEndRange.Name = "txtEndRange";
            this.txtEndRange.Size = new System.Drawing.Size(123, 22);
            this.txtEndRange.TabIndex = 1;
            this.txtEndRange.TextChanged += new System.EventHandler(this.txtEndRange_TextChanged);
            this.txtEndRange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtField_KeyPress);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(112, 120);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(123, 22);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtField_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbCommercialPlan
            // 
            this.cmbCommercialPlan.FormattingEnabled = true;
            this.cmbCommercialPlan.Location = new System.Drawing.Point(112, 160);
            this.cmbCommercialPlan.Name = "cmbCommercialPlan";
            this.cmbCommercialPlan.Size = new System.Drawing.Size(228, 24);
            this.cmbCommercialPlan.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo Plan";
            // 
            // FrmCommercialPlanRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(474, 241);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCommercialPlan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtEndRange);
            this.Controls.Add(this.txtStartRange);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCommercialPlanRange";
            this.Text = "FrmCommercialPlanRange";
            this.Load += new System.EventHandler(this.FrmCommercialPlanRange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStartRange;
        private System.Windows.Forms.TextBox txtEndRange;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbCommercialPlan;
        private System.Windows.Forms.Label label4;
    }
}