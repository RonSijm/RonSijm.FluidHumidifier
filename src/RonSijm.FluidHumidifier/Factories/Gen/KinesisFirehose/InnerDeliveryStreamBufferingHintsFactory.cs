// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamBufferingHintsFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.BufferingHints> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.BufferingHints>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.BufferingHints Create()
    {
        var bufferingHintsResult = CreateBufferingHints();
        factoryAction?.Invoke(bufferingHintsResult);

        return bufferingHintsResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.BufferingHints CreateBufferingHints()
    {
        var bufferingHintsResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.BufferingHints();

        return bufferingHintsResult;
    }

} // End Of Class

public static class InnerDeliveryStreamBufferingHintsFactoryExtensions
{
}
