// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerAutomatedReasoningPolicyPolicyDefinitionFactory(Action<Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinition> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinition>
{

    protected override Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinition Create()
    {
        var policyDefinitionResult = CreatePolicyDefinition();
        factoryAction?.Invoke(policyDefinitionResult);

        return policyDefinitionResult;
    }

    private Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinition CreatePolicyDefinition()
    {
        var policyDefinitionResult = new Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinition();

        return policyDefinitionResult;
    }

} // End Of Class

public static class InnerAutomatedReasoningPolicyPolicyDefinitionFactoryExtensions
{
}
