using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3_eMEDS
{
    public class Medecin
    {
        public int Id { get; set; }
        public string Lastname { get; set; }
        public string FirstName { get; set; }
        public string BirthDate { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        // constructor when get data from db
        public Medecin(int id, string lastname, string firstName, string birthDate, string username, string role)
        {
            Id = id;
            Lastname = lastname;
            FirstName = firstName;
            BirthDate = birthDate;
            Username = username;
            Role = role;
        }

        // constructor when add medecin in db 
        public Medecin(string lastname, string firstName, string birthDate, string username, string password, string role)
        {
            this.Lastname = lastname;
            this.FirstName = firstName;
            this.BirthDate = birthDate; 
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }

        // constructor for login 
        public Medecin(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
