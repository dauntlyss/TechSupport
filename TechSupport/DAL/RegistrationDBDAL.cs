using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// This is a data layer class that is used to access registrations from the DB
    /// Author: Alyssa Harris
    /// Version: 2/13/23
    /// </summary>
    public class RegistrationDBDAL
    {
        #region Methods

        /// <summary>
        /// This method connects to the database and runs a query to return the customers names
        /// </summary>
        /// <returns>A list of all customer's names</returns>
        public List<Registration> GetAllRegistrations()
        {
            string selectStatement =
                "SELECT * " +
                "FROM Registrations " +
                "ORDER BY CustomerID, ProductCode";
            return ProcessList(selectStatement);
        }

        private List<Registration> ProcessList(string sql)
        {
            List<Registration> registrationList = new List<Registration>();
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
                            Registration registration = new Registration
                            {
                                CustomerID = (int)reader["CustomerID"],
                                ProductCode = reader["ProductCode"].ToString(),
                                RegistrationDate = (DateTime)reader["RegistrationDate"]
                            };
                            registrationList.Add(registration);
                        }
                    }
                }
            }
            return registrationList;
        }

        /// <summary>
        /// This method calls the stored procedure spIsCustomerProductRegistered
        /// </summary>
        /// <param name="customerID">customer ID</param>
        /// <param name="productCode">product code</param>
        /// <returns>boolean of true/false if customer is registered</returns>
        public Boolean IsCustomerProductRegistered(int customerID, string productCode)
        {
            Boolean registered;

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand
                {
                    Connection = connection,
                    CommandText = "spIsCustomerProductRegistered",
                    CommandType = CommandType.StoredProcedure
                })
                {
                    selectCommand.Parameters.Add("@CustomerID", SqlDbType.Int);
                    selectCommand.Parameters["@CustomerID"].Value = customerID;
                    selectCommand.Parameters.Add("@ProductCode", SqlDbType.VarChar);
                    selectCommand.Parameters["@ProductCode"].Value = productCode;
                    using (SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        if (reader.HasRows)
                        {
                            registered = true;
                        }
                        else
                        {
                            registered = false;
                        }
                        return registered;
                    }
                }
            }
        }

        #endregion
    }
}
