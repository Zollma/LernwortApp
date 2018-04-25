using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BAL_Lernwort;
using BO_Lernwort;

namespace PL_Lernwort
{
    public partial class DialogNewLernset : Form
    {
        private ManagerPanelDls mngrPnl;
        private DataGridView dgvListLernsets;
        private BAL_Manager bmngr = new BAL_Manager();
        private LernsetClass lernsetClass = new LernsetClass();
       
        private int lernsetID = -1;

        public DialogNewLernset(ref ManagerPanelDls mngr, ref DataGridView dgvLst)
        {
            InitializeComponent();
            dgvNeueLernw.Columns.Add("SpLernwort", "Lernwort");
            dgvNeueLernw.Columns.Add("SpWordID", "WortID");
            dgvNeueLernw.Enabled = false;
            mngrPnl = mngr;
            dgvListLernsets = dgvLst;
        }
         
       
        private void TxtBoxBeschreibung_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBoxBeschreibung.Text != "")
                {
                    dgvNeueLernw.Enabled = true;
                    lernsetClass = mngrPnl.NewLernset(txtBoxBeschreibung.Text);
                    dgvNeueLernw.Focus();
                }
            }
        }

        private void DgvNeueLernw_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string word = "" + dgvNeueLernw.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            
            //New Word
            if (word != "")
            {
                int wrt = bmngr.NewWord(word, lernsetClass.LernsetID);
                dgvNeueLernw.Rows[e.RowIndex].Cells[1].Value = wrt;
            }
            else
            {
                //Delete Word
            }
        }

        private void BtnFertigStellen_Click(object sender, EventArgs e)
        {
            this.Close();
            mngrPnl.AddLernsetToDgv(ref dgvListLernsets, lernsetClass);
        }

        private void BtnAbbrechen_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            list.Add(lernsetClass.LernsetID);
            mngrPnl.DeleteLernset(ref dgvListLernsets, list);
            this.Close();
            //Delete lernset
        }
    }
}
