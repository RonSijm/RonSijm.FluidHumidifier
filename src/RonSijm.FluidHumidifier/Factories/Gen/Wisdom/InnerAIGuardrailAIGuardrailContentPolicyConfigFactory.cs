// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerAIGuardrailAIGuardrailContentPolicyConfigFactory(Action<Humidifier.Wisdom.AIGuardrailTypes.AIGuardrailContentPolicyConfig> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.AIGuardrailTypes.AIGuardrailContentPolicyConfig>
{

    protected override Humidifier.Wisdom.AIGuardrailTypes.AIGuardrailContentPolicyConfig Create()
    {
        var aIGuardrailContentPolicyConfigResult = CreateAIGuardrailContentPolicyConfig();
        factoryAction?.Invoke(aIGuardrailContentPolicyConfigResult);

        return aIGuardrailContentPolicyConfigResult;
    }

    private Humidifier.Wisdom.AIGuardrailTypes.AIGuardrailContentPolicyConfig CreateAIGuardrailContentPolicyConfig()
    {
        var aIGuardrailContentPolicyConfigResult = new Humidifier.Wisdom.AIGuardrailTypes.AIGuardrailContentPolicyConfig();

        return aIGuardrailContentPolicyConfigResult;
    }

} // End Of Class

public static class InnerAIGuardrailAIGuardrailContentPolicyConfigFactoryExtensions
{
}
