using System;
using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// Technician class controller used to access the data access layer for technicians
    /// Author: Alyssa Harris
    /// Version: 2/19/23
    /// </summary>
    public class TechnicianController
    {
        #region Data Members

        private readonly TechnicianDBDAL _technicianDBSource;

        #endregion

        #region Constructors

        /// <summary>
        /// Creates a TechnicianController object
        /// </summary>
        public TechnicianController()
        {
            _technicianDBSource = new TechnicianDBDAL();
        }

        #endregion

        #region Methods

        /// <summary>
        /// This method returns all the technician ids and names
        /// </summary>
        /// <returns>A list of all the technician objects with id and name</returns>
        public List<TechnicianIDAndName> GetAllTechnicianIDAndNames()
        {
            return _technicianDBSource.GetAllTechnicianIDAndNames();
        }

        /// <summary>
        /// THis method is used to get/return all the technicians
        /// </summary>
        /// <returns>a list of all the technician objects</returns>
        public List<Technician> GetAllTechnicians()
        {
            return _technicianDBSource.GetAllTechnicians();
        }

        /// <summary>
        /// This method gets all the techs assigned to incidents
        /// </summary>
        /// <returns>a list of assigned technician objects</returns>
        public List<Technician> GetAssignedTechnicians()
        {
            return _technicianDBSource.GetAssignedTechnicians();
        }

        #endregion
    }
}
