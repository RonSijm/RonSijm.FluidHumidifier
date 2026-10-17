// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerPolicyPolicyDefinitionFactory(Action<Humidifier.BedrockAgentCore.PolicyTypes.PolicyDefinition> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.PolicyTypes.PolicyDefinition>
{

    internal InnerPolicyPolicyStatementFactory PolicyFactory { get; set; }

    internal InnerPolicyCedarPolicyFactory CedarFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.PolicyTypes.PolicyDefinition Create()
    {
        var policyDefinitionResult = CreatePolicyDefinition();
        factoryAction?.Invoke(policyDefinitionResult);

        return policyDefinitionResult;
    }

    private Humidifier.BedrockAgentCore.PolicyTypes.PolicyDefinition CreatePolicyDefinition()
    {
        var policyDefinitionResult = new Humidifier.BedrockAgentCore.PolicyTypes.PolicyDefinition();

        return policyDefinitionResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.PolicyTypes.PolicyDefinition result)
    {
        base.CreateChildren(result);

        result.Policy ??= PolicyFactory?.Build();
        result.Cedar ??= CedarFactory?.Build();
    }

} // End Of Class

public static class InnerPolicyPolicyDefinitionFactoryExtensions
{
    public static CombinedResult<InnerPolicyPolicyDefinitionFactory, InnerPolicyPolicyStatementFactory> WithPolicy(this InnerPolicyPolicyDefinitionFactory parentFactory, Action<Humidifier.BedrockAgentCore.PolicyTypes.PolicyStatement> subFactoryAction = null)
    {
        parentFactory.PolicyFactory = new InnerPolicyPolicyStatementFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PolicyFactory);
    }

    public static CombinedResult<InnerPolicyPolicyDefinitionFactory, InnerPolicyCedarPolicyFactory> WithCedar(this InnerPolicyPolicyDefinitionFactory parentFactory, Action<Humidifier.BedrockAgentCore.PolicyTypes.CedarPolicy> subFactoryAction = null)
    {
        parentFactory.CedarFactory = new InnerPolicyCedarPolicyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CedarFactory);
    }

    public static CombinedResult<InnerPolicyPolicyDefinitionFactory, T1, InnerPolicyPolicyStatementFactory> WithPolicy<T1>(this CombinedResult<InnerPolicyPolicyDefinitionFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyTypes.PolicyStatement> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPolicyPolicyDefinitionFactory, InnerPolicyPolicyStatementFactory> WithPolicy<T1>(this CombinedResult<T1, InnerPolicyPolicyDefinitionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyTypes.PolicyStatement> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerPolicyPolicyDefinitionFactory, T1, T2, InnerPolicyPolicyStatementFactory> WithPolicy<T1, T2>(this CombinedResult<InnerPolicyPolicyDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyTypes.PolicyStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPolicyPolicyDefinitionFactory, T2, InnerPolicyPolicyStatementFactory> WithPolicy<T1, T2>(this CombinedResult<T1, InnerPolicyPolicyDefinitionFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyTypes.PolicyStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPolicyPolicyDefinitionFactory, InnerPolicyPolicyStatementFactory> WithPolicy<T1, T2>(this CombinedResult<T1, T2, InnerPolicyPolicyDefinitionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyTypes.PolicyStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerPolicyPolicyDefinitionFactory, T1, T2, T3, InnerPolicyPolicyStatementFactory> WithPolicy<T1, T2, T3>(this CombinedResult<InnerPolicyPolicyDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyTypes.PolicyStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPolicyPolicyDefinitionFactory, T2, T3, InnerPolicyPolicyStatementFactory> WithPolicy<T1, T2, T3>(this CombinedResult<T1, InnerPolicyPolicyDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyTypes.PolicyStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPolicyPolicyDefinitionFactory, T3, InnerPolicyPolicyStatementFactory> WithPolicy<T1, T2, T3>(this CombinedResult<T1, T2, InnerPolicyPolicyDefinitionFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyTypes.PolicyStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPolicyPolicyDefinitionFactory, InnerPolicyPolicyStatementFactory> WithPolicy<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPolicyPolicyDefinitionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyTypes.PolicyStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerPolicyPolicyDefinitionFactory, T1, T2, T3, T4, InnerPolicyPolicyStatementFactory> WithPolicy<T1, T2, T3, T4>(this CombinedResult<InnerPolicyPolicyDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyTypes.PolicyStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPolicyPolicyDefinitionFactory, T2, T3, T4, InnerPolicyPolicyStatementFactory> WithPolicy<T1, T2, T3, T4>(this CombinedResult<T1, InnerPolicyPolicyDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyTypes.PolicyStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPolicyPolicyDefinitionFactory, T3, T4, InnerPolicyPolicyStatementFactory> WithPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPolicyPolicyDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyTypes.PolicyStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPolicyPolicyDefinitionFactory, T4, InnerPolicyPolicyStatementFactory> WithPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPolicyPolicyDefinitionFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyTypes.PolicyStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerPolicyPolicyDefinitionFactory, InnerPolicyPolicyStatementFactory> WithPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPolicyPolicyDefinitionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyTypes.PolicyStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerPolicyPolicyDefinitionFactory, T1, InnerPolicyCedarPolicyFactory> WithCedar<T1>(this CombinedResult<InnerPolicyPolicyDefinitionFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyTypes.CedarPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithCedar(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPolicyPolicyDefinitionFactory, InnerPolicyCedarPolicyFactory> WithCedar<T1>(this CombinedResult<T1, InnerPolicyPolicyDefinitionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyTypes.CedarPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithCedar(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerPolicyPolicyDefinitionFactory, T1, T2, InnerPolicyCedarPolicyFactory> WithCedar<T1, T2>(this CombinedResult<InnerPolicyPolicyDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyTypes.CedarPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCedar(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPolicyPolicyDefinitionFactory, T2, InnerPolicyCedarPolicyFactory> WithCedar<T1, T2>(this CombinedResult<T1, InnerPolicyPolicyDefinitionFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyTypes.CedarPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCedar(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPolicyPolicyDefinitionFactory, InnerPolicyCedarPolicyFactory> WithCedar<T1, T2>(this CombinedResult<T1, T2, InnerPolicyPolicyDefinitionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyTypes.CedarPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCedar(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerPolicyPolicyDefinitionFactory, T1, T2, T3, InnerPolicyCedarPolicyFactory> WithCedar<T1, T2, T3>(this CombinedResult<InnerPolicyPolicyDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyTypes.CedarPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCedar(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPolicyPolicyDefinitionFactory, T2, T3, InnerPolicyCedarPolicyFactory> WithCedar<T1, T2, T3>(this CombinedResult<T1, InnerPolicyPolicyDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyTypes.CedarPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCedar(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPolicyPolicyDefinitionFactory, T3, InnerPolicyCedarPolicyFactory> WithCedar<T1, T2, T3>(this CombinedResult<T1, T2, InnerPolicyPolicyDefinitionFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyTypes.CedarPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCedar(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPolicyPolicyDefinitionFactory, InnerPolicyCedarPolicyFactory> WithCedar<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPolicyPolicyDefinitionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyTypes.CedarPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCedar(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerPolicyPolicyDefinitionFactory, T1, T2, T3, T4, InnerPolicyCedarPolicyFactory> WithCedar<T1, T2, T3, T4>(this CombinedResult<InnerPolicyPolicyDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyTypes.CedarPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCedar(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPolicyPolicyDefinitionFactory, T2, T3, T4, InnerPolicyCedarPolicyFactory> WithCedar<T1, T2, T3, T4>(this CombinedResult<T1, InnerPolicyPolicyDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyTypes.CedarPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCedar(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPolicyPolicyDefinitionFactory, T3, T4, InnerPolicyCedarPolicyFactory> WithCedar<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPolicyPolicyDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyTypes.CedarPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCedar(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPolicyPolicyDefinitionFactory, T4, InnerPolicyCedarPolicyFactory> WithCedar<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPolicyPolicyDefinitionFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyTypes.CedarPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCedar(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerPolicyPolicyDefinitionFactory, InnerPolicyCedarPolicyFactory> WithCedar<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPolicyPolicyDefinitionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyTypes.CedarPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCedar(combinedResult.T5, subFactoryAction).T2);
}
