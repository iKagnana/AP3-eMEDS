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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPatientStep1Form stepOne = new AddPatientStep1Form();
            stepOne.ShowDialog();
        }
    }
}
