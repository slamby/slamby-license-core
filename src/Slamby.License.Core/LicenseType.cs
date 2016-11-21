﻿namespace Slamby.License.Core
{
    /// <summary>
    /// Defines the type of a <see cref="License"/>
    /// </summary>
    public enum LicenseType
    {
        /// <summary>
        /// For open source use
        /// </summary>
        OpenSource = 1,

        /// <summary>
        /// Commercial license
        /// </summary>
        Commercial = 2,

        /// <summary>
        /// Azure Marketplace license
        /// </summary>
        MarketPlace = 3
    }
}