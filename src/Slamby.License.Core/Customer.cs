using System.Xml.Linq;

﻿namespace Slamby.License.Core
{
    /// <summary>
    /// The customer of a <see cref="License"/>.
    /// </summary>
    public class Customer : LicenseAttributes
    {
        internal Customer(XElement xmlData)
            : base(xmlData, "CustomerData")
        {
        }

        /// <summary>
        /// Gets or sets the Name of this <see cref="Customer"/>.
        /// </summary>
        public string Name
        {
            get { return GetTag("Name"); }
            set { SetTag("Name", value); }
        }
        
        /// <summary>
        /// Gets or sets the Company of this <see cref="Customer"/>.
        /// </summary>
        public string Company
        {
            get { return GetTag("Company"); }
            set { SetTag("Company", value); }
        }

        /// <summary>
        /// Gets or sets the Email of this <see cref="Customer"/>.
        /// </summary>
        public string Email
        {
            get { return GetTag("Email"); }
            set { SetTag("Email", value); }
        }
    }
}