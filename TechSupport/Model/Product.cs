using System;
using System.Collections.Generic;

namespace TechSupport.Model
{
    /// <summary>
    /// THis class definees the product object
    /// Author: Alyssa Harris
    /// Version: 2/13/23
    /// </summary>
    public class Product
    {
        #region Data Members

        /// <summary>
        /// Getter method for product ProductCode
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// Getter method for product Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Getter method for product Version
        /// </summary>
        public decimal Version { get; set; }

        /// <summary>
        /// Getter method for product ReleaseDate
        /// </summary>
        public DateTime ReleaseDate { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// THis is the default constructor for the object
        /// </summary>
        public Product()
        {
        }

        /// <summary>
        /// This is the constructor used to create product
        /// </summary>
        /// <param name="productCode">product's code</param>
        /// <param name="name">product's name</param>
        /// <param name="version">product's version</param>
        /// <param name="releaseDate">product's release date</param>
        public Product(string productCode, string name, decimal version, DateTime releaseDate)
        {

            if (string.IsNullOrEmpty(productCode))
            {
                throw new ArgumentException("Product's Product Code cannot be empty.", "productCode");

            }

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Product's Name cannot be empty.", "name");

            }

            if (version < 0)
            {
                throw new ArgumentOutOfRangeException("version", "Product's Version must be a number greater than or equal to 0.0.");

            }

            if (releaseDate.Year < 2000 || releaseDate > DateTime.Now)
            {
                throw new ArgumentOutOfRangeException("releaseDate", "Product's Release Date has to occur after the year 2000 and <= current datetime.");
            }

            this.ProductCode = productCode;
            this.Name = name;
            this.Version = version;
            this.ReleaseDate = releaseDate;
        }

        #endregion
    }
}
