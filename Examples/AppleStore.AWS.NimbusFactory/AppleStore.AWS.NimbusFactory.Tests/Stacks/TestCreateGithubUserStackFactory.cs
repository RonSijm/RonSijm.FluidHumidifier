using AppleStore.AWS.NimbusFactory.CLI.Features.AllAccounts.StacksForAllAccounts.GithubUserStack;
using AppleStore.AWS.NimbusFactory.Tests.Base;

namespace AppleStore.AWS.NimbusFactory.Tests.Stacks;

public class TestCreateGithubUserStackFactory : BaseBuilderBuilderTest<GithubUserStackComposer>
{
    protected override Task<Stack> BuildStack()
    {
        var result = SUT.Create(new GithubUserStackConfig()
        {
            DeployPermissions = new List<string>()
            {
                "ecr:CreateRepository"
            }
        });

        return Task.FromResult(result.Stack);
    }
}