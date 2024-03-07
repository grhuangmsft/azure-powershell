if (($null -eq $TestName) -or ($TestName -contains 'New-AzSupportTicket')) {
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $TestRecordingFile = Join-Path $PSScriptRoot 'New-AzSupportTicket.Recording.json'
    $currentPath = $PSScriptRoot
    while (-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'New-AzSupportTicket' {
    It 'CreateExpanded' -Skip:!$env.HasSubscription{
        $supportTicket = New-AzSupportTicket -Name $env.NameForCreate -AdvancedDiagnosticConsent $env.AdvancedDiagnosticConsent -ContactDetailCountry $env.ContactDetailCountry -ContactDetailFirstName $env.ContactDetailFirstName -ContactDetailLastName $env.ContactDetailLastName -ContactDetailPreferredContactMethod $env.ContactDetailPreferredContactMethod -ContactDetailPreferredSupportLanguage $env.ContactDetailPreferredSupportLanguage -ContactDetailPreferredTimeZone $env.ContactDetailPreferredTimeZone -ContactDetailPrimaryEmailAddress $env.ContactDetailPrimaryEmailAddress -Description $env.Description -ProblemClassificationId $env.ProblemClassificationId -ServiceId $env.ServiceId -Severity $env.Severity -Title $env.Title
        
        $supportTicket.Description | Should -Be "test ticket - please ignore and close"
    }
}
