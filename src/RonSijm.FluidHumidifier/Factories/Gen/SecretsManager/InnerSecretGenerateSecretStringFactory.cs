// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecretsManager;

public class InnerSecretGenerateSecretStringFactory(Action<Humidifier.SecretsManager.SecretTypes.GenerateSecretString> factoryAction = null) : SubResourceFactory<Humidifier.SecretsManager.SecretTypes.GenerateSecretString>
{

    protected override Humidifier.SecretsManager.SecretTypes.GenerateSecretString Create()
    {
        var generateSecretStringResult = CreateGenerateSecretString();
        factoryAction?.Invoke(generateSecretStringResult);

        return generateSecretStringResult;
    }

    private Humidifier.SecretsManager.SecretTypes.GenerateSecretString CreateGenerateSecretString()
    {
        var generateSecretStringResult = new Humidifier.SecretsManager.SecretTypes.GenerateSecretString();

        return generateSecretStringResult;
    }

} // End Of Class

public static class InnerSecretGenerateSecretStringFactoryExtensions
{
}
