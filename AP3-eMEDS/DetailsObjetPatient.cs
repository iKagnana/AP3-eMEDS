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
    public partial class DetailsObjetPatient : Form
    {
        private readonly AntecedentController anController = new AntecedentController();
        private readonly AllergieController alController = new AllergieController();
        private typeObjetPatient type;
        private ObjetPatient selectedObjet;
        public DetailsObjetPatient(typeObjetPatient type, ObjetPatient objetPatient)
        {
            InitializeComponent();

            this.type = type;
            this.selectedObjet = objetPatient;

            switch (type)
            {
                case typeObjetPatient.Antecedent:
                    this.Text = "Détails d'un antécédent - GSB";
                    break;
                case typeObjetPatient.Allergie:
                    this.Text = "Détails d'un antécédent - GSB";
                    break;
            }

            this.nameTxt.Text = objetPatient.Libelle;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (selectedObjet.Libelle.Length == 0)
            {
                return;
            }

            RequestStatus status = new RequestStatus();
            status.success = false;
            switch (type)
            {
                case typeObjetPatient.Antecedent:
                    status = anController.UpdateAntecedent(selectedObjet);
                    break;
                case typeObjetPatient.Allergie:
                    status = alController.UpdateAllergy(selectedObjet);
                    break;
            }

            if (status.success)
            {
                MessageBox.Show("Modification réussite.");
                this.Close();
            } else
            {
                MessageBox.Show("Erreur lors de la modification.");
            }
        }

        private void supprBtn_Click(object sender, EventArgs e)
        {
            RequestStatus status = new RequestStatus();
            status.success = false;
            switch (type)
            {
                case typeObjetPatient.Antecedent:
                    status = anController.DeleteAntecedent(selectedObjet.Id);
                    break;
                case typeObjetPatient.Allergie:
                    status = alController.DeleteAllergy(selectedObjet.Id);
                    break;
            }

            if (status.success)
            {
                MessageBox.Show("Suppression réussie.");
                this.Close();
            } else if (!status.success && status.typeError == typeError.CannotDelete)
            {
                MessageBox.Show("Vous ne pouvez pas supprimer.");
            } else
            {
                MessageBox.Show("Erreur lors de la suppression");
            }

        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            this.selectedObjet.Libelle = this.nameTxt.Text;
        }
    }
}
