using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3_eMEDS
{
    public class Medicament
    {
        public int Id { get; set; }
        public string Libelle { get; set; }

        public string Instructions { get; set; }
        public string ContreIndication { get; set; }
        

        // constructor when get data from db
        public Medicament(int Id, string Libelle, string ContreIndication, string Instructions)
        {
            this.Id = Id;
            this.Libelle = Libelle;
            this.ContreIndication = ContreIndication;
            this.Instructions = Instructions;
        }

        // constructor for adding data in db
        public Medicament(string Libelle, string ContreIndication, string Instructions)
        {
            this.Libelle = Libelle;
            this.ContreIndication = ContreIndication;
            this.Instructions = Instructions;
        }

    }
}
