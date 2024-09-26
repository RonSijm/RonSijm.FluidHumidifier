// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class RuleGroupFactory(string resourceName = null, Action<Humidifier.WAFv2.RuleGroup> factoryAction = null) : ResourceFactory<Humidifier.WAFv2.RuleGroup>(resourceName)
{

    internal List<InnerRuleGroupLabelSummaryFactory> AvailableLabelsFactories { get; set; } = [];

    internal List<InnerRuleGroupLabelSummaryFactory> ConsumedLabelsFactories { get; set; } = [];

    internal List<InnerRuleGroupRuleFactory> RulesFactories { get; set; } = [];

    internal InnerRuleGroupVisibilityConfigFactory VisibilityConfigFactory { get; set; }

    protected override Humidifier.WAFv2.RuleGroup Create()
    {
        var ruleGroupResult = CreateRuleGroup();
        factoryAction?.Invoke(ruleGroupResult);

        return ruleGroupResult;
    }

    private Humidifier.WAFv2.RuleGroup CreateRuleGroup()
    {
        var ruleGroupResult = new Humidifier.WAFv2.RuleGroup
        {
            GivenName = InputResourceName,
        };

        return ruleGroupResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.RuleGroup result)
    {
        base.CreateChildren(result);

        result.AvailableLabels = AvailableLabelsFactories.Any() ? AvailableLabelsFactories.Select(x => x.Build()).ToList() : null;
        result.ConsumedLabels = ConsumedLabelsFactories.Any() ? ConsumedLabelsFactories.Select(x => x.Build()).ToList() : null;
        result.Rules = RulesFactories.Any() ? RulesFactories.Select(x => x.Build()).ToList() : null;
        result.VisibilityConfig ??= VisibilityConfigFactory?.Build();
    }

} // End Of Class

