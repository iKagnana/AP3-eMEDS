using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP3_eMEDS
{
    internal class AllergieController
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        public AllergieController() { }

        // get all allergies
        public List<ObjetPatient> GetAllergies()
        {
            List<ObjetPatient> allergies = new List<ObjetPatient>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM allergie";

                    

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        MySqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            allergies.Add(new ObjetPatient(reader.GetInt32(0), reader.GetString(1)));
                        }
                        conn.Close();
                        return allergies;
                    }
                }
            } catch (MySqlException e)
            {
                ErrorHandler handler = new ErrorHandler(e);
                Console.WriteLine(handler.GetMessageError());
                MessageBox.Show("Impossible de récupérer la liste des allergies pour le moment.");
                return allergies;
            }
        }

        // add allergies 
        public RequestStatus AddAllergy(ObjetPatient allergie)
        {
            RequestStatus status = new RequestStatus();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO allergie (libelle_al) VALUES (@libelle)";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("libelle", allergie.Libelle);
                        int result = command.ExecuteNonQuery();
                        conn.Close();
                        return status.GetRequestStatusNoError(result);
                    }
                }
            }
            catch (MySqlException e)
            {
                ErrorHandler handler = new ErrorHandler(e);
                Console.WriteLine(handler.GetMessageError());
                return status.GetRequestStatusError(handler.type);
            }
        }

        // update allergy from its id 
        public RequestStatus UpdateAllergy(ObjetPatient allergie)
        {
            RequestStatus status = new RequestStatus();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE allergie SET libelle_al = @libelle WHERE id_al = @id";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@libelle", allergie.Libelle);
                        command.Parameters.AddWithValue("@id", allergie.Id);
                        int result = command.ExecuteNonQuery();
                        conn.Close();
                        return status.GetRequestStatusNoError(result);
                    }
                }
            }
            catch (MySqlException e)
            {
                ErrorHandler handler = new ErrorHandler(e);
                Console.WriteLine(handler.GetMessageError());
                return status.GetRequestStatusError(handler.type);
            }
        }

        // delete allergy from its id 
        public RequestStatus DeleteAllergy(int id)
        {
            RequestStatus status = new RequestStatus();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM allergie WHERE id_al = @id";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
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
