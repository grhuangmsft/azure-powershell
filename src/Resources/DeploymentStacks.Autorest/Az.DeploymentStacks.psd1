@{
  GUID = 'e6e33807-43af-4563-bad1-52727f32d650'
  RootModule = './Az.DeploymentStacks.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: DeploymentStacks cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.DeploymentStacks.private.dll'
  FormatsToProcess = './Az.DeploymentStacks.format.ps1xml'
  FunctionsToExport = 'Export-AzResourceDeploymentStackTemplate', 'Get-AzResourceDeploymentStack', 'New-AzResourceDeploymentStack', 'Remove-AzResourceDeploymentStack', 'Set-AzResourceDeploymentStack', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'DeploymentStacks'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
