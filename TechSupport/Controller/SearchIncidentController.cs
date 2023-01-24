using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


        public void Search(int customerId)
        {
            if (customerId < 0)
            {
                throw new ArgumentNullException("Customer ID much be greater than 0.");
            }
            this.incidentSource.Search(customerId);
        }
    }
}
