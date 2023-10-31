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
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Adding drug !");
            Drug drug = new Drug(this.textBox1.Text, this.textBox2.Text);
            dataAccess.AddDrug(drug);
            this.UpdateGridView();
        }

        public void UpdateGridView()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = dataAccess.GetDrugList();
        }


        private void OpenForm(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Drug selectedDrug = dataAccess.GetDrugById(e.RowIndex);
                Details details = new Details(selectedDrug.Name, selectedDrug.Description);
                details.Show();
            }
            
        }
    }
}
