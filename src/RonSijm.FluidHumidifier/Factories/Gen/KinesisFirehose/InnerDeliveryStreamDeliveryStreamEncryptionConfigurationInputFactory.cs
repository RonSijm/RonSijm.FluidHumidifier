// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamDeliveryStreamEncryptionConfigurationInputFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.DeliveryStreamEncryptionConfigurationInput> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.DeliveryStreamEncryptionConfigurationInput>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.DeliveryStreamEncryptionConfigurationInput Create()
    {
        var deliveryStreamEncryptionConfigurationInputResult = CreateDeliveryStreamEncryptionConfigurationInput();
        factoryAction?.Invoke(deliveryStreamEncryptionConfigurationInputResult);

        return deliveryStreamEncryptionConfigurationInputResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.DeliveryStreamEncryptionConfigurationInput CreateDeliveryStreamEncryptionConfigurationInput()
    {
        var deliveryStreamEncryptionConfigurationInputResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.DeliveryStreamEncryptionConfigurationInput();

        return deliveryStreamEncryptionConfigurationInputResult;
    }

} // End Of Class

public static class InnerDeliveryStreamDeliveryStreamEncryptionConfigurationInputFactoryExtensions
{
}
