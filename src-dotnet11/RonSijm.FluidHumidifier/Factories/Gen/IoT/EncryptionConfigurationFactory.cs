// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class EncryptionConfigurationFactory(string resourceName = null, Action<Humidifier.IoT.EncryptionConfiguration> factoryAction = null) : ResourceFactory<Humidifier.IoT.EncryptionConfiguration>(resourceName)
{

    protected override Humidifier.IoT.EncryptionConfiguration Create()
    {
        var encryptionConfigurationResult = CreateEncryptionConfiguration();
        factoryAction?.Invoke(encryptionConfigurationResult);

        return encryptionConfigurationResult;
    }

    private Humidifier.IoT.EncryptionConfiguration CreateEncryptionConfiguration()
    {
        var encryptionConfigurationResult = new Humidifier.IoT.EncryptionConfiguration
        {
            GivenName = InputResourceName,
        };

        return encryptionConfigurationResult;
    }

} // End Of Class

public static class EncryptionConfigurationFactoryExtensions
{
}
