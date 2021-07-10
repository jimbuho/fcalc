
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.chkIsDynamic = new System.Windows.Forms.CheckBox();
            this.chkRequireRange = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
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
            this.grdPlanTypes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPlanTypes_CellClick);
            this.grdPlanTypes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPlanTypes_CellContentClick);
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
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(412, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 41);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // chkIsDynamic
            // 
            this.chkIsDynamic.AutoSize = true;
            this.chkIsDynamic.Location = new System.Drawing.Point(228, 364);
            this.chkIsDynamic.Name = "chkIsDynamic";
            this.chkIsDynamic.Size = new System.Drawing.Size(108, 21);
            this.chkIsDynamic.TabIndex = 7;
            this.chkIsDynamic.Text = "Es Dinamico";
            this.chkIsDynamic.UseVisualStyleBackColor = true;
            // 
            // chkRequireRange
            // 
            this.chkRequireRange.AutoSize = true;
            this.chkRequireRange.Location = new System.Drawing.Point(342, 362);
            this.chkRequireRange.Name = "chkRequireRange";
            this.chkRequireRange.Size = new System.Drawing.Size(134, 21);
            this.chkRequireRange.TabIndex = 6;
            this.chkRequireRange.Text = "Requiere Rango";
            this.chkRequireRange.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 362);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(205, 22);
            this.txtName.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(541, 351);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 41);
            this.button3.TabIndex = 8;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(483, 362);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 17);
            this.lblId.TabIndex = 9;
            // 
            // FrmPlanTypeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 442);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.chkIsDynamic);
            this.Controls.Add(this.chkRequireRange);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdPlanTypes);
            this.Name = "FrmPlanTypeList";
            this.Text = "FrmPlanTypeList";
            this.Load += new System.EventHandler(this.FrmPlanTypeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPlanTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPlanTypes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox chkIsDynamic;
        private System.Windows.Forms.CheckBox chkRequireRange;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblId;
    }
}