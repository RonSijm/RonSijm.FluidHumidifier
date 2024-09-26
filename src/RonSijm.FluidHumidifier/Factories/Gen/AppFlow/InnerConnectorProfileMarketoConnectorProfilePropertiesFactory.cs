// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileMarketoConnectorProfilePropertiesFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.MarketoConnectorProfileProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.MarketoConnectorProfileProperties>
{

    protected override Humidifier.AppFlow.ConnectorProfileTypes.MarketoConnectorProfileProperties Create()
    {
        var marketoConnectorProfilePropertiesResult = CreateMarketoConnectorProfileProperties();
        factoryAction?.Invoke(marketoConnectorProfilePropertiesResult);

        return marketoConnectorProfilePropertiesResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.MarketoConnectorProfileProperties CreateMarketoConnectorProfileProperties()
    {
        var marketoConnectorProfilePropertiesResult = new Humidifier.AppFlow.ConnectorProfileTypes.MarketoConnectorProfileProperties();

        return marketoConnectorProfilePropertiesResult;
    }

} // End Of Class

public static class InnerConnectorProfileMarketoConnectorProfilePropertiesFactoryExtensions
{
}
