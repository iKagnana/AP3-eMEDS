using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using BCrypt.Net;

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
                        medecins.Add(new Medecin(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5)));
                    }
                    conn.Close(); 
                    return medecins;
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
                    "VALUES (@lastname, @firstname, @login, @password, @birthdate, @role)";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    // hash password
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(medecin.Password);
                    command.Parameters.AddWithValue("@lastname", medecin.Lastname);
                    command.Parameters.AddWithValue("@firstname", medecin.FirstName);
                    command.Parameters.AddWithValue("@login", medecin.Username);
                    command.Parameters.AddWithValue("@password", hashedPassword);
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
                string query = "SELECT id_m n FROM medecin WHERE login_m = @email";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@email", email);
                    return Convert.ToInt32(command.ExecuteScalar()) <  0;
                    
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
                string query = "SELECT id_m, role, password_m FROM medecin WHERE login_m = @login";

                int idMedecin = 0;
                string role = "";
                string hashedPassword = "";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@login", medecin.Username);

                    idMedecin = Convert.ToInt32(command.ExecuteScalar());
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        idMedecin = reader.GetInt32(0);
                        role = reader.GetString(1);
                        hashedPassword = reader.GetString(2);
                    }
                    conn.Close();
                    if (!hashedPassword.Equals("") && BCrypt.Net.BCrypt.Verify(medecin.Password, hashedPassword) )
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

        // update medecin 
        public int UpdateMedecin(Medecin medecin)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE medecin SET nom_m = @lasttname, prenom_m = @firstname, date_naissance_m = @birthDate, login_m = @login, role = @role WHERE id_m = @id";

                using (MySqlCommand command = new MySqlCommand(@query, conn))
                {
                    command.Parameters.AddWithValue("@lastname", medecin.Lastname);
                    command.Parameters.AddWithValue("@firstname", medecin.FirstName);
                    command.Parameters.AddWithValue("@login", medecin.Username);
                    command.Parameters.AddWithValue("@birthdate", medecin.BirthDate);
                    command.Parameters.AddWithValue("@role", medecin.Role);
                    command.Parameters.AddWithValue("@id", medecin.Id);

                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }

        // udpate medecin's password
        public int UpdateMedecinPassword(string password, int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE medecin SET password_m = @password WHERE id_m= @id";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
                    command.Parameters.AddWithValue("password", hashedPassword);
                    command.Parameters.AddWithValue("id", id);

                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }


        // delete medecin 
        public int UpdateMedecin(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELET FROM medecin WHERE id_m = @id";

                using (MySqlCommand command = new MySqlCommand(@query, conn))
                {
                    command.Parameters.AddWithValue("@id", id);

                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }
    }
}
