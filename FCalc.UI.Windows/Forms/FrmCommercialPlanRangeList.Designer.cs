﻿
namespace FCalc.UI.Windows.Forms
{
    partial class FrmCommercialPlanRangeList
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
            this.grdCommercialPlanRange = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbCommercialPlan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtEndRange = new System.Windows.Forms.TextBox();
            this.txtStartRange = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCommercialPlanRange)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCommercialPlanRange
            // 
            this.grdCommercialPlanRange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCommercialPlanRange.Location = new System.Drawing.Point(12, 58);
            this.grdCommercialPlanRange.Name = "grdCommercialPlanRange";
            this.grdCommercialPlanRange.RowHeadersWidth = 51;
            this.grdCommercialPlanRange.RowTemplate.Height = 24;
            this.grdCommercialPlanRange.Size = new System.Drawing.Size(630, 253);
            this.grdCommercialPlanRange.TabIndex = 0;
            this.grdCommercialPlanRange.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCommercialPlanRange_CellClick);
            this.grdCommercialPlanRange.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCommercialPlanRange_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(513, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nuevo Rango";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "Refrescar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbCommercialPlan
            // 
            this.cmbCommercialPlan.FormattingEnabled = true;
            this.cmbCommercialPlan.Location = new System.Drawing.Point(117, 454);
            this.cmbCommercialPlan.Name = "cmbCommercialPlan";
            this.cmbCommercialPlan.Size = new System.Drawing.Size(228, 24);
            this.cmbCommercialPlan.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Inicio";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(86, 414);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(123, 22);
            this.txtPrice.TabIndex = 10;
            // 
            // txtEndRange
            // 
            this.txtEndRange.Location = new System.Drawing.Point(86, 371);
            this.txtEndRange.Name = "txtEndRange";
            this.txtEndRange.Size = new System.Drawing.Size(123, 22);
            this.txtEndRange.TabIndex = 9;
            // 
            // txtStartRange
            // 
            this.txtStartRange.Location = new System.Drawing.Point(86, 332);
            this.txtStartRange.Name = "txtStartRange";
            this.txtStartRange.Size = new System.Drawing.Size(123, 22);
            this.txtStartRange.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(517, 351);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 41);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(394, 352);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 41);
            this.button3.TabIndex = 15;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tipo de plan";
            // 
            // FrmCommercialPlanRangeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 498);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmbCommercialPlan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtEndRange);
            this.Controls.Add(this.txtStartRange);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdCommercialPlanRange);
            this.Name = "FrmCommercialPlanRangeList";
            this.Text = "FrmCommercialPlanRangeList";
            this.Load += new System.EventHandler(this.FrmCommercialPlanRangeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCommercialPlanRange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCommercialPlanRange;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbCommercialPlan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtEndRange;
        private System.Windows.Forms.TextBox txtStartRange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
    }
}