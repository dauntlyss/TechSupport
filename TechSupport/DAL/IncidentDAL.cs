using System;
using System.Collections.Generic;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// Data Access Layer clcass used to access all incidents
    /// </summary>
    public class IncidentDAL
    {
        #region Data Members
        private static List<Incident> _incidents = new List<Incident>();

        #endregion

        #region Methods
        /// <summary>
        /// Gets all incidents.
        /// </summary>
        /// <returns>List of all incidences</returns>
        public List<Incident> GetAllIncidents()
        {
            return _incidents;
        }

        /// <summary>
        /// Adds the specified incident.
        /// </summary>
        /// <param name="incident">The incident.</param>
        /// <exception cref="ArgumentNullException">Incident cannot be null.</exception>
        public void Add(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("Incident cannot be null.");
            }
            _incidents.Add(incident);
        }

        /// <summary>
        /// Searches for all incidents under the inputed customer id
        /// </summary>
        /// <param name="customerId"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public List<Incident> Search(int customerId)
        {
            if (customerId < 0)
            {
                throw new ArgumentNullException("CustomerId cannot be less than 0");
            }

            return _incidents.FindAll(item => item.CustomerId == customerId);
        }
        #endregion
    }
}
