using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;

namespace AP3_eMEDS
{
    public partial class Form2 : Form
    {
        private DrugDataAccess dataAccess = new DrugDataAccess();
        public Form2()
        {
            InitializeComponent();
            UpdateGridView();
        }

        // event when click on the button
        private void addBtn_Click(object sender, EventArgs e)
        {
            // create a new object drug
            Drug drug = new Drug(this.textBox1.Text, this.textBox2.Text);
            // get the saved row in db
            int result = dataAccess.addDrugToDB(drug);
            if (result == 0)
            {
                MessageBox.Show("Il y a eu une erreur");
            }
            else if (result == 1)
            {
                MessageBox.Show("Médicament ajouté");
            }
            UpdateGridView();
            ResetTextBoxes();
        }

        // get the last updated list of drugs
        public void UpdateGridView()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = dataAccess.GetDrugs();
        }

        // reset textboxes
        private void ResetTextBoxes()
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
        }


        // open the new form Details
        private void OpenForm(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                if (selectedRow != null)
                {
                    Drug selected = selectedRow.DataBoundItem as Drug;
                    Details details = new Details(selected.Id, selected.Name, selected.Description);
                    // add closing event to the form
                    details.FormClosing += new FormClosingEventHandler(this.DetailsClosing);
                    details.Show();
                }
                
            }

        }

        // handle when the Details form is closing, update the actual list
        private void DetailsClosing(object sender, FormClosingEventArgs e)
        {
            UpdateGridView();
        }
    }
}
