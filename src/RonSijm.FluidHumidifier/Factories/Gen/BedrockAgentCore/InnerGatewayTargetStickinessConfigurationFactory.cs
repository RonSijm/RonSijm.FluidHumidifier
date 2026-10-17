// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayTargetStickinessConfigurationFactory(Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.StickinessConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTargetTypes.StickinessConfiguration>
{

    protected override Humidifier.BedrockAgentCore.GatewayTargetTypes.StickinessConfiguration Create()
    {
        var stickinessConfigurationResult = CreateStickinessConfiguration();
        factoryAction?.Invoke(stickinessConfigurationResult);

        return stickinessConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTargetTypes.StickinessConfiguration CreateStickinessConfiguration()
    {
        var stickinessConfigurationResult = new Humidifier.BedrockAgentCore.GatewayTargetTypes.StickinessConfiguration();

        return stickinessConfigurationResult;
    }

} // End Of Class

public static class InnerGatewayTargetStickinessConfigurationFactoryExtensions
{
}
