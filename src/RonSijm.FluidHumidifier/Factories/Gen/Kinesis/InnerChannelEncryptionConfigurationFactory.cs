// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kinesis;

public class InnerChannelEncryptionConfigurationFactory(Action<Humidifier.Kinesis.ChannelTypes.EncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kinesis.ChannelTypes.EncryptionConfiguration>
{

    protected override Humidifier.Kinesis.ChannelTypes.EncryptionConfiguration Create()
    {
        var encryptionConfigurationResult = CreateEncryptionConfiguration();
        factoryAction?.Invoke(encryptionConfigurationResult);

        return encryptionConfigurationResult;
    }

    private Humidifier.Kinesis.ChannelTypes.EncryptionConfiguration CreateEncryptionConfiguration()
    {
        var encryptionConfigurationResult = new Humidifier.Kinesis.ChannelTypes.EncryptionConfiguration();

        return encryptionConfigurationResult;
    }

} // End Of Class

public static class InnerChannelEncryptionConfigurationFactoryExtensions
{
}
