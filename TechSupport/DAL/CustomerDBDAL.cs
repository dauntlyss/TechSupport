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
        #region Methods

        /// <summary>
        /// This method connects to the database and runs a query to return customer by customerID
        /// </summary>
        /// <param name="customerID">customer id</param>
        /// <returns>single customer in list that matches the customerID</returns>
        public List<Customer> GetCustomer(int customerID)
        {
            List<Customer> customerList = new List<Customer>();

            string selectStatement =
                "SELECT * " +
                "FROM Customers " +
                "WHERE " +
                "CustomerID = @customerID";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@customerID", System.Data.SqlDbType.Int);
                    selectCommand.Parameters["@customerID"].Value = customerID;
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Customer customer = new Customer
                            {
                                CustomerID = (int)reader["CustomerID"],
                                Name = reader["Name"].ToString(),
                                Address = reader["Address"].ToString(),
                                City = reader["City"].ToString(),
                                State = reader["State"].ToString(),
                                ZipCode = reader["ZipCode"].ToString(),
                                Phone = reader["Phone"].ToString(),
                                Email = reader["Email"].ToString()
                            };
                            customerList.Add(customer);
                        }
                    }
                }
            }
            return customerList;
        }

        /// <summary>
        /// This method connect to the DB and runs a query to return the customer ID and names
        /// </summary>
        /// <returns>A list of al customer's ids and names</returns>
        public List<CustomerIdAndName> GetAllCustomerIdAndNames()
        {
            string selectStatement =
                "SELECT CustomerID, Name " +
                "FROM Customers " +
                "ORDER BY Name";
            return ProcessIDAndNameList(selectStatement);
        }

        private static List<CustomerIdAndName> ProcessIDAndNameList(string sql)
        {
            List<CustomerIdAndName> customerList = new List<CustomerIdAndName>();
            string selectStatement = sql;
            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CustomerIdAndName customer = new CustomerIdAndName
                            {
                                CustomerID = (int)reader["CustomerID"],
                                Name = reader["Name"].ToString()
                            };
                            customerList.Add(customer);
                        }
                    }
                }
            }
            return customerList;
        }
        #endregion
    }
}
