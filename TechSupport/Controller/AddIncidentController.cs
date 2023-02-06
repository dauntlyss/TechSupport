using System;
using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// Controller class used to access the DAL to add incidents to the incidents list
    /// </summary>
    public class AddIncidentController
    {
        private readonly IncidentDAL _incidentSource;

        /// <summary>
        /// Initializes a new instance of the AddIncidentController class.
        /// </summary>
        public AddIncidentController()
        {
            this._incidentSource = new IncidentDAL();
        }

        /// <summary>
        /// This method gets all incidents
        /// </summary>
        /// <returns>A list of all the incidents</returns>
        public List<Incident> GetAllIncidents()
        {
            return this._incidentSource.GetAllIncidents();
        }

        /// <summary>
        /// Adds the specified incident.
        /// </summary>
        /// <param name="incident">The incident.</param>
        public void Add(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("Incident cannot be null.");
            }
            this._incidentSource.Add(incident);
        }
    }
}
