using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AP3_eMEDS
{
    internal class MedicamentController
    {
        // get value for localhost in App.config
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        public MedicamentController() { }

        public RequestStatus AddMedicament(Medicament med)
        {
            RequestStatus status = new RequestStatus();
            try
            {
                // create connection to the db to make query 
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO medicament (libelle_med, contre_indication) " +
                        "VALUES (@libelle, @contre_indication)";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@libelle", med.Libelle);
                        command.Parameters.AddWithValue("@contre_indication", med.ContreIndication);
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

        // add incompatibility with allergy 
        public RequestStatus AddIncompatibilityAllergy(int idMed, int idAl)
        {
            RequestStatus status = new RequestStatus();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO incompatible (id_al, id_med) VALUES (@id_al, @id_med)";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id_al", idAl);
                        command.Parameters.AddWithValue("@id_med", idMed);

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

        // add incompatibility with allergy 
        public RequestStatus AddIncompatibilityAntecedent(int idMed, int idAn)
        {
            RequestStatus status = new RequestStatus();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO incompatible (id_an, id_med) VALUES (@id_a, @id_med)";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id_al", idAn);
                        command.Parameters.AddWithValue("@id_med", idMed);

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

        // add incompatibility with allergy 
        public RequestStatus AddIncompatibilityMedicament(int idMed, int idMedSec)
        {
            RequestStatus status = new RequestStatus();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO incompatible (id_med_Medicament, id_med) VALUES (@id_medSec, @id_med)";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id_medSec", idMedSec);
                        command.Parameters.AddWithValue("@id_med", idMed);

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

        // get all medicaments from db
        public List<Medicament> GetMedicaments()
        {
            List<Medicament> medicament = new List<Medicament>();
            try
            {
                // create connection to the db to make query 
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM medicament";
                    

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {

                        MySqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            // Console.WriteLine(reader.GetString(0) + " " + reader.GetString(1) +  " " + reader.GetString(2));
                            medicament.Add(new Medicament(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                        }
                        conn.Close();
                        return medicament;
                    }
                }
            } catch (MySqlException e)
            {
                ErrorHandler handler = new ErrorHandler(e);
                Console.WriteLine(handler.GetMessageError());
                MessageBox.Show("Impossible de récupérer la liste des médicaments pour le moment.");
                return medicament;
            }
        }

        // get all incompatible allergies
        public List<ObjetPatient> GetAllergies(int id)
        {
            List<ObjetPatient> allergies = new List<ObjetPatient>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT incompatible.id_al, libelle_al FROM incompatible " +
                        "INNER JOIN medicament ON medicament.id_med = incompatible.id_med " +
                        "INNER JOIN allergie ON allergie.id_al = incompatible.id_al " +
                        "WHERE incompatible.id_al IS NOT NULL and incompatible.id_med = @id_med";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id_med", id);
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
                MessageBox.Show("Impossible de récupérer les allergies incompatibles avec ce médicament pour le moment.");
                return allergies;
            }
        }

        // get all incompatible antecedent
        public List<ObjetPatient> GetAntecedents(int id)
        {
            List<ObjetPatient> antecedent = new List<ObjetPatient>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT incompatible.id_a, libelle_a FROM incompatible " +
                        "INNER JOIN medicament ON medicament.id_med = incompatible.id_med " +
                        "INNER JOIN antecedent ON antecedent.id_a = incompatible.id_al " +
                        "WHERE incompatible.id_a IS NOT NULL and incompatible.id_med = @id_med";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id_med", id);
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            antecedent.Add(new ObjetPatient(reader.GetInt32(0), reader.GetString(1)));
                        }

                        conn.Close();
                        return antecedent;
                    }
                }
            } catch (MySqlException e)
            {
                ErrorHandler handler = new ErrorHandler(e);
                Console.WriteLine(handler.GetMessageError());
                MessageBox.Show("Impossible de récupérer les antécédents incompatibles avec ce médicament pour le moment.");
                return antecedent;
            }
        }

        // get all incompaible meds
        public List<ObjetPatient> GetIncompatibleMedicament(int id)
        {
            List<ObjetPatient> antecedent = new List<ObjetPatient>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT incompatible.id_med_Medicament, libelle_med FROM incompatible " +
                     "INNER JOIN medicament ON medicament.id_med = incompatible.id_med_Medicament " +
                     "WHERE incompatible.id_med_Medicament IS NOT NULL and incompatible.id_med = @id_med";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id_med", id);
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            antecedent.Add(new ObjetPatient(reader.GetInt32(0), reader.GetString(1)));
                        }

                        conn.Close();
                        return antecedent;
                    }
                }
            }
            catch (MySqlException e)
            {
                ErrorHandler handler = new ErrorHandler(e);
                Console.WriteLine(handler.GetMessageError());
                MessageBox.Show("Impossible de récupérer les médicaments incompatibles avec ce médicament pour le moment.");
                return antecedent;
            }
        }

        // return true if incompatibily 
        public RequestStatus GetIncompatibilityAllergy(int id_al, int id_med)
        {
            RequestStatus status = new RequestStatus();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id_med FROM incompatible WHERE id_med = @id_med and id_al = @id_al";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id_al", id_al);
                        command.Parameters.AddWithValue("@id_med", id_med);


                        if (Convert.ToInt32(command.ExecuteScalar()) > 0)
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

        // return true if incompatibily 
        public RequestStatus GetIncompatibilityAntecedent(int id_a, int id_med)
        {
            RequestStatus status = new RequestStatus();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id_med FROM incompatible WHERE id_med = @id_med and id_a = @id_a";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id_a", id_a);
                        command.Parameters.AddWithValue("@id_med", id_med);


                        if (Convert.ToInt32(command.ExecuteScalar()) > 0)
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

        // return true if incompatibily 
        public RequestStatus GetIncompatibilityMedicament(int id_med, int id_med_two)
        {
            RequestStatus status = new RequestStatus();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id_med FROM incompatible WHERE id_med = @id_med and id_med_Medicament = @id_med_two";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id_med", id_med);
                        command.Parameters.AddWithValue("@id_med_two", id_med_two);


                        if (Convert.ToInt32(command.ExecuteScalar()) > 0)
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

        // update item from its id
        public RequestStatus UpdateMedicamentFromId(Medicament updatedDrug) 
        {
            RequestStatus status = new RequestStatus();
            try
            {
                // create connection to the db to make query 
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE medicament SET libelle_med = @libelle, contre_indication = @contre_indication WHERE id_med = @id";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id", updatedDrug.Id);
                        command.Parameters.AddWithValue("@libelle", updatedDrug.Libelle);
                        command.Parameters.AddWithValue("@contre_indication", updatedDrug.ContreIndication);
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

        // delete item from its id
        public RequestStatus DeleteMedicamentFromId(int id)
        {
            RequestStatus status = new RequestStatus();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM medicament WHERE id_med = @id";

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

        // delete allergy for incompatibility
        public RequestStatus DeleteAllergyIncompatibility(int idAl, int idMed)
        {
            RequestStatus status = new RequestStatus();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM incompatible WHERE id_al = @id_al and id_med = @id_med";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id_al", idAl);
                        command.Parameters.AddWithValue("@id_med", idMed);

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

        // delete antecedent for incompatibility
        public RequestStatus DeleteAntecedentIncompatibility(int idA, int idMed)
        {
            RequestStatus status = new RequestStatus();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM incompatible WHERE id_a = @id_a and id_med = @id_med";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id_a", idA);
                        command.Parameters.AddWithValue("@id_med", idMed);

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

        // delete medicament for incompatibility
        public RequestStatus DeleteMedicamentIncompatibility(int idMedTwo, int idMed)
        {
            RequestStatus status = new RequestStatus();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM incompatible WHERE id_med_Medicament = @id_medTwo and id_med = @id_med";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id_medTwo", idMedTwo);
                        command.Parameters.AddWithValue("@id_med", idMed);

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
