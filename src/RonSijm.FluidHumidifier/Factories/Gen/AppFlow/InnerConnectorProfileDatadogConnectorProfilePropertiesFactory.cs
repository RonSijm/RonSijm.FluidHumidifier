// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileDatadogConnectorProfilePropertiesFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.DatadogConnectorProfileProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.DatadogConnectorProfileProperties>
{

    protected override Humidifier.AppFlow.ConnectorProfileTypes.DatadogConnectorProfileProperties Create()
    {
        var datadogConnectorProfilePropertiesResult = CreateDatadogConnectorProfileProperties();
        factoryAction?.Invoke(datadogConnectorProfilePropertiesResult);

        return datadogConnectorProfilePropertiesResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.DatadogConnectorProfileProperties CreateDatadogConnectorProfileProperties()
    {
        var datadogConnectorProfilePropertiesResult = new Humidifier.AppFlow.ConnectorProfileTypes.DatadogConnectorProfileProperties();

        return datadogConnectorProfilePropertiesResult;
    }

} // End Of Class

public static class InnerConnectorProfileDatadogConnectorProfilePropertiesFactoryExtensions
{
}
