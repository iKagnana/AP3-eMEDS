using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Status
{
    Waiting,
    Confirmed,
    Refused

}

namespace AP3_eMEDS

{
    public class Patient
    {
        public int Id { get; set; }
        public string Nom {get; set;}
        public string Prenom { get; set;}
        public string Sexe { get; set;}
        public string NumSecu { get; set; }
        public int Allergie { get; set; }
        public int Antecedent { get; set; }
        

        // init from db simple Patient class
        public Patient(int id, string lastname, string firstname, string sexe, string numSecu, int allergie, int antecedent)
        {
            this.Id = id;
            this.Nom = lastname;
            this.Prenom = firstname;
            this.Sexe = sexe;
            this.NumSecu = numSecu;
            this.Allergie = allergie;
            this.Antecedent = antecedent;
        }

        // constructor for create patient
        public Patient(string lastname, string firstname, string sexe, string numSecu)
        {
            this.Nom = lastname;
            this.Prenom = firstname;
            this.Sexe = sexe;
            this.NumSecu = numSecu;
        }
    }
}
