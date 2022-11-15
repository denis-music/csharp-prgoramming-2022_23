namespace DLWMS.WinForms.Intro
{
    partial class frmDelegati
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
            this.btnNotifikacije = new System.Windows.Forms.Button();
            this.txtPoruka = new System.Windows.Forms.TextBox();
            this.cbPrvaGodina = new System.Windows.Forms.CheckBox();
            this.cbDrugaGodina = new System.Windows.Forms.CheckBox();
            this.cbTrecaGodina = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnNotifikacije
            // 
            this.btnNotifikacije.Location = new System.Drawing.Point(361, 189);
            this.btnNotifikacije.Name = "btnNotifikacije";
            this.btnNotifikacije.Size = new System.Drawing.Size(75, 23);
            this.btnNotifikacije.TabIndex = 0;
            this.btnNotifikacije.Text = "Posalji";
            this.btnNotifikacije.UseVisualStyleBackColor = true;
            this.btnNotifikacije.Click += new System.EventHandler(this.btnNotifikacije_Click);
            // 
            // txtPoruka
            // 
            this.txtPoruka.Location = new System.Drawing.Point(24, 12);
            this.txtPoruka.Multiline = true;
            this.txtPoruka.Name = "txtPoruka";
            this.txtPoruka.Size = new System.Drawing.Size(412, 171);
            this.txtPoruka.TabIndex = 1;
            // 
            // cbPrvaGodina
            // 
            this.cbPrvaGodina.AutoSize = true;
            this.cbPrvaGodina.Location = new System.Drawing.Point(24, 189);
            this.cbPrvaGodina.Name = "cbPrvaGodina";
            this.cbPrvaGodina.Size = new System.Drawing.Size(89, 19);
            this.cbPrvaGodina.TabIndex = 2;
            this.cbPrvaGodina.Text = "Prva godina";
            this.cbPrvaGodina.UseVisualStyleBackColor = true;
            this.cbPrvaGodina.CheckedChanged += new System.EventHandler(this.cbPrvaGodina_CheckedChanged);
            // 
            // cbDrugaGodina
            // 
            this.cbDrugaGodina.AutoSize = true;
            this.cbDrugaGodina.Location = new System.Drawing.Point(119, 189);
            this.cbDrugaGodina.Name = "cbDrugaGodina";
            this.cbDrugaGodina.Size = new System.Drawing.Size(98, 19);
            this.cbDrugaGodina.TabIndex = 3;
            this.cbDrugaGodina.Text = "Druga godina";
            this.cbDrugaGodina.UseVisualStyleBackColor = true;
            this.cbDrugaGodina.CheckedChanged += new System.EventHandler(this.cbDrugaGodina_CheckedChanged);
            // 
            // cbTrecaGodina
            // 
            this.cbTrecaGodina.AutoSize = true;
            this.cbTrecaGodina.Location = new System.Drawing.Point(223, 189);
            this.cbTrecaGodina.Name = "cbTrecaGodina";
            this.cbTrecaGodina.Size = new System.Drawing.Size(93, 19);
            this.cbTrecaGodina.TabIndex = 4;
            this.cbTrecaGodina.Text = "Treca godina";
            this.cbTrecaGodina.UseVisualStyleBackColor = true;
            this.cbTrecaGodina.CheckedChanged += new System.EventHandler(this.cbTrecaGodina_CheckedChanged);
            // 
            // frmDelegati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 226);
            this.Controls.Add(this.cbTrecaGodina);
            this.Controls.Add(this.cbDrugaGodina);
            this.Controls.Add(this.cbPrvaGodina);
            this.Controls.Add(this.txtPoruka);
            this.Controls.Add(this.btnNotifikacije);
            this.Name = "frmDelegati";
            this.Text = "frmDelegati";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnNotifikacije;
        private TextBox txtPoruka;
        private CheckBox cbPrvaGodina;
        private CheckBox cbDrugaGodina;
        private CheckBox cbTrecaGodina;
    }
}