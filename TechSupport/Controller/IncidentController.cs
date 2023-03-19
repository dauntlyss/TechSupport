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
        /// <returns>All search incidents </returns>
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
        /// <returns>an incident</returns>
        public Incident GetIncident(int incidentID)
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
        public bool UpdateIncident(Incident formerIncident, Incident newIncident)
        {
            if (formerIncident.IncidentID < 1)
            {
                throw new ArgumentException("Former Incident cannot be less than 1");
            }
            if (formerIncident.Description.Length > 200)
            {
                throw new ArgumentException("Former Incident's description cannot be greater than 200 characters");
            }
            if (newIncident.IncidentID < 1)
            {
                throw new ArgumentException("New IncidentID cannot be less than 1");
            }
            if (newIncident.Description.Length > 200)
            {
                throw new ArgumentException("New Incident's description cannot be greater than 200 characters");
            }
             return _incidentDBSource.UpdateIncident(formerIncident, newIncident);
        }

        /// <summary>
        /// Closes the incident with a specific IncidentID
        /// </summary>
        /// <param name="formerIncident">old Incident object</param>
        /// <param name="newIncident">new Incident object</param>
        /// <returns>boolean if Incident object was closed</returns>
        public bool CloseIncident(Incident formerIncident, Incident newIncident)
        {
            if (formerIncident.IncidentID < 1)
            {
                throw new ArgumentException("Former IncidentID cannot be less than 1");
            }
            if (formerIncident.Description.Length > 200)
            {
                throw new ArgumentException("Former Description cannot be greater than 200 characters");
            }
            if (newIncident.IncidentID < 1)
            {
                throw new ArgumentException("New incident's IncidentID cannot be less than 1");
            }
            if (newIncident.Description.Length > 200)
            {
                throw new ArgumentException("New incident's Description cannot be greater than 200 characters");
            }
            return _incidentDBSource.CloseIncident(formerIncident, newIncident);
        }

        /// <summary>
        /// This method used to return open incidents assigned from DAL
        /// </summary>
        /// <param name="techID">technician id</param>
        /// <returns>list of assigned open incident objects</returns>
        public List<Incident> GetTechnicianOpenIncidents(int techID)
        {
            return _incidentDBSource.GetOpenIncidentsWithTech(techID);
        }
    }
}
