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
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string DateNaissance { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        // constructor when get data from db
        public Medecin(int id, string lastname, string firstName, string birthDate, string username, string role)
        {
            Id = id;
            Nom = lastname;
            Prenom = firstName;
            DateNaissance = birthDate;
            Email = username;
            Role = role;
        }

        // constructor when add medecin in db 
        public Medecin(string lastname, string firstName, string birthDate, string username, string password, string role)
        {
            this.Nom = lastname;
            this.Prenom = firstName;
            this.DateNaissance = birthDate; 
            this.Email = username;
            this.Password = password;
            this.Role = role;
        }

        // constructor for login 
        public Medecin(string username, string password)
        {
            this.Email = username;
            this.Password = password;
        }
    }
}
