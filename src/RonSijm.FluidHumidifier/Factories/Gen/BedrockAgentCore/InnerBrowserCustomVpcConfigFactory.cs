// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerBrowserCustomVpcConfigFactory(Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.VpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.BrowserCustomTypes.VpcConfig>
{

    protected override Humidifier.BedrockAgentCore.BrowserCustomTypes.VpcConfig Create()
    {
        var vpcConfigResult = CreateVpcConfig();
        factoryAction?.Invoke(vpcConfigResult);

        return vpcConfigResult;
    }

    private Humidifier.BedrockAgentCore.BrowserCustomTypes.VpcConfig CreateVpcConfig()
    {
        var vpcConfigResult = new Humidifier.BedrockAgentCore.BrowserCustomTypes.VpcConfig();

        return vpcConfigResult;
    }

} // End Of Class

public static class InnerBrowserCustomVpcConfigFactoryExtensions
{
}
