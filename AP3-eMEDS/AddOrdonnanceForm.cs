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
    public partial class AddOrdonnanceForm : Form
    {
        private readonly OrdonnanceController controller = new OrdonnanceController();
        private readonly MedicamentController medController = new MedicamentController();

        // variable 
        private Patient patient;
        private int selectedMed;
        private List<Ordonnance> ordonnances = new List<Ordonnance>();
        private List<ObjetPatient> medicaments = new List<ObjetPatient>();
        private List<Medicament> allMeds = new List<Medicament>();
        private string selectedTypeDate;

        public AddOrdonnanceForm(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
            this.allMeds = medController.GetMedicaments();
            this.dureeTxt.Visible = false;

            // init patient's infos
            this.patientInfos.Text = $"{patient.Nom} {patient.Prenom} {patient.Sexe} - {patient.NumSecu}";

            // update data grid
            UpdateOrdonnance();

            // init comboBox
            string[] typeDate = {"jour", "semaine", "mois"};
            this.comboBoxDate.DataSource = typeDate;
            UpdateComboBoxMeds();

        }

        private void UpdateOrdonnance()
        {
            this.ordonnances = controller.GetOrdonnances(patient.Id);

            // data grid 
            this.dataGridListO.DataSource = null;
            this.dataGridListO.DataSource = ordonnances;
        }

        // update data grid with ordonnance's medicament
        private void UpdateMedicamentDG()
        {
            this.dataGridMeds.DataSource = null;
            this.dataGridMeds.DataSource = medicaments;
        }

        private void UpdateComboBoxMeds()
        {
            // updateCombobox
            this.comboMeds.DataSource = null;
            this.comboMeds.DataSource = allMeds;
            this.comboMeds.ValueMember = "Id";
            this.comboMeds.DisplayMember = "Libelle";
            this.comboMeds.SelectedIndex = allMeds[0].Id;
            this.comboMeds.SelectedValue = allMeds[0].Libelle;
        }

        private void addMedBtn_Click(object sender, EventArgs e)
        {
            // use the class ObjetPatient and not Medicament
            // only id return by comboBox -> create ObjetPatient for display in dataGrid
            // get the medicament's label
            if (selectedMed != -1)
            {
                ObjetPatient newMed = new ObjetPatient(selectedMed, allMeds[selectedMed].Libelle);
                medicaments.Add(newMed);
                allMeds.RemoveAt(selectedMed);
                UpdateComboBoxMeds();
                UpdateMedicamentDG();
            }
        }

        private void comboMeds_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMed = (int)this.comboMeds.SelectedIndex;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            this.dureeTxt.Visible = this.checkBox.Checked;
            this.nbDate.Visible = !this.checkBox.Checked;
            this.comboBoxDate.Visible = !this.checkBox.Checked;
            
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // pass UUID in field code for ordonnance to make easier adding meds
            string code = Guid.NewGuid().ToString();
            string duree;
            // set duree
            if (this.checkBox.Checked)
            {
                duree = dureeTxt.Text;
            } else
            {
                duree = $"{nbDate.Value} {comboBoxDate.SelectedValue}";
            }

            // create object ordonnance to send to db 
            Ordonnance newOrdo = new Ordonnance(posologieTxt.Text, duree, InstruSpeTxt.Text, code);
            // send to db 
            int result = controller.AddOrdonnance(newOrdo, 1, patient.Id);
            if (result == 1)
            {
                int idOrdonnance = controller.GetIdWithCode(code);
                if (idOrdonnance != 0)
                {
                    foreach (ObjetPatient meds in medicaments)
                    {
                        int addedMeds = controller.AddMedsInOrdonnance(idOrdonnance, meds.Id);
                        Console.WriteLine("réussite ajout médicament : " + addedMeds);
                        if (addedMeds != 1)
                        {
                            MessageBox.Show($"Une erreur s'est produite en ajoutant le médicament : {meds.Libelle}");
                            break;
                        }
                    }
                    MessageBox.Show("Ajout de l'ordonnance réussit.");
                } else
                {
                    MessageBox.Show("Récupération d'aucun id");
                }
            } else
            {
                MessageBox.Show("L'ordonnance n'a pas eu être ajoutée.");
            }
        }

        private void comboBoxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTypeDate = this.comboBoxDate.ValueMember;
        }
    }
}
