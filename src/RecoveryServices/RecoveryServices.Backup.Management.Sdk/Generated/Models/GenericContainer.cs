// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Base class for generic container of backup items
    /// </summary>
    [Newtonsoft.Json.JsonObject("GenericContainer")]
    public partial class GenericContainer : ProtectionContainer
    {
        /// <summary>
        /// Initializes a new instance of the GenericContainer class.
        /// </summary>
        public GenericContainer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GenericContainer class.
        /// </summary>
        /// <param name="friendlyName">Friendly name of the container.</param>
        /// <param name="backupManagementType">Type of backup management for
        /// the container. Possible values include: 'Invalid', 'AzureIaasVM',
        /// 'MAB', 'DPM', 'AzureBackupServer', 'AzureSql', 'AzureStorage',
        /// 'AzureWorkload', 'DefaultBackup'</param>
        /// <param name="registrationStatus">Status of registration of the
        /// container with the Recovery Services Vault.</param>
        /// <param name="healthStatus">Status of health of the
        /// container.</param>
        /// <param name="protectableObjectType">Type of the protectable object
        /// associated with this container</param>
        /// <param name="fabricName">Name of the container's fabric</param>
        /// <param name="extendedInformation">Extended information (not
        /// returned in List container API calls)</param>
        public GenericContainer(string friendlyName = default(string), string backupManagementType = default(string), string registrationStatus = default(string), string healthStatus = default(string), string protectableObjectType = default(string), string fabricName = default(string), GenericContainerExtendedInfo extendedInformation = default(GenericContainerExtendedInfo))
            : base(friendlyName, backupManagementType, registrationStatus, healthStatus, protectableObjectType)
        {
            FabricName = fabricName;
            ExtendedInformation = extendedInformation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the container's fabric
        /// </summary>
        [JsonProperty(PropertyName = "fabricName")]
        public string FabricName { get; set; }

        /// <summary>
        /// Gets or sets extended information (not returned in List container
        /// API calls)
        /// </summary>
        [JsonProperty(PropertyName = "extendedInformation")]
        public GenericContainerExtendedInfo ExtendedInformation { get; set; }

    }
}
