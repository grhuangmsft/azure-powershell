
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
Operation to create a lab resource.
.Description
Operation to create a lab resource.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILab
.Link
https://learn.microsoft.com/powershell/module/az.labservices/new-azlabserviceslab
#>
function New-AzLabServicesLab {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILab])]
[CmdletBinding(PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('LabName')]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Path')]
    [System.String]
    # The name of the lab that uniquely identifies it within containing lab account.
    # Used in resource URIs.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # The geo-location where the resource lives
    ${Location},

    [Parameter()]
    
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # Flag to pre-install dedicated GPU drivers.
    ${AdditionalCapabilityInstallGpuDriver},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [SecureString]
    # The password for the user.
    # This is required for the TemplateVM createOption.
    ${AdminUserPassword},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # The username to use when signing in to lab VMs.
    ${AdminUserUsername},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.TimeSpan]
    # The amount of time a VM will stay running after a user disconnects if this behavior is enabled.
    ${AutoShutdownProfileDisconnectDelay},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.TimeSpan]
    # The amount of time a VM will idle before it is shutdown if this behavior is enabled.
    ${AutoShutdownProfileIdleDelay},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.TimeSpan]
    # The amount of time a VM will stay running before it is shutdown if no connection is made and this behavior is enabled.
    ${AutoShutdownProfileNoConnectDelay},

    [Parameter()]
    
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # Whether shutdown on disconnect is enabled
    ${AutoShutdownProfileShutdownOnDisconnect},

    [Parameter()]
    
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # Whether a VM will get shutdown when it has idled for a period of time.
    ${AutoShutdownProfileShutdownOnIdle},

    [Parameter()]
    
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # Whether a VM will get shutdown when it hasn't been connected to after a period of time.
    ${AutoShutdownProfileShutdownWhenNotConnected},

    [Parameter()]
    
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # The enabled access level for Client Access over RDP.
    ${ConnectionProfileClientRdpAccess},

    [Parameter()]
    
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # The enabled access level for Client Access over SSH.
    ${ConnectionProfileClientSshAccess},

    [Parameter()]
    
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # The enabled access level for Web Access over RDP.
    ${ConnectionProfileWebRdpAccess},

    [Parameter()]
    
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # The enabled access level for Web Access over SSH.
    ${ConnectionProfileWebSshAccess},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # The description of the lab.
    ${Description},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # Image resource ID
    ${ImageReferenceId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # The image offer if applicable.
    ${ImageReferenceOffer},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # The image publisher
    ${ImageReferencePublisher},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # The image SKU
    ${ImageReferenceSku},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # The image version specified on creation.
    ${ImageReferenceVersion},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # The ID of the lab plan.
    # Used during resource creation to provide defaults and acts as a permission container when creating a lab via labs.azure.com.
    # Setting a labPlanId on an existing lab provides organization..
    ${LabPlanId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # The external load balancer resource id
    ${NetworkProfileLoadBalancerId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # The external public IP resource id
    ${NetworkProfilePublicIPId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # The external subnet resource id
    ${NetworkProfileSubnetId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [SecureString]
    # The password for the user.
    # This is required for the TemplateVM createOption.
    ${NonAdminUserPassword},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # The username to use when signing in to lab VMs.
    ${NonAdminUserUsername},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # The AAD group ID which this lab roster is populated from.
    # Having this set enables AAD sync mode.
    ${RosterProfileActiveDirectoryGroupId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # The base URI identifying the lms instance.
    ${RosterProfileLmsInstance},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # The unique id of the azure lab services tool in the lms.
    ${RosterProfileLtiClientId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # The unique context identifier for the lab in the lms.
    ${RosterProfileLtiContextId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # The uri of the names and roles service endpoint on the lms for the class attached to this lab.
    ${RosterProfileLtiRosterEndpoint},

    [Parameter()]
    
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # Whether any user or only specified users can register to a lab.
    ${SecurityProfileOpenAccess},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.Int32]
    # If the SKU supports scale out/in then the capacity integer should be included.
    # If scale out/in is not possible for the resource this may be omitted.
    ${SkuCapacity},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # If the service has different generations of hardware, for the same SKU, then that can be captured here.
    ${SkuFamily},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # The name of the SKU.
    # Ex - P3.
    # It is typically a letter+number code
    ${SkuName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # The SKU size.
    # When the name field is the combination of tier and some other value, this would be the standalone code.
    ${SkuSize},

    [Parameter()]
    
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # This field is required to be implemented by the Resource Provider if the service has more than one tier, but is not required on a PUT.
    ${SkuTier},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ITrackedResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # The title of the lab.
    ${Title},

    [Parameter()]
    
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # Indicates what lab virtual machines are created from.
    ${VirtualMachineProfileCreateOption},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.TimeSpan]
    # The initial quota alloted to each lab user.
    # Must be a time span between 0 and 9999 hours.
    ${VirtualMachineProfileUsageQuota},

    [Parameter()]
    
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    # Enabling this option will use the same password for all user VMs.
    ${VirtualMachineProfileUseSharedPassword},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

process {       
    if ($PSBoundParameters.ContainsKey('AdminUserPassword')) {
        $psAdminTxt = . "$PSScriptRoot/../utils/Unprotect-SecureString.ps1" $PSBoundParameters['AdminUserPassword']
        $PSBoundParameters.Remove("AdminUserPassword") > $null
        $PSBoundParameters.Add("AdminUserPassword",$psAdminTxt)
    }

    if ($PSBoundParameters.ContainsKey('NonAdminUserPassword')) {
        $psTxt = . "$PSScriptRoot/../utils/Unprotect-SecureString.ps1" $PSBoundParameters['NonAdminUserPassword']
        $PSBoundParameters.Remove("NonAdminUserPassword") > $null
        $PSBoundParameters.Add("NonAdminUserPassword",$psTxt)
    }

    return Az.LabServices.internal\New-AzLabServicesLab @PSBoundParameters

    }
}
