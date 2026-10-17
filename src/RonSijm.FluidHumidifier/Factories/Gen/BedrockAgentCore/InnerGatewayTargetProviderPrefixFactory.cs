// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayTargetProviderPrefixFactory(Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ProviderPrefix> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTargetTypes.ProviderPrefix>
{

    protected override Humidifier.BedrockAgentCore.GatewayTargetTypes.ProviderPrefix Create()
    {
        var providerPrefixResult = CreateProviderPrefix();
        factoryAction?.Invoke(providerPrefixResult);

        return providerPrefixResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTargetTypes.ProviderPrefix CreateProviderPrefix()
    {
        var providerPrefixResult = new Humidifier.BedrockAgentCore.GatewayTargetTypes.ProviderPrefix();

        return providerPrefixResult;
    }

} // End Of Class

public static class InnerGatewayTargetProviderPrefixFactoryExtensions
{
}
