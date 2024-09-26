// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamKMSEncryptionConfigFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.KMSEncryptionConfig> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.KMSEncryptionConfig>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.KMSEncryptionConfig Create()
    {
        var kMSEncryptionConfigResult = CreateKMSEncryptionConfig();
        factoryAction?.Invoke(kMSEncryptionConfigResult);

        return kMSEncryptionConfigResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.KMSEncryptionConfig CreateKMSEncryptionConfig()
    {
        var kMSEncryptionConfigResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.KMSEncryptionConfig();

        return kMSEncryptionConfigResult;
    }

} // End Of Class

public static class InnerDeliveryStreamKMSEncryptionConfigFactoryExtensions
{
}
