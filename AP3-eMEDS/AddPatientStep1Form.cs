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
        private List<Patient> patients = new List<Patient>();
        private string sexe = "";
        public AddPatientStep1Form()
        {
            InitializeComponent();

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!lastNameTxt.Text.Equals("") && !firstNameTxt.Text.Equals("") && 
                !sexe.Equals("") && !numSecuTxt.Text.Equals(""))
            {
                labelError.Visible = false;
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

                    AddPatientStep2Form step2 = new AddPatientStep2Form(controller.GetIdPatientFromNumSecu(numSecuTxt.Text));
                    step2.ShowDialog();
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
            this.labelErrorNumSecu.Visible = this.numSecuTxt.Text.Length == 15;
        }
    }
}
