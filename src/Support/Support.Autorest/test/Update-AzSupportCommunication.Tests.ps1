if(($null -eq $TestName) -or ($TestName -contains 'Update-AzSupportCommunication'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Update-AzSupportCommunication.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Update-AzSupportCommunication' {   
    
    It 'UpdateExpanded' {
        Mock Update-AzSupportCommunication{ New-MockObject -Type "Microsoft.Azure.PowerShell.Cmdlets.Support.Models.CommunicationDetails"}
            
        Update-AzSupportCommunication -Name $env.CommunicationName -SupportTicketName $env.Name -Body "Body changed" 

        Assert-MockCalled Update-AzSupportCommunication -Exactly 1
    }

    It 'UpdateViaIdentitySupportTicketExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
