// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileZendeskConnectorProfilePropertiesFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.ZendeskConnectorProfileProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.ZendeskConnectorProfileProperties>
{

    protected override Humidifier.AppFlow.ConnectorProfileTypes.ZendeskConnectorProfileProperties Create()
    {
        var zendeskConnectorProfilePropertiesResult = CreateZendeskConnectorProfileProperties();
        factoryAction?.Invoke(zendeskConnectorProfilePropertiesResult);

        return zendeskConnectorProfilePropertiesResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.ZendeskConnectorProfileProperties CreateZendeskConnectorProfileProperties()
    {
        var zendeskConnectorProfilePropertiesResult = new Humidifier.AppFlow.ConnectorProfileTypes.ZendeskConnectorProfileProperties();

        return zendeskConnectorProfilePropertiesResult;
    }

} // End Of Class

public static class InnerConnectorProfileZendeskConnectorProfilePropertiesFactoryExtensions
{
}
