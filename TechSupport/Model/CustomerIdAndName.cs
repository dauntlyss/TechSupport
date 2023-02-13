using System;
using System.Collections.Generic;

namespace TechSupport.Model
{
    /// <summary>
    /// This class defines the customer Id and Name 
    /// Author: Alyssa Harris
    /// Version: 2/13/23
    /// </summary>
    public class CustomerIdAndName
    {
        #region Data Members

        /// <summary>
        /// Getter method for CustomerID
        /// </summary>
        public int CustomerID { get; set; }

        /// <summary>
        /// Getter method for customer Name
        /// </summary>
        public string Name { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor for the object
        /// </summary>
        public CustomerIdAndName()
        {
        }

        /// <summary>
        /// Used to create the object
        /// </summary>
        /// <param name="customerID">customer's ID</param>
        /// <param name="name">customer's name</param>
        public CustomerIdAndName(int customerID, string name)
        {

            if (customerID < 0)
            {
                throw new ArgumentOutOfRangeException("customerID", "Customer's CustomerID has must be greater than 0.");

            }

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Customer's Name cannot be empty.", "name");

            }

            this.CustomerID = customerID;
            this.Name = name;
        }

        #endregion
    }
}
