using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3_eMEDS
{
    internal class User
    {
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User(string Lastname, string Firstname, string Email, string Passwrord) {
            this.Lastname = Lastname;
            this.Firstname = Firstname;
            this.Email = Email;
            this.Password = Passwrord;
        }

        public User(string Lastname)
        {
            this.Lastname = Lastname;
        }
    }
}
