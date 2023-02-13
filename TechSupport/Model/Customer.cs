using System;
using System.Collections.Generic;


namespace TechSupport.Model
{
    /// <summary>
    /// Model class used to define the customer object
    /// Author: Alyssa Harris
    /// Version: 2/13/23
    /// </summary>
    public class Customer
    {
        #region Data Members

        /// <summary>
        /// Getter method for customer CustomerID
        /// </summary>
        public int CustomerID { get; set; }

        /// <summary>
        /// Getter method for customer Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Getter method for customer Address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Getter method for customer City
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Getter method for customer State
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Getter method for customer ZipCode
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// Getter method for customer Phone
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Getter method for customer Email
        /// </summary>
        public string Email { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor for the customer object
        /// </summary>
        public Customer()
        {
        }

        /// <summary>
        /// Constructor used to create customer
        /// </summary>
        /// <param name="customerID">customer's ID</param>
        /// <param name="name">customer's name</param>
        /// <param name="address">customer's address</param>
        /// <param name="city">customer's city</param>
        /// <param name="state">customer's state</param>
        /// <param name="zipCode">customer's zip code</param>
        /// <param name="phone">customer's phone</param>
        /// <param name="email">customer's email</param>
        public Customer(int customerID, string name, string address, string city, string state, string zipCode, string phone, string email)
        {

            if (customerID < 0)
            {
                throw new ArgumentOutOfRangeException("customerID", "Customer's CustomerID must be greater than 0.");

            }

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Customer's Name cannot be empty.", "name");

            }

            if (string.IsNullOrEmpty(address))
            {
                throw new ArgumentException("Customer's address cannot be empty.", "address");

            }

            if (string.IsNullOrEmpty(city))
            {
                throw new ArgumentException("Customer's city cannot be empty.", "city");

            }

            if (string.IsNullOrEmpty(state))
            {
                throw new ArgumentException("Customer's state abbreviation cannot be empty.", "state");

            }

            if (string.IsNullOrEmpty(zipCode))
            {
                throw new ArgumentException("Customer's zip code cannot be empty.", "zipCode");

            }

            if (string.IsNullOrEmpty(phone))
            {
                throw new ArgumentException("Customer's phone cannot be empty.", "phone");

            }

            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentException("Customer's email cannot be empty.", "email");

            }

            this.CustomerID = customerID;
            this.Name = name;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
            this.Phone = phone;
            this.Email = email;
        }

        #endregion
    }
}
