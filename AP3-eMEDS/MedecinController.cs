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

        // get all medecins
        public List<Medecin> GetMedecins()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString)) {
                conn.Open();
                string query = "SELECT id_m, nom_m, prenom_m, date_naissance_m, login_m, role FROM medecin";

                List<Medecin> medecins = new List<Medecin>();

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    MySqlDataReader reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        medecins.Add(new Medecin())
                    }
                }
            }
        }

        // method create user type medecin
        public int AddMedecin(Medecin medecin)
        {
            // create connection to the db to make query 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO medecin (nom_m, prenom_m, login_m, password_m, date_naissance_m, role) " +
                    "VALUES (@lastname, @firstname, @login, @password, @login, @role)";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@name", medecin.Lastname);
                    command.Parameters.AddWithValue("@siret", medecin.FirstName);
                    command.Parameters.AddWithValue("@login", medecin.Username);
                    command.Parameters.AddWithValue("@password", medecin.Password);
                    command.Parameters.AddWithValue("@birthdate", medecin.BirthDate);
                    command.Parameters.AddWithValue("@role", medecin.Role);
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
                string query = "SELECT id_m FROM medecin WHERE login_m = @login and password_m = @password";

                int idMedecin = 0;
                string role = "";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@login", medecin.Username);
                    command.Parameters.AddWithValue("@password", medecin.Password);

                    idMedecin = Convert.ToInt32(command.ExecuteScalar());
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        idMedecin = reader.GetInt32(0);
                        role = reader.GetString(1);
                    }
                    conn.Close();
                    if (idMedecin > 0 && !role.Equals(""))
                    {
                        Global.UserId = idMedecin;
                        Global.UserRole = role;
                        return true;
                    } else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
