if(($null -eq $TestName) -or ($TestName -contains 'New-AzSupportFileWorkspacesNoSubscription'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'New-AzSupportFileWorkspacesNoSubscription.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'New-AzSupportFileWorkspacesNoSubscription' {
    It 'Create' -Skip:$env.HasSubscription{
        $fileWorkspaceName = $env.fileWorkspaceNameNoSubscriptionForCreate
        $fileWorkspace = New-AzSupportFileWorkspacesNoSubscription -Name $fileWorkspaceName
        $fileWorkspace.Name | Should -Be $fileWorkspaceName
    }
}
