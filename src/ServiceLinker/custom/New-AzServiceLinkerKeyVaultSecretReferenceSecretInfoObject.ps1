
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
Create an in-memory object for KeyVaultSecretReferenceSecretInfo.
.Description
Create an in-memory object for KeyVaultSecretReferenceSecretInfo.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.KeyVaultSecretReferenceSecretInfo
.Link
https://learn.microsoft.com/powershell/module/az.ServiceLinker/new-azservicelinkerkeyvaultsecretreferencesecretinfoobject
#>
function New-AzServiceLinkerKeyVaultSecretReferenceSecretInfoObject {
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.DoNotExportAttribute()]
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.KeyVaultSecretReferenceSecretInfo')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="Name of the Key Vault secret.")]
        [string]
        $Name,
        [Parameter(HelpMessage="Version of the Key Vault secret.")]
        [string]
        $Version,
        [Parameter(Mandatory, HelpMessage="The secret type.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.SecretType])]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.SecretType]
        $SecretType
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.KeyVaultSecretReferenceSecretInfo]::New()

        if ($PSBoundParameters.ContainsKey('Name')) {
            $Object.Name = $Name
        }
        if ($PSBoundParameters.ContainsKey('Version')) {
            $Object.Version = $Version
        }
        if ($PSBoundParameters.ContainsKey('SecretType')) {
            $Object.SecretType = $SecretType
        }
        return $Object
    }
}

