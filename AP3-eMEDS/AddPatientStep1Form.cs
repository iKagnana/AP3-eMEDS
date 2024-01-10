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
                Regex numSecuPattern = new Regex(@"^\\d{15}$");
                if (!numSecuPattern.IsMatch(numSecuTxt.Text))
                {
                    labelErrorNumSecu.Visible = true;
                } else if (controller.GetIdPatientFromNumSecu(numSecuTxt.Text) == 0)
                {
                    Patient newPatient = new Patient(lastNameTxt.Text, firstNameTxt.Text, sexe, numSecuTxt.Text);
                    controller.AddPatient(newPatient);
                } else
                {
                    MessageBox.Show("Attention ce numéro est déjà utilisé !");
                }
                
            } else
            {
                labelError.Visible = true;
            }
        }

        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
            this.sexe = "M";
        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            this.sexe = "F";
        }
    }
}
