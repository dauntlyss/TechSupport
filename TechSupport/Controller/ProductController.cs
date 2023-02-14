using System;
using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// This class is the controller used to access the DAL and search all products
    /// Author: Alyssa Harris
    /// Version: 2/13/23
    /// </summary>
    public class ProductController
    {
        #region Data Members

        private readonly ProductDBDAL _productDBSource;

        #endregion

        #region Constructors

        /// <summary>
        /// This method instantiates a ProductController object
        /// </summary>
        public ProductController()
        {
            _productDBSource = new ProductDBDAL();
        }

        #endregion

        #region Methods

        /// <summary>
        /// This method returns all the product names
        /// </summary>
        /// <returns>A list of all the product codes and names</returns>
        public List<ProductCodeAndName> GetAllProductCodeAndNames()
        {
            return _productDBSource.GetAllProductCodeAndNames();
        }

        #endregion
    }
}
