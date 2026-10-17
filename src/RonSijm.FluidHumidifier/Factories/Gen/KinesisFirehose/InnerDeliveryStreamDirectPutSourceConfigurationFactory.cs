// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamDirectPutSourceConfigurationFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.DirectPutSourceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.DirectPutSourceConfiguration>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.DirectPutSourceConfiguration Create()
    {
        var directPutSourceConfigurationResult = CreateDirectPutSourceConfiguration();
        factoryAction?.Invoke(directPutSourceConfigurationResult);

        return directPutSourceConfigurationResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.DirectPutSourceConfiguration CreateDirectPutSourceConfiguration()
    {
        var directPutSourceConfigurationResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.DirectPutSourceConfiguration();

        return directPutSourceConfigurationResult;
    }

} // End Of Class

public static class InnerDeliveryStreamDirectPutSourceConfigurationFactoryExtensions
{
}
