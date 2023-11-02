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
    public partial class AddDrugForm : Form
    {
        private DrugDataAccess dataAccess = new DrugDataAccess();
        private List<Drug> drugs = new List<Drug>();
        public AddDrugForm()
        {
            InitializeComponent();
            UpdateGridView();

            // init column size
            this.dataGridView1.Columns[0].Width = 25;
            this.dataGridView1.Columns[1].Width = 100;
            this.dataGridView1.Columns[2].Width = 210;
            this.dataGridView1.Columns[3].Width = 150;
        }

        // event when click on the button
        private void addBtn_Click(object sender, EventArgs e)
        {
            // create a new object drug
            Drug drug = new Drug(
                this.nameTxt.Text,
                this.descTxt.Text,
                this.targetTxt.Text,
                Convert.ToDouble(this.priceTxt.Text),
                Convert.ToInt32(this.stocksField.Text)
                );
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
            // get updated data 
            var drugs = dataAccess.GetDrugs();

            // reset research to avoid conflict
            this.drugs = drugs;
            this.searchTxt.Text = "";
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = drugs;
        }

        // reset textboxes
        private void ResetTextBoxes()
        {
            this.nameTxt.Text = "";
            this.targetTxt.Text = "";
            this.descTxt.Text = "";
            this.priceTxt.Text = "";
            this.priceTxt.Text = "";
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
                    Details details = new Details(selected);
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

        // update list with filters
        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            // if searchTxt is empty => get the filled data
            if (searchTxt.Text == "") {
                this.dataGridView1.DataSource = drugs;
                // exit method
                return;

            }

             List<Drug> filteredDrugs = new List<Drug>();

            foreach (var drug in drugs)
            {
                if (drug.Name.ToLower().Contains(searchTxt.Text.ToLower()) || 
                    drug.Description.ToLower().Contains(searchTxt.Text.ToLower()) || 
                        drug.Target.ToLower().Contains(searchTxt.Text.ToLower()))
                {
                    filteredDrugs.Add(drug);
                }
            }

            this.dataGridView1.DataSource = filteredDrugs;
        }
    }
}
