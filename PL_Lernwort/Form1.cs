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

        public Form1()
        {
            InitializeComponent();
            
            mPanelDls.FillDataGridView(ref dgvLernsets);
            mPanelDls.FillStatistikGpb(ref lblAnzLrnst, ref lblAnzLernwr, ref lblGelrnt);
            
           
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

        private void NeuesLernsetErstellen()
        {

        }

        private void LernsetBearbeiten()
        {

        }

        private void LernsetsLernen()
        {

        }
    }
}
