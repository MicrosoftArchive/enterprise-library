﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AExpense.FunctionalTests.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AExpense.FunctionalTests.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select an amount greater than 0.00.
        /// </summary>
        internal static string AmountGreaterThanZeroMessage {
            get {
                return ResourceManager.GetString("AmountGreaterThanZeroMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must supply an approver name..
        /// </summary>
        internal static string ApproverNameMustBeSuppliedMessage {
            get {
                return ResourceManager.GetString("ApproverNameMustBeSuppliedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cost center Should not be null..
        /// </summary>
        internal static string CostCencerNotNullMessage {
            get {
                return ResourceManager.GetString("CostCencerNotNullMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must supply a description..
        /// </summary>
        internal static string DescriptionMustBeSuppliedMessage {
            get {
                return ResourceManager.GetString("DescriptionMustBeSuppliedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The requested action could not be finished. Please retry later or contact Help Desk with Error Token ID.
        /// </summary>
        internal static string FriendlyMessage {
            get {
                return ResourceManager.GetString("FriendlyMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User not registered in Membership repository..
        /// </summary>
        internal static string InvalidApproverMessage {
            get {
                return ResourceManager.GetString("InvalidApproverMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Notify Policy Exception Handling.
        /// </summary>
        internal static string NotifyExceptionTitle {
            get {
                return ResourceManager.GetString("NotifyExceptionTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method User.set_UserName executed.
        /// </summary>
        internal static string SetUserNameWasExecutedMessage {
            get {
                return ResourceManager.GetString("SetUserNameWasExecutedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must supply a title..
        /// </summary>
        internal static string TitleMustBeSuppliedMessage {
            get {
                return ResourceManager.GetString("TitleMustBeSuppliedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User does not exist in LDAP..
        /// </summary>
        internal static string UserDoesNotExistInLDAPMessage {
            get {
                return ResourceManager.GetString("UserDoesNotExistInLDAPMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User should not be null..
        /// </summary>
        internal static string UserNotNullMessage {
            get {
                return ResourceManager.GetString("UserNotNullMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User not registered in Membership repository..
        /// </summary>
        internal static string UserNotRegisteredMessage {
            get {
                return ResourceManager.GetString("UserNotRegisteredMessage", resourceCulture);
            }
        }
    }
}
