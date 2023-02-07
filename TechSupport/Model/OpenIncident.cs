using System;


namespace TechSupport.Model
{
    /// <summary>
    /// Class defines an open incident object
    /// Author: Alyssa Harris
    /// Version: 02/06/23
    /// </summary>
    public class OpenIncident
    {
        #region Data Members

        /// <summary>
        /// Getter and setter for ProductCode parameter
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// Getter and setter for DateOpened parameter
        /// </summary>
        public DateTime DateOpened { get; set; }

        /// <summary>
        /// Getter and setter for Customer name parameter
        /// </summary>
        public string Customer { get; set; }

        /// <summary>
        /// Getter and setter for Technician name parameter
        /// </summary>
        public string Technician { get; set; }

        /// <summary>
        /// Getter and setter for Title of incident parameter
        /// </summary>
        public string Title { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Zero parameter constructor for object
        /// </summary>
        public OpenIncident()
        {
        }

        /// <summary>
        /// Constuctor that accepts open incident parameters and makes them available to getter/setters
        /// </summary>
        /// <param name="productCode">product code</param>
        /// <param name="dateOpened">date incident opened</param>
        /// <param name="customer">customer name</param>
        /// <param name="technician">technician name</param>
        /// <param name="title">title of incident</param>
        public OpenIncident(string productCode, DateTime dateOpened, string customer, string technician, string title)
        {
            this.ProductCode = productCode;
            this.DateOpened = dateOpened;
            this.Customer = customer;
            this.Technician = technician;
            this.Title = title;
        }

        #endregion
    }
}
