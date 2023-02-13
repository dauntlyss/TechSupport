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
