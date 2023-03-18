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
        private readonly CustomerDBDAL _customerDBSource;

        ///Creates an incidentController object to add incidents
        public CustomerController()
        {
            this._customerDBSource = new CustomerDBDAL();
        }

        /// <summary>
        /// Delegates retrieving all Customers to CustomerDAL.
        /// </summary>
        /// <returns>All Customers in TechSupport database.</returns>
        public List<Customer> GetAllCustomers()
        {
            return _customerDBSource.GetAllCustomers();
        }
        /*#region Data Members

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

        /// <summary>
        /// This method retrievees a customer based on customer Id
        /// </summary>
        /// <param name="customerID">customer id</param>
        /// <returns>list of customer objects</returns>
        public List<Customer> GetCustomer(int customerID)
        {
            if (customerID < 1)
            {
                throw new ArgumentException("CustomerID cannot be less than 1");
            }
            return _customerDBSource.GetCustomer(customerID);
        }

        #endregion*/
    }
}
