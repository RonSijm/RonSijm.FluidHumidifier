// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerStorageLensActivityMetricsFactory(Action<Humidifier.S3.StorageLensTypes.ActivityMetrics> factoryAction = null) : SubResourceFactory<Humidifier.S3.StorageLensTypes.ActivityMetrics>
{

    protected override Humidifier.S3.StorageLensTypes.ActivityMetrics Create()
    {
        var activityMetricsResult = CreateActivityMetrics();
        factoryAction?.Invoke(activityMetricsResult);

        return activityMetricsResult;
    }

    private Humidifier.S3.StorageLensTypes.ActivityMetrics CreateActivityMetrics()
    {
        var activityMetricsResult = new Humidifier.S3.StorageLensTypes.ActivityMetrics();

        return activityMetricsResult;
    }

} // End Of Class

public static class InnerStorageLensActivityMetricsFactoryExtensions
{
}
