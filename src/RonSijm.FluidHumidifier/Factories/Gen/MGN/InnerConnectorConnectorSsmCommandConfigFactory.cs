// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MGN;

public class InnerConnectorConnectorSsmCommandConfigFactory(Action<Humidifier.MGN.ConnectorTypes.ConnectorSsmCommandConfig> factoryAction = null) : SubResourceFactory<Humidifier.MGN.ConnectorTypes.ConnectorSsmCommandConfig>
{

    protected override Humidifier.MGN.ConnectorTypes.ConnectorSsmCommandConfig Create()
    {
        var connectorSsmCommandConfigResult = CreateConnectorSsmCommandConfig();
        factoryAction?.Invoke(connectorSsmCommandConfigResult);

        return connectorSsmCommandConfigResult;
    }

    private Humidifier.MGN.ConnectorTypes.ConnectorSsmCommandConfig CreateConnectorSsmCommandConfig()
    {
        var connectorSsmCommandConfigResult = new Humidifier.MGN.ConnectorTypes.ConnectorSsmCommandConfig();

        return connectorSsmCommandConfigResult;
    }

} // End Of Class

public static class InnerConnectorConnectorSsmCommandConfigFactoryExtensions
{
}
