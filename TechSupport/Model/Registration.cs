using System;
using System.Collections.Generic;

namespace TechSupport.Model
{
    /// <summary>
    /// Model used to define a registration
    /// Author: Alyssa Harris
    /// Version: 2/13/23
    /// </summary>
    public class Registration
    {
        #region Data Members

        /// <summary>
        /// Getter method for registration CustomerID
        /// </summary>
        public int CustomerID { get; set; }

        /// <summary>
        /// Getter method for registration ProductCode
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// Getter method for registration RegistrationDate
        /// </summary>
        public DateTime RegistrationDate { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// This is the default constructor for the object
        /// </summary>
        public Registration()
        {
        }

        /// <summary>
        /// THis is the constructor used to create registration
        /// </summary>
        /// <param name="customerID">registration's customerID</param>
        /// <param name="productCode">registration's product code</param>
        /// <param name="registrationDate">registration's date</param>
        public Registration(int customerID, string productCode, DateTime registrationDate)
        {

            if (customerID < 0)
            {
                throw new ArgumentOutOfRangeException("customerID", "Registration's CustomerID has to be number greater than 0");
            }

            if (string.IsNullOrEmpty(productCode))
            {
                throw new ArgumentException("Registration's Product Code cannot be empty.", "productCode");
            }

            if (registrationDate.Year < 2000 || registrationDate > DateTime.Now)
            {
                throw new ArgumentOutOfRangeException("registrationDate", "Registration's Date has to occur after 2000 and <= current datetime");
            }

            this.CustomerID = customerID;
            this.ProductCode = productCode;
            this.RegistrationDate = registrationDate;
        }

        #endregion
    }
}
