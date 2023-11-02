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
        private readonly Drug detailledDrug;
        private readonly DrugDataAccess drugDataAccess = new DrugDataAccess();
        public Details(Drug detailledDrug)
        {
            InitializeComponent();
            this.nameTxt.Text = detailledDrug.Name;
            this.targetTxt.Text = detailledDrug.Target;
            this.descTxt.Text = detailledDrug.Description;
            this.priceTxt.Text = detailledDrug.Price.ToString();
            this.stocksField.Text = detailledDrug.Stocks.ToString();
            this.detailledDrug = detailledDrug;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            Drug updatedDrug = new Drug(detailledDrug.Id, 
                                        nameTxt.Text, 
                                        descTxt.Text,
                                        targetTxt.Text,
                                        Convert.ToDouble(priceTxt.Text), 
                                        Convert.ToInt32(stocksField.Text));
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
            // TODO
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
