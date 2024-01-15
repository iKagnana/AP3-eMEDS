using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3_eMEDS
{
    // used in ordonnance to handle warning 
    internal class Incompatibility
    {
        public typeItem type;
        public ObjetPatient firstItem;
        public ObjetPatient secondItem;
        public Incompatibility(typeItem type, ObjetPatient firstItem, ObjetPatient secondItem)
        {
            this.type = type;
            this.firstItem = firstItem;
            this.secondItem = secondItem;
        }
    }
}
