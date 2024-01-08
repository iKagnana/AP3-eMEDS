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

        // init from db simple Patient class
        public Patient(int id, string lastname, string firstname, string sexe)
        {
            this.Id = id;
            this.Nom = lastname;
            this.Prenom = firstname;
            this.Sexe = sexe;
        }

        // constructor for create patient
        public Patient(string lastname, string firstname, string sexe)
        {
            this.Nom = lastname;
            this.Prenom = firstname;
            this.Sexe = sexe;
        }
    }
}
