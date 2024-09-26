// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileServiceNowConnectorProfilePropertiesFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.ServiceNowConnectorProfileProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.ServiceNowConnectorProfileProperties>
{

    protected override Humidifier.AppFlow.ConnectorProfileTypes.ServiceNowConnectorProfileProperties Create()
    {
        var serviceNowConnectorProfilePropertiesResult = CreateServiceNowConnectorProfileProperties();
        factoryAction?.Invoke(serviceNowConnectorProfilePropertiesResult);

        return serviceNowConnectorProfilePropertiesResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.ServiceNowConnectorProfileProperties CreateServiceNowConnectorProfileProperties()
    {
        var serviceNowConnectorProfilePropertiesResult = new Humidifier.AppFlow.ConnectorProfileTypes.ServiceNowConnectorProfileProperties();

        return serviceNowConnectorProfilePropertiesResult;
    }

} // End Of Class

public static class InnerConnectorProfileServiceNowConnectorProfilePropertiesFactoryExtensions
{
}
