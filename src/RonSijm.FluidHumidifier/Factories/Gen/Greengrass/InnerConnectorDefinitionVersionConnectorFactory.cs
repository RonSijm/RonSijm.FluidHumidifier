// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerConnectorDefinitionVersionConnectorFactory(Action<Humidifier.Greengrass.ConnectorDefinitionVersionTypes.Connector> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.ConnectorDefinitionVersionTypes.Connector>
{

    protected override Humidifier.Greengrass.ConnectorDefinitionVersionTypes.Connector Create()
    {
        var connectorResult = CreateConnector();
        factoryAction?.Invoke(connectorResult);

        return connectorResult;
    }

    private Humidifier.Greengrass.ConnectorDefinitionVersionTypes.Connector CreateConnector()
    {
        var connectorResult = new Humidifier.Greengrass.ConnectorDefinitionVersionTypes.Connector();

        return connectorResult;
    }

} // End Of Class

public static class InnerConnectorDefinitionVersionConnectorFactoryExtensions
{
}
