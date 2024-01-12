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
    public partial class Menu : Form
    {
        private readonly string role = Global.UserRole;
        public Menu()
        {
            InitializeComponent();

            // hide elements when not admin 
            if (role != "ADMIN")
            {
                this.groupMedecin.Visible = false;
                this.groupPatientObject.Visible = false;
            }
            
        }

        private void medBtn_Click(object sender, EventArgs e)
        {
            AddMedicamentForm medicamentForm = new AddMedicamentForm();
            medicamentForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PatientList patientForm = new PatientList();
            patientForm.ShowDialog();
        }
    }
}
