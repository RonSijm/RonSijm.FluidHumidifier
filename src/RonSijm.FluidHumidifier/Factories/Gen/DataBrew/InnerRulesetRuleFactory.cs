// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerRulesetRuleFactory(Action<Humidifier.DataBrew.RulesetTypes.Rule> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.RulesetTypes.Rule>
{

    internal InnerRulesetThresholdFactory ThresholdFactory { get; set; }

    protected override Humidifier.DataBrew.RulesetTypes.Rule Create()
    {
        var ruleResult = CreateRule();
        factoryAction?.Invoke(ruleResult);

        return ruleResult;
    }

    private Humidifier.DataBrew.RulesetTypes.Rule CreateRule()
    {
        var ruleResult = new Humidifier.DataBrew.RulesetTypes.Rule();

        return ruleResult;
    }
    public override void CreateChildren(Humidifier.DataBrew.RulesetTypes.Rule result)
    {
        base.CreateChildren(result);

        result.Threshold ??= ThresholdFactory?.Build();
    }

} // End Of Class

public static class InnerRulesetRuleFactoryExtensions
{
    public static CombinedResult<InnerRulesetRuleFactory, InnerRulesetThresholdFactory> WithThreshold(this InnerRulesetRuleFactory parentFactory, Action<Humidifier.DataBrew.RulesetTypes.Threshold> subFactoryAction = null)
    {
        parentFactory.ThresholdFactory = new InnerRulesetThresholdFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ThresholdFactory);
    }

    public static CombinedResult<InnerRulesetRuleFactory, T1, InnerRulesetThresholdFactory> WithThreshold<T1>(this CombinedResult<InnerRulesetRuleFactory, T1> combinedResult, Action<Humidifier.DataBrew.RulesetTypes.Threshold> subFactoryAction = null) => new (combinedResult, combinedResult, WithThreshold(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRulesetRuleFactory, InnerRulesetThresholdFactory> WithThreshold<T1>(this CombinedResult<T1, InnerRulesetRuleFactory> combinedResult, Action<Humidifier.DataBrew.RulesetTypes.Threshold> subFactoryAction = null) => new (combinedResult, combinedResult, WithThreshold(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRulesetRuleFactory, T1, T2, InnerRulesetThresholdFactory> WithThreshold<T1, T2>(this CombinedResult<InnerRulesetRuleFactory, T1, T2> combinedResult, Action<Humidifier.DataBrew.RulesetTypes.Threshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithThreshold(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRulesetRuleFactory, T2, InnerRulesetThresholdFactory> WithThreshold<T1, T2>(this CombinedResult<T1, InnerRulesetRuleFactory, T2> combinedResult, Action<Humidifier.DataBrew.RulesetTypes.Threshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithThreshold(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRulesetRuleFactory, InnerRulesetThresholdFactory> WithThreshold<T1, T2>(this CombinedResult<T1, T2, InnerRulesetRuleFactory> combinedResult, Action<Humidifier.DataBrew.RulesetTypes.Threshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithThreshold(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRulesetRuleFactory, T1, T2, T3, InnerRulesetThresholdFactory> WithThreshold<T1, T2, T3>(this CombinedResult<InnerRulesetRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataBrew.RulesetTypes.Threshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithThreshold(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRulesetRuleFactory, T2, T3, InnerRulesetThresholdFactory> WithThreshold<T1, T2, T3>(this CombinedResult<T1, InnerRulesetRuleFactory, T2, T3> combinedResult, Action<Humidifier.DataBrew.RulesetTypes.Threshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithThreshold(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRulesetRuleFactory, T3, InnerRulesetThresholdFactory> WithThreshold<T1, T2, T3>(this CombinedResult<T1, T2, InnerRulesetRuleFactory, T3> combinedResult, Action<Humidifier.DataBrew.RulesetTypes.Threshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithThreshold(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRulesetRuleFactory, InnerRulesetThresholdFactory> WithThreshold<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRulesetRuleFactory> combinedResult, Action<Humidifier.DataBrew.RulesetTypes.Threshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithThreshold(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRulesetRuleFactory, T1, T2, T3, T4, InnerRulesetThresholdFactory> WithThreshold<T1, T2, T3, T4>(this CombinedResult<InnerRulesetRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.RulesetTypes.Threshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithThreshold(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRulesetRuleFactory, T2, T3, T4, InnerRulesetThresholdFactory> WithThreshold<T1, T2, T3, T4>(this CombinedResult<T1, InnerRulesetRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.RulesetTypes.Threshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithThreshold(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRulesetRuleFactory, T3, T4, InnerRulesetThresholdFactory> WithThreshold<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRulesetRuleFactory, T3, T4> combinedResult, Action<Humidifier.DataBrew.RulesetTypes.Threshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithThreshold(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRulesetRuleFactory, T4, InnerRulesetThresholdFactory> WithThreshold<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRulesetRuleFactory, T4> combinedResult, Action<Humidifier.DataBrew.RulesetTypes.Threshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithThreshold(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRulesetRuleFactory, InnerRulesetThresholdFactory> WithThreshold<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRulesetRuleFactory> combinedResult, Action<Humidifier.DataBrew.RulesetTypes.Threshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithThreshold(combinedResult.T5, subFactoryAction));
}
