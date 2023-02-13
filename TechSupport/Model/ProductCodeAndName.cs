using System;
using System.Collections.Generic;

namespace TechSupport.Model
{
    /// <summary>
    /// Model class that defines the product code and name
    /// Author: Alyssa Harris
    /// Version: 2/13/23
    /// </summary>
    public class ProductCodeAndName
    {
        #region Data Members

        /// <summary>
        /// Getter method for product's ProductCode
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// Getter method for product's Name
        /// </summary>
        public string Name { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// The default constructor for the object
        /// </summary>
        public ProductCodeAndName()
        {
        }

        /// <summary>
        /// The constructor used to create product code and name
        /// </summary>
        /// <param name="productCode">product's code</param>
        /// <param name="name">product's name</param>
        public ProductCodeAndName(string productCode, string name)
        {

            if (string.IsNullOrEmpty(productCode))
            {
                throw new ArgumentException("Product's Product Code cannot be empty.", "productCode");
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Product's Name cannot be empty.", "name");
            }

            this.ProductCode = productCode;
            this.Name = name;
        }

        #endregion
    }
}
