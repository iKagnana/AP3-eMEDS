using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3_eMEDS
{
    internal class AllergieController
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        // get all allergies
        public List<ObjetPatient> GetAllergies()
        {
            using(MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM allergie";

                List<ObjetPatient> allergies = new List<ObjetPatient>();

                using(MySqlCommand command = new MySqlCommand(query, conn))
                {
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        allergies.Add(new ObjetPatient(reader.GetInt32(0), reader.GetString(2)));
                    }

                    return allergies;
                }
            }
        }

        // add allergies 
        public int AddAllergy(ObjetPatient allergie)
        {
            using(MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO allergie (libelle_al) VALUES (@libelle)";

                using(MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("libelle", allergie.Libelle);
                    int result = command.ExecuteNonQuery();
                    return result;
                }
            }
        }

        // update allergy from its id 
        public int UpdateAllergy(ObjetPatient allergie)
        {
            using(MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE allergie SET libelle_al = @libelle WHERE id_al = @id";
                using(MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@libelle", allergie.Libelle);
                    command.Parameters.AddWithValue("@id", allergie.Id);
                    int result = command.ExecuteNonQuery();
                    return result;
                }
            }
        }

        // delete allergy from its id 
        public int DeleteAllergy(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM allergie WHERE id_al = @id";

                using(MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id", id);
                    int result = command.ExecuteNonQuery();
                    return result;
                }
            }
        }
    }
}
