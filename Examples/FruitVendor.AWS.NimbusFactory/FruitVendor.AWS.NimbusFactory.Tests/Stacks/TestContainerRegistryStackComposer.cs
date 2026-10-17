using FruitVendor.AWS.NimbusFactory.CLI.Features.AssetsAccount.StacksForAssets.ERCServiceStack;
using FruitVendor.AWS.NimbusFactory.Tests.Base;
using RonSijm.FluidHumidifier.Features.Consumer;

namespace FruitVendor.AWS.NimbusFactory.Tests.Stacks;

public class TestContainerRegistryStackComposer : BaseBuilderBuilderTest<ContainerRegistryStackComposer>
{
    protected override Task<Stack> BuildStack()
    {
        var result = SUT.Create(new ContainerRegistryStackConfig()
        {
            ExternalAccountIdsWithAccess = new List<EnvironmentConfig>
            {
                new("test1234", "1234", "any"),
                new("test5678", "5678", "any")
            }
        });

        return Task.FromResult(result.Stack);
    }
}