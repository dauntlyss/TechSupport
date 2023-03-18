using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// Data Access Layer class used to access the technicians.
    /// Author: Alyssa Harris
    /// Version: 2/19/2023
    /// </summary>
    public class TechnicianDBDAL
    {
        #region Methods

        /// <summary>
        /// This method connects to the database and runs a query to return the all technicians
        /// </summary>
        /// <returns>list of all technician objects</returns>
        public List<Technician> GetAllTechnicians()
        {
            List<Technician> technicianList = new List<Technician>();

            string selectStatement =
                "SELECT * " +
                "FROM Technicians " +
                "ORDER BY Name";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Technician technician = new Technician
                            {
                                TechID = (int)reader["TechID"],
                                Name = reader["Name"].ToString(),
                                Email = reader["Email"].ToString(),
                                Phone = reader["Phone"].ToString()
                            };
                            technicianList.Add(technician);
                        }
                    }
                }
            }
            return technicianList;
        }
        /// <summary>
        /// This method connects to the database and runs a query to return all the technician's ids and names
        /// </summary>
        /// <returns>list of all technician objects with id and name</returns>
        public List<TechnicianIDAndName> GetAllTechnicianIDAndNames()
        {
            List<TechnicianIDAndName> technicianList = new List<TechnicianIDAndName>();

            string selectStatement =
                "SELECT TechID, Name " +
                "FROM Technicians " +
                "ORDER BY Name";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TechnicianIDAndName technician = new TechnicianIDAndName
                            {
                                TechID = (int)reader["TechID"],
                                Name = reader["Name"].ToString()
                            };
                            technicianList.Add(technician);
                        }
                    }
                }
            }
            return technicianList;
        }

        #endregion
    }
}
