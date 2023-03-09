// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Extensions;

    /// <summary>Container group diagnostic information.</summary>
    public partial class ContainerGroupDiagnostics :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IContainerGroupDiagnostics,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IContainerGroupDiagnosticsInternal
    {

        /// <summary>Backing field for <see cref="LogAnalytic" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.ILogAnalytics _logAnalytic;

        /// <summary>Container group log analytics information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.ILogAnalytics LogAnalytic { get => (this._logAnalytic = this._logAnalytic ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.LogAnalytics()); set => this._logAnalytic = value; }

        /// <summary>The log type to be used.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.LogAnalyticsLogType? LogAnalyticLogType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.ILogAnalyticsInternal)LogAnalytic).LogType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.ILogAnalyticsInternal)LogAnalytic).LogType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.LogAnalyticsLogType)""); }

        /// <summary>Metadata for log analytics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.ILogAnalyticsMetadata LogAnalyticMetadata { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.ILogAnalyticsInternal)LogAnalytic).Metadata; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.ILogAnalyticsInternal)LogAnalytic).Metadata = value ?? null /* model class */; }

        /// <summary>The workspace id for log analytics</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public string LogAnalyticWorkspaceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.ILogAnalyticsInternal)LogAnalytic).WorkspaceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.ILogAnalyticsInternal)LogAnalytic).WorkspaceId = value ?? null; }

        /// <summary>The workspace key for log analytics</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public string LogAnalyticWorkspaceKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.ILogAnalyticsInternal)LogAnalytic).WorkspaceKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.ILogAnalyticsInternal)LogAnalytic).WorkspaceKey = value ?? null; }

        /// <summary>The workspace resource id for log analytics</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public string LogAnalyticWorkspaceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.ILogAnalyticsInternal)LogAnalytic).WorkspaceResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.ILogAnalyticsInternal)LogAnalytic).WorkspaceResourceId = value ?? null; }

        /// <summary>Internal Acessors for LogAnalytic</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.ILogAnalytics Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.IContainerGroupDiagnosticsInternal.LogAnalytic { get => (this._logAnalytic = this._logAnalytic ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.LogAnalytics()); set { {_logAnalytic = value;} } }

        /// <summary>Creates an new <see cref="ContainerGroupDiagnostics" /> instance.</summary>
        public ContainerGroupDiagnostics()
        {

        }
    }
    /// Container group diagnostic information.
    public partial interface IContainerGroupDiagnostics :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.IJsonSerializable
    {
        /// <summary>The log type to be used.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The log type to be used.",
        SerializedName = @"logType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.LogAnalyticsLogType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.LogAnalyticsLogType? LogAnalyticLogType { get; set; }
        /// <summary>Metadata for log analytics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Metadata for log analytics.",
        SerializedName = @"metadata",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.ILogAnalyticsMetadata) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.ILogAnalyticsMetadata LogAnalyticMetadata { get; set; }
        /// <summary>The workspace id for log analytics</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The workspace id for log analytics",
        SerializedName = @"workspaceId",
        PossibleTypes = new [] { typeof(string) })]
        string LogAnalyticWorkspaceId { get; set; }
        /// <summary>The workspace key for log analytics</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The workspace key for log analytics",
        SerializedName = @"workspaceKey",
        PossibleTypes = new [] { typeof(string) })]
        string LogAnalyticWorkspaceKey { get; set; }
        /// <summary>The workspace resource id for log analytics</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The workspace resource id for log analytics",
        SerializedName = @"workspaceResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string LogAnalyticWorkspaceResourceId { get; set; }

    }
    /// Container group diagnostic information.
    internal partial interface IContainerGroupDiagnosticsInternal

    {
        /// <summary>Container group log analytics information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.ILogAnalytics LogAnalytic { get; set; }
        /// <summary>The log type to be used.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.LogAnalyticsLogType? LogAnalyticLogType { get; set; }
        /// <summary>Metadata for log analytics.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20221001Preview.ILogAnalyticsMetadata LogAnalyticMetadata { get; set; }
        /// <summary>The workspace id for log analytics</summary>
        string LogAnalyticWorkspaceId { get; set; }
        /// <summary>The workspace key for log analytics</summary>
        string LogAnalyticWorkspaceKey { get; set; }
        /// <summary>The workspace resource id for log analytics</summary>
        string LogAnalyticWorkspaceResourceId { get; set; }

    }
}