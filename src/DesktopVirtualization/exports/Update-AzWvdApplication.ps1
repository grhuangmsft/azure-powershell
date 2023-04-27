
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
Update an application.
.Description
Update an application.
.Example
Update-AzWvdApplication -ResourceGroupName ResourceGroupName `
                             -GroupName ApplicationGroupName `
                             -Name ApplicationName `
                             -FilePath 'C:\windows\system32\mspaint.exe' `
                             -FriendlyName 'Friendly name' `
                             -Description 'Description' `
                             -IconIndex 0 `
                             -IconPath 'C:\windows\system32\mspaint.exe' `
                             -CommandLineSetting 'Allow' `
                             -ShowInPortal:$true

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IDesktopVirtualizationIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20210712.IApplication
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IDesktopVirtualizationIdentity>: Identity Parameter
  [ApplicationGroupName <String>]: The name of the application group
  [ApplicationName <String>]: The name of the application within the specified application group
  [DesktopName <String>]: The name of the desktop within the specified desktop group
  [HostPoolName <String>]: The name of the host pool within the specified resource group
  [Id <String>]: Resource identity path
  [MsixPackageFullName <String>]: The version specific package full name of the MSIX package within specified hostpool
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ScalingPlanName <String>]: The name of the scaling plan.
  [SessionHostName <String>]: The name of the session host within the specified host pool
  [SubscriptionId <String>]: The ID of the target subscription.
  [UserSessionId <String>]: The name of the user session within the specified session host
  [WorkspaceName <String>]: The name of the workspace
.Link
https://learn.microsoft.com/powershell/module/az.desktopvirtualization/update-azwvdapplication
#>
function Update-AzWvdApplication {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20210712.IApplication])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Alias('ApplicationGroupName')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Path')]
    [System.String]
    # The name of the application group
    ${GroupName},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Alias('ApplicationName')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Path')]
    [System.String]
    # The name of the application within the specified application group
    ${Name},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IDesktopVirtualizationIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.RemoteApplicationType])]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.RemoteApplicationType]
    # Resource Type of Application.
    ${ApplicationType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # Command Line Arguments for Application.
    ${CommandLineArgument},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CommandLineSetting])]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CommandLineSetting]
    # Specifies whether this published application can be launched with command line arguments provided by the client, command line arguments specified at publish time, or no command line arguments at all.
    ${CommandLineSetting},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # Description of Application.
    ${Description},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # Specifies a path for the executable file for the application.
    ${FilePath},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # Friendly name of Application.
    ${FriendlyName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.Int32]
    # Index of the icon.
    ${IconIndex},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # Path to icon.
    ${IconPath},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # Specifies the package application Id for MSIX applications
    ${MsixPackageApplicationId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # Specifies the package family name for MSIX applications
    ${MsixPackageFamilyName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Specifies whether to show the RemoteApp program in the RD Web Access server.
    ${ShowInPortal},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20210712.IApplicationPatchTags]))]
    [System.Collections.Hashtable]
    # tags to be updated
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Runtime')]
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
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $PSVersionTable.PSVersion.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
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
            UpdateExpanded = 'Az.DesktopVirtualization.private\Update-AzWvdApplication_UpdateExpanded';
            UpdateViaIdentityExpanded = 'Az.DesktopVirtualization.private\Update-AzWvdApplication_UpdateViaIdentityExpanded';
        }
        if (('UpdateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
            [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
