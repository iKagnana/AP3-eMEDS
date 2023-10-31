using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3_eMEDS
{
    // espèce de controller
    internal class DrugDataAccess
    {
        private List<Drug> drugs = new List<Drug>();

        public DrugDataAccess() { }

        // ajoute un médicament à la liste
        public void AddDrug(Drug drug) {
            this.drugs.Add(drug);
        }

        // permet de récupérer la liste de médicament
        public List<Drug> GetDrugList() { 
            return this.drugs; 
        }

        // permet de récupérer un médicament en particulier
        public Drug GetDrugById(int Id)
        {
            return this.drugs[Id];
        }
    }
}
