// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileVeevaConnectorProfilePropertiesFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.VeevaConnectorProfileProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.VeevaConnectorProfileProperties>
{

    protected override Humidifier.AppFlow.ConnectorProfileTypes.VeevaConnectorProfileProperties Create()
    {
        var veevaConnectorProfilePropertiesResult = CreateVeevaConnectorProfileProperties();
        factoryAction?.Invoke(veevaConnectorProfilePropertiesResult);

        return veevaConnectorProfilePropertiesResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.VeevaConnectorProfileProperties CreateVeevaConnectorProfileProperties()
    {
        var veevaConnectorProfilePropertiesResult = new Humidifier.AppFlow.ConnectorProfileTypes.VeevaConnectorProfileProperties();

        return veevaConnectorProfilePropertiesResult;
    }

} // End Of Class

public static class InnerConnectorProfileVeevaConnectorProfilePropertiesFactoryExtensions
{
}
