using System;
using System.Collections.Generic;

namespace TechSupport.Model
{
    /// <summary>
    /// Model class used to define the Incident object
    /// </summary>
    public class Incident
    {
        #region Data Members

        /// <summary>
        /// Gets the incident's IncidentID
        /// </summary>
        public int? IncidentID { get; set; }

        /// <summary>
        /// Gets the customer identifier of the incident.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets the incident's TechID
        /// </summary>
        public int? TechID { get; set; }

        /// <summary>
        /// Gets the incident's ProductCode.
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// Gets the title of the incident.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets the description of the incident.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets incident's DateOpened
        /// </summary>
        public DateTime DateOpened { get; set; }

        /// <summary>
        /// Gets incident's DateClosed
        /// </summary>
        public DateTime? DateClosed { get; set; }
        public string Customer { get; internal set; }
        public string Name { get; internal set; }

        #endregion

        #region Constructors
        /// <summary>
        /// The default constructor for the object
        /// </summary>
        public Incident()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Incident class.
        /// </summary>
        /// <param name="incidentID">Incident ID</param>
        /// <param name="customerID">Customer ID</param>
        /// <param name="productCode">Product Code</param>
        /// <param name="techID">Technician ID</param>
        /// <param name="dateOpened">Date Opened</param>
        /// <param name="dateClosed">Date Closed</param>
        /// <param name="title">Title</param>
        /// <param name="description">Description</param>
        public Incident(int? incidentID, int customerID, string productCode, int? techID
            , DateTime dateOpened, DateTime? dateClosed, string title, string description)
        {
            if (incidentID != null && incidentID < 0)
            {
                throw new ArgumentOutOfRangeException("incidentID", "Incident's IncidentID must be a number greater than 0.");

            }

            if (customerID < 0)
            {
                throw new ArgumentOutOfRangeException("customerID", "Incident's CustomerID must be a number greater than 0.");

            }

            if (string.IsNullOrEmpty(productCode) || productCode.Length > 10)
            {
                throw new ArgumentException("Incident's Product Code cannot be null/empty or greater than 10 characters.", "productCode");

            }

            if (techID != null && techID < 0)
            {
                throw new ArgumentOutOfRangeException("techID", "Incident's TechID must be a number greater than 0.");

            }

            if (!DateTime.TryParse(dateOpened.ToString(), out _))
            {
                throw new ArgumentException("Incident's Date Opened is not valid.", "dateOpened");

            }

            if (dateClosed != null && !DateTime.TryParse(dateClosed.ToString(), out _))
            {
                throw new ArgumentException("Incident's Date Closed is not valid.", "dateClosed");

            }

            if (string.IsNullOrEmpty(title) || title.Length > 50)
            {
                throw new ArgumentException("Incident's Title cannot be null/empty or greater than 50 characters.", "title");

            }

            if (string.IsNullOrEmpty(description) || description.Length > 200)
            {
                throw new ArgumentException("Incident's description cannot be null/empty or greater than 200 characters.", "description");

            }

            this.IncidentID = incidentID;
            this.CustomerId = customerID;
            this.ProductCode = productCode;
            this.TechID = techID;
            this.DateOpened = dateOpened;
            this.DateClosed = dateClosed;
            this.Title = title;
            this.Description = description;
        }
        #endregion
    }
}
