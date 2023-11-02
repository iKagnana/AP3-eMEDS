using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AP3_eMEDS
{
    internal class UserController
    {
        // get value for localhost in App.config
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        public UserController() { }

        // method create user type customer
        public int AddCustomer(Customer customer)
        {
            // create connection to the db to make query 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO users (name, siret, email, password, address) " +
                    "VALUES (@name, @siret, @email, @password, @address)";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@name", customer.Name);
                    command.Parameters.AddWithValue("@siret", customer.Siret);
                    command.Parameters.AddWithValue("@email", customer.Email);
                    command.Parameters.AddWithValue("@password", customer.Password);
                    command.Parameters.AddWithValue("@address", customer.Address);
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }

        // method create user type employee
        public int AddEmployee(Employee employee)
        {
            // create connection to the db to make query 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO users (lastname, firstname, email, password, address) " +
                    "VALUES (@lastname, @firstname, @email, @password, @address)";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@name", employee.Lastname);
                    command.Parameters.AddWithValue("@siret", employee.FirstName);
                    command.Parameters.AddWithValue("@email", employee.Email);
                    command.Parameters.AddWithValue("@password", employee.Password);
                    command.Parameters.AddWithValue("@address", employee.Address);
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }

        // login function
        public bool Login(User user)
        {
            // get the data of the customer
            // create connection to the db to make query 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT email, password FROM users WHERE id = @id";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id", user.Id);

                    // get data 
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.GetString(0) == user.Email && reader.GetString(1) == user.Password)
                    {
                        conn.Close();
                        return true;
                    }
                    else
                    {
                        conn.Close();
                        return false;
                    }
                    
                }
            }
        }
    }
}
