// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerSecurityProfileMetricValueFactory(Action<Humidifier.IoT.SecurityProfileTypes.MetricValue> factoryAction = null) : SubResourceFactory<Humidifier.IoT.SecurityProfileTypes.MetricValue>
{

    protected override Humidifier.IoT.SecurityProfileTypes.MetricValue Create()
    {
        var metricValueResult = CreateMetricValue();
        factoryAction?.Invoke(metricValueResult);

        return metricValueResult;
    }

    private Humidifier.IoT.SecurityProfileTypes.MetricValue CreateMetricValue()
    {
        var metricValueResult = new Humidifier.IoT.SecurityProfileTypes.MetricValue();

        return metricValueResult;
    }

} // End Of Class

public static class InnerSecurityProfileMetricValueFactoryExtensions
{
}
