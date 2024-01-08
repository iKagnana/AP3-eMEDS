﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;

namespace AP3_eMEDS
{
    public partial class AddMedicamentForm : Form
    {
        private MedicamentController dataAccess = new MedicamentController();
        private List<Medicament> drugs = new List<Medicament>();
        public AddMedicamentForm()
        {
            InitializeComponent();
            UpdateGridView();

            // init column size
            this.dataGridView1.Columns[0].HeaderText = "Id";
            this.dataGridView1.Columns[1].HeaderText = "Libellé";
            this.dataGridView1.Columns[2].HeaderText = "Contre-indications";

            this.dataGridView1.Columns[2].Width = 250;
        }
        
        // event when click on the button
        private void addBtn_Click(object sender, EventArgs e)
        {
            // create a new object drug
            Medicament drug = new Medicament(
                this.nameTxt.Text,
                this.contreIndcTxt.Text
                );
            // get the saved row in db
            int result = dataAccess.addDrugToDB(drug);
            if (result == 0)
            {
                MessageBox.Show("Il y a eu une erreur");
            }
            else if (result == 1)
            {
                MessageBox.Show("Médicament ajouté");
            }
            UpdateGridView();
            ResetTextBoxes();
        }

        // get the last updated list of drugs
        public void UpdateGridView()
        {
            // get updated data 
            var drugs = dataAccess.GetDrugs();

            // reset research to avoid conflict
            this.drugs = drugs;
            this.searchTxt.Text = "";
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = drugs;
        }

        // reset textboxes
        private void ResetTextBoxes()
        {
            this.nameTxt.Text = "";
            this.contreIndcTxt.Text = "";
        }


        // open the new form Details
        private void OpenForm(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                if (selectedRow != null)
                {
                    Medicament selected = selectedRow.DataBoundItem as Medicament;
                    Details details = new Details(selected);
                    // add closing event to the form
                    details.FormClosing += new FormClosingEventHandler(this.DetailsClosing);
                    details.Show();
                }
                
            }

        }

        // handle when the Details form is closing, update the actual list
        private void DetailsClosing(object sender, FormClosingEventArgs e)
        {
            UpdateGridView();
        }

        // check if only numeric value or not
        private void priceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        // update list with filters
        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            // if searchTxt is empty => get the filled data
            if (searchTxt.Text == "") {
                this.dataGridView1.DataSource = drugs;
                // exit method
                return;

            }

             List<Medicament> filteredDrugs = new List<Medicament>();

            foreach (var drug in drugs)
            {
                if (drug.Libelle.ToLower().Contains(searchTxt.Text.ToLower()))
                {
                    filteredDrugs.Add(drug);
                }
            }

            this.dataGridView1.DataSource = filteredDrugs;
        }
    }
}