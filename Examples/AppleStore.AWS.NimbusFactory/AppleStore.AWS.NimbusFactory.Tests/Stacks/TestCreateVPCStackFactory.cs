using AppleStore.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.VPCInfrastructureStack;
using AppleStore.AWS.NimbusFactory.Tests.Base;

namespace AppleStore.AWS.NimbusFactory.Tests.Stacks;

public class TestCreateVpcStackFactory : BaseBuilderBuilderTest<VPCInfrastructureStackComposer>
{
    protected override Task<Stack> BuildStack()
    {
        var result = SUT.Create(new VPCInfrastructureConfig());

        var stack = result.Stack;

        return Task.FromResult(stack);
    }
}