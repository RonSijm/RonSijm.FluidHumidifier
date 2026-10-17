// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayTargetHttpConnectorSourceFactory(Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpConnectorSource> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpConnectorSource>
{

    protected override Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpConnectorSource Create()
    {
        var httpConnectorSourceResult = CreateHttpConnectorSource();
        factoryAction?.Invoke(httpConnectorSourceResult);

        return httpConnectorSourceResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpConnectorSource CreateHttpConnectorSource()
    {
        var httpConnectorSourceResult = new Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpConnectorSource();

        return httpConnectorSourceResult;
    }

} // End Of Class

public static class InnerGatewayTargetHttpConnectorSourceFactoryExtensions
{
}
