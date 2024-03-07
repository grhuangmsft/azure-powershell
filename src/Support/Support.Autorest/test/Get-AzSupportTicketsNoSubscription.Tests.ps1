if(($null -eq $TestName) -or ($TestName -contains 'Get-AzSupportTicketsNoSubscription'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzSupportTicketsNoSubscription.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Get-AzSupportTicketsNoSubscription' {
    It 'List'  -Skip:$env.HasSubscription{
        # if($env.SupportPlanTenant -eq "Basic support" || $env.SupportPlanTenant -eq "Free"){
        #     write-host "cannot get support tickets with free support plan"
            
        #     Mock Get-AzSupportTicketsNoSubscription{ New-MockObject -Type "Microsoft.Azure.PowerShell.Cmdlets.Support.Models.SupportTicketDetails"}
            
        #     Get-AzSupportTicketsNoSubscription
            
        #     Assert-MockCalled Get-AzSupportTicketsNoSubscription -Exactly 1
        # }
        # else{
            $supportTickets = Get-AzSupportTicketsNoSubscription -Top 5
            $supportTickets.Count | Should -BeGreaterThan 1
        # }
    }

    It 'Get'  -Skip:$env.HasSubscription{
    #     if($env.SupportPlanTenant -eq "Basic support" || $env.SupportPlanTenant -eq "Free"){
    #         write-host "cannot get support tickets with free support plan"
            
    #         Mock Get-AzSupportTicketsNoSubscription{ New-MockObject -Type "Microsoft.Azure.PowerShell.Cmdlets.Support.Models.SupportTicketDetails"}
            
    #         Get-AzSupportTicketsNoSubscription -SupportTicketName $env.Name

    #         Assert-MockCalled Get-AzSupportTicketsNoSubscription -Exactly 2
    #     }
        # else{
            $supportTicket = Get-AzSupportTicketsNoSubscription -SupportTicketName $env.Name
            $supportTicket.Description | Should -Be "test ticket - please ignore and close"
        # }
    }

    It 'GetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
