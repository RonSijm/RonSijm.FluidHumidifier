// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerMetricMetricCalculationFactory(Action<Humidifier.Connect.MetricTypes.MetricCalculation> factoryAction = null) : SubResourceFactory<Humidifier.Connect.MetricTypes.MetricCalculation>
{

    protected override Humidifier.Connect.MetricTypes.MetricCalculation Create()
    {
        var metricCalculationResult = CreateMetricCalculation();
        factoryAction?.Invoke(metricCalculationResult);

        return metricCalculationResult;
    }

    private Humidifier.Connect.MetricTypes.MetricCalculation CreateMetricCalculation()
    {
        var metricCalculationResult = new Humidifier.Connect.MetricTypes.MetricCalculation();

        return metricCalculationResult;
    }

} // End Of Class

public static class InnerMetricMetricCalculationFactoryExtensions
{
}
