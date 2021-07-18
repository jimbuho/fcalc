
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
            this.grdPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPreview.Location = new System.Drawing.Point(12, 55);
            this.grdPreview.Name = "grdPreview";
            this.grdPreview.RowHeadersWidth = 51;
            this.grdPreview.RowTemplate.Height = 24;
            this.grdPreview.Size = new System.Drawing.Size(415, 523);
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
            this.button2.Location = new System.Drawing.Point(433, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
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
            this.grdResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResults.Location = new System.Drawing.Point(545, 55);
            this.grdResults.Name = "grdResults";
            this.grdResults.RowHeadersWidth = 51;
            this.grdResults.RowTemplate.Height = 24;
            this.grdResults.Size = new System.Drawing.Size(411, 523);
            this.grdResults.TabIndex = 4;
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(971, 596);
            this.Controls.Add(this.grdResults);
            this.Controls.Add(this.lblMessages);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdPreview);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalculator";
            this.Text = "FrmCalculator";
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