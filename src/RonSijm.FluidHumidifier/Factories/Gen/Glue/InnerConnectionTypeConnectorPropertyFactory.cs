// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerConnectionTypeConnectorPropertyFactory(Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> factoryAction = null) : SubResourceFactory<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty>
{

    protected override Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty Create()
    {
        var connectorPropertyResult = CreateConnectorProperty();
        factoryAction?.Invoke(connectorPropertyResult);

        return connectorPropertyResult;
    }

    private Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty CreateConnectorProperty()
    {
        var connectorPropertyResult = new Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty();

        return connectorPropertyResult;
    }

} // End Of Class

public static class InnerConnectionTypeConnectorPropertyFactoryExtensions
{
}
