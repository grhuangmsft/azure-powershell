// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// Existing recovery proximity placement group input.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Existing")]
    public partial class ExistingRecoveryProximityPlacementGroup : RecoveryProximityPlacementGroupCustomDetails
    {
        /// <summary>
        /// Initializes a new instance of the ExistingRecoveryProximityPlacementGroup class.
        /// </summary>
        public ExistingRecoveryProximityPlacementGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExistingRecoveryProximityPlacementGroup class.
        /// </summary>

        /// <param name="recoveryProximityPlacementGroupId">The recovery proximity placement group Id. Will throw error, if resource
        /// does not exist.
        /// </param>
        public ExistingRecoveryProximityPlacementGroup(string recoveryProximityPlacementGroupId = default(string))

        {
            this.RecoveryProximityPlacementGroupId = recoveryProximityPlacementGroupId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the recovery proximity placement group Id. Will throw error,
        /// if resource does not exist.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryProximityPlacementGroupId")]
        public string RecoveryProximityPlacementGroupId {get; set; }
    }
}