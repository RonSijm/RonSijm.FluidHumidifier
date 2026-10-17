// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerAIGuardrailAIGuardrailTopicPolicyConfigFactory(Action<Humidifier.Wisdom.AIGuardrailTypes.AIGuardrailTopicPolicyConfig> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.AIGuardrailTypes.AIGuardrailTopicPolicyConfig>
{

    protected override Humidifier.Wisdom.AIGuardrailTypes.AIGuardrailTopicPolicyConfig Create()
    {
        var aIGuardrailTopicPolicyConfigResult = CreateAIGuardrailTopicPolicyConfig();
        factoryAction?.Invoke(aIGuardrailTopicPolicyConfigResult);

        return aIGuardrailTopicPolicyConfigResult;
    }

    private Humidifier.Wisdom.AIGuardrailTypes.AIGuardrailTopicPolicyConfig CreateAIGuardrailTopicPolicyConfig()
    {
        var aIGuardrailTopicPolicyConfigResult = new Humidifier.Wisdom.AIGuardrailTypes.AIGuardrailTopicPolicyConfig();

        return aIGuardrailTopicPolicyConfigResult;
    }

} // End Of Class

public static class InnerAIGuardrailAIGuardrailTopicPolicyConfigFactoryExtensions
{
}
