// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class CustomMetricFactory(string resourceName = null, Action<Humidifier.IoT.CustomMetric> factoryAction = null) : ResourceFactory<Humidifier.IoT.CustomMetric>(resourceName)
{

    protected override Humidifier.IoT.CustomMetric Create()
    {
        var customMetricResult = CreateCustomMetric();
        factoryAction?.Invoke(customMetricResult);

        return customMetricResult;
    }

    private Humidifier.IoT.CustomMetric CreateCustomMetric()
    {
        var customMetricResult = new Humidifier.IoT.CustomMetric
        {
            GivenName = InputResourceName,
        };

        return customMetricResult;
    }

} // End Of Class

public static class CustomMetricFactoryExtensions
{
}
