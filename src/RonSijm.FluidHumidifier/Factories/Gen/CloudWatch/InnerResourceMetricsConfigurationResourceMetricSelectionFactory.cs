// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerResourceMetricsConfigurationResourceMetricSelectionFactory(Action<Humidifier.CloudWatch.ResourceMetricsConfigurationTypes.ResourceMetricSelection> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.ResourceMetricsConfigurationTypes.ResourceMetricSelection>
{

    protected override Humidifier.CloudWatch.ResourceMetricsConfigurationTypes.ResourceMetricSelection Create()
    {
        var resourceMetricSelectionResult = CreateResourceMetricSelection();
        factoryAction?.Invoke(resourceMetricSelectionResult);

        return resourceMetricSelectionResult;
    }

    private Humidifier.CloudWatch.ResourceMetricsConfigurationTypes.ResourceMetricSelection CreateResourceMetricSelection()
    {
        var resourceMetricSelectionResult = new Humidifier.CloudWatch.ResourceMetricsConfigurationTypes.ResourceMetricSelection();

        return resourceMetricSelectionResult;
    }

} // End Of Class

public static class InnerResourceMetricsConfigurationResourceMetricSelectionFactoryExtensions
{
}
