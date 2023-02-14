using System;

namespace TechSupport.Model
{
    /// <summary>
    /// Model class used to define the Incident object
    /// </summary>
    public class Incident
    {
        /// <summary>
        /// Gets the customer identifier of the incident.
        /// </summary>
        public int CustomerId { get; }

        /// <summary>
        /// Gets the incident's ProductCode.
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// Gets the title of the incident.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Gets the description of the incident.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// The default constructor for the object
        /// </summary>
        public Incident()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Incident class.
        /// </summary>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="productCode">incident product code</param>
        /// <param name="title">The title.</param>
        /// <param name="description">The description.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">customerId - Customer ID for the incident must be greater than 0.</exception>
        /// <exception cref="System.ArgumentException">
        /// The title of the incident cannot be empty or exceed 100 characters. - title
        /// or
        /// The description of the incident cannot be empty or greater than 300 characters. - description
        /// </exception>
        public Incident(int customerId, string productCode, string title, string description)
        {
            if (customerId < 0)
            {
                throw new ArgumentOutOfRangeException("customerId",
                    "Customer ID for the incident must be greater than 0.");
            }

            if (string.IsNullOrEmpty(productCode) || productCode.Length > 20)
            {
                throw new ArgumentException("Incident's Product Code cannot be empty or exceed 20 characters.", "productCode");
            }

            if (string.IsNullOrEmpty(title) || title.Length > 100)
            {
                throw new ArgumentException("The title of the incident cannot be empty or exceed 100 characters.",
                    "title");
            }

            if (string.IsNullOrEmpty(description) || description.Length > 300)
            {
                throw new ArgumentException("The description of the incident cannot be empty or greater than 300 characters.", "description");
            }

            this.CustomerId = customerId;
            this.ProductCode= productCode;
            this.Title = title;
            this.Description = description;
        }
    }
}
