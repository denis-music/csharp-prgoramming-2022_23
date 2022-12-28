namespace DLWMS.WinForms.Studenti
{
    partial class frmStudentiPredmeti
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
            this.components = new System.ComponentModel.Container();
            this.dgvPolozeniPredmeti = new System.Windows.Forms.DataGridView();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.lblIndeks = new System.Windows.Forms.Label();
            this.cmbPredmet = new System.Windows.Forms.ComboBox();
            this.cmbOcjene = new System.Windows.Forms.ComboBox();
            this.dtpDatumPolaganja = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnPrintaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozeniPredmeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPolozeniPredmeti
            // 
            this.dgvPolozeniPredmeti.AllowUserToAddRows = false;
            this.dgvPolozeniPredmeti.AllowUserToDeleteRows = false;
            this.dgvPolozeniPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolozeniPredmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predmet,
            this.Datum,
            this.Ocjena,
            this.Obrisi});
            this.dgvPolozeniPredmeti.Location = new System.Drawing.Point(11, 146);
            this.dgvPolozeniPredmeti.Name = "dgvPolozeniPredmeti";
            this.dgvPolozeniPredmeti.ReadOnly = true;
            this.dgvPolozeniPredmeti.RowTemplate.Height = 25;
            this.dgvPolozeniPredmeti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPolozeniPredmeti.Size = new System.Drawing.Size(562, 179);
            this.dgvPolozeniPredmeti.TabIndex = 0;
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            // 
            // Obrisi
            // 
            this.Obrisi.HeaderText = "";
            this.Obrisi.Name = "Obrisi";
            this.Obrisi.ReadOnly = true;
            this.Obrisi.Text = "Obriši";
            this.Obrisi.UseColumnTextForButtonValue = true;
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(12, 12);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(84, 89);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 1;
            this.pbSlika.TabStop = false;
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblImePrezime.Location = new System.Drawing.Point(102, 49);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(0, 54);
            this.lblImePrezime.TabIndex = 2;
            // 
            // lblIndeks
            // 
            this.lblIndeks.AutoSize = true;
            this.lblIndeks.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIndeks.Location = new System.Drawing.Point(102, 12);
            this.lblIndeks.Name = "lblIndeks";
            this.lblIndeks.Size = new System.Drawing.Size(0, 37);
            this.lblIndeks.TabIndex = 3;
            // 
            // cmbPredmet
            // 
            this.cmbPredmet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPredmet.FormattingEnabled = true;
            this.cmbPredmet.Location = new System.Drawing.Point(12, 117);
            this.cmbPredmet.Name = "cmbPredmet";
            this.cmbPredmet.Size = new System.Drawing.Size(162, 23);
            this.cmbPredmet.TabIndex = 4;
            // 
            // cmbOcjene
            // 
            this.cmbOcjene.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOcjene.FormattingEnabled = true;
            this.cmbOcjene.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbOcjene.Location = new System.Drawing.Point(180, 117);
            this.cmbOcjene.Name = "cmbOcjene";
            this.cmbOcjene.Size = new System.Drawing.Size(82, 23);
            this.cmbOcjene.TabIndex = 5;
            // 
            // dtpDatumPolaganja
            // 
            this.dtpDatumPolaganja.Location = new System.Drawing.Point(268, 117);
            this.dtpDatumPolaganja.Name = "dtpDatumPolaganja";
            this.dtpDatumPolaganja.Size = new System.Drawing.Size(224, 23);
            this.dtpDatumPolaganja.TabIndex = 6;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(498, 117);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(468, 331);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(105, 23);
            this.btnPrintaj.TabIndex = 8;
            this.btnPrintaj.Text = "Printaj uvjerenje";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // frmStudentiPredmeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 363);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dtpDatumPolaganja);
            this.Controls.Add(this.cmbOcjene);
            this.Controls.Add(this.cmbPredmet);
            this.Controls.Add(this.lblIndeks);
            this.Controls.Add(this.lblImePrezime);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.dgvPolozeniPredmeti);
            this.Name = "frmStudentiPredmeti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Položeni predmeti";
            this.Load += new System.EventHandler(this.frmStudentiPredmeti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozeniPredmeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvPolozeniPredmeti;
        private PictureBox pbSlika;
        private Label lblImePrezime;
        private Label lblIndeks;
        private ComboBox cmbPredmet;
        private ComboBox cmbOcjene;
        private DateTimePicker dtpDatumPolaganja;
        private Button btnDodaj;
        private ErrorProvider err;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewTextBoxColumn Ocjena;
        private DataGridViewButtonColumn Obrisi;
        private Button btnPrintaj;
    }
}