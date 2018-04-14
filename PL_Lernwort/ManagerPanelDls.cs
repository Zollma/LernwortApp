﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL_Lernwort;
using BO_Lernwort;


namespace PL_Lernwort
{
    //a class to manage all things with the Panel panelDataLernset
    class ManagerPanelDls
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

            DateTime date = new DateTime();

            foreach (LernsetClass l in ListLernsets)
            {
                if(l.Gelernt == date)
                {
                    dgvLernsets.Rows.Add(l.LernsetID, l.Beschreibung, l.Lernsetstatus, l.Erstellt.ToShortDateString(), "-");
                }
                else
                {
                    dgvLernsets.Rows.Add(l.LernsetID, l.Beschreibung, l.Lernsetstatus, l.Erstellt.ToShortDateString(), l.Gelernt.ToShortDateString());
                }
                
            }

            if (dgvLernsets.RowCount>1)
            {
                dgvLernsets.Rows[0].Selected = true;
            }
            
        }

        public void FillStatistikGpb(ref Label lblNumLrnst, ref Label lblNumLernwr, ref Label lblLerned)
        {
            string strLrnst = bmngr.GetNumberOfLernsets().ToString();
            string strLernw = bmngr.GetNumberOfLernwords().ToString();
            string strperc = bmngr.GetPercentageLerned().ToString();
            lblNumLrnst.Text = "Lernsets: "+ strLrnst;
            lblNumLernwr.Text = "Lernwörter: "+ strLernw;
            lblLerned.Text = "Gelernt: " + strperc+" % ";
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
    }
}
