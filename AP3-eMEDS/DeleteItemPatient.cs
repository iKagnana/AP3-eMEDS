﻿using System;
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
    public partial class DeleteItemPatient : Form
    {
        private readonly PatientController controller = new PatientController();
        private ObjetPatient selected;
        private int idP;
        private typeItem typeItem;
        public DeleteItemPatient(ObjetPatient obj, int idP, typeItem type)
        {
            InitializeComponent();

            this.selected = obj;
            this.idP = idP;
            this.typeItem = type;

            // init label
            switch (type)
            {
                case typeItem.Allergy:
                    this.subtitle.Text = $"l'{obj.Libelle} ?";
                    break;
                case typeItem.Antecedent:
                    this.subtitle.Text = $"l'antécédent {obj.Libelle} ?";
                    break;


            }
            
        }

        private void supprBtn_Click(object sender, EventArgs e)
        {
            switch (this.typeItem)
            {
                case typeItem.Allergy:
                    controller.DeletePatientAllergy(idP, selected.Id);
                    break;
                case typeItem.Antecedent:
                   controller.DeletePatientAntecedent(idP, selected.Id);
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
