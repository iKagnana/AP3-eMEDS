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
    public partial class DetailsMedecin : Form
    {
        private Medecin selectedMedecin;
        private readonly MedecinController controller = new MedecinController();
        public DetailsMedecin(Medecin medecin)
        {
            InitializeComponent();

            this.selectedMedecin = medecin;

            // init fields
            this.lastnameTxt.Text = medecin.Nom;
            this.firstnameTxt.Text = medecin.Prenom;
            this.birthDatePicker.Text = medecin.DateNaissance;
            this.emailTxt.Text = medecin.Email;

            string[] roles = { "ADMIN", "USER" };
            this.comboBoxRole.DataSource = roles;
            this.comboBoxRole.SelectedIndex = Array.FindIndex(roles, role => role == medecin.Role);

        }

        private void pwTxt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous ne pouvez pas directement modifier le mot de passe.");
        }

        private void changePwBtn_Click(object sender, EventArgs e)
        {
            ChangePwForm changePwForm = new ChangePwForm(selectedMedecin.Id);
            changePwForm.ShowDialog();
        }

        private void supprBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Supress Médecin ", selectedMedecin.Id);
            RequestStatus status = controller.DeleteMedecin(selectedMedecin.Id);

            if (status.success)
            {
                MessageBox.Show("Suppression du médecin réussi");
            } else if (!status.success && status.typeError == typeError.CannotDelete)
            {
                MessageBox.Show("Vous ne pouvez pas supprimer ce médecin");
            } else
            {
                MessageBox.Show("Erreur lors de la suppression");
            }

            this.Close();
        }
    }
}
