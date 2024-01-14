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
        public DetailsMedecin(Medecin medecin)
        {
            InitializeComponent();

            this.selectedMedecin = medecin;

            // init fields
            this.lastnameTxt.Text = medecin.Lastname;
            this.firstnameTxt.Text = medecin.FirstName;
            this.birthDatePicker.Text = medecin.BirthDate;
            this.emailTxt.Text = medecin.Username;

            string[] roles = { "ADMIN", "USER" };
            this.comboBoxRole.DataSource = roles;
            // TODO set role init

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
    }
}
