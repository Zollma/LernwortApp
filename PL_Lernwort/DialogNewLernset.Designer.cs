namespace PL_Lernwort
{
    partial class DialogNewLernset
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxBeschreibung = new System.Windows.Forms.TextBox();
            this.dgvNeueLernw = new System.Windows.Forms.DataGridView();
            this.btnFertigStellen = new System.Windows.Forms.Button();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNeueLernw)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bitte geben Sie einen Namen/Beschreibung für das Lernset ein:";
            // 
            // txtBoxBeschreibung
            // 
            this.txtBoxBeschreibung.Location = new System.Drawing.Point(447, 13);
            this.txtBoxBeschreibung.Name = "txtBoxBeschreibung";
            this.txtBoxBeschreibung.Size = new System.Drawing.Size(342, 22);
            this.txtBoxBeschreibung.TabIndex = 1;
            this.txtBoxBeschreibung.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBoxBeschreibung_KeyUp);
            // 
            // dgvNeueLernw
            // 
            this.dgvNeueLernw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNeueLernw.Location = new System.Drawing.Point(16, 54);
            this.dgvNeueLernw.Name = "dgvNeueLernw";
            this.dgvNeueLernw.RowTemplate.Height = 24;
            this.dgvNeueLernw.Size = new System.Drawing.Size(310, 187);
            this.dgvNeueLernw.TabIndex = 2;
            this.dgvNeueLernw.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvNeueLernw_CellEndEdit);
            // 
            // btnFertigStellen
            // 
            this.btnFertigStellen.Location = new System.Drawing.Point(548, 213);
            this.btnFertigStellen.Name = "btnFertigStellen";
            this.btnFertigStellen.Size = new System.Drawing.Size(105, 28);
            this.btnFertigStellen.TabIndex = 3;
            this.btnFertigStellen.Text = "Fertig stellen";
            this.btnFertigStellen.UseVisualStyleBackColor = true;
            this.btnFertigStellen.Click += new System.EventHandler(this.BtnFertigStellen_Click);
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Location = new System.Drawing.Point(710, 213);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(102, 28);
            this.btnAbbrechen.TabIndex = 4;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            this.btnAbbrechen.Click += new System.EventHandler(this.BtnAbbrechen_Click);
            // 
            // DialogNewLernset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 253);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.btnFertigStellen);
            this.Controls.Add(this.dgvNeueLernw);
            this.Controls.Add(this.txtBoxBeschreibung);
            this.Controls.Add(this.label1);
            this.Name = "DialogNewLernset";
            this.Text = "Neues Lernset erstellen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNeueLernw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxBeschreibung;
        private System.Windows.Forms.DataGridView dgvNeueLernw;
        private System.Windows.Forms.Button btnFertigStellen;
        private System.Windows.Forms.Button btnAbbrechen;
    }
}