public static class RuleGroupFactoryExtensions
{
    public static CombinedResult<RuleGroupFactory, InnerRuleGroupLabelSummaryFactory> WithAvailableLabels(this RuleGroupFactory parentFactory, Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> subFactoryAction = null)
    {
        var factory = new InnerRuleGroupLabelSummaryFactory(subFactoryAction);
        parentFactory.AvailableLabelsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<RuleGroupFactory, InnerRuleGroupLabelSummaryFactory> WithConsumedLabels(this RuleGroupFactory parentFactory, Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> subFactoryAction = null)
    {
        var factory = new InnerRuleGroupLabelSummaryFactory(subFactoryAction);
        parentFactory.ConsumedLabelsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<RuleGroupFactory, InnerRuleGroupRuleFactory> WithRules(this RuleGroupFactory parentFactory, Action<Humidifier.WAFv2.RuleGroupTypes.Rule> subFactoryAction = null)
    {
        var factory = new InnerRuleGroupRuleFactory(subFactoryAction);
        parentFactory.RulesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<RuleGroupFactory, InnerRuleGroupVisibilityConfigFactory> WithVisibilityConfig(this RuleGroupFactory parentFactory, Action<Humidifier.WAFv2.RuleGroupTypes.VisibilityConfig> subFactoryAction = null)
    {
        parentFactory.VisibilityConfigFactory = new InnerRuleGroupVisibilityConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VisibilityConfigFactory);
    }

    public static CombinedResult<RuleGroupFactory, T1, InnerRuleGroupLabelSummaryFactory> WithAvailableLabels<T1>(this CombinedResult<RuleGroupFactory, T1> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> subFactoryAction = null) => new (combinedResult, combinedResult, WithAvailableLabels(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleGroupFactory, InnerRuleGroupLabelSummaryFactory> WithAvailableLabels<T1>(this CombinedResult<T1, RuleGroupFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> subFactoryAction = null) => new (combinedResult, combinedResult, WithAvailableLabels(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RuleGroupFactory, T1, T2, InnerRuleGroupLabelSummaryFactory> WithAvailableLabels<T1, T2>(this CombinedResult<RuleGroupFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAvailableLabels(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleGroupFactory, T2, InnerRuleGroupLabelSummaryFactory> WithAvailableLabels<T1, T2>(this CombinedResult<T1, RuleGroupFactory, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAvailableLabels(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleGroupFactory, InnerRuleGroupLabelSummaryFactory> WithAvailableLabels<T1, T2>(this CombinedResult<T1, T2, RuleGroupFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAvailableLabels(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RuleGroupFactory, T1, T2, T3, InnerRuleGroupLabelSummaryFactory> WithAvailableLabels<T1, T2, T3>(this CombinedResult<RuleGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAvailableLabels(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleGroupFactory, T2, T3, InnerRuleGroupLabelSummaryFactory> WithAvailableLabels<T1, T2, T3>(this CombinedResult<T1, RuleGroupFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAvailableLabels(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleGroupFactory, T3, InnerRuleGroupLabelSummaryFactory> WithAvailableLabels<T1, T2, T3>(this CombinedResult<T1, T2, RuleGroupFactory, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAvailableLabels(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RuleGroupFactory, InnerRuleGroupLabelSummaryFactory> WithAvailableLabels<T1, T2, T3>(this CombinedResult<T1, T2, T3, RuleGroupFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAvailableLabels(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RuleGroupFactory, T1, T2, T3, T4, InnerRuleGroupLabelSummaryFactory> WithAvailableLabels<T1, T2, T3, T4>(this CombinedResult<RuleGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAvailableLabels(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleGroupFactory, T2, T3, T4, InnerRuleGroupLabelSummaryFactory> WithAvailableLabels<T1, T2, T3, T4>(this CombinedResult<T1, RuleGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAvailableLabels(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleGroupFactory, T3, T4, InnerRuleGroupLabelSummaryFactory> WithAvailableLabels<T1, T2, T3, T4>(this CombinedResult<T1, T2, RuleGroupFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAvailableLabels(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RuleGroupFactory, T4, InnerRuleGroupLabelSummaryFactory> WithAvailableLabels<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RuleGroupFactory, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAvailableLabels(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RuleGroupFactory, InnerRuleGroupLabelSummaryFactory> WithAvailableLabels<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RuleGroupFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAvailableLabels(combinedResult.T5, subFactoryAction));
    public static CombinedResult<RuleGroupFactory, T1, InnerRuleGroupLabelSummaryFactory> WithConsumedLabels<T1>(this CombinedResult<RuleGroupFactory, T1> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> subFactoryAction = null) => new (combinedResult, combinedResult, WithConsumedLabels(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleGroupFactory, InnerRuleGroupLabelSummaryFactory> WithConsumedLabels<T1>(this CombinedResult<T1, RuleGroupFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> subFactoryAction = null) => new (combinedResult, combinedResult, WithConsumedLabels(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RuleGroupFactory, T1, T2, InnerRuleGroupLabelSummaryFactory> WithConsumedLabels<T1, T2>(this CombinedResult<RuleGroupFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConsumedLabels(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleGroupFactory, T2, InnerRuleGroupLabelSummaryFactory> WithConsumedLabels<T1, T2>(this CombinedResult<T1, RuleGroupFactory, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConsumedLabels(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleGroupFactory, InnerRuleGroupLabelSummaryFactory> WithConsumedLabels<T1, T2>(this CombinedResult<T1, T2, RuleGroupFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConsumedLabels(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RuleGroupFactory, T1, T2, T3, InnerRuleGroupLabelSummaryFactory> WithConsumedLabels<T1, T2, T3>(this CombinedResult<RuleGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConsumedLabels(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleGroupFactory, T2, T3, InnerRuleGroupLabelSummaryFactory> WithConsumedLabels<T1, T2, T3>(this CombinedResult<T1, RuleGroupFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConsumedLabels(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleGroupFactory, T3, InnerRuleGroupLabelSummaryFactory> WithConsumedLabels<T1, T2, T3>(this CombinedResult<T1, T2, RuleGroupFactory, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConsumedLabels(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RuleGroupFactory, InnerRuleGroupLabelSummaryFactory> WithConsumedLabels<T1, T2, T3>(this CombinedResult<T1, T2, T3, RuleGroupFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConsumedLabels(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RuleGroupFactory, T1, T2, T3, T4, InnerRuleGroupLabelSummaryFactory> WithConsumedLabels<T1, T2, T3, T4>(this CombinedResult<RuleGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConsumedLabels(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleGroupFactory, T2, T3, T4, InnerRuleGroupLabelSummaryFactory> WithConsumedLabels<T1, T2, T3, T4>(this CombinedResult<T1, RuleGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConsumedLabels(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleGroupFactory, T3, T4, InnerRuleGroupLabelSummaryFactory> WithConsumedLabels<T1, T2, T3, T4>(this CombinedResult<T1, T2, RuleGroupFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConsumedLabels(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RuleGroupFactory, T4, InnerRuleGroupLabelSummaryFactory> WithConsumedLabels<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RuleGroupFactory, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConsumedLabels(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RuleGroupFactory, InnerRuleGroupLabelSummaryFactory> WithConsumedLabels<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RuleGroupFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConsumedLabels(combinedResult.T5, subFactoryAction));
    public static CombinedResult<RuleGroupFactory, T1, InnerRuleGroupRuleFactory> WithRules<T1>(this CombinedResult<RuleGroupFactory, T1> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleGroupFactory, InnerRuleGroupRuleFactory> WithRules<T1>(this CombinedResult<T1, RuleGroupFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RuleGroupFactory, T1, T2, InnerRuleGroupRuleFactory> WithRules<T1, T2>(this CombinedResult<RuleGroupFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleGroupFactory, T2, InnerRuleGroupRuleFactory> WithRules<T1, T2>(this CombinedResult<T1, RuleGroupFactory, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleGroupFactory, InnerRuleGroupRuleFactory> WithRules<T1, T2>(this CombinedResult<T1, T2, RuleGroupFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RuleGroupFactory, T1, T2, T3, InnerRuleGroupRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<RuleGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleGroupFactory, T2, T3, InnerRuleGroupRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, RuleGroupFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleGroupFactory, T3, InnerRuleGroupRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, T2, RuleGroupFactory, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RuleGroupFactory, InnerRuleGroupRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, T2, T3, RuleGroupFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RuleGroupFactory, T1, T2, T3, T4, InnerRuleGroupRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<RuleGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleGroupFactory, T2, T3, T4, InnerRuleGroupRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, RuleGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleGroupFactory, T3, T4, InnerRuleGroupRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, RuleGroupFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RuleGroupFactory, T4, InnerRuleGroupRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RuleGroupFactory, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RuleGroupFactory, InnerRuleGroupRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RuleGroupFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T5, subFactoryAction));
    public static CombinedResult<RuleGroupFactory, T1, InnerRuleGroupVisibilityConfigFactory> WithVisibilityConfig<T1>(this CombinedResult<RuleGroupFactory, T1> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.VisibilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVisibilityConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleGroupFactory, InnerRuleGroupVisibilityConfigFactory> WithVisibilityConfig<T1>(this CombinedResult<T1, RuleGroupFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.VisibilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVisibilityConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RuleGroupFactory, T1, T2, InnerRuleGroupVisibilityConfigFactory> WithVisibilityConfig<T1, T2>(this CombinedResult<RuleGroupFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.VisibilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVisibilityConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleGroupFactory, T2, InnerRuleGroupVisibilityConfigFactory> WithVisibilityConfig<T1, T2>(this CombinedResult<T1, RuleGroupFactory, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.VisibilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVisibilityConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleGroupFactory, InnerRuleGroupVisibilityConfigFactory> WithVisibilityConfig<T1, T2>(this CombinedResult<T1, T2, RuleGroupFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.VisibilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVisibilityConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RuleGroupFactory, T1, T2, T3, InnerRuleGroupVisibilityConfigFactory> WithVisibilityConfig<T1, T2, T3>(this CombinedResult<RuleGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.VisibilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVisibilityConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleGroupFactory, T2, T3, InnerRuleGroupVisibilityConfigFactory> WithVisibilityConfig<T1, T2, T3>(this CombinedResult<T1, RuleGroupFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.VisibilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVisibilityConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleGroupFactory, T3, InnerRuleGroupVisibilityConfigFactory> WithVisibilityConfig<T1, T2, T3>(this CombinedResult<T1, T2, RuleGroupFactory, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.VisibilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVisibilityConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RuleGroupFactory, InnerRuleGroupVisibilityConfigFactory> WithVisibilityConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, RuleGroupFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.VisibilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVisibilityConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RuleGroupFactory, T1, T2, T3, T4, InnerRuleGroupVisibilityConfigFactory> WithVisibilityConfig<T1, T2, T3, T4>(this CombinedResult<RuleGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.VisibilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVisibilityConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleGroupFactory, T2, T3, T4, InnerRuleGroupVisibilityConfigFactory> WithVisibilityConfig<T1, T2, T3, T4>(this CombinedResult<T1, RuleGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.VisibilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVisibilityConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleGroupFactory, T3, T4, InnerRuleGroupVisibilityConfigFactory> WithVisibilityConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, RuleGroupFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.VisibilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVisibilityConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RuleGroupFactory, T4, InnerRuleGroupVisibilityConfigFactory> WithVisibilityConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RuleGroupFactory, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.VisibilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVisibilityConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RuleGroupFactory, InnerRuleGroupVisibilityConfigFactory> WithVisibilityConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RuleGroupFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.VisibilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVisibilityConfig(combinedResult.T5, subFactoryAction));
}
