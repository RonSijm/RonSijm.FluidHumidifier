// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerAIGuardrailAIGuardrailSensitiveInformationPolicyConfigFactory(Action<Humidifier.Wisdom.AIGuardrailTypes.AIGuardrailSensitiveInformationPolicyConfig> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.AIGuardrailTypes.AIGuardrailSensitiveInformationPolicyConfig>
{

    protected override Humidifier.Wisdom.AIGuardrailTypes.AIGuardrailSensitiveInformationPolicyConfig Create()
    {
        var aIGuardrailSensitiveInformationPolicyConfigResult = CreateAIGuardrailSensitiveInformationPolicyConfig();
        factoryAction?.Invoke(aIGuardrailSensitiveInformationPolicyConfigResult);

        return aIGuardrailSensitiveInformationPolicyConfigResult;
    }

    private Humidifier.Wisdom.AIGuardrailTypes.AIGuardrailSensitiveInformationPolicyConfig CreateAIGuardrailSensitiveInformationPolicyConfig()
    {
        var aIGuardrailSensitiveInformationPolicyConfigResult = new Humidifier.Wisdom.AIGuardrailTypes.AIGuardrailSensitiveInformationPolicyConfig();

        return aIGuardrailSensitiveInformationPolicyConfigResult;
    }

} // End Of Class

public static class InnerAIGuardrailAIGuardrailSensitiveInformationPolicyConfigFactoryExtensions
{
}
