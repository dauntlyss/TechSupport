using System;
using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// Class controller that will access the DAL to search and add incidents
    /// </summary>
    public class IncidentController
    {
        private readonly IncidentDAL _incidentSource;

        ///Creates an incidentController object to add incidents
        public IncidentController()
        {
            this._incidentSource = new IncidentDAL();
        }

        /// <summary>
        /// Returns all incidents
        /// </summary>
        public List<Incident> GetAllIncidents()
        {
            return this._incidentSource.GetAllIncidents();
        }

        /// <summary>
        /// Adds an incident to the list
        /// </summary>
        /// <param name="incident"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void Add(Incident incident)
        {
            if (incident ==  null)
            {
                throw new ArgumentNullException("Incident cannot be null.");
            }
            this._incidentSource.Add(incident);
        }

        /// <summary>
        /// Gets all the incidents with a specific customer ID
        /// </summary>
        /// <returns></returns>
        public List<Incident> GetSearchIncidents()
        {
            return this._incidentSource.GetAllSearchResults();
        }

        /// <summary>
        /// Searches incidents by customer ID
        /// </summary>
        /// <param name="customerID"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void Search(int customerID)
        {
            if (customerID < 0)
            {
                throw new ArgumentNullException("Customer ID must be greater than 0.");
            }
            this._incidentSource.Search(customerID);
        }

    }
}
