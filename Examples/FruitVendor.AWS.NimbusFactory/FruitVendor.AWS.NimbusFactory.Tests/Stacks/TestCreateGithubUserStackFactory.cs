using FruitVendor.AWS.NimbusFactory.CLI.Features.AllAccounts.StacksForAllAccounts.GithubUserStack;
using FruitVendor.AWS.NimbusFactory.Tests.Base;

namespace FruitVendor.AWS.NimbusFactory.Tests.Stacks;

public class TestCreateGithubUserStackFactory : BaseBuilderBuilderTest<GithubUserStackComposer>
{
    protected override Task<Stack> BuildStack()
    {
        var result = SUT.Create(new GithubUserStackConfig()
        {
            RepoRoot = "FruitVendor",
            DeployPermissions = new List<string>()
            {
                "ecr:CreateRepository"
            }
        });

        return Task.FromResult(result.Stack);
    }
}
