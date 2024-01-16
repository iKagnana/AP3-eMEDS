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
    public partial class DeleteMedIncompatibility : Form
    {
        private readonly MedicamentController controller = new MedicamentController();
        private typeItem type;
        private int idMed;
        private ObjetPatient selectedObj;
        public DeleteMedIncompatibility(ObjetPatient obj, int idMed, typeItem type)
        {
            InitializeComponent();

            this.selectedObj = obj;
            this.idMed = idMed;
            this.type = type;

            // init label
            switch (type)
            {
                case typeItem.Allergy:
                    this.titleLabel.Text = $"Voulez-vous supprimer l'allergie {obj.Libelle} ?";
                    break;
                case typeItem.Antecedent:
                    this.titleLabel.Text = $"Voulez-vous supprimer l'antécédent {obj.Libelle} ?";
                    break;


            }
        }

        private void supprBtn_Click(object sender, EventArgs e)
        {
            switch (this.type)
            {
                case typeItem.Allergy:
                    controller.DeleteAllergyIncompatibility(selectedObj.Id, idMed);
                    break;
                case typeItem.Antecedent:
                    controller.deleteAntecedentIncompatibility(selectedObj.Id, idMed);
                    break;
                case typeItem.Medicament:
                    controller.deleteMedicamentIncompatibility(selectedObj.Id, idMed);
                    break;


            }

            this.Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
