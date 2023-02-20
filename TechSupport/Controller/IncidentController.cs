using System;
using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// Class controller that will access the DAL to search and add incidents
    /// Author: Alyssa Harris
    /// Version: 2/19/23
    /// </summary>
    public class IncidentController
    {

        private readonly IncidentDBDAL _incidentDBSource;

        ///Creates an incidentController object to add incidents
        public IncidentController()
        {
            this._incidentDBSource = new IncidentDBDAL();
        }

        /// <summary>
        /// Returns all incidents
        /// </summary>
        public List<Incident> GetAllIncidents()
        {
            return this._incidentDBSource.GetAllIncidents();
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
            if (incident.CustomerId < 0)
            {
                throw new ArgumentException("CustomerID cannot be less than 0.");
            }
            if (string.IsNullOrEmpty(incident.ProductCode))
            {
                throw new ArgumentNullException("ProductCode cannot be null or empty.");
            }
            if (string.IsNullOrEmpty(incident.Title))
            {
                throw new ArgumentNullException("Title cannot be null or empty.");
            }
            if (string.IsNullOrEmpty(incident.Description))
            {
                throw new ArgumentNullException("Description cannot be null or empty.");
            }
            this._incidentDBSource.AddIncident(incident);
        }

        /// <summary>
        /// Gets all the incidents with a specific customer ID
        /// </summary>
        /// <returns></returns>
        public List<Incident> GetSearchIncidents(int customerID)
        {
            return this._incidentDBSource.GetSearchIncidents(customerID);
        }

        /// <summary>
        /// Returns open incidents from DAL
        /// </summary>
        /// <returns>A list of open incidents</returns>
        public List<OpenIncident> GetOpenIncidents()
        {
            return _incidentDBSource.GetOpenIncidents();
        }

        /// <summary>
        /// Returns the incident with a specific IncidentID
        /// </summary>
        /// <param name="incidentID">incident id</param>
        /// <returns>A list of incident objects</returns>
        public List<Incident> GetIncident(int incidentID)
        {
            if (incidentID < 1)
            {
                throw new ArgumentException("IncidentID cannot be less than 1.");
            }
            return _incidentDBSource.GetIncident(incidentID);
        }

        /// <summary>
        /// Updates specific fields of incident object
        /// </summary>
        /// <param name="incident">incident object</param>
        public void UpdateIncident(Incident incident)
        {
            if (incident.IncidentID < 1)
            {
                throw new ArgumentException("IncidentID cannot be less than 1");
            }
            if (incident.Description.Length > 200)
            {
                throw new ArgumentException("Description cannot be greater than 200");
            }
            _incidentDBSource.UpdateIncident(incident);
        }

        /// <summary>
        /// Closes the incident with a specific IncidentID
        /// </summary>
        /// <param name="incidentID">incident id</param>
        public void CloseIncident(int incidentID)
        {
            if (incidentID < 1)
            {
                throw new ArgumentException("IncidentID cannot be less than 1.");
            }
            _incidentDBSource.CloseIncident(incidentID);
        }

    }
}
