// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Runtime.Extensions;

    /// <summary>Check quota availability response object.</summary>
    public partial class CheckQuotaAvailabilityResponse :
        Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201.ICheckQuotaAvailabilityResponse,
        Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201.ICheckQuotaAvailabilityResponseInternal,
        Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.Resource();

        /// <summary>Message indicating additional details to add to quota support request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Origin(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.PropertyOrigin.Inlined)]
        public string AvailabilityStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201.ICheckQuotaAvailabilityResponsePropertiesInternal)Property).AvailabilityStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201.ICheckQuotaAvailabilityResponsePropertiesInternal)Property).AvailabilityStatus = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Origin(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResourceInternal)__resource).Id; }

        /// <summary>
        /// True/False indicating whether the quota request be granted based on availability.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Origin(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.PropertyOrigin.Inlined)]
        public bool? IsAvailable { get => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201.ICheckQuotaAvailabilityResponsePropertiesInternal)Property).IsAvailable; set => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201.ICheckQuotaAvailabilityResponsePropertiesInternal)Property).IsAvailable = value ?? default(bool); }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201.ICheckQuotaAvailabilityResponseProperties Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201.ICheckQuotaAvailabilityResponseInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201.CheckQuotaAvailabilityResponseProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.ISystemData Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResourceInternal)__resource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResourceInternal)__resource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResourceInternal)__resource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Origin(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201.ICheckQuotaAvailabilityResponseProperties _property;

        /// <summary>Check quota availability response properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Origin(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201.ICheckQuotaAvailabilityResponseProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201.CheckQuotaAvailabilityResponseProperties()); set => this._property = value; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Origin(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Origin(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.PropertyOrigin.Inherited)]
        private Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResourceInternal)__resource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Origin(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResourceInternal)__resource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResourceInternal)__resource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Origin(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResourceInternal)__resource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResourceInternal)__resource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Origin(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResourceInternal)__resource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResourceInternal)__resource).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Origin(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Origin(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Origin(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Support.CreatedByType)""); }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Origin(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="CheckQuotaAvailabilityResponse" /> instance.</summary>
        public CheckQuotaAvailabilityResponse()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Check quota availability response object.
    public partial interface ICheckQuotaAvailabilityResponse :
        Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResource
    {
        /// <summary>Message indicating additional details to add to quota support request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Message indicating additional details to add to quota support request.",
        SerializedName = @"availabilityStatus",
        PossibleTypes = new [] { typeof(string) })]
        string AvailabilityStatus { get; set; }
        /// <summary>
        /// True/False indicating whether the quota request be granted based on availability.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"True/False indicating whether the quota request be granted based on availability.",
        SerializedName = @"isAvailable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsAvailable { get; set; }

    }
    /// Check quota availability response object.
    internal partial interface ICheckQuotaAvailabilityResponseInternal :
        Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api30.IResourceInternal
    {
        /// <summary>Message indicating additional details to add to quota support request.</summary>
        string AvailabilityStatus { get; set; }
        /// <summary>
        /// True/False indicating whether the quota request be granted based on availability.
        /// </summary>
        bool? IsAvailable { get; set; }
        /// <summary>Check quota availability response properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201.ICheckQuotaAvailabilityResponseProperties Property { get; set; }

    }
}