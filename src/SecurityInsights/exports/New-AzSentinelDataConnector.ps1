
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Creates or updates the data connector.
.Description
Creates or updates the data connector.
.Example

.Example
New-AzSentinelDataConnector -ResourceGroupName "myResourceGroupName" -workspaceName "myWorkspaceName" -Kind 'MicrosoftThreatIntelligence' -BingSafetyPhishingURL Enabled -BingSafetyPhishingUrlLookbackPeriod All  -MicrosoftEmergingThreatFeed Enabled -MicrosoftEmergingThreatFeedLookbackPeriod All

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.DataConnector
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

PERMISSIONCUSTOM <PermissionsCustomsItem[]>: [Parameter(ParameterSetName = 'APIPolling')]
  [Description <String>]: Customs permissions description
  [Name <String>]: Customs permissions name

PERMISSIONRESOURCEPROVIDER <PermissionsResourceProviderItem[]>: [Parameter(ParameterSetName = 'APIPolling')]
  [PermissionsDisplayText <String>]: Permission description text
  [Provider <ProviderName?>]: Provider name
  [ProviderDisplayName <String>]: Permission provider display name
  [RequiredPermissionAction <Boolean?>]: action permission
  [RequiredPermissionDelete <Boolean?>]: delete permission
  [RequiredPermissionRead <Boolean?>]: read permission
  [RequiredPermissionWrite <Boolean?>]: write permission
  [Scope <PermissionProviderScope?>]: Permission provider scope

UICONFIGCONNECTIVITYCRITERION <ConnectivityCriteria[]>: [Parameter(ParameterSetName = 'APIPolling', Mandatory)]
  [Type <ConnectivityType?>]: type of connectivity
  [Value <String[]>]: Queries for checking connectivity

UICONFIGDATATYPE <LastDataReceivedDataType[]>: [Parameter(ParameterSetName = 'APIPolling', Mandatory)]
  [LastDataReceivedQuery <String>]: Query for indicate last data received
  [Name <String>]: Name of the data type to show in the graph. can be use with {{graphQueriesTableName}} placeholder

UICONFIGGRAPHQUERY <GraphQueries[]>: [Parameter(ParameterSetName = 'APIPolling', Mandatory)]
  [BaseQuery <String>]: The base query for the graph
  [Legend <String>]: The legend for the graph
  [MetricName <String>]: the metric that the query is checking

UICONFIGINSTRUCTIONSTEP <InstructionSteps[]>: [Parameter(ParameterSetName = 'APIPolling', Mandatory)]
  [Description <String>]: Instruction step description
  [Instruction <IConnectorInstructionModelBase[]>]: Instruction step details
    Type <SettingType>: The kind of the setting
    [Parameter <IAny>]: The parameters for the setting
  [Title <String>]: Instruction step title

UICONFIGSAMPLEQUERY <SampleQueries[]>: [Parameter(ParameterSetName = 'APIPolling', Mandatory)]
  [Description <String>]: The sample query description
  [Query <String>]: the sample query
