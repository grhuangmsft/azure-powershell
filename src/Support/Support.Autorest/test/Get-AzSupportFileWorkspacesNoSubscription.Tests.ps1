if(($null -eq $TestName) -or ($TestName -contains 'Get-AzSupportFileWorkspacesNoSubscription'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzSupportFileWorkspacesNoSubscription.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Get-AzSupportFileWorkspacesNoSubscription' {
    It 'Get' -skip:($env.HasSubscription -eq $true){
        $fileWorkspace = Get-AzSupportFileWorkspacesNoSubscription -Name $env.FileWorkspaceNameNoSubscription
        $fileWorkspace.Name | Should -Be $env.FileWorkspaceNameNoSubscription
    }

    It 'GetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
