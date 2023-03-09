// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Extensions;

    /// <summary>Pool of backend IP addresses.</summary>
    public partial class BackendAddressPool :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPool,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolInternal,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated __subResourceAutoGenerated = new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.SubResourceAutoGenerated();

        /// <summary>An array of references to IP addresses defined in network interfaces.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INetworkInterfaceIPConfiguration[] BackendIPConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal)Property).BackendIPConfiguration; }

        /// <summary>
        /// Amount of seconds Load Balancer waits for before sending RESET to client and backend address.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public int? DrainPeriodInSecond { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal)Property).DrainPeriodInSecond; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal)Property).DrainPeriodInSecond = value ?? default(int); }

        /// <summary>Backing field for <see cref="Etag" /> property.</summary>
        private string _etag;

        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string Etag { get => this._etag; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGeneratedInternal)__subResourceAutoGenerated).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGeneratedInternal)__subResourceAutoGenerated).Id = value ?? null; }

        /// <summary>An array of references to inbound NAT rules that use this backend address pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated[] InboundNatRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal)Property).InboundNatRule; }

        /// <summary>An array of backend addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddress[] LoadBalancerBackendAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal)Property).LoadBalancerBackendAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal)Property).LoadBalancerBackendAddress = value ?? null /* arrayOf */; }

        /// <summary>
        /// An array of references to load balancing rules that use this backend address pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated[] LoadBalancingRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal)Property).LoadBalancingRule; }

        /// <summary>The location of the backend address pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal)Property).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal)Property).Location = value ?? null; }

        /// <summary>Internal Acessors for BackendIPConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INetworkInterfaceIPConfiguration[] Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolInternal.BackendIPConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal)Property).BackendIPConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal)Property).BackendIPConfiguration = value; }

        /// <summary>Internal Acessors for Etag</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolInternal.Etag { get => this._etag; set { {_etag = value;} } }

        /// <summary>Internal Acessors for InboundNatRule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated[] Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolInternal.InboundNatRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal)Property).InboundNatRule; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal)Property).InboundNatRule = value; }

        /// <summary>Internal Acessors for LoadBalancingRule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated[] Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolInternal.LoadBalancingRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal)Property).LoadBalancingRule; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal)Property).LoadBalancingRule = value; }

        /// <summary>Internal Acessors for OutboundRule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolInternal.OutboundRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal)Property).OutboundRule; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal)Property).OutboundRule = value; }

        /// <summary>Internal Acessors for PropertiesOutboundRules</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated[] Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolInternal.PropertiesOutboundRules { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal)Property).OutboundRules; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal)Property).OutboundRules = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormat Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.BackendAddressPoolPropertiesFormat()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>
        /// The name of the resource that is unique within the set of backend address pools used by the load balancer. This name can
        /// be used to access the resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string OutboundRuleId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal)Property).OutboundRuleId; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal)Property).OutboundRuleId = value ?? null; }

        /// <summary>An array of references to outbound rules that use this backend address pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated[] PropertiesOutboundRules { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal)Property).OutboundRules; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormat _property;

        /// <summary>Properties of load balancer backend address pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormat Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.BackendAddressPoolPropertiesFormat()); set => this._property = value; }

        /// <summary>The provisioning state of the backend address pool resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal)Property).ProvisioningState; }

        /// <summary>An array of gateway load balancer tunnel interfaces.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IGatewayLoadBalancerTunnelInterface[] TunnelInterface { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal)Property).TunnelInterface; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal)Property).TunnelInterface = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="BackendAddressPool" /> instance.</summary>
        public BackendAddressPool()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__subResourceAutoGenerated), __subResourceAutoGenerated);
            await eventListener.AssertObjectIsValid(nameof(__subResourceAutoGenerated), __subResourceAutoGenerated);
        }
    }
    /// Pool of backend IP addresses.
    public partial interface IBackendAddressPool :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated
    {
        /// <summary>An array of references to IP addresses defined in network interfaces.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"An array of references to IP addresses defined in network interfaces.",
        SerializedName = @"backendIPConfigurations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INetworkInterfaceIPConfiguration) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INetworkInterfaceIPConfiguration[] BackendIPConfiguration { get;  }
        /// <summary>
        /// Amount of seconds Load Balancer waits for before sending RESET to client and backend address.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Amount of seconds Load Balancer waits for before sending RESET to client and backend address.",
        SerializedName = @"drainPeriodInSeconds",
        PossibleTypes = new [] { typeof(int) })]
        int? DrainPeriodInSecond { get; set; }
        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A unique read-only string that changes whenever the resource is updated.",
        SerializedName = @"etag",
        PossibleTypes = new [] { typeof(string) })]
        string Etag { get;  }
        /// <summary>An array of references to inbound NAT rules that use this backend address pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"An array of references to inbound NAT rules that use this backend address pool.",
        SerializedName = @"inboundNatRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated[] InboundNatRule { get;  }
        /// <summary>An array of backend addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An array of backend addresses.",
        SerializedName = @"loadBalancerBackendAddresses",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddress) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddress[] LoadBalancerBackendAddress { get; set; }
        /// <summary>
        /// An array of references to load balancing rules that use this backend address pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"An array of references to load balancing rules that use this backend address pool.",
        SerializedName = @"loadBalancingRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated[] LoadBalancingRule { get;  }
        /// <summary>The location of the backend address pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The location of the backend address pool.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>
        /// The name of the resource that is unique within the set of backend address pools used by the load balancer. This name can
        /// be used to access the resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the resource that is unique within the set of backend address pools used by the load balancer. This name can be used to access the resource.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string OutboundRuleId { get; set; }
        /// <summary>An array of references to outbound rules that use this backend address pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"An array of references to outbound rules that use this backend address pool.",
        SerializedName = @"outboundRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated[] PropertiesOutboundRules { get;  }
        /// <summary>The provisioning state of the backend address pool resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the backend address pool resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>An array of gateway load balancer tunnel interfaces.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An array of gateway load balancer tunnel interfaces.",
        SerializedName = @"tunnelInterfaces",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IGatewayLoadBalancerTunnelInterface) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IGatewayLoadBalancerTunnelInterface[] TunnelInterface { get; set; }
        /// <summary>Type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Type of the resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// Pool of backend IP addresses.
    internal partial interface IBackendAddressPoolInternal :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGeneratedInternal
    {
        /// <summary>An array of references to IP addresses defined in network interfaces.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INetworkInterfaceIPConfiguration[] BackendIPConfiguration { get; set; }
        /// <summary>
        /// Amount of seconds Load Balancer waits for before sending RESET to client and backend address.
        /// </summary>
        int? DrainPeriodInSecond { get; set; }
        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        string Etag { get; set; }
        /// <summary>An array of references to inbound NAT rules that use this backend address pool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated[] InboundNatRule { get; set; }
        /// <summary>An array of backend addresses.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddress[] LoadBalancerBackendAddress { get; set; }
        /// <summary>
        /// An array of references to load balancing rules that use this backend address pool.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated[] LoadBalancingRule { get; set; }
        /// <summary>The location of the backend address pool.</summary>
        string Location { get; set; }
        /// <summary>
        /// The name of the resource that is unique within the set of backend address pools used by the load balancer. This name can
        /// be used to access the resource.
        /// </summary>
        string Name { get; set; }
        /// <summary>A reference to an outbound rule that uses this backend address pool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated OutboundRule { get; set; }
        /// <summary>Resource ID.</summary>
        string OutboundRuleId { get; set; }
        /// <summary>An array of references to outbound rules that use this backend address pool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated[] PropertiesOutboundRules { get; set; }
        /// <summary>Properties of load balancer backend address pool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormat Property { get; set; }
        /// <summary>The provisioning state of the backend address pool resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>An array of gateway load balancer tunnel interfaces.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IGatewayLoadBalancerTunnelInterface[] TunnelInterface { get; set; }
        /// <summary>Type of the resource.</summary>
        string Type { get; set; }

    }
}