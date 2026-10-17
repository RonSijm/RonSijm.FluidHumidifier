using AppleStore.AWS.NimbusFactory.CLI.Features.AssetsAccount.StacksForAssets.ERCServiceStack;
using AppleStore.AWS.NimbusFactory.Tests.Base;
using Humidifier.Helpers;
using RonSijm.FluidHumidifier.Features.Consumer;

namespace AppleStore.AWS.NimbusFactory.Tests.Stacks;

public class TestContainerRegistryStackComposer : BaseBuilderBuilderTest<ContainerRegistryStackComposer>
{
    protected override Task<Stack> BuildStack()
    {
        var region = "eu-central-1";

        var result = SUT.Create(new ContainerRegistryStackConfig()
        {
            ExternalAccountIdsWithAccess = new List<EnvironmentConfig>
            {
                new("test1234", "1234", region),
                new("test5678", "5678", region)
            }
        });

        return Task.FromResult(result.Stack);
    }
}
