using System;
using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// This class is the controller used to acccess the DAL and search the Db for customers.
    /// Author: Alyssa Harris
    /// Version: 2/13/23
    /// </summary>
    public class CustomerController
    {
        #region Data Members

        private readonly CustomerDBDAL _customerDBSource;

        #endregion

        #region Constructors

        /// <summary>
        /// This method instantiates a CustomerController object
        /// </summary>
        public CustomerController()
        {
            _customerDBSource = new CustomerDBDAL();
        }

        #endregion

        #region Methods

        /// <summary>
        /// This method returns all the customer names
        /// </summary>
        /// <returns>A list of all the customer ids and names</returns>
        public List<CustomerIdAndName> GetAllCustomerIDAndNames()
        {
            return _customerDBSource.GetAllCustomerIdAndNames();
        }

        #endregion
    }
}
