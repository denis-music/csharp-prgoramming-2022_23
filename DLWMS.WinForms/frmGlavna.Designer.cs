namespace DLWMS.WinForms
{
    partial class frmGlavna
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaStudenataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krajRadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.igreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preuzmiNovuVerzijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblPrikaziDatumVrijeme = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.igreToolStripMenuItem,
            this.pomoćToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1226, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentiToolStripMenuItem,
            this.toolStripSeparator1,
            this.odjavaToolStripMenuItem,
            this.krajRadaToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // studentiToolStripMenuItem
            // 
            this.studentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviStudentToolStripMenuItem,
            this.pretragaStudenataToolStripMenuItem});
            this.studentiToolStripMenuItem.Name = "studentiToolStripMenuItem";
            this.studentiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.studentiToolStripMenuItem.Text = "Studenti";
            this.studentiToolStripMenuItem.Click += new System.EventHandler(this.studentiToolStripMenuItem_Click);
            // 
            // noviStudentToolStripMenuItem
            // 
            this.noviStudentToolStripMenuItem.Name = "noviStudentToolStripMenuItem";
            this.noviStudentToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.noviStudentToolStripMenuItem.Text = "Novi student";
            this.noviStudentToolStripMenuItem.Click += new System.EventHandler(this.noviStudentToolStripMenuItem_Click);
            // 
            // pretragaStudenataToolStripMenuItem
            // 
            this.pretragaStudenataToolStripMenuItem.Name = "pretragaStudenataToolStripMenuItem";
            this.pretragaStudenataToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.pretragaStudenataToolStripMenuItem.Text = "Pretraga studenata";
            this.pretragaStudenataToolStripMenuItem.Click += new System.EventHandler(this.pretragaStudenataToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // krajRadaToolStripMenuItem
            // 
            this.krajRadaToolStripMenuItem.Name = "krajRadaToolStripMenuItem";
            this.krajRadaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.krajRadaToolStripMenuItem.Text = "Kraj rada";
            this.krajRadaToolStripMenuItem.Click += new System.EventHandler(this.krajRadaToolStripMenuItem_Click);
            // 
            // igreToolStripMenuItem
            // 
            this.igreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xOToolStripMenuItem,
            this.toolStripMenuItem2});
            this.igreToolStripMenuItem.Name = "igreToolStripMenuItem";
            this.igreToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.igreToolStripMenuItem.Text = "Igre";
            // 
            // xOToolStripMenuItem
            // 
            this.xOToolStripMenuItem.Name = "xOToolStripMenuItem";
            this.xOToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
            this.xOToolStripMenuItem.Text = "XO";
            this.xOToolStripMenuItem.Click += new System.EventHandler(this.xOToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(90, 22);
            this.toolStripMenuItem2.Text = "....";
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramuToolStripMenuItem,
            this.preuzmiNovuVerzijuToolStripMenuItem,
            this.pomoćToolStripMenuItem1});
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomoćToolStripMenuItem.Text = "Pomoć";
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.oProgramuToolStripMenuItem.Text = "O programu";
            // 
            // preuzmiNovuVerzijuToolStripMenuItem
            // 
            this.preuzmiNovuVerzijuToolStripMenuItem.Name = "preuzmiNovuVerzijuToolStripMenuItem";
            this.preuzmiNovuVerzijuToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.preuzmiNovuVerzijuToolStripMenuItem.Text = "Preuzmi novu verziju";
            // 
            // pomoćToolStripMenuItem1
            // 
            this.pomoćToolStripMenuItem1.Name = "pomoćToolStripMenuItem1";
            this.pomoćToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.pomoćToolStripMenuItem1.Text = "Pomoć";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPrikaziDatumVrijeme});
            this.statusStrip1.Location = new System.Drawing.Point(0, 646);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1226, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblPrikaziDatumVrijeme
            // 
            this.lblPrikaziDatumVrijeme.Name = "lblPrikaziDatumVrijeme";
            this.lblPrikaziDatumVrijeme.Size = new System.Drawing.Size(118, 17);
            this.lblPrikaziDatumVrijeme.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 668);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGlavna";
            this.Text = "DLWMS v1.4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGlavna_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem studentiToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem krajRadaToolStripMenuItem;
        private ToolStripMenuItem noviStudentToolStripMenuItem;
        private ToolStripMenuItem pretragaStudenataToolStripMenuItem;
        private ToolStripMenuItem igreToolStripMenuItem;
        private ToolStripMenuItem xOToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem pomoćToolStripMenuItem;
        private ToolStripMenuItem oProgramuToolStripMenuItem;
        private ToolStripMenuItem preuzmiNovuVerzijuToolStripMenuItem;
        private ToolStripMenuItem pomoćToolStripMenuItem1;
        private ToolStripMenuItem odjavaToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblPrikaziDatumVrijeme;
        private System.Windows.Forms.Timer timer1;
    }
}