.Link
https://docs.microsoft.com/powershell/module/az.securityinsights/new-azsentineldataconnector
#>
function New-AzSentinelDataConnector {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.DataConnector])]
[CmdletBinding(DefaultParameterSetName='AADAATP', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Path')]
    [System.String]
    # The Resource Group Name.
    ${ResourceGroupName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Gets subscription credentials which uniquely identify Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.DefaultInfo(Script='(New-Guid).Guid')]
    [System.String]
    # The Id of the Data Connector.
    ${Id},

    [Parameter(Mandatory)]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DataConnectorKind])]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DataConnectorKind]
    # Kind of the the data connection
    ${Kind},

    [Parameter(ParameterSetName='AADAATP')]
    [Parameter(ParameterSetName='ThreatIntelligenceTaxii')]
    [Parameter(ParameterSetName='ThreatIntelligence')]
    [Parameter(ParameterSetName='OfficeIRM')]
    [Parameter(ParameterSetName='OfficeATP')]
    [Parameter(ParameterSetName='Office365')]
    [Parameter(ParameterSetName='MicrosoftThreatProtection')]
    [Parameter(ParameterSetName='MicrosoftThreatIntelligence')]
    [Parameter(ParameterSetName='MicrosoftDefenderAdvancedThreatProtection')]
    [Parameter(ParameterSetName='MicrosoftCloudAppSecurity')]
    [Parameter(ParameterSetName='Dynamics365')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Tenant.Id')]
    [System.String]
    # The TenantId.
    ${TenantId},

    [Parameter(ParameterSetName='AADAATP')]
    [Parameter(ParameterSetName='OfficeIRM')]
    [Parameter(ParameterSetName='OfficeATP')]
    [Parameter(ParameterSetName='MicrosoftDefenderAdvancedThreatProtection')]
    [Parameter(ParameterSetName='MicrosoftCloudAppSecurity')]
    [Parameter(ParameterSetName='AzureSecurityCenter')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DataTypeState])]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    ${Alerts},

    [Parameter(ParameterSetName='ThreatIntelligenceTaxii', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    ${WorkspaceId},

    [Parameter(ParameterSetName='ThreatIntelligenceTaxii', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    ${FriendlyName},

    [Parameter(ParameterSetName='ThreatIntelligenceTaxii', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    ${APIRootURL},

    [Parameter(ParameterSetName='ThreatIntelligenceTaxii', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    ${CollectionId},

    [Parameter(ParameterSetName='ThreatIntelligenceTaxii', Mandatory)]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.PollingFrequency])]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.PollingFrequency]
    ${PollingFrequency},

    [Parameter(ParameterSetName='ThreatIntelligenceTaxii')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    ${UserName},

    [Parameter(ParameterSetName='ThreatIntelligenceTaxii')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    ${Password},

    [Parameter(ParameterSetName='ThreatIntelligenceTaxii')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    ${TaxiiLookbackPeriod},

    [Parameter(ParameterSetName='ThreatIntelligence')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DataTypeState])]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    ${Indicator},

    [Parameter(ParameterSetName='Office365')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DataTypeState])]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    ${Exchange},

    [Parameter(ParameterSetName='Office365')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DataTypeState])]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    ${SharePoint},

    [Parameter(ParameterSetName='Office365')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DataTypeState])]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    ${Teams},

    [Parameter(ParameterSetName='MicrosoftThreatProtection')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DataTypeState])]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    ${Incident},

    [Parameter(ParameterSetName='MicrosoftThreatIntelligence')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DataTypeState])]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    ${BingSafetyPhishingURL},

    [Parameter(ParameterSetName='MicrosoftThreatIntelligence')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    ${BingSafetyPhishingUrlLookbackPeriod},

    [Parameter(ParameterSetName='MicrosoftThreatIntelligence')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DataTypeState])]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    ${MicrosoftEmergingThreatFeed},

    [Parameter(ParameterSetName='MicrosoftThreatIntelligence')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    ${MicrosoftEmergingThreatFeedLookbackPeriod},

    [Parameter(ParameterSetName='MicrosoftCloudAppSecurity')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DataTypeState])]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    ${DiscoveryLog},

    [Parameter(ParameterSetName='Dynamics365')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DataTypeState])]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    ${CommonDataServiceActivity},

    [Parameter(ParameterSetName='AzureSecurityCenter', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    # ASC Subscription Id.
    ${ASCSubscriptionId},

    [Parameter(ParameterSetName='AmazonWebServicesS3', Mandatory)]
    [Parameter(ParameterSetName='AmazonWebServicesCloudTrail', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    ${AWSRoleArn},

    [Parameter(ParameterSetName='AmazonWebServicesS3', Mandatory)]
    [Parameter(ParameterSetName='AmazonWebServicesCloudTrail')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DataTypeState])]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    ${Log},

    [Parameter(ParameterSetName='AmazonWebServicesS3', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String[]]
    ${SQSURL},

    [Parameter(ParameterSetName='AmazonWebServicesS3', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    ${DetinationTable},

    [Parameter(ParameterSetName='GenericUI', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    # [Parameter(ParameterSetName = 'APIPolling', Mandatory)]
    ${UiConfigTitle},

    [Parameter(ParameterSetName='GenericUI', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    # [Parameter(ParameterSetName = 'APIPolling', Mandatory)]
    ${UiConfigPublisher},

    [Parameter(ParameterSetName='GenericUI', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    # [Parameter(ParameterSetName = 'APIPolling', Mandatory)]
    ${UiConfigDescriptionMarkdown},

    [Parameter(ParameterSetName='GenericUI', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    # [Parameter(ParameterSetName = 'APIPolling', Mandatory)]
    ${UiConfigGraphQueriesTableName},

    [Parameter(ParameterSetName='GenericUI', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.GraphQueries[]]
    # [Parameter(ParameterSetName = 'APIPolling', Mandatory)]
    # To construct, see NOTES section for UICONFIGGRAPHQUERY properties and create a hash table.
    ${UiConfigGraphQuery},

    [Parameter(ParameterSetName='GenericUI', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.SampleQueries[]]
    # [Parameter(ParameterSetName = 'APIPolling', Mandatory)]
    # To construct, see NOTES section for UICONFIGSAMPLEQUERY properties and create a hash table.
    ${UiConfigSampleQuery},

    [Parameter(ParameterSetName='GenericUI', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.LastDataReceivedDataType[]]
    # [Parameter(ParameterSetName = 'APIPolling', Mandatory)]
    # To construct, see NOTES section for UICONFIGDATATYPE properties and create a hash table.
    ${UiConfigDataType},

    [Parameter(ParameterSetName='GenericUI', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ConnectivityCriteria[]]
    # [Parameter(ParameterSetName = 'APIPolling', Mandatory)]
    # To construct, see NOTES section for UICONFIGCONNECTIVITYCRITERION properties and create a hash table.
    ${UiConfigConnectivityCriterion},

    [Parameter(ParameterSetName='GenericUI', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.Boolean]
    # [Parameter(ParameterSetName = 'APIPolling', Mandatory)]
    ${AvailabilityIsPreview},

    [Parameter(ParameterSetName='GenericUI', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.InstructionSteps[]]
    # [Parameter(ParameterSetName = 'APIPolling', Mandatory)]
    # To construct, see NOTES section for UICONFIGINSTRUCTIONSTEP properties and create a hash table.
    ${UiConfigInstructionStep},

    [Parameter(ParameterSetName='GenericUI')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [System.String]
    # [Parameter(ParameterSetName = 'APIPolling')]
    ${UiConfigCustomImage},

    [Parameter(ParameterSetName='GenericUI')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.DefaultInfo(Script='1')]
    [System.Int32]
    # [Parameter(ParameterSetName = 'APIPolling')]
    ${AvailabilityStatus},

    [Parameter(ParameterSetName='GenericUI')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.PermissionsResourceProviderItem[]]
    # [Parameter(ParameterSetName = 'APIPolling')]
    # To construct, see NOTES section for PERMISSIONRESOURCEPROVIDER properties and create a hash table.
    ${PermissionResourceProvider},

    [Parameter(ParameterSetName='GenericUI')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.PermissionsCustomsItem[]]
    # [Parameter(ParameterSetName = 'APIPolling')]
    # To construct, see NOTES section for PERMISSIONCUSTOM properties and create a hash table.
    ${PermissionCustom},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName

        if ($null -eq [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion) {
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $Host.Version.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
        } else {
            $internalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
            if ($internalCalledCmdlets -eq '') {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $MyInvocation.MyCommand.Name
            } else {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets += ',' + $MyInvocation.MyCommand.Name
            }
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = 'internal'
        }

        $mapping = @{
            AADAATP = 'Az.SecurityInsights.custom\New-AzSentinelDataConnector';
            ThreatIntelligenceTaxii = 'Az.SecurityInsights.custom\New-AzSentinelDataConnector';
            ThreatIntelligence = 'Az.SecurityInsights.custom\New-AzSentinelDataConnector';
            OfficeIRM = 'Az.SecurityInsights.custom\New-AzSentinelDataConnector';
            OfficeATP = 'Az.SecurityInsights.custom\New-AzSentinelDataConnector';
            Office365 = 'Az.SecurityInsights.custom\New-AzSentinelDataConnector';
            MicrosoftThreatProtection = 'Az.SecurityInsights.custom\New-AzSentinelDataConnector';
            MicrosoftThreatIntelligence = 'Az.SecurityInsights.custom\New-AzSentinelDataConnector';
            MicrosoftDefenderAdvancedThreatProtection = 'Az.SecurityInsights.custom\New-AzSentinelDataConnector';
            MicrosoftCloudAppSecurity = 'Az.SecurityInsights.custom\New-AzSentinelDataConnector';
            Dynamics365 = 'Az.SecurityInsights.custom\New-AzSentinelDataConnector';
            AzureSecurityCenter = 'Az.SecurityInsights.custom\New-AzSentinelDataConnector';
            AmazonWebServicesS3 = 'Az.SecurityInsights.custom\New-AzSentinelDataConnector';
            AmazonWebServicesCloudTrail = 'Az.SecurityInsights.custom\New-AzSentinelDataConnector';
            GenericUI = 'Az.SecurityInsights.custom\New-AzSentinelDataConnector';
        }
        if (('AADAATP', 'ThreatIntelligenceTaxii', 'ThreatIntelligence', 'OfficeIRM', 'OfficeATP', 'Office365', 'MicrosoftThreatProtection', 'MicrosoftThreatIntelligence', 'MicrosoftDefenderAdvancedThreatProtection', 'MicrosoftCloudAppSecurity', 'Dynamics365', 'AzureSecurityCenter', 'AmazonWebServicesS3', 'AmazonWebServicesCloudTrail', 'GenericUI') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        if (('AADAATP', 'ThreatIntelligenceTaxii', 'ThreatIntelligence', 'OfficeIRM', 'OfficeATP', 'Office365', 'MicrosoftThreatProtection', 'MicrosoftThreatIntelligence', 'MicrosoftDefenderAdvancedThreatProtection', 'MicrosoftCloudAppSecurity', 'Dynamics365', 'AzureSecurityCenter', 'AmazonWebServicesS3', 'AmazonWebServicesCloudTrail', 'GenericUI') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Id')) {
            $PSBoundParameters['Id'] = (New-Guid).Guid
        }
        if (('AADAATP', 'ThreatIntelligenceTaxii', 'ThreatIntelligence', 'OfficeIRM', 'OfficeATP', 'Office365', 'MicrosoftThreatProtection', 'MicrosoftThreatIntelligence', 'MicrosoftDefenderAdvancedThreatProtection', 'MicrosoftCloudAppSecurity', 'Dynamics365') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('TenantId')) {
            $PSBoundParameters['TenantId'] = (Get-AzContext).Tenant.Id
        }
        if (('GenericUI') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('AvailabilityStatus')) {
            $PSBoundParameters['AvailabilityStatus'] = 1
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }

    finally {
        $backupTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        $backupInternalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
    }

}
end {
    try {
        $steppablePipeline.End()

        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $backupTelemetryId
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $backupInternalCalledCmdlets
        if ($preTelemetryId -eq '') {
            [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
