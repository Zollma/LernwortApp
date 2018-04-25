namespace PL_Lernwort
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelDataLernset = new System.Windows.Forms.Panel();
            this.panelDataLernwords = new System.Windows.Forms.Panel();
            this.btnFertigStellen = new System.Windows.Forms.Button();
            this.dgvLernwords = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblGelrnt = new System.Windows.Forms.Label();
            this.lblAnzLernwr = new System.Windows.Forms.Label();
            this.lblAnzLrnst = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoeschen = new System.Windows.Forms.Button();
            this.btnNeu = new System.Windows.Forms.Button();
            this.btnBearbeiten = new System.Windows.Forms.Button();
            this.btnLernen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHinweis = new System.Windows.Forms.Label();
            this.dgvLernsets = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lernsetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuErstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDataLernset.SuspendLayout();
            this.panelDataLernwords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLernwords)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLernsets)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDataLernset
            // 
            this.panelDataLernset.Controls.Add(this.panelDataLernwords);
            this.panelDataLernset.Controls.Add(this.groupBox2);
            this.panelDataLernset.Controls.Add(this.groupBox1);
            this.panelDataLernset.Controls.Add(this.label1);
            this.panelDataLernset.Controls.Add(this.lblHinweis);
            this.panelDataLernset.Controls.Add(this.dgvLernsets);
            this.panelDataLernset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataLernset.Location = new System.Drawing.Point(0, 28);
            this.panelDataLernset.Name = "panelDataLernset";
            this.panelDataLernset.Size = new System.Drawing.Size(1182, 649);
            this.panelDataLernset.TabIndex = 0;
            // 
            // panelDataLernwords
            // 
            this.panelDataLernwords.Controls.Add(this.btnFertigStellen);
            this.panelDataLernwords.Controls.Add(this.dgvLernwords);
            this.panelDataLernwords.Location = new System.Drawing.Point(22, 147);
            this.panelDataLernwords.Name = "panelDataLernwords";
            this.panelDataLernwords.Size = new System.Drawing.Size(742, 490);
            this.panelDataLernwords.TabIndex = 6;
            // 
            // btnFertigStellen
            // 
            this.btnFertigStellen.Location = new System.Drawing.Point(600, 62);
            this.btnFertigStellen.Name = "btnFertigStellen";
            this.btnFertigStellen.Size = new System.Drawing.Size(117, 28);
            this.btnFertigStellen.TabIndex = 1;
            this.btnFertigStellen.Text = "Fertig stellen";
            this.btnFertigStellen.UseVisualStyleBackColor = true;
            this.btnFertigStellen.Click += new System.EventHandler(this.BtnFertig_Click);
            // 
            // dgvLernwords
            // 
            this.dgvLernwords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLernwords.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvLernwords.Location = new System.Drawing.Point(0, 0);
            this.dgvLernwords.Name = "dgvLernwords";
            this.dgvLernwords.RowTemplate.Height = 24;
            this.dgvLernwords.Size = new System.Drawing.Size(574, 490);
            this.dgvLernwords.TabIndex = 0;
            this.dgvLernwords.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLernwords_CellEndEdit);
            this.dgvLernwords.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DgvLernwords_UserDeletingRow);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblGelrnt);
            this.groupBox2.Controls.Add(this.lblAnzLernwr);
            this.groupBox2.Controls.Add(this.lblAnzLrnst);
            this.groupBox2.Location = new System.Drawing.Point(977, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 175);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statistik";
            // 
            // lblGelrnt
            // 
            this.lblGelrnt.AutoSize = true;
            this.lblGelrnt.Location = new System.Drawing.Point(7, 100);
            this.lblGelrnt.Name = "lblGelrnt";
            this.lblGelrnt.Size = new System.Drawing.Size(87, 17);
            this.lblGelrnt.TabIndex = 2;
            this.lblGelrnt.Text = "Gelernt: 0 %";
            // 
            // lblAnzLernwr
            // 
            this.lblAnzLernwr.AutoSize = true;
            this.lblAnzLernwr.Location = new System.Drawing.Point(7, 67);
            this.lblAnzLernwr.Name = "lblAnzLernwr";
            this.lblAnzLernwr.Size = new System.Drawing.Size(80, 17);
            this.lblAnzLernwr.TabIndex = 1;
            this.lblAnzLernwr.Text = "Lernwörter:";
            // 
            // lblAnzLrnst
            // 
            this.lblAnzLrnst.AutoSize = true;
            this.lblAnzLrnst.Location = new System.Drawing.Point(7, 34);
            this.lblAnzLrnst.Name = "lblAnzLrnst";
            this.lblAnzLrnst.Size = new System.Drawing.Size(71, 17);
            this.lblAnzLrnst.TabIndex = 0;
            this.lblAnzLrnst.Text = "Lernsets: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoeschen);
            this.groupBox1.Controls.Add(this.btnNeu);
            this.groupBox1.Controls.Add(this.btnBearbeiten);
            this.groupBox1.Controls.Add(this.btnLernen);
            this.groupBox1.Location = new System.Drawing.Point(977, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 216);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lernset";
            // 
            // btnLoeschen
            // 
            this.btnLoeschen.Location = new System.Drawing.Point(6, 165);
            this.btnLoeschen.Name = "btnLoeschen";
            this.btnLoeschen.Size = new System.Drawing.Size(120, 28);
            this.btnLoeschen.TabIndex = 5;
            this.btnLoeschen.Text = "löschen";
            this.btnLoeschen.UseVisualStyleBackColor = true;
            this.btnLoeschen.Click += new System.EventHandler(this.BtnLoeschen_Click);
            // 
            // btnNeu
            // 
            this.btnNeu.Location = new System.Drawing.Point(6, 124);
            this.btnNeu.Name = "btnNeu";
            this.btnNeu.Size = new System.Drawing.Size(120, 28);
            this.btnNeu.TabIndex = 4;
            this.btnNeu.Text = "neu";
            this.btnNeu.UseVisualStyleBackColor = true;
            this.btnNeu.Click += new System.EventHandler(this.BtnNeu_Click);
            // 
            // btnBearbeiten
            // 
            this.btnBearbeiten.Location = new System.Drawing.Point(6, 83);
            this.btnBearbeiten.Name = "btnBearbeiten";
            this.btnBearbeiten.Size = new System.Drawing.Size(120, 28);
            this.btnBearbeiten.TabIndex = 3;
            this.btnBearbeiten.Text = "bearbeiten";
            this.btnBearbeiten.UseVisualStyleBackColor = true;
            this.btnBearbeiten.Click += new System.EventHandler(this.BtnBearbeiten_Click);
            // 
            // btnLernen
            // 
            this.btnLernen.Location = new System.Drawing.Point(6, 40);
            this.btnLernen.Name = "btnLernen";
            this.btnLernen.Size = new System.Drawing.Size(120, 30);
            this.btnLernen.TabIndex = 2;
            this.btnLernen.Text = "lernen";
            this.btnLernen.UseVisualStyleBackColor = true;
            this.btnLernen.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(977, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 3;
            // 
            // lblHinweis
            // 
            this.lblHinweis.AutoSize = true;
            this.lblHinweis.Location = new System.Drawing.Point(974, 14);
            this.lblHinweis.Name = "lblHinweis";
            this.lblHinweis.Size = new System.Drawing.Size(167, 17);
            this.lblHinweis.TabIndex = 1;
            this.lblHinweis.Text = "Bitte Lernset auswählen. ";
            // 
            // dgvLernsets
            // 
            this.dgvLernsets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLernsets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLernsets.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvLernsets.Location = new System.Drawing.Point(0, 0);
            this.dgvLernsets.Name = "dgvLernsets";
            this.dgvLernsets.RowTemplate.Height = 24;
            this.dgvLernsets.Size = new System.Drawing.Size(935, 649);
            this.dgvLernsets.TabIndex = 0;
            this.dgvLernsets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLernsets_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lernsetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lernsetToolStripMenuItem
            // 
            this.lernsetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuErstellenToolStripMenuItem,
            this.lernenToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.löschenToolStripMenuItem});
            this.lernsetToolStripMenuItem.Name = "lernsetToolStripMenuItem";
            this.lernsetToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.lernsetToolStripMenuItem.Text = "Lernset";
            // 
            // neuErstellenToolStripMenuItem
            // 
            this.neuErstellenToolStripMenuItem.Name = "neuErstellenToolStripMenuItem";
            this.neuErstellenToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.neuErstellenToolStripMenuItem.Text = "neu erstellen";
            this.neuErstellenToolStripMenuItem.Click += new System.EventHandler(this.NeuErstellenToolStripMenuItem_Click);
            // 
            // lernenToolStripMenuItem
            // 
            this.lernenToolStripMenuItem.Name = "lernenToolStripMenuItem";
            this.lernenToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.lernenToolStripMenuItem.Text = "lernen";
            this.lernenToolStripMenuItem.Click += new System.EventHandler(this.LernenToolStripMenuItem_Click);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.bearbeitenToolStripMenuItem.Text = "bearbeiten";
            this.bearbeitenToolStripMenuItem.Click += new System.EventHandler(this.BearbeitenToolStripMenuItem_Click);
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.löschenToolStripMenuItem.Text = "löschen";
            this.löschenToolStripMenuItem.Click += new System.EventHandler(this.LoeschenToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 677);
            this.Controls.Add(this.panelDataLernset);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Lernwort";
            this.panelDataLernset.ResumeLayout(false);
            this.panelDataLernset.PerformLayout();
            this.panelDataLernwords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLernwords)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLernsets)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDataLernset;
        private System.Windows.Forms.DataGridView dgvLernsets;
        private System.Windows.Forms.Button btnLernen;
        private System.Windows.Forms.Label lblHinweis;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lernsetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuErstellenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lernenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBearbeiten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNeu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblGelrnt;
        private System.Windows.Forms.Label lblAnzLernwr;
        private System.Windows.Forms.Label lblAnzLrnst;
        private System.Windows.Forms.Panel panelDataLernwords;
        private System.Windows.Forms.DataGridView dgvLernwords;
        private System.Windows.Forms.Button btnLoeschen;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        private System.Windows.Forms.Button btnFertigStellen;
    }
}

