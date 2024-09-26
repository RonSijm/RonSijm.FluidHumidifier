// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamSplunkRetryOptionsFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.SplunkRetryOptions> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.SplunkRetryOptions>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.SplunkRetryOptions Create()
    {
        var splunkRetryOptionsResult = CreateSplunkRetryOptions();
        factoryAction?.Invoke(splunkRetryOptionsResult);

        return splunkRetryOptionsResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.SplunkRetryOptions CreateSplunkRetryOptions()
    {
        var splunkRetryOptionsResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.SplunkRetryOptions();

        return splunkRetryOptionsResult;
    }

} // End Of Class

public static class InnerDeliveryStreamSplunkRetryOptionsFactoryExtensions
{
}
