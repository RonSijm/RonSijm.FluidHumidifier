// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerSecurityProfileMetricDimensionFactory(Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> factoryAction = null) : SubResourceFactory<Humidifier.IoT.SecurityProfileTypes.MetricDimension>
{

    protected override Humidifier.IoT.SecurityProfileTypes.MetricDimension Create()
    {
        var metricDimensionResult = CreateMetricDimension();
        factoryAction?.Invoke(metricDimensionResult);

        return metricDimensionResult;
    }

    private Humidifier.IoT.SecurityProfileTypes.MetricDimension CreateMetricDimension()
    {
        var metricDimensionResult = new Humidifier.IoT.SecurityProfileTypes.MetricDimension();

        return metricDimensionResult;
    }

} // End Of Class

public static class InnerSecurityProfileMetricDimensionFactoryExtensions
{
}
