using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    /// <summary>
    /// This class is used to define the open incident assigned
    /// </summary>
    /// Author: Alyssa Harris
    /// Version: 3/15/23
    internal class OpenIncidentAssigned
    {
        #region Data Members

        /// <summary>
        /// Getter and setter for Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Getter and setter for DateOpened
        /// </summary>
        public DateTime DateOpened { get; set; }

        /// <summary>
        /// Getter and setter for Customer name
        /// </summary>
        public string Customer { get; set; }

        /// <summary>
        /// Getter and setter for TechID
        /// </summary>
        public int TechID { get; set; }

        /// <summary>
        /// Getter and setter for Title of incident
        /// </summary>
        public string Title { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Constructor that takes no parameters
        /// </summary>
        public OpenIncidentAssigned()
        {
        }

        /// <summary>
        /// Overloaded constuctor that accepts open incidents assigned parameters and makes them available to getter/setters
        /// </summary>
        /// <param name="name">product name</param>
        /// <param name="dateOpened">incident date opened</param>
        /// <param name="customer">customer name</param>
        /// <param name="techID">technician id</param>
        /// <param name="title">incident title</param>
        public OpenIncidentAssigned(string name, DateTime dateOpened, string customer, int techID, string title)
        {
            this.Name = name;
            this.DateOpened = dateOpened;
            this.Customer = customer;
            this.TechID = techID;
            this.Title = title;
        }

        #endregion
    }
}
