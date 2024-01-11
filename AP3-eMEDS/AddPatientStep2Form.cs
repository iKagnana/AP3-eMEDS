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
    public partial class AddPatientStep2Form : Form
    {
        // controllers
        private AllergieController alController = new AllergieController();
        private AntecedentController anController = new AntecedentController();
        private PatientController patientController = new PatientController();
        // variables 
        //// combobox
        private List<ObjetPatient> allergies = new List<ObjetPatient>();
        private List<ObjetPatient> antecedent = new List<ObjetPatient>();
        private int selectedAl;
        private int selectedAn;
        //// data grid
        private List<ObjetPatient> patientAl = new List<ObjetPatient>();
        private List<ObjetPatient> patientAn = new List<ObjetPatient>();
        //// passed values 
        private int idPatient;

        public AddPatientStep2Form(int idPatient)
        {
            InitializeComponent();
            UpdateGridAllergie();
            UpdateGridAntecedent();
            this.idPatient = idPatient;

            // update comboBoxes
            this.comboAl.DataSource = null;
            this.comboAl.DataSource = alController.GetAllergies();
            this.comboAl.ValueMember = "Id";
            this.comboAl.DisplayMember = "Libelle";

            this.comboAn.DataSource = null;
            this.comboAn.DataSource = anController.GetAntecedents();
            this.comboAn.ValueMember = "Id";
            this.comboAn.DisplayMember = "Libelle";
        }

        // update data in data grid -> allergies
        private void UpdateGridAllergie()
        {
            this.patientAl = patientController.GetPatientAllergies(idPatient);
            // reset data -> avoid duplicate
            this.dataGridAl.DataSource = null;
            this.dataGridAl.DataSource = patientAl;
        }

        // update data in data grid -> antecedent
        private void UpdateGridAntecedent()
        {
            this.patientAn = patientController.GetPatientAntecedents(idPatient);

            this.dataGridAn.DataSource = null;
            this.dataGridAn.DataSource = patientAn;
        }

        // set value after user selected the value
        private void comboAl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // try catch block because we can have cast exception
            try
            {
                Console.WriteLine(comboAl.SelectedValue);
                selectedAl = (int)comboAl.SelectedValue;
            } catch (Exception err)
            {
                Console.WriteLine(err);
                
            }
            
        }

        private void comboAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine(comboAn.SelectedValue);
                selectedAn = (int)comboAn.SelectedValue;
            } catch (Exception err)
            {
                Console.WriteLine(err);
                
            }
        }

        private void addAlBtn_Click(object sender, EventArgs e)
        {
            // check if doesnt already added 
            if (-1 == patientAl.FindIndex(al => al.Id == selectedAl) && selectedAl != 0)
            {
                patientController.AddAllergyToPatient(selectedAl, idPatient);
                UpdateGridAllergie();
            }
        }

        private void addAnBtn_Click(object sender, EventArgs e)
        {
            // check if doesnt already added 
            if (-1 == patientAn.FindIndex(an => an.Id == selectedAn) && selectedAn != 0)
            {
                Console.WriteLine(selectedAn);
                patientController.AddAntecedentToPatient(selectedAn, idPatient);
                UpdateGridAntecedent();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
