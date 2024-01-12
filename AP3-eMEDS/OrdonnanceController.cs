using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3_eMEDS
{
    internal class OrdonnanceController
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        public OrdonnanceController() { }

        // add ordonnance
        public List<Ordonnance> GetOrdonnances(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM ordonnance WHERE id_p = @id_p";

                List<Ordonnance> ordonnances = new List<Ordonnance>();

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id_p", id);

                    MySqlDataReader reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        ordonnances.Add(new Ordonnance(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4)));
                    }

                    conn.Close();
                    return ordonnances;
                }
            }
        }

        // add ordonnance
        public int AddOrdonnance(Ordonnance ordonnance, int idM, int idP)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO ordonnance (posologie, duree_traitement, instructions_specifique, code, id_m, id_p) VALUES (@posologie, @duree, @instruSpe, @code, @id_m, @id_p)";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@posologie", ordonnance.Posologie);
                    command.Parameters.AddWithValue("@duree", ordonnance.Duree);
                    command.Parameters.AddWithValue("@instruSpe", ordonnance.InstructionsSpe);
                    command.Parameters.AddWithValue("@code", ordonnance.Code);
                    command.Parameters.AddWithValue("@id_m", idM);
                    command.Parameters.AddWithValue("@id_p", idP);

                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }

        // add medicament in ordonnance
        public int AddMedsInOrdonnance(int idO, int idMed)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO ligne_ordonnance (id_o, id_med) VALUES (@id_o, @id_med)";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id_o", idO);
                    command.Parameters.AddWithValue("@id_med", idMed);

                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }

        // get ordonnance id with code
        public int GetIdWithCode(string code)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id_o FROM ordonnance WHERE code = @code";

                int id = 0;

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@code", code);

                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("id récupéré : " + id);
                        id = reader.GetInt32(0);
                    }
                    conn.Close();
                    return id;
                }
            }
        }
    }
}
