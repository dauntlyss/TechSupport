using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// Data Access Layer clcass used to access all incidents
    /// </summary>
    public class IncidentDAL
    {
        private static List<Incident> _incidents = new List<Incident>
        {
            new Incident(5489, "Issue Logging In", "When I try to log in, it give me and invalid error."),
            new Incident(3295, "Need to change password", "My password is my ex-husbands name and I need to change it."),
            new Incident(2300, "Help Changing Username", "I need to change my username so I can build a brand."),
            new Incident(1689, "App is slow", "When I use the app it is slow, speed it up.")
        };

        private List<Incident> _searchResults = new List<Incident>();

        /// <summary>
        /// Gets all incidents.
        /// </summary>
        /// <returns>List of all incidences</returns>
        public List<Incident> GetAllIncidents()
        {
            return _incidents;
        }

        /// <summary>
        /// Gets all search results.
        /// </summary>
        /// <returns>List of all search results</returns>
        public List<Incident> GetAllSearchResults()
        {
            return _searchResults;
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


        public void Search(int customerId)
        {
            _searchResults.Clear();
            if (customerId < 0)
            {
                throw new ArgumentNullException("CustomerId cannot be less than 0");
            }

            foreach (var incident in _incidents)
            {
                if (incident.CustomerId == customerId)
                {
                    _searchResults.Add(incident);
                }
            }
        }

    }
}
