using System;
using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// This class is the controller used to access the DAl and search registrations in the DB
    /// </summary>
    public class RegistrationController
    {
        #region Data Members

        private readonly RegistrationDBDAL _registrationDBSource;

        #endregion

        #region Constructors

        /// <summary>
        /// THis method instantiates a RegistrationController object
        /// </summary>
        public RegistrationController()
        {
            _registrationDBSource = new RegistrationDBDAL();
        }

        #endregion

        #region Methods

        /// <summary>
        /// THis method returns all the registrations in the DB
        /// </summary>
        /// <returns>A list of all the registrations</returns>
        public List<Registration> GetAllRegistrations()
        {
            return _registrationDBSource.GetAllRegistrations();
        }

        /// <summary>
        /// This method calls the stored procedure and returns boolean value if record is registered
        /// </summary>
        /// <param name="customerID">customer id</param>
        /// <param name="productCode">product code</param>
        /// <returns>return boolean value if product is registered</returns>
        public Boolean IsCustomerProductRegistered(int customerID, string productCode)
        {
            return _registrationDBSource.IsCustomerProductRegistered(customerID, productCode);
        }
        #endregion
    }
}
