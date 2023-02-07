using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace TechSupport.DAL
{
    /// <summary>
    /// Connection object for the TechSupport DB
    /// Author: Alyssa Harris
    /// Version: 02/06/2023
    /// </summary>
    public static class TechSupportDBConnection
    {
        #region Methods


        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=TechSupport;" +
                "Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        #endregion
    }
}
