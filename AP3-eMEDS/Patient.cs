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
    internal class Patient
    {
        public int Id { get; set; }
        public string Name {get; set;}
        public string Siret { get; set;}
        public string Sexe { get; set;}
        public List<Antecedent> antecedents { get; set; }

        public Patient(int id, string name, string siret, string sexe, List<Antecedent> antecedents)
        {
            Id = id;
            Name = name;
            Siret = siret;
            Sexe = sexe;
            this.antecedents = antecedents;
        }
    }
}
