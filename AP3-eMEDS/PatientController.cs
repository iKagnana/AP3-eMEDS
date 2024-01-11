using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AP3_eMEDS
{
    internal class PatientController
    {

        // get value for localhost in App.config
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;
        private List<Patient> patients = new List<Patient>();

        // add constructor 
        public PatientController() { }

        // get patients
        public List<Patient> GetPatients()
        {
            // create connection to the db to make query 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
               
                string query = "SELECT patient.id_p, nom_p, prenom_p, sexe_p, num_secu, COUNT(id_al) as nb_allergie, COUNT(id_a) as nb_antecedent " +
                    "FROM patient " +
                    "LEFT OUTER JOIN etre ON patient.id_p = etre.id_p " +
                    "LEFT OUTER JOIN avoir ON patient.id_p = avoir.id_p " +
                    "GROUP BY prenom_p, nom_p";
                this.patients = new List<Patient>();

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Patient newDrug = new Patient(reader.GetInt32(0), 
                                                      reader.GetString(1), 
                                                      reader.GetString(2), 
                                                      reader.GetString(3), 
                                                      reader.GetString(4),
                                                      reader.GetInt32(5), 
                                                      reader.GetInt32(6));
                        patients.Add(newDrug);
                    }
                    conn.Close();
                    return patients;
                }
            }
        }

        // add patient 
        public int AddPatient(Patient patient)
        {
            // create connection to the db to make query 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO patient (nom_p, prenom_p, sexe) " +
                    "VALUES (@nom, @prenom, @sexe)";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@nom", patient.Nom);
                    command.Parameters.AddWithValue("@prenom", patient.Prenom);
                    command.Parameters.AddWithValue("@sexe", patient.Sexe);
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }

        // get patient's "numéro de sécurité sociale"
        public int GetIdPatientFromNumSecu(string numSecu)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id_p FROM patient WHERE num_secu = @num_secu";
                int result = 0;

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    MySqlDataReader reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        command.Parameters.AddWithValue("@num_secu", numSecu);
                        result = reader.GetInt32(0);
                    }
                    conn.Close();
                    return result;
                }
            }
        }

        // add patient's

        // update patient with its id
        public int UpdatePatient(Patient patient)
        {
            // create connection to the db to make query 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE patient SET nom_p = @nom, prenom_p = @prenom, sexe = @sexe WHERE id_p = @id";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id", patient.Id);
                    command.Parameters.AddWithValue("@nom", patient.Nom);
                    command.Parameters.AddWithValue("@prenom", patient.Prenom);
                    command.Parameters.AddWithValue("@sexe", patient.Sexe);
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }

        // delete patient from its id
        public int DeletePatient(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM patient WHERE id_p = @id";

                using (MySqlCommand command = new MySqlCommand(query, conn))
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
