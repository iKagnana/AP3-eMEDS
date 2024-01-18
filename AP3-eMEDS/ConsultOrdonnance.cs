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
    public partial class ConsultOrdonnance : Form
    {
        private readonly OrdonnanceController controller = new OrdonnanceController();
        private Patient patient;
        private Ordonnance ordonnance;
        private List<Medicament> medicament = new List<Medicament>();

        public ConsultOrdonnance(Patient patient, Ordonnance ordonnance)
        {
            InitializeComponent();
            this.patient = patient;
            this.ordonnance = ordonnance;

            UpdateDataGrid();

            // init form
            this.labelInfos.Text = $"{patient.Nom} {patient.Prenom} {patient.Sexe} - {patient.NumSecu}";
            this.dureeTxt.Text = ordonnance.Duree;
            this.InstruSpeTxt.Text = ordonnance.InstructionsSpe;
            this.posologieTxt.Text = ordonnance.Posologie;
            
        }

        private void UpdateDataGrid()
        {
            Console.WriteLine(ordonnance.Code);
            this.medicament = controller.GetAllMeds(ordonnance.Id);

            this.dataGridMeds.DataSource = null;
            this.dataGridMeds.DataSource = medicament;
        }
    }
}
