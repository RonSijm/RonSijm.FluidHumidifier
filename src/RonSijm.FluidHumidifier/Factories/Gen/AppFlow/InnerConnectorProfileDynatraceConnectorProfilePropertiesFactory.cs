// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileDynatraceConnectorProfilePropertiesFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.DynatraceConnectorProfileProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.DynatraceConnectorProfileProperties>
{

    protected override Humidifier.AppFlow.ConnectorProfileTypes.DynatraceConnectorProfileProperties Create()
    {
        var dynatraceConnectorProfilePropertiesResult = CreateDynatraceConnectorProfileProperties();
        factoryAction?.Invoke(dynatraceConnectorProfilePropertiesResult);

        return dynatraceConnectorProfilePropertiesResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.DynatraceConnectorProfileProperties CreateDynatraceConnectorProfileProperties()
    {
        var dynatraceConnectorProfilePropertiesResult = new Humidifier.AppFlow.ConnectorProfileTypes.DynatraceConnectorProfileProperties();

        return dynatraceConnectorProfilePropertiesResult;
    }

} // End Of Class

public static class InnerConnectorProfileDynatraceConnectorProfilePropertiesFactoryExtensions
{
}
