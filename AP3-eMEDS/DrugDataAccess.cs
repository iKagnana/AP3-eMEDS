using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AP3_eMEDS
{
    internal class DrugDataAccess
    {
        // get value for localhost in App.config
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;
        private List<Drug> drugs = new List<Drug>();

        public DrugDataAccess() { }

        // add drug to local list
        public void AddDrug(Drug drug) {
            this.drugs.Add(drug);
        }

        // get drugDataAccess's drugs value (drugs list)
        public List<Drug> GetDrugList() { 
            return this.drugs; 
        }

        // get selected drug with its index
        public Drug GetDrugById(int Id)
        {
            return this.drugs[Id];
        }

        // DB functions
        // add drugs to db
        public int addDrugToDB(Drug drug)
        {
            // create connection to the db to make query 
            using (MySqlConnection conn = new MySqlConnection(connectionString)) 
            { 
                conn.Open();
                string query = "INSERT INTO drugs (name, description) VALUES (@name, @description)";

                using (MySqlCommand command = new MySqlCommand(query, conn)) 
                {
                    command.Parameters.AddWithValue("@name", drug.Name);
                    command.Parameters.AddWithValue("@description", drug.Description);
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }

        // get all drugs from db
        public List<Drug> GetDrugs()
        {
            // create connection to the db to make query 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM drugs";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {

                    MySqlDataReader reader = command.ExecuteReader();
                    List<Drug> newList = new List<Drug>();
                    while (reader.Read())
                    {
                        // Console.WriteLine(reader.GetString(0) + " " + reader.GetString(1) +  " " + reader.GetString(2));
                        Drug newDrug = new Drug(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                        newList.Add(newDrug);
                    }
                    conn.Close();
                    return newList;
                }
            }
        }

        // get drug from its id 
        public Drug GetDrugFromId(int id)
        {
            // create connection to the db to make query 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM drugs WHERE id = @id";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = command.ExecuteReader();
                    Drug selectedDrug = new Drug(reader.GetString(1), reader.GetString(2));
                    conn.Close();
                    return selectedDrug;
                }
            }
        }

        // update item from its id
        public int UpdateDrugFromId(Drug updatedDrug) 
        {
            // create connection to the db to make query 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE drugs SET name = @name, description = @description WHERE id = @id";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id", updatedDrug.Id);
                    command.Parameters.AddWithValue("@name", updatedDrug.Name);
                    command.Parameters.AddWithValue("@description", updatedDrug.Description);
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }
    }
}
