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
        private readonly PatientController patientController = new PatientController();

        // variable 
        private Patient patient;
        private int selectedMed;
        private List<Ordonnance> ordonnances = new List<Ordonnance>();
        private List<ObjetPatient> medicaments = new List<ObjetPatient>();
        private List<Medicament> allMeds = new List<Medicament>();
        private List<ObjetPatient>  patientAntecedents = new List<ObjetPatient>();
        private List<ObjetPatient>  patientAllergies = new List<ObjetPatient>();
        private string selectedTypeDate;
        // to handle warning text and popup display
        private List<Incompatibility> incompatibilities = new List<Incompatibility>();


        public AddOrdonnanceForm(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
            this.allMeds = medController.GetMedicaments();
            this.patientAllergies = patientController.GetPatientAllergies(patient.Id);
            this.patientAntecedents = patientController.GetPatientAntecedents(patient.Id);
            this.dureeTxt.Visible = false;

            // init patient's infos
            this.patientInfos.Text = $"{patient.Nom} {patient.Prenom} {patient.Sexe} - {patient.NumSecu}";

            // update data grid
            UpdateOrdonnance();

            // init comboBox
            string[] typeDate = {"jour", "semaine", "mois"};
            this.comboBoxDate.DataSource = typeDate;
            UpdateComboBoxMeds();

            // init warning text
            this.warningMedsTxt.Visible = false;
            this.warningText.Visible = false;

        }

        private void UpdateOrdonnance()
        {
            this.ordonnances = controller.GetOrdonnances(patient.Id);

            // data grid 
            DataGridViewButtonColumn modifyButton = new DataGridViewButtonColumn();
            modifyButton.Name = "Générer le pdf";
            modifyButton.Text = "Générer le pdf";
            int columnIndex = 0;
            if (dataGridListO.Columns["modify"] == null)
            {
                dataGridListO.Columns.Insert(columnIndex, modifyButton);
            }
            this.dataGridListO.DataSource = null;
            this.dataGridListO.DataSource = ordonnances;

            // init header names
            this.dataGridListO.Columns[4].HeaderText = "Durée";
            this.dataGridListO.Columns[5].HeaderText = "Instructions spécifiques";

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
                this.TestIncompatibilty(newMed);
                medicaments.Add(newMed);
                allMeds.RemoveAt(selectedMed);
                UpdateComboBoxMeds();
                UpdateMedicamentDG();
            }
        }

        // test incompatibility 
        private void TestIncompatibilty(ObjetPatient med)
        {
            // test if incompatibility with patient's antecedent
            foreach (ObjetPatient antecedent in patientAntecedents)
            {
                RequestStatus status = medController.GetIncompatibilityAntecedent(antecedent.Id, med.Id);
                if (status.success)
                {
                    incompatibilities.Add(new Incompatibility(typeItem.Antecedent, med, antecedent));
                    this.warningText.Visible = true;
                    break;
                } else if (!status.success && (status.typeError == typeError.NoConnection || status.typeError == typeError.InvalidCredentials ))
                {
                    MessageBox.Show("Attention aucune possibilité de vérifier s'il y a une incompatibilité avec le médicament sélectionné.");
                    break;
                }
            }

            // test if incompatibility with patient's allergies 
            foreach (ObjetPatient allergy in patientAllergies)
            {
                RequestStatus status = medController.GetIncompatibilityAllergy(allergy.Id, med.Id);
                if (status.success)
                {
                    incompatibilities.Add(new Incompatibility(typeItem.Allergy, med, allergy));
                    this.warningText.Visible = true;
                    break;
                }
                else if (!status.success && (status.typeError == typeError.NoConnection || status.typeError == typeError.InvalidCredentials))
                {
                    MessageBox.Show("Attention aucune possibilité de vérifier s'il y a une incompatibilité avec le médicament sélectionné.");
                    break;
                }
            }
            // test if incompatibility with other medicament in list
            foreach (ObjetPatient meds in medicaments)
            {
                RequestStatus status = medController.GetIncompatibilityMedicament(meds.Id, med.Id);
                if (status.success)
                {
                    incompatibilities.Add(new Incompatibility(typeItem.Medicament, med, meds));
                    this.warningText.Visible = true;

                    string message = "Attention ce médicament est incompatible avec ce médicament :" + meds.Libelle;
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult dialog;

                    dialog = MessageBox.Show(message, "Voulez-vous continuer ?", buttons);
                    if (dialog == System.Windows.Forms.DialogResult.No)
                    {
                        return;
                    }
                    break;
                }
                else if (!status.success && (status.typeError == typeError.NoConnection || status.typeError == typeError.InvalidCredentials))
                {
                    MessageBox.Show("Attention aucune possibilité de vérifier s'il y a une incompatibilité avec le médicament sélectionné.");
                    break;
                }
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
            // warning message
            if (incompatibilities.Exists(inco => inco.type == typeItem.Allergy) || incompatibilities.Exists(inco => inco.type == typeItem.Antecedent))
            {
                // separate allergies and antecedent
                List<string> antedentsString = incompatibilities.Where(inco => inco.type == typeItem.Antecedent).Select(ant => ant.secondItem.Libelle).ToList();
                List<string> allergiesString = incompatibilities.Where(inco => inco.type == typeItem.Allergy).Select(ant => ant.secondItem.Libelle).ToList();

                string message = "Attention certains médicaments sont incompatibles avec le patient. " +
                    $"Il a des incompatibilités avec : {String.Join(", ", antedentsString)}, {String.Join(", ", allergiesString)}";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult dialog;

                dialog = MessageBox.Show(message, "Voulez-vous continuer ?", buttons);
                if (dialog == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
            }

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

            // test if fields are empty
            if (this.InstruSpeTxt.Text.Length == 0 || this.posologieTxt.Text.Length == 0
                || duree.Length == 0 && this.medicaments.Count == 0)
            {
                MessageBox.Show("Vérifiez vos champs.");
                // exit
                return;
            }

            // create object ordonnance to send to db 
            Ordonnance newOrdo = new Ordonnance(posologieTxt.Text, duree, InstruSpeTxt.Text, code);
            int idMedecin = Global.UserId;
            // send to db 
            RequestStatus status = controller.AddOrdonnance(newOrdo, idMedecin, patient.Id);
            if (status.success)
            {
                int idOrdonnance = controller.GetIdWithCode(code);
                if (idOrdonnance != 0)
                {
                    foreach (ObjetPatient meds in medicaments)
                    {
                        RequestStatus statusAddedMeds = controller.AddMedsInOrdonnance(idOrdonnance, meds.Id);
                        if (!statusAddedMeds.success)
                        {
                            MessageBox.Show($"Une erreur s'est produite en ajoutant le médicament : {meds.Libelle}");
                            break;
                        }
                    }
                    MessageBox.Show("Ajout de l'ordonnance réussit.");
                    UpdateOrdonnance();
                } else
                {
                    MessageBox.Show("Erreur dans l'ajout de médicament pour l'ordonnance");
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

        private void dataGridMeds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridMeds.Rows[e.RowIndex];
                if (selectedRow != null)
                {
                    ObjetPatient selected = selectedRow.DataBoundItem as ObjetPatient;
                    DeleteOrdonnanceMedicamentForm details = new DeleteOrdonnanceMedicamentForm(this, selected);
                    // add closing event to the form
                    details.FormClosing += new FormClosingEventHandler(this.DetailsClosing);
                    details.Show();
                }

            }
        }

        // handle when the Details form is closing, update the actual list
        private void DetailsClosing(object sender, FormClosingEventArgs e)
        {
            UpdateMedicamentDG();
        }

        // delete item medicament list
        public void DeleteMedicament(ObjetPatient selectedMed)
        {
            medicaments.Remove(selectedMed);
            int incompatibilityIndex = incompatibilities.FindIndex(inco => inco.firstItem.Id == selectedMed.Id);
            if ( incompatibilityIndex != -1)
            {
                incompatibilities.RemoveAt(incompatibilityIndex);
                this.warningMedsTxt.Visible = incompatibilities.Exists(inco => inco.type == typeItem.Medicament);
                this.warningText.Visible = incompatibilities.Exists(inco => inco.type == typeItem.Allergy) || incompatibilities.Exists(inco => inco.type == typeItem.Antecedent);

            }
        }

        private void dataGridListO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridListO.Rows[e.RowIndex];
                if (selectedRow != null)
                {
                    Ordonnance selected = selectedRow.DataBoundItem as Ordonnance;
                    if (e.ColumnIndex == dataGridListO.Columns["Générer le pdf"].Index)
                    {
                        // generate pdf 
                        selected.GeneratePDF(controller.GetAllMeds(selected.Id));
                    }
                }

            }
        }
    }
}
