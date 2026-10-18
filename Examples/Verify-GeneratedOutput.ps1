[CmdletBinding()]
param(
    [ValidateSet('Debug', 'Release')]
    [string] $Configuration = 'Release',
    [switch] $NoBuild
)

$ErrorActionPreference = 'Stop'

foreach ($sample in @('AppleStore', 'FruitVendor')) {
    $projectDirectory = Join-Path $PSScriptRoot "$sample.AWS.NimbusFactory"
    $project = Join-Path $projectDirectory "$sample.AWS.NimbusFactory.CLI/$sample.AWS.NimbusFactory.CLI.csproj"
    if (-not $NoBuild) {
        Push-Location $PSScriptRoot
        try { dotnet build $project -c $Configuration -m:1 -p:GeneratePackageOnBuild=false }
        finally { Pop-Location }
        if ($LASTEXITCODE -ne 0) { throw "$sample build failed." }
    }

    $binaryDirectory = Join-Path $projectDirectory "$sample.AWS.NimbusFactory.CLI/bin/$Configuration/net11.0"
    dotnet (Join-Path $binaryDirectory "$sample.AWS.NimbusFactory.CLI.dll")
    if ($LASTEXITCODE -ne 0) { throw "$sample generation failed." }

    $outputDirectory = Join-Path $binaryDirectory 'generated'
    $expected = Get-Content (Join-Path $PSScriptRoot "VerificationResults/$sample.generated.json") -Raw | ConvertFrom-Json
    $actual = @(Get-ChildItem -LiteralPath $outputDirectory -Recurse -File | ForEach-Object {
        $relativePath = [IO.Path]::GetRelativePath($outputDirectory, $_.FullName).Replace('\', '/')
        # Batch deployment scripts embed the absolute generation directory.
        if ($_.Extension -eq '.bat') {
            $content = [IO.File]::ReadAllText($_.FullName).Replace($outputDirectory, '<GENERATED_DIRECTORY>')
            $bytes = [Text.Encoding]::UTF8.GetBytes($content)
        }
        else {
            $bytes = [IO.File]::ReadAllBytes($_.FullName)
        }
        $hash = [Convert]::ToHexString([Security.Cryptography.SHA256]::HashData($bytes))
        [pscustomobject]@{ Path = $relativePath; Hash = $hash }
    })

    $differences = @(Compare-Object $expected $actual -Property Path, Hash)
    if ($differences.Count -gt 0) {
        $paths = $differences.Path | Sort-Object -Unique
        throw "$sample output changed: $($paths -join ', ')"
    }
    Write-Host "$sample`: all $($actual.Count) generated files match the original dynamic-model output."
}
