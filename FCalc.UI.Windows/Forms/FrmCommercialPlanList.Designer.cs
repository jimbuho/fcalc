
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPlanType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdCommercialPlanList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCommercialPlanList
            // 
            this.grdCommercialPlanList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCommercialPlanList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdCommercialPlanList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdCommercialPlanList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdCommercialPlanList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCommercialPlanList.Location = new System.Drawing.Point(22, 76);
            this.grdCommercialPlanList.Name = "grdCommercialPlanList";
            this.grdCommercialPlanList.RowHeadersWidth = 51;
            this.grdCommercialPlanList.RowTemplate.Height = 24;
            this.grdCommercialPlanList.Size = new System.Drawing.Size(711, 363);
            this.grdCommercialPlanList.TabIndex = 0;
            this.grdCommercialPlanList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCommercialPlanList_CellClick);
            this.grdCommercialPlanList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCommercialPlanList_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(614, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nuevo Plan Comercial";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 562);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tipo de Plan";
            // 
            // cmbPlanType
            // 
            this.cmbPlanType.FormattingEnabled = true;
            this.cmbPlanType.Location = new System.Drawing.Point(142, 556);
            this.cmbPlanType.Name = "cmbPlanType";
            this.cmbPlanType.Size = new System.Drawing.Size(144, 24);
            this.cmbPlanType.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 506);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Precio del Plan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre del Plan";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(142, 506);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(144, 22);
            this.txtPrice.TabIndex = 8;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(142, 457);
            this.txtName.MaxLength = 16;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(337, 22);
            this.txtName.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(510, 448);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 41);
            this.button3.TabIndex = 13;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(631, 448);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 41);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmCommercialPlanList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(750, 604);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPlanType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdCommercialPlanList);
            this.Name = "FrmCommercialPlanList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA DE PLANES COMERCIALES";
            this.Load += new System.EventHandler(this.FrmCommercialPlanList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCommercialPlanList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCommercialPlanList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPlanType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDelete;
    }
}