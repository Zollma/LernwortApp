using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL_Lernwort
{
    public partial class Form1 : Form
    {
        private ManagerPanelDls mPanelDls = new ManagerPanelDls();
        private ManagerPanelDlws mPanelDlws = new ManagerPanelDlws();

        public Form1()
        {
            InitializeComponent();
            
            mPanelDls.FillDataGridView(ref dgvLernsets);
            mPanelDls.FillStatistikGpb(ref lblAnzLrnst, ref lblAnzLernwr, ref lblGelrnt);
            panelDataLernwords.Hide();
           
        }

        private void NeuErstellenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NeuesLernsetErstellen();
        }

        private void BearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LernsetBearbeiten();
        }

        private void LernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LernsetsLernen();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            LernsetsLernen();
        }

        private void BtnBearbeiten_Click(object sender, EventArgs e)
        {
            LernsetBearbeiten();
        }

        private void BtnNeu_Click(object sender, EventArgs e)
        {
            NeuesLernsetErstellen();
        }

        private void LoeschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LernsetLoeschen();
        }

        private void BtnLoeschen_Click(object sender, EventArgs e)
        {
            LernsetLoeschen();
        }

        private void NeuesLernsetErstellen()
        {

        }

        private void LernsetBearbeiten()
        {
            mPanelDlws.FillDataGridView(ref dgvLernwords, mPanelDls.GetSelectedIDs(dgvLernsets));
            panelDataLernwords.Show();
        }

        private void LernsetsLernen()
        {

        }

        private void LernsetLoeschen()
        {

        }
        
        private void DgvLernwords_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string word = "" + dgvLernwords.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            int wordID = Convert.ToInt16(dgvLernwords.Rows[e.RowIndex].Cells[e.ColumnIndex+2].Value);
            if (wordID == 0)
            {
                dgvLernwords.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = 0;
                int lernsetID = 0;
                lernsetID = Convert.ToInt16(dgvLernwords.Rows[e.RowIndex-1].Cells[e.ColumnIndex + 3].Value);
                wordID = mPanelDlws.NewWord(word, lernsetID);
                dgvLernwords.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value = wordID;
            }
            else
            {
                mPanelDlws.EditWord(word, wordID);
            }
            
           
        }
    }
}
