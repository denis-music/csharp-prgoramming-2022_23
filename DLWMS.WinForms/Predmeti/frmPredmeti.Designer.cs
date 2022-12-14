namespace DLWMS.WinForms.Predmeti
{
    partial class frmPredmeti
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
            this.dgvPredmeti = new System.Windows.Forms.DataGridView();
            this.txtNazivPredmeta = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmeti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPredmeti
            // 
            this.dgvPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPredmeti.Location = new System.Drawing.Point(12, 59);
            this.dgvPredmeti.Name = "dgvPredmeti";
            this.dgvPredmeti.RowTemplate.Height = 25;
            this.dgvPredmeti.Size = new System.Drawing.Size(297, 150);
            this.dgvPredmeti.TabIndex = 0;
            // 
            // txtNazivPredmeta
            // 
            this.txtNazivPredmeta.Location = new System.Drawing.Point(12, 30);
            this.txtNazivPredmeta.Name = "txtNazivPredmeta";
            this.txtNazivPredmeta.Size = new System.Drawing.Size(220, 23);
            this.txtNazivPredmeta.TabIndex = 1;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(234, 30);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // frmPredmeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 215);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtNazivPredmeta);
            this.Controls.Add(this.dgvPredmeti);
            this.Name = "frmPredmeti";
            this.Text = "frmPredmeti";
            this.Load += new System.EventHandler(this.frmPredmeti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmeti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvPredmeti;
        private TextBox txtNazivPredmeta;
        private Button btnDodaj;
    }
}