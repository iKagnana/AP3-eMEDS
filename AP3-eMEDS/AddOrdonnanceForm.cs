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
    public partial class AddOrdonnanceForm : Form
    {
        private readonly OrdonnanceController controller = new OrdonnanceController();
        // variable 
        private Patient patient;
        private List<Ordonnance> ordonnance = new List<Ordonnance>();

        public AddOrdonnanceForm(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;

            UpdateOrdonnance();
        }

        private void UpdateOrdonnance()
        {
            this.ordonnance = controller.GetOrdonnances(patient.Id);

            // data grid 
            this.dataGridListO.DataSource = null;
            this.dataGridListO.DataSource = ordonnance;
        }
    }
}
