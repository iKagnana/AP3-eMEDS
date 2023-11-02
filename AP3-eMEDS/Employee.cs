using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3_eMEDS
{
    internal class Employee : User
    {
        public string Lastname { get; set; }
        public string FirstName { get; set; }
        public Employee(string Lastname, string Firstname,string Address, string Email, string Passwrord) : 
            base(Email, Passwrord, Address)
        {
            this.Lastname = Lastname;
            this.FirstName = Firstname;
            this.Email = Email;
            this.Password = Passwrord;
            this.Address = Address;
        }

    }
}
