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
        private readonly Medicament detailledDrug;
        private readonly MedicamentController drugDataAccess = new MedicamentController();
        public Details(Medicament detailledDrug)
        {
            InitializeComponent();
            this.nameTxt.Text = detailledDrug.Libelle;
            this.contreIndcTxt.Text = detailledDrug.ContreIndication;
            this.InstructionTxt.Text = detailledDrug.Instructions;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            Medicament updatedDrug = new Medicament(detailledDrug.Id, 
                                        nameTxt.Text, 
                                        contreIndcTxt.Text,
                                        InstructionTxt.Text
                                        );
            int result =  drugDataAccess.UpdateDrugFromId(updatedDrug);
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
            int result = drugDataAccess.DeleteDrugFromId(detailledDrug.Id);
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
    }
}
