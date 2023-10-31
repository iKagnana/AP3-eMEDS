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
                string query = "INSERT INTO Drugs (name, description) VALUES (@name, @description)";

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

    }
}
