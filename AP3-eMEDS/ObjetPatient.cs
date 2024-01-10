using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3_eMEDS
{
    internal class ObjetPatient
    {
        public int Id { get; set; }
        public string Libelle { get; set; }

        // add constructor to map data from db
        public ObjetPatient(int Id, string Libelle)
        {
            this.Id = Id;
            this.Libelle = Libelle;
        }

        // add constructor to send data to db
        public ObjetPatient(string Libelle)
        {
            this.Libelle = Libelle;
        }
    }
}
