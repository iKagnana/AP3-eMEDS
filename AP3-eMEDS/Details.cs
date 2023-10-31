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
        private Drug detailledDrug;
        private DrugDataAccess drugDataAccess = new DrugDataAccess();
        public Details(int id, string name, string description)
        {
            InitializeComponent();
            this.textBox1.Text = name;
            this.textBox2.Text = description;
            this.detailledDrug = new Drug(id, name, description);
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            Drug updatedDrug = new Drug(detailledDrug.Id, textBox1.Text, textBox2.Text);
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

        }
    }
}
