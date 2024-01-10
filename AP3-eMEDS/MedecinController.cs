using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AP3_eMEDS
{
    internal class MedecinController
    {
        // get value for localhost in App.config
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        public MedecinController() { }

        // function to get the string associated with enum option 
        public string GetStatus(Status status)
        {
            switch (status)
            {
                case Status.Waiting: 
                    return "En attente de validation";
                case Status.Confirmed:
                    return "Validé";
                case Status.Refused:
                    return "Refusé";
                default:
                    return "";
            }
        }

        // method create user type employee
        public int AddEmployee(Medecin medecin)
        {
            // create connection to the db to make query 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO medecin (nom_m, prenom_m, login_m, password_m, date_naissance_m) " +
                    "VALUES (@lastname, @firstname, @login, @password, @login)";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@name", medecin.Lastname);
                    command.Parameters.AddWithValue("@siret", medecin.FirstName);
                    command.Parameters.AddWithValue("@login", medecin.Username);
                    command.Parameters.AddWithValue("@password", medecin.Password);
                    command.Parameters.AddWithValue("@birthdate", medecin.BirthDate);
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }

        // function to get all the user email to see if it's unique
        public bool UniqueEmail(string email)
        {
            // create connection to the db to make query 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT email FROM medecin WHERE email = @email";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@email", email);
                    
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        conn.Close();
                        return true;
                    } else
                    {
                        conn.Close();
                        return false;
                    }
                    
                }
            }
        }

        // login function
        public bool Login(Medecin medecin)
        {
            // get the data of the customer
            // create connection to the db to make query 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT login_m, password_m FROM medecin WHERE login_m = @login";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@login", medecin.Username);

                    // get data 
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    
                    if (reader.GetString(0) == medecin.Username && 
                        reader.GetString(1) == medecin.Password)
                    {
                        conn.Close();
                        return true;
                            
                    }
                    else
                    {
                        conn.Close();
                        return false;
                    }
                    
                }
            }
        }
    }
}
