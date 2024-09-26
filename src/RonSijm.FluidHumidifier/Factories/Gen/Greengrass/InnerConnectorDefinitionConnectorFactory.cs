// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerConnectorDefinitionConnectorFactory(Action<Humidifier.Greengrass.ConnectorDefinitionTypes.Connector> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.ConnectorDefinitionTypes.Connector>
{

    protected override Humidifier.Greengrass.ConnectorDefinitionTypes.Connector Create()
    {
        var connectorResult = CreateConnector();
        factoryAction?.Invoke(connectorResult);

        return connectorResult;
    }

    private Humidifier.Greengrass.ConnectorDefinitionTypes.Connector CreateConnector()
    {
        var connectorResult = new Humidifier.Greengrass.ConnectorDefinitionTypes.Connector();

        return connectorResult;
    }

} // End Of Class

public static class InnerConnectorDefinitionConnectorFactoryExtensions
{
}
