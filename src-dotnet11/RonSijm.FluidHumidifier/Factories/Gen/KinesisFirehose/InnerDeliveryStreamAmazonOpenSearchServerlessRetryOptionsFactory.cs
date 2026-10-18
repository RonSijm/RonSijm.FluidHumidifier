// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamAmazonOpenSearchServerlessRetryOptionsFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.AmazonOpenSearchServerlessRetryOptions> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.AmazonOpenSearchServerlessRetryOptions>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.AmazonOpenSearchServerlessRetryOptions Create()
    {
        var amazonOpenSearchServerlessRetryOptionsResult = CreateAmazonOpenSearchServerlessRetryOptions();
        factoryAction?.Invoke(amazonOpenSearchServerlessRetryOptionsResult);

        return amazonOpenSearchServerlessRetryOptionsResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.AmazonOpenSearchServerlessRetryOptions CreateAmazonOpenSearchServerlessRetryOptions()
    {
        var amazonOpenSearchServerlessRetryOptionsResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.AmazonOpenSearchServerlessRetryOptions();

        return amazonOpenSearchServerlessRetryOptionsResult;
    }

} // End Of Class

public static class InnerDeliveryStreamAmazonOpenSearchServerlessRetryOptionsFactoryExtensions
{
}
