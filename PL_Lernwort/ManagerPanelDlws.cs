using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BAL_Lernwort;
using BO_Lernwort;

namespace PL_Lernwort
{
    //a class to manage all things with the Panel panelDataLernwords
    class ManagerPanelDlws
    {
        private List<LernwortClass> ListLernwords { get; set; }
        private BAL_Manager bmngr = new BAL_Manager();

        public ManagerPanelDlws()
        {

        }

        public void FillDataGridView(ref DataGridView dgvLernwords, List<int> lernsetID)
        {
            dgvLernwords.Columns.Add("SpLernwort", "Lernwort");
            dgvLernwords.Columns.Add("SpLerndurchlauf", "Lerndurchlauf");
            dgvLernwords.Columns.Add("SpWordID", "WortID");
            dgvLernwords.Columns.Add("SpLernsetID", "LernsetID");

            try
            { 
                ListLernwords = bmngr.GetListOfLernwords(lernsetID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach (LernwortClass l in ListLernwords)
            {
                dgvLernwords.Rows.Add(l.Lernwort, l.Lerndurchlauf, l.WortID, l.LernsetID);
            }

            dgvLernwords.Columns[1].ReadOnly = true;
            dgvLernwords.Columns[2].Visible = true;
            dgvLernwords.Columns[3].Visible = true;
        }

        public void EditWord(string word, int wordID )
        {
            try
            {
                bmngr.EditWord(word, wordID);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int NewWord(string word, int lernsetID)
        {
            int value = 0;
            try
            {
                value = bmngr.NewWord(word, lernsetID);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return value;
        }

        public void DeleteWord(int wordID)
        {
            try
            {
                bool blDeleted = bmngr.DeleteWord(wordID);
                if (blDeleted)
                {
                    MessageBox.Show("Datensatz aus der Datenbank gelöscht");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
