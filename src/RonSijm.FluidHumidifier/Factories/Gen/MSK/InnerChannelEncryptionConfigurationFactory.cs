// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerChannelEncryptionConfigurationFactory(Action<Humidifier.MSK.ChannelTypes.EncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ChannelTypes.EncryptionConfiguration>
{

    protected override Humidifier.MSK.ChannelTypes.EncryptionConfiguration Create()
    {
        var encryptionConfigurationResult = CreateEncryptionConfiguration();
        factoryAction?.Invoke(encryptionConfigurationResult);

        return encryptionConfigurationResult;
    }

    private Humidifier.MSK.ChannelTypes.EncryptionConfiguration CreateEncryptionConfiguration()
    {
        var encryptionConfigurationResult = new Humidifier.MSK.ChannelTypes.EncryptionConfiguration();

        return encryptionConfigurationResult;
    }

} // End Of Class

public static class InnerChannelEncryptionConfigurationFactoryExtensions
{
}
