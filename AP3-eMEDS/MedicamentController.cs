using System;
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
