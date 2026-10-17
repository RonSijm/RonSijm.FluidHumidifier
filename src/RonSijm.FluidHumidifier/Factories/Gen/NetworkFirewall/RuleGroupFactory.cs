// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class RuleGroupFactory(string resourceName = null, Action<Humidifier.NetworkFirewall.RuleGroup> factoryAction = null) : ResourceFactory<Humidifier.NetworkFirewall.RuleGroup>(resourceName)
{

    internal InnerRuleGroupSummaryConfigurationFactory SummaryConfigurationFactory { get; set; }

    internal InnerRuleGroupRuleGroupFactory RuleGroup_Factory { get; set; }

    protected override Humidifier.NetworkFirewall.RuleGroup Create()
    {
        var ruleGroupResult = CreateRuleGroup();
        factoryAction?.Invoke(ruleGroupResult);

        return ruleGroupResult;
    }

    private Humidifier.NetworkFirewall.RuleGroup CreateRuleGroup()
    {
        var ruleGroupResult = new Humidifier.NetworkFirewall.RuleGroup
        {
            GivenName = InputResourceName,
        };

        return ruleGroupResult;
    }
    public override void CreateChildren(Humidifier.NetworkFirewall.RuleGroup result)
    {
        base.CreateChildren(result);

        result.SummaryConfiguration ??= SummaryConfigurationFactory?.Build();
        result.RuleGroup_ ??= RuleGroup_Factory?.Build();
    }

} // End Of Class

