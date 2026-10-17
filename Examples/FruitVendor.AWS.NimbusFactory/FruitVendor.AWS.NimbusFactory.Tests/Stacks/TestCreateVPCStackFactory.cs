using FruitVendor.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.VPCInfrastructureStack;
using FruitVendor.AWS.NimbusFactory.Tests.Base;

namespace FruitVendor.AWS.NimbusFactory.Tests.Stacks;

public class TestCreateVpcStackFactory : BaseBuilderBuilderTest<VPCInfrastructureStackComposer>
{
    protected override Task<Stack> BuildStack()
    {
        var result = SUT.Create(new VPCInfrastructureConfig());

        var stack = result.Stack;

        return Task.FromResult(stack);
    }
}