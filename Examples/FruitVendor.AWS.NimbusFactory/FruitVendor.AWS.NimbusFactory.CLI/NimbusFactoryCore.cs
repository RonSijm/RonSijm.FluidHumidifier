using FruitVendor.AWS.NimbusFactory.CLI.Core.Config;

namespace FruitVendor.AWS.NimbusFactory.CLI;

public class NimbusFactoryCore(EnvironmentResultFactory environmentResultFactory, GithubActionFactory githubActionFactory, BatchActionFactory batchActionFactory, AppSettings appSettings)
{
    public void Create()
    {
        var environmentResults = environmentResultFactory.CreateEnvironments();

        var actionConfig = new CreateGithubActionConfig
        {
            OutputDir = $"{appSettings.BaseDir}.github\\workflows\\",
            StartNotificationsAtStack = 0,
            WithNotifications = environment => $"arn:aws:sns:{AWSConfigSettings.RegionName}:{environment.AWSAccountId}:{ResourceConfigSettings.ConceptNameLower}-sysops-{environment.EnvironmentName}-Topic",
            DisableRoleBack = false,
            // BranchName = environment => $"CloudFormation/{environment}"
            // Override Git Branch for testing
            BranchName = _ => "main",
        };

        foreach (var environmentOutputResult in environmentResults)
        {
            githubActionFactory.CreateActions(environmentResults, actionConfig);
        }

        var batchActionConfig = new CreateEnvironmentConfig
        {
            OutputDir = $"{appSettings.BaseDir}.github\\workflows\\",
            StartNotificationsAtStack = 1,
            WithNotifications = environment => $"arn:aws:sns:{AWSConfigSettings.RegionName}:{environment.AWSAccountId}:{ResourceConfigSettings.ConceptNameLower}-sysops-{environment.EnvironmentName}-Topic",
            DisableRoleBack = false
        };

        batchActionConfig.OutputDir = $"{appSettings.BaseDir}Cloud Formation\\";

        foreach (var environmentOutputResult in environmentResults)
        {
            batchActionFactory.CreateActions(environmentResults, batchActionConfig);
        }
    }
}
