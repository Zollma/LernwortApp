using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BAL_Lernwort;
using BO_Lernwort;


namespace PL_Lernwort
{
    //a class to manage all things with the Panel panelDataLernset
    public class ManagerPanelDls
    {
        private List<LernsetClass> ListLernsets { get; set; }

        private BAL_Manager bmngr = new BAL_Manager();

        public ManagerPanelDls()
        {
            try
            {
                ListLernsets = bmngr.GetDALLernsetList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void FillDataGridView(ref DataGridView dgvLernsets)
        {
            dgvLernsets.Columns.Add("SpLernsetID", "LernsetID");
            dgvLernsets.Columns.Add("SpBeschreibung", "Beschreibung");
            dgvLernsets.Columns.Add("SpLernstatus", "Lernstatus");
            dgvLernsets.Columns.Add("SpErstellt", "Erstellt");
            dgvLernsets.Columns.Add("SpGelernt", "Gelernt");

            int columnscount = dgvLernsets.ColumnCount;

            for (int i = 0; i < columnscount; i++)
            {
                dgvLernsets.Columns[i].ReadOnly = true;
            }

            foreach (LernsetClass l in ListLernsets)
            {
                if (l.Gelernt < l.Erstellt)
                {
                    dgvLernsets.Rows.Add(l.LernsetID, l.Beschreibung, l.Lernsetstatus, l.Erstellt.ToShortDateString(), "-");
                }
                else
                {
                    dgvLernsets.Rows.Add(l.LernsetID, l.Beschreibung, l.Lernsetstatus, l.Erstellt.ToShortDateString(), l.Gelernt.ToShortDateString());
                }

            }

            if (dgvLernsets.RowCount > 1)
            {
                dgvLernsets.Rows[0].Selected = true;
            }

        }


        public void FillStatistikGpb(ref Label lblNumLrnst, ref Label lblNumLernwr, ref Label lblLerned)
        {
            try
            {
                string strLrnst = bmngr.GetNumberOfLernsets().ToString();
                string strLernw = bmngr.GetNumberOfLernwords().ToString();
                string strperc = bmngr.GetPercentageLerned().ToString();
                lblNumLrnst.Text = "Lernsets: " + strLrnst;
                lblNumLernwr.Text = "Lernwörter: " + strLernw;
                lblLerned.Text = "Gelernt: " + strperc + " % ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<int> GetSelectedIDs(DataGridView dgvLernsets)
        {
            DataGridViewSelectedRowCollection selectedRows = dgvLernsets.SelectedRows;
            int count = selectedRows.Count;
            List<int> li = new List<int>();

            for (int i = 0; i < count; i++)
            {
                li.Add(Convert.ToInt32(dgvLernsets.SelectedRows[i].Cells[0].Value));
            }

            return li;
        }

        public void DeleteLernset(ref DataGridView dgvLernsets, List<int> lernsetID)
        {
            try
            {
                int countDeleted = bmngr.DeleteLernset(lernsetID);
                if (countDeleted > 0)
                {
                    DataGridViewSelectedRowCollection selectedRows = dgvLernsets.SelectedRows;
                    int countRows = selectedRows.Count;
                    int countCells = dgvLernsets.ColumnCount;
                    for (int i = 0; i < countRows; i++)
                    {
                        for (int j = 0; j < countCells; j++)
                        {
                            dgvLernsets.SelectedRows[i].Cells[j].Value = "";
                        }

                    }
                    string message = Convert.ToString(countDeleted);
                    MessageBox.Show("Datensatz aus der Datenbank gelöscht: " + message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public LernsetClass NewLernset(string bschrbng)
        {

            LernsetClass lernset = new LernsetClass();
            try
            {
                lernset = bmngr.NewLernset(bschrbng);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return lernset;
        }

        public void AddLernsetToDgv(ref DataGridView dgvLernsets, LernsetClass lrnst)
        {
            dgvLernsets.Rows.Add(lrnst.LernsetID, lrnst.Beschreibung, lrnst.Lernsetstatus, lrnst.Erstellt.ToShortDateString(), "-");
        }


    }
}
