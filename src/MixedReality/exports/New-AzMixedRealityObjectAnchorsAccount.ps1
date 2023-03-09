
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
Creating or Updating an object anchors Account.
.Description
Creating or Updating an object anchors Account.
.Example
New-AzMixedRealityObjectAnchorsAccount -Name azpstestanchorsaccount-object -ResourceGroupName azps_test_group -Location eastus2

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Models.Api20210301Preview.IObjectAnchorsAccount
.Link
https://learn.microsoft.com/powershell/module/az.mixedreality/new-azmixedrealityobjectanchorsaccount
#>
function New-AzMixedRealityObjectAnchorsAccount {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Models.Api20210301Preview.IObjectAnchorsAccount])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Category('Path')]
    [System.String]
    # Name of an Mixed Reality Account.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Category('Path')]
    [System.String]
    # Name of an Azure resource group.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The Azure subscription ID.
    # This is a GUID-formatted string (e.g.
    # 00000000-0000-0000-0000-000000000000)
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Category('Body')]
    [System.String]
    # The geo-location where the resource lives
    ${Location},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Support.ResourceIdentityType])]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Support.ResourceIdentityType]
    # The identity type.
    ${IdentityType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Category('Body')]
    [System.Int32]
    # If the SKU supports scale out/in then the capacity integer should be included.
    # If scale out/in is not possible for the resource this may be omitted.
    ${KindCapacity},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Category('Body')]
    [System.String]
    # If the service has different generations of hardware, for the same SKU, then that can be captured here.
    ${KindFamily},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Category('Body')]
    [System.String]
    # The name of the SKU.
    # Ex - P3.
    # It is typically a letter+number code
    ${KindName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Category('Body')]
    [System.String]
    # The SKU size.
    # When the name field is the combination of tier and some other value, this would be the standalone code.
    ${KindSize},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Support.SkuTier])]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Support.SkuTier]
    # This field is required to be implemented by the Resource Provider if the service has more than one tier, but is not required on a PUT.
    ${KindTier},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Support.ResourceIdentityType])]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Support.ResourceIdentityType]
    # The identity type.
    ${PlanType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Category('Body')]
    [System.Int32]
    # If the SKU supports scale out/in then the capacity integer should be included.
    # If scale out/in is not possible for the resource this may be omitted.
    ${SkuCapacity},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Category('Body')]
    [System.String]
    # If the service has different generations of hardware, for the same SKU, then that can be captured here.
    ${SkuFamily},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Category('Body')]
    [System.String]
    # The name of the SKU.
    # Ex - P3.
    # It is typically a letter+number code
    ${SkuName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Category('Body')]
    [System.String]
    # The SKU size.
    # When the name field is the combination of tier and some other value, this would be the standalone code.
    ${SkuSize},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Support.SkuTier])]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Support.SkuTier]
    # This field is required to be implemented by the Resource Provider if the service has more than one tier, but is not required on a PUT.
    ${SkuTier},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Category('Body')]
    [System.String]
    # The name of the storage account associated with this accountId
    ${StorageAccountName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Models.Api10.ITrackedResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Category('Runtime')]
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
            [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
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
            CreateExpanded = 'Az.MixedReality.private\New-AzMixedRealityObjectAnchorsAccount_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
            [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
