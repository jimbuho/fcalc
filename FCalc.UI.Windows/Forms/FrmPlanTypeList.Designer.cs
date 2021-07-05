
namespace FCalc.UI.Windows.Forms
{
    partial class FrmPlanTypeList
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
            this.grdPlanTypes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdPlanTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPlanTypes
            // 
            this.grdPlanTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPlanTypes.Location = new System.Drawing.Point(12, 63);
            this.grdPlanTypes.Name = "grdPlanTypes";
            this.grdPlanTypes.RowHeadersWidth = 51;
            this.grdPlanTypes.RowTemplate.Height = 24;
            this.grdPlanTypes.Size = new System.Drawing.Size(636, 282);
            this.grdPlanTypes.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(537, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nuevo Tipo de Plan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Refrescar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmPlanTypeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 357);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdPlanTypes);
            this.Name = "FrmPlanTypeList";
            this.Text = "FrmPlanTypeList";
            this.Load += new System.EventHandler(this.FrmPlanTypeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPlanTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPlanTypes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}