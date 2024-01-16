using System;
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
    public partial class PatientList : Form
    {
        private PatientController controller = new PatientController();
        private List<Patient> patients = new List<Patient>();
        public PatientList()
        {
            InitializeComponent();
            GetPatients();
        }

        private void GetPatients()
        {
            // get updated data 
            var patients = controller.GetPatients();

            // reset research to avoid conflict
            this.patients = patients;

            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = patients;
            DataGridViewButtonColumn ordonnanceButton = new DataGridViewButtonColumn();
            ordonnanceButton.Name = "Accès ordonnance";
            ordonnanceButton.Text = "Accès ordonnance";
            if (dataGridView1.Columns["Accès ordonnance"] == null)
            {
                dataGridView1.Columns.Insert(0, ordonnanceButton);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPatientStep2Form stepTwo = new AddPatientStep2Form(0);
            stepTwo.FormClosing += new FormClosingEventHandler(this.DetailsClosing);
            AddPatientStep1Form stepOne = new AddPatientStep1Form(stepTwo);
            stepOne.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                if (selectedRow != null)
                {
                    Patient selected = selectedRow.DataBoundItem as Patient;
                    if (e.ColumnIndex == dataGridView1.Columns["Accès ordonnance"].Index)
                    {
                        AddOrdonnanceForm ordonnanceForm = new AddOrdonnanceForm(selected);
                        ordonnanceForm.ShowDialog();

                        
                    }
                    else
                    {
                        DetailsPatient details = new DetailsPatient(selected);
                        // add closing event to the form
                        details.FormClosing += new FormClosingEventHandler(this.DetailsClosing);
                        details.ShowDialog();
                    }
                }
                
            } 
        }

        private void DetailsClosing(object sender, FormClosingEventArgs e)
        {
            GetPatients();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchTxt.Text == "")
            {
                this.dataGridView1.DataSource = patients;
                return;

            }

            List<Patient> filteredPatient = new List<Patient>();

            foreach (var patient in patients)
            {
                if (patient.Nom.ToLower().Contains(searchTxt.Text.ToLower()) || patient.Prenom.ToLower().Contains(searchTxt.Text.ToLower()))
                {
                    filteredPatient.Add(patient);
                }
            }

            this.dataGridView1.DataSource = filteredPatient;
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            GetPatients();
        }
    }
}
