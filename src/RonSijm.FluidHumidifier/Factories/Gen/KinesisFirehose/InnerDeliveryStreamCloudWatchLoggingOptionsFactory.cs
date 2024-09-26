// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamCloudWatchLoggingOptionsFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.CloudWatchLoggingOptions> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.CloudWatchLoggingOptions>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.CloudWatchLoggingOptions Create()
    {
        var cloudWatchLoggingOptionsResult = CreateCloudWatchLoggingOptions();
        factoryAction?.Invoke(cloudWatchLoggingOptionsResult);

        return cloudWatchLoggingOptionsResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.CloudWatchLoggingOptions CreateCloudWatchLoggingOptions()
    {
        var cloudWatchLoggingOptionsResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.CloudWatchLoggingOptions();

        return cloudWatchLoggingOptionsResult;
    }

} // End Of Class

public static class InnerDeliveryStreamCloudWatchLoggingOptionsFactoryExtensions
{
}
