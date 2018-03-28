namespace PL_Lernwort
{
    partial class Lernwort
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
            this.dgvLernsets = new System.Windows.Forms.DataGridView();
            this.panelDataLernset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLernsets)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDataLernset
            // 
            this.panelDataLernset.Controls.Add(this.dgvLernsets);
            this.panelDataLernset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataLernset.Location = new System.Drawing.Point(0, 0);
            this.panelDataLernset.Name = "panelDataLernset";
            this.panelDataLernset.Size = new System.Drawing.Size(1099, 677);
            this.panelDataLernset.TabIndex = 0;
            // 
            // dgvLernsets
            // 
            this.dgvLernsets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLernsets.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvLernsets.Location = new System.Drawing.Point(0, 0);
            this.dgvLernsets.Name = "dgvLernsets";
            this.dgvLernsets.RowTemplate.Height = 24;
            this.dgvLernsets.Size = new System.Drawing.Size(1060, 677);
            this.dgvLernsets.TabIndex = 0;
            // 
            // Lernwort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 677);
            this.Controls.Add(this.panelDataLernset);
            this.Name = "Lernwort";
            this.Text = "Form1";
            this.panelDataLernset.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLernsets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDataLernset;
        private System.Windows.Forms.DataGridView dgvLernsets;
    }
}

