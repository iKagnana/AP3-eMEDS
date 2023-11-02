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
    internal class Customer : User
    {
        public string Name {get; set;}
        public string Siret { get; set;}
        public Status Status { get; set;}
        public Customer(string Email, string Passwrord, string Address, string Name, string Siret, Status status) : 
            base(Email, Passwrord, Address)
        {
            this.Name = Name;
            this.Siret = Siret;
            this.Email = Email;
            this.Password = Passwrord;
            this.Address = Address;
            this.Status = status;
        }
    }
}
