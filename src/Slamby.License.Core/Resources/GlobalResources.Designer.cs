﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Slamby.License.Core.Resources {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class GlobalResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal GlobalResources() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Slamby.License.Core.Resources.GlobalResources", typeof(GlobalResources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Invalid core number!.
        /// </summary>
        public static string LicenseCoresMessage {
            get {
                return ResourceManager.GetString("LicenseCoresMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The core number of your server is greater than in the license. Contact us to purchase the right license. - support@slamby.com.
        /// </summary>
        public static string LicenseCoresResolve {
            get {
                return ResourceManager.GetString("LicenseCoresResolve", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to License for this product has expired!.
        /// </summary>
        public static string LicenseExpiredMessage {
            get {
                return ResourceManager.GetString("LicenseExpiredMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Your license is expired. Please contact us to renew the license. - support@slamby.com.
        /// </summary>
        public static string LicenseExpiredResolve {
            get {
                return ResourceManager.GetString("LicenseExpiredResolve", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The license is not for this instance!.
        /// </summary>
        public static string LicenseIdMessage {
            get {
                return ResourceManager.GetString("LicenseIdMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The id of the server instance is not matched with the license. If you reinstalled the Slamby API please contact us. - support@slamby.com.
        /// </summary>
        public static string LicenseIdResolve {
            get {
                return ResourceManager.GetString("LicenseIdResolve", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to License signature validation error!.
        /// </summary>
        public static string LicenseSignatureMessage {
            get {
                return ResourceManager.GetString("LicenseSignatureMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The license signature and data does not match. This usually happens when a license file is corrupted or has been altered. - support@slamby.com.
        /// </summary>
        public static string LicenseSignatureResolve {
            get {
                return ResourceManager.GetString("LicenseSignatureResolve", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to License validation failed!.
        /// </summary>
        public static string LicenseValidationFailedMessage {
            get {
                return ResourceManager.GetString("LicenseValidationFailedMessage", resourceCulture);
            }
        }
    }
}