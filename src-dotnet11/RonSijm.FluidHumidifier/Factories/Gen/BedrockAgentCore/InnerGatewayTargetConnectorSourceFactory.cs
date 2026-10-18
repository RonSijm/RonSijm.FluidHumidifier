// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayTargetConnectorSourceFactory(Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorSource> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorSource>
{

    protected override Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorSource Create()
    {
        var connectorSourceResult = CreateConnectorSource();
        factoryAction?.Invoke(connectorSourceResult);

        return connectorSourceResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorSource CreateConnectorSource()
    {
        var connectorSourceResult = new Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorSource();

        return connectorSourceResult;
    }

} // End Of Class

public static class InnerGatewayTargetConnectorSourceFactoryExtensions
{
}
