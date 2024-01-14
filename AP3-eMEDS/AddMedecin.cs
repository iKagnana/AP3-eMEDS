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
    public partial class AddMedecinForm : Form
    {
        private readonly MedecinController controller = new MedecinController();
        private List<Medecin> medecins = new List<Medecin>();
        private string selectedRole = "";
        public AddMedecinForm()
        {
            InitializeComponent();

            // init combo box
            string[] roles = { "ADMIN", "USER" };
            this.comboBoxRole.DataSource = roles;

            UpdateDataGrid();

        }

        private void ResetForm()
        {
            this.lastnameTxt.Text = "";
            this.firstnameLabel.Text = "";
            this.emailTxt.Text = "";
            this.pwTxt.Text = "";
        }

        private void UpdateDataGrid()
        {
            this.medecins = controller.GetMedecins();

            this.dataGridMedecin.DataSource = null;
            this.dataGridMedecin.DataSource = this.medecins;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Medecin newMedecin = new Medecin(this.lastnameTxt.Text,
                                             this.firstnameTxt.Text,
                                             this.birthDatePicker.Text,
                                             this.emailTxt.Text,
                                             this.pwTxt.Text, 
                                             this.selectedRole);
            int result = controller.AddMedecin(newMedecin);
            if (result == 1)
            {
                MessageBox.Show("Médecin ajouté");
                ResetForm();
            } else
            {
                MessageBox.Show("Erreur lors de l'ajout du médecin");
            }
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.selectedRole = (string)comboBoxRole.SelectedValue;
            } catch
            {
                Console.WriteLine("Erreur comboBox");
            }
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchTxt.Text == "")
            {
                this.dataGridMedecin.DataSource = medecins;
                return;

            }

            List<Medecin> filteredMedecins = new List<Medecin>();

            foreach (var medecin in medecins)
            {
                if (medecin.Lastname.ToLower().Contains(searchTxt.Text.ToLower()) || medecin.FirstName.ToLower().Contains(searchTxt.Text.ToLower()))
                {
                    filteredMedecins.Add(medecin);
                }
            }

            this.dataGridMedecin.DataSource = medecins;
        }

        private void dataGridMedecin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridMedecin.Rows[e.RowIndex];
                if (selectedRow != null)
                {
                    Medecin selected = selectedRow.DataBoundItem as Medecin;
                    DetailsMedecin details = new DetailsMedecin(selected);
                    // add closing event to the form
                    details.FormClosing += new FormClosingEventHandler(this.DetailsClosing);
                    details.Show();
                }

            }
        }

        // func called when details dialog close
        private void DetailsClosing(object sender, FormClosingEventArgs e)
        {
            UpdateDataGrid();
        }
    }
}
