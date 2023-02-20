using System;
using System.Collections.Generic;

namespace TechSupport.Model
{
    /// <summary>
    /// This is a modele class used to deinf the technician name and id
    /// Author: Alyssa Harris
    /// Version: 2/19/23
    /// </summary>
    public class TechnicianIDAndName
    {
        #region Data Members

        /// <summary>
        /// Gets the technician's TechID
        /// </summary>
        public int TechID { get; set; }

        /// <summary>
        /// Gets the technician's Name
        /// </summary>
        public string Name { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// This is the default constructor for the object
        /// </summary>
        public TechnicianIDAndName()
        {
        }

        /// <summary>
        /// This is the constructor used to create technician id and name object
        /// </summary>
        /// <param name="techID">TechID</param>
        /// <param name="name">Name</param>
        public TechnicianIDAndName(int techID, string name)
        {

            if (techID < 0)
            {
                throw new ArgumentOutOfRangeException("techID", "Technician's TechID must be number greater than 0.");

            }

            if (string.IsNullOrEmpty(name) || name.Length > 50)
            {
                throw new ArgumentException("Technician's Name cannot be null/empty or greater than 50 characters.", "name");

            }

            this.TechID = techID;
            this.Name = name;
        }

        #endregion
    }
}
