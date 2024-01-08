using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Cmp;

namespace AP3_eMEDS
{
    public partial class AddPatientForm : Form
    {
        private PatientController controller = new PatientController();
        private List<Patient> patients = new List<Patient>();
        private string sexe = "";
        public AddPatientForm()
        {
            InitializeComponent();
            UpdateGridView();

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!lastNameTxt.Text.Equals("") && !firstNameTxt.Text.Equals("") && !sexe.Equals(""))
            {
                Patient newPatient = new Patient(lastNameTxt.Text, firstNameTxt.Text, sexe);
                controller.AddPatient(newPatient);
                UpdateGridView();
            }
        }

        private void UpdateGridView()
        {
            this.patients = controller.GetPatients();
            // reset research to avoid conflict
            this.searchTxt.Text = "";
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = patients;
        }

        // when cellClick
        private void OpenPatientDetails(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                if (selectedRow != null)
                {
                    Patient selected = selectedRow.DataBoundItem as Patient;
                    DetailsPatient details = new DetailsPatient(selected);
                    // add closing event to the form
                    details.FormClosing += new FormClosingEventHandler(this.CloseDetails);
                    details.Show();
                }

            }
        }

        // when leave patient details 
        private void CloseDetails(object sender, FormClosingEventArgs e)
        {
            UpdateGridView();
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
