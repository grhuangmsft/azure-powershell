
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
Creates and uploads a new file under a workspace for the specified subscription.
.Description
Creates and uploads a new file under a workspace for the specified subscription.
.Example
{{ Add code here }}
.Example
{{ Add code here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Support.Models.IFileDetails
.Link
https://learn.microsoft.com/powershell/module/az.support/new-azsupportfile
#>
function New-AzSupportFileAndUpload {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Support.Models.IFileDetails])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('FileWorkspaceName')]
    [Microsoft.Azure.PowerShell.Cmdlets.Support.Category('Path')]
    [System.String]
    # File workspace name.
    ${WorkspaceName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Support.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Support.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Azure subscription Id.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Support.Category('Body')]
    [System.String]
    # Path of the file to be uploaded
    ${FilePath},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Support.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Support.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Support.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Support.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Support.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Support.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Support.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Support.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Support.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

process {
    $FileName = Split-Path $FilePath -Leaf
    $MaxChunkSize = 2.5 * 1024 * 1024 #2.5 MB
    $MaxFileSize = 5 * 1024 * 1024 #5 MB
    $FileContentBytes = Get-Content -Path $FilePath -Raw

    if($FileContentBytes -eq $Null){
        throw "File cannot be empty"
    }

    $FileContentByteArray = [System.Text.Encoding]::UTF8.GetBytes($FileContentBytes)
    $FileSize = $FileContentByteArray.Length

    if($FileSize -gt $MaxFileSize){
        throw "File size is greater than the maximum file size of 5 MB"
    }

    $ChunkSize = If($FileSize -gt $MaxChunkSize) {$MaxChunkSize} Else {$FileSize}
    $NumberOfChunks = [int][Math]::Floor($FileSize / $ChunkSize);

    If($FileSize % $ChunkSize -gt 0) 
    {
        $NumberOfChunks++
    }

    $PSBoundParameters.Remove('FilePath') | Out-Null
    Az.Support.internal\New-AzSupportFile -ErrorAction Stop -Name $FileName -FileSize $FileSize -ChunkSize $ChunkSize -NumberOfChunk $NumberOfChunks @PSBoundParameters

    $chunkIndex = 0
    $startIndex = 0
    $endIndex = $ChunkSize - 1
    
    while($chunkIndex -lt $NumberOfChunks){
        $FileContent = [convert]::ToBase64String($FileContentByteArray[$startIndex..$endIndex])
        Az.Support.internal\Invoke-AzSupportUploadFile -ErrorAction Stop -FileName $FileName -ChunkIndex $chunkIndex -Content $FileContent @PSBoundParameters
        $chunkIndex++
        $startIndex = $endIndex + 1
        $endIndex = $FileSize - 1
    }
}
}
