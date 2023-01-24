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
        /// Gets the title of the incident.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Gets the description of the incident.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Initializes a new instance of the Incident class.
        /// </summary>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="title">The title.</param>
        /// <param name="description">The description.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">customerId - Customer ID for the incident must be greater than 0.</exception>
        /// <exception cref="System.ArgumentException">
        /// The title of the incident cannot be empty or exceed 100 characters. - title
        /// or
        /// The description of the incident cannot be empty or greater than 300 characters. - description
        /// </exception>
        public Incident(int customerId, string title, string description)
        {
            if (customerId < 0)
            {
                throw new ArgumentOutOfRangeException("customerId",
                    "Customer ID for the incident must be greater than 0.");
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
            this.Title = title;
            this.Description = description;
        }
    }
}
