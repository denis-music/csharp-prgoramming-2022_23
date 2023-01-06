namespace DLWMS.WinForms.Asinhrono
{
    partial class frmPing
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
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.btnPing = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.cmbBrojPonavljanja = new System.Windows.Forms.ComboBox();
            this.cmbPauza = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtIspis
            // 
            this.txtIspis.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIspis.Location = new System.Drawing.Point(12, 74);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtIspis.Size = new System.Drawing.Size(453, 364);
            this.txtIspis.TabIndex = 0;
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(390, 45);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(75, 23);
            this.btnPing.TabIndex = 1;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(12, 45);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(164, 23);
            this.txtUrl.TabIndex = 2;
            // 
            // cmbBrojPonavljanja
            // 
            this.cmbBrojPonavljanja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrojPonavljanja.FormattingEnabled = true;
            this.cmbBrojPonavljanja.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "20"});
            this.cmbBrojPonavljanja.Location = new System.Drawing.Point(182, 45);
            this.cmbBrojPonavljanja.Name = "cmbBrojPonavljanja";
            this.cmbBrojPonavljanja.Size = new System.Drawing.Size(67, 23);
            this.cmbBrojPonavljanja.TabIndex = 3;
            // 
            // cmbPauza
            // 
            this.cmbPauza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPauza.FormattingEnabled = true;
            this.cmbPauza.Items.AddRange(new object[] {
            "100",
            "500",
            "1000",
            "2000"});
            this.cmbPauza.Location = new System.Drawing.Point(255, 45);
            this.cmbPauza.Name = "cmbPauza";
            this.cmbPauza.Size = new System.Drawing.Size(67, 23);
            this.cmbPauza.TabIndex = 4;
            // 
            // frmPing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.cmbPauza);
            this.Controls.Add(this.cmbBrojPonavljanja);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnPing);
            this.Controls.Add(this.txtIspis);
            this.Name = "frmPing";
            this.Text = "frmPing";
            this.Load += new System.EventHandler(this.frmPing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtIspis;
        private Button btnPing;
        private TextBox txtUrl;
        private ComboBox cmbBrojPonavljanja;
        private ComboBox cmbPauza;
    }
}