// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowOutputSecretsManagerEncryptionKeyConfigurationFactory(Action<Humidifier.MediaConnect.FlowOutputTypes.SecretsManagerEncryptionKeyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowOutputTypes.SecretsManagerEncryptionKeyConfiguration>
{

    protected override Humidifier.MediaConnect.FlowOutputTypes.SecretsManagerEncryptionKeyConfiguration Create()
    {
        var secretsManagerEncryptionKeyConfigurationResult = CreateSecretsManagerEncryptionKeyConfiguration();
        factoryAction?.Invoke(secretsManagerEncryptionKeyConfigurationResult);

        return secretsManagerEncryptionKeyConfigurationResult;
    }

    private Humidifier.MediaConnect.FlowOutputTypes.SecretsManagerEncryptionKeyConfiguration CreateSecretsManagerEncryptionKeyConfiguration()
    {
        var secretsManagerEncryptionKeyConfigurationResult = new Humidifier.MediaConnect.FlowOutputTypes.SecretsManagerEncryptionKeyConfiguration();

        return secretsManagerEncryptionKeyConfigurationResult;
    }

} // End Of Class

public static class InnerFlowOutputSecretsManagerEncryptionKeyConfigurationFactoryExtensions
{
}
