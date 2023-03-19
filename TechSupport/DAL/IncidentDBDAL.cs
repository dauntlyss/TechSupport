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
        public Incident GetIncident(int incidentID)
        {
            Incident incident = new Incident();

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
                            {
                                incident.IncidentID = (int)reader["IncidentID"];
                                incident.CustomerId = (int)reader["CustomerID"];
                                incident.ProductCode = reader["ProductCode"].ToString();
                                incident.TechID = reader["TechID"] as int? ?? default;
                                incident.DateOpened = (DateTime)reader["DateOpened"];
                                incident.DateClosed = reader["DateClosed"] as DateTime? ?? default;
                                incident.Title = reader["Title"].ToString();
                                incident.Description = reader["Description"].ToString();
                            };
                            
                        }
                    }
                }
            }
            return incident;
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
        /// <param name="formerIncident">former Incident object</param>
        /// <param name="newIncident">new Incident object</param>
        /// <returns>boolean if incident was closed</returns>
        public bool CloseIncident(Incident formerIncident, Incident newIncident)
        {
            string updateStatement =
                "UPDATE Incidents SET " +
                "CustomerID = @NewCustomerID " +
                ", ProductCode = @NewProductCode " +
                ", TechID = @NewTechID " +
                ", DateOpened = @NewDateOpened " +
                ", DateClosed = @NewDateClosed " +
                ", Title = @NewTitle " +
                ", Description = @NewDescription " +
                "WHERE IncidentID = @FormerIncidentID " +
                "AND CustomerID = @FormerCustomerID " +
                "AND ProductCode = @FormerProductCode " +
                "AND (TechID = @FormerTechID " +
                     "OR TechID IS NULL AND @FormerTechID IS NULL) " +
                "AND DateOpened = @FormerDateOpened " +
                "AND (DateClosed = @FormerDateClosed " +
                     "OR DateClosed IS NULL AND @FormerDateClosed IS NULL) " +
                "AND Title = @FormerTitle " +
                "AND Description = @FormerDescription";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.Add("@NewCustomerID", System.Data.SqlDbType.Int);
                    updateCommand.Parameters["@NewCustomerID"].Value = newIncident.CustomerId;
                    updateCommand.Parameters.Add("@NewProductCode", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@NewProductCode"].Value = newIncident.ProductCode;

                    if (newIncident.TechID == null || newIncident.TechID == 0)
                    {
                        updateCommand.Parameters.Add("@NewTechID", SqlDbType.VarChar);
                        updateCommand.Parameters["@NewTechID"].Value = DBNull.Value;
                    }
                    else
                    {
                        updateCommand.Parameters.Add("@NewTechID", System.Data.SqlDbType.Int);
                        updateCommand.Parameters["@NewTechID"].Value = newIncident.TechID;
                    }

                    updateCommand.Parameters.Add("@NewDateOpened", System.Data.SqlDbType.DateTime);
                    updateCommand.Parameters["@NewDateOpened"].Value = newIncident.DateOpened;

                    updateCommand.Parameters.Add("@NewDateClosed", SqlDbType.DateTime);
                    updateCommand.Parameters["@NewDateClosed"].Value = DateTime.Now;

                    updateCommand.Parameters.Add("@NewTitle", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@NewTitle"].Value = newIncident.Title;

                    updateCommand.Parameters.Add("@NewDescription", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@NewDescription"].Value = newIncident.Description;

                    updateCommand.Parameters.Add("@FormerIncidentID", System.Data.SqlDbType.Int);
                    updateCommand.Parameters["@FormerIncidentID"].Value = formerIncident.IncidentID;
                    updateCommand.Parameters.Add("@FormerCustomerID", System.Data.SqlDbType.Int);
                    updateCommand.Parameters["@FormerCustomerID"].Value = formerIncident.CustomerId;
                    updateCommand.Parameters.Add("@FormerProductCode", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@FormerProductCode"].Value = formerIncident.ProductCode;

                    if (formerIncident.TechID == null || formerIncident.TechID == 0)
                    {
                        updateCommand.Parameters.Add("@FormerTechID", SqlDbType.VarChar);
                        updateCommand.Parameters["@FormerTechID"].Value = DBNull.Value;
                    }
                    else
                    {
                        updateCommand.Parameters.Add("@FormerTechID", System.Data.SqlDbType.Int);
                        updateCommand.Parameters["@FormerTechID"].Value = formerIncident.TechID;
                    }

                    updateCommand.Parameters.Add("@FormerDateOpened", System.Data.SqlDbType.DateTime);
                    updateCommand.Parameters["@FormerDateOpened"].Value = formerIncident.DateOpened;

                    if (formerIncident.DateClosed == null || formerIncident.DateClosed == DateTime.MinValue)
                    {
                        updateCommand.Parameters.Add("@FormerDateClosed", SqlDbType.VarChar);
                        updateCommand.Parameters["@FormerDateClosed"].Value = DBNull.Value;
                    }
                    else
                    {
                        updateCommand.Parameters.Add("@FormerDateClosed", System.Data.SqlDbType.DateTime);
                        updateCommand.Parameters["@FormerDateClosed"].Value = formerIncident.DateClosed;
                    }

                    updateCommand.Parameters.Add("@FormerTitle", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@FormerTitle"].Value = formerIncident.Title;

                    updateCommand.Parameters.Add("@FormerDescription", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@FormerDescription"].Value = formerIncident.Description;

                    int count = updateCommand.ExecuteNonQuery();
                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        /// <summary>
        /// This method connects to the database and runs a query to update specific fields of the incident
        /// </summary>
        /// <param name="formerIncident">Former Incident object</param>
        /// <param name="newIncident">new Incident object</param>
        public bool UpdateIncident(Incident formerIncident, Incident newIncident)
        {
            string updateStatement =
                "UPDATE Incidents SET " +
                "CustomerID = @NewCustomerID " +
                ", ProductCode = @NewProductCode " +
                ", TechID = @NewTechID " +
                ", DateOpened = @NewDateOpened " +
                ", DateClosed = @NewDateClosed " +
                ", Title = @NewTitle " +
                ", Description = @NewDescription " +
                "WHERE IncidentID = @FormerIncidentID " +
                "AND CustomerID = @FormerCustomerID " +
                "AND ProductCode = @FormerProductCode " +
                "AND (TechID = @FormerTechID " +
                     "OR TechID IS NULL AND @FormerTechID IS NULL) " +
                "AND DateOpened = @FormerDateOpened " +
                "AND (DateClosed = @FormerDateClosed " +
                     "OR DateClosed IS NULL AND @FormerDateClosed IS NULL) " +
                "AND Title = @FormerTitle " +
                "AND Description = @FormerDescription";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.Add("@NewCustomerID", System.Data.SqlDbType.Int);
                    updateCommand.Parameters["@NewCustomerID"].Value = newIncident.CustomerId;
                    updateCommand.Parameters.Add("@NewProductCode", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@NewProductCode"].Value = newIncident.ProductCode;

                    if (newIncident.TechID == null || newIncident.TechID == 0)
                    {
                        updateCommand.Parameters.Add("@NewTechID", SqlDbType.VarChar);
                        updateCommand.Parameters["@NewTechID"].Value = DBNull.Value;
                    }
                    else
                    {
                        updateCommand.Parameters.Add("@NewTechID", System.Data.SqlDbType.Int);
                        updateCommand.Parameters["@NewTechID"].Value = newIncident.TechID;
                    }

                    updateCommand.Parameters.Add("@NewDateOpened", System.Data.SqlDbType.DateTime);
                    updateCommand.Parameters["@NewDateOpened"].Value = newIncident.DateOpened;

                    if (newIncident.DateClosed == null || newIncident.DateClosed == DateTime.MinValue)
                    {
                        updateCommand.Parameters.Add("@NewDateClosed", SqlDbType.VarChar);
                        updateCommand.Parameters["@NewDateClosed"].Value = DBNull.Value;
                    }
                    else
                    {
                        updateCommand.Parameters.Add("@NewDateClosed", System.Data.SqlDbType.DateTime);
                        updateCommand.Parameters["@NewDateClosed"].Value = newIncident.DateClosed;
                    }

                    updateCommand.Parameters.Add("@NewTitle", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@NewTitle"].Value = newIncident.Title;

                    updateCommand.Parameters.Add("@NewDescription", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@NewDescription"].Value = newIncident.Description;

                    updateCommand.Parameters.Add("@FormerIncidentID", System.Data.SqlDbType.Int);
                    updateCommand.Parameters["@FormerIncidentID"].Value = formerIncident.IncidentID;
                    updateCommand.Parameters.Add("@FormerCustomerID", System.Data.SqlDbType.Int);
                    updateCommand.Parameters["@FormerCustomerID"].Value = formerIncident.CustomerId;
                    updateCommand.Parameters.Add("@FormerProductCode", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@FormerProductCode"].Value = formerIncident.ProductCode;

                    if (formerIncident.TechID == null || formerIncident.TechID == 0)
                    {
                        updateCommand.Parameters.Add("@FormerTechID", SqlDbType.VarChar);
                        updateCommand.Parameters["@FormerTechID"].Value = DBNull.Value;
                    }
                    else
                    {
                        updateCommand.Parameters.Add("@FormerTechID", System.Data.SqlDbType.Int);
                        updateCommand.Parameters["@FormerTechID"].Value = formerIncident.TechID;
                    }

                    updateCommand.Parameters.Add("@FormerDateOpened", System.Data.SqlDbType.DateTime);
                    updateCommand.Parameters["@FormerDateOpened"].Value = formerIncident.DateOpened;

                    if (formerIncident.DateClosed == null || formerIncident.DateClosed == DateTime.MinValue)
                    {
                        updateCommand.Parameters.Add("@FormerDateClosed", SqlDbType.VarChar);
                        updateCommand.Parameters["@FormerDateClosed"].Value = DBNull.Value;
                    }
                    else
                    {
                        updateCommand.Parameters.Add("@FormerDateClosed", System.Data.SqlDbType.DateTime);
                        updateCommand.Parameters["@FormerDateClosed"].Value = formerIncident.DateClosed;
                    }

                    updateCommand.Parameters.Add("@FormerTitle", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@FormerTitle"].Value = formerIncident.Title;

                    updateCommand.Parameters.Add("@FormerDescription", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@FormerDescription"].Value = formerIncident.Description;

                    int count = updateCommand.ExecuteNonQuery();
                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        /// <summary>
        /// method used to connect to the database and run a query to return the open incidents assigned
        /// </summary>
        /// <param name="techID">technician id</param>
        /// <returns>open incident assigned objects</returns>
        public List<Incident> GetOpenIncidentsWithTech(int techID)
        {
            List<Incident> incidents = new List<Incident>();

            string selectStatement = @"SELECT p.Name AS 'Product', DateOpened, c.Name as 'Customer', Title
                                       FROM Incidents AS i
                                         JOIN Customers AS c ON i.CustomerID = c.CustomerID
                                         JOIN Technicians AS t ON i.TechID = t.TechID
                                         JOIN Products AS p ON i.ProductCode = p.ProductCode
                                       WHERE t.TechID = @TechID
                                         AND DateClosed IS NULL
                                       ;";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(selectStatement, connection))
                {
                    cmd.Parameters.Add("TechID", SqlDbType.Int);
                    cmd.Parameters["TechID"].Value = techID;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Incident incident = new Incident
                            {
                                ProductCode = reader.GetString(reader.GetOrdinal("Product")),
                                DateOpened = reader.GetDateTime(reader.GetOrdinal("DateOpened")),
                                Customer = reader.GetString(reader.GetOrdinal("Customer")),
                                Title = reader.GetString(reader.GetOrdinal("Title"))
                            };

                            incidents.Add(incident);
                        }
                    }
                }
            }

            return incidents;
        }

        #endregion
    }
}
