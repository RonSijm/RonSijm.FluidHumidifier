# NimbusFactory examples

Two fictional infrastructure applications demonstrate composing CloudFormation stacks with FluidHumidifier:

- [AppleStore](AppleStore.AWS.NimbusFactory): multiple environments and accounts, ECS services, a container registry, PostgreSQL, Redis, and cross-region backups.
- [FruitVendor](FruitVendor.AWS.NimbusFactory): a smaller application with Elastic Beanstalk, a database, S3, and CloudFront.

Project names, namespaces, resource names, DNS names, account IDs, certificate and KMS identifiers, CI identifiers, and test fixtures use sample values. Domains use the reserved `.example` suffix. The account numbers and resource identifiers are placeholders.

## Build and test

Use the .NET 11 preview SDK pinned in `global.json`. The examples reference this repository's projects under `src-dotnet11` and the Humidifier projects in a sibling checkout:

```text
workspace/
  RonSijm.FluidHumidifier/
    Examples/
    src-dotnet11/
  RonSijm.Humidifier/
    src-dotnet11/
```

Run these commands from the FluidHumidifier repository root. Changing to the examples directory selects the preview SDK configured by its `global.json`:

```powershell
cd Examples
dotnet build AppleStore.AWS.NimbusFactory/AppleStore.AWS.NimbusFactory.Nugets.sln -c Release
dotnet build FruitVendor.AWS.NimbusFactory/FruitVendor.AWS.NimbusFactory.Nugets.sln -c Release
dotnet test AppleStore.AWS.NimbusFactory/AppleStore.AWS.NimbusFactory.Nugets.sln -c Release --filter "FullyQualifiedName!~IntegrationTest"
dotnet test FruitVendor.AWS.NimbusFactory/FruitVendor.AWS.NimbusFactory.Nugets.sln -c Release --filter "FullyQualifiedName!~IntegrationTest"
```

The `LocalDev.sln` variants additionally show the library and code-generation projects. The focused `Nugets.sln` variants contain the application and its tests; the applications still use source references for the FluidHumidifier projects.

The template-validation integration tests also require `cfn-lint` on PATH.

To check the full CLI output against the output captured before the union migration, run `./Examples/Verify-GeneratedOutput.ps1` from the repository root using PowerShell 7 on Windows. Use `-NoBuild` to check an existing Release build. This checks all 58 generated files, including CloudFormation templates, deployment scripts, and GitHub workflows. Only the absolute generation directory embedded in batch scripts is normalized.

## Generate templates

```powershell
dotnet run --project AppleStore.AWS.NimbusFactory/AppleStore.AWS.NimbusFactory.CLI
dotnet run --project FruitVendor.AWS.NimbusFactory/FruitVendor.AWS.NimbusFactory.CLI
```

Each CLI loads its own `appsettings.json`. Its default `BaseDir` is `./generated/`, resolved relative to the application's output directory. Generation writes CloudFormation templates, batch deployment scripts, and GitHub workflows. Running the CLI does not deploy resources.

Before deploying generated output, supply your own account IDs, domains, certificate ARNs, KMS key ARNs, GitHub repository owners, and CircleCI identifiers. The sample database passwords use Secrets Manager dynamic references such as `example/applestore/dev/database` and `example/fruitvendor/fruitvendor-prod/database`; provide a secret containing a `password` field for each environment.

The test projects use FluentAssertions 8; its license requires a paid license for commercial use. See the package's license terms.
