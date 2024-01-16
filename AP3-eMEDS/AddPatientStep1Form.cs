using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Cmp;

namespace AP3_eMEDS
{
    public partial class AddPatientStep1Form : Form
    {
        private PatientController controller = new PatientController();
        private string sexe = "";
        private AddPatientStep2Form patientFormStepTwo;
        // pass in order to reload data when this window is closed
        public AddPatientStep1Form(AddPatientStep2Form patientFormStepTwo)
        {
            InitializeComponent();
            this.patientFormStepTwo = patientFormStepTwo;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!lastNameTxt.Text.Equals("") && !firstNameTxt.Text.Equals("") && 
                !sexe.Equals("") && !numSecuTxt.Text.Equals(""))
            {
                labelError.Visible = false;
                // can't have invalid num secu 
                if (numSecuTxt.Text.Length != 15)
                {
                    return;
                }

                if (controller.GetIdPatientFromNumSecu(numSecuTxt.Text) == 0)
                {
                    labelErrorNumSecu.Visible = false;

                    Patient newPatient = new Patient(lastNameTxt.Text, firstNameTxt.Text, sexe, numSecuTxt.Text);
                    int result = controller.AddPatient(newPatient);
                    if (result == 1)
                    {
                        MessageBox.Show("Patient ajouté");
                    } else if (result == 0)
                    {
                        MessageBox.Show("Il y a eu une erreur.");
                    }
                    // set valid id 
                    patientFormStepTwo.idPatient = controller.GetIdPatientFromNumSecu(numSecuTxt.Text);
                    patientFormStepTwo.ShowDialog();
                    ResetForm();
                    this.Close();
                } else
                {
                    MessageBox.Show("Attention ce numéro est déjà utilisé !");
                }
                
            } else
            {
                labelError.Visible = true;
            }
        }

        private void ResetForm()
        {
            this.lastNameTxt.Text = string.Empty; 
            this.firstNameTxt.Text = string.Empty; 
            this.numSecuTxt.Text = string.Empty;
        }

        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
            this.sexe = "M";
        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            this.sexe = "F";
        }

        private void numSecuTxt_TextChanged(object sender, EventArgs e)
        {
            this.labelErrorNumSecu.Visible = this.numSecuTxt.Text.Length != 15;
        }
    }
}
