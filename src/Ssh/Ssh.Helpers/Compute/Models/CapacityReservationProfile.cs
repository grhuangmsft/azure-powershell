// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Ssh.Helpers.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The parameters of a capacity reservation Profile.
    /// </summary>
    public partial class CapacityReservationProfile
    {
        /// <summary>
        /// Initializes a new instance of the CapacityReservationProfile class.
        /// </summary>
        public CapacityReservationProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CapacityReservationProfile class.
        /// </summary>
        /// <param name="capacityReservationGroup">Specifies the capacity
        /// reservation group resource id that should be used for allocating
        /// the virtual machine or scaleset vm instances provided enough
        /// capacity has been reserved. Please refer to
        /// https://aka.ms/CapacityReservation for more details.</param>
        public CapacityReservationProfile(SubResource capacityReservationGroup = default(SubResource))
        {
            CapacityReservationGroup = capacityReservationGroup;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the capacity reservation group resource id
        /// that should be used for allocating the virtual machine or scaleset
        /// vm instances provided enough capacity has been reserved. Please
        /// refer to https://aka.ms/CapacityReservation for more details.
        /// </summary>
        [JsonProperty(PropertyName = "capacityReservationGroup")]
        public SubResource CapacityReservationGroup { get; set; }

    }
}
