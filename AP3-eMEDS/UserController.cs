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

        // function to get the string associated with enum option 
        public string GetStatus(Status status)
        {
            switch (status)
            {
                case Status.Waiting: 
                    return "En attente de validation";
                case Status.Confirmed:
                    return "Validé";
                case Status.Refused:
                    return "Refusé";
                default:
                    return "";
            }
        }

        // method create user type customer
        public int AddCustomer(Customer customer)
        {
            // create connection to the db to make query 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO users (name, siret, email, password, address, status) " +
                    "VALUES (@name, @siret, @email, @password, @address, @status)";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@name", customer.Name);
                    command.Parameters.AddWithValue("@siret", customer.Siret);
                    command.Parameters.AddWithValue("@email", customer.Email);
                    command.Parameters.AddWithValue("@password", customer.Password);
                    command.Parameters.AddWithValue("@address", customer.Address);
                    command.Parameters.AddWithValue("@status", GetStatus(customer.Status));
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

        // function to get all the user email to see if it's unique
        public bool UniqueEmail(string email)
        {
            // create connection to the db to make query 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT email FROM users WHERE email = @email";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@email", email);
                    
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        conn.Close();
                        return true;
                    } else
                    {
                        conn.Close();
                        return false;
                    }
                    
                }
            }
        }

        // login function
        public string Login(User user)
        {
            // get the data of the customer
            // create connection to the db to make query 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT email, password, status FROM users WHERE email = @email";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@email", user.Email);

                    // get data 
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    
                    string status = reader.GetString(2);
                    if (reader.GetString(0) == user.Email && 
                        reader.GetString(1) == user.Password)
                    {
                        conn.Close();

                        string message = "";

                        switch (status)
                        {
                            case "Validé":
                                message = "LoggedIn";
                                break;
                            case "En attente de validation":
                                message = "Waiting status";
                                break;
                            case "Refusé":
                                message = "Invalid status";
                                break;

                        }
                        return message;
                            
                    }
                    else
                    {
                        conn.Close();
                        return "Invalid user authentification";
                    }
                    
                }
            }
        }
    }
}
