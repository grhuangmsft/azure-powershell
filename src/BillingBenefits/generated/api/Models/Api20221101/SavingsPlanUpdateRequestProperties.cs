// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Extensions;

    /// <summary>Savings plan patch request</summary>
    public partial class SavingsPlanUpdateRequestProperties :
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanUpdateRequestProperties,
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanUpdateRequestPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AppliedScopeProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopeProperties _appliedScopeProperty;

        /// <summary>Properties specific to applied scope type. Not required if not applicable.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopeProperties AppliedScopeProperty { get => (this._appliedScopeProperty = this._appliedScopeProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.AppliedScopeProperties()); set => this._appliedScopeProperty = value; }

        /// <summary>Display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string AppliedScopePropertyDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopePropertiesInternal)AppliedScopeProperty).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopePropertiesInternal)AppliedScopeProperty).DisplayName = value ?? null; }

        /// <summary>
        /// Fully-qualified identifier of the management group where the benefit must be applied.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string AppliedScopePropertyManagementGroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopePropertiesInternal)AppliedScopeProperty).ManagementGroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopePropertiesInternal)AppliedScopeProperty).ManagementGroupId = value ?? null; }

        /// <summary>Fully-qualified identifier of the resource group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string AppliedScopePropertyResourceGroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopePropertiesInternal)AppliedScopeProperty).ResourceGroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopePropertiesInternal)AppliedScopeProperty).ResourceGroupId = value ?? null; }

        /// <summary>Fully-qualified identifier of the subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string AppliedScopePropertySubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopePropertiesInternal)AppliedScopeProperty).SubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopePropertiesInternal)AppliedScopeProperty).SubscriptionId = value ?? null; }

        /// <summary>Tenant ID where the benefit is applied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string AppliedScopePropertyTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopePropertiesInternal)AppliedScopeProperty).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopePropertiesInternal)AppliedScopeProperty).TenantId = value ?? null; }

        /// <summary>Backing field for <see cref="AppliedScopeType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.AppliedScopeType? _appliedScopeType;

        /// <summary>Type of the Applied Scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.AppliedScopeType? AppliedScopeType { get => this._appliedScopeType; set => this._appliedScopeType = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Internal Acessors for AppliedScopeProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopeProperties Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanUpdateRequestPropertiesInternal.AppliedScopeProperty { get => (this._appliedScopeProperty = this._appliedScopeProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.AppliedScopeProperties()); set { {_appliedScopeProperty = value;} } }

        /// <summary>Backing field for <see cref="Renew" /> property.</summary>
        private bool? _renew;

        /// <summary>
        /// Setting this to true will automatically purchase a new benefit on the expiration date time.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        public bool? Renew { get => this._renew; set => this._renew = value; }

        /// <summary>Backing field for <see cref="RenewProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewProperties _renewProperty;

        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewProperties RenewProperty { get => (this._renewProperty = this._renewProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.RenewProperties()); set => this._renewProperty = value; }

        /// <summary>Creates an new <see cref="SavingsPlanUpdateRequestProperties" /> instance.</summary>
        public SavingsPlanUpdateRequestProperties()
        {

        }
    }
    /// Savings plan patch request
    public partial interface ISavingsPlanUpdateRequestProperties :
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.IJsonSerializable
    {
        /// <summary>Display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string AppliedScopePropertyDisplayName { get; set; }
        /// <summary>
        /// Fully-qualified identifier of the management group where the benefit must be applied.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully-qualified identifier of the management group where the benefit must be applied.",
        SerializedName = @"managementGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string AppliedScopePropertyManagementGroupId { get; set; }
        /// <summary>Fully-qualified identifier of the resource group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully-qualified identifier of the resource group.",
        SerializedName = @"resourceGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string AppliedScopePropertyResourceGroupId { get; set; }
        /// <summary>Fully-qualified identifier of the subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully-qualified identifier of the subscription.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string AppliedScopePropertySubscriptionId { get; set; }
        /// <summary>Tenant ID where the benefit is applied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Tenant ID where the benefit is applied.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string AppliedScopePropertyTenantId { get; set; }
        /// <summary>Type of the Applied Scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the Applied Scope.",
        SerializedName = @"appliedScopeType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.AppliedScopeType) })]
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.AppliedScopeType? AppliedScopeType { get; set; }
        /// <summary>Display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>
        /// Setting this to true will automatically purchase a new benefit on the expiration date time.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Setting this to true will automatically purchase a new benefit on the expiration date time.",
        SerializedName = @"renew",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Renew { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"renewProperties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewProperties RenewProperty { get; set; }

    }
    /// Savings plan patch request
    internal partial interface ISavingsPlanUpdateRequestPropertiesInternal

    {
        /// <summary>Properties specific to applied scope type. Not required if not applicable.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopeProperties AppliedScopeProperty { get; set; }
        /// <summary>Display name</summary>
        string AppliedScopePropertyDisplayName { get; set; }
        /// <summary>
        /// Fully-qualified identifier of the management group where the benefit must be applied.
        /// </summary>
        string AppliedScopePropertyManagementGroupId { get; set; }
        /// <summary>Fully-qualified identifier of the resource group.</summary>
        string AppliedScopePropertyResourceGroupId { get; set; }
        /// <summary>Fully-qualified identifier of the subscription.</summary>
        string AppliedScopePropertySubscriptionId { get; set; }
        /// <summary>Tenant ID where the benefit is applied.</summary>
        string AppliedScopePropertyTenantId { get; set; }
        /// <summary>Type of the Applied Scope.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.AppliedScopeType? AppliedScopeType { get; set; }
        /// <summary>Display name</summary>
        string DisplayName { get; set; }
        /// <summary>
        /// Setting this to true will automatically purchase a new benefit on the expiration date time.
        /// </summary>
        bool? Renew { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IRenewProperties RenewProperty { get; set; }

    }
}