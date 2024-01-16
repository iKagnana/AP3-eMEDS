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
    internal class AntecedentController
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        public AntecedentController() { }

        // get all antecedent
        public List<ObjetPatient> GetAntecedents()
        {
            List<ObjetPatient> antecedents = new List<ObjetPatient>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM antecedent";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        MySqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            antecedents.Add(new ObjetPatient(reader.GetInt32(0), reader.GetString(1)));
                        }
                        conn.Close();
                        return antecedents;
                    }
                }
            } catch (MySqlException e)
            {
                ErrorHandler handler = new ErrorHandler(e);
                Console.WriteLine(handler.GetMessageError());
                MessageBox.Show("Impossible de récupérer la liste des antécédents pour le moment.");
                return antecedents;
            }
        }

        // add antecedent
        public RequestStatus AddAntecedent(ObjetPatient antecedent)
        {
            RequestStatus status = new RequestStatus();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO antecedent (libelle_a) VALUES (@libelle)";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@libelle", antecedent.Libelle);
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

        // update antecedent from its id
        public RequestStatus UpdateAntecedent(ObjetPatient antecedent)
        {
            RequestStatus status = new RequestStatus();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE antecedent SET libelle_a = @libelle WHERE id_a = @id";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@libelle", antecedent.Libelle);
                        command.Parameters.AddWithValue("@id", antecedent.Id);
                        int result = command.ExecuteNonQuery();
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

        // delete antecedent from its id 
        public RequestStatus DeleteAntecedent(int id)
        {
            RequestStatus status = new RequestStatus();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM antecedent WHERE id_a = @id";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        int result = command.ExecuteNonQuery();
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
