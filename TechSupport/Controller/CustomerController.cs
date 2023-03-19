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
        
    }
}
