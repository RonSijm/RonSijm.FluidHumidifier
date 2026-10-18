// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerGuardrailAutomatedReasoningPolicyConfigFactory(Action<Humidifier.Bedrock.GuardrailTypes.AutomatedReasoningPolicyConfig> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.GuardrailTypes.AutomatedReasoningPolicyConfig>
{

    protected override Humidifier.Bedrock.GuardrailTypes.AutomatedReasoningPolicyConfig Create()
    {
        var automatedReasoningPolicyConfigResult = CreateAutomatedReasoningPolicyConfig();
        factoryAction?.Invoke(automatedReasoningPolicyConfigResult);

        return automatedReasoningPolicyConfigResult;
    }

    private Humidifier.Bedrock.GuardrailTypes.AutomatedReasoningPolicyConfig CreateAutomatedReasoningPolicyConfig()
    {
        var automatedReasoningPolicyConfigResult = new Humidifier.Bedrock.GuardrailTypes.AutomatedReasoningPolicyConfig();

        return automatedReasoningPolicyConfigResult;
    }

} // End Of Class

public static class InnerGuardrailAutomatedReasoningPolicyConfigFactoryExtensions
{
}
