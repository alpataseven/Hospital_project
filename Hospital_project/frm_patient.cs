﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_project
{
    public partial class frm_patient : Form
    {
        public frm_patient()
        {
            InitializeComponent();
        }

        private void frm_patient_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_hasta_kayit fr = new frm_hasta_kayit();
            fr.Show();
        }
    }
}
