﻿using System;
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
    public partial class Lernwort : Form
    {
        private ManagerPanelDls mPanelDls = new ManagerPanelDls();

        public Lernwort()
        {
            InitializeComponent();
            mPanelDls.FillDataGridView(ref dgvLernsets);
           
        }
    }
}