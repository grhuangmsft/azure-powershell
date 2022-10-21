// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Extensions;

    /// <summary>The network security perimeter link resource</summary>
    public partial class NspLink :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLink,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkInternal,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.ProxyResource();

        /// <summary>
        /// Perimeter ARM Id for the remote NSP with which the link gets created in Auto-approval mode. It should be used when the
        /// NSP admin have Microsoft.Network/networkSecurityPerimeters/linkPerimeter/action permission on the remote NSP resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Inlined)]
        public string AutoApprovedRemotePerimeterResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)Property).AutoApprovedRemotePerimeterResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)Property).AutoApprovedRemotePerimeterResourceId = value ?? null; }

        /// <summary>
        /// A message passed to the owner of the remote NSP link resource with this connection request. In case of Auto-approved flow,
        /// it is default to 'Auto Approved'. Restricted to 140 chars.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Inlined)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)Property).Description = value ?? null; }

        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Inherited)]
        public string Etag { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal)__proxyResource).Etag; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal)__proxyResource).Id; }

        /// <summary>
        /// Local Inbound profile names to which Inbound is allowed. Use ['*'] to allow inbound to all profiles. It's default value
        /// is ['*'].
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Inlined)]
        public string[] LocalInboundProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)Property).LocalInboundProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)Property).LocalInboundProfile = value ?? null /* arrayOf */; }

        /// <summary>
        /// Local Outbound profile names from which Outbound is allowed. In current version, it is readonly property and it's value
        /// is set to ['*'] to allow outbound from all profiles. In later version, user will be able to modify it.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Inlined)]
        public string[] LocalOutboundProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)Property).LocalOutboundProfile; }

        /// <summary>Internal Acessors for LocalOutboundProfile</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkInternal.LocalOutboundProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)Property).LocalOutboundProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)Property).LocalOutboundProfile = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkProperties Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.NspLinkProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for RemoteOutboundProfile</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkInternal.RemoteOutboundProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)Property).RemoteOutboundProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)Property).RemoteOutboundProfile = value; }

        /// <summary>Internal Acessors for RemotePerimeterGuid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkInternal.RemotePerimeterGuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)Property).RemotePerimeterGuid; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)Property).RemotePerimeterGuid = value; }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspLinkStatus? Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkInternal.Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)Property).Status = value; }

        /// <summary>Internal Acessors for Etag</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal.Etag { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal)__proxyResource).Etag; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal)__proxyResource).Etag = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal)__proxyResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal)__proxyResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal)__proxyResource).Type = value; }

        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal)__proxyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkProperties _property;

        /// <summary>Properties of the network security perimeter link resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.NspLinkProperties()); set => this._property = value; }

        /// <summary>The provisioning state of the NSP Link resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)Property).ProvisioningState; }

        /// <summary>
        /// Remote Inbound profile names to which Inbound is allowed. Use ['*'] to allow inbound to all profiles. This property can
        /// only be updated in auto-approval mode. It's default value is ['*'].
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Inlined)]
        public string[] RemoteInboundProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)Property).RemoteInboundProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)Property).RemoteInboundProfile = value ?? null /* arrayOf */; }

        /// <summary>
        /// Remote Outbound profile names from which Outbound is allowed. In current version, it is readonly property and it's value
        /// is set to ['*'] to allow outbound from all profiles. In later version, user will be able to modify it.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Inlined)]
        public string[] RemoteOutboundProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)Property).RemoteOutboundProfile; }

        /// <summary>Remote NSP Guid with which the link gets created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Inlined)]
        public string RemotePerimeterGuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)Property).RemotePerimeterGuid; }

        /// <summary>The NSP link state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspLinkStatus? Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal)Property).Status; }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal)__proxyResource).Type; }

        /// <summary>Creates an new <see cref="NspLink" /> instance.</summary>
        public NspLink()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// The network security perimeter link resource
    public partial interface INspLink :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResource
    {
        /// <summary>
        /// Perimeter ARM Id for the remote NSP with which the link gets created in Auto-approval mode. It should be used when the
        /// NSP admin have Microsoft.Network/networkSecurityPerimeters/linkPerimeter/action permission on the remote NSP resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Perimeter ARM Id for the remote NSP with which the link gets created in Auto-approval mode. It should be used when the NSP admin have Microsoft.Network/networkSecurityPerimeters/linkPerimeter/action permission on the remote NSP resource.",
        SerializedName = @"autoApprovedRemotePerimeterResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string AutoApprovedRemotePerimeterResourceId { get; set; }
        /// <summary>
        /// A message passed to the owner of the remote NSP link resource with this connection request. In case of Auto-approved flow,
        /// it is default to 'Auto Approved'. Restricted to 140 chars.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A message passed to the owner of the remote NSP link resource with this connection request. In case of Auto-approved flow, it is default to 'Auto Approved'. Restricted to 140 chars.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>
        /// Local Inbound profile names to which Inbound is allowed. Use ['*'] to allow inbound to all profiles. It's default value
        /// is ['*'].
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Local Inbound profile names to which Inbound is allowed. Use ['*'] to allow inbound to all profiles. It's default value is ['*'].",
        SerializedName = @"localInboundProfiles",
        PossibleTypes = new [] { typeof(string) })]
        string[] LocalInboundProfile { get; set; }
        /// <summary>
        /// Local Outbound profile names from which Outbound is allowed. In current version, it is readonly property and it's value
        /// is set to ['*'] to allow outbound from all profiles. In later version, user will be able to modify it.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Local Outbound profile names from which Outbound is allowed. In current version, it is readonly property and it's value is set to ['*'] to allow outbound from all profiles. In later version, user will be able to modify it.",
        SerializedName = @"localOutboundProfiles",
        PossibleTypes = new [] { typeof(string) })]
        string[] LocalOutboundProfile { get;  }
        /// <summary>The provisioning state of the NSP Link resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the NSP Link resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspProvisioningState? ProvisioningState { get;  }
        /// <summary>
        /// Remote Inbound profile names to which Inbound is allowed. Use ['*'] to allow inbound to all profiles. This property can
        /// only be updated in auto-approval mode. It's default value is ['*'].
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Remote Inbound profile names to which Inbound is allowed. Use ['*'] to allow inbound to all profiles. This property can only be updated in auto-approval mode. It's default value is ['*'].",
        SerializedName = @"remoteInboundProfiles",
        PossibleTypes = new [] { typeof(string) })]
        string[] RemoteInboundProfile { get; set; }
        /// <summary>
        /// Remote Outbound profile names from which Outbound is allowed. In current version, it is readonly property and it's value
        /// is set to ['*'] to allow outbound from all profiles. In later version, user will be able to modify it.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Remote Outbound profile names from which Outbound is allowed. In current version, it is readonly property and it's value is set to ['*'] to allow outbound from all profiles. In later version, user will be able to modify it.",
        SerializedName = @"remoteOutboundProfiles",
        PossibleTypes = new [] { typeof(string) })]
        string[] RemoteOutboundProfile { get;  }
        /// <summary>Remote NSP Guid with which the link gets created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Remote NSP Guid with which the link gets created.",
        SerializedName = @"remotePerimeterGuid",
        PossibleTypes = new [] { typeof(string) })]
        string RemotePerimeterGuid { get;  }
        /// <summary>The NSP link state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The NSP link state.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspLinkStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspLinkStatus? Status { get;  }

    }
    /// The network security perimeter link resource
    internal partial interface INspLinkInternal :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal
    {
        /// <summary>
        /// Perimeter ARM Id for the remote NSP with which the link gets created in Auto-approval mode. It should be used when the
        /// NSP admin have Microsoft.Network/networkSecurityPerimeters/linkPerimeter/action permission on the remote NSP resource.
        /// </summary>
        string AutoApprovedRemotePerimeterResourceId { get; set; }
        /// <summary>
        /// A message passed to the owner of the remote NSP link resource with this connection request. In case of Auto-approved flow,
        /// it is default to 'Auto Approved'. Restricted to 140 chars.
        /// </summary>
        string Description { get; set; }
        /// <summary>
        /// Local Inbound profile names to which Inbound is allowed. Use ['*'] to allow inbound to all profiles. It's default value
        /// is ['*'].
        /// </summary>
        string[] LocalInboundProfile { get; set; }
        /// <summary>
        /// Local Outbound profile names from which Outbound is allowed. In current version, it is readonly property and it's value
        /// is set to ['*'] to allow outbound from all profiles. In later version, user will be able to modify it.
        /// </summary>
        string[] LocalOutboundProfile { get; set; }
        /// <summary>Properties of the network security perimeter link resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkProperties Property { get; set; }
        /// <summary>The provisioning state of the NSP Link resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspProvisioningState? ProvisioningState { get; set; }
        /// <summary>
        /// Remote Inbound profile names to which Inbound is allowed. Use ['*'] to allow inbound to all profiles. This property can
        /// only be updated in auto-approval mode. It's default value is ['*'].
        /// </summary>
        string[] RemoteInboundProfile { get; set; }
        /// <summary>
        /// Remote Outbound profile names from which Outbound is allowed. In current version, it is readonly property and it's value
        /// is set to ['*'] to allow outbound from all profiles. In later version, user will be able to modify it.
        /// </summary>
        string[] RemoteOutboundProfile { get; set; }
        /// <summary>Remote NSP Guid with which the link gets created.</summary>
        string RemotePerimeterGuid { get; set; }
        /// <summary>The NSP link state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspLinkStatus? Status { get; set; }

    }
}