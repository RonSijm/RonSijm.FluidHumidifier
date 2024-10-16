// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowLookoutMetricsDestinationPropertiesFactory(Action<Humidifier.AppFlow.FlowTypes.LookoutMetricsDestinationProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.LookoutMetricsDestinationProperties>
{

    protected override Humidifier.AppFlow.FlowTypes.LookoutMetricsDestinationProperties Create()
    {
        var lookoutMetricsDestinationPropertiesResult = CreateLookoutMetricsDestinationProperties();
        factoryAction?.Invoke(lookoutMetricsDestinationPropertiesResult);

        return lookoutMetricsDestinationPropertiesResult;
    }

    private Humidifier.AppFlow.FlowTypes.LookoutMetricsDestinationProperties CreateLookoutMetricsDestinationProperties()
    {
        var lookoutMetricsDestinationPropertiesResult = new Humidifier.AppFlow.FlowTypes.LookoutMetricsDestinationProperties();

        return lookoutMetricsDestinationPropertiesResult;
    }

} // End Of Class

public static class InnerFlowLookoutMetricsDestinationPropertiesFactoryExtensions
{
}
