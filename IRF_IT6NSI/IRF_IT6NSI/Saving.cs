﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_IT6NSI
{
    public partial class Saving : Form
    {
        public Saving(BindingSource FinalBS)
        {
            InitializeComponent();
            dgwFinal.DataSource = FinalBS;
            dgwFinal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

    }
}
