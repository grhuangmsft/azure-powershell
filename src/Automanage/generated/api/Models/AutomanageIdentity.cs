// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Extensions;

    public partial class AutomanageIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.IAutomanageIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.Automanage.Models.IAutomanageIdentityInternal
    {

        /// <summary>Backing field for <see cref="BestPracticeName" /> property.</summary>
        private string _bestPracticeName;

        /// <summary>The Automanage best practice name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Automanage.PropertyOrigin.Owned)]
        public string BestPracticeName { get => this._bestPracticeName; set => this._bestPracticeName = value; }

        /// <summary>Backing field for <see cref="ClusterName" /> property.</summary>
        private string _clusterName;

        /// <summary>The name of the Arc machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Automanage.PropertyOrigin.Owned)]
        public string ClusterName { get => this._clusterName; set => this._clusterName = value; }

        /// <summary>Backing field for <see cref="ConfigurationProfileAssignmentName" /> property.</summary>
        private string _configurationProfileAssignmentName;

        /// <summary>Name of the configuration profile assignment. Only default is supported.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Automanage.PropertyOrigin.Owned)]
        public string ConfigurationProfileAssignmentName { get => this._configurationProfileAssignmentName; set => this._configurationProfileAssignmentName = value; }

        /// <summary>Backing field for <see cref="ConfigurationProfileName" /> property.</summary>
        private string _configurationProfileName;

        /// <summary>Name of the configuration profile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Automanage.PropertyOrigin.Owned)]
        public string ConfigurationProfileName { get => this._configurationProfileName; set => this._configurationProfileName = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Automanage.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="MachineName" /> property.</summary>
        private string _machineName;

        /// <summary>The name of the Arc machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Automanage.PropertyOrigin.Owned)]
        public string MachineName { get => this._machineName; set => this._machineName = value; }

        /// <summary>Backing field for <see cref="ReportName" /> property.</summary>
        private string _reportName;

        /// <summary>The report name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Automanage.PropertyOrigin.Owned)]
        public string ReportName { get => this._reportName; set => this._reportName = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Automanage.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Automanage.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Backing field for <see cref="VMName" /> property.</summary>
        private string _vMName;

        /// <summary>The name of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Automanage.PropertyOrigin.Owned)]
        public string VMName { get => this._vMName; set => this._vMName = value; }

        /// <summary>Backing field for <see cref="VersionName" /> property.</summary>
        private string _versionName;

        /// <summary>The Automanage best practice version name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Automanage.PropertyOrigin.Owned)]
        public string VersionName { get => this._versionName; set => this._versionName = value; }

        /// <summary>Creates an new <see cref="AutomanageIdentity" /> instance.</summary>
        public AutomanageIdentity()
        {

        }
    }
    public partial interface IAutomanageIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.IJsonSerializable
    {
        /// <summary>The Automanage best practice name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Automanage best practice name.",
        SerializedName = @"bestPracticeName",
        PossibleTypes = new [] { typeof(string) })]
        string BestPracticeName { get; set; }
        /// <summary>The name of the Arc machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the Arc machine.",
        SerializedName = @"clusterName",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterName { get; set; }
        /// <summary>Name of the configuration profile assignment. Only default is supported.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the configuration profile assignment. Only default is supported.",
        SerializedName = @"configurationProfileAssignmentName",
        PossibleTypes = new [] { typeof(string) })]
        string ConfigurationProfileAssignmentName { get; set; }
        /// <summary>Name of the configuration profile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the configuration profile.",
        SerializedName = @"configurationProfileName",
        PossibleTypes = new [] { typeof(string) })]
        string ConfigurationProfileName { get; set; }
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The name of the Arc machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the Arc machine.",
        SerializedName = @"machineName",
        PossibleTypes = new [] { typeof(string) })]
        string MachineName { get; set; }
        /// <summary>The report name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The report name.",
        SerializedName = @"reportName",
        PossibleTypes = new [] { typeof(string) })]
        string ReportName { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the resource group. The name is case insensitive.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroupName { get; set; }
        /// <summary>The ID of the target subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ID of the target subscription.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }
        /// <summary>The name of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the virtual machine.",
        SerializedName = @"vmName",
        PossibleTypes = new [] { typeof(string) })]
        string VMName { get; set; }
        /// <summary>The Automanage best practice version name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Automanage.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Automanage best practice version name.",
        SerializedName = @"versionName",
        PossibleTypes = new [] { typeof(string) })]
        string VersionName { get; set; }

    }
    internal partial interface IAutomanageIdentityInternal

    {
        /// <summary>The Automanage best practice name.</summary>
        string BestPracticeName { get; set; }
        /// <summary>The name of the Arc machine.</summary>
        string ClusterName { get; set; }
        /// <summary>Name of the configuration profile assignment. Only default is supported.</summary>
        string ConfigurationProfileAssignmentName { get; set; }
        /// <summary>Name of the configuration profile.</summary>
        string ConfigurationProfileName { get; set; }
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>The name of the Arc machine.</summary>
        string MachineName { get; set; }
        /// <summary>The report name.</summary>
        string ReportName { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        string ResourceGroupName { get; set; }
        /// <summary>The ID of the target subscription.</summary>
        string SubscriptionId { get; set; }
        /// <summary>The name of the virtual machine.</summary>
        string VMName { get; set; }
        /// <summary>The Automanage best practice version name.</summary>
        string VersionName { get; set; }

    }
}