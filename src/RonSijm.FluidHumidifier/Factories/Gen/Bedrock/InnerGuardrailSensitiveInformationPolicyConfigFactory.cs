// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerGuardrailSensitiveInformationPolicyConfigFactory(Action<Humidifier.Bedrock.GuardrailTypes.SensitiveInformationPolicyConfig> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.GuardrailTypes.SensitiveInformationPolicyConfig>
{

    protected override Humidifier.Bedrock.GuardrailTypes.SensitiveInformationPolicyConfig Create()
    {
        var sensitiveInformationPolicyConfigResult = CreateSensitiveInformationPolicyConfig();
        factoryAction?.Invoke(sensitiveInformationPolicyConfigResult);

        return sensitiveInformationPolicyConfigResult;
    }

    private Humidifier.Bedrock.GuardrailTypes.SensitiveInformationPolicyConfig CreateSensitiveInformationPolicyConfig()
    {
        var sensitiveInformationPolicyConfigResult = new Humidifier.Bedrock.GuardrailTypes.SensitiveInformationPolicyConfig();

        return sensitiveInformationPolicyConfigResult;
    }

} // End Of Class

public static class InnerGuardrailSensitiveInformationPolicyConfigFactoryExtensions
{
}
