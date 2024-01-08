using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3_eMEDS
{
    internal class Medecin
    {
        public string Id { get; set; }
        public string Lastname { get; set; }
        public string FirstName { get; set; }
        public string BirthDate { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Medecin(string id, string lastname, string firstName, string birthDate, string username, string password)
        {
            Id = id;
            Lastname = lastname;
            FirstName = firstName;
            BirthDate = birthDate;
            Username = username;
            Password = password;
        }

        // constructor for login 
        public Medecin(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
