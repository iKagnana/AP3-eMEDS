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
    public partial class Details : Form
    {
        private readonly Medicament detailledMed;
        private readonly MedicamentController controller = new MedicamentController();
        private readonly AllergieController alController = new AllergieController();
        private readonly AntecedentController anController = new AntecedentController();
        // variables
        private int selectedAl;
        private int selectedAn;
        private int selectedMed;
        private List<ObjetPatient> allergies = new List<ObjetPatient>();
        private List<ObjetPatient> antecedent = new List<ObjetPatient>();
        private List<ObjetPatient> medicaments = new List<ObjetPatient>();
        public Details(Medicament detailledMed)
        {
            InitializeComponent();
            this.detailledMed = detailledMed;
            this.nameTxt.Text = detailledMed.Libelle;
            this.contreIndcTxt.Text = detailledMed.ContreIndication;

            // init data grid
            UpdateAllergyDataGrid();
            UpdateAntecedentDataGrid();
            UpdateMedicamentDataGrid();

            this.dataGridAl.Columns[1].Width = 200;
            this.dataGridAn.Columns[1].Width = 200;
            this.dataGridMed.Columns[1].Width = 200;


            // init comboBox
            this.comboAl.DataSource = alController.GetAllergies();
            this.comboAl.ValueMember = "Id";
            this.comboAl.DisplayMember = "Libelle";

            this.comboAn.DataSource = anController.GetAntecedents();
            this.comboAn.ValueMember = "Id";
            this.comboAn.DisplayMember = "Libelle";

            this.comboMed.DataSource = controller.GetMedicaments();
            this.comboMed.ValueMember = "Id";
            this.comboMed.DisplayMember = "Libelle";
        }

        // update data grid view
        private void UpdateAllergyDataGrid()
        {
            this.allergies = controller.GetAllergies(detailledMed.Id);
            this.dataGridAl.DataSource = null;
            this.dataGridAl.DataSource = allergies;
        }

        private void UpdateAntecedentDataGrid()
        {
            this.antecedent = controller.GetAntecedents(detailledMed.Id);
            this.dataGridAn.DataSource = null;
            this.dataGridAn.DataSource = antecedent;
        }

        private void UpdateMedicamentDataGrid()
        {
            this.medicaments = controller.GetIncompatibleMedicament(detailledMed.Id);
            this.dataGridMed.DataSource = null;
            this.dataGridMed.DataSource = medicaments;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            Medicament updatedDrug = new Medicament(detailledMed.Id, 
                                        nameTxt.Text, 
                                        contreIndcTxt.Text);
            int result =  controller.UpdateMedicamentFromId(updatedDrug);
            Console.WriteLine(result);
            if (result == 0)
            {
                MessageBox.Show("Il y a eu une erreur");
            }
            else if (result == 1)
            {
                MessageBox.Show("Médicament modifié");
                this.Close();
            }
        }

        private void supprBtn_Click(object sender, EventArgs e)
        {
            int result = controller.DeleteMedicamentFromId(detailledMed.Id);
            if (result == 0)
            {
                MessageBox.Show("Il y a eu une erreur");
            }
            else if (result == 1)
            {
                MessageBox.Show("Médicament supprimé");
                this.Close();
            }
        }

        // check if only numeric value or not
        private void priceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void comboAl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // try catch to avoid build fail before value assigned for conboAl's selected value
            try
            {
                selectedAl = (int)comboAl.SelectedValue;
            } catch
            {
                Console.WriteLine("Can't convert to int, value is NaN");
            }
        }

        private void comboAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedAn = (int)comboAn.SelectedValue;
            }
            catch
            {
                Console.WriteLine("Can't convert to int, value is NaN");
            }
        }

        private void comboMed_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedMed = (int)comboMed.SelectedValue;
            }
            catch
            {
                Console.WriteLine("Can't convert to int, value is NaN");
            }
        }

        private void addAlBtn_Click(object sender, EventArgs e)
        {
            if (allergies.FindIndex(al => al.Id == selectedAl) == -1 && selectedAl != 0)
            {
                int result = controller.AddIncompatibilityAllergy(detailledMed.Id, selectedAl);
                if (result == 1)
                {
                    UpdateAllergyDataGrid();
                } else
                {
                    MessageBox.Show("Il y a eu une erreur");
                }
            }
        }

        private void addAnBtn_Click(object sender, EventArgs e)
        {
            if (antecedent.FindIndex(an => an.Id == selectedAn) == -1 && selectedAn != 0)
            {
                int result = controller.AddIncompatibilityAntecedent(detailledMed.Id, selectedAn);
                if (result == 1)
                {
                    UpdateAntecedentDataGrid();
                }
                else
                {
                    MessageBox.Show("Il y a eu une erreur");
                }
            }
        }

        private void addMedBtn_Click(object sender, EventArgs e)
        {
            if (medicaments.FindIndex(med => med.Id == selectedMed) == -1 && selectedMed != 0)
            {
                int result = controller.AddIncompatibilityMedicament(detailledMed.Id, selectedMed);
                if (result == 1)
                {
                    UpdateMedicamentDataGrid();
                }
                else
                {
                    MessageBox.Show("Il y a eu une erreur");
                }
            }
        }

        private void dataGridAl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridAl.Rows[e.RowIndex];
                if (selectedRow != null)
                {
                    ObjetPatient selected = selectedRow.DataBoundItem as ObjetPatient;
                    DeleteMedIncompatibility details = new DeleteMedIncompatibility(selected, detailledMed.Id, typeItem.Allergy);
                    // add closing event to the form
                    details.FormClosing += new FormClosingEventHandler(this.DetailsClosing);
                    details.Show();
                }

            }
        }

        private void dataGridAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridAl.Rows[e.RowIndex];
                if (selectedRow != null)
                {
                    ObjetPatient selected = selectedRow.DataBoundItem as ObjetPatient;
                    DeleteMedIncompatibility details = new DeleteMedIncompatibility(selected, detailledMed.Id, typeItem.Antecedent);
                    // add closing event to the form
                    details.FormClosing += new FormClosingEventHandler(this.DetailsClosing);
                    details.Show();
                }

            }
        }

        private void dataGridMed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridAl.Rows[e.RowIndex];
                if (selectedRow != null)
                {
                    ObjetPatient selected = selectedRow.DataBoundItem as ObjetPatient;
                    DeleteMedIncompatibility details = new DeleteMedIncompatibility(selected, detailledMed.Id, typeItem.Medicament);
                    // add closing event to the form
                    details.FormClosing += new FormClosingEventHandler(this.DetailsClosing);
                    details.Show();
                }

            }
        }

        private void DetailsClosing(object sender, FormClosingEventArgs e)
        {
            UpdateAllergyDataGrid();
            UpdateAntecedentDataGrid();
            UpdateMedicamentDataGrid();
        }
    }
}
