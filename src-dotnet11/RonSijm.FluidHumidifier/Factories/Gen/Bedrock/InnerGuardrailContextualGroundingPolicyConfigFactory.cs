// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerGuardrailContextualGroundingPolicyConfigFactory(Action<Humidifier.Bedrock.GuardrailTypes.ContextualGroundingPolicyConfig> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.GuardrailTypes.ContextualGroundingPolicyConfig>
{

    protected override Humidifier.Bedrock.GuardrailTypes.ContextualGroundingPolicyConfig Create()
    {
        var contextualGroundingPolicyConfigResult = CreateContextualGroundingPolicyConfig();
        factoryAction?.Invoke(contextualGroundingPolicyConfigResult);

        return contextualGroundingPolicyConfigResult;
    }

    private Humidifier.Bedrock.GuardrailTypes.ContextualGroundingPolicyConfig CreateContextualGroundingPolicyConfig()
    {
        var contextualGroundingPolicyConfigResult = new Humidifier.Bedrock.GuardrailTypes.ContextualGroundingPolicyConfig();

        return contextualGroundingPolicyConfigResult;
    }

} // End Of Class

public static class InnerGuardrailContextualGroundingPolicyConfigFactoryExtensions
{
}
