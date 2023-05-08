
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Updates an existing server.
The request body can contain one to many of the properties present in the normal server definition.
Use Update-AzPostSqlFlexibleServerConfiguration instead if you want update server parameters such as wait_timeout or net_retry_count.
.Description
Updates an existing server.
The request body can contain one to many of the properties present in the normal server definition.
Use Update-AzPostSqlFlexibleServerConfiguration instead if you want update server parameters such as wait_timeout or net_retry_count.
#>

function Update-AzPostgreSqlFlexibleServer {
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IServerAutogenerated])]
    [CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Description('Updates an existing server. The request body can contain one to many of the properties present in the normal server definition. Use Update-AzPostgreSqlFlexibleServerConfiguration instead if you want update server parameters such as wait_timeout or net_retry_count.')]
    param(
        [Parameter(ParameterSetName='UpdateExpanded', Mandatory, HelpMessage='The name of the server.')]
        [Alias('ServerName')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Path')]
        [System.String]
        ${Name},

        [Parameter(ParameterSetName='UpdateExpanded', Mandatory, HelpMessage='The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Path')]
        [System.String]
        ${ResourceGroupName},

        [Parameter(ParameterSetName='UpdateExpanded', HelpMessage='The subscription ID that identifies an Azure subscription.')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
        [System.String]
        ${SubscriptionId},

        [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline, HelpMessage='Identity Parameter. To construct, see NOTES section for INPUTOBJECT properties and create a hash table.')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentity]
        ${InputObject},

        [Parameter(HelpMessage='The password of the administrator login.')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Body')]
        [System.Security.SecureString]
        ${AdministratorLoginPassword},

        [Parameter(HelpMessage='The name of the sku, e.g. Burstable_B1ms, Standard_D2ds_v4')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Body')]
        [System.String]
        ${Sku},

        [Parameter(HelpMessage='The tier of the particular SKU. Accepted values: Burstable, GeneralPurpose, Memory Optimized. Default: Burstable.')]
        
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Body')]
        [System.String]
        ${SkuTier},

        [Parameter(HelpMessage='Enable or disable high availability feature. Allowed values: Enabled, Disabled')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Body')]
        [Validateset('Enabled', 'Disabled')]
        ${HaEnabled},

        [Parameter(HelpMessage='Backup retention days for the server. Day count is between 7 and 35.')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Body')]
        [System.Int32]
        ${BackupRetentionDay},

        [Parameter(HelpMessage='Period of time (UTC) designated for maintenance. Examples: "Sun:23:30" to schedule on Sunday, 11:30pm UTC. To set back to default pass in "Disabled"')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Body')]
        [System.String]
        ${MaintenanceWindow},

        [Parameter(HelpMessage='Max storage allowed for a server.')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Body')]
        [System.Int32]
        ${StorageInMb},

        [Parameter(HelpMessage='Application-specific metadata in the form of key-value pairs.')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IServerUpdateParametersTags]))]
        [System.Collections.Hashtable]
        ${Tag},

        [Parameter(HelpMessage = 'The credentials, account, tenant, and subscription used for communication with Azure.')]
        [Alias('AzureRMContext', 'AzureCredential')]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Azure')]
        [System.Management.Automation.PSObject]
        ${DefaultProfile},

        [Parameter(HelpMessage = 'Run the command as a job.')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        ${AsJob},

        [Parameter(DontShow, HelpMessage = 'Wait for .NET debugger to attach.')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        ${Break},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be appended to the front of the pipeline.
        ${HttpPipelineAppend},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be prepended to the front of the pipeline.
        ${HttpPipelinePrepend},

        [Parameter(HelpMessage = 'Run the command asynchronously.')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        ${NoWait},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Runtime')]
        [System.Uri]
        # The URI for the proxy server to use.
        ${Proxy},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Runtime')]
        [System.Management.Automation.PSCredential]
        # Credentials for a proxy server to use for the remote call.
        ${ProxyCredential},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Use the default credentials for the proxy.
        ${ProxyUseDefaultCredentials}
    )

    process {
        try {
            if ($PSBoundParameters.ContainsKey('StorageInMb')) {
                $PSBoundParameters.StorageSizeGb = [Math]::floor($PSBoundParameters['StorageInMb'] / 1024)
                $null = $PSBoundParameters.Remove('StorageInMb')
            }

            if ($PSBoundParameters.ContainsKey('Sku')) {
                $PSBoundParameters.SkuName = $PSBoundParameters['Sku']
                $null = $PSBoundParameters.Remove('Sku')
            }

            if ($PSBoundParameters.ContainsKey('HaEnabled')) {
                if ($PSBoundParameters['HaEnabled'] -eq 'Enabled'){
                    $PSBoundParameters.HighAvailabilityMode = 'ZoneRedundant'
                }
                else {
                    $PSBoundParameters.HighAvailabilityMode = $PSBoundParameters['HaEnabled']
                }
                $null = $PSBoundParameters.Remove('HaEnabled')
            }

            if ($PSBoundParameters.ContainsKey('MaintenanceWindow')) {

                $PSBoundParameters.MaintenanceWindowDayOfWeek = $null
                $PSBoundParameters.MaintenanceWindowStartHour = $null
                $PSBoundParameters.MaintenanceWindowStartMinute = $null

                if ($PSBoundParameters.MaintenanceWindow.ToLower() -eq "disabled"){
                    $PSBoundParameters.MaintenanceWindowDayOfWeek = 0
                    $PSBoundParameters.MaintenanceWindowStartHour = 0
                    $PSBoundParameters.MaintenanceWindowStartMinute = 0
                    $PSBoundParameters.MaintenanceWindowCustomWindow = "Disabled"
                }
                else {
                    $ParsedWindow = $PSBoundParameters.MaintenanceWindow -split ":"
                    $DaytoNumber = @{Mon = 1; Tue = 2; Wed = 3; Thur = 4; Fri = 5; Sat = 6; Sun = 0}

                    if ($ParsedWindow.Length -ge 1){
                        $PSBoundParameters.MaintenanceWindowDayOfWeek =  $DaytoNumber[$ParsedWindow[0]]
                    }

                    if ($ParsedWindow.Length -ge 2){
                        $PSBoundParameters.MaintenanceWindowStartHour = $ParsedWindow[1]
                    }

                    if ($ParsedWindow.Length -ge 3){
                        $PSBoundParameters.MaintenanceWindowStartMinute = $ParsedWindow[2]
                    }

                    $PSBoundParameters.MaintenanceWindowCustomWindow = "Enabled"
                }

                $null = $PSBoundParameters.Remove('MaintenanceWindow')
            }

            Az.PostgreSql.internal\Update-AzPostgreSqlFlexibleServer @PSBoundParameters
        } catch {
            throw
        }
    }
}
