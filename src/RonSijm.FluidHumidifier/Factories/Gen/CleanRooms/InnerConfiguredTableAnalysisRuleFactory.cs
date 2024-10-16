// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerConfiguredTableAnalysisRuleFactory(Action<Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRule> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRule>
{

    internal InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory PolicyFactory { get; set; }

    protected override Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRule Create()
    {
        var analysisRuleResult = CreateAnalysisRule();
        factoryAction?.Invoke(analysisRuleResult);

        return analysisRuleResult;
    }

    private Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRule CreateAnalysisRule()
    {
        var analysisRuleResult = new Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRule();

        return analysisRuleResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRule result)
    {
        base.CreateChildren(result);

        result.Policy ??= PolicyFactory?.Build();
    }

} // End Of Class

public static class InnerConfiguredTableAnalysisRuleFactoryExtensions
{
    public static CombinedResult<InnerConfiguredTableAnalysisRuleFactory, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory> WithPolicy(this InnerConfiguredTableAnalysisRuleFactory parentFactory, Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicy> subFactoryAction = null)
    {
        parentFactory.PolicyFactory = new InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PolicyFactory);
    }

    public static CombinedResult<InnerConfiguredTableAnalysisRuleFactory, T1, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory> WithPolicy<T1>(this CombinedResult<InnerConfiguredTableAnalysisRuleFactory, T1> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfiguredTableAnalysisRuleFactory, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory> WithPolicy<T1>(this CombinedResult<T1, InnerConfiguredTableAnalysisRuleFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConfiguredTableAnalysisRuleFactory, T1, T2, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory> WithPolicy<T1, T2>(this CombinedResult<InnerConfiguredTableAnalysisRuleFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfiguredTableAnalysisRuleFactory, T2, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory> WithPolicy<T1, T2>(this CombinedResult<T1, InnerConfiguredTableAnalysisRuleFactory, T2> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfiguredTableAnalysisRuleFactory, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory> WithPolicy<T1, T2>(this CombinedResult<T1, T2, InnerConfiguredTableAnalysisRuleFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConfiguredTableAnalysisRuleFactory, T1, T2, T3, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory> WithPolicy<T1, T2, T3>(this CombinedResult<InnerConfiguredTableAnalysisRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfiguredTableAnalysisRuleFactory, T2, T3, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory> WithPolicy<T1, T2, T3>(this CombinedResult<T1, InnerConfiguredTableAnalysisRuleFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfiguredTableAnalysisRuleFactory, T3, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory> WithPolicy<T1, T2, T3>(this CombinedResult<T1, T2, InnerConfiguredTableAnalysisRuleFactory, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfiguredTableAnalysisRuleFactory, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory> WithPolicy<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConfiguredTableAnalysisRuleFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConfiguredTableAnalysisRuleFactory, T1, T2, T3, T4, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory> WithPolicy<T1, T2, T3, T4>(this CombinedResult<InnerConfiguredTableAnalysisRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfiguredTableAnalysisRuleFactory, T2, T3, T4, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory> WithPolicy<T1, T2, T3, T4>(this CombinedResult<T1, InnerConfiguredTableAnalysisRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfiguredTableAnalysisRuleFactory, T3, T4, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory> WithPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConfiguredTableAnalysisRuleFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfiguredTableAnalysisRuleFactory, T4, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory> WithPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConfiguredTableAnalysisRuleFactory, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConfiguredTableAnalysisRuleFactory, InnerConfiguredTableConfiguredTableAnalysisRulePolicyFactory> WithPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConfiguredTableAnalysisRuleFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.ConfiguredTableAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T5, subFactoryAction));
}
