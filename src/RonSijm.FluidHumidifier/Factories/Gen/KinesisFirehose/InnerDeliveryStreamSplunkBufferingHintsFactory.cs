// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamSplunkBufferingHintsFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.SplunkBufferingHints> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.SplunkBufferingHints>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.SplunkBufferingHints Create()
    {
        var splunkBufferingHintsResult = CreateSplunkBufferingHints();
        factoryAction?.Invoke(splunkBufferingHintsResult);

        return splunkBufferingHintsResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.SplunkBufferingHints CreateSplunkBufferingHints()
    {
        var splunkBufferingHintsResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.SplunkBufferingHints();

        return splunkBufferingHintsResult;
    }

} // End Of Class

public static class InnerDeliveryStreamSplunkBufferingHintsFactoryExtensions
{
}
