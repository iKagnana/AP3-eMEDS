﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AP3_eMEDS
{
    internal class MedicamentController
    {
        // get value for localhost in App.config
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;
        private List<Medicament> drugs = new List<Medicament>();

        public MedicamentController() { }

        // add drug to local list
        public void AddDrug(Medicament drug) {
            this.drugs.Add(drug);
        }

        // get drugDataAccess's drugs value (drugs list)
        public List<Medicament> GetDrugList() { 
            return this.drugs; 
        }

        // get selected drug with its index
        public Medicament GetDrugById(int Id)
        {
            return this.drugs[Id];
        }

        // DB functions
        // add drugs to db
        public int AddMedicament(Medicament drug)
        {
            // create connection to the db to make query 
            using (MySqlConnection conn = new MySqlConnection(connectionString)) 
            { 
                conn.Open();
                string query = "INSERT INTO medicament (libelle_med, contre_indication) " +
                    "VALUES (@libelle, @contre_indication)";

                using (MySqlCommand command = new MySqlCommand(query, conn)) 
                {
                    command.Parameters.AddWithValue("@libelle", drug.Libelle);
                    command.Parameters.AddWithValue("@contre_indication", drug.ContreIndication);
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }

        // add incompatibility with allergy 
        public int AddIncompatibilityAllergy(int idMed, int idAl)
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
                    return result;
                }
            }
        }

        // add incompatibility with allergy 
        public int AddIncompatibilityAntecedent(int idMed, int idAn)
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
                    return result;
                }
            }
        }

        // add incompatibility with allergy 
        public int AddIncompatibilityMedicament(int idMed, int idMedSec)
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
                    return result;
                }
            }
        }

        // get all drugs from db
        public List<Medicament> GetMedicaments()
        {
            // create connection to the db to make query 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM medicament";
                this.drugs = new List<Medicament>();

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {

                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        // Console.WriteLine(reader.GetString(0) + " " + reader.GetString(1) +  " " + reader.GetString(2));
                        Medicament newDrug = new Medicament(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                        drugs.Add(newDrug);
                    }
                    conn.Close();
                    return drugs;
                }
            }
        }

        // get all incompatible allergies
        public List<ObjetPatient> GetAllergies(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT incompatible.id_al, libelle_al FROM incompatible " +
                    "INNER JOIN medicament ON medicament.id_med = incompatible.id_med " +
                    "INNER JOIN allergie ON allergie.id_al = incompatible.id_al " +
                    "WHERE incompatible.id_al IS NOT NULL and incompatible.id_med = @id_med";

                List<ObjetPatient> allergies = new List<ObjetPatient>();

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id_med", id);
                    MySqlDataReader reader = command.ExecuteReader();

                    while(reader.Read())
                    {
                        allergies.Add(new ObjetPatient(reader.GetInt32(0), reader.GetString(1)));
                    }

                    conn.Close();
                    return allergies;
                }
            }
        }

        // get all incompatible antecedent
        public List<ObjetPatient> GetAntecedents(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT incompatible.id_a, libelle_a FROM incompatible " +
                    "INNER JOIN medicament ON medicament.id_med = incompatible.id_med " +
                    "INNER JOIN antecedent ON antecedent.id_a = incompatible.id_al " +
                    "WHERE incompatible.id_a IS NOT NULL and incompatible.id_med = @id_med";

                List<ObjetPatient> antecedent = new List<ObjetPatient>();

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

        // get all incompatible medecament
        public List<ObjetPatient> GetIncompatibleMedicament(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT incompatible.id_med_Medicament, libelle_med FROM incompatible " +
                    "INNER JOIN medicament ON medicament.id_med = incompatible.id_med " +
                    "WHERE incompatible.id_a IS NOT NULL and incompatible.id_med = @id_med";

                List<ObjetPatient> medicament = new List<ObjetPatient>();

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id_med", id);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        medicament.Add(new ObjetPatient(reader.GetInt32(0), reader.GetString(1)));
                    }

                    conn.Close();
                    return medicament;
                }
            }
        }

        // update item from its id
        public int UpdateMedicamentFromId(Medicament updatedDrug) 
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
                    return result;
                }
            }
        }

        // delete item from its id
        public int DeleteMedicamentFromId(int id)
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
                    return result;
                }

            }
        }


    }
}
