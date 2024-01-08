using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3_eMEDS
{
    internal class Antecedent
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Antecedent(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
