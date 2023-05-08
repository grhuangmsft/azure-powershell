
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
Create or update DigitalTwinsInstance endpoint.
.Description
Create or update DigitalTwinsInstance endpoint.
.Example
{{ Add code here }}
.Example
{{ Add code here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResource
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IDigitalTwinsIdentity>: Identity Parameter
  [EndpointName <String>]: Name of Endpoint Resource.
  [Id <String>]: Resource identity path
  [Location <String>]: Location of DigitalTwinsInstance.
  [PrivateEndpointConnectionName <String>]: The name of the private endpoint connection.
  [ResourceGroupName <String>]: The name of the resource group that contains the DigitalTwinsInstance.
  [ResourceId <String>]: The name of the private link resource.
  [ResourceName <String>]: The name of the DigitalTwinsInstance.
  [SubscriptionId <String>]: The subscription identifier.
  [TimeSeriesDatabaseConnectionName <String>]: Name of time series database connection.
.Link
https://learn.microsoft.com/powershell/module/az.digitaltwins/new-azdigitaltwinsendpoint
#>
function New-AzDigitalTwinsEndpoint {
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResource])]
    [CmdletBinding(DefaultParameterSetName='EventHub', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    param(
        [Parameter(ParameterSetName='EventHub', Mandatory)]
        [Parameter(ParameterSetName='EventGrid', Mandatory)]
        [Parameter(ParameterSetName='ServiceBus', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Path')]
        [System.String]
        # Name of Endpoint Resource.
        ${EndpointName},

        [Parameter(ParameterSetName='EventHub', Mandatory)]
        [Parameter(ParameterSetName='EventGrid', Mandatory)]
        [Parameter(ParameterSetName='ServiceBus', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Path')]
        [System.String]
        # The name of the resource group that contains the DigitalTwinsInstance.
        ${ResourceGroupName},

        [Parameter(ParameterSetName='EventHub', Mandatory)]
        [Parameter(ParameterSetName='EventGrid', Mandatory)]
        [Parameter(ParameterSetName='ServiceBus', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Path')]
        [System.String]
        # The name of the DigitalTwinsInstance.
        ${ResourceName},

        [Parameter(ParameterSetName='EventHub')]
        [Parameter(ParameterSetName='EventGrid')]
        [Parameter(ParameterSetName='ServiceBus')]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
        [System.String]
        # The subscription identifier.
        ${SubscriptionId},

        [Parameter(ParameterSetName='EventHub', ValueFromPipeline)]
        [Parameter(ParameterSetName='EventGrid', ValueFromPipeline)]
        [Parameter(ParameterSetName='ServiceBus', ValueFromPipeline)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResource]
        # DigitalTwinsInstance endpoint resource.
        # To construct, see NOTES section for ENDPOINTDESCRIPTION properties and create a hash table.
        ${EndpointDescription},

        [Parameter(ParameterSetName='EventHub', Mandatory)]
        [Parameter(ParameterSetName='EventGrid', Mandatory)]
        [Parameter(ParameterSetName='ServiceBus', Mandatory)]
        
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Body')]
        [System.String]
        # The type of Digital Twins endpoint
        ${EndpointType},

        [Parameter()]
        
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Body')]
        [System.String]
        # Specifies the authentication type being used for connecting to the endpoint.
        # Defaults to 'KeyBased'.
        # If 'KeyBased' is selected, a connection string must be specified (at least the primary connection string).
        # If 'IdentityBased' is select, the endpointUri and entityPath properties must be specified.
        ${AuthenticationType},

        [Parameter(ParameterSetName='EventHub',Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Body')]
        [System.String]
        # The subscription identifier.
        ${ConnectionStringPrimaryKey},

        [Parameter(ParameterSetName='EventHub')]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Body')]
        [System.String]
        # The subscription identifier.
        ${ConnectionStringSecondaryKey},

        [Parameter(ParameterSetName='EventGrid',Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Body')]
        [System.String]
        # The subscription identifier.
        ${TopicEndpoint},

        [Parameter(ParameterSetName='EventGrid',Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Body')]
        [System.String]
        # The subscription identifier.
        ${AccessKey1},

        [Parameter(ParameterSetName='ServiceBus',Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Body')]
        [System.String]
        # The subscription identifier.
        ${PrimaryConnectionString},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Body')]
        [System.String]
        # Dead letter storage secret for key-based authentication.
        # Will be obfuscated during read.
        ${DeadLetterSecret},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Body')]
        [System.String]
        # Dead letter storage URL for identity-based authentication.
        ${DeadLetterUri},

        [Parameter()]
        [Alias('AzureRMContext', 'AzureCredential')]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Azure')]
        [System.Management.Automation.PSObject]
        # The credentials, account, tenant, and subscription used for communication with Azure.
        ${DefaultProfile},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Run the command as a job
        ${AsJob},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Wait for .NET debugger to attach
        ${Break},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be appended to the front of the pipeline
        ${HttpPipelineAppend},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be prepended to the front of the pipeline
        ${HttpPipelinePrepend},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Run the command asynchronously
        ${NoWait},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Runtime')]
        [System.Uri]
        # The URI for the proxy server to use
        ${Proxy},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Runtime')]
        [System.Management.Automation.PSCredential]
        # Credentials for a proxy server to use for the remote call
        ${ProxyCredential},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Use the default credentials for the proxy
        ${ProxyUseDefaultCredentials}
    )
    process {
        try {
            if($PSBoundParameters['EndpointType'] -eq 'EventHub')
            {
                $Parameter = [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.DigitalTwinsEndpointResource]::new()
                $Parameter.Property = [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.EventHub]::new()
                $Parameter.Property.connectionStringPrimaryKey = $PSBoundParameters['connectionStringPrimaryKey']
                $Parameter.Property.connectionStringSecondaryKey = $PSBoundParameters['connectionStringSecondaryKey']
                $null = $PSBoundParameters.Remove('connectionStringPrimaryKey')
                $null = $PSBoundParameters.Remove('connectionStringSecondaryKey')
            }
            if($PSBoundParameters['EndpointType'] -eq 'EventGrid')
            {
                $Parameter = [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.DigitalTwinsEndpointResource]::new()
                $Parameter.Property = [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.EventGrid]::new()
                $Parameter.Property.TopicEndpoint = $PSBoundParameters['TopicEndpoint']
                $Parameter.Property.accessKey1 = $PSBoundParameters['accessKey1']
                $null = $PSBoundParameters.Remove('TopicEndpoint')
                $null = $PSBoundParameters.Remove('accessKey1')
            }
            if($PSBoundParameters['EndpointType'] -eq 'ServiceBus')
            {
                $Parameter = [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.DigitalTwinsEndpointResource]::new()
                $Parameter.Property = [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.ServiceBus]::new()
                $Parameter.Property.primaryConnectionString = $PSBoundParameters['primaryConnectionString']
                $null = $PSBoundParameters.Remove('primaryConnectionString')
            }
            $Parameter.EndpointType = $PSBoundParameters['EndpointType']
            $Parameter.AuthenticationType = $PSBoundParameters['AuthenticationType']
            $null = $PSBoundParameters.Remove('EndpointType')
            $null = $PSBoundParameters.Remove('AuthenticationType')
            $null = $PSBoundParameters.Add("EndpointDescription",$Parameter)

            Az.DigitalTwins.internal\New-AzDigitalTwinsEndpoint @PSBoundParameters
        } catch {
            throw
        }
    }
}
