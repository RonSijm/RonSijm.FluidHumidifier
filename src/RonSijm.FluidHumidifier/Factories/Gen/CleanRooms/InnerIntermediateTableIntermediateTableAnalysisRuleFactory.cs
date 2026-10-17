// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerIntermediateTableIntermediateTableAnalysisRuleFactory(Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRule> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRule>
{

    internal InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory PolicyFactory { get; set; }

    protected override Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRule Create()
    {
        var intermediateTableAnalysisRuleResult = CreateIntermediateTableAnalysisRule();
        factoryAction?.Invoke(intermediateTableAnalysisRuleResult);

        return intermediateTableAnalysisRuleResult;
    }

    private Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRule CreateIntermediateTableAnalysisRule()
    {
        var intermediateTableAnalysisRuleResult = new Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRule();

        return intermediateTableAnalysisRuleResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRule result)
    {
        base.CreateChildren(result);

        result.Policy ??= PolicyFactory?.Build();
    }

} // End Of Class

public static class InnerIntermediateTableIntermediateTableAnalysisRuleFactoryExtensions
{
    public static CombinedResult<InnerIntermediateTableIntermediateTableAnalysisRuleFactory, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory> WithPolicy(this InnerIntermediateTableIntermediateTableAnalysisRuleFactory parentFactory, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicy> subFactoryAction = null)
    {
        parentFactory.PolicyFactory = new InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PolicyFactory);
    }

    public static CombinedResult<InnerIntermediateTableIntermediateTableAnalysisRuleFactory, T1, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory> WithPolicy<T1>(this CombinedResult<InnerIntermediateTableIntermediateTableAnalysisRuleFactory, T1> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIntermediateTableIntermediateTableAnalysisRuleFactory, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory> WithPolicy<T1>(this CombinedResult<T1, InnerIntermediateTableIntermediateTableAnalysisRuleFactory> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerIntermediateTableIntermediateTableAnalysisRuleFactory, T1, T2, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory> WithPolicy<T1, T2>(this CombinedResult<InnerIntermediateTableIntermediateTableAnalysisRuleFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIntermediateTableIntermediateTableAnalysisRuleFactory, T2, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory> WithPolicy<T1, T2>(this CombinedResult<T1, InnerIntermediateTableIntermediateTableAnalysisRuleFactory, T2> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIntermediateTableIntermediateTableAnalysisRuleFactory, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory> WithPolicy<T1, T2>(this CombinedResult<T1, T2, InnerIntermediateTableIntermediateTableAnalysisRuleFactory> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerIntermediateTableIntermediateTableAnalysisRuleFactory, T1, T2, T3, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory> WithPolicy<T1, T2, T3>(this CombinedResult<InnerIntermediateTableIntermediateTableAnalysisRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIntermediateTableIntermediateTableAnalysisRuleFactory, T2, T3, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory> WithPolicy<T1, T2, T3>(this CombinedResult<T1, InnerIntermediateTableIntermediateTableAnalysisRuleFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIntermediateTableIntermediateTableAnalysisRuleFactory, T3, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory> WithPolicy<T1, T2, T3>(this CombinedResult<T1, T2, InnerIntermediateTableIntermediateTableAnalysisRuleFactory, T3> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerIntermediateTableIntermediateTableAnalysisRuleFactory, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory> WithPolicy<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerIntermediateTableIntermediateTableAnalysisRuleFactory> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerIntermediateTableIntermediateTableAnalysisRuleFactory, T1, T2, T3, T4, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory> WithPolicy<T1, T2, T3, T4>(this CombinedResult<InnerIntermediateTableIntermediateTableAnalysisRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIntermediateTableIntermediateTableAnalysisRuleFactory, T2, T3, T4, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory> WithPolicy<T1, T2, T3, T4>(this CombinedResult<T1, InnerIntermediateTableIntermediateTableAnalysisRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIntermediateTableIntermediateTableAnalysisRuleFactory, T3, T4, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory> WithPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerIntermediateTableIntermediateTableAnalysisRuleFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerIntermediateTableIntermediateTableAnalysisRuleFactory, T4, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory> WithPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerIntermediateTableIntermediateTableAnalysisRuleFactory, T4> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerIntermediateTableIntermediateTableAnalysisRuleFactory, InnerIntermediateTableIntermediateTableAnalysisRulePolicyFactory> WithPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerIntermediateTableIntermediateTableAnalysisRuleFactory> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T5, subFactoryAction).T2);
}
