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
