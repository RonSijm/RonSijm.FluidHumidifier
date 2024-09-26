// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory(Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRule> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRule>
{

    internal InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory PolicyFactory { get; set; }

    protected override Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRule Create()
    {
        var configuredTableAssociationAnalysisRuleResult = CreateConfiguredTableAssociationAnalysisRule();
        factoryAction?.Invoke(configuredTableAssociationAnalysisRuleResult);

        return configuredTableAssociationAnalysisRuleResult;
    }

    private Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRule CreateConfiguredTableAssociationAnalysisRule()
    {
        var configuredTableAssociationAnalysisRuleResult = new Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRule();

        return configuredTableAssociationAnalysisRuleResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRule result)
    {
        base.CreateChildren(result);

        result.Policy ??= PolicyFactory?.Build();
    }

} // End Of Class

public static class InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactoryExtensions
{
    public static CombinedResult<InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory> WithPolicy(this InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory parentFactory, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicy> subFactoryAction = null)
    {
        parentFactory.PolicyFactory = new InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PolicyFactory);
    }

    public static CombinedResult<InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory, T1, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory> WithPolicy<T1>(this CombinedResult<InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory, T1> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory> WithPolicy<T1>(this CombinedResult<T1, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory, T1, T2, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory> WithPolicy<T1, T2>(this CombinedResult<InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory, T2, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory> WithPolicy<T1, T2>(this CombinedResult<T1, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory, T2> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory> WithPolicy<T1, T2>(this CombinedResult<T1, T2, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory, T1, T2, T3, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory> WithPolicy<T1, T2, T3>(this CombinedResult<InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory, T2, T3, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory> WithPolicy<T1, T2, T3>(this CombinedResult<T1, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory, T3, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory> WithPolicy<T1, T2, T3>(this CombinedResult<T1, T2, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory> WithPolicy<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory, T1, T2, T3, T4, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory> WithPolicy<T1, T2, T3, T4>(this CombinedResult<InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory, T2, T3, T4, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory> WithPolicy<T1, T2, T3, T4>(this CombinedResult<T1, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory, T3, T4, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory> WithPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory, T4, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory> WithPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRulePolicyFactory> WithPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRulePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T5, subFactoryAction));
}
