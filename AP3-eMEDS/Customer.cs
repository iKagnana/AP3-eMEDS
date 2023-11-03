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
        public bool ValidCustomer { get; set;} = true;

        public Customer(string Email, string Password, string Address, string Name, string Siret, Status status) : 
            base(Email, Password, Address)
        {
            this.Name = EmptyField(Name);
            this.Siret = EmptyField(Siret);
            this.Email = EmptyField(Email);
            this.Password = EmptyField(Password);
            this.Address = EmptyField(Address);
            this.Status = status;
        }

        public string EmptyField(string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                this.ValidCustomer = false;
            }
            return text;
        }
    }
}
