﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP3_eMEDS
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void medBtn_Click(object sender, EventArgs e)
        {
            AddMedicamentForm medicamentForm = new AddMedicamentForm();
            medicamentForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPatientForm patientForm = new AddPatientForm();
            patientForm.ShowDialog();
        }
    }
}
