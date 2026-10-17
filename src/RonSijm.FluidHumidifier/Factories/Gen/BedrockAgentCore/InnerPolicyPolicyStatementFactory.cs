// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerPolicyPolicyStatementFactory(Action<Humidifier.BedrockAgentCore.PolicyTypes.PolicyStatement> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.PolicyTypes.PolicyStatement>
{

    protected override Humidifier.BedrockAgentCore.PolicyTypes.PolicyStatement Create()
    {
        var policyStatementResult = CreatePolicyStatement();
        factoryAction?.Invoke(policyStatementResult);

        return policyStatementResult;
    }

    private Humidifier.BedrockAgentCore.PolicyTypes.PolicyStatement CreatePolicyStatement()
    {
        var policyStatementResult = new Humidifier.BedrockAgentCore.PolicyTypes.PolicyStatement();

        return policyStatementResult;
    }

} // End Of Class

public static class InnerPolicyPolicyStatementFactoryExtensions
{
}
