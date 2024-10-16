// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalyticsV2;

public class InnerApplicationCloudWatchLoggingOptionCloudWatchLoggingOptionFactory(Action<Humidifier.KinesisAnalyticsV2.ApplicationCloudWatchLoggingOptionTypes.CloudWatchLoggingOption> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalyticsV2.ApplicationCloudWatchLoggingOptionTypes.CloudWatchLoggingOption>
{

    protected override Humidifier.KinesisAnalyticsV2.ApplicationCloudWatchLoggingOptionTypes.CloudWatchLoggingOption Create()
    {
        var cloudWatchLoggingOptionResult = CreateCloudWatchLoggingOption();
        factoryAction?.Invoke(cloudWatchLoggingOptionResult);

        return cloudWatchLoggingOptionResult;
    }

    private Humidifier.KinesisAnalyticsV2.ApplicationCloudWatchLoggingOptionTypes.CloudWatchLoggingOption CreateCloudWatchLoggingOption()
    {
        var cloudWatchLoggingOptionResult = new Humidifier.KinesisAnalyticsV2.ApplicationCloudWatchLoggingOptionTypes.CloudWatchLoggingOption();

        return cloudWatchLoggingOptionResult;
    }

} // End Of Class

public static class InnerApplicationCloudWatchLoggingOptionCloudWatchLoggingOptionFactoryExtensions
{
}
