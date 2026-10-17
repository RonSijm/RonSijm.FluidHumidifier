namespace AppleStore.AWS.NimbusFactory.CLI.Features.AssetsAccount.StacksForAssets.ERCServiceStack;

public class ContainerRegistryStackComposer : BaseStackComposer<ContainerRegistryStackConfig>
{
    public override StackCreateResult Create(ContainerRegistryStackConfig config)
    {
        var environmentFactory = CreateEnvironmentFactory();

        var stack = environmentFactory.AddStack("ECRService");

        var repository = stack.WithECRRepository(ResourceConfigSettings.ConceptNameLower, config =>
        {
            config.RepositoryName = ECRServiceConfig.RepositoryName;
        });

        var condition = new Dictionary<string, Dictionary<string, dynamic>>
        {
            ["StringEquals"] = new() { ["aws:PrincipalArn"] = config.ExternalAccountIdsWithAccess.Select(x => $"arn:aws:iam::{x.AWSAccountId}:role/{ResourceConfigSettings.AccessToAssetsRoleName(x.EnvironmentName)}").ToList() },
        };

        if (config.ExternalAccountIdsWithAccess != null && config.ExternalAccountIdsWithAccess.Any())
        {
            repository.WithRepositoryPolicyText().WithStatement([
                "ecr:GetDownloadUrlForLayer",
                "ecr:BatchGetImage",
                "ecr:BatchCheckLayerAvailability"
            ], principle: "*", condition: condition);
        }

        var roleFactory = stack.WithRole(ResourceConfigSettings.AccessToAssetsRoleName(Environment.EnvironmentName));

        roleFactory.WithAssumeRolePolicy()
            .WithStatement("sts:AssumeRole", principle: new
            {
                AWS = config.ExternalAccountIdsWithAccess.Select(x => $"arn:aws:iam::{x.AWSAccountId}:root").ToList()
            });

        InnerRolePolicyFactory policy = roleFactory.WithPolicies();

       policy.WithDocument()
            .WithStatement([
                "ecr:GetDownloadUrlForLayer",
                "ecr:BatchGetImage",
                "ecr:BatchCheckLayerAvailability"
            ], resource: repository.FFnARN());

        //roleFactory.WithPolicies()
        //    .WithDocument()
        //    .WithStatement([
        //        "ecr:GetDownloadUrlForLayer",
        //        "ecr:BatchGetImage",
        //        "ecr:BatchCheckLayerAvailability"
        //    ], resource: FFn.FFnARN(repository));

        var stackResult = environmentFactory.Build().First();

        var result = new StackCreateResult
        {
            Stack = stackResult
        };

        return result;
    }
}