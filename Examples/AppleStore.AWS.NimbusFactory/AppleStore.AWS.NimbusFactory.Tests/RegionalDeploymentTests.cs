using System.Text.RegularExpressions;
using RonSijm.FluidHumidifier.Batch;
using RonSijm.FluidHumidifier.Features.Consumer;
using RonSijm.FluidHumidifier.Features.Output;
using RonSijm.FluidHumidifier.Github;

namespace AppleStore.AWS.NimbusFactory.Tests;

public class RegionalDeploymentTests
{
    [Fact]
    public void DeploymentScriptsUseTheBackupRegionOnlyForTheBackupStack()
    {
        var environment = new EnvironmentOutputResult
        {
            Environment = new EnvironmentConfig("dev", "1234", "eu-central-1"),
            RegionName = "eu-central-1"
        };
        environment.Add(new StackCreateResult { Stack = new Stack { Name = "Primary" } }, "Cloud Formation\\Scripts");
        environment.Add(new StackCreateResult
        {
            Stack = new Stack { Name = "Backup" },
            Region = "eu-west-3"
        }, "Cloud Formation\\Scripts");
        environment.Add(new StackCreateResult { Stack = new Stack { Name = "AfterBackup" } }, "Cloud Formation\\Scripts");

        var outputDirectory = Directory.CreateTempSubdirectory("AppleStoreRegionalDeploymentTests-");
        try
        {
            BatchActionFactory.CreateEnvironmentAction(environment, new CreateEnvironmentConfig
            {
                OutputDir = outputDirectory.FullName
            });
            GithubActionFactory.CreateEnvironmentAction(environment, new CreateGithubActionConfig
            {
                OutputDir = outputDirectory.FullName + Path.DirectorySeparatorChar,
                BranchName = _ => "main"
            });

            var batch = File.ReadAllText(Path.Combine(outputDirectory.FullName, "deploy-cf-dev.bat"));
            var batchSteps = Regex.Split(batch, @"(?m)^echo ");
            Assert.Contains("--region eu-central-1", batchSteps.Single(step => step.StartsWith("Primary")));
            Assert.Contains("--region eu-west-3", batchSteps.Single(step => step.StartsWith("Backup")));
            Assert.Contains("--region eu-central-1", batchSteps.Single(step => step.StartsWith("AfterBackup")));

            var workflow = File.ReadAllText(Path.Combine(outputDirectory.FullName, "auto-deploy-cf-dev.yml"));
            var workflowSteps = Regex.Split(workflow, @"(?m)^    - name: ");
            var backupStep = workflowSteps.Single(step => step.Contains("id: CF-2-dev-Backup-Stack"));
            Assert.Contains("AWS_REGION: eu-west-3", backupStep);
            Assert.Contains("AWS_DEFAULT_REGION: eu-west-3", backupStep);
            Assert.DoesNotContain("AWS_REGION: eu-west-3",
                workflowSteps.Single(step => step.Contains("id: CF-1-dev-Primary-Stack")));
            Assert.DoesNotContain("AWS_REGION: eu-west-3",
                workflowSteps.Single(step => step.Contains("id: CF-3-dev-AfterBackup-Stack")));
        }
        finally
        {
            outputDirectory.Delete(recursive: true);
        }
    }
}
