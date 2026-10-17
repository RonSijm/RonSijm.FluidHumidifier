namespace AppleStore.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.PUMUsersStack;

public class PUMUsersStackComposer : BaseStackComposer<PUMUsersStackConfig>
{
    public override StackCreateResult Create(PUMUsersStackConfig config)
    {
        var environmentFactory = CreateEnvironmentFactory();

        var stack = environmentFactory
        .AddStack("PUM Users");

        CreateDatabaseAccessRole(stack, "DatabaseAccess");

        var stackResult = environmentFactory.Build().First();

        var result = new StackCreateResult
        {
            Stack = stackResult,
        };

        return result;
    }

    private void CreateDatabaseAccessRole(StackFactory stack, string name)
    {
        var policy = stack.WithManagedPolicy(name);

        var policyDocument = policy.WithDocument();

        policyDocument.WithStatement(new List<string>
        {
            "ssm:StartSession",
            "ssm:TerminateSession",
        }, resource: new List<string>()
        {
            $"arn:aws:ssm:{Environment.Region}:{Environment.AWSAccountId}:document/AWS-StartPortForwardingSessionToRemoteHost",
            $"arn:aws:ssm:{Environment.Region}::document/AWS-StartPortForwardingSessionToRemoteHost",
            $"arn:aws:ecs:{Environment.Region}:{Environment.AWSAccountId}:task/AppleStore-{Environment.EnvironmentName}-Cluster/*"
        }, sid: "AllowCreateAndTerminateSessions");

        var allowDescribeSessionsConditions = new Dictionary<string, Dictionary<string, dynamic>>
        {
            ["StringEquals"] = new() { ["ssm:DocumentName"] = "AWS-StartPortForwardingSessionToRemoteHost" },
        };

        policyDocument.WithStatement("ssm:DescribeSessions", principle: null, resource: "*", condition: allowDescribeSessionsConditions, sid: "AllowDescribeSessions");

        var role = stack.WithRole(name, role =>
        {
            role.MaxSessionDuration = 3600;
            role.ManagedPolicyArns = new List<dynamic> { policy.FFnREF() };
        });

        var describeSessionsPrinciple = new Dictionary<string, dynamic>()
        {
            { "Federated", $"arn:aws:iam::{Environment.AWSAccountId}:saml-provider/ADFS" }
        };

        var assumeRoleWithSAMLConditions = new Dictionary<string, Dictionary<string, dynamic>>
        {
            ["StringEquals"] = new() { ["SAML:aud"] = "https://signin.aws.amazon.com/saml" },
        };

        role.WithAssumeRolePolicy().WithStatement("sts:AssumeRoleWithSAML", principle: describeSessionsPrinciple, condition: assumeRoleWithSAMLConditions);
    }
}
