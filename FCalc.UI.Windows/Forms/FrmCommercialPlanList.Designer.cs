﻿
namespace FCalc.UI.Windows.Forms
{
    partial class FrmCommercialPlanList
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
            this.grdCommercialPlanList = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdCommercialPlanList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCommercialPlanList
            // 
            this.grdCommercialPlanList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCommercialPlanList.Location = new System.Drawing.Point(22, 76);
            this.grdCommercialPlanList.Name = "grdCommercialPlanList";
            this.grdCommercialPlanList.RowHeadersWidth = 51;
            this.grdCommercialPlanList.RowTemplate.Height = 24;
            this.grdCommercialPlanList.Size = new System.Drawing.Size(766, 362);
            this.grdCommercialPlanList.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nuevo Plan Comercial";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Refrescar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmCommercialPlanList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdCommercialPlanList);
            this.Name = "FrmCommercialPlanList";
            this.Text = "FrmCommercialPlanList";
            this.Load += new System.EventHandler(this.FrmCommercialPlanList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCommercialPlanList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCommercialPlanList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}