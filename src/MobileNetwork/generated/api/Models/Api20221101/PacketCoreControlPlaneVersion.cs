// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Extensions;

    /// <summary>Packet core control plane version resource.</summary>
    public partial class PacketCoreControlPlaneVersion :
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPacketCoreControlPlaneVersion,
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPacketCoreControlPlaneVersionInternal,
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.Resource();

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.DoNotFormat]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResourceInternal)__resource).Id; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPacketCoreControlPlaneVersionPropertiesFormat Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPacketCoreControlPlaneVersionInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.PacketCoreControlPlaneVersionPropertiesFormat()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPacketCoreControlPlaneVersionInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPacketCoreControlPlaneVersionPropertiesFormatInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPacketCoreControlPlaneVersionPropertiesFormatInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.ISystemData Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResourceInternal)__resource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResourceInternal)__resource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResourceInternal)__resource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.FormatTable(Index = 0)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResourceInternal)__resource).Name; }

        /// <summary>Platform specific packet core control plane version properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPlatform[] Platform { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPacketCoreControlPlaneVersionPropertiesFormatInternal)Property).Platform; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPacketCoreControlPlaneVersionPropertiesFormatInternal)Property).Platform = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPacketCoreControlPlaneVersionPropertiesFormat _property;

        /// <summary>Packet core control plane version properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPacketCoreControlPlaneVersionPropertiesFormat Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.PacketCoreControlPlaneVersionPropertiesFormat()); set => this._property = value; }

        /// <summary>The provisioning state of the packet core control plane version resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPacketCoreControlPlaneVersionPropertiesFormatInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.DoNotFormat]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResourceInternal)__resource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.DoNotFormat]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResourceInternal)__resource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResourceInternal)__resource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.DoNotFormat]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResourceInternal)__resource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResourceInternal)__resource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResourceInternal)__resource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResourceInternal)__resource).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.DoNotFormat]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.DoNotFormat]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.CreatedByType)""); }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.DoNotFormat]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="PacketCoreControlPlaneVersion" /> instance.</summary>
        public PacketCoreControlPlaneVersion()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Packet core control plane version resource.
    public partial interface IPacketCoreControlPlaneVersion :
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResource
    {
        /// <summary>Platform specific packet core control plane version properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Platform specific packet core control plane version properties.",
        SerializedName = @"platforms",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPlatform) })]
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPlatform[] Platform { get; set; }
        /// <summary>The provisioning state of the packet core control plane version resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the packet core control plane version resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState? ProvisioningState { get;  }

    }
    /// Packet core control plane version resource.
    internal partial interface IPacketCoreControlPlaneVersionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IResourceInternal
    {
        /// <summary>Platform specific packet core control plane version properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPlatform[] Platform { get; set; }
        /// <summary>Packet core control plane version properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPacketCoreControlPlaneVersionPropertiesFormat Property { get; set; }
        /// <summary>The provisioning state of the packet core control plane version resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState? ProvisioningState { get; set; }

    }
}