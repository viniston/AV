﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TE.Core.Properties {
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
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TE.Core.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to persist authorization requests..
        /// </summary>
        public static string FailedAuthorizationRequestPersistence {
            get {
                return ResourceManager.GetString("FailedAuthorizationRequestPersistence", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to persist authorization responses..
        /// </summary>
        public static string FailedAuthorizationResponsePersistence {
            get {
                return ResourceManager.GetString("FailedAuthorizationResponsePersistence", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to persist capture authorization requests..
        /// </summary>
        public static string FailedCaptureAuthorizationRequestPersistence {
            get {
                return ResourceManager.GetString("FailedCaptureAuthorizationRequestPersistence", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not a valid quote identifier..
        /// </summary>
        public static string InvalidQuoteIdExceptionMessage {
            get {
                return ResourceManager.GetString("InvalidQuoteIdExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to complete operation for the quote {0} due to the current quote status: {1}..
        /// </summary>
        public static string InvalidQuoteStatus {
            get {
                return ResourceManager.GetString("InvalidQuoteStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tried to get a non-existent payment summary: {0}.
        /// </summary>
        public static string PaymentSummaryDoesNotExistExceptionMessage {
            get {
                return ResourceManager.GetString("PaymentSummaryDoesNotExistExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Traveler price breakdowns collection is empty, most likley the front ends price booking call to Amadeus failed..
        /// </summary>
        public static string PriceBookingFailureDeveloperMessage {
            get {
                return ResourceManager.GetString("PriceBookingFailureDeveloperMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No quote exists with id: {0}..
        /// </summary>
        public static string QuoteDoesNotExistExceptionMessage {
            get {
                return ResourceManager.GetString("QuoteDoesNotExistExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to complete payment for cruise service with TravelServiceId: {0} due to the invalid status: {1}..
        /// </summary>
        public static string UnableToGetAmountToBeChargedForCruiseTravelServiceFormat {
            get {
                return ResourceManager.GetString("UnableToGetAmountToBeChargedForCruiseTravelServiceFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to get net rate for cruise service with TravelServiceId: {0}..
        /// </summary>
        public static string UnableToGetNetRateForCruiseTravelServiceFormat {
            get {
                return ResourceManager.GetString("UnableToGetNetRateForCruiseTravelServiceFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to get PaymentTypeProviderBroker..
        /// </summary>
        public static string UnableToGetPaymentProviderBroker {
            get {
                return ResourceManager.GetString("UnableToGetPaymentProviderBroker", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to get PaymentTypeProviderWorker..
        /// </summary>
        public static string UnableToGetPaymentProviderWorker {
            get {
                return ResourceManager.GetString("UnableToGetPaymentProviderWorker", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported TravelServiceType {0}..
        /// </summary>
        public static string UnsupportedTravelServiceTypeFormat {
            get {
                return ResourceManager.GetString("UnsupportedTravelServiceTypeFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provider {0} does not support void of payments..
        /// </summary>
        public static string UnsupportedVoidPaymentsForProvider {
            get {
                return ResourceManager.GetString("UnsupportedVoidPaymentsForProvider", resourceCulture);
            }
        }
    }
}
