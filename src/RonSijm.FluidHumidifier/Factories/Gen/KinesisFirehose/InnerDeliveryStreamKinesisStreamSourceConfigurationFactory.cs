// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamKinesisStreamSourceConfigurationFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.KinesisStreamSourceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.KinesisStreamSourceConfiguration>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.KinesisStreamSourceConfiguration Create()
    {
        var kinesisStreamSourceConfigurationResult = CreateKinesisStreamSourceConfiguration();
        factoryAction?.Invoke(kinesisStreamSourceConfigurationResult);

        return kinesisStreamSourceConfigurationResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.KinesisStreamSourceConfiguration CreateKinesisStreamSourceConfiguration()
    {
        var kinesisStreamSourceConfigurationResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.KinesisStreamSourceConfiguration();

        return kinesisStreamSourceConfigurationResult;
    }

} // End Of Class

public static class InnerDeliveryStreamKinesisStreamSourceConfigurationFactoryExtensions
{
}
