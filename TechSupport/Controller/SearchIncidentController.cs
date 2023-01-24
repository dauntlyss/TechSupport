using System;
using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// Controller class used to access the DAL to search incidents in the incidents list
    /// </summary>
    public class SearchIncidentController
    {
        private readonly IncidentDAL incidentSource;

        public SearchIncidentController()
        {
            this.incidentSource = new IncidentDAL();
        }

        /// <summary>
        /// Gets the search incidents.
        /// </summary>
        /// <returns>Incidents that match the search</returns>
        public List<Incident> GetSearchIncidents()
        {
            return this.incidentSource.GetAllSearchResults();
        }

        /// <summary>
        /// Searches the incidents based on the specified customer identifier.
        /// </summary>
        /// <param name="customerId">The customer identifier.</param>
        public void Search(int customerId)
        {
            if (customerId < 0)
            {
                throw new ArgumentNullException("Customer ID must be greater than 0.");
            }
            this.incidentSource.Search(customerId);
        }
    }
}
