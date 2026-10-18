// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class InnerMetricAttributionMetricAttributeFactory(Action<Humidifier.Personalize.MetricAttributionTypes.MetricAttribute> factoryAction = null) : SubResourceFactory<Humidifier.Personalize.MetricAttributionTypes.MetricAttribute>
{

    protected override Humidifier.Personalize.MetricAttributionTypes.MetricAttribute Create()
    {
        var metricAttributeResult = CreateMetricAttribute();
        factoryAction?.Invoke(metricAttributeResult);

        return metricAttributeResult;
    }

    private Humidifier.Personalize.MetricAttributionTypes.MetricAttribute CreateMetricAttribute()
    {
        var metricAttributeResult = new Humidifier.Personalize.MetricAttributionTypes.MetricAttribute();

        return metricAttributeResult;
    }

} // End Of Class

public static class InnerMetricAttributionMetricAttributeFactoryExtensions
{
}
