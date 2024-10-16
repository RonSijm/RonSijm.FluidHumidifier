// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamRetryOptionsFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.RetryOptions> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.RetryOptions>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.RetryOptions Create()
    {
        var retryOptionsResult = CreateRetryOptions();
        factoryAction?.Invoke(retryOptionsResult);

        return retryOptionsResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.RetryOptions CreateRetryOptions()
    {
        var retryOptionsResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.RetryOptions();

        return retryOptionsResult;
    }

} // End Of Class

public static class InnerDeliveryStreamRetryOptionsFactoryExtensions
{
}
