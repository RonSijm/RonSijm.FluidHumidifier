// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowSecretsManagerEncryptionKeyConfigurationFactory(Action<Humidifier.MediaConnect.FlowTypes.SecretsManagerEncryptionKeyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowTypes.SecretsManagerEncryptionKeyConfiguration>
{

    protected override Humidifier.MediaConnect.FlowTypes.SecretsManagerEncryptionKeyConfiguration Create()
    {
        var secretsManagerEncryptionKeyConfigurationResult = CreateSecretsManagerEncryptionKeyConfiguration();
        factoryAction?.Invoke(secretsManagerEncryptionKeyConfigurationResult);

        return secretsManagerEncryptionKeyConfigurationResult;
    }

    private Humidifier.MediaConnect.FlowTypes.SecretsManagerEncryptionKeyConfiguration CreateSecretsManagerEncryptionKeyConfiguration()
    {
        var secretsManagerEncryptionKeyConfigurationResult = new Humidifier.MediaConnect.FlowTypes.SecretsManagerEncryptionKeyConfiguration();

        return secretsManagerEncryptionKeyConfigurationResult;
    }

} // End Of Class

public static class InnerFlowSecretsManagerEncryptionKeyConfigurationFactoryExtensions
{
}
