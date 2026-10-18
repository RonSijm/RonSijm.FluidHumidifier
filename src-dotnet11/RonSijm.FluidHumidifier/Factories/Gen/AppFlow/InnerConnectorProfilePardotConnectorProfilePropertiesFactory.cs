// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfilePardotConnectorProfilePropertiesFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.PardotConnectorProfileProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.PardotConnectorProfileProperties>
{

    protected override Humidifier.AppFlow.ConnectorProfileTypes.PardotConnectorProfileProperties Create()
    {
        var pardotConnectorProfilePropertiesResult = CreatePardotConnectorProfileProperties();
        factoryAction?.Invoke(pardotConnectorProfilePropertiesResult);

        return pardotConnectorProfilePropertiesResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.PardotConnectorProfileProperties CreatePardotConnectorProfileProperties()
    {
        var pardotConnectorProfilePropertiesResult = new Humidifier.AppFlow.ConnectorProfileTypes.PardotConnectorProfileProperties();

        return pardotConnectorProfilePropertiesResult;
    }

} // End Of Class

public static class InnerConnectorProfilePardotConnectorProfilePropertiesFactoryExtensions
{
}
