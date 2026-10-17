// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerPolicyCedarPolicyFactory(Action<Humidifier.BedrockAgentCore.PolicyTypes.CedarPolicy> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.PolicyTypes.CedarPolicy>
{

    protected override Humidifier.BedrockAgentCore.PolicyTypes.CedarPolicy Create()
    {
        var cedarPolicyResult = CreateCedarPolicy();
        factoryAction?.Invoke(cedarPolicyResult);

        return cedarPolicyResult;
    }

    private Humidifier.BedrockAgentCore.PolicyTypes.CedarPolicy CreateCedarPolicy()
    {
        var cedarPolicyResult = new Humidifier.BedrockAgentCore.PolicyTypes.CedarPolicy();

        return cedarPolicyResult;
    }

} // End Of Class

public static class InnerPolicyCedarPolicyFactoryExtensions
{
}
