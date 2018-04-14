using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            ListLernwords = bmngr.GetListOfLernwords(lernsetID);

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
           bmngr.EditWord(word, wordID);
        }

        public int NewWord(string word, int lernsetID)
        {
            return bmngr.NewWord(word, lernsetID);
        }

        public void DeleteWord(int wordID)
        {
            bool blDeleted = bmngr.DeleteWord(wordID);
            if(blDeleted)
            {
                MessageBox.Show("Datensatz aus der Datenbank gelöscht");
            }
        }
    }
}
