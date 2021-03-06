
namespace FCalc.UI.Windows.Forms
{
    partial class FrmCalculator
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
            this.grdPreview = new System.Windows.Forms.DataGridView();
            this.ofdFileFinder = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblMessages = new System.Windows.Forms.Label();
            this.grdResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdResults)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPreview
            // 
            this.grdPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdPreview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPreview.Location = new System.Drawing.Point(12, 55);
            this.grdPreview.Name = "grdPreview";
            this.grdPreview.RowHeadersWidth = 51;
            this.grdPreview.RowTemplate.Height = 24;
            this.grdPreview.Size = new System.Drawing.Size(444, 636);
            this.grdPreview.TabIndex = 0;
            // 
            // ofdFileFinder
            // 
            this.ofdFileFinder.FileName = "ofdOpenXLSX";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(170, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cargar Archivo del Mes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(516, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 77);
            this.button2.TabIndex = 2;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblMessages
            // 
            this.lblMessages.AutoSize = true;
            this.lblMessages.Location = new System.Drawing.Point(188, 22);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(390, 17);
            this.lblMessages.TabIndex = 3;
            this.lblMessages.Text = "Pulse \"Cargar Archivo del Mes\" para iniciar el procesamiento";
            // 
            // grdResults
            // 
            this.grdResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResults.Location = new System.Drawing.Point(717, 55);
            this.grdResults.Name = "grdResults";
            this.grdResults.RowHeadersWidth = 51;
            this.grdResults.RowTemplate.Height = 24;
            this.grdResults.Size = new System.Drawing.Size(465, 636);
            this.grdResults.TabIndex = 4;
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1197, 696);
            this.Controls.Add(this.grdResults);
            this.Controls.Add(this.lblMessages);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdPreview);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULADORA DE FACTURACION MENSUAL";
            this.Load += new System.EventHandler(this.FrmCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPreview;
        private System.Windows.Forms.OpenFileDialog ofdFileFinder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.DataGridView grdResults;
    }
}