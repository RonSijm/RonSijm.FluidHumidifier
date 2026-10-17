// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class InnerConnectorConnectorAsyncMdnConfigFactory(Action<Humidifier.Transfer.ConnectorTypes.ConnectorAsyncMdnConfig> factoryAction = null) : SubResourceFactory<Humidifier.Transfer.ConnectorTypes.ConnectorAsyncMdnConfig>
{

    protected override Humidifier.Transfer.ConnectorTypes.ConnectorAsyncMdnConfig Create()
    {
        var connectorAsyncMdnConfigResult = CreateConnectorAsyncMdnConfig();
        factoryAction?.Invoke(connectorAsyncMdnConfigResult);

        return connectorAsyncMdnConfigResult;
    }

    private Humidifier.Transfer.ConnectorTypes.ConnectorAsyncMdnConfig CreateConnectorAsyncMdnConfig()
    {
        var connectorAsyncMdnConfigResult = new Humidifier.Transfer.ConnectorTypes.ConnectorAsyncMdnConfig();

        return connectorAsyncMdnConfigResult;
    }

} // End Of Class

public static class InnerConnectorConnectorAsyncMdnConfigFactoryExtensions
{
}
