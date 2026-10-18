// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppRunner;

public class InnerServiceEncryptionConfigurationFactory(Action<Humidifier.AppRunner.ServiceTypes.EncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AppRunner.ServiceTypes.EncryptionConfiguration>
{

    protected override Humidifier.AppRunner.ServiceTypes.EncryptionConfiguration Create()
    {
        var encryptionConfigurationResult = CreateEncryptionConfiguration();
        factoryAction?.Invoke(encryptionConfigurationResult);

        return encryptionConfigurationResult;
    }

    private Humidifier.AppRunner.ServiceTypes.EncryptionConfiguration CreateEncryptionConfiguration()
    {
        var encryptionConfigurationResult = new Humidifier.AppRunner.ServiceTypes.EncryptionConfiguration();

        return encryptionConfigurationResult;
    }

} // End Of Class

public static class InnerServiceEncryptionConfigurationFactoryExtensions
{
}
