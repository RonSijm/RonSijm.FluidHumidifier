namespace AppleStore.AWS.NimbusFactory.CLI;

public class NimbusFactoryCore(EnvironmentResultFactory environmentResultFactory, GithubActionFactory githubActionFactory, BatchActionFactory batchActionFactory, AppSettings appSettings)
{
    public void Create()
    {
        var environmentResults = environmentResultFactory.CreateEnvironments();

        var actionConfig = new CreateGithubActionConfig
        {
            OutputDir = $"{appSettings.BaseDir}.github\\workflows\\",
            StartNotificationsAtStack = 5,
            WithNotifications = environment => $"arn:aws:sns:{AWSConfigSettings.DefaultRegion}:{environment.AWSAccountId}:{ResourceConfigSettings.ConceptNameLower}-sysops-{environment.EnvironmentName}-Topic",
            DisableRoleBack = false,
            // BranchName = environment => $"CloudFormation/{environment}"
            // Override Git Branch for testing
            BranchName = _ => "main"
        };

        foreach (var environmentOutputResult in environmentResults)
        {
            githubActionFactory.CreateActions(environmentResults, actionConfig);
        }

        var batchActionConfig = new CreateEnvironmentConfig
        {
            OutputDir = $"{appSettings.BaseDir}Cloud Formation\\Scripts\\",
            StartNotificationsAtStack = 5,
            WithNotifications = environment => $"arn:aws:sns:{AWSConfigSettings.DefaultRegion}:{environment.AWSAccountId}:{ResourceConfigSettings.ConceptNameLower}-sysops-{environment.EnvironmentName}-Topic",
            DisableRoleBack = false
        };

        actionConfig.OutputDir = $"{appSettings.BaseDir}Cloud Formation\\Scripts";

        foreach (var environmentOutputResult in environmentResults)
        {
            batchActionFactory.CreateActions(environmentResults, batchActionConfig);
        }
    }
}
