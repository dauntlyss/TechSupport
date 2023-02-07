using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// DAL used to acccess the DB TechSupport
    /// Author: Alyssa Harris
    /// Version: 2/6/23
    /// </summary>
    public class IncidentDBDAL
    {
        #region Methods

        /// <summary>
        /// method used to connect to the database and run a query to return the open incidents
        /// </summary>
        /// <returns>list of open incidents</returns>
        public List<OpenIncident> GetOpenIncidents()
        {
            List<OpenIncident> openIncidentList = new List<OpenIncident>();

            string selectStatement =
                "SELECT " +
                "INC.ProductCode" +
                ", INC.DateOpened" +
                ", ISNULL(CUS.Name, '') AS Customer" +
                ", ISNULL(TEC.Name, '') AS Technician" +
                ", INC.Title " +
                "FROM Incidents INC " +
                "LEFT JOIN Customers CUS " +
                "    ON INC.CustomerID = CUS.CustomerID " +
                "LEFT JOIN Technicians TEC " +
                "    ON INC.TechID = TEC.TechID " +
                "WHERE " +
                "INC.DateClosed IS NULL " +
                "AND INC.DateOpened IS NOT NULL " +
                "ORDER BY INC.DateOpened";

            try
            {
                using (SqlConnection connection = TechSupportDBConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                OpenIncident openIncident = new OpenIncident
                                {
                                    ProductCode = reader["ProductCode"].ToString(),
                                    DateOpened = (DateTime)reader["DateOpened"],
                                    Customer = reader["Customer"].ToString(),
                                    Technician = reader["Technician"].ToString(),
                                    Title = reader["Title"].ToString()
                                };
                                openIncidentList.Add(openIncident);
                            }
                        }
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            return openIncidentList;
        }

        #endregion
    }
}
