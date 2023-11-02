using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3_eMEDS
{
    internal class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }

        // constructor to get user 
        public User(int Id, string email, string passwrord, string address)
        {
            this.Id = Id;
            this.Email = email;
            this.Password = passwrord;
            this.Address = address;
        }

        // constructor to create user
        public User(string email, string passwrord, string address)
        {
            this.Email = email;
            this.Password = passwrord;
            this.Address = address;
        }
    }
}
