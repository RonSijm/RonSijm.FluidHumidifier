// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerRuntimeVpcConfigFactory(Action<Humidifier.BedrockAgentCore.RuntimeTypes.VpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.RuntimeTypes.VpcConfig>
{

    protected override Humidifier.BedrockAgentCore.RuntimeTypes.VpcConfig Create()
    {
        var vpcConfigResult = CreateVpcConfig();
        factoryAction?.Invoke(vpcConfigResult);

        return vpcConfigResult;
    }

    private Humidifier.BedrockAgentCore.RuntimeTypes.VpcConfig CreateVpcConfig()
    {
        var vpcConfigResult = new Humidifier.BedrockAgentCore.RuntimeTypes.VpcConfig();

        return vpcConfigResult;
    }

} // End Of Class

public static class InnerRuntimeVpcConfigFactoryExtensions
{
}
