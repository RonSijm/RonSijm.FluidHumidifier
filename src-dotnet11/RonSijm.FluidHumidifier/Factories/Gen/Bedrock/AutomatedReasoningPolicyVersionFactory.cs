// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class AutomatedReasoningPolicyVersionFactory(string resourceName = null, Action<Humidifier.Bedrock.AutomatedReasoningPolicyVersion> factoryAction = null) : ResourceFactory<Humidifier.Bedrock.AutomatedReasoningPolicyVersion>(resourceName)
{

    protected override Humidifier.Bedrock.AutomatedReasoningPolicyVersion Create()
    {
        var automatedReasoningPolicyVersionResult = CreateAutomatedReasoningPolicyVersion();
        factoryAction?.Invoke(automatedReasoningPolicyVersionResult);

        return automatedReasoningPolicyVersionResult;
    }

    private Humidifier.Bedrock.AutomatedReasoningPolicyVersion CreateAutomatedReasoningPolicyVersion()
    {
        var automatedReasoningPolicyVersionResult = new Humidifier.Bedrock.AutomatedReasoningPolicyVersion
        {
            GivenName = InputResourceName,
        };

        return automatedReasoningPolicyVersionResult;
    }

} // End Of Class

public static class AutomatedReasoningPolicyVersionFactoryExtensions
{
}
