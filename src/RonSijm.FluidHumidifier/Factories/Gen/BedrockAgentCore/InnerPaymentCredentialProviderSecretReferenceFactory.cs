// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerPaymentCredentialProviderSecretReferenceFactory(Action<Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.SecretReference> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.SecretReference>
{

    protected override Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.SecretReference Create()
    {
        var secretReferenceResult = CreateSecretReference();
        factoryAction?.Invoke(secretReferenceResult);

        return secretReferenceResult;
    }

    private Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.SecretReference CreateSecretReference()
    {
        var secretReferenceResult = new Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.SecretReference();

        return secretReferenceResult;
    }

} // End Of Class

public static class InnerPaymentCredentialProviderSecretReferenceFactoryExtensions
{
}
