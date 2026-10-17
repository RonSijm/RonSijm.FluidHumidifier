using AppleStore.AWS.NimbusFactory.CLI.Features.AllAccounts.StacksForAllAccounts.CircleCIUserStack;
using AppleStore.AWS.NimbusFactory.CLI.Features.AssetsAccount.StacksForAssets.ERCServiceStack;

namespace AppleStore.AWS.NimbusFactory.CLI.Features.AssetsAccount.AssetEnvironmentComposer;

public class AssetsEnvironmentComposer(GithubUserStackComposer githubUserStackComposer,
    CloudformationResourcesStackComposer cloudformationResourcesStackComposer,
    SlackLoggerStackComposer slackLoggerStackComposer,
    ContainerRegistryStackComposer ecrServiceStackComposer,
    CircleCIUserStackComposer circleCIUserStackComposer,
    DecoratorOrchestrator decoratorOrchestrator) : BaseEnvironmentComposer<AssetsEnvironmentFactoryConfig>(decoratorOrchestrator)
{
    protected override EnvironmentOutputResult Create(AssetsEnvironmentFactoryConfig config)
    {
        var result = new EnvironmentOutputResult
        {
            Environment = config.Environment,
            RegionName = AWSConfigSettings.DefaultRegion,
        };

        var githubUserStack = githubUserStackComposer.Create(new GithubUserStackConfig
        {
            DeployPermissions = AssetsNeededDeployPermissions.AssetPermissions,
        });

        var scriptsBasePath = $"Cloud Formation\\Scripts\\1 - All\\";

        var githubResources = result.Add(githubUserStack, $"{scriptsBasePath}4 - Create CloudFormation {githubUserStack.Stack.Name} Stack\\{config.Environment.EnvironmentName}");

        var lambdaResources = result.Add(() => cloudformationResourcesStackComposer.Create(new CloudformationResourcesConfig()), $"{scriptsBasePath}5 - Cloudformation Resources Stack\\{config.Environment.EnvironmentName}");
        
        result.Add(() => slackLoggerStackComposer.Create(new SlackLoggerStackConfig
            {
                Import = new List<ExportModel> { lambdaResources.Export, githubResources.Export }
            }),
            $"{scriptsBasePath}6 - Create Lambda Logger Stack\\{config.Environment.EnvironmentName}"
        );

        result.Add(() => ecrServiceStackComposer.Create(new ContainerRegistryStackConfig
        {
            ExternalAccountIdsWithAccess = config.AccountsIdsWithAccessToERC
        }));

        result.Add(() => circleCIUserStackComposer.Create(new CircleCIUserStackConfig
        {
            Import = new List<ExportModel> { githubResources.Export }
        }),
            $"{scriptsBasePath}9 - Create CircleCI User\\{config.Environment.EnvironmentName}"
        );

        return result;
    }
}
