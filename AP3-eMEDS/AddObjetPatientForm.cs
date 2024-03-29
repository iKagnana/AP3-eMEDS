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
    public partial class AddObjetPatientForm : Form
    {
        private readonly AllergieController alController = new AllergieController();
        private readonly AntecedentController anController = new AntecedentController();
        private List<ObjetPatient> objets = new List<ObjetPatient>();
        private typeObjetPatient type;
        public AddObjetPatientForm(typeObjetPatient type)
        {
            InitializeComponent();
            UpdateDataGrid();

            // data grid column width 
            this.dataGridObjetPatient.Columns[1].Width = 300;

        }

        private void UpdateDataGrid()
        {
            switch (type)
            {
                case typeObjetPatient.Antecedent:
                    this.Text = "Gestion des antécédents - GSB";
                    this.labelTitle.Text = "Ajout d'un antécédent";
                    this.objets = anController.GetAntecedents();
                    break;
                case typeObjetPatient.Allergie:
                    this.Text = "Gestion des allergies - GSB";
                    this.labelTitle.Text = "Ajout d'une allergie";
                    this.objets = alController.GetAllergies();
                    break;
            }

            this.dataGridObjetPatient.DataSource = null;
            this.dataGridObjetPatient.DataSource = objets;
        }

        private void ResetForm()
        {
            this.nameTxt.Text = String.Empty;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (this.nameTxt.Text.Length == 0)
            {
                MessageBox.Show("Vous ne pouvez pas avoir de champs vides");
                return;
            }

            ObjetPatient newObjetPatient = new ObjetPatient(this.nameTxt.Text);
            RequestStatus status = new RequestStatus();
            status.success = false;
            switch (type) {
                case typeObjetPatient.Antecedent:
                    status = anController.AddAntecedent(newObjetPatient);
                    break;
                case typeObjetPatient.Allergie:
                    status = alController.AddAllergy(newObjetPatient);
                    break;
            }

            if (status.success)
            {
                MessageBox.Show("Elément ajouté");
                UpdateDataGrid();
                ResetForm();
            } else
            {
                MessageBox.Show("Il y a eu une erreur");
            }
        }

        private void dataGridObjetPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridObjetPatient.Rows[e.RowIndex];
                if (selectedRow != null)
                {
                    ObjetPatient selected = selectedRow.DataBoundItem as ObjetPatient;
                    DetailsObjetPatient details = new DetailsObjetPatient(this.type, selected);
                    // add closing event to the form
                    details.FormClosing += new FormClosingEventHandler(this.DetailsClosing);
                    details.Show();
                }

            }
        }
        private void DetailsClosing(object sender, FormClosingEventArgs e)
        {
            UpdateDataGrid();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchTxt.Text == "")
            {
                this.dataGridObjetPatient.DataSource = objets;
                // exit method
                return;

            }

            List<ObjetPatient> filteredObj = new List<ObjetPatient>();

            foreach (var obj in objets)
            {
                if (obj.Libelle.ToLower().Contains(searchTxt.Text.ToLower()))
                {
                    filteredObj.Add(obj);
                }
            }

            this.dataGridObjetPatient.DataSource = filteredObj;
        }
    }
}
