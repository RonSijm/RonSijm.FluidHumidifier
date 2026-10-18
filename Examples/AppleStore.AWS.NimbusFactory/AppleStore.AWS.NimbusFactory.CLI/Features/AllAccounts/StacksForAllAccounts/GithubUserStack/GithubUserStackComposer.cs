namespace AppleStore.AWS.NimbusFactory.CLI.Features.AllAccounts.StacksForAllAccounts.GithubUserStack;

public class GithubUserStackComposer : BaseStackComposer<GithubUserStackConfig>
{
    public override StackCreateResult Create(GithubUserStackConfig config)
    {
        var environmentFactory = CreateEnvironmentFactory();

        var stack = environmentFactory.AddStack("Github User");

        // Policy that assures that you cannot randomly assume other roles.
        var oidcSafetyPolicy = stack.WithManagedPolicy("OidcSafety");
        var oidcSafetyPolicyDocument = oidcSafetyPolicy.WithDocument();
        oidcSafetyPolicyDocument.WithStatement(
            action: "sts:AssumeRole",
            resource: "*",
            sid: "OidcSafeties",
            effect: "Deny"
        );

        var githubActionsDeployPolicy = stack.WithManagedPolicy("GitHub-Actions-Deploy");
        var deployPolicyDocument = githubActionsDeployPolicy.WithDocument();
        deployPolicyDocument.WithStatement(
            action: "*",
            resource: "*",
            effect: "Allow"
        );

        var githubActionsRole = stack.WithRole("GitHubActionsRole", role =>
        {
            role.RoleName = "GitHub-Actions-Role";
            role.ManagedPolicyArns = new List<Union<string, BaseFunction>>
            {
                oidcSafetyPolicy.FFnREF(),
                githubActionsDeployPolicy.FFnREF()
            };
        });

        var assumeRolePolicy = githubActionsRole.WithAssumeRolePolicy();

        var condition = new Dictionary<string, Dictionary<string, object>>
        {
            ["StringLike"] = new() { ["token.actions.githubusercontent.com:sub"] = new[] { "repo:AppleStore/*" } },
            ["StringEqualsIgnoreCase"] = new() { ["token.actions.githubusercontent.com:aud"] = "sts.amazonaws.com" },
        };

        assumeRolePolicy.WithStatement(action: "sts:AssumeRoleWithWebIdentity", principle: new PolicyPrincipal {
            Federated = Fn.Sub("arn:aws:iam::${AWS::AccountId}:oidc-provider/token.actions.githubusercontent.com")
        }, condition: condition);

        stack.WithOIDCProvider("GitHubActionsOidcProvider", provider =>
        {
            provider.ClientIdList = new[] { "sts.amazonaws.com" };
            provider.ThumbprintList = new[] { "6938fd4d98bab03faadb97b34396831e3780aea1" };
            provider.Url = "https://token.actions.githubusercontent.com";
        });

        var export = new ExportModel { oidcSafetyPolicy };

        var stackResult = environmentFactory.Build().First();

        var result = new StackCreateResult
        {
            Stack = stackResult,
            Export = export
        };

        return result;
    }
}