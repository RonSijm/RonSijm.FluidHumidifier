// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class AutomatedReasoningPolicyFactory(string resourceName = null, Action<Humidifier.Bedrock.AutomatedReasoningPolicy> factoryAction = null) : ResourceFactory<Humidifier.Bedrock.AutomatedReasoningPolicy>(resourceName)
{

    internal InnerAutomatedReasoningPolicyPolicyDefinitionFactory PolicyDefinitionFactory { get; set; }

    protected override Humidifier.Bedrock.AutomatedReasoningPolicy Create()
    {
        var automatedReasoningPolicyResult = CreateAutomatedReasoningPolicy();
        factoryAction?.Invoke(automatedReasoningPolicyResult);

        return automatedReasoningPolicyResult;
    }

    private Humidifier.Bedrock.AutomatedReasoningPolicy CreateAutomatedReasoningPolicy()
    {
        var automatedReasoningPolicyResult = new Humidifier.Bedrock.AutomatedReasoningPolicy
        {
            GivenName = InputResourceName,
        };

        return automatedReasoningPolicyResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.AutomatedReasoningPolicy result)
    {
        base.CreateChildren(result);

        result.PolicyDefinition ??= PolicyDefinitionFactory?.Build();
    }

} // End Of Class

public static class AutomatedReasoningPolicyFactoryExtensions
{
    public static CombinedResult<AutomatedReasoningPolicyFactory, InnerAutomatedReasoningPolicyPolicyDefinitionFactory> WithPolicyDefinition(this AutomatedReasoningPolicyFactory parentFactory, Action<Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinition> subFactoryAction = null)
    {
        parentFactory.PolicyDefinitionFactory = new InnerAutomatedReasoningPolicyPolicyDefinitionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PolicyDefinitionFactory);
    }

    public static CombinedResult<AutomatedReasoningPolicyFactory, T1, InnerAutomatedReasoningPolicyPolicyDefinitionFactory> WithPolicyDefinition<T1>(this CombinedResult<AutomatedReasoningPolicyFactory, T1> combinedResult, Action<Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicyDefinition(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AutomatedReasoningPolicyFactory, InnerAutomatedReasoningPolicyPolicyDefinitionFactory> WithPolicyDefinition<T1>(this CombinedResult<T1, AutomatedReasoningPolicyFactory> combinedResult, Action<Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicyDefinition(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AutomatedReasoningPolicyFactory, T1, T2, InnerAutomatedReasoningPolicyPolicyDefinitionFactory> WithPolicyDefinition<T1, T2>(this CombinedResult<AutomatedReasoningPolicyFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicyDefinition(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AutomatedReasoningPolicyFactory, T2, InnerAutomatedReasoningPolicyPolicyDefinitionFactory> WithPolicyDefinition<T1, T2>(this CombinedResult<T1, AutomatedReasoningPolicyFactory, T2> combinedResult, Action<Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicyDefinition(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AutomatedReasoningPolicyFactory, InnerAutomatedReasoningPolicyPolicyDefinitionFactory> WithPolicyDefinition<T1, T2>(this CombinedResult<T1, T2, AutomatedReasoningPolicyFactory> combinedResult, Action<Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicyDefinition(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AutomatedReasoningPolicyFactory, T1, T2, T3, InnerAutomatedReasoningPolicyPolicyDefinitionFactory> WithPolicyDefinition<T1, T2, T3>(this CombinedResult<AutomatedReasoningPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyDefinition(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AutomatedReasoningPolicyFactory, T2, T3, InnerAutomatedReasoningPolicyPolicyDefinitionFactory> WithPolicyDefinition<T1, T2, T3>(this CombinedResult<T1, AutomatedReasoningPolicyFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyDefinition(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AutomatedReasoningPolicyFactory, T3, InnerAutomatedReasoningPolicyPolicyDefinitionFactory> WithPolicyDefinition<T1, T2, T3>(this CombinedResult<T1, T2, AutomatedReasoningPolicyFactory, T3> combinedResult, Action<Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyDefinition(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AutomatedReasoningPolicyFactory, InnerAutomatedReasoningPolicyPolicyDefinitionFactory> WithPolicyDefinition<T1, T2, T3>(this CombinedResult<T1, T2, T3, AutomatedReasoningPolicyFactory> combinedResult, Action<Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyDefinition(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AutomatedReasoningPolicyFactory, T1, T2, T3, T4, InnerAutomatedReasoningPolicyPolicyDefinitionFactory> WithPolicyDefinition<T1, T2, T3, T4>(this CombinedResult<AutomatedReasoningPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyDefinition(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AutomatedReasoningPolicyFactory, T2, T3, T4, InnerAutomatedReasoningPolicyPolicyDefinitionFactory> WithPolicyDefinition<T1, T2, T3, T4>(this CombinedResult<T1, AutomatedReasoningPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyDefinition(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AutomatedReasoningPolicyFactory, T3, T4, InnerAutomatedReasoningPolicyPolicyDefinitionFactory> WithPolicyDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, AutomatedReasoningPolicyFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyDefinition(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AutomatedReasoningPolicyFactory, T4, InnerAutomatedReasoningPolicyPolicyDefinitionFactory> WithPolicyDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AutomatedReasoningPolicyFactory, T4> combinedResult, Action<Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyDefinition(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AutomatedReasoningPolicyFactory, InnerAutomatedReasoningPolicyPolicyDefinitionFactory> WithPolicyDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AutomatedReasoningPolicyFactory> combinedResult, Action<Humidifier.Bedrock.AutomatedReasoningPolicyTypes.PolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyDefinition(combinedResult.T5, subFactoryAction).T2);
}
