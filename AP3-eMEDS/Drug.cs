using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3_eMEDS
{
    internal class Drug
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Drug(int Id, string Name, string Description) 
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
        }

        public Drug(string Name, string Description) {
            this.Name = Name;
            this.Description = Description;
        }

    }
}
