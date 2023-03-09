// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Existing recovery availability set input.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Existing")]
    public partial class ExistingRecoveryAvailabilitySet : RecoveryAvailabilitySetCustomDetails
    {
        /// <summary>
        /// Initializes a new instance of the ExistingRecoveryAvailabilitySet
        /// class.
        /// </summary>
        public ExistingRecoveryAvailabilitySet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExistingRecoveryAvailabilitySet
        /// class.
        /// </summary>
        /// <param name="recoveryAvailabilitySetId">The recovery availability
        /// set Id. Will throw error, if resource does not exist.</param>
        public ExistingRecoveryAvailabilitySet(string recoveryAvailabilitySetId = default(string))
        {
            RecoveryAvailabilitySetId = recoveryAvailabilitySetId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the recovery availability set Id. Will throw error, if
        /// resource does not exist.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAvailabilitySetId")]
        public string RecoveryAvailabilitySetId { get; set; }

    }
}
