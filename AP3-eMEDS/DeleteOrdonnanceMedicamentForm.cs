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
    public partial class DeleteOrdonnanceMedicamentForm : Form
    {
        private AddOrdonnanceForm form;
        private ObjetPatient selectedMed;
        public DeleteOrdonnanceMedicamentForm(AddOrdonnanceForm actualForm, ObjetPatient med)
        {
            InitializeComponent();

            // to use the parent form func
            this.form = actualForm;
            this.selectedMed = med;
            this.titleLabel.Text = $"Voulez-vous supprimer le médicament {med.Libelle} ?";
        }

        private void supprBtn_Click(object sender, EventArgs e)
        {
            form.DeleteMedicament(selectedMed);
            this.Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
