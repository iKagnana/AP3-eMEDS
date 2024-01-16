using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace AP3_eMEDS
{
    internal class PatientController
    {

        // get value for localhost in App.config
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        // add constructor 
        public PatientController() { }

        // get patients
        public List<Patient> GetPatients()
        {
            List<Patient> patients = new List<Patient>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT patient.id_p, nom_p, prenom_p, sexe_p, num_secu, COUNT(id_al) as nb_allergie, COUNT(id_a) as nb_antecedent " +
                        "FROM patient " +
                        "LEFT OUTER JOIN etre ON patient.id_p = etre.id_p " +
                        "LEFT OUTER JOIN avoir ON patient.id_p = avoir.id_p " +
                        "GROUP BY prenom_p, nom_p";

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
            } catch (MySqlException e)
            {
                ErrorHandler handler = new ErrorHandler(e);
                Console.WriteLine(handler.GetMessageError());
                MessageBox.Show("Impossible de récupérer les patients pour le moment.");
                return patients;
            }
        }

        // add patient 
        public RequestStatus AddPatient(Patient patient)
        {
            RequestStatus status = new RequestStatus();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO patient (nom_p, prenom_p, sexe_p, num_secu) " +
                        "VALUES (@nom, @prenom, @sexe, @num_secu)";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@nom", patient.Nom);
                        command.Parameters.AddWithValue("@prenom", patient.Prenom);
                        command.Parameters.AddWithValue("@sexe", patient.Sexe);
                        command.Parameters.AddWithValue("@num_secu", patient.NumSecu);
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

        // get patient's "numéro de sécurité sociale"
        public int GetIdPatientFromNumSecu(string numSecu)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id_p FROM patient WHERE num_secu = @num_secu";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@num_secu", numSecu);
                        conn.Close();
                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            } catch (MySqlException e)
            {
                ErrorHandler handler = new ErrorHandler(e);
                Console.WriteLine(handler.GetMessageError());
                return 0;
            }
        }

        // get patient's allergies
        public List<ObjetPatient> GetPatientAllergies(int id)
        {
            List<ObjetPatient> allergies = new List<ObjetPatient>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT allergie.id_al, libelle_al FROM patient " +
                        "INNER JOIN etre ON patient.id_p = etre.id_p " +
                        "INNER JOIN allergie ON etre.id_al = allergie.id_al " +
                        "WHERE patient.id_p = @id";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id", id);

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
                MessageBox.Show("Impossible de récupérer les allergies du patient pour le moment.");
                return allergies;
            }
        }
        // get patient's antecedent
        public List<ObjetPatient> GetPatientAntecedents(int id)
        {
            List<ObjetPatient> antecedents = new List<ObjetPatient>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT antecedent.id_a, libelle_a FROM patient " +
                        "INNER JOIN avoir ON patient.id_p = avoir.id_p " +
                        "INNER JOIN antecedent ON avoir.id_a = antecedent.id_a " +
                        "WHERE patient.id_p = @id";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id", id);

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
                MessageBox.Show("Impossible de récupérer les antécédents du patient pour le moment.");
                return antecedents;
            }
        }


        // add patient's allergy 
        public RequestStatus AddAllergyToPatient(int idAl, int idP)
        {
            RequestStatus status = new RequestStatus();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO etre (id_al, id_p) VALUES (@id_al, @id_p)";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id_al", idAl);
                        command.Parameters.AddWithValue("@id_p", idP);

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

        public RequestStatus AddAntecedentToPatient(int idA, int idP)
        {
            RequestStatus status = new RequestStatus();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO avoir (id_a, id_p) VALUES (@id_a, @id_p)";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id_a", idA);
                        command.Parameters.AddWithValue("@id_p", idP);

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

        // update patient with its id
        public RequestStatus UpdatePatient(Patient patient)
        {
            RequestStatus status = new RequestStatus();
            try
            {
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

        // delete patient from its id
        public RequestStatus DeletePatient(int id)
        {
            RequestStatus status = new RequestStatus();
            try
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

        // delete patient allergy
        public RequestStatus DeletePatientAllergy(int idP, int idAl)
        {
            RequestStatus status = new RequestStatus();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM etre WHERE id_al = @id_al and id_p = @id_p";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id_al", idAl);
                        command.Parameters.AddWithValue("@id_p", idP);

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

        // delete patient antecedent
        public RequestStatus DeletePatientAntecedent(int idP, int idAn)
        {
            RequestStatus status = new RequestStatus();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM avoir WHERE id_a = @id_a and id_p = @id_p";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id_a", idAn);
                        command.Parameters.AddWithValue("@id_p", idP);

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
