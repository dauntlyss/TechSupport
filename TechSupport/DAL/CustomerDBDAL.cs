using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL

{
    /// <summary>
    /// DAL to access all customers in the DB
    /// Author: Alyssa Harris
    /// Version: 02/13/2023
    /// </summary>
    public class CustomerDBDAL
    {
        /// <summary>
        /// Retrieves all of the Customers on the Customers table in the TechSupport database.
        /// </summary>
        /// <returns>List containing all Customers in TechSupport database</returns>
        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();

            string selectStatement = "SELECT CustomerID, Name FROM Customers";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Customer customer = new Customer
                            {
                                CustomerID = reader.GetInt32(reader.GetOrdinal("CustomerID")),
                                Name = reader.GetString(reader.GetOrdinal("Name"))
                            };

                            customers.Add(customer);
                        }
                    }
                }
            }

            return customers;
        }
    }
}

