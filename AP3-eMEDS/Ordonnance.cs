using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AP3_eMEDS
{
    internal class Ordonnance
    {
        public int Id { get; set; }
        public string Posologie { get; set; }
        public string Duree {  get; set; }
        public string InstructionsSpe {  get; set; }
        public int NbMeds { get; set; }
        public string Code { get; set; }

        // create item from db
        public Ordonnance(int id, string posologie, string duree, int nbMeds ) {
            this.Id = id;
            this.Posologie = posologie;
            this.Duree = duree;
            this.NbMeds = nbMeds;
        }

        // create item to send to db
        public Ordonnance(string posologie, string duree, string instructionSpe, string code)
        {
            this.Posologie = posologie;
            this.Duree = duree;
            this.InstructionsSpe = instructionSpe;
            this.Code = code;
        }
    }
}
