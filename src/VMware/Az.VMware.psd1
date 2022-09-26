@{
  GUID = '6ced3ed2-fb86-4a72-aca7-369161b12fea'
  RootModule = './Az.VMware.psm1'
  ModuleVersion = '0.4.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: VMware cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.VMware.private.dll'
  FormatsToProcess = './Az.VMware.format.ps1xml'
  FunctionsToExport = 'Get-AzVMwareAddon', 'Get-AzVMwareAuthorization', 'Get-AzVMwareCloudLink', 'Get-AzVMwareCluster', 'Get-AzVMwareDatastore', 'Get-AzVMwareGlobalReachConnection', 'Get-AzVMwarePlacementPolicy', 'Get-AzVMwarePrivateCloud', 'Get-AzVMwarePrivateCloudAdminCredential', 'Get-AzVMwareVirtualMachine', 'New-AzVMwareAddon', 'New-AzVMwareAddonSrmPropertiesObject', 'New-AzVMwareAddonVrPropertiesObject', 'New-AzVMwareAuthorization', 'New-AzVMwareCloudLink', 'New-AzVMwareCluster', 'New-AzVMwareDatastore', 'New-AzVMwareGlobalReachConnection', 'New-AzVMwarePlacementPolicy', 'New-AzVMwarePrivateCloud', 'New-AzVMwarePrivateCloudNsxtPassword', 'New-AzVMwarePrivateCloudVcenterPassword', 'New-AzVMwarePSCredentialExecutionParameterObject', 'New-AzVMwareScriptSecureStringExecutionParameterObject', 'New-AzVMwareScriptStringExecutionParameterObject', 'New-AzVMwareVmHostPlacementPolicyPropertiesObject', 'New-AzVMwareVMPlacementPolicyPropertiesObject', 'Remove-AzVMwareAddon', 'Remove-AzVMwareAuthorization', 'Remove-AzVMwareCloudLink', 'Remove-AzVMwareCluster', 'Remove-AzVMwareDatastore', 'Remove-AzVMwareGlobalReachConnection', 'Remove-AzVMwarePlacementPolicy', 'Remove-AzVMwarePrivateCloud', 'Test-AzVMwareLocationQuotaAvailability', 'Test-AzVMwareLocationTrialAvailability', 'Update-AzVMwareCluster', 'Update-AzVMwarePlacementPolicy', 'Update-AzVMwarePrivateCloud', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'VMware'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
