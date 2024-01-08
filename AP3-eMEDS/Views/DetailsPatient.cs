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
        private PatientController controller = new PatientController();
        public DetailsPatient(Patient patient)
        {
            InitializeComponent();
            this.updatedPatient = patient;
            this.lastNameTxt.Text = patient.Prenom;
            this.firstNameTxt.Text = patient.Nom;
            // this.firstNameTxt.Text = patient.Prenom;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            this.updatedPatient.Nom = this.firstNameTxt.Text;
            this.updatedPatient.Prenom = this.lastNameTxt.Text;
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

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            this.updatedPatient.Sexe = "M";
        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            this.updatedPatient.Sexe = "F";
        }
    }
}