public static class RuleGroupFactoryExtensions
{
    public static CombinedResult<RuleGroupFactory, InnerRuleGroupSummaryConfigurationFactory> WithSummaryConfiguration(this RuleGroupFactory parentFactory, Action<Humidifier.NetworkFirewall.RuleGroupTypes.SummaryConfiguration> subFactoryAction = null)
    {
        parentFactory.SummaryConfigurationFactory = new InnerRuleGroupSummaryConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SummaryConfigurationFactory);
    }

    public static CombinedResult<RuleGroupFactory, InnerRuleGroupRuleGroupFactory> WithRuleGroup_(this RuleGroupFactory parentFactory, Action<Humidifier.NetworkFirewall.RuleGroupTypes.RuleGroup> subFactoryAction = null)
    {
        parentFactory.RuleGroup_Factory = new InnerRuleGroupRuleGroupFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RuleGroup_Factory);
    }

    public static CombinedResult<RuleGroupFactory, T1, InnerRuleGroupSummaryConfigurationFactory> WithSummaryConfiguration<T1>(this CombinedResult<RuleGroupFactory, T1> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.SummaryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSummaryConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RuleGroupFactory, InnerRuleGroupSummaryConfigurationFactory> WithSummaryConfiguration<T1>(this CombinedResult<T1, RuleGroupFactory> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.SummaryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSummaryConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<RuleGroupFactory, T1, T2, InnerRuleGroupSummaryConfigurationFactory> WithSummaryConfiguration<T1, T2>(this CombinedResult<RuleGroupFactory, T1, T2> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.SummaryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSummaryConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RuleGroupFactory, T2, InnerRuleGroupSummaryConfigurationFactory> WithSummaryConfiguration<T1, T2>(this CombinedResult<T1, RuleGroupFactory, T2> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.SummaryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSummaryConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RuleGroupFactory, InnerRuleGroupSummaryConfigurationFactory> WithSummaryConfiguration<T1, T2>(this CombinedResult<T1, T2, RuleGroupFactory> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.SummaryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSummaryConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<RuleGroupFactory, T1, T2, T3, InnerRuleGroupSummaryConfigurationFactory> WithSummaryConfiguration<T1, T2, T3>(this CombinedResult<RuleGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.SummaryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSummaryConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RuleGroupFactory, T2, T3, InnerRuleGroupSummaryConfigurationFactory> WithSummaryConfiguration<T1, T2, T3>(this CombinedResult<T1, RuleGroupFactory, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.SummaryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSummaryConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RuleGroupFactory, T3, InnerRuleGroupSummaryConfigurationFactory> WithSummaryConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, RuleGroupFactory, T3> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.SummaryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSummaryConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, RuleGroupFactory, InnerRuleGroupSummaryConfigurationFactory> WithSummaryConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, RuleGroupFactory> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.SummaryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSummaryConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<RuleGroupFactory, T1, T2, T3, T4, InnerRuleGroupSummaryConfigurationFactory> WithSummaryConfiguration<T1, T2, T3, T4>(this CombinedResult<RuleGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.SummaryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSummaryConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RuleGroupFactory, T2, T3, T4, InnerRuleGroupSummaryConfigurationFactory> WithSummaryConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, RuleGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.SummaryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSummaryConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RuleGroupFactory, T3, T4, InnerRuleGroupSummaryConfigurationFactory> WithSummaryConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, RuleGroupFactory, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.SummaryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSummaryConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, RuleGroupFactory, T4, InnerRuleGroupSummaryConfigurationFactory> WithSummaryConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RuleGroupFactory, T4> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.SummaryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSummaryConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, RuleGroupFactory, InnerRuleGroupSummaryConfigurationFactory> WithSummaryConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RuleGroupFactory> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.SummaryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSummaryConfiguration(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<RuleGroupFactory, T1, InnerRuleGroupRuleGroupFactory> WithRuleGroup_<T1>(this CombinedResult<RuleGroupFactory, T1> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.RuleGroup> subFactoryAction = null) => new (combinedResult, combinedResult, WithRuleGroup_(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RuleGroupFactory, InnerRuleGroupRuleGroupFactory> WithRuleGroup_<T1>(this CombinedResult<T1, RuleGroupFactory> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.RuleGroup> subFactoryAction = null) => new (combinedResult, combinedResult, WithRuleGroup_(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<RuleGroupFactory, T1, T2, InnerRuleGroupRuleGroupFactory> WithRuleGroup_<T1, T2>(this CombinedResult<RuleGroupFactory, T1, T2> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.RuleGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuleGroup_(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RuleGroupFactory, T2, InnerRuleGroupRuleGroupFactory> WithRuleGroup_<T1, T2>(this CombinedResult<T1, RuleGroupFactory, T2> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.RuleGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuleGroup_(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RuleGroupFactory, InnerRuleGroupRuleGroupFactory> WithRuleGroup_<T1, T2>(this CombinedResult<T1, T2, RuleGroupFactory> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.RuleGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuleGroup_(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<RuleGroupFactory, T1, T2, T3, InnerRuleGroupRuleGroupFactory> WithRuleGroup_<T1, T2, T3>(this CombinedResult<RuleGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.RuleGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuleGroup_(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RuleGroupFactory, T2, T3, InnerRuleGroupRuleGroupFactory> WithRuleGroup_<T1, T2, T3>(this CombinedResult<T1, RuleGroupFactory, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.RuleGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuleGroup_(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RuleGroupFactory, T3, InnerRuleGroupRuleGroupFactory> WithRuleGroup_<T1, T2, T3>(this CombinedResult<T1, T2, RuleGroupFactory, T3> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.RuleGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuleGroup_(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, RuleGroupFactory, InnerRuleGroupRuleGroupFactory> WithRuleGroup_<T1, T2, T3>(this CombinedResult<T1, T2, T3, RuleGroupFactory> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.RuleGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuleGroup_(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<RuleGroupFactory, T1, T2, T3, T4, InnerRuleGroupRuleGroupFactory> WithRuleGroup_<T1, T2, T3, T4>(this CombinedResult<RuleGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.RuleGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuleGroup_(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RuleGroupFactory, T2, T3, T4, InnerRuleGroupRuleGroupFactory> WithRuleGroup_<T1, T2, T3, T4>(this CombinedResult<T1, RuleGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.RuleGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuleGroup_(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RuleGroupFactory, T3, T4, InnerRuleGroupRuleGroupFactory> WithRuleGroup_<T1, T2, T3, T4>(this CombinedResult<T1, T2, RuleGroupFactory, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.RuleGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuleGroup_(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, RuleGroupFactory, T4, InnerRuleGroupRuleGroupFactory> WithRuleGroup_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RuleGroupFactory, T4> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.RuleGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuleGroup_(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, RuleGroupFactory, InnerRuleGroupRuleGroupFactory> WithRuleGroup_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RuleGroupFactory> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.RuleGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuleGroup_(combinedResult.T5, subFactoryAction).T2);
}
