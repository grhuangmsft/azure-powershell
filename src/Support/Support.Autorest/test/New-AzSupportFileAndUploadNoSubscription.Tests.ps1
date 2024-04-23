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
    It 'CreateExpanded' {
        $testFilePath = Join-Path $PSScriptRoot files test.txt
        $file = New-AzSupportFileAndUploadNoSubscription -WorkspaceName $env.FileWorkspaceNameNoSubscription -FilePath $testFilePath
        $file.Name | Should -Be "test.txt"
    }

    It 'CreateWithFileTwoChunks' {
        $testFilePath = Join-Path $PSScriptRoot files "3mb-testfile.txt"
        Write-Host "file path: " $testFilePath
        $file = New-AzSupportFileAndUploadNoSubscription -WorkspaceName $env.FileWorkspaceNameNoSubscription -FilePath $testFilePath
        $file.Name | Should -Be "3mb-testfile.txt"
    }

    It 'CreateWithFileOver5Mb' {
        $testFilePath = Join-Path $PSScriptRoot files "over5mb-testfile.txt"
        { New-AzSupportFileAndUpload -WorkspaceName $env.FileWorkspaceNameNoSubscription -FilePath $testFilePath } | Should -Throw -ExpectedMessage "File size is greater than the maximum file size of 5 MB"
    }
}
