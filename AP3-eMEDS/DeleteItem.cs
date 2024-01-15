using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP3_eMEDS
{
    public enum typeItem
    {
        Medicament, 
        Allergy, 
        Antecedent
    }
    public partial class DeleteItem : Form
    {
        private int IdItem;
        private typeItem typeItem;
        public DeleteItem(int idSelected, string Libelle, typeItem type)
        {
            InitializeComponent();

            this.IdItem = idSelected;
            this.typeItem = type;

            // init label
            switch (type)
            {
                case typeItem.Medicament:
                    this.titleLabel.Text = $"Voulez-vous supprimer le médicament {Libelle} ?";
                    break;
                case typeItem.Allergy:
                    this.titleLabel.Text = $"Voulez-vous supprimer l'allergie {Libelle} ?";
                    break;
                case typeItem.Antecedent:
                    this.titleLabel.Text = $"Voulez-vous supprimer l'antécédent {Libelle} ?";
                    break;


            }
            
        }

        private void supprBtn_Click(object sender, EventArgs e)
        {
            // init label
            switch (this.typeItem)
            {
                case typeItem.Medicament:
                    MedicamentController medicamentController = new MedicamentController();
                    medicamentController.DeleteMedicamentFromId(this.IdItem);
                    break;
                case typeItem.Allergy:
                    AllergieController allergieController = new AllergieController();
                    allergieController.DeleteAllergy(IdItem);
                    break;
                case typeItem.Antecedent:
                    AntecedentController antecedentController = new AntecedentController();
                    antecedentController.DeleteAntecedent(IdItem);
                    break;


            }
        }
    }
}
