// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamAmazonOpenSearchServerlessBufferingHintsFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.AmazonOpenSearchServerlessBufferingHints> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.AmazonOpenSearchServerlessBufferingHints>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.AmazonOpenSearchServerlessBufferingHints Create()
    {
        var amazonOpenSearchServerlessBufferingHintsResult = CreateAmazonOpenSearchServerlessBufferingHints();
        factoryAction?.Invoke(amazonOpenSearchServerlessBufferingHintsResult);

        return amazonOpenSearchServerlessBufferingHintsResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.AmazonOpenSearchServerlessBufferingHints CreateAmazonOpenSearchServerlessBufferingHints()
    {
        var amazonOpenSearchServerlessBufferingHintsResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.AmazonOpenSearchServerlessBufferingHints();

        return amazonOpenSearchServerlessBufferingHintsResult;
    }

} // End Of Class

public static class InnerDeliveryStreamAmazonOpenSearchServerlessBufferingHintsFactoryExtensions
{
}
