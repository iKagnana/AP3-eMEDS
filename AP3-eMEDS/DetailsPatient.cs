using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI.Common;

namespace AP3_eMEDS
{
    public partial class DetailsPatient : Form
    {
        private Patient updatedPatient;
        private readonly PatientController controller = new PatientController();
        private readonly AntecedentController antecedentController = new AntecedentController();
        private readonly AllergieController allergieController = new AllergieController();

        // patient's
        private List<ObjetPatient> antecedent = new List<ObjetPatient>();
        private List<ObjetPatient> allergies = new List<ObjetPatient>();

        // patient's
        private List<ObjetPatient> allAntecedent = new List<ObjetPatient>();
        private List<ObjetPatient> allAllergies = new List<ObjetPatient>();
        public DetailsPatient(Patient patient)
        {
            InitializeComponent();
            this.updatedPatient = patient;
            this.lastNameTxt.Text = patient.Prenom;
            this.firstNameTxt.Text = patient.Nom;
            this.numSecuTxt.Text = patient.NumSecu;
            this.radioMale.Checked = patient.Sexe == "M";
            this.radioFemale.Checked = patient.Sexe == "F";

            this.labelError.Visible = false;
            this.labelErrorNumSecu.Visible = false;

            // init comboBox
            this.comboAn.DataSource = antecedentController.GetAntecedents();
            this.comboAn.ValueMember = "Id";
            this.comboAn.DisplayMember = "Libelle";
            this.comboAl.DataSource = allergieController.GetAllergies();
            this.comboAl.ValueMember = "Id";
            this.comboAl.DisplayMember = "Libelle";


            UpdateAllergieDataGrid();
            UpdateAntecedentDataGrid();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (!this.firstNameTxt.Text.Equals("") && !this.lastNameTxt.Text.Equals("") && !this.numSecuTxt.Text.Equals("") && this.numSecuTxt.Text.Length == 15) { 
                this.labelError.Visible = false;
                this.updatedPatient.Nom = this.firstNameTxt.Text;
                this.updatedPatient.Prenom = this.lastNameTxt.Text;
                this.updatedPatient.NumSecu = this.numSecuTxt.Text;
                int result = controller.UpdatePatient(updatedPatient);
                if (result == 0)
                {
                    MessageBox.Show("Il y a eu une erreur");
                }
                else if (result == 1)
                {
                    MessageBox.Show("Patient modifié");
                    this.Close();
                }
            } else
            {
                this.labelError.Visible = true;
            }
        } 

        private void supprBtn_Click(object sender, EventArgs e)
        {
            int result = controller.DeletePatient(updatedPatient.Id);
            if (result == 0)
            {
                MessageBox.Show("Il y a eu une erreur");
            }
            else if (result == 1)
            {
                MessageBox.Show("Patient supprimé");
                this.Close();
            }
        }

        private void UpdateAntecedentDataGrid()
        {
            this.antecedent = controller.GetPatientAntecedents(updatedPatient.Id);

            this.dataGridAn.DataSource = null;
            this.dataGridAn.DataSource = this.antecedent;
        }

        private void UpdateAllergieDataGrid()
        {
            this.allergies = controller.GetPatientAllergies(updatedPatient.Id);

            this.dataGridAl.DataSource = null;
            this.dataGridAl.DataSource = this.allergies;
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            this.updatedPatient.Sexe = "M";
        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            this.updatedPatient.Sexe = "F";
        }

        private void supprBtn_Click_1(object sender, EventArgs e)
        {
            int result = controller.DeletePatient(updatedPatient.Id);
            if (result == 1)
            {
                MessageBox.Show("Suppression du patient réussi");
            } else
            {
                MessageBox.Show("Erreur lors de la suppresion du patient");
            }
        }

        private void numSecuTxt_TextChanged(object sender, EventArgs e)
        {
            this.labelErrorNumSecu.Visible = this.numSecuTxt.Text.Length == 15;
        }

        private void dataGridAl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridAl.Rows[e.RowIndex];
                if (selectedRow != null)
                {
                    ObjetPatient selected = selectedRow.DataBoundItem as ObjetPatient;
                    DeleteItemPatient details = new DeleteItemPatient(selected, updatedPatient.Id, typeItem.Allergy) ;
                    // add closing event to the form
                    details.FormClosing += new FormClosingEventHandler(this.DetailsClosing);
                    details.Show();
                }

            }
        }

        private void dataGridAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridAn.Rows[e.RowIndex];
                if (selectedRow != null)
                {
                    ObjetPatient selected = selectedRow.DataBoundItem as ObjetPatient;
                    DeleteItemPatient details = new DeleteItemPatient(selected, updatedPatient.Id, typeItem.Antecedent);
                    // add closing event to the form
                    details.FormClosing += new FormClosingEventHandler(this.DetailsClosing);
                    details.Show();
                }

            }
        }

        private void DetailsClosing(object sender, FormClosingEventArgs e)
        {
            UpdateAllergieDataGrid();
            UpdateAntecedentDataGrid();
        }

        private void comboAl_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = (int)comboAl.SelectedValue;
                // return -1 if doesnt find
                if (index != allergies.FindIndex(al => al.Id == index)) 
                {
                    controller.AddAllergyToPatient(index, updatedPatient.Id);
                    UpdateAllergieDataGrid();
                }
                
            }
            catch
            {
                Console.WriteLine("Cannot convert to string");
            }
        }

        private void comboAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = (int)comboAn.SelectedValue;
                if (index != antecedent.FindIndex(al => al.Id == index))
                {
                    controller.AddAntecedentToPatient(index, updatedPatient.Id);
                    UpdateAntecedentDataGrid();
                }
            } catch
            {
                Console.WriteLine("Cannot convert to string");
            }
        }
    }
}
