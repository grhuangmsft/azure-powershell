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
    /// VMwareCbt specific resume replication input.
    /// </summary>
    [Newtonsoft.Json.JsonObject("VMwareCbt")]
    public partial class VMwareCbtResumeReplicationInput : ResumeReplicationProviderSpecificInput
    {
        /// <summary>
        /// Initializes a new instance of the VMwareCbtResumeReplicationInput
        /// class.
        /// </summary>
        public VMwareCbtResumeReplicationInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VMwareCbtResumeReplicationInput
        /// class.
        /// </summary>
        /// <param name="deleteMigrationResources">A value indicating whether
        /// Migration resources to be deleted.</param>
        public VMwareCbtResumeReplicationInput(string deleteMigrationResources = default(string))
        {
            DeleteMigrationResources = deleteMigrationResources;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a value indicating whether Migration resources to be
        /// deleted.
        /// </summary>
        [JsonProperty(PropertyName = "deleteMigrationResources")]
        public string DeleteMigrationResources { get; set; }

    }
}
