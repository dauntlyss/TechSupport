using System;
using System.Collections.Generic;

namespace TechSupport.Model
{
    /// <summary>
    /// Model class used to define technician object 
    /// Author: Alyssa Harris
    /// Version: 3/15/23
    /// </summary>
    public class Technician
    {
        #region Data Members

        /// <summary>
        /// Getter method for technician TechID
        /// </summary>
        public int TechID { get; set; }

        /// <summary>
        /// Getter method for technician Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Getter method for technician Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Getter method for technician Phone
        /// </summary>
        public string Phone { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// This is the default constuctor
        /// </summary>
        public Technician()
        {
        }

        /// <summary>
        /// Overloaded constructor used to create technician
        /// </summary>
        /// <param name="techID">technician techID</param>
        /// <param name="name">technician name</param>
        /// <param name="email">technician email</param>
        /// <param name="phone">technician phone</param>
        public Technician(int techID, string name, string email, string phone)
        {

            if (techID < 0)
            {
                throw new ArgumentOutOfRangeException("techID", "Technician's TechID must be number greater than 0.");
            }

            if (string.IsNullOrEmpty(name) || name.Length > 50)
            {
                throw new ArgumentException("Technician's Name cannot be null/empty or greater than 50 characters.", "name");
            }

            if (string.IsNullOrEmpty(email) || email.Length > 50)
            {
                throw new ArgumentException("Technician's Email cannot be null/empty or greater than 50 characters.", "email");
            }

            if (string.IsNullOrEmpty(phone) || phone.Length > 20)
            {
                throw new ArgumentException("Technician's Phone cannot be null/empty or greater than 20 characters", "phone");
            }

            this.TechID = techID;
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
        }

        #endregion
    }
}
