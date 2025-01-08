// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerAIGuardrailAIGuardrailWordPolicyConfigFactory(Action<Humidifier.Wisdom.AIGuardrailTypes.AIGuardrailWordPolicyConfig> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.AIGuardrailTypes.AIGuardrailWordPolicyConfig>
{

    protected override Humidifier.Wisdom.AIGuardrailTypes.AIGuardrailWordPolicyConfig Create()
    {
        var aIGuardrailWordPolicyConfigResult = CreateAIGuardrailWordPolicyConfig();
        factoryAction?.Invoke(aIGuardrailWordPolicyConfigResult);

        return aIGuardrailWordPolicyConfigResult;
    }

    private Humidifier.Wisdom.AIGuardrailTypes.AIGuardrailWordPolicyConfig CreateAIGuardrailWordPolicyConfig()
    {
        var aIGuardrailWordPolicyConfigResult = new Humidifier.Wisdom.AIGuardrailTypes.AIGuardrailWordPolicyConfig();

        return aIGuardrailWordPolicyConfigResult;
    }

} // End Of Class

public static class InnerAIGuardrailAIGuardrailWordPolicyConfigFactoryExtensions
{
}
