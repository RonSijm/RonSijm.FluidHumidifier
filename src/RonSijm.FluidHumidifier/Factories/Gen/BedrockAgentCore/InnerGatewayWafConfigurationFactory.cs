// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayWafConfigurationFactory(Action<Humidifier.BedrockAgentCore.GatewayTypes.WafConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTypes.WafConfiguration>
{

    protected override Humidifier.BedrockAgentCore.GatewayTypes.WafConfiguration Create()
    {
        var wafConfigurationResult = CreateWafConfiguration();
        factoryAction?.Invoke(wafConfigurationResult);

        return wafConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTypes.WafConfiguration CreateWafConfiguration()
    {
        var wafConfigurationResult = new Humidifier.BedrockAgentCore.GatewayTypes.WafConfiguration();

        return wafConfigurationResult;
    }

} // End Of Class

public static class InnerGatewayWafConfigurationFactoryExtensions
{
}
