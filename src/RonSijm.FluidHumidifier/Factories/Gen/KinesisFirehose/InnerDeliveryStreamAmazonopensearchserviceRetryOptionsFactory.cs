// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamAmazonopensearchserviceRetryOptionsFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.AmazonopensearchserviceRetryOptions> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.AmazonopensearchserviceRetryOptions>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.AmazonopensearchserviceRetryOptions Create()
    {
        var amazonopensearchserviceRetryOptionsResult = CreateAmazonopensearchserviceRetryOptions();
        factoryAction?.Invoke(amazonopensearchserviceRetryOptionsResult);

        return amazonopensearchserviceRetryOptionsResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.AmazonopensearchserviceRetryOptions CreateAmazonopensearchserviceRetryOptions()
    {
        var amazonopensearchserviceRetryOptionsResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.AmazonopensearchserviceRetryOptions();

        return amazonopensearchserviceRetryOptionsResult;
    }

} // End Of Class

public static class InnerDeliveryStreamAmazonopensearchserviceRetryOptionsFactoryExtensions
{
}
