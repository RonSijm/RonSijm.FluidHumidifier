// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class PolicyEngineFactory(string resourceName = null, Action<Humidifier.BedrockAgentCore.PolicyEngine> factoryAction = null) : ResourceFactory<Humidifier.BedrockAgentCore.PolicyEngine>(resourceName)
{

    protected override Humidifier.BedrockAgentCore.PolicyEngine Create()
    {
        var policyEngineResult = CreatePolicyEngine();
        factoryAction?.Invoke(policyEngineResult);

        return policyEngineResult;
    }

    private Humidifier.BedrockAgentCore.PolicyEngine CreatePolicyEngine()
    {
        var policyEngineResult = new Humidifier.BedrockAgentCore.PolicyEngine
        {
            GivenName = InputResourceName,
        };

        return policyEngineResult;
    }

} // End Of Class

public static class PolicyEngineFactoryExtensions
{
}
