// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory(Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration>
{

    protected override Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration Create()
    {
        var secretsManagerEncryptionKeyConfigurationResult = CreateSecretsManagerEncryptionKeyConfiguration();
        factoryAction?.Invoke(secretsManagerEncryptionKeyConfigurationResult);

        return secretsManagerEncryptionKeyConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration CreateSecretsManagerEncryptionKeyConfiguration()
    {
        var secretsManagerEncryptionKeyConfigurationResult = new Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration();

        return secretsManagerEncryptionKeyConfigurationResult;
    }

} // End Of Class

public static class InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactoryExtensions
{
}
