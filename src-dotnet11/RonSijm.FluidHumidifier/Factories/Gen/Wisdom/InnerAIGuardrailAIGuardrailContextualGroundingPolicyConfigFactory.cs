// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerAIGuardrailAIGuardrailContextualGroundingPolicyConfigFactory(Action<Humidifier.Wisdom.AIGuardrailTypes.AIGuardrailContextualGroundingPolicyConfig> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.AIGuardrailTypes.AIGuardrailContextualGroundingPolicyConfig>
{

    protected override Humidifier.Wisdom.AIGuardrailTypes.AIGuardrailContextualGroundingPolicyConfig Create()
    {
        var aIGuardrailContextualGroundingPolicyConfigResult = CreateAIGuardrailContextualGroundingPolicyConfig();
        factoryAction?.Invoke(aIGuardrailContextualGroundingPolicyConfigResult);

        return aIGuardrailContextualGroundingPolicyConfigResult;
    }

    private Humidifier.Wisdom.AIGuardrailTypes.AIGuardrailContextualGroundingPolicyConfig CreateAIGuardrailContextualGroundingPolicyConfig()
    {
        var aIGuardrailContextualGroundingPolicyConfigResult = new Humidifier.Wisdom.AIGuardrailTypes.AIGuardrailContextualGroundingPolicyConfig();

        return aIGuardrailContextualGroundingPolicyConfigResult;
    }

} // End Of Class

public static class InnerAIGuardrailAIGuardrailContextualGroundingPolicyConfigFactoryExtensions
{
}
