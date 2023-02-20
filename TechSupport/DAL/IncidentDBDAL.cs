using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// DAL used to acccess the DB TechSupport
    /// Author: Alyssa Harris
    /// Version: 2/13/23
    /// </summary>
    public class IncidentDBDAL
    {
        #region Methods

        /// <summary>
        /// This method connects to the database and runs a query to add incident
        /// </summary>
        /// <param name="customerID"> customer id</param>
        /// <param name="productCode">product code</param>
        /// <param name="title">incident title</param>
        /// <param name="description">incident description</param>
        public void AddIncident(Incident incident)
        {
            string insertStatement =
                "INSERT Incidents " +
                  "(CustomerID, ProductCode, TechID, DateOpened, DateClosed, Title, Description) " +
                "VALUES (@customerID, @productCode, @techID, @dateOpened, @dateClosed, @title, @description)";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.Add("@customerID", System.Data.SqlDbType.Int);
                    insertCommand.Parameters["@customerID"].Value = incident.CustomerId;
                    insertCommand.Parameters.Add("@productCode", System.Data.SqlDbType.VarChar);
                    insertCommand.Parameters["@productCode"].Value = incident.ProductCode;
                    insertCommand.Parameters.Add("@techID", System.Data.SqlDbType.Int);
                    insertCommand.Parameters["@techID"].Value = DBNull.Value;
                    insertCommand.Parameters.Add("@dateOpened", System.Data.SqlDbType.DateTime);
                    insertCommand.Parameters["@dateOpened"].Value = DateTime.Now;
                    insertCommand.Parameters.Add("@dateClosed", System.Data.SqlDbType.DateTime);
                    insertCommand.Parameters["@dateClosed"].Value = DBNull.Value;
                    insertCommand.Parameters.Add("@title", System.Data.SqlDbType.VarChar);
                    insertCommand.Parameters["@title"].Value = incident.Title;
                    insertCommand.Parameters.Add("@description", System.Data.SqlDbType.VarChar);
                    insertCommand.Parameters["@description"].Value = incident.Description;
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// This method connects database and runs a query to return incident by incidentID
        /// </summary>
        /// <param name="incidentID">incident id</param>
        /// <returns>A single incident object in list</returns>
        public List<Incident> GetIncident(int incidentID)
        {
            List<Incident> incidentList = new List<Incident>();

            string selectStatement =
                "SELECT * " +
                "FROM Incidents " +
                "WHERE " +
                "IncidentID = @incidentID";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@incidentID", System.Data.SqlDbType.Int);
                    selectCommand.Parameters["@incidentID"].Value = incidentID;
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Incident incident = new Incident
                            {
                                IncidentID = (int)reader["IncidentID"],
                                CustomerId = (int)reader["CustomerID"],
                                ProductCode = reader["ProductCode"].ToString(),
                                TechID = reader["TechID"] as int? ?? default,
                                DateOpened = (DateTime)reader["DateOpened"],
                                DateClosed = reader["DateClosed"] as DateTime? ?? default,
                                Title = reader["Title"].ToString(),
                                Description = reader["Description"].ToString()
                            };
                            incidentList.Add(incident);
                        }
                    }
                }
            }
            return incidentList;
        }

        /// <summary>
        /// This method connects to the database and runs a query to return search incidents by customerID
        /// </summary>
        /// <param name="customerID">customer id</param>
        /// <returns>list of searched incidents</returns>
        public List<Incident> GetSearchIncidents(int customerID)
        {
            List<Incident> searchIncidentList = new List<Incident>();

            string selectStatement =
                "SELECT " +
                "CustomerID" +
                ", ProductCode" +
                ", Title " +
                ", Description " +
                "FROM Incidents " +
                "WHERE " +
                "CustomerID = @customerID " +
                "ORDER BY IncidentID";

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
                            Incident incident = new Incident
                            {
                                CustomerId = (int)reader["CustomerID"],
                                ProductCode = reader["ProductCode"].ToString(),
                                Title = reader["Title"].ToString(),
                                Description = reader["Description"].ToString()
                            };
                            searchIncidentList.Add(incident);
                        }
                    }
                }
            }
            return searchIncidentList;
        }

        /// <summary>
        /// method used to connect to the database and run a query to return all incidents
        /// </summary>
        /// <returns>all incidents list</returns>
        public List<Incident> GetAllIncidents()
        {
            List<Incident> allIncidentList = new List<Incident>();

            string selectStatement =
                "SELECT " +
                "CustomerID" +
                ", ProductCode" +
                ", Title " +
                ", Description " +
                "FROM Incidents " +
                "ORDER BY IncidentID";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Incident incident = new Incident
                            {
                                CustomerId = (int)reader["CustomerID"],
                                ProductCode = reader["ProductCode"].ToString(),
                                Title = reader["Title"].ToString(),
                                Description = reader["Description"].ToString()
                            };
                            allIncidentList.Add(incident);
                        }
                    }
                }
            }
            return allIncidentList;
        }

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

        /// <summary>
        /// This method connects to the database and runs a query to update incident to closed status
        /// </summary>
        /// <param name="incidentID"> The incident id</param>
        public void CloseIncident(int incidentID)
        {
            string updateStatement =
                "UPDATE Incidents SET " +
                "DateClosed = @time " +
                "WHERE IncidentID = @incidentID";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.Add("@incidentID", System.Data.SqlDbType.Int);
                    updateCommand.Parameters["@incidentID"].Value = incidentID;
                    updateCommand.Parameters.Add("@time", System.Data.SqlDbType.Date);
                    updateCommand.Parameters["@time"].Value = DateTime.Now;
                    updateCommand.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// This method connects to the database and runs a query to update specific fields of the incident
        /// </summary>
        /// <param name="incident">incident object</param>
        public void UpdateIncident(Incident incident)
        {
            string updateStatement =
                "UPDATE Incidents SET " +
                "TechID = @techID " +
                ", Description = @description " +
                "WHERE IncidentID = @incidentID";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.Add("@incidentID", System.Data.SqlDbType.Int);
                    updateCommand.Parameters["@incidentID"].Value = incident.IncidentID;
                    updateCommand.Parameters.Add("@description", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@description"].Value = incident.Description;

                    if (incident.TechID == null || incident.TechID == 0)
                    {
                        updateCommand.Parameters.Add("@techID", SqlDbType.VarChar);
                        updateCommand.Parameters["@techID"].Value = DBNull.Value;
                    }
                    else
                    {
                        updateCommand.Parameters.Add("@techID", System.Data.SqlDbType.Int);
                        updateCommand.Parameters["@techID"].Value = incident.TechID;
                    }

                    updateCommand.ExecuteNonQuery();
                }
            }
        }

        #endregion
    }
}
