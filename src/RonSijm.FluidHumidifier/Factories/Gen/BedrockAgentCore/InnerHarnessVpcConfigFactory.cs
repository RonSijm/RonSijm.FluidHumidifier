// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessVpcConfigFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.VpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.VpcConfig>
{

    protected override Humidifier.BedrockAgentCore.HarnessTypes.VpcConfig Create()
    {
        var vpcConfigResult = CreateVpcConfig();
        factoryAction?.Invoke(vpcConfigResult);

        return vpcConfigResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.VpcConfig CreateVpcConfig()
    {
        var vpcConfigResult = new Humidifier.BedrockAgentCore.HarnessTypes.VpcConfig();

        return vpcConfigResult;
    }

} // End Of Class

public static class InnerHarnessVpcConfigFactoryExtensions
{
}
