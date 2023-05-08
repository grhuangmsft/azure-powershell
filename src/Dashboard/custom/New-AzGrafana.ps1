
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
Create or update a workspace for Grafana resource.
This API is idempotent, so user can either create a new grafana or update an existing grafana.
.Description
Create or update a workspace for Grafana resource.
This API is idempotent, so user can either create a new grafana or update an existing grafana.
.Example
New-AzGrafana -Name azpstest-grafana -ResourceGroupName azpstest-gp -ApiKey Enabled -AutoGeneratedDomainNameLabelScope 'TenantReuse' -DeterministicOutboundIP 'Enabled' -IdentityType 'SystemAssigned' -Location eastus -PublicNetworkAccess 'Enabled' -SkuName Standard -ZoneRedundancy 'Enabled' -Tag @{"Environment"="Dev"}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafana
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

GRAFANAINTEGRATIONAZUREMONITORWORKSPACEINTEGRATION <IAzureMonitorWorkspaceIntegration[]>: .
  [AzureMonitorWorkspaceResourceId <String>]: The resource Id of the connected Azure Monitor Workspace.
.Link
https://learn.microsoft.com/powershell/module/az.dashboard/new-azgrafana
#>
function New-AzGrafana {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafana])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('GrafanaName')]
    [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category('Path')]
    [System.String]
    # The workspace name of Azure Managed Grafana.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    
    [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category('Body')]
    [System.String]
    # The api key setting of the Grafana instance.
    ${ApiKey},

    [Parameter(Mandatory)]
    
    [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category('Body')]
    [System.String]
    # Scope for dns deterministic name hash calculation.
    ${AutoGeneratedDomainNameLabelScope},

    [Parameter(Mandatory)]
    
    [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category('Body')]
    [System.String]
    # Whether a Grafana instance uses deterministic outbound IPs.
    ${DeterministicOutboundIP},

    [Parameter(Mandatory)]
    
    [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category('Body')]
    [System.String]
    # Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
    ${IdentityType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUserAssignedIdentities]))]
    [System.Collections.Hashtable]
    # The set of user assigned identities associated with the resource.
    # The userAssignedIdentities dictionary keys will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
    # The dictionary values can be empty objects ({}) in requests.
    ${IdentityUserAssignedIdentity},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category('Body')]
    [System.String]
    # The geo-location where the grafana resource lives
    ${Location},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IAzureMonitorWorkspaceIntegration[]]
    # The MonitorWorkspaceIntegration of Azure Managed Grafana.
    # To construct, see NOTES section for MONITORWORKSPACEINTEGRATION properties and create a hash table.
    ${MonitorWorkspaceIntegration},

    [Parameter(Mandatory)]
    
    [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category('Body')]
    [System.String]
    # Indicate the state for enable or disable traffic over the public interface.
    ${PublicNetworkAccess},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category('Body')]
    [System.String]
    # The Sku of the grafana resource.
    ${SkuName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedGrafanaTags]))]
    [System.Collections.Hashtable]
    # The tags for grafana resource.
    ${Tag},

    [Parameter(Mandatory)]
    
    [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category('Body')]
    [System.String]
    # The zone redundancy setting of the Grafana instance.
    ${ZoneRedundancy},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

    process {
        Az.Dashboard.internal\New-AzGrafana @PSBoundParameters
    }

}
