using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3_eMEDS
{
    internal class AntecedentController
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        public AntecedentController() { }

        // get all antecedent
        public List<ObjetPatient> GetAntecedents()
        {
            using(MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM antecedent";

                List<ObjetPatient> antecedents = new List<ObjetPatient>();

                using(MySqlCommand command = new MySqlCommand(query, conn))
                {
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        antecedents.Add(new ObjetPatient(reader.GetInt32(0), reader.GetString(1)));
                    }

                    return antecedents;
                }
            }
        }

        // add antecedent
        public int AddAntecedent(ObjetPatient antecedent)
        {
            using(MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO antecedent (libelle_a) VALUES (@libelle)";

                using(MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@libelle", antecedent.Libelle);
                    int result = command.ExecuteNonQuery();
                    return result;
                }
            }
        }

        // update antecedent from its id
        public int UpdateAntecedent(ObjetPatient antecedent)
        {
            using(MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE antecedent SET libelle_a = @libelle WHERE id_a = @id";

                using(MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@libelle", antecedent.Libelle);
                    command.Parameters.AddWithValue("@id", antecedent.Id);
                    int result = command.ExecuteNonQuery();
                    return result;
                }
            }
        }

        // delete antecedent from its id 
        public int DeleteAntecedent(int id)
        {
            using(MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM antecedent WHERE id_a = @id";

                using(MySqlCommand command = new MySqlCommand(query, conn)) {
                    command.Parameters.AddWithValue("@id", id);
                    int result = command.ExecuteNonQuery();
                    return result;
                }
            }
        }
    }
}
