using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using BCrypt.Net;
using System.Windows.Forms;

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
            List<Medecin> medecins = new List<Medecin>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id_m, nom_m, prenom_m, date_naissance_m, login_m, role FROM medecin";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        MySqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            medecins.Add(new Medecin(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5)));
                        }
                        conn.Close();
                        return medecins;
                    }
                }
            } catch (MySqlException e)
            {
                ErrorHandler handler = new ErrorHandler(e);
                Console.WriteLine(handler.GetMessageError());
                MessageBox.Show("Impossible de récupérer la liste des médecins pour le moment.");
                return medecins;
            }
        }

        // method create user type medecin
        public RequestStatus AddMedecin(Medecin medecin)
        {
            RequestStatus status = new RequestStatus();
            try
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
                        return status.GetRequestStatusNoError(result);
                    }
                }
            } catch (MySqlException e)
            {
                ErrorHandler handler = new ErrorHandler(e);
                Console.WriteLine(handler.GetMessageError());
                return status.GetRequestStatusError(handler.type);
            }
        }

        // function to check if email unique, return true if unique
        public RequestStatus UniqueEmail(string email)
        {
            RequestStatus status = new RequestStatus();
            try
            {
                // create connection to the db to make query 
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id_m n FROM medecin WHERE login_m = @email";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@email", email);
                        if (Convert.ToInt32(command.ExecuteScalar()) < 0)
                        {
                            return status.GetRequestStatusNoError(1);
                        }
                        return status.GetRequestStatusNoError(0);

                    }
                }
            } catch (MySqlException e)
            {
                ErrorHandler handler = new ErrorHandler(e);
                Console.WriteLine(handler.GetMessageError());
                return status.GetRequestStatusError(handler.type);
            }
        }

        // login function
        public RequestStatus Login(Medecin medecin)
        {
            RequestStatus status = new RequestStatus();
            try
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
                        command.Parameters.AddWithValue("@login", medecin.Username.ToLower());

                        idMedecin = Convert.ToInt32(command.ExecuteScalar());
                        MySqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            idMedecin = reader.GetInt32(0);
                            role = reader.GetString(1);
                            hashedPassword = reader.GetString(2);
                        }
                        conn.Close();
                        if (!hashedPassword.Equals("") && BCrypt.Net.BCrypt.Verify(medecin.Password, hashedPassword))
                        {
                            Global.UserId = idMedecin;
                            Global.UserRole = role;
                            return status.GetRequestStatusNoError(1);
                        }
                        else
                        {
                            return status.GetRequestStatusNoError(0);
                        }
                    }
                }
            } catch (MySqlException e)
            {
                ErrorHandler handler = new ErrorHandler(e);
                Console.WriteLine(handler.GetMessageError());
                return status.GetRequestStatusError(handler.type);
            }
        }

        // update medecin 
        public RequestStatus UpdateMedecin(Medecin medecin)
        {
            RequestStatus status = new RequestStatus();
            try
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
                        return status.GetRequestStatusNoError(result);
                    }
                }
            } catch (MySqlException e)
            {
                ErrorHandler handler = new ErrorHandler(e);
                Console.WriteLine(handler.GetMessageError());
                return status.GetRequestStatusError(handler.type);
            }
        }

        // udpate medecin's password
        public RequestStatus UpdateMedecinPassword(string password, int id)
        {
            RequestStatus status = new RequestStatus();
            try
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
                        return status.GetRequestStatusNoError(result);
                    }
                }
            } catch (MySqlException e)
            {
                ErrorHandler handler = new ErrorHandler(e);
                Console.WriteLine(handler.GetMessageError());
                return status.GetRequestStatusError(handler.type);
            }
        }


        // delete medecin 
        public RequestStatus DeleteMedecin(int id)
        {
            RequestStatus status = new RequestStatus();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM medecin WHERE id_m = @id";

                    using (MySqlCommand command = new MySqlCommand(@query, conn))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        int result = command.ExecuteNonQuery();
                        conn.Close();
                        return status.GetRequestStatusNoError(result);
                    }
                }
            } catch (MySqlException e)
            {
                ErrorHandler handler = new ErrorHandler(e);
                Console.WriteLine(handler.GetMessageError());
                return status.GetRequestStatusError(handler.type);
            }
        }
    }
}
