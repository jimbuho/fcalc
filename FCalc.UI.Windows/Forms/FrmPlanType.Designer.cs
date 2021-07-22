
namespace FCalc.UI.Windows.Forms
{
    partial class FrmPlanType
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.chkRequireRange = new System.Windows.Forms.CheckBox();
            this.chkIsDynamic = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(215, 29);
            this.txtName.MaxLength = 16;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(259, 22);
            this.txtName.TabIndex = 0;
            // 
            // chkRequireRange
            // 
            this.chkRequireRange.AutoSize = true;
            this.chkRequireRange.Location = new System.Drawing.Point(25, 72);
            this.chkRequireRange.Name = "chkRequireRange";
            this.chkRequireRange.Size = new System.Drawing.Size(134, 21);
            this.chkRequireRange.TabIndex = 1;
            this.chkRequireRange.Text = "Requiere Rango";
            this.chkRequireRange.UseVisualStyleBackColor = true;
            // 
            // chkIsDynamic
            // 
            this.chkIsDynamic.AutoSize = true;
            this.chkIsDynamic.Location = new System.Drawing.Point(25, 118);
            this.chkIsDynamic.Name = "chkIsDynamic";
            this.chkIsDynamic.Size = new System.Drawing.Size(108, 21);
            this.chkIsDynamic.TabIndex = 2;
            this.chkIsDynamic.Text = "Es Dinamico";
            this.chkIsDynamic.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de Tipo de Plan";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(363, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPlanType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(481, 151);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkIsDynamic);
            this.Controls.Add(this.chkRequireRange);
            this.Controls.Add(this.txtName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPlanType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NUEVO TIPO DE PLAN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox chkRequireRange;
        private System.Windows.Forms.CheckBox chkIsDynamic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}