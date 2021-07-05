
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
            // FrmCommercialPlanRangeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 320);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdCommercialPlanRange);
            this.Name = "FrmCommercialPlanRangeList";
            this.Text = "FrmCommercialPlanRangeList";
            this.Load += new System.EventHandler(this.FrmCommercialPlanRangeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCommercialPlanRange)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCommercialPlanRange;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}