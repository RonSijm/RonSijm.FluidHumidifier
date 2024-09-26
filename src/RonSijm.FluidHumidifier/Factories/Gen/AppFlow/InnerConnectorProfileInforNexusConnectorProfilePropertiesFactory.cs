// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileInforNexusConnectorProfilePropertiesFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.InforNexusConnectorProfileProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.InforNexusConnectorProfileProperties>
{

    protected override Humidifier.AppFlow.ConnectorProfileTypes.InforNexusConnectorProfileProperties Create()
    {
        var inforNexusConnectorProfilePropertiesResult = CreateInforNexusConnectorProfileProperties();
        factoryAction?.Invoke(inforNexusConnectorProfilePropertiesResult);

        return inforNexusConnectorProfilePropertiesResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.InforNexusConnectorProfileProperties CreateInforNexusConnectorProfileProperties()
    {
        var inforNexusConnectorProfilePropertiesResult = new Humidifier.AppFlow.ConnectorProfileTypes.InforNexusConnectorProfileProperties();

        return inforNexusConnectorProfilePropertiesResult;
    }

} // End Of Class

public static class InnerConnectorProfileInforNexusConnectorProfilePropertiesFactoryExtensions
{
}
