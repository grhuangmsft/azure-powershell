// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Extensions;

    /// <summary>Device Update account details.</summary>
    public partial class Account :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IAccount,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IAccountInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.TrackedResource();

        /// <summary>API host name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public string HostName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IAccountPropertiesInternal)Property).HostName; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).Id; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IManagedServiceIdentity _identity;

        /// <summary>The type of identity used for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IManagedServiceIdentity Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.ManagedServiceIdentity()); set => this._identity = value; }

        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IManagedServiceIdentityInternal)Identity).PrincipalId; }

        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IManagedServiceIdentityInternal)Identity).TenantId; }

        /// <summary>
        /// Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.ManagedServiceIdentityType? IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IManagedServiceIdentityInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IManagedServiceIdentityInternal)Identity).Type = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.ManagedServiceIdentityType)""); }

        /// <summary>
        /// The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
        /// The dictionary values can be empty objects ({}) in requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.FormatTable(Index = 1)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.ITrackedResourceInternal)__trackedResource).Location = value ; }

        /// <summary>Internal Acessors for HostName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IAccountInternal.HostName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IAccountPropertiesInternal)Property).HostName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IAccountPropertiesInternal)Property).HostName = value; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IManagedServiceIdentity Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IAccountInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.ManagedServiceIdentity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IAccountInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IManagedServiceIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IManagedServiceIdentityInternal)Identity).PrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IAccountInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IManagedServiceIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IManagedServiceIdentityInternal)Identity).TenantId = value; }

        /// <summary>Internal Acessors for PropertiesLocations</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.ILocation[] Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IAccountInternal.PropertiesLocations { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IAccountPropertiesInternal)Property).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IAccountPropertiesInternal)Property).Location = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IAccountProperties Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IAccountInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.AccountProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IAccountInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IAccountPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IAccountPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.ISystemData Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.FormatTable(Index = 0)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).Name; }

        /// <summary>List of private endpoint connections associated with the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnection[] PrivateEndpointConnection { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IAccountPropertiesInternal)Property).PrivateEndpointConnection; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IAccountPropertiesInternal)Property).PrivateEndpointConnection = value ?? null /* arrayOf */; }

        /// <summary>Device Update account primary and failover location details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.ILocation[] PropertiesLocations { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IAccountPropertiesInternal)Property).Location; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IAccountProperties _property;

        /// <summary>Device Update account properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IAccountProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.AccountProperties()); set => this._property = value; }

        /// <summary>Provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IAccountPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Whether or not public network access is allowed for the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.PublicNetworkAccess? PublicNetworkAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IAccountPropertiesInternal)Property).PublicNetworkAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IAccountPropertiesInternal)Property).PublicNetworkAccess = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.PublicNetworkAccess)""); }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.FormatTable(Index = 3)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Device Update Sku</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.FormatTable(Index = 2)]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.Sku? Sku { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IAccountPropertiesInternal)Property).Sku; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IAccountPropertiesInternal)Property).Sku = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.Sku)""); }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.CreatedByType)""); }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).Type; }

        /// <summary>Creates an new <see cref="Account" /> instance.</summary>
        public Account()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// Device Update account details.
    public partial interface IAccount :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.ITrackedResource
    {
        /// <summary>API host name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"API host name.",
        SerializedName = @"hostName",
        PossibleTypes = new [] { typeof(string) })]
        string HostName { get;  }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get;  }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get;  }
        /// <summary>
        /// Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.ManagedServiceIdentityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.ManagedServiceIdentityType? IdentityType { get; set; }
        /// <summary>
        /// The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
        /// The dictionary values can be empty objects ({}) in requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}. The dictionary values can be empty objects ({}) in requests.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>List of private endpoint connections associated with the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of private endpoint connections associated with the account.",
        SerializedName = @"privateEndpointConnections",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnection) })]
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnection[] PrivateEndpointConnection { get; set; }
        /// <summary>Device Update account primary and failover location details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Device Update account primary and failover location details",
        SerializedName = @"locations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.ILocation) })]
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.ILocation[] PropertiesLocations { get;  }
        /// <summary>Provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning state.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>Whether or not public network access is allowed for the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether or not public network access is allowed for the account.",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.PublicNetworkAccess) })]
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary>Device Update Sku</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Device Update Sku",
        SerializedName = @"sku",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.Sku) })]
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.Sku? Sku { get; set; }

    }
    /// Device Update account details.
    internal partial interface IAccountInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.ITrackedResourceInternal
    {
        /// <summary>API host name.</summary>
        string HostName { get; set; }
        /// <summary>The type of identity used for the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IManagedServiceIdentity Identity { get; set; }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityTenantId { get; set; }
        /// <summary>
        /// Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.ManagedServiceIdentityType? IdentityType { get; set; }
        /// <summary>
        /// The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
        /// The dictionary values can be empty objects ({}) in requests.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>List of private endpoint connections associated with the account.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IPrivateEndpointConnection[] PrivateEndpointConnection { get; set; }
        /// <summary>Device Update account primary and failover location details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.ILocation[] PropertiesLocations { get; set; }
        /// <summary>Device Update account properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IAccountProperties Property { get; set; }
        /// <summary>Provisioning state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Whether or not public network access is allowed for the account.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary>Device Update Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.Sku? Sku { get; set; }

    }
}