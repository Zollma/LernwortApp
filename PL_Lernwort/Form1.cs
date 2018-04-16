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
            CreateNewLernset();
        }

        private void BearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditLernset();
        }

        private void LernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LerningLernsets();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            LerningLernsets();
        }

        private void BtnBearbeiten_Click(object sender, EventArgs e)
        {
            EditLernset();
        }

        private void BtnNeu_Click(object sender, EventArgs e)
        {
            CreateNewLernset();
        }

        private void LoeschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteLernset();
        }

        private void BtnLoeschen_Click(object sender, EventArgs e)
        {
            DeleteLernset();
        }

        private void CreateNewLernset()
        {

        }

        private void EditLernset()
        {
            mPanelDlws.FillDataGridView(ref dgvLernwords, mPanelDls.GetSelectedIDs(dgvLernsets));
            panelDataLernwords.Show();
        }

        private void LerningLernsets()
        {

        }

        private void DeleteLernset()
        {
            mPanelDls.DeleteLernset(mPanelDls.GetSelectedIDs(dgvLernsets));
        }

        private void DeleteLernword(int wordID)
        {
            mPanelDlws.DeleteWord(wordID);
        }
        
        private void DgvLernwords_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string word = "" + dgvLernwords.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            int wordID = Convert.ToInt16(dgvLernwords.Rows[e.RowIndex].Cells[2].Value);
            //Add new Lernword
            if (wordID == 0)
            {
                dgvLernwords.Rows[e.RowIndex].Cells[1].Value = 0;
                int lernsetID = 0;
                lernsetID = Convert.ToInt16(dgvLernwords.Rows[e.RowIndex-1].Cells[3].Value);
                dgvLernwords.Rows[e.RowIndex].Cells[3].Value = lernsetID;
                wordID = mPanelDlws.NewWord(word, lernsetID);
                dgvLernwords.Rows[e.RowIndex].Cells[2].Value = wordID;
            }
            else
            {
                //Delete Lernword and the entrys of the row
                if (word == "")
                {
                    dgvLernwords.Rows[e.RowIndex].Cells[1].Value = "";
                    dgvLernwords.Rows[e.RowIndex].Cells[2].Value = "";
                    dgvLernwords.Rows[e.RowIndex].Cells[3].Value = "";
                    DeleteLernword(wordID);
                }
                else
                {
                    //Change the Lernword
                    mPanelDlws.EditWord(word, wordID);
                }
               
            }           
        }

        

        private void DgvLernwords_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int wortID = Convert.ToInt16(dgvLernwords.SelectedRows[0].Cells[2].Value);

            DialogResult dr = MessageBox.Show("Wollen Sie dieses Lernwort wirklich löschen?","Achtung", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
                DeleteLernword(wortID);
            else
            {
                e.Cancel = true;
            }
        }

        private void BtnFertig_Click(object sender, EventArgs e)
        {
            panelDataLernwords.Hide();
        }
    }
}
