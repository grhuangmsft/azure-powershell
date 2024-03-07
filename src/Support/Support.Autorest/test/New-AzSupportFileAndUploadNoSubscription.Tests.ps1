if(($null -eq $TestName) -or ($TestName -contains 'New-AzSupportFileAndUploadNoSubscription'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'New-AzSupportFileAndUploadNoSubscription.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'New-AzSupportFileAndUploadNoSubscription' {
    It 'CreateExpanded' -skip:($env.HasSubscription -eq $true){
        $testFilePath = Join-Path $PSScriptRoot files test.txt
        $file = New-AzSupportFileAndUploadNoSubscription -WorkspaceName $env.FileWorkspaceNameNoSubscription -FilePath $testFilePath
        $file.Name | Should -Be "test.txt"
    }
}
