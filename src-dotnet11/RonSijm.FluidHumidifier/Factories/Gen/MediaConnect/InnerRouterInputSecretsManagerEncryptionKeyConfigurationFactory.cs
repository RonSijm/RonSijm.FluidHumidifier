// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory(Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration>
{

    protected override Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration Create()
    {
        var secretsManagerEncryptionKeyConfigurationResult = CreateSecretsManagerEncryptionKeyConfiguration();
        factoryAction?.Invoke(secretsManagerEncryptionKeyConfigurationResult);

        return secretsManagerEncryptionKeyConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration CreateSecretsManagerEncryptionKeyConfiguration()
    {
        var secretsManagerEncryptionKeyConfigurationResult = new Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration();

        return secretsManagerEncryptionKeyConfigurationResult;
    }

} // End Of Class

public static class InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactoryExtensions
{
}
