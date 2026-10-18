// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowDatadogSourcePropertiesFactory(Action<Humidifier.AppFlow.FlowTypes.DatadogSourceProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.DatadogSourceProperties>
{

    protected override Humidifier.AppFlow.FlowTypes.DatadogSourceProperties Create()
    {
        var datadogSourcePropertiesResult = CreateDatadogSourceProperties();
        factoryAction?.Invoke(datadogSourcePropertiesResult);

        return datadogSourcePropertiesResult;
    }

    private Humidifier.AppFlow.FlowTypes.DatadogSourceProperties CreateDatadogSourceProperties()
    {
        var datadogSourcePropertiesResult = new Humidifier.AppFlow.FlowTypes.DatadogSourceProperties();

        return datadogSourcePropertiesResult;
    }

} // End Of Class

public static class InnerFlowDatadogSourcePropertiesFactoryExtensions
{
}
