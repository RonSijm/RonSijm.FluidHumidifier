namespace AppleStore.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.ECRServiceAccessStack;

public class ERCServiceAccessStackComposer : BaseStackComposer<ERCServiceAccessStackConfig>
{
    public override StackCreateResult Create(ERCServiceAccessStackConfig config)
    {
        var environmentFactory = CreateEnvironmentFactory();

        var stack = environmentFactory
            .AddStack("ECR Service Access");

        var ecsTaskExecutionRolePolicy = stack.WithManagedPolicy($"ecs-{Environment.EnvironmentName}-TaskExecutionRole");
        ecsTaskExecutionRolePolicy.WithDocument().WithStatement(ECRNeededPermissions.ExecutionPermissions, resource: "*");

        var getEnvironmentVariablesPolicy = stack.WithManagedPolicy("ecsTaskCanGetEnvironmentVariables");

        getEnvironmentVariablesPolicy.WithDocument().WithStatement(ECRNeededPermissions.S3Permissions, resource: "*");

        var role = stack.WithRole(ResourceConfigSettings.AccessToAssetsRoleName(Environment.EnvironmentName), roleConfig =>
        {
            roleConfig.MaxSessionDuration = 3600;
            roleConfig.ManagedPolicyArns = new List<dynamic>
            {
                ecsTaskExecutionRolePolicy.FFnREF(),
                getEnvironmentVariablesPolicy.FFnREF()
            };
        });


        var assumeRolePolicy = role.WithAssumeRolePolicy();

        assumeRolePolicy.WithStatement("sts:AssumeRole", principle: new { Service = "ecs-tasks.amazonaws.com" });
        assumeRolePolicy.WithStatement("sts:AssumeRole", principle: new { AWS = $"arn:aws:iam::{config.AssetAccountId}:root" });
        assumeRolePolicy.WithStatement("sts:AssumeRole", principle: new { AWS = $"arn:aws:iam::{Environment.AWSAccountId}:root" });
        assumeRolePolicy.WithStatement("sts:AssumeRole", principle: new { AWS = $"arn:aws:iam::{config.AssetAccountId}:role/{ResourceConfigSettings.AccessToAssetsRoleName(AccountConfigSettings.AssetAccountName)}" });

        var export = new ExportModel { role };

        var stackResult = environmentFactory.Build().First();

        var result = new StackCreateResult
        {
            Stack = stackResult,
            Export = export
        };

        return result;
    }